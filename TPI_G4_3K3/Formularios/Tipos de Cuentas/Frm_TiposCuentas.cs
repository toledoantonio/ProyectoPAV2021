using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BankApp.Formularios.Tipos_de_Cuentas
{
    public partial class Frm_TiposCuentas : BankApp.Formularios.FrmBase.Frm_Base
    {
        public Frm_TiposCuentas()
        {
            InitializeComponent();
        }

        public string id { get; set; }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {

        }

        public void CargarFormulario(DataTable tabla)
        {
            txt_id._Text = tabla.Rows[0]["ID"].ToString();
            txt_descripcion._Text = tabla.Rows[0]["Descripcion"].ToString();
        }    
    }
}
