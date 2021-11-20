using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BankApp.Formularios.Servicio
{
    public partial class Frm_Servicios : BankApp.Formularios.FrmBase.Frm_Base
    {
        public Frm_Servicios()
        {
            InitializeComponent();
        }

        private void txt_id_Load(object sender, EventArgs e)
        {

        }

        public string id { get; set; }
    }
}
