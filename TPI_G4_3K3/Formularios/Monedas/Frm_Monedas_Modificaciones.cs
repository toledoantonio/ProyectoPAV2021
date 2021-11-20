using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankApp.Negocios;
using BankApp.Clases;

namespace BankApp.Formularios.Monedas
{
    public partial class Frm_Monedas_Modificaciones : BankApp.Formularios.Monedas.Frm_Monedas
    {
        public Frm_Monedas_Modificaciones()
        {
            InitializeComponent();
        }

        private void CargarFormulario(DataTable tabla)
        {
            txt_id._Text = tabla.Rows[0]["id"].ToString();
            txt_nombre._Text = tabla.Rows[0]["nombre"].ToString();
            labelText3._Text = tabla.Rows[0]["simbolo"].ToString();
        }

        private void Frm_Monedas_Modificaciones_Load(object sender, EventArgs e)
        {
            NE_Monedas mon = new NE_Monedas();
            CargarFormulario(mon.BuscarMoneda(id));
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales _TE = new TratamientosEspeciales();

            if (_TE.Validar(this.Controls) == TratamientosEspeciales.RespuestaValidacion.Correcta)
            {
                NE_Monedas mon = new NE_Monedas();

                mon.id = txt_id._Text;
                mon.nombre = txt_nombre._Text;
                mon.simbolo = labelText3._Text;
                mon.Modificar();

                MessageBox.Show("La modificación de la moneda se realizó correctamente.","Importante");
            }
        }
    }
}
