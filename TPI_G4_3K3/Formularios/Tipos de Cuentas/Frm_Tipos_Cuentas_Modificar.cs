using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankApp.Negocios;
using BankApp.Clases;


namespace BankApp.Formularios.Tipos_de_Cuentas
{
    public partial class Frm_Tipos_Cuentas_Modificar : BankApp.Formularios.Tipos_de_Cuentas.Frm_TiposCuentas
    {
        public Frm_Tipos_Cuentas_Modificar()
        {
            InitializeComponent();
        }

        private void Frm_Tipos_Cuentas_Modicar_Load(object sender, EventArgs e)
        {
            NE_Tipos_Cuentas tc = new NE_Tipos_Cuentas();
            CargarFormulario(tc.RecuperarTipoCuenta(id));
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales _TE = new TratamientosEspeciales();

            if (_TE.Validar(this.Controls) == TratamientosEspeciales.RespuestaValidacion.Correcta)
            {
                NE_Tipos_Cuentas tc = new NE_Tipos_Cuentas();

                tc.id = txt_id._Text;
                tc.descripcion = txt_descripcion._Text;
                
                tc.Modificar();
                MessageBox.Show("La modificación se realizó Correctamente.", "Importante");
            }
        }
    }
}
