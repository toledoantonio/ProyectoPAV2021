using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BankApp.Clases;
using System.Windows.Forms;

namespace BankApp.Negocios
{
    class NE_Canjes
    {
        public string fecha { get; set; }
        public string id_usuario { get; set; }
        public string codigo_premio { get; set; }
        public string puntos_usados { get; set; }

        BE_Acceso_Datos _BD = new BE_Acceso_Datos();
        TratamientosEspeciales _TE = new TratamientosEspeciales();

        public DataTable RecuperarUltimoCanje()
        {
            string sql = "SELECT TOP 1 id, CONVERT(VARCHAR(10), fecha, 105), id_usuario, codigo_premio, puntos_usados FROM Canjes ORDER BY id DESC";
            return _BD.EjecutarSelect(sql);
        }

        public void CanjearPremio(string numero_cuenta,string puntos_restantes,string stock_restante)
        {
            string sqlInsertCanje = "INSERT INTO Canjes VALUES (";
            sqlInsertCanje += _TE.FormatearDato(fecha,"fecha");
            sqlInsertCanje += ", " + id_usuario;
            sqlInsertCanje += ", " + codigo_premio;
            sqlInsertCanje += ", " + puntos_usados;
            sqlInsertCanje += ")";

            _BD.IniciarTransaccion();
            _BD.Insertar(sqlInsertCanje, BE_Acceso_Datos.RecuperacionPk.no_recuperar);

            string sqlModificarCuenta = "UPDATE Cuentas SET ";
            sqlModificarCuenta += "puntos_total = " + puntos_restantes + " WHERE numero = " + numero_cuenta;
            _BD.Modificar(sqlModificarCuenta);

            string sqlModificarPremio = "UPDATE Premios SET ";
            sqlModificarPremio += "stock = " + stock_restante;
            sqlModificarPremio += "WHERE codigo = " + codigo_premio;
            _BD.Modificar(sqlModificarPremio);

            if (_BD.CerrarTransaccion() == BE_Acceso_Datos.EstadoTransaccion.correcto)
            {
                MessageBox.Show("Se grabó correctamente el canje del premio");
            }
            else
            {
                MessageBox.Show("No se grabó el canje del premio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }


        }

        public DataTable Reporte_Canjes(string id_usuario, string fecha_desde, string fecha_hasta)
        {
            string sql = @"SELECT  u.nombre_usuario, p.descripcion, c.puntos_usados, c.fecha FROM Canjes c
                            JOIN Usuarios u ON c.id_usuario = u.id
                            JOIN Premios p ON c.codigo_premio = p.codigo 
                            WHERE 1=1";

            if (id_usuario != "")
                sql += " AND id_usuario = " + id_usuario;
            if (fecha_desde != "  /  /")
                sql += " AND fecha >= " + _TE.FormatearDato(fecha_desde, "fecha");
            if (fecha_hasta != "  /  /")
                sql += " AND fecha <= " + _TE.FormatearDato(fecha_hasta, "fecha");
            sql += " ORDER BY fecha";

            return _BD.EjecutarSelect(sql);                        
        }

        public DataTable Estadistica_Canje(string anno, string mes_desde, string mes_hasta)
        {
            string sql = @"SELECT convert(char(4), year(fecha)) + '/' + convert(char(2), month(fecha)) descripcion
                            , count(*) cuantos_canjes
                            , sum(puntos_usados) puntos_totales
                            FROM Canjes
                            WHERE year(fecha) = " + anno + " AND month(fecha) between " + mes_desde + " AND " + mes_hasta
                            + "group by year(fecha), month(fecha)";

            return _BD.EjecutarSelect(sql);
        }

        public DataTable Estadistica2_Canje(string anno, string mes)
        {
            string sql = @"SELECT tp.nombre, count(*) cuantos_canjes FROM Canjes c
                        JOIN Premios p ON c.codigo_premio = p.codigo
                        JOIN Tipo_Premio tp ON p.id_tipo_premio = tp.id
                        WHERE year(c.fecha) = " + anno + " AND month(c.fecha) = " + mes
                        + "group by tp.nombre";
            
            return _BD.EjecutarSelect(sql);
        }
    }
}
