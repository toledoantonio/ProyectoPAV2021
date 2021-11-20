using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using BankApp.Negocios;


namespace BankApp.Formularios.Reportes.Telefonos
{
    public partial class Frm_ReportesUsuarios : BankApp.Formularios.FrmBase.Frm_Base
    {
        public Frm_ReportesUsuarios()
        {
            InitializeComponent();
        }

        private void Frm_ReportesTelefonos_Load(object sender, EventArgs e)
        {

            this.rv_usuarios.RefreshReport();
            cmb_tipo_doc._Cargar();
        }


        private void btn_calcular1_Click(object sender, EventArgs e)
        {
            NE_Usuarios usuario = new NE_Usuarios();
            DataTable tabla = new DataTable();

            //Validacion

            if (txt_nombre.ToString() == "" )
            {
                MessageBox.Show("No se cargo ningun Nombre de busqueda", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            tabla = usuario.ReporteUsuarios(cmb_tipo_doc.SelectedValue.ToString(), txt_nombre._Text);
            ReportDataSource datos = new ReportDataSource("DataSet1", tabla);
            rv_usuarios.LocalReport.ReportEmbeddedResource = "BankApp.Formularios.Reportes.Usuarios.Rprt_Usuarios.rdlc";

            ReportParameter[] parametro = new ReportParameter[1];
            parametro[0] = new ReportParameter("RP01", "Para el Nombre: " + txt_nombre._Text + " y el Tipo de Documento: " + cmb_tipo_doc.SelectedValue.ToString());
            rv_usuarios.LocalReport.SetParameters(parametro);
            rv_usuarios.LocalReport.DataSources.Clear();
            rv_usuarios.LocalReport.DataSources.Add(datos);
            rv_usuarios.RefreshReport();
        }
    }
}
