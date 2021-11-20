using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankApp.Clases;
using System.Data;
using System.Windows.Forms;

namespace BankApp.Negocios
{
    class NE_Tarifas
    {
        public enum Validacion { correcta, incorrecta }

        public string id { get; set; }
        public string fecha_vig_desde { get; set; }
        public string fecha_vig_hasta { get; set; }
        public string monto_base { get; set; }
        public string monto_superior { get; set; }
        public string porcentaje { get; set; }

        BE_Acceso_Datos _BD = new BE_Acceso_Datos();

        public DataTable BuscarTarifasPatron(string patron, string patron2)
        {
            string sql = @"SELECT id, CONVERT(VARCHAR(10), fecha_vig_desde, 105), CONVERT(VARCHAR(10), fecha_vig_hasta, 105), monto_base, monto_superior, porcentaje 
                          FROM Tarifas WHERE fecha_vig_desde >= '" + patron + "' and fecha_vig_hasta <= '" + patron2 + "'";

            return _BD.EjecutarSelect(sql);
        }
        public DataTable BuscarTarifasID(string id)
        {
            string sql = @"SELECT id, CONVERT(VARCHAR(10), fecha_vig_desde, 105), CONVERT(VARCHAR(10), fecha_vig_hasta, 105), monto_base, monto_superior, porcentaje 
                          FROM Tarifas WHERE id = " + id;

            return _BD.EjecutarSelect(sql);
        }
        public DataTable RecuperarTarifas(string id)
        {
            string sql = @"SELECT * 
                          FROM Tarifas WHERE id = " + id;

            return _BD.EjecutarSelect(sql);
        }
        public DataTable BuscarTarifasTodos()
        {
            string sql = @"SELECT id, CONVERT(VARCHAR(10), fecha_vig_desde, 105), CONVERT(VARCHAR(10), fecha_vig_hasta, 105), monto_base, monto_superior, porcentaje 
                          FROM Tarifas";

            return _BD.EjecutarSelect(sql);
        }

        public DataTable BuscarTarifaTransferencia(string monto, string fecha)
        {
            monto = monto.Replace(",", ".");
            string sql = @"SELECT id , porcentaje FROM Tarifas WHERE " + monto + " BETWEEN monto_base AND monto_superior AND '" +
                          fecha + "' BETWEEN fecha_vig_desde AND fecha_vig_hasta";

            return _BD.EjecutarSelect(sql);
        }


        public string Insertar()
        {
            string sqlInsert = "";

            sqlInsert = @"INSERT INTO Tarifas (fecha_vig_desde, fecha_vig_hasta, monto_base, monto_superior, porcentaje) VALUES (";
            sqlInsert += "'" + fecha_vig_desde + "'";
            sqlInsert += ", '" + fecha_vig_hasta + "'";
            sqlInsert += ", " + monto_base;
            sqlInsert += ", " + monto_superior;
            sqlInsert += ", " + porcentaje + ")";

            return _BD.Insertar(sqlInsert, BE_Acceso_Datos.RecuperacionPk.recuperar);
        }
        public string Insertar(Control.ControlCollection Controles)
        {
            TratamientosEspeciales _TE = new TratamientosEspeciales();
            return _BD.Insertar(_TE.SqlInsertAutomatico("Tarifas", Controles), BE_Acceso_Datos.RecuperacionPk.recuperar);
        }
        public void Modificar()
        {
            string sqlModificar = "UPDATE Tarifas SET ";
            sqlModificar += " fecha_vig_desde = '" + fecha_vig_desde + "'";
            sqlModificar += ", fecha_vig_hasta = '" + fecha_vig_hasta + "'";
            sqlModificar += ", monto_base = " + monto_base;
            sqlModificar += ", monto_superior = " + monto_superior;
            sqlModificar += ", porcentaje = " + porcentaje;
            sqlModificar += " WHERE id = " + id;

            _BD.Modificar(sqlModificar);
        }
        public void Borrar()
        {
            string sqlBorrar = "DELETE FROM Tarifas WHERE id = " + id;
            _BD.Borrar(sqlBorrar);
        }
        public void Borrar(string id)
        {
            string sqlBorrar = "DELETE FROM Tarifas WHERE id = " + id;
            _BD.Borrar(sqlBorrar);
        }
    }
}
