using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankApp.Negocios;
using Microsoft.Reporting.WinForms;
using BankApp.Formularios.GraficosEstadisticos.Transferencias;

namespace BankApp.Formularios.GraficosEstadisticos.Transferencias
{
    public partial class Frm_Estadisticas_Transferencias : BankApp.Formularios.FrmBase.Frm_Base
    {
        public Frm_Estadisticas_Transferencias()
        {
            InitializeComponent();
        }

        private void Frm_Estadisticas_Transferencias_Load(object sender, EventArgs e)
        {

            this.rv01.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.rv02.RefreshReport();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_buscar01_Click(object sender, EventArgs e)
        {

            if (txt_Año01._Text != "" && txt_MesDesde01._Text != "" && txt_MesHasta01._Text != "")
            {
                armarMensualesTransfrencias();
            }
            else
            {
                MessageBox.Show("Faltan valores de busqueda", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void armarMensualesTransfrencias()
        {
            NE_Transferencias trans = new NE_Transferencias();

            string año = txt_Año01._Text;
            string mes1 = txt_MesDesde01._Text;
            string mes2 = txt_MesHasta01._Text;

            ReportDataSource datos = new ReportDataSource("DataSet1", trans.estadisticaMensualesTransfrencias(txt_Año01._Text, txt_MesDesde01._Text, txt_MesHasta01._Text));
            if (chk_DatosValorTotal.Checked)
            {
                rv01.LocalReport.ReportEmbeddedResource = "BankApp.Formularios.GraficosEstadisticos.Transferencias.Rpt_Estadisticas_Transferencias02.rdlc";
            }
            else
            {
                rv01.LocalReport.ReportEmbeddedResource = "BankApp.Formularios.GraficosEstadisticos.Transferencias.Rpt_Estadisticas_Transferencias01.rdlc";
            }
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("RP01", "Para el año: "+ año + " entre el mes: "+ mes1 + " y el mes: " + mes2);
            rv01.LocalReport.SetParameters(parametros);
            rv01.LocalReport.DataSources.Clear();
            rv01.LocalReport.DataSources.Add(datos);
            rv01.RefreshReport();
            
        }

        private void buttonLC_Click(object sender, EventArgs e)
        {
            if (txt_CuentaOrigen._Text != "" && txt_CuentaDestino._Text != "")
            {
                ArmarReporteEstadisticoTransferenciasxCuentas();
            }
            else
            {
                MessageBox.Show("Debe ingresar Cuenta de Origen y Destino para buscar.");
                return;
            }
        }

        private void ArmarReporteEstadisticoTransferenciasxCuentas()
        {
            NE_Transferencias trans = new NE_Transferencias();
            ReportDataSource Datos = new ReportDataSource("DataSet1", trans.Estadistica_TransferenciasxCuentas(txt_CuentaOrigen._Text, txt_CuentaDestino._Text));
            reportViewer1.LocalReport.ReportEmbeddedResource = "BankApp.Formularios.GraficosEstadisticos.Transferencias.Rpt_Estadisticas_TrasnferenciasxCuentas.rdlc";

            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("RP10", "Para el la Cuenta Origen: " + txt_CuentaOrigen._Text + " y la Cuenta Destino: " + txt_CuentaDestino._Text);
            reportViewer1.LocalReport.SetParameters(parametros);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(Datos);
            reportViewer1.RefreshReport();
        }

        private void btn_buscar02_Click(object sender, EventArgs e)
        {
            if (txt_fechaDesde01._Text.Trim().Remove(0, 1).Trim() != "/"  && txt_fechaHasta01._Text.Trim().Remove(0, 1).Trim() != "/")
            {
                armarMensualesTransfrenciasxMonedas();
            }
            else
            {
                MessageBox.Show("Faltan valores de busqueda", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void armarMensualesTransfrenciasxMonedas()
        {
            NE_Transferencias trans = new NE_Transferencias();

            string fechaDesde = txt_fechaDesde01._Text;
            string fechaHasta = txt_fechaHasta01._Text;
            

            ReportDataSource datos = new ReportDataSource("DataSet1", trans.estadisticaMensualesTransfrenciasxMonedas(txt_fechaDesde01._Text, txt_fechaHasta01._Text));
            //if (chk_DatosValorTotal.Checked)
            //{
            //    rv02.LocalReport.ReportEmbeddedResource = "BankApp.Formularios.GraficosEstadisticos.Transferencias.Rpt_Estadisticas_TransferenciasMonedas02.rdlc";
            //}
            //else
            //{
            rv02.LocalReport.ReportEmbeddedResource = "BankApp.Formularios.GraficosEstadisticos.Transferencias.Rpt_Estadisticas_TransferenciasMonedas.rdlc";
            //}
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("RP01", "Para la fecha: " + fechaDesde + " hasta la fecha: " + fechaHasta);
            rv02.LocalReport.SetParameters(parametros);
            rv02.LocalReport.DataSources.Clear();
            rv02.LocalReport.DataSources.Add(datos);
            rv02.RefreshReport();
        }
    }
}
