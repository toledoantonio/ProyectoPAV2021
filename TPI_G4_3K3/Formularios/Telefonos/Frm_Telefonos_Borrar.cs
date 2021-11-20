using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankApp.Negocios;
using BankApp.Clases;

namespace BankApp.Formularios.Telefonos
{
    public partial class Frm_Telefonos_Borrar : BankApp.Formularios.Telefonos.Frm_Telefonos
    {
        public Frm_Telefonos_Borrar()
        {
            InitializeComponent();
        }

        private void CargarFormulario(DataTable tabla)
        {
            txt_numero._Text = tabla.Rows[0]["numero"].ToString();
            txt_id._Text = tabla.Rows[0]["id_usuario"].ToString();
            
        }


        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            NE_Telefonos tel = new NE_Telefonos();
            tel.numero = numero;
            if (MessageBox.Show("Está seguro de querer borrar el Telefono Seleccionado " + txt_numero._Text + "?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tel.Borrar();
                MessageBox.Show("El Telefono " + txt_numero._Text + " se borró correctamente", "Importante");
            }
            else
                MessageBox.Show("No se procedió a borrar");
        }

        private void Frm_Telefonos_Borrar_Load(object sender, EventArgs e)
        {
            NE_Telefonos tel = new NE_Telefonos();
            CargarFormulario(tel.RecuperarTelefono(numero));
        }


    }
}
