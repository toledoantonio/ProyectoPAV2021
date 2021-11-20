using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankApp.Negocios;
using BankApp.Clases;

namespace BankApp.Formularios.Usuarios
{
    public partial class Frm_Usuarios_Modificaciones : BankApp.Formularios.Usuarios.Frm_Usuarios
    {
        public Frm_Usuarios_Modificaciones()
        {
            InitializeComponent();
        }

        private void CargarFormulario(DataTable tabla)
        {
            txt_id._Text = tabla.Rows[0]["id"].ToString();
            txt_nombre_usuario._Text = tabla.Rows[0]["nombre_usuario"].ToString();
            txt_contraseña._Text = tabla.Rows[0]["contraseña"].ToString();
            txt_apellido._Text = tabla.Rows[0]["apellido"].ToString();
            txt_nombre._Text = tabla.Rows[0]["nombre"].ToString();
            cmb_tipo_doc.SelectedValue = int.Parse(tabla.Rows[0]["tipo_doc"].ToString());
            txt_nro_doc._Text = tabla.Rows[0]["nro_doc"].ToString();
        }

        private void Frm_Usuarios_Modificaciones_Load(object sender, EventArgs e)
        {
            NE_Usuarios usu = new NE_Usuarios();
            CargarFormulario(usu.RecuperarUsuario(id));
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales _TE = new TratamientosEspeciales();

            if (_TE.Validar(this.Controls) == TratamientosEspeciales.RespuestaValidacion.Correcta)
            {
                NE_Usuarios usu = new NE_Usuarios();
                usu.id = txt_id._Text;
                usu.nombre_usuario = txt_nombre_usuario._Text;
                usu.contraseña = txt_contraseña._Text;
                usu.apellido = txt_apellido._Text;
                usu.nombre = txt_nombre._Text;
                usu.tipo_doc = cmb_tipo_doc.SelectedValue.ToString();
                usu.nro_doc = txt_nro_doc._Text;
                usu.Modificar();
                MessageBox.Show("La modificación se realizó Correctamente.", "Importante");
            }
        }
    }
}
