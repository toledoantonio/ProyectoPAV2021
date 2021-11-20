using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankApp.Clases;
using BankApp.Negocios;

namespace BankApp.Formularios.Cuentas
{
    public partial class Frm_Cuentas_Alta : BankApp.Formularios.Cuentas.Frm_Cuentas
    {
        public Frm_Cuentas_Alta()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales _TE = new TratamientosEspeciales();

            if(_TE.Validar(this.Controls) == TratamientosEspeciales.RespuestaValidacion.Error)
            {
                NE_Cuentas cue = new NE_Cuentas();

                cue.tipo_cuenta = cmb_tiposCuentas.SelectedValue.ToString();
                cue.id_usuario = txt_id_usuario._Text.ToString();
                cue.id_moneda = cmb_monedas.SelectedValue.ToString();
                cue.puntos_total = txt_puntos._Text;
                cue.saldo = txt_saldo._Text;

                string numero = cue.Insertar();
                txt_numero._Text = numero;

                //txt_numero._Text = cue.Insertar(this.Controls);

                MessageBox.Show("Se Registro correctamente la Cuenta", "Importante");

            }
        }
        private void Frm_Cuentas_Alta_Load(object sender, EventArgs e)
        {

        }
    }
}
