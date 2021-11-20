using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankApp.Negocios;
using BankApp.Clases;

namespace BankApp.Formularios.Servicio
{
    public partial class Frm_Servicios_Modificar : BankApp.Formularios.Servicio.Frm_Servicios
    {
        public Frm_Servicios_Modificar()
        {
            InitializeComponent();
        }
        private void Frm_Servicios_Modificar_Load_1(object sender, EventArgs e)
        {
            NE_Servicios ser = new NE_Servicios();
            CargarFormulario(ser.RecuperarServicio(id));
        }

        private void CargarFormulario(DataTable tabla)
        {
            txt_id._Text = tabla.Rows[0]["id"].ToString();
            txt_nombre._Text = tabla.Rows[0]["nombre"].ToString();
        }
        

        private void btn_aceptar_Click(object sender, EventArgs e)
        {

            TratamientosEspeciales _TE = new TratamientosEspeciales();

            if (_TE.Validar(this.Controls) == TratamientosEspeciales.RespuestaValidacion.Correcta)
            {
                NE_Servicios ser = new NE_Servicios();
                ser.id = txt_id._Text;
                ser.nombre = txt_nombre._Text;           
                ser.Modificar();
                MessageBox.Show("La modificación se realizó Correctamente.", "Importante");
            }
        }

        
    }
}
