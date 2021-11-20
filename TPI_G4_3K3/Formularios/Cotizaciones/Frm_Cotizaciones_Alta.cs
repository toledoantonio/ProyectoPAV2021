using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankApp.Clases;
using BankApp.Negocios;

namespace BankApp.Formularios.Cotizaciones
{
    public partial class Frm_Cotizaciones_Alta : BankApp.Formularios.Cotizaciones.Frm_Cotizaciones
    {
        public Frm_Cotizaciones_Alta()
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
                NE_Cotizaciones cot = new NE_Cotizaciones();

                cot.id = txt_id._Text;
                cot.moneda_origen = txt_cmb_mon_org.SelectedValue.ToString();
                cot.moneda_destino = txt_cmb_mon_dest.SelectedValue.ToString();
                cot.fecha = txt_fecha._Text;
                cot.valor = txt_valor._Text;
                id = cot.Insertar();
                txt_id._Text = id;

                MessageBox.Show("Se Grabó correctamente la Cotizacion", "Importante");
            }
        }
    }
}
