using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankApp.Clases;
using BankApp.Negocios;

namespace BankApp.Formularios.Servicio
{
    public partial class Frm_Servicios_Alta : BankApp.Formularios.Servicio.Frm_Servicios
    {
        public Frm_Servicios_Alta()
        {
            InitializeComponent();
        }
        private void btn_aceptar_Click_1(object sender, EventArgs e)
        {
            //1)validar los datos del formulario
            //puede suceder que la validación de todo ok => grabo en la base de datos
            //o puede suceder que la validacion de error => ir a corregir el error

            TratamientosEspeciales _TE = new TratamientosEspeciales();

            if (_TE.Validar(this.Controls) == TratamientosEspeciales.RespuestaValidacion.Correcta)
            {
                NE_Servicios ser = new NE_Servicios();           
                txt_id._Text = ser.Insertar(this.Controls);

                MessageBox.Show("Se Grabó correctamente", "Importante");
            }
        }

        
    }
}
