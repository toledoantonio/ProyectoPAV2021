using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankApp.Negocios;

namespace BankApp.Formularios.Cuentas
{
    public partial class Frm_Cuentas_Borrar : BankApp.Formularios.Cuentas.Frm_Cuentas
    {
        public Frm_Cuentas_Borrar()
        {
            InitializeComponent();
        }

        private void Frm_Cuentas_Borrar_Load(object sender, EventArgs e)
        {
            NE_Cuentas cuen = new NE_Cuentas();
            CargarFormulario(cuen.RecuperarCuenta(numero));
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            NE_Cuentas cuen = new NE_Cuentas();
            cuen.numero = numero;
            if (MessageBox.Show("Está seguro de querer borrar la Cuenta " + txt_numero._Text + "?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cuen.Borrar();
                MessageBox.Show("La cuenta se borró correctamente", "Importante");
            }
            else
                MessageBox.Show("No se procedió a borrar");
        }
    }
}
