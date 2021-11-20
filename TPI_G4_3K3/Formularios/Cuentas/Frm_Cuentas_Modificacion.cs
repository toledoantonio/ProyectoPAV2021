using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankApp.Negocios;
using BankApp.Formularios.Cuentas;
using BankApp.Clases;

namespace BankApp.Formularios.Cuentas
{
    public partial class Frm_Cuentas_Modificacion : BankApp.Formularios.Cuentas.Frm_Cuentas
    {
        public Frm_Cuentas_Modificacion()
        {
            InitializeComponent();
        }

        private void Frm_Cuentas_Modificacion_Load(object sender, EventArgs e)
        {
            NE_Cuentas cuen = new NE_Cuentas();
            CargarFormulario(cuen.RecuperarCuenta(numero));
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales _TE = new TratamientosEspeciales();

            if (_TE.Validar(this.Controls) == TratamientosEspeciales.RespuestaValidacion.Correcta)
            {
                NE_Cuentas cuen = new NE_Cuentas();
                cuen.numero = txt_numero._Text;
                cuen.id_usuario = txt_id_usuario._Text;
                cuen.tipo_cuenta = cmb_tiposCuentas.SelectedValue.ToString();
                cuen.id_moneda = cmb_monedas.SelectedValue.ToString();
                cuen.puntos_total = txt_puntos._Text;
                cuen.saldo = txt_saldo._Text;

                cuen.Modificar();
                MessageBox.Show("La modificación se realizó Correctamente.", "Importante");
            }
        }
    }
}
