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
    class NE_Pago_Electronico
    {
        public string id { get; set; }
        public string cuenta_origen { get; set; }
        public string fecha { get; set; }
        public string hora { get; set; }
        public string id_tipo_operacion { get; set; }
        public string importe { get; set; }
        public string id_servicio { get; set; }
        public string puntos_sumados { get; set; }

        BE_Acceso_Datos _BD = new BE_Acceso_Datos();
        TratamientosEspeciales _TE = new TratamientosEspeciales();

        public DataTable BuscarUltimoPago()
        {
            string sql = @"SELECT TOP 1 o.id, o.cuenta_origen, CONVERT(VARCHAR(10), o.fecha, 105), o.hora, t.nombre, o.importe, s.nombre, o.puntos_sumados 
                          FROM Operaciones o, Tipos_Operaciones t, Servicios s WHERE o.id_tipo_operacion = t.id AND o.id_servicio = s.id ORDER BY id DESC";

            return _BD.EjecutarSelect(sql);
        }
        public DataTable BuscarPagosxMesAno (string id_servicio, string mes, string ano)
        {
            string sql = @"SELECT o.id, o.cuenta_origen, o.fecha, o.importe, o.puntos_sumados 
                          FROM Operaciones o WHERE 1=1";

            if (id_servicio != "")
                sql += " AND id_servicio = " + id_servicio;
            if (mes != "")
                sql += " AND MONTH(o.fecha) = " + mes;
            if (ano != "")
                sql += " AND YEAR(o.fecha) = " + ano;

                        sql += " AND o.id_tipo_operacion = 2";

            return _BD.EjecutarSelect(sql);
        }
        public DataTable BuscarPagosxPuntosImportes (string id_pago, string importe_min, string importe_max, string puntos_min, string puntos_max)
        {
            string sql = @"SELECT o.id, o.importe, s.nombre, o.puntos_sumados 
                          FROM Operaciones o JOIN Servicios s ON o.id_servicio = s.id WHERE 1=1";

            if (id_pago != "")
                sql += " AND o.id = " + id_pago;
            if (importe_min != "")
                sql += " AND o.importe >= " + importe_min;
            if (importe_max != "")
                sql += " AND o.importe <= " + importe_max;
            if (puntos_min != "")
                sql += " AND o.puntos_sumados  >= " + puntos_min;
            if (puntos_max != "")
                sql += " AND o.puntos_sumados  <= " + puntos_max;

            sql += " AND o.id_tipo_operacion = 2";

            return _BD.EjecutarSelect(sql);
        }

        public DataTable ValoresMensualesPagosElectronicos (string ano, string mes1, string mes2)
        {
            string sql = @"SELECT CONVERT(char(4),YEAR(o.fecha))+'/'+ CONVERT(char(2),MONTH(o.fecha)) descripcion
                            , COUNT(*) cuantos_pagos, SUM(o.importe) importe_total 
                            FROM Operaciones o WHERE YEAR(o.fecha) =" +ano+ " AND MONTH(o.fecha) between " +mes1+ " AND " +mes2+
                            " GROUP BY YEAR(o.fecha), MONTH(o.fecha)";
            return _BD.EjecutarSelect(sql);
        }

        public DataTable ServiciosMensualesPagosElectronicos(string ano01, string mes01)
        {
            string sql = @"SELECT s.nombre, COUNT(*) cuantos_servicios FROM Operaciones o JOIN Servicios s ON o.id_servicio = s.id
                        WHERE YEAR(o.fecha) =" +ano01+ " AND MONTH(o.fecha) =" +mes01+  
                        " GROUP BY YEAR(o.fecha), MONTH(o.fecha), s.nombre";
            return _BD.EjecutarSelect(sql);
        }

        public void PagarServicio(string saldo_restante, string puntos_obtenidos)
        {
            importe = importe.Replace(",",".");
            string sqlInsertCanje = "INSERT INTO Operaciones (cuenta_origen, fecha, hora, id_tipo_operacion, importe, id_servicio, puntos_sumados) VALUES (";
            sqlInsertCanje += cuenta_origen;
            sqlInsertCanje += ", " + _TE.FormatearDato(fecha, "fecha");
            sqlInsertCanje += ", '" + hora + "'";
            sqlInsertCanje += ", " + "2";
            sqlInsertCanje += ", " + importe;
            sqlInsertCanje += ", " + id_servicio;
            sqlInsertCanje += ", " + puntos_obtenidos;
            sqlInsertCanje += ")";
            _BD.IniciarTransaccion();
            _BD.Insertar(sqlInsertCanje, BE_Acceso_Datos.RecuperacionPk.no_recuperar);

            saldo_restante = saldo_restante.Replace(",", ".");

            string sqlModificarCuenta = "UPDATE Cuentas SET ";
            sqlModificarCuenta += "puntos_total += " + puntos_obtenidos;
            sqlModificarCuenta += ",saldo = " + saldo_restante;
            sqlModificarCuenta += "WHERE numero = " + cuenta_origen;
            _BD.Modificar(sqlModificarCuenta);

            if (_BD.CerrarTransaccion() == BE_Acceso_Datos.EstadoTransaccion.correcto)
            {
                MessageBox.Show("Se realizo Correctamente el Pago.\n" +
                   "Su nuevo Saldo es de: $" + saldo_restante + "\nSumo: " + puntos_obtenidos + " Puntos",
                   "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("No se grabó el pago del servicio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
