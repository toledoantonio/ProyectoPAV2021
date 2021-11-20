using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankApp.Clases;
using BankApp.Negocios;

namespace BankApp.Formularios.Monedas
{
    public partial class Frm_Monedas_Alta : BankApp.Formularios.Monedas.Frm_Monedas
    {
        public Frm_Monedas_Alta()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales _TE = new TratamientosEspeciales();

            if(_TE.Validar(this.Controls) == TratamientosEspeciales.RespuestaValidacion.Correcta)
            {
                NE_Monedas mon = new NE_Monedas();

                mon.nombre = txt_nombre._Text;
                mon.simbolo = labelText3._Text;

                id = mon.Insertar();
                txt_id._Text = id;

                MessageBox.Show("La moneda se registro correctamente correctamente.");
            }

        }
    }
}
