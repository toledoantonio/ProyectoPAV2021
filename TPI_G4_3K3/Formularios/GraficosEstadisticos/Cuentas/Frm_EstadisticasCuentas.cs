using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankApp.Negocios;
using Microsoft.Reporting.WinForms;


namespace BankApp.Formularios.GraficosEstadisticos.Cuentas
{
    public partial class Frm_EstadisticasCuentas : BankApp.Formularios.FrmBase.Frm_Base
    {
        public Frm_EstadisticasCuentas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Frm_EstadisticasCuentas_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            this.rv01.RefreshReport();
            cmb_tipo_cuenta._Cargar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_SaldoMin._Text != "" && txt_SaldoMax._Text != "")
            {
                ArmarReporteEstadisticoCuentasxSaldos();
            }
            else
            {
                MessageBox.Show("Debe ingresar Saldo Minimo y Maximo para buscar.");
                return;
            }

          
        }

        private void ArmarReporteEstadisticoCuentasxSaldos()
        {
            NE_Cuentas cuenta = new NE_Cuentas();
            ReportDataSource Datos = new ReportDataSource("DataSet1", cuenta.Estadistica_CuentasxSaldo(txt_SaldoMin._Text, txt_SaldoMax._Text));
            reportViewer1.LocalReport.ReportEmbeddedResource = "BankApp.Formularios.GraficosEstadisticos.Cuentas.RepEstadisticaCuentasxSaldos.rdlc";

            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("RP10", "Para el Saldo Minimo: " + txt_SaldoMin._Text + " y Saldo Maximo: " + txt_SaldoMax._Text);
            reportViewer1.LocalReport.SetParameters(parametros);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(Datos);
            reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            NE_Cuentas cuenta = new NE_Cuentas();
            ReportDataSource Datos = new ReportDataSource("DataSet1", cuenta.Estadistica_CuentasxTipoDoc(cmb_tipo_cuenta.SelectedValue.ToString()));
            rv01.LocalReport.ReportEmbeddedResource = "BankApp.Formularios.GraficosEstadisticos.Cuentas.Rep_EstadisticaCuentasxTipo.rdlc";
            
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("RP01", "Para el Tipo de Cuenta " + cmb_tipo_cuenta.SelectedValue.ToString());
            rv01.LocalReport.SetParameters(parametros);           
            rv01.LocalReport.DataSources.Clear();
            rv01.LocalReport.DataSources.Add(Datos);
            rv01.RefreshReport();
        }
    }
}
