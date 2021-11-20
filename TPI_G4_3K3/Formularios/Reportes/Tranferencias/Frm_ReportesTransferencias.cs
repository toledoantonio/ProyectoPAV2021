using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using BankApp.Negocios;


namespace BankApp.Formularios.Reportes.Tranferencias
{
    public partial class Frm_ReportesTransferencias : BankApp.Formularios.FrmBase.Frm_Base
    {
        public Frm_ReportesTransferencias()
        {
            InitializeComponent();
        }

        private void Frm_ReportesTransferencias_Load(object sender, EventArgs e)
        {

            this.rv01.RefreshReport();
            cargarCombos();
            this.reportViewer1.RefreshReport();
            this.rv03.RefreshReport();
        }

        public void cargarCombos()
        {
            cmb_monedasOrigen._Cargar();
            cmb_monedasDestino._Cargar();
        }

        private void btn_calcular01_Click(object sender, EventArgs e)
        {
            NE_Transferencias transferencia = new NE_Transferencias();
            DataTable tabla = new DataTable();


            if (cmb_monedasOrigen.SelectedIndex == -1 && cmb_monedasDestino.SelectedIndex == -1)
            {
                MessageBox.Show("No se cargo ningun valor de busqueda", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (cmb_monedasDestino.SelectedIndex == -1)
            {
                tabla = transferencia.buscarTransferencia_X_Monedas(cmb_monedasOrigen.SelectedValue.ToString(), "");
            }
            else
            {
                if (cmb_monedasOrigen.SelectedIndex == -1)
                {
                    tabla = transferencia.buscarTransferencia_X_Monedas("", cmb_monedasDestino.SelectedValue.ToString());
                }
                else
                {
                    tabla = transferencia.buscarTransferencia_X_Monedas(cmb_monedasOrigen.SelectedValue.ToString(), cmb_monedasDestino.SelectedValue.ToString());
                }
            }
            ReportDataSource datos = new ReportDataSource("DataSet1", tabla);
            rv01.LocalReport.ReportEmbeddedResource = "BankApp.Formularios.Reportes.Tranferencias.Rpt_Transferencias.rdlc";
            
            ReportParameter[] parametro = new ReportParameter[2];
            parametro[0] = new ReportParameter("RP01", "Para la Moneda Origen: " + cmb_monedasOrigen.Text.ToString());
            parametro[1] = new ReportParameter("RP06", "Para la Moneda Destino: " + cmb_monedasDestino.Text.ToString());
            rv01.LocalReport.SetParameters(parametro);

            rv01.LocalReport.DataSources.Clear();
            rv01.LocalReport.DataSources.Add(datos);
            rv01.RefreshReport();


        }

        private void buttonLC_Click(object sender, EventArgs e)
        {
            NE_Transferencias transferencia = new NE_Transferencias();
            DataTable tabla = new DataTable();

            if (txt_CuentaOrigen._Text == "" && txt_CuentaDestino._Text == "")
            {
                MessageBox.Show("No se cargo ningun valor de busqueda", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            tabla = transferencia.buscarTransferencia_X_Cuentas(txt_CuentaOrigen._Text, txt_CuentaDestino._Text);

            ReportDataSource datos = new ReportDataSource("DataSet1", tabla);
            reportViewer1.LocalReport.ReportEmbeddedResource = "BankApp.Formularios.Reportes.Tranferencias.Rpt_TransferenciasxCuentas.rdlc";

            ReportParameter[] parametro = new ReportParameter[2];
            parametro[0] = new ReportParameter("RP02", "Para la Cuenta Origen: " + txt_CuentaOrigen._Text);
            parametro[1] = new ReportParameter("RP07", " para la Cuenta Destino: " + txt_CuentaDestino._Text);
            reportViewer1.LocalReport.SetParameters(parametro);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(datos);
            reportViewer1.RefreshReport();

            
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            NE_Transferencias transferencia = new NE_Transferencias();
            DataTable tabla = new DataTable();

            tabla = transferencia.buscarTransferencia_X_Fecha_Usuario(txt_cuenta_origen._Text, txt_fecha_desde._Text, txt_fecha_hasta._Text);

            if (txt_cuenta_origen._Text == "" && txt_fecha_desde._Text.Trim().Remove(0, 1).Trim() == "/" && txt_fecha_hasta._Text.Trim().Remove(0, 1).Trim() == "/")
            {
                MessageBox.Show("No se cargo ningun valor de busqueda", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ReportDataSource datos = new ReportDataSource("DataSet1", tabla);
            rv03.LocalReport.ReportEmbeddedResource = "BankApp.Formularios.Reportes.Tranferencias.Rpt_TransferenciaxFecha.rdlc";

            ReportParameter[] parametro = new ReportParameter[3];
            parametro[0] = new ReportParameter("RP03", "Para la cuenta origen: " + txt_cuenta_origen._Text);
            parametro[1] = new ReportParameter("RP04", "Desde la fecha: " + txt_fecha_desde._Text);
            parametro[2] = new ReportParameter("RP05", "Hasta la fecha: " + txt_fecha_hasta._Text);
            rv03.LocalReport.SetParameters(parametro);

            rv03.LocalReport.DataSources.Clear();
            rv03.LocalReport.DataSources.Add(datos);
            rv03.RefreshReport();
        }

        private void txt_fecha_desde_Load(object sender, EventArgs e)
        {

        }
    }
}
