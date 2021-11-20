using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankApp.Clases;
using System.Data;

namespace BankApp.Negocios
{
    class NE_Monedas
    {
        public enum Validacion { correcta, incorrecta }

        public string id { get; set; }
        public string nombre { get; set; }
        public string simbolo { get; set; }
        
        BE_Acceso_Datos _BD = new BE_Acceso_Datos();

        public DataTable BuscarMoneda(string id)
        {
            string sql = "SELECT * FROM Monedas WHERE id = " + id;
            return _BD.EjecutarSelect(sql);
        }
        public DataTable BuscarMoneda_Nombre(string nombre)
        {
            string sql = "SELECT * FROM Monedas WHERE nombre like '%" + nombre+"%'";
            return _BD.EjecutarSelect(sql);
        }
        public DataTable BuscarMonedasTodas()
        {
            string sql = @"SELECT * 
                          FROM Monedas";

            return _BD.EjecutarSelect(sql);
        }
        public string Insertar()
        {
            string sqlInsert = "";

            sqlInsert = "INSERT INTO monedas (nombre,simbolo) VALUES (";
            sqlInsert += "'" + nombre + "'";
            sqlInsert += ", '" + simbolo + "')";

            return _BD.Insertar(sqlInsert, BE_Acceso_Datos.RecuperacionPk.recuperar);
        }

        public void Modificar()
        {
            string sqlModificar = "";

            sqlModificar = "UPDATE monedas SET ";
            sqlModificar += "nombre = '" + nombre + "'";
            sqlModificar += ",simbolo = '" + simbolo + "'";
            sqlModificar += " WHERE id = " + id;

            _BD.Modificar(sqlModificar);
        }

        public void Borrar()
        {
            string sqlBorrar = "DELETE FROM monedas WHERE id = " + id;
            _BD.Borrar(sqlBorrar);
        }
    }
}
