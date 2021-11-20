using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BankApp.Formularios.Cotizaciones
{
    public partial class Frm_Cotizaciones : BankApp.Formularios.FrmBase.Frm_Base
    {
        public Frm_Cotizaciones()
        {
            InitializeComponent();
        }

        public string id { get; set; }
        private void txt_codigo_Load(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox011_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_descripcion_Load(object sender, EventArgs e)
        {

        }
        private void Frm_Cotizaciones_Load(object sender, EventArgs e)
        {
            txt_cmb_mon_org._Cargar();
            txt_cmb_mon_dest._Cargar();
        }
        
    }
}
