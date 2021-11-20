using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankApp.Negocios;
using BankApp.Clases;

namespace BankApp.Formularios.Tarifa
{
    public partial class Frm_Tarifas_Modificacion : BankApp.Formularios.Tarifa.Frm_Tarifas
    {
        public Frm_Tarifas_Modificacion()
        {
            InitializeComponent();
        }


        public void CargarFormulario(DataTable tabla)
        {
            txt_id._Text = tabla.Rows[0]["id"].ToString();
            txt_fecha_vig_desde._Text = tabla.Rows[0]["fecha_vig_desde"].ToString();
            txt_fecha_vig_hasta._Text = tabla.Rows[0]["fecha_vig_hasta"].ToString();
            txt_monto_base._Text = tabla.Rows[0]["monto_base"].ToString();
            txt_monto_sup._Text = tabla.Rows[0]["monto_superior"].ToString();
            txt_porcentaje._Text = tabla.Rows[0]["porcentaje"].ToString();
        }

       

        private void btn_aceptar_Click_1(object sender, EventArgs e)
        {
            
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
                tar.Modificar();
                

                MessageBox.Show("Se grabó correctamente la Tarifa", "Importante");
            }
        }

        private void Frm_Tarifas_Modificacion_Load(object sender, EventArgs e)
        {
            NE_Tarifas tar = new NE_Tarifas();
            CargarFormulario(tar.RecuperarTarifas(id));
        }
    }
}
