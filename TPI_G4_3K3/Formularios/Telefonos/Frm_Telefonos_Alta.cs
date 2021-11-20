using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankApp.Clases;
using BankApp.Negocios;

namespace BankApp.Formularios.Telefonos
{
    public partial class Frm_Telefonos_Alta : BankApp.Formularios.Telefonos.Frm_Telefonos
    {
        public Frm_Telefonos_Alta()
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
                NE_Telefonos tel = new NE_Telefonos();
                tel.numero = txt_numero._Text;
                tel.id_usuario = txt_id._Text;
                numero = tel.Insertar();
                txt_numero._Text = numero;

                //txt_numero._Text = tel.Insertar(this.Controls);
                //txt_id._Text = tel.Insertar(this.Controls);


                MessageBox.Show("El Alta del Telefono se realizó correctamente.");
            }
        }

        private void Frm_Telefonos_Alta_Load(object sender, EventArgs e)
        {

        }
    }
}
