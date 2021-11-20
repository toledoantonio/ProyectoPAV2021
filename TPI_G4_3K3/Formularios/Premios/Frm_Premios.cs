using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BankApp.Formularios.Premios
{
    public partial class Frm_Premios : BankApp.Formularios.FrmBase.Frm_Base
    {
        public Frm_Premios()
        {
            InitializeComponent();
        }
        public string codigo { get; set; }

        private void Frm_Premios_Load(object sender, EventArgs e)
        {
            cmb_tipo_prem._Cargar();
        }
        public void CargarFormulario(DataTable tabla)
        {
            txt_codigo._Text = tabla.Rows[0]["codigo"].ToString();
            cmb_tipo_prem.SelectedValue = tabla.Rows[0]["id_tipo_premio"].ToString();
            txt_descripcion._Text = tabla.Rows[0]["descripcion"].ToString();
            txt_puntos_req_actual._Text = tabla.Rows[0]["puntos_req_actual"].ToString();
            txt_stock._Text = tabla.Rows[0]["stock"].ToString();
        }
    }
        
}
