using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankApp.Negocios;

namespace BankApp.Formularios.Tipos_de_Cuentas
{
    public partial class Frm_Tipos_Cuentas_Borrar : BankApp.Formularios.Tipos_de_Cuentas.Frm_TiposCuentas
    {
        public Frm_Tipos_Cuentas_Borrar()
        {
            InitializeComponent();
        }

        private void Frm_Tipos_Cuentas_Borrar_Load(object sender, EventArgs e)
        {
            NE_Tipos_Cuentas tc = new NE_Tipos_Cuentas();
            CargarFormulario(tc.RecuperarTipoCuenta(id));
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            NE_Tipos_Cuentas tc = new NE_Tipos_Cuentas();
            tc.id = id;
            if (MessageBox.Show("Está seguro de querer borrar el Tipo de Cuenta " + txt_descripcion._Text + "?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tc.Borrar();
                MessageBox.Show("El Premio se borró correctamente", "Importante");
            }
            else
                MessageBox.Show("No se procedió a borrar");
        }
    }
}
