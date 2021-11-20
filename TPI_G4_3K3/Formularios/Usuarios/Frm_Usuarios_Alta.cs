using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankApp.Clases;
using BankApp.Negocios;

namespace BankApp.Formularios.Usuarios
{
    public partial class Frm_Usuarios_Alta : BankApp.Formularios.Usuarios.Frm_Usuarios
    {
        public Frm_Usuarios_Alta()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            //1)validar los datos del formulario
            //puede suceder que la validación de todo ok => grabo en la base de datos
            //o puede suceder que la validacion de error => ir a corregir el error

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
                id = usu.Insertar();
                txt_id._Text = id;

                MessageBox.Show("El Alta del usuario se realizó correctamente.");
            }      
        }

        private void Frm_Usuarios_Alta_Load(object sender, EventArgs e)
        {

        }
    }
}
