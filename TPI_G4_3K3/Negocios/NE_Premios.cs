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
    class NE_Premios
    {
        public enum Validacion { correcta, incorrecta }

        public string codigo { get; set; }
        public string id_tipo_premio { get; set; }
        public string descripcion { get; set; }
        public string puntos_req_actual { get; set; }
        public string stock { get; set; }

        BE_Acceso_Datos _BD = new BE_Acceso_Datos();

        public DataTable BuscarPremio(string descripcion)
        {
            string sql = @"SELECT p.codigo, t.nombre, p.descripcion, p.stock, p.puntos_req_actual
                          FROM Premios p, Tipo_Premio t WHERE p.id_tipo_premio = t.id AND p.descripcion LIKE '%" + descripcion + "%'";

            return _BD.EjecutarSelect(sql);
        }
        public DataTable BuscarPremioCodigo(string codigo)
        {
            string sql = @"SELECT p.codigo, t.nombre, p.descripcion, p.stock, p.puntos_req_actual  
                          FROM Premios p, Tipo_Premio t WHERE p.id_tipo_premio = t.id AND p.codigo = " + codigo;

            return _BD.EjecutarSelect(sql);
        }
        public DataTable BuscarPremiosTodos()
        {
            string sql = @"SELECT p.codigo, t.nombre, p.descripcion, p.stock, p.puntos_req_actual  
                          FROM Premios p, Tipo_Premio t WHERE p.id_tipo_premio = t.id";

            return _BD.EjecutarSelect(sql);
        }
        public DataTable BuscarPremiosTodosCanje()
        {
            string sql = @"SELECT codigo,descripcion,puntos_req_actual,stock
                             FROM Premios";
            return _BD.EjecutarSelect(sql);
        }

        public DataTable RecuperarPremio(string codigo)
        {
            string sql = @"SELECT * 
                          FROM Premios WHERE codigo = " + codigo;

            return _BD.EjecutarSelect(sql);
        }
        public string Insertar()
        {
            string sqlInsert = "";

            sqlInsert = @"INSERT INTO Premios (id_tipo_premio, descripcion, puntos_req_actual, stock) VALUES (";
            sqlInsert += id_tipo_premio;
            sqlInsert += ", '" + descripcion + "'";
            sqlInsert += ", " + puntos_req_actual;
            sqlInsert += ", " + stock + ")";

            return _BD.Insertar(sqlInsert, BE_Acceso_Datos.RecuperacionPk.recuperar);
        }
        public string Insertar(Control.ControlCollection Controles)
        {
            TratamientosEspeciales _TE = new TratamientosEspeciales();
            return _BD.Insertar(_TE.SqlInsertAutomatico("Premios", Controles), BE_Acceso_Datos.RecuperacionPk.recuperar);
        }
        public void Modificar()
        {
            string sqlModificar = "UPDATE Premios SET ";
            sqlModificar += " id_tipo_premio = " + id_tipo_premio;
            sqlModificar += ", descripcion = '" + descripcion + "'";
            sqlModificar += ", puntos_req_actual = " + puntos_req_actual;
            sqlModificar += ", stock = " + stock;
            sqlModificar += " WHERE codigo = " + codigo;

            _BD.Modificar(sqlModificar);
        }
        public void Borrar()
        {
            string sqlBorrar = "DELETE FROM Premios WHERE codigo = " + codigo;
            _BD.Borrar(sqlBorrar);
        }
        public void Borrar(string codigo)
        {
            string sqlBorrar = "DELETE FROM Premios WHERE codigo = " + codigo;
            _BD.Borrar(sqlBorrar);
        }

        public DataTable Reporte_Premios(string id_tipo_premio, string puntos_min, string puntos_max)
        {
            string sql = @"SELECT p.codigo, tp.nombre, p.descripcion, p.puntos_req_actual, p.stock FROM Premios p
                            JOIN Tipo_Premio tp ON p.id_tipo_premio = tp.id
                            WHERE 1=1";

            if (id_tipo_premio != "")
                sql += " AND id_tipo_premio = " + id_tipo_premio;
            if (puntos_min != "")
                sql += " AND puntos_req_actual >= " + puntos_min;
            if (puntos_max != "")
                sql += " AND puntos_req_actual <= " + puntos_max;

            return _BD.EjecutarSelect(sql);
        }
    }
}
