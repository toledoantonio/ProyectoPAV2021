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
    class NE_Cotizaciones
    {
        public enum Validacion { correcta, incorrecta }

        public string id { get; set; }
        public string moneda_origen { get; set; }
        public string moneda_destino { get; set; }
        public string fecha { get; set; }
        public string valor { get; set; }

        BE_Acceso_Datos _BD = new BE_Acceso_Datos();

        public DataTable BuscarCotizacionesPatron(string patron, string patron2)
        {
            string sql = @"SELECT c.id, o.nombre, d.nombre, CONVERT(VARCHAR(10), c.fecha, 105), valor 
                        FROM Cotizaciones c, Monedas o, Monedas d WHERE c.moneda_origen = o.id AND c.moneda_destino = d.id AND c.fecha >= '" + patron + "' and c.fecha <= '" + patron2 + "'";

            return _BD.EjecutarSelect(sql);
        }
        public DataTable BuscarCotizacionesID(string id)
        {
            string sql = @"SELECT c.id, o.nombre, d.nombre, CONVERT(VARCHAR(10), c.fecha, 105), valor 
                          FROM Cotizaciones c, Monedas o, Monedas d WHERE c.moneda_origen = o.id AND c.moneda_destino = d.id AND c.id = " + id;

            return _BD.EjecutarSelect(sql);
        }

        public DataTable RecuperarCotizaciones(string id)
        {
            string sql = @"SELECT * 
                          FROM Cotizaciones WHERE id = " + id;

            return _BD.EjecutarSelect(sql);
        }

        public DataTable BuscarCotizacionTransferencia(string monedaOrigen, string monedaDestino, string fecha)
        {
            string sql = @"SELECT c.id, c.valor FROM Cotizaciones c, Monedas o, Monedas d 
                          WHERE c.moneda_origen = o.id AND c.moneda_destino = d.id 
                          AND o.simbolo = '" + monedaOrigen + "' AND d.simbolo = '" + monedaDestino + "'"
                          + " AND c.fecha = '"+ fecha + "'";

            return _BD.EjecutarSelect(sql);
        }

        public string Insertar()
        {
            string sqlInsert = "";

            sqlInsert = @"INSERT INTO Cotizaciones (moneda_origen, moneda_destino, fecha, valor) VALUES (";
            sqlInsert += moneda_origen;
            sqlInsert += ", " + moneda_destino;
            sqlInsert += ", '" + fecha + "'";
            sqlInsert += ", " + valor.Replace(",", ".") + ")";

            return _BD.Insertar(sqlInsert, BE_Acceso_Datos.RecuperacionPk.recuperar);
        }
        public string Insertar(Control.ControlCollection Controles)
        {
            TratamientosEspeciales _TE = new TratamientosEspeciales();
            return _BD.Insertar(_TE.SqlInsertAutomatico("Cotizaciones", Controles), BE_Acceso_Datos.RecuperacionPk.recuperar);
        }
        public void Modificar()
        {
            string sqlModificar = "UPDATE Cotizaciones SET ";
            sqlModificar += "moneda_origen = " + moneda_origen;
            sqlModificar += ", moneda_destino = " + moneda_destino;
            sqlModificar += ", fecha = '" + fecha + "'";
            sqlModificar += ", valor = " + valor.Replace(",", ".");
            sqlModificar += " WHERE id = " + id;

            _BD.Modificar(sqlModificar);
        }
        public void Borrar()
        {
            string sqlBorrar = "DELETE FROM Cotizaciones WHERE id = " + id;
            _BD.Borrar(sqlBorrar);
        }
        public void Borrar(string id)
        {
            string sqlBorrar = "DELETE FROM Cotizaciones WHERE id = " + id;
            _BD.Borrar(sqlBorrar);
        }
        public DataTable BuscarCotizacionesTodos()
        {
            string sql = @"SELECT c.id, o.nombre, d.nombre, CONVERT(VARCHAR(10), c.fecha, 105), valor 
                        FROM Cotizaciones c, Monedas o, Monedas d WHERE c.moneda_origen = o.id AND c.moneda_destino = d.id";

            return _BD.EjecutarSelect(sql);
        }
    }
}


