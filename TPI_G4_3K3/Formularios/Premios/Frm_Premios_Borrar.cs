using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankApp.Negocios;
using BankApp.Clases;

namespace BankApp.Formularios.Premios
{
    public partial class Frm_Premios_Borrar : BankApp.Formularios.Premios.Frm_Premios
    {
        public Frm_Premios_Borrar()
        {
            InitializeComponent();
        }
        private void Frm_Premios_Borrar_Load(object sender, EventArgs e)
        {
            NE_Premios prem = new NE_Premios();
            CargarFormulario(prem.RecuperarPremio(codigo));
        }
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            NE_Premios prem = new NE_Premios();
            prem.codigo = codigo;
            if (MessageBox.Show("Está seguro de querer borrar el Premio " + txt_descripcion._Text + "?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                prem.Borrar();
                MessageBox.Show("El Premio se borró correctamente", "Importante");
            }
            else
                MessageBox.Show("No se procedió a borrar");
        }
    }
}
