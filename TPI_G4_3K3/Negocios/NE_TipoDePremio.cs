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
    class NE_TipoDePremio
    {
        public enum Validacion { correcta, incorrecta }

        public string id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }


        BE_Acceso_Datos _BD = new BE_Acceso_Datos();

        public DataTable BuscarTipoPremioNombre(string nombre)
        {
            string sql = @"SELECT id, nombre, descripcion 
                          FROM Tipo_Premio WHERE nombre LIKE '%" + nombre + "%'";

            return _BD.EjecutarSelect(sql);
        }
        public DataTable BuscarTipoDePremiosTodos()
        {
            string sql = @"SELECT * 
                          FROM Tipo_Premio";

            return _BD.EjecutarSelect(sql);
        }
        public DataTable BuscarTipoPremioId(string id)
        {
            string sql = @"SELECT id, nombre, descripcion 
                          FROM Tipo_Premio WHERE id = " + id;

            return _BD.EjecutarSelect(sql);
        }

        public DataTable RecuperarTipoPremio(string id)
        {
            string sql = @"SELECT * 
                          FROM Tipo_Premio WHERE id = " + id;

            return _BD.EjecutarSelect(sql);
        }

        public string Insertar()
        {
            string sqlInsert = "";

            sqlInsert = @"INSERT INTO Tipo_Premio (id, nombre, descripcion) VALUES (";
            sqlInsert += "'" + nombre + "'";
            sqlInsert += ", '" + descripcion + "')";

            return _BD.Insertar(sqlInsert, BE_Acceso_Datos.RecuperacionPk.recuperar);
        }
        public string Insertar(Control.ControlCollection Controles)
        {
            TratamientosEspeciales _TE = new TratamientosEspeciales();
            return _BD.Insertar(_TE.SqlInsertAutomatico("Tipo_Premio", Controles), BE_Acceso_Datos.RecuperacionPk.recuperar);
        }
        public void Modificar()
        {
            string sqlModificar = "UPDATE Tipo_Premio SET ";
            sqlModificar += " nombre = '" + nombre + "'";
            sqlModificar += ", descripcion = '" + descripcion + "'";
            sqlModificar += " WHERE id = " + id;

            _BD.Modificar(sqlModificar);
        }
        public void Borrar()
        {
            string sqlBorrar = "DELETE FROM Tipo_Premio WHERE id = " + id;
            _BD.Borrar(sqlBorrar);
        }
        public void Borrar(string id)
        {
            string sqlBorrar = "DELETE FROM Tipo_Premio WHERE id = " + id;
            _BD.Borrar(sqlBorrar);
        }
    }
}
