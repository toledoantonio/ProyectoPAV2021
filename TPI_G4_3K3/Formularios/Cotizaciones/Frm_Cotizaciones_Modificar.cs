using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankApp.Negocios;
using BankApp.Clases;

namespace BankApp.Formularios.Cotizaciones
{
    public partial class Frm_Cotizaciones_Modificar : BankApp.Formularios.Cotizaciones.Frm_Cotizaciones
    {
        public Frm_Cotizaciones_Modificar()
        {
            InitializeComponent();
        }
        private void Frm_Cotizaciones_Modificar_Load_1(object sender, EventArgs e)
        {
            NE_Cotizaciones cot = new NE_Cotizaciones();
            CargarFormulario(cot.RecuperarCotizaciones(id));
        }

        public void CargarFormulario(DataTable tabla)
        {
            txt_id._Text = tabla.Rows[0]["id"].ToString();
            txt_cmb_mon_org.SelectedValue = tabla.Rows[0]["moneda_origen"].ToString();
            txt_cmb_mon_dest.SelectedValue = tabla.Rows[0]["Moneda_destino"].ToString();
            txt_fecha._Text = tabla.Rows[0]["fecha"].ToString();
            txt_valor._Text = tabla.Rows[0]["valor"].ToString();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales _TE = new TratamientosEspeciales();

            if (_TE.Validar(this.Controls) == TratamientosEspeciales.RespuestaValidacion.Correcta)
            {
                NE_Cotizaciones cot = new NE_Cotizaciones();
                cot.id = txt_id._Text;
                cot.moneda_origen = txt_cmb_mon_org.SelectedValue.ToString();
                cot.moneda_destino = txt_cmb_mon_dest.SelectedValue.ToString();
                cot.fecha = txt_fecha._Text;
                cot.valor = txt_valor._Text;
                cot.Modificar();
                MessageBox.Show("La modificación se realizó Correctamente.", "Importante");
            }
        }

        
    }
}
