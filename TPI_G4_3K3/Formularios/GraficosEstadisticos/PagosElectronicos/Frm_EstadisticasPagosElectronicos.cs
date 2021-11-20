using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankApp.Negocios;
using Microsoft.Reporting.WinForms;

namespace BankApp.Formularios.GraficosEstadisticos.PagosElectronicos
{
    public partial class Frm_EstadisticasPagosElectronicos : BankApp.Formularios.FrmBase.Frm_Base
    {
        public Frm_EstadisticasPagosElectronicos()
        {
            InitializeComponent();
        }

        private void Frm_EstadisticasPagosElectronicos_Load(object sender, EventArgs e)
        {

            this.rv01.RefreshReport();
            this.rv02.RefreshReport();
            this.rv01.RefreshReport();
            this.rv02.RefreshReport();
        }

        private void btn_buscar01_Click(object sender, EventArgs e)
        {
            if (txt_ano._Text != string.Empty && txt_mes._Text != "" && txt_mes2._Text != "")
            {
                ArmarReporteEstadisticoValoresMensualesSueldos();
            }
            else
            {
                MessageBox.Show("Debe ingresar el año y mes para buscar.");
                return;
            }
        }

        private void ArmarReporteEstadisticoValoresMensualesSueldos()
        {
            NE_Pago_Electronico pg = new NE_Pago_Electronico();

            ReportDataSource Datos = new ReportDataSource("DataSet1", pg.ValoresMensualesPagosElectronicos(txt_ano._Text, txt_mes._Text, txt_mes2._Text));
            if (chk_01.Checked == false)
                rv01.LocalReport.ReportEmbeddedResource = "BankApp.Formularios.GraficosEstadisticos.PagosElectronicos.RepEstadisticaPagosElectronicos01.rdlc";
            else
                rv01.LocalReport.ReportEmbeddedResource = "BankApp.Formularios.GraficosEstadisticos.PagosElectronicos.RepEstadisticaPagosElectronicos02.rdlc";

            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("PR01", "Para el año " + txt_ano._Text + " entre el mes " + txt_mes._Text + " y el mes " + txt_mes2._Text);
            rv01.LocalReport.SetParameters(parametros);
            rv01.LocalReport.DataSources.Clear();
            rv01.LocalReport.DataSources.Add(Datos);
            rv01.RefreshReport();
        }
  
    private void btn_buscar02_Click(object sender, EventArgs e)
        {
            if (txt_ano01._Text != "" && txt_mes01._Text != "")
            {
                CalculoComparativoServicios();
            }
            else
            {
                MessageBox.Show("Debe ingresar el año y mes para buscar.");
                return;
            }
        }
        private void CalculoComparativoServicios()
        {
            NE_Pago_Electronico pg = new NE_Pago_Electronico();

            ReportDataSource Datos = new ReportDataSource("PE01", pg.ServiciosMensualesPagosElectronicos(txt_ano01._Text, txt_mes01._Text));
            rv02.LocalReport.ReportEmbeddedResource = "BankApp.Formularios.GraficosEstadisticos.PagosElectronicos.RepEstadisticaComparacionPagosElectronicos.rdlc";

            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("PR03", "Para el año " + txt_ano01._Text + " del mes " + txt_mes01._Text);
            rv02.LocalReport.SetParameters(parametros);

            rv02.LocalReport.DataSources.Clear();
            rv02.LocalReport.DataSources.Add(Datos);
            rv02.RefreshReport();
        }
    }
}
