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
    class NE_Transferencias
    {
        public enum Validacion { correcta, incorrecta }
        public string id { get; set; }
        public string cuenta_origen { get; set; }
        public string cuenta_destino { get; set; }
        public string fecha { get; set; }
        public string hora { get; set; }
        public string id_cotizaciones { get; set; }
        public string id_tipo_operacion { get; set; }
        public string importe { get; set; }
        public string id_tarifas { get; set; }

        public string imp_A_Desc { get; set; }
        public string valorCot { get; set; }


        BE_Acceso_Datos _BD = new BE_Acceso_Datos();
        TratamientosEspeciales _TE = new TratamientosEspeciales();

        public string insertarConCot()
        {
            //inserta la operacion en base de datos
            string sqlInsert = "";

            sqlInsert += @"INSERT INTO Operaciones (cuenta_origen, cuenta_destino, fecha, hora, id_cotizaciones, id_tipo_operacion, importe, id_tarifas) VALUES ( ";
            sqlInsert += cuenta_origen;
            sqlInsert += ", " + cuenta_destino;
            sqlInsert += ", '" + fecha + "'";
            sqlInsert += ", '" + hora + "'";
            sqlInsert += ", " + id_cotizaciones;
            sqlInsert += ", " + id_tipo_operacion;
            sqlInsert += ", " + importe.Replace(",", ".");
            sqlInsert += ", " + id_tarifas + " )";

            string imp_A_Sum = (float.Parse(importe) / float.Parse(valorCot)).ToString().Replace(",", ".");
            actualizarSaldos(imp_A_Desc, imp_A_Sum);

            return _BD.Insertar(sqlInsert, BE_Acceso_Datos.RecuperacionPk.recuperar);
        }

        public string insertarSinCot()
        {
            string sqlInsert = "";

            sqlInsert += @"INSERT INTO Operaciones (cuenta_origen, cuenta_destino, fecha, hora, id_tipo_operacion, importe, id_tarifas) VALUES ( ";
            sqlInsert += cuenta_origen;
            sqlInsert += ", " + cuenta_destino;
            sqlInsert += ", '" + fecha + "'";
            sqlInsert += ", '" + hora + "'";
            sqlInsert += ", " + id_tipo_operacion;
            sqlInsert += ", " + importe.Replace(",", ".");
            sqlInsert += ", " + id_tarifas + " )";

            actualizarSaldos(imp_A_Desc, importe);

            return _BD.Insertar(sqlInsert, BE_Acceso_Datos.RecuperacionPk.recuperar);
        }

        private void actualizarSaldos(string imp_A_Desc, string imp_A_Sum)
        {
            //actualiza cuenta origen
            string sqlUpdateCD = "UPDATE Cuentas SET saldo = saldo - " + imp_A_Desc.Replace(",", ".") + " WHERE numero = " + cuenta_origen;
            _BD.Modificar(sqlUpdateCD);

            //actualiza cuenta destino
            string sqlUpdateCO = "UPDATE Cuentas SET saldo = saldo + " + imp_A_Sum.Replace(",", ".") + " WHERE numero = " + cuenta_destino;
            _BD.Modificar(sqlUpdateCO);

        }

        public DataTable buscarUltimoTransferencia()
        {
            string sql = @"SELECT TOP 1 o.id, o.cuenta_origen, o.cuenta_destino, CONVERT(VARCHAR(10), o.fecha, 105), o.hora, o.id_cotizaciones, t.nombre, o.importe, o.id_tarifas
                          FROM Operaciones o, Tipos_Operaciones t WHERE o.id_tipo_operacion = t.id ORDER BY id DESC";

            return _BD.EjecutarSelect(sql);
        }

        public DataTable buscarTransferencia_X_Monedas(string monedaOrigen, string monedaDestino)
        {
            string sql = @"SELECT o.id, o.cuenta_origen, o.cuenta_destino, CONVERT(VARCHAR(10), o.fecha, 105) fecha, o.hora, c.valor cotizacion, o.importe, t.porcentaje tarifa 
                           FROM Operaciones o 
                           JOIN Cuentas co ON o.cuenta_origen = co.numero
                           JOIN Cuentas cd ON o.cuenta_destino = cd.numero
                           JOIN Cotizaciones c ON o.id_cotizaciones = c.id 
                           JOIN Tarifas t ON o.id_tarifas = t.id 
                           WHERE 1=1";

            if (monedaOrigen != "")
            {
                sql += " AND co.id_moneda = " + monedaOrigen;
            }
            if (monedaDestino != "")
            {
                sql += " AND cd.id_moneda = " + monedaDestino;
            }
            sql += " ORDER BY o.fecha, o.hora";

            return _BD.EjecutarSelect(sql);
        }

      

        public DataTable buscarTransferencia_X_Cuentas(string txt_CuentaOrigen, string txt_CuentaDestino)
        {
            string sql = @"SELECT o.id, o.cuenta_origen, o.cuenta_destino, CONVERT(VARCHAR(10), o.fecha, 105) fecha, o.hora, c.valor cotizacion, o.importe, t.porcentaje tarifa
                           FROM Operaciones o 
                           JOIN Cuentas co ON o.cuenta_origen = co.numero
                           JOIN Cuentas cd ON o.cuenta_destino = cd.numero
                           JOIN Cotizaciones c ON o.id_cotizaciones = c.id 
                           JOIN Tarifas t ON o.id_tarifas = t.id 
                           WHERE 1=1";


            
            if (txt_CuentaOrigen != "")
                sql += " AND o.cuenta_origen = " + txt_CuentaOrigen;
            if (txt_CuentaDestino != "")
                sql += " AND o.cuenta_destino = " + txt_CuentaDestino;
                
            
                sql += " ORDER BY o.cuenta_origen, o.cuenta_destino";

            return _BD.EjecutarSelect(sql);


      

        }

        public DataTable buscarTransferencia_X_Fecha_Usuario(string cuenta_origen, string fecha_desde, string fecha_hasta)
        {
            string sql = @"SELECT o.id, o.cuenta_origen, o.cuenta_destino, o.hora, c.valor cotizacion, o.importe, t.porcentaje tarifa
                           FROM Operaciones o
                           JOIN Cotizaciones c ON o.id_cotizaciones = c.id 
                           JOIN Tarifas t ON o.id_tarifas = t.id  
                           WHERE 1=1";

            if (cuenta_origen != "")
                sql += " AND o.cuenta_origen = " + cuenta_origen;
            if (fecha_desde != "  /  /")
                sql += " AND o.fecha >= " + _TE.FormatearDato(fecha_desde, "fecha");
            if (fecha_hasta != "  /  /")
                sql += " AND o.fecha <= " + _TE.FormatearDato(fecha_hasta, "fecha");
            sql += " ORDER BY o.fecha";

            return _BD.EjecutarSelect(sql);
        }

        public DataTable estadisticaMensualesTransfrencias(string año, string mesDesde, string mesHasta)
        {
            string sql = @"SELECT CONVERT(CHAR(4), YEAR(t.fecha))+'/'+CONVERT(CHAR(4), MONTH(t.fecha)) descripcion, COUNT(*) cantidad, SUM(t.importe) cantidad_transferida
                            FROM Operaciones t 
                            WHERE YEAR(t.fecha) = " + año +
                            " AND MONTH(t.fecha) BETWEEN " + mesDesde + " AND " + mesHasta + 
                            " AND id_tipo_operacion = 1 " +
                            "GROUP BY YEAR(t.fecha), MONTH(t.fecha)";

            return _BD.EjecutarSelect(sql);
        }

        public DataTable Estadistica_TransferenciasxCuentas(string CuentaOrigen, string CuentaDestino)
        {
            string sql = @"SELECT o.fecha, COUNT(*) cuantas_fecha FROM Operaciones o  
                        WHERE  o.cuenta_origen = " + CuentaOrigen + "AND o.cuenta_destino =" + CuentaDestino +
                         "GROUP BY o.fecha";

            return _BD.EjecutarSelect(sql);
        }

        public DataTable estadisticaMensualesTransfrenciasxMonedas(string fechaDesde, string fechaHasta)
        {
            string sql = @"SELECT mo.simbolo+' a '+md.simbolo descripcion, COUNT(*) cantidad, SUM(t.importe) cantidad_transferida
                            FROM Operaciones t 
                            JOIN Cuentas co ON t.cuenta_origen = co.numero
                            JOIN Cuentas cd ON t.cuenta_destino = cd.numero
                            JOIN Monedas mo ON co.id_moneda = mo.id
                            JOIN Monedas md ON cd.id_moneda = md.id
                            WHERE t.fecha BETWEEN '" + fechaDesde + "' AND '" + fechaHasta +
                            "' AND id_tipo_operacion = 1 " +
                            "GROUP BY mo.simbolo, md.simbolo";

            return _BD.EjecutarSelect(sql);
        }
    }
}


