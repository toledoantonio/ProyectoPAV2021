using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankApp.Negocios;
using Microsoft.Reporting.WinForms;

namespace BankApp.Formularios.GraficosEstadisticos.Canjes
{
    public partial class Frm_EstadisticasCanjes : BankApp.Formularios.FrmBase.Frm_Base
    {
        public Frm_EstadisticasCanjes()
        {
            InitializeComponent();
        }

        private void Frm_EstadisticasCanjes_Load(object sender, EventArgs e)
        {

            this.rv01.RefreshReport();
            this.rv02.RefreshReport();
        }

        private void btn_buscar01_Click(object sender, EventArgs e)
        {

            if (txt_anno._Text != string.Empty && txt_mes_desde._Text != "" && txt_mes_desde._Text != "")
            {
                ArmarReporteEstadistico();
            }
            else
            {
                MessageBox.Show("Debe ingresar el año y mes para buscar.");
                return;
            }
        }

        private void ArmarReporteEstadistico()
        {
            NE_Canjes canje = new NE_Canjes();

            ReportDataSource Datos = new ReportDataSource("DataSet1", canje.Estadistica_Canje(txt_anno._Text, txt_mes_desde._Text, txt_mes_hasta._Text));
            if(chk_puntos_totales.Checked == false)
                rv01.LocalReport.ReportEmbeddedResource = "BankApp.Formularios.GraficosEstadisticos.Canjes.RepEstadisticaCanjes01.rdlc";
            else
                rv01.LocalReport.ReportEmbeddedResource = "BankApp.Formularios.GraficosEstadisticos.Canjes.RepEstadisticaCanjes02.rdlc";
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("PR01", "Para el año "+txt_anno._Text+" entre el mes "+txt_mes_desde._Text+" y mes "+txt_mes_hasta._Text);
            rv01.LocalReport.SetParameters(parametros);
            rv01.LocalReport.DataSources.Clear();
            rv01.LocalReport.DataSources.Add(Datos);
            rv01.RefreshReport();
        }

        private void btn_buscar02_Click(object sender, EventArgs e)
        {
            if(txt_anno2._Text != "" && txt_mes2._Text != "")
            {
                ArmarReporteEstadistico2();
            }
            else
            {
                MessageBox.Show("Debe ingresar el año y mes para buscar.");
                return;
            }
        }

        private void ArmarReporteEstadistico2()
        {
            NE_Canjes canje = new NE_Canjes();
            ReportDataSource Datos = new ReportDataSource("DataSet1", canje.Estadistica2_Canje(txt_anno2._Text, txt_mes2._Text));
            rv02.LocalReport.ReportEmbeddedResource = "BankApp.Formularios.GraficosEstadisticos.Canjes.RepEstadisticaComparacionCanjes.rdlc";
            
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("PR01", "Para el año " + txt_anno2._Text + " y mes " + txt_mes2._Text);
            rv02.LocalReport.SetParameters(parametros);

            rv02.LocalReport.DataSources.Clear();
            rv02.LocalReport.DataSources.Add(Datos);
            rv02.RefreshReport();
        }
    }
}
