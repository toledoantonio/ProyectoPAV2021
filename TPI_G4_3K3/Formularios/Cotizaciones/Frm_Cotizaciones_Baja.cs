using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankApp.Negocios;
using BankApp.Clases;

namespace BankApp.Formularios
{
    public partial class Frm_Cotizaciones_Baja : BankApp.Formularios.Cotizaciones.Frm_Cotizaciones
    {
        public Frm_Cotizaciones_Baja()
        {
            InitializeComponent();
        }
        private void Frm_Cotizaciones_Baja_Load_1(object sender, EventArgs e)
        {
            NE_Cotizaciones prem = new NE_Cotizaciones();
            CargarFormulario(prem.RecuperarCotizaciones(id));
        }

        public void CargarFormulario(DataTable tabla)
        {
            txt_id._Text = tabla.Rows[0]["id"].ToString();
            txt_cmb_mon_org.SelectedValue = tabla.Rows[0]["moneda_origen"].ToString();
            txt_cmb_mon_dest.SelectedValue = tabla.Rows[0]["Moneda_destino"].ToString();
            txt_fecha._Text = tabla.Rows[0]["fecha"].ToString();
            txt_valor._Text = tabla.Rows[0]["valor"].ToString();
        }
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            NE_Cotizaciones cot = new NE_Cotizaciones();
            cot.id = id;
            if (MessageBox.Show("Está seguro de querer borrar La cotizacion ID: " + txt_id._Text + "?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cot.Borrar();
                MessageBox.Show("La Cotizacion se borró correctamente", "Importante");
            }
            else
                MessageBox.Show("No se procedió a borrar");
        }

        
    }
}
