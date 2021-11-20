using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankApp.Negocios;
using BankApp.Clases;

namespace BankApp.Formularios.Premios
{
    public partial class Frm_Premios_Modificar : BankApp.Formularios.Premios.Frm_Premios
    {
        public Frm_Premios_Modificar()
        {
            InitializeComponent();
        }

        private void Frm_Premios_Modificar_Load(object sender, EventArgs e)
        {
            NE_Premios prem = new NE_Premios();
            CargarFormulario(prem.RecuperarPremio(codigo));
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales _TE = new TratamientosEspeciales();

            if (_TE.Validar(this.Controls) == TratamientosEspeciales.RespuestaValidacion.Correcta)
            {
                NE_Premios prem = new NE_Premios();
                prem.codigo = txt_codigo._Text;
                prem.id_tipo_premio = cmb_tipo_prem.SelectedValue.ToString();
                prem.descripcion = txt_descripcion._Text;
                prem.puntos_req_actual = txt_puntos_req_actual._Text;
                prem.stock = txt_stock._Text;
                prem.Modificar();
                MessageBox.Show("La modificación se realizó Correctamente.", "Importante");
            }
        }
    }
}
