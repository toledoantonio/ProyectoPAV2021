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
    class NE_Servicios
    {
        public enum Validacion { correcta, incorrecta }

        public string id { get; set; }
        public string nombre { get; set; }
        

        BE_Acceso_Datos _BD = new BE_Acceso_Datos();

        public DataTable BuscarServiciosxNombre(string nombre)
        {
            string sql = @"SELECT id, nombre 
                          FROM Servicios WHERE nombre LIKE '%" + nombre + "%'";

            return _BD.EjecutarSelect(sql);
        }
        public DataTable BuscarServiciosxID(string id)
        {
            string sql = @"SELECT id, nombre 
                          FROM Servicios WHERE id = " + id;

            return _BD.EjecutarSelect(sql);
        }

        public DataTable BuscarServiciosTodos()
        {
            string sql = @"SELECT * 
                          FROM Servicios";

            return _BD.EjecutarSelect(sql);
        }

        public DataTable RecuperarServicio(string id)
        {
            string sql = @"SELECT * 
                          FROM Servicios WHERE id = " + id;

            return _BD.EjecutarSelect(sql);
        }

        public string Insertar()
        {
            string sqlInsert = "";

            sqlInsert = @"INSERT INTO Servicios (nombre) VALUES (";
            sqlInsert += "'" + nombre + "')";
            

            return _BD.Insertar(sqlInsert, BE_Acceso_Datos.RecuperacionPk.recuperar);
        }
        public string Insertar(Control.ControlCollection Controles)
        {
            TratamientosEspeciales _TE = new TratamientosEspeciales();
            //MessageBox.Show(_TE.SqlInsertAutomatico("Servicios", Controles));
            //return "0";
            return _BD.Insertar(_TE.SqlInsertAutomatico("Servicios", Controles), BE_Acceso_Datos.RecuperacionPk.recuperar);
        }
        public void Modificar()
        {
            string sqlModificar = "UPDATE Servicios SET ";
            sqlModificar += " nombre = '" + nombre + "'";
            sqlModificar += " WHERE id = " + id;

            _BD.Modificar(sqlModificar);
        }
        public void Borrar()
        {
            string sqlBorrar = "DELETE FROM Servicios WHERE id = " + id;
            _BD.Borrar(sqlBorrar);
        }
        public void Borrar(string id)
        {
            string sqlBorrar = "DELETE FROM Usuarios WHERE id = " + id;
            _BD.Borrar(sqlBorrar);
        }
    }
}

