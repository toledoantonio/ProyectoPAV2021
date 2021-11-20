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
    class NE_Cuentas
    {
        public enum Validacion { correcta, incorrecta }

        public string numero { get; set; }
        public string tipo_cuenta { get; set; }
        public string id_usuario { get; set; }
        public string id_moneda { get; set; }
        public string puntos_total { get; set; }
        public string saldo { get; set; }
        //public string puntos_total { get; set; }
        //public string saldo { get; set; }

        BE_Acceso_Datos _BD = new BE_Acceso_Datos();

        public DataTable BuscarCuenta(string patron, string columna)
        {
            string sql = @"SELECT c.numero, t.descripcion, c.id_usuario, m.nombre, c.puntos_total, c.saldo
                          FROM Cuentas c, Monedas m, Tipos_Cuentas t WHERE c.tipo_cuenta = t.id AND c.id_moneda = m.id AND " + columna + " = " + patron;

            return _BD.EjecutarSelect(sql);
        }

        public DataTable RecuperarCuenta(string numero)
        {
            string sql = @"SELECT * FROM Cuentas WHERE numero = " + numero;

            return _BD.EjecutarSelect(sql);
        }
        public DataTable BuscarCuentasTodos()
        {
            string sql = @"SELECT c.numero, t.descripcion, c.id_usuario, m.nombre, c.puntos_total, c.saldo
                          FROM Cuentas c, Monedas m, Tipos_Cuentas t WHERE c.tipo_cuenta = t.id AND c.id_moneda = m.id";

            return _BD.EjecutarSelect(sql);
        }

        public DataTable ReporteCuenta(string tipo_cuenta, string id_moneda)
        {
            string sql = @"SELECT c.id_usuario, m.simbolo, c.saldo
                          FROM Cuentas c JOIN Monedas m ON c.id_moneda = m.id WHERE 1=1";

            if (tipo_cuenta != "")
                sql += "AND tipo_cuenta = " + tipo_cuenta;
            if (id_moneda != "")
                sql += "AND id_moneda = " + id_moneda;

            sql += "ORDER BY c.id_usuario";

            return _BD.EjecutarSelect(sql);

        }
            

        public DataTable RecuperarMonedaYSaldo(string numero)
        {
            string sql = @"SELECT m.nombre, c.saldo, m.simbolo
                          FROM Cuentas c JOIN Monedas m ON c.id_moneda = m.id WHERE c.numero = " + numero;

            return _BD.EjecutarSelect(sql);
        }
        public DataTable RecuperarPuntos(string numero)
        {
            string sql = @"SELECT puntos_total FROM Cuentas WHERE numero = " + numero;
            return _BD.EjecutarSelect(sql);
        }
        public string RecuperarIdUsuario(string numero)
        {
            string sql = "SELECT id_usuario FROM Cuentas WHERE numero = " + numero;
            return _BD.EjecutarSelect(sql).Rows[0][0].ToString();
        }
        public string Insertar()
        {
            string sqlInsert = "";

            sqlInsert = @"INSERT INTO Cuentas (tipo_cuenta, id_usuario, id_moneda, puntos_total, saldo) VALUES (";
            sqlInsert += tipo_cuenta;
            sqlInsert += ", " + id_usuario;
            sqlInsert += ", " + id_moneda; 
            sqlInsert += ", 0, 0 )";

            return _BD.Insertar(sqlInsert, BE_Acceso_Datos.RecuperacionPk.recuperar);
        }
        public string Insertar(Control.ControlCollection Controles)
        {
            TratamientosEspeciales _TE = new TratamientosEspeciales();
            return _BD.Insertar(_TE.SqlInsertAutomatico("Cuentas", Controles), BE_Acceso_Datos.RecuperacionPk.recuperar);
        }
        
        public void Modificar()
        {
            string sqlModificar = "UPDATE Cuentas SET ";
            sqlModificar += " tipo_cuenta = " + tipo_cuenta;
            sqlModificar += ", id_usuario = " + id_usuario;
            sqlModificar += ", id_moneda = " + id_moneda;
            sqlModificar += ", saldo = " + saldo;
            sqlModificar += ", puntos_total = " + puntos_total;
            sqlModificar += " WHERE numero = " + numero;

            _BD.Modificar(sqlModificar);
        }

        public void Borrar()
        {
            string sqlBorrar = "DELETE FROM Cuentas WHERE numero = " + numero;
            _BD.Borrar(sqlBorrar);
        }

        public DataTable BuscarCuentasxSaldos(string txt_SaldoMin, string txt_SaldoMax)
        {
            string sql = @"SELECT c.numero, c.tipo_cuenta, c.id_usuario, u.nombre_usuario, u.apellido, c.id_moneda, c.saldo
                          FROM Cuentas c
                          JOIN  Usuarios u ON c.id_usuario = u.id
                          WHERE 1=1";

            if (txt_SaldoMin != "")
                sql += "AND c.saldo >= " + txt_SaldoMin;
            if (txt_SaldoMax != "")
                sql += "AND c.saldo <= " + txt_SaldoMax;

            return _BD.EjecutarSelect(sql);
        }

        public DataTable Estadistica_CuentasxSaldo(string SaldoMin, string SaldoMax)
        {
            string sql = @"SELECT m.nombre, COUNT(c.numero) cuantos_cuentas FROM Cuentas c JOIN Monedas m ON c.id_moneda = m.id 
                        WHERE  c.saldo between " + SaldoMin +  "AND " + SaldoMax +
                         "GROUP BY m.nombre";

            return _BD.EjecutarSelect(sql);
        }

        public DataTable Estadistica_CuentasxTipoDoc(string tipo_doc)
        {
            string sql = @"SELECT m.nombre, COUNT(c.numero) cuantos_cuentas FROM Cuentas c JOIN Monedas m ON c.id_moneda = m.id                          
                           WHERE c.tipo_cuenta = " + tipo_doc + " GROUP BY m.nombre ";

            return _BD.EjecutarSelect(sql);
        }
    }
}


