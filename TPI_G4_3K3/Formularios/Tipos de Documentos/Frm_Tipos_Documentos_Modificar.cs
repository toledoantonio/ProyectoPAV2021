using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankApp.Negocios;
using BankApp.Clases;

namespace BankApp.Formularios.Tipos_de_Documentos
{
    public partial class Frm_Tipos_Documentos_Modificar : BankApp.Formularios.Tipos_de_Documentos.Frm_Tipos_Documentos
    {
        public Frm_Tipos_Documentos_Modificar()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales _TE = new TratamientosEspeciales();

            if (_TE.Validar(this.Controls) == TratamientosEspeciales.RespuestaValidacion.Correcta)
            {
                NE_Tipos_Documentos tdoc = new NE_Tipos_Documentos();
                tdoc.id = txt_id._Text;
                tdoc.descripcion = txt_descripcion._Text;
                tdoc.Modificar();
                MessageBox.Show("La modificación se realizó Correctamente.", "Importante");
            }
        }

        private void Frm_Tipos_Documentos_Modificar_Load(object sender, EventArgs e)
        {
            NE_Tipos_Documentos tpre = new NE_Tipos_Documentos();
            CargarFormulario(tpre.RecuperarTipoDocumento(id));
        }
    }
}
