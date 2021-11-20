using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankApp.Negocios;

namespace BankApp.Formularios.Monedas
{
    public partial class Frm_Monedas_Borrar : BankApp.Formularios.Monedas.Frm_Monedas
    {
        public Frm_Monedas_Borrar()
        {
            InitializeComponent();
        }
        private void CargarFormulario(DataTable tabla)
        {
            txt_id._Text = tabla.Rows[0]["id"].ToString();
            txt_nombre._Text = tabla.Rows[0]["nombre"].ToString();
            labelText3._Text = tabla.Rows[0]["simbolo"].ToString();
        }

        private void Frm_Monedas_Borrar_Load(object sender, EventArgs e)
        {
            NE_Monedas mon = new NE_Monedas();
            CargarFormulario(mon.BuscarMoneda(id));
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            NE_Monedas mon = new NE_Monedas();
            mon.id = id;

            if (MessageBox.Show("Está seguro de querer borrar la moneda:\n"+txt_nombre._Text+"?","Importante",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                mon.Borrar();
                MessageBox.Show("El moneda se borró correctamente", "Importante");
            }

        }
    }
}
