using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankApp.Negocios;
using BankApp.Clases;

namespace BankApp.Formularios.Tarifa
{
    public partial class Frm_Tarifas_Baja : BankApp.Formularios.Tarifa.Frm_Tarifas
    {
        public Frm_Tarifas_Baja()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            NE_Tarifas tar = new NE_Tarifas();
            tar.id = id;
            if (MessageBox.Show("Está seguro de querer borrar La Tarifa ID: " + txt_id._Text + "?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tar.Borrar();
                MessageBox.Show("La Tarifa se borró correctamente", "Importante");
            }
            else
                MessageBox.Show("No se procedió a borrar");
        }
        public void CargarFormulario(DataTable tabla)
        {
            txt_id._Text = tabla.Rows[0]["id"].ToString();
            txt_fecha_vig_desde._Text = tabla.Rows[0]["fecha_vig_desde"].ToString();
            txt_fecha_vig_hasta._Text = tabla.Rows[0]["fecha_vig_hasta"].ToString();
            txt_monto_base._Text = tabla.Rows[0]["monto_base"].ToString();
            txt_monto_sup._Text = tabla.Rows[0]["monto_superior"].ToString();
            txt_porcentaje._Text = tabla.Rows[0]["porcentaje"].ToString();
        }

        private void Frm_Tarifas_Baja_Load(object sender, EventArgs e)
        {
            NE_Tarifas tar = new NE_Tarifas();
            CargarFormulario(tar.RecuperarTarifas(id));
        }
    }
}
