using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankApp.Clases;
using BankApp.Negocios;

namespace BankApp.Formularios.Tarifa
{
    public partial class Frm_Tarifas_Alta : BankApp.Formularios.Tarifa.Frm_Tarifas
    {
        public Frm_Tarifas_Alta()
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
                NE_Tarifas tar = new NE_Tarifas();

                tar.id = txt_id._Text;
                tar.fecha_vig_desde = txt_fecha_vig_desde._Text;
                tar.fecha_vig_hasta = txt_fecha_vig_hasta._Text;
                tar.monto_base = txt_monto_base._Text;
                tar.monto_superior = txt_monto_sup._Text;
                tar.porcentaje = txt_porcentaje._Text;
                id = tar.Insertar();
                txt_id._Text = id;

                MessageBox.Show("Se grabó correctamente la tarifa", "Importante");
            }
        }
    }
}
