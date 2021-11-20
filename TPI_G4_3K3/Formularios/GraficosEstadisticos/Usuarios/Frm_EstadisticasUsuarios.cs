using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankApp.Formularios.GraficosEstadisticos.Usuarios;
using BankApp.Negocios;
using Microsoft.Reporting.WinForms;

namespace BankApp.Formularios.GraficosEstadisticos.Usuarios
{
    public partial class Frm_EstadisticasUsuarios : BankApp.Formularios.FrmBase.Frm_Base
    {
        public Frm_EstadisticasUsuarios()
        {
            InitializeComponent();
        }

        private void Frm_EstadisticasUsuarios_Load(object sender, EventArgs e)
        {

            this.rv01.RefreshReport();
        }

        private void btn_buscar01_Click(object sender, EventArgs e)
        {
            if (txt_nombre._Text != "")
            {
                ArmarReporteEstadisticoUsuarios();
            }
            else
            {
                MessageBox.Show("Debe ingresar el nombre para buscar.");
                return;
            }


        }
        public void ArmarReporteEstadisticoUsuarios()
        {

            NE_Usuarios usuario = new NE_Usuarios();

            ReportDataSource datos = new ReportDataSource("DataSet1", usuario.Estadistica_Usuarios(txt_nombre._Text));
            rv01.LocalReport.ReportEmbeddedResource = "BankApp.Formularios.GraficosEstadisticos.Usuarios.RepEstadisticaUsuarios.rdlc";
            
            ReportParameter[] parametro = new ReportParameter[1];
            parametro[0] = new ReportParameter("PR01", "Para el Nombre: " + txt_nombre._Text );
            rv01.LocalReport.SetParameters(parametro);
            rv01.LocalReport.DataSources.Clear();
            rv01.LocalReport.DataSources.Add(datos);
            rv01.RefreshReport();

        }

    }
}
