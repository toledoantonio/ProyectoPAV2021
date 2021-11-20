using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using BankApp.Negocios;

namespace BankApp.Formularios.Reportes.Cuentas
{
    public partial class Frm_ReportesCuentas : BankApp.Formularios.FrmBase.Frm_Base
    {
        public Frm_ReportesCuentas()
        {
            InitializeComponent();
        }

        private void Frm_ReportesCuentas_Load(object sender, EventArgs e)
        {

            this.rv_cuentas.RefreshReport();
            this.rv_cuentas.RefreshReport();
            this.rv_cuentas.RefreshReport();
            cmb_tipo_cuenta._Cargar();
            cmb_monedas._Cargar();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void btn_calcular1_Click(object sender, EventArgs e)
        {
            NE_Cuentas cuenta = new NE_Cuentas();
            DataTable tabla = new DataTable();

            //validaciones

            tabla = cuenta.ReporteCuenta(cmb_tipo_cuenta.SelectedValue.ToString(), cmb_monedas.SelectedValue.ToString());
            ReportDataSource datos = new ReportDataSource("DataSet1", tabla);
            rv_cuentas.LocalReport.ReportEmbeddedResource = "BankApp.Formularios.Reportes.Cuentas.Rprt_Cuentas.rdlc";

            ReportParameter[] parametro = new ReportParameter[1];
            parametro[0] = new ReportParameter("RP01", "Para el Tipo de Cuenta: " + cmb_tipo_cuenta.SelectedValue.ToString() + " y la Moneda: " + cmb_monedas.SelectedValue.ToString());
            rv_cuentas.LocalReport.SetParameters(parametro);
            rv_cuentas.LocalReport.DataSources.Clear();
            rv_cuentas.LocalReport.DataSources.Add(datos);
            rv_cuentas.RefreshReport();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NE_Cuentas cuenta = new NE_Cuentas();
            DataTable tabla = new DataTable();

            if (txt_SaldoMin._Text == "" && txt_SaldoMax._Text == "")
            {
                MessageBox.Show("No se cargo ningun valor de busqueda", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            //validaciones

            tabla = cuenta.BuscarCuentasxSaldos( txt_SaldoMin._Text, txt_SaldoMax._Text);
            ReportDataSource datos = new ReportDataSource("DataSet1", tabla);
            reportViewer1.LocalReport.ReportEmbeddedResource = "BankApp.Formularios.Reportes.Cuentas.Rprt_CuentasxSaldos.rdlc";

            ReportParameter[] parametro = new ReportParameter[2];
            parametro[0] = new ReportParameter("RP08", "Entre el Saldo Minimo: " + txt_SaldoMin._Text);
            parametro[1] = new ReportParameter("RP10", " y el Saldo Maximo: " + txt_SaldoMax._Text);

            reportViewer1.LocalReport.SetParameters(parametro);
            reportViewer1.LocalReport.SetParameters(parametro);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(datos);
            reportViewer1.RefreshReport();
        }
    }
}
