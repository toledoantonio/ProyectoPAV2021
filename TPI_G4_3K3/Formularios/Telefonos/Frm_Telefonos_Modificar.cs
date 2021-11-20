using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankApp.Negocios;
using BankApp.Clases;

namespace BankApp.Formularios.Telefonos
{
    public partial class Frm_Telefonos_Modificar : BankApp.Formularios.Telefonos.Frm_Telefonos
    {
        public Frm_Telefonos_Modificar()
        {
            InitializeComponent();
        }


        private void CargarFormulario(DataTable tabla)
        {
            txt_numero._Text = tabla.Rows[0]["numero"].ToString();
            txt_id._Text = tabla.Rows[0]["id_usuario"].ToString();
        }


        private void Frm_Telefonos_Modificar_Load(object sender, EventArgs e)
        {
            NE_Telefonos tel = new NE_Telefonos();
            CargarFormulario(tel.RecuperarTelefono(numero));
        }

        private void btn_aceptar_Click_1(object sender, EventArgs e)
        {
            TratamientosEspeciales _TE = new TratamientosEspeciales();

            if (_TE.Validar(this.Controls) == TratamientosEspeciales.RespuestaValidacion.Correcta)
            {
                NE_Telefonos tel = new NE_Telefonos();
                tel.numero = txt_numero._Text;
                tel.id_usuario = txt_id._Text;
                tel.Modificar();
                MessageBox.Show("La modificación se realizó Correctamente.", "Importante");
            }
        }
    }
}
