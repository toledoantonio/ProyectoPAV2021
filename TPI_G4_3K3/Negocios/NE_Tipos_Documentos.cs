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
    class NE_Tipos_Documentos
    {
        public enum Validacion { correcta, incorrecta }

        public string id { get; set; }
        public string descripcion { get; set; }


        BE_Acceso_Datos _BD = new BE_Acceso_Datos();

        public DataTable BuscarTipos_DocumentosDescripcion(string descripcion)
        {
            string sql = @"SELECT id, descripcion 
                          FROM Tipos_Documentos WHERE descripcion LIKE '%" + descripcion + "%'";

            return _BD.EjecutarSelect(sql);
        }
        public DataTable BuscarTipos_DocumentosID(string id)
        {
            string sql = @"SELECT id, descripcion 
                          FROM Tipos_Documentos WHERE id = " + id;

            return _BD.EjecutarSelect(sql);
        }
        public DataTable BuscarTipos_DocumentosTodos()
        {
            string sql = @"SELECT * 
                          FROM Tipos_Documentos";

            return _BD.EjecutarSelect(sql);
        }
        public DataTable RecuperarTipoDocumento(string id)
        {
            string sql = @"SELECT * 
                          FROM Tipos_Documentos WHERE id = " + id;

            return _BD.EjecutarSelect(sql);
        }
        public string Insertar()
        {
            string sqlInsert = "";

            sqlInsert = @"INSERT INTO Tipos_Documentos (id, descripcion) VALUES (";
            sqlInsert += "'" + descripcion + "')";


            return _BD.Insertar(sqlInsert, BE_Acceso_Datos.RecuperacionPk.recuperar);
        }
        public string Insertar(Control.ControlCollection Controles)
        {
            TratamientosEspeciales _TE = new TratamientosEspeciales();
            //MessageBox.Show(_TE.SqlInsertAutomatico("Tipos_Documentos", Controles));
            //return "0";
            return _BD.Insertar(_TE.SqlInsertAutomatico("Tipos_Documentos", Controles), BE_Acceso_Datos.RecuperacionPk.recuperar);
        }
        public void Modificar()
        {
            string sqlModificar = "UPDATE Tipos_Documentos SET ";
            sqlModificar += " descripcion = '" + descripcion + "'";
            sqlModificar += " WHERE id = " + id;

            _BD.Modificar(sqlModificar);
        }
        public void Borrar()
        {
            string sqlBorrar = "DELETE FROM Tipos_Documentos WHERE id = " + id;
            _BD.Borrar(sqlBorrar);
        }
        public void Borrar(string id)
        {
            string sqlBorrar = "DELETE FROM Tipos_Documentos WHERE id = " + id;
            _BD.Borrar(sqlBorrar);
        }
    }
    
}
