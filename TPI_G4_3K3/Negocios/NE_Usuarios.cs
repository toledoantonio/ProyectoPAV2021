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
    class NE_Usuarios
    {
        public enum Validacion { correcta, incorrecta }

        public string id { get; set; }
        public string nombre_usuario { get; set; }
        public string contraseña { get; set; }
        public string apellido { get; set; }
        public string nombre { get; set; }
        public string tipo_doc { get; set; }
        public string nro_doc { get; set; }

        BE_Acceso_Datos _BD = new BE_Acceso_Datos();

        public DataTable BuscarUsuario(string patron, string columna)
        {
            string sql = @"SELECT u.id, u.nombre_usuario, u.apellido, u.nombre, t.descripcion, u.nro_doc 
                          FROM Usuarios u, Tipos_Documentos t WHERE u.tipo_doc = t.id AND " + columna + " like '%" + patron + "%'";

            return _BD.EjecutarSelect(sql);
        }
        public DataTable BuscarUsuario(string id)
        {
            string sql = @"SELECT u.id, u.nombre_usuario, u.apellido, u.nombre, t.descripcion, u.nro_doc 
                          FROM Usuarios u, Tipos_Documentos t WHERE u.tipo_doc = t.id AND u.id = " + id;

            return _BD.EjecutarSelect(sql);
        }
        public DataTable RecuperarUsuario(string id)
        {
            string sql = @"SELECT * 
                          FROM Usuarios WHERE id = " + id;

            return _BD.EjecutarSelect(sql);
        }

        public DataTable ReporteUsuarios(string tipo_doc, string nombre)
        {
            string sql = @"SELECT u.id, u.nombre, u.apellido, u.nro_doc, t.numero
                          FROM Usuarios u JOIN Telefonos t ON u.id = t.id_usuario WHERE 1=1";

            if (tipo_doc != "")
                sql += " AND tipo_doc = " + tipo_doc;
            if (nombre != "")
                sql += " AND nombre_usuario = '" + nombre + "'";

            sql += " ORDER BY u.id, nombre ";

            
            return _BD.EjecutarSelect(sql);
        }
        public string Insertar()
        {
            string sqlInsert = "";

            sqlInsert = @"INSERT INTO Usuarios (nombre_usuario, contraseña, apellido
                               , nombre, tipo_doc, nro_doc) VALUES (";
            sqlInsert += "'"+nombre_usuario + "'";
            sqlInsert += ", '" + contraseña + "'";
            sqlInsert += ", '" + apellido + "'";
            sqlInsert += ", '" + nombre + "'";
            sqlInsert += ", " + tipo_doc;
            sqlInsert += ", " + nro_doc+")";

            return _BD.Insertar(sqlInsert, BE_Acceso_Datos.RecuperacionPk.recuperar);
        }
        public string Insertar (Control.ControlCollection Controles)
        {
            TratamientosEspeciales _TE = new TratamientosEspeciales();
            return _BD.Insertar(_TE.SqlInsertAutomatico("Usuarios", Controles), BE_Acceso_Datos.RecuperacionPk.recuperar);
        }
        public void Modificar()
        {
            string sqlModificar = "UPDATE Usuarios SET ";
            sqlModificar += " nombre_usuario = '" + nombre_usuario + "'";
            sqlModificar += ", contraseña = '" + contraseña + "'";
            sqlModificar += ", apellido = '" + apellido + "'";
            sqlModificar += ", nombre = '" + nombre + "'";
            sqlModificar += ", tipo_doc = " + tipo_doc;
            sqlModificar += ", nro_doc = " + nro_doc;
            sqlModificar += " WHERE id = " + id;

            _BD.Modificar(sqlModificar);
        }
        public void Borrar()
        {
            string sqlBorrar = "DELETE FROM Usuarios WHERE id = " + id;
            _BD.Borrar(sqlBorrar);
        }
        public void Borrar(string id)
        {
            string sqlBorrar = "DELETE FROM Usuarios WHERE id = " + id;
            _BD.Borrar(sqlBorrar);
        }
        public DataTable BuscarUsuariosTodos()
        {
            string sql = @"SELECT u.id, u.nombre_usuario, u.apellido, u.nombre, t.descripcion, u.nro_doc 
                          FROM Usuarios u, Tipos_Documentos t WHERE u.tipo_doc = t.id";
            return _BD.EjecutarSelect(sql);
        }
        public DataTable Estadistica_Usuarios(string nombre)
        {
            string sql = @"SELECT td.descripcion, COUNT(*) cuantos_usuarios FROM Usuarios u JOIN Tipos_Documentos td ON u.tipo_doc = td.id
                            WHERE u.nombre LIKE '%" + nombre + "%' GROUP BY td.descripcion";

            return _BD.EjecutarSelect(sql);
        }
    }
}
