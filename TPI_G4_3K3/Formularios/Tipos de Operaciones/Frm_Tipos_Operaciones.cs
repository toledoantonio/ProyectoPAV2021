using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BankApp.Formularios.Tipos_de_Operaciones
{
    public partial class Frm_Tipos_Operaciones : BankApp.Formularios.FrmBase.Frm_Base
    {
        public Frm_Tipos_Operaciones()
        {
            InitializeComponent();
        }

        public string id { get; set; }

        public void CargarFormulario(DataTable tabla)
        {
            txt_id._Text = tabla.Rows[0]["id"].ToString();
            txt_nombre._Text = tabla.Rows[0]["nombre"].ToString();
        }

        private void Frm_Tipos_Operaciones_Load(object sender, EventArgs e)
        {

        }
    }
}
