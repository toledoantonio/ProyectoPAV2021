using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using BankApp.Negocios;

namespace BankApp.Formularios.Reportes.Pagos_Electronicos
{
    public partial class Frm_ReportesPagosElectronicos : BankApp.Formularios.FrmBase.Frm_Base
    {
        public Frm_ReportesPagosElectronicos()
        {
            InitializeComponent();
        }

        private void Frm_ReportesPagosElectronicos_Load(object sender, EventArgs e)
        {
            this.PagElec.RefreshReport();
            cmb_servicios._Cargar();
            this.PagElec.RefreshReport();
            this.PagElec2.RefreshReport();
        }

        private void btn_buscar01_Click_1(object sender, EventArgs e)
        {
            NE_Pago_Electronico pg = new NE_Pago_Electronico();
            DataTable tabla = new DataTable();
            //validaciones

            string id_servicio = "";
            if (cmb_servicios.SelectedIndex == -1)
                tabla = pg.BuscarPagosxMesAno(id_servicio, txt_mes._Text, txt_ano._Text);
            else
                id_servicio = cmb_servicios.SelectedValue.ToString();
            tabla = pg.BuscarPagosxMesAno(id_servicio, txt_mes._Text, txt_ano._Text);

            ReportDataSource datos = new ReportDataSource("DataSet1", tabla);
            PagElec.LocalReport.ReportEmbeddedResource = "BankApp.Formularios.Reportes.PagoElectronico.Rprt_PagosElectronicos.rdlc";
            ReportParameter[] parametro = new ReportParameter[2];
            parametro[0] = new ReportParameter("RP01", "Para el Id de Servicio: " + id_servicio);
            parametro[1] = new ReportParameter("RP02", "Para el año: " + txt_ano._Text + " y mes: " + txt_mes._Text);

            PagElec.LocalReport.SetParameters(parametro);

            PagElec.LocalReport.DataSources.Clear();
            PagElec.LocalReport.DataSources.Add(datos);
            PagElec.RefreshReport();
        }

        private void btn_buscar02_Click(object sender, EventArgs e)
        {
            NE_Pago_Electronico pg = new NE_Pago_Electronico();
            DataTable tabla = new DataTable();

            tabla = pg.BuscarPagosxPuntosImportes(txt_id_pago._Text, txt_importe_min._Text, txt_importe_max._Text, txt_puntos_min._Text, txt_puntos_max._Text);

            ReportDataSource datos = new ReportDataSource("DataSet1", tabla);
            PagElec2.LocalReport.ReportEmbeddedResource = "BankApp.Formularios.Reportes.PagoElectronico.Rprt_ReportesPagosElectronicos01.rdlc";
            ReportParameter[] parametro = new ReportParameter[5];
            parametro[0] = new ReportParameter("RP01", "Para el Id de Pago Electronico: " + txt_id_pago._Text);
            parametro[1] = new ReportParameter("RP02", "Puntos Mínimos: " + txt_importe_min._Text);
            parametro[2] = new ReportParameter("RP03", "Puntos Maximos: " + txt_importe_max._Text);
            parametro[3] = new ReportParameter("RP04", "Importes Minimos: " + txt_puntos_min._Text);
            parametro[4] = new ReportParameter("RP05", "Importes Maximos: " + txt_puntos_max._Text);

            PagElec2.LocalReport.SetParameters(parametro);

            PagElec2.LocalReport.DataSources.Clear();
            PagElec2.LocalReport.DataSources.Add(datos);
            PagElec2.RefreshReport();
        }
    }
}
