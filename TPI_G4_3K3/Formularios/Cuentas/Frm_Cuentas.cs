using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BankApp.Formularios.Cuentas
{
    public partial class Frm_Cuentas : BankApp.Formularios.FrmBase.Frm_Base
    {
        public Frm_Cuentas()
        {
            InitializeComponent();
        }

        public string numero { get; set; }

        private void Frm_Cuentas_Load(object sender, EventArgs e)
        {
            CargarCombos();
        }

        public void CargarCombos()
        {
            cmb_tiposCuentas._Cargar();
            cmb_monedas._Cargar();
        }

        public void CargarFormulario(DataTable tabla)
        {
            txt_numero._Text = tabla.Rows[0]["numero"].ToString();
            cmb_tiposCuentas.SelectedValue = tabla.Rows[0]["tipo_cuenta"].ToString();
            txt_id_usuario._Text = tabla.Rows[0]["id_usuario"].ToString();
            cmb_monedas.SelectedValue = tabla.Rows[0]["id_moneda"].ToString();
            txt_puntos._Text = tabla.Rows[0]["puntos_total"].ToString();
            txt_saldo._Text = tabla.Rows[0]["saldo"].ToString();
        }

        private void pnl_titulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_id_Load(object sender, EventArgs e)
        {

        }
    }
}
