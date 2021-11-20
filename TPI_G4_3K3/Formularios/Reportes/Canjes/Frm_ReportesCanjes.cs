using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using BankApp.Negocios;

namespace BankApp.Formularios.Reportes.Canjes
{
    public partial class Frm_ReportesCanjes : BankApp.Formularios.FrmBase.Frm_Base
    {
        public Frm_ReportesCanjes()
        {
            InitializeComponent();
        }

        private void Frm_ReportesCanjes_Load(object sender, EventArgs e)
        {

            this.rv_canjes.RefreshReport();
            this.rv_premios.RefreshReport();
            cmb_tipo_premio._Cargar();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            NE_Canjes canje = new NE_Canjes();
            DataTable tabla = new DataTable();

            tabla = canje.Reporte_Canjes(txt_id_usuario._Text,txt_fecha_desde._Text, txt_fecha_hasta._Text);
            ReportDataSource datos = new ReportDataSource("DataSet1",tabla);
            rv_canjes.LocalReport.ReportEmbeddedResource = "BankApp.Formularios.Reportes.Canjes.Rprt_Canjes.rdlc";

            ReportParameter[] parametro = new ReportParameter[3];
            parametro[0] = new ReportParameter("RP01", "Para el Id Usuario: " + txt_id_usuario._Text);
            parametro[1] = new ReportParameter("RP02", "Desde la fecha: " + txt_fecha_desde._Text);
            parametro[2] = new ReportParameter("RP03", "Hasta la fecha: " + txt_fecha_hasta._Text);
            rv_canjes.LocalReport.SetParameters(parametro);

            rv_canjes.LocalReport.DataSources.Clear();
            rv_canjes.LocalReport.DataSources.Add(datos);
            rv_canjes.RefreshReport();
        }

        private void btn_calcular2_Click(object sender, EventArgs e)
        {
            NE_Premios premio = new NE_Premios();
            DataTable tabla = new DataTable();

            string id_tipo_premio = "";
            if (cmb_tipo_premio.SelectedIndex == -1)
                tabla = premio.Reporte_Premios(id_tipo_premio, txt_puntos_min._Text, txt_puntos_max._Text);
            else
                id_tipo_premio = cmb_tipo_premio.SelectedValue.ToString();
                tabla = premio.Reporte_Premios(id_tipo_premio, txt_puntos_min._Text, txt_puntos_max._Text);
            ReportDataSource datos = new ReportDataSource("DataSet1", tabla);
            rv_premios.LocalReport.ReportEmbeddedResource = "BankApp.Formularios.Reportes.Canjes.Rprt_Premio.rdlc";

            ReportParameter[] parametro = new ReportParameter[3];
            parametro[0] = new ReportParameter("RP01", "Para el Id Tipo de Premio: " + id_tipo_premio);
            parametro[1] = new ReportParameter("RP02", "Puntos Mínimos: " + txt_puntos_min._Text);
            parametro[2] = new ReportParameter("RP03", "Puntos Máximos: " + txt_puntos_max._Text);
            rv_premios.LocalReport.SetParameters(parametro);

            rv_premios.LocalReport.DataSources.Clear();
            rv_premios.LocalReport.DataSources.Add(datos);
            rv_premios.RefreshReport();
        }
    }
}
