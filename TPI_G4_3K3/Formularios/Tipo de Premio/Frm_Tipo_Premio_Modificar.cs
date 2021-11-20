using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankApp.Negocios;
using BankApp.Clases;

namespace BankApp.Formularios.Tipo_de_Premio
{
    public partial class Frm_Tipo_Premio_Modificar : BankApp.Formularios.Tipo_de_Premio.Frm_Tipo_Premio
    {
        public Frm_Tipo_Premio_Modificar()
        {
            InitializeComponent();
        }

        private void Frm_Tipo_Premio_Modificar_Load(object sender, EventArgs e)
        {
            NE_TipoDePremio tpre = new NE_TipoDePremio();
            CargarFormulario(tpre.RecuperarTipoPremio(id));
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales _TE = new TratamientosEspeciales();

            if (_TE.Validar(this.Controls) == TratamientosEspeciales.RespuestaValidacion.Correcta)
            {
                NE_TipoDePremio tpre = new NE_TipoDePremio();
                tpre.id = txt_id._Text;
                tpre.nombre = txt_nombre._Text;
                tpre.descripcion = txt_descripcion._Text;
                tpre.Modificar();
                MessageBox.Show("La modificación se realizó Correctamente.", "Importante");
            }
        }
    }
}
