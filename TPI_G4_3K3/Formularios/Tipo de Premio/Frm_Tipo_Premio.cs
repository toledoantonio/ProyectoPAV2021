using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BankApp.Formularios.Tipo_de_Premio
{
    public partial class Frm_Tipo_Premio : BankApp.Formularios.FrmBase.Frm_Base
    {
        public Frm_Tipo_Premio()
        {
            InitializeComponent();
        }
        public string id { get; set; }

        public void CargarFormulario(DataTable tabla)
        {
            txt_id._Text = tabla.Rows[0]["id"].ToString();
            txt_nombre._Text = tabla.Rows[0]["nombre"].ToString();
            txt_descripcion._Text = tabla.Rows[0]["descripcion"].ToString();
        }
    }
}
