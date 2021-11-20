using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BankApp.Formularios.Telefonos
{
    public partial class Frm_Telefonos : BankApp.Formularios.FrmBase.Frm_Base
    {
        public Frm_Telefonos()
        {
            InitializeComponent();
        }
        public string numero { get; set; }

        private void txt_id_Load(object sender, EventArgs e)
        {

        }
    }   
}
