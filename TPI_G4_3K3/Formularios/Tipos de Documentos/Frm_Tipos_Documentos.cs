using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BankApp.Formularios.Tipos_de_Documentos
{
    public partial class Frm_Tipos_Documentos : BankApp.Formularios.FrmBase.Frm_Base
    {
        public Frm_Tipos_Documentos()
        {
            InitializeComponent();
        }
        public string _Titulo
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
        public string id { get; set; }

        public void CargarFormulario(DataTable tabla)
        {
            txt_id._Text = tabla.Rows[0]["id"].ToString();
            txt_descripcion._Text = tabla.Rows[0]["descripcion"].ToString();
        }
        
    }
}
