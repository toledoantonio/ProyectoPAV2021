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
    class NE_Tipos_Cuentas
    {
        public enum Validacion { correcta, incorrecta }

        public string id { get; set; }
        public string descripcion { get; set; }


        BE_Acceso_Datos _BD = new BE_Acceso_Datos();

        public DataTable BuscarTipos_CuentasDescripcion(string descripcion)
        {
            string sql = @"SELECT id, descripcion 
                          FROM Tipos_Cuentas WHERE descripcion LIKE '%" + descripcion + "%'";

            return _BD.EjecutarSelect(sql);
        }
        public DataTable BuscarTipos_CuentasID(string id)
        {
            string sql = @"SELECT id, descripcion 
                          FROM Tipos_Cuentas WHERE id = " + id;

            return _BD.EjecutarSelect(sql);
        }
        public DataTable BuscarTipos_CuentasTodos()
        {
            string sql = @"SELECT * 
                          FROM Tipos_Cuentas";

            return _BD.EjecutarSelect(sql);
        }
        public string Insertar()
        {
            string sqlInsert = "";

            sqlInsert = @"INSERT INTO Tipos_Cuentas (descripcion) VALUES (";
            sqlInsert += "'" + descripcion + "')";


            return _BD.Insertar(sqlInsert, BE_Acceso_Datos.RecuperacionPk.recuperar);
        }
        public string Insertar(Control.ControlCollection Controles)
        {
            TratamientosEspeciales _TE = new TratamientosEspeciales();
            //MessageBox.Show(_TE.SqlInsertAutomatico("Servicios", Controles));
            //return "0";
            return _BD.Insertar(_TE.SqlInsertAutomatico("Tipos_Cuentas", Controles), BE_Acceso_Datos.RecuperacionPk.recuperar);
        }

        public DataTable RecuperarTipoCuenta(string id)
        {
            string sql = @"SELECT * FROM Tipos_Cuentas WHERE id = " + id;

            return _BD.EjecutarSelect(sql);
        }

        public void Modificar()
        {
            string sqlModificar = "UPDATE Tipos_Cuentas SET ";      
            sqlModificar += " descripcion = '" + descripcion + "'";
            sqlModificar += " WHERE id = " + id;

            _BD.Modificar(sqlModificar);
        }

        public void Borrar()
        {
            string sqlBorrar = "DELETE FROM Tipos_Cuentas WHERE id = " + id;
            _BD.Borrar(sqlBorrar);
        }
    }
}
