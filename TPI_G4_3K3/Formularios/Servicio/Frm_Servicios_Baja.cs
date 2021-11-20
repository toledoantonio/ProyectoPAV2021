using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankApp.Negocios;
using BankApp.Clases;

namespace BankApp.Formularios.Servicio
{
    public partial class Frm_Servicios_Baja : BankApp.Formularios.Servicio.Frm_Servicios
    {
        public Frm_Servicios_Baja()
        {
            InitializeComponent();
        }
        
         private void Frm_Servicios_Baja_Load(object sender, EventArgs e)
        {
            NE_Servicios ser = new NE_Servicios();
            CargarFormulario(ser.RecuperarServicio(id));
        }

        private void CargarFormulario(DataTable tabla)
        {
            txt_id._Text = tabla.Rows[0]["id"].ToString();
            txt_nombre._Text = tabla.Rows[0]["nombre"].ToString();
        }

        private void btn_aceptar_Click_1(object sender, EventArgs e)
        {
            NE_Servicios ser = new NE_Servicios();
            ser.id = id;
            if (MessageBox.Show("Está seguro de querer borrar el Servicio Seleccionado " + txt_nombre._Text + "?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ser.Borrar();
                MessageBox.Show("El Servicio " + txt_nombre._Text + " se borró correctamente", "Importante");
            }
            else
                MessageBox.Show("No se procedió a borrar");
        }

        
    }
}
    

