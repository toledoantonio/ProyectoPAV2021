using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankApp.Clases;
using BankApp.Negocios;

namespace BankApp.Formularios.Tipos_de_Documentos
{
    public partial class Frm_Tipos_Documentos_Alta : BankApp.Formularios.Tipos_de_Documentos.Frm_Tipos_Documentos
    {
        public Frm_Tipos_Documentos_Alta()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales _TE = new TratamientosEspeciales();

            if (_TE.Validar(this.Controls) == TratamientosEspeciales.RespuestaValidacion.Correcta)
            {
                NE_Tipos_Documentos tdoc = new NE_Tipos_Documentos();

                txt_id._Text = tdoc.Insertar(this.Controls);

                MessageBox.Show("Se Grabó correctamente el Tipo de Documento", "Importante");
            }
            
        }
    }
}
