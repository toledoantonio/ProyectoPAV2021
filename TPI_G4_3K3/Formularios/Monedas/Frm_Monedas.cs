using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BankApp.Formularios.Monedas
{
    public partial class Frm_Monedas : BankApp.Formularios.FrmBase.Frm_Base
    {
        public Frm_Monedas()
        {
            InitializeComponent();
        }

        public string _Titulo
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
        public string id { get; set; }
    }
}
