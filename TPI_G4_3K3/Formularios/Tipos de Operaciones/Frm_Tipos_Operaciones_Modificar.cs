using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankApp.Negocios;
using BankApp.Clases;

namespace BankApp.Formularios.Tipos_de_Operaciones
{
    public partial class Frm_Tipos_Operaciones_Modificar : BankApp.Formularios.Tipos_de_Operaciones.Frm_Tipos_Operaciones
    {
        public Frm_Tipos_Operaciones_Modificar()
        {
            InitializeComponent();
        }

        private void Frm_Tipos_Operaciones_Modificar_Load(object sender, EventArgs e)
        {
            NE_Tipos_Operaciones usu = new NE_Tipos_Operaciones();
            CargarFormulario(usu.RecuperarTiposDeOperaciones(id));
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales _TE = new TratamientosEspeciales();

            if (_TE.Validar(this.Controls) == TratamientosEspeciales.RespuestaValidacion.Correcta)
            {
                NE_Tipos_Operaciones tpre = new NE_Tipos_Operaciones();
                tpre.id = txt_id._Text;
                tpre.nombre = txt_nombre._Text;
                tpre.Modificar();
                MessageBox.Show("La modificación se realizó Correctamente.", "Importante");
            }
        }
    }
}
