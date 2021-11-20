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
    public partial class Frm_Tipos_Documentos_Borrar : BankApp.Formularios.Tipos_de_Documentos.Frm_Tipos_Documentos
    {
        public Frm_Tipos_Documentos_Borrar()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            NE_Tipos_Documentos tdoc = new NE_Tipos_Documentos();
            tdoc.id = id;
            if (MessageBox.Show("Está seguro de querer borrar el Tipo de Documento " + txt_descripcion._Text + "?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tdoc.Borrar();
                MessageBox.Show("El Tipo de Documento se borró Correctamente", "Importante");
            }
            else
                MessageBox.Show("No se procedió a borrar");
        }

        private void Frm_Tipos_Documentos_Borrar_Load(object sender, EventArgs e)
        {
            NE_Tipos_Documentos tdoc = new NE_Tipos_Documentos();
            CargarFormulario(tdoc.RecuperarTipoDocumento(id));
        }
    }
}
