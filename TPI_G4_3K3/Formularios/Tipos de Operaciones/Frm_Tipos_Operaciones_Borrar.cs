using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankApp.Negocios;
using BankApp.Clases;

namespace BankApp.Formularios.Tipos_de_Operaciones
{
    public partial class Frm_Tipos_Operaciones_Borrar : BankApp.Formularios.Tipos_de_Operaciones.Frm_Tipos_Operaciones
    {
        public Frm_Tipos_Operaciones_Borrar()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            NE_Tipos_Operaciones to = new NE_Tipos_Operaciones();
            to.id = id;
            if (MessageBox.Show("Está seguro de querer borrar el Tipo de Operacion " + txt_nombre._Text + "?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                to.Borrar();
                MessageBox.Show("El Tipo de Operacion se borró Correctamente", "Importante");
            }
            else
                MessageBox.Show("No se procedió a borrar");
        }

        private void Frm_Tipos_Operaciones_Borrar_Load(object sender, EventArgs e)
        {
            NE_Tipos_Operaciones to = new NE_Tipos_Operaciones();
            CargarFormulario(to.RecuperarTiposDeOperaciones(id));
        }
    }
}
