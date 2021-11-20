using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankApp.Clases;
using BankApp.Negocios;

namespace BankApp.Formularios.Tipos_de_Operaciones
{
    public partial class Frm_Tipos_Operaciones_Alta : BankApp.Formularios.Tipos_de_Operaciones.Frm_Tipos_Operaciones
    {
        public Frm_Tipos_Operaciones_Alta()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales _TE = new TratamientosEspeciales();

            if (_TE.Validar(this.Controls) == TratamientosEspeciales.RespuestaValidacion.Correcta)
            {
                NE_Tipos_Operaciones ser = new NE_Tipos_Operaciones();

                txt_id._Text = ser.Insertar(this.Controls);

                MessageBox.Show("Se Grabó correctamente el Tipo de Operacion", "Importante");
            }
        }
    }
}
