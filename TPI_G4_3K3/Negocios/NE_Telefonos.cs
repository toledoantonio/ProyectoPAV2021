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
    class NE_Telefonos
    {
        public enum Validacion { correcta, incorrecta }

        public string numero { get; set; }
        public string id_usuario { get; set; }

        BE_Acceso_Datos _BD = new BE_Acceso_Datos();

        public DataTable BuscarNumero(string numero)
        {
            string sql = @"SELECT numero, id_usuario 
                          FROM Telefonos WHERE numero LIKE '%" +numero+ "%'";

            return _BD.EjecutarSelect(sql);
        }

        public DataTable BuscarId_usuario(string id_usuario)
        {
            string sql = @"SELECT numero, id_usuario 
                          FROM Telefonos WHERE id_usuario = " + id_usuario;

            return _BD.EjecutarSelect(sql);
        }
        public DataTable BuscarTelefonosTodos()
        {
            string sql = @"SELECT * 
                          FROM Telefonos";

            return _BD.EjecutarSelect(sql);
        }

        public DataTable RecuperarTelefono(string numero)
        {
            string sql = @"SELECT * 
                          FROM Telefonos WHERE numero = " + numero;

            return _BD.EjecutarSelect(sql);
        }
                           

        public string Insertar()
        {
            string sqlInsert = "";

            sqlInsert = @"INSERT INTO Telefonos (numero, id_usuario) VALUES (";
            sqlInsert += numero ;
            sqlInsert += ", " + id_usuario + ")";


            return _BD.Insertar(sqlInsert, BE_Acceso_Datos.RecuperacionPk.recuperar);
        }
        public string Insertar(Control.ControlCollection Controles)
        {
            TratamientosEspeciales _TE = new TratamientosEspeciales();
            //MessageBox.Show(_TE.SqlInsertAutomatico("Servicios", Controles));
            //return "0";
            return _BD.Insertar(_TE.SqlInsertAutomatico("Telefonos", Controles), BE_Acceso_Datos.RecuperacionPk.recuperar);
        }

        public void Modificar()
        {
            string sqlModificar = "UPDATE Telefonos SET ";
            sqlModificar += " id_usuario = " + id_usuario;
            sqlModificar += " WHERE numero = " + numero ;

            _BD.Modificar(sqlModificar);
        }

        public void Borrar()
        {
            string sqlBorrar = "DELETE FROM Telefonos WHERE numero = " + numero;
            _BD.Borrar(sqlBorrar);
        }
        public void Borrar(string id_usuario)
        {
            string sqlBorrar = "DELETE FROM Telefonos WHERE id_usuario = " + id_usuario;
            _BD.Borrar(sqlBorrar);
        }
    }
}
