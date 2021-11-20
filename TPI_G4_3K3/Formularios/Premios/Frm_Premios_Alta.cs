using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankApp.Clases;
using BankApp.Negocios;

namespace BankApp.Formularios.Premios
{
    public partial class Frm_Premios_Alta : BankApp.Formularios.Premios.Frm_Premios
    {
        public Frm_Premios_Alta()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            //1)validar los datos del formulario
            //puede suceder que la validación de todo ok => grabo en la base de datos
            //o puede suceder que la validacion de error => ir a corregir el error

            TratamientosEspeciales _TE = new TratamientosEspeciales();

            if (_TE.Validar(this.Controls) == TratamientosEspeciales.RespuestaValidacion.Correcta)
            {
                NE_Premios ser = new NE_Premios();

                txt_codigo._Text = ser.Insertar(this.Controls);

                MessageBox.Show("Se Grabó correctamente el Premio", "Importante");
            }
        }
    }
}
