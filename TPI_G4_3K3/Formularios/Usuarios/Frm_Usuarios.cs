using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BankApp.Formularios.Usuarios
{
    public partial class Frm_Usuarios : BankApp.Formularios.FrmBase.Frm_Base
    {
        public Frm_Usuarios()
        {
            InitializeComponent();
        }

        public string _Titulo
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        public string id { get; set; }

        private void Frm_Usuarios_Load(object sender, EventArgs e)
        {
            cmb_tipo_doc._Cargar();
        }

        private void txt_id_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
