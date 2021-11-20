using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankApp.Clases;
using BankApp.Negocios;

namespace BankApp.Formularios.Tipo_de_Premio
{
    public partial class Frm_Tipo_Premio_Alta : BankApp.Formularios.Tipo_de_Premio.Frm_Tipo_Premio
    {
        public Frm_Tipo_Premio_Alta()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales _TE = new TratamientosEspeciales();

            if (_TE.Validar(this.Controls) == TratamientosEspeciales.RespuestaValidacion.Correcta)
            {
                NE_TipoDePremio ser = new NE_TipoDePremio();

                txt_id._Text = ser.Insertar(this.Controls);

                MessageBox.Show("Se Grabó correctamente el Premio", "Importante");
            }
    }   }
}
