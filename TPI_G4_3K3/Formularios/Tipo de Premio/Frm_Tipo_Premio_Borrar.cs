using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankApp.Negocios;
using BankApp.Clases;

namespace BankApp.Formularios.Tipo_de_Premio
{
    public partial class Frm_Tipo_Premio_Borrar : BankApp.Formularios.Tipo_de_Premio.Frm_Tipo_Premio
    {
        public Frm_Tipo_Premio_Borrar()
        {
            InitializeComponent();
        }

        private void Frm_Tipo_Premio_Borrar_Load(object sender, EventArgs e)
        {
            NE_TipoDePremio usu = new NE_TipoDePremio();
            CargarFormulario(usu.RecuperarTipoPremio(id));
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            NE_TipoDePremio tpre = new NE_TipoDePremio();
            tpre.id = id;
            if (MessageBox.Show("Está seguro de querer borrar el Tipo de Premio " + txt_nombre._Text + "?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tpre.Borrar();
                MessageBox.Show("El Tipo de Premio se borró Correctamente", "Importante");
            }
            else
                MessageBox.Show("No se procedió a borrar");
        }
    }
}
