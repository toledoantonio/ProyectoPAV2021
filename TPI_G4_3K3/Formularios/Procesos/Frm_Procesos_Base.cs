using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankApp.Clases;

namespace BankApp.Formularios.Procesos
{
    public partial class Frm_Procesos_Base : BankApp.Formularios.FrmBase.Frm_Base
    {
        TratamientosEspeciales _TE = new TratamientosEspeciales();

        public Frm_Procesos_Base()
        {
            InitializeComponent();
        }

        private void btn_FechaSistema_Click(object sender, EventArgs e)
        {
            lbl_fecha._Text = _TE.RecuperarFechaSistema();
        }

        private void btn_HoraSistema_Click_1(object sender, EventArgs e)
        {
            lbl_hora._Text = _TE.RecuperarHoraSistema();
        }

        private void lbl_cta_origen_Load(object sender, EventArgs e)
        {

        }
    }
}
