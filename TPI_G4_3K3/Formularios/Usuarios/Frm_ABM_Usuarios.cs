using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankApp.Negocios;

namespace BankApp.Formularios.Usuarios
{
    public partial class Frm_ABM_Usuarios : BankApp.Formularios.FrmBase.Frm_Base_ABM
    {
        public Frm_ABM_Usuarios()
        {
            InitializeComponent();
        }

        private void Frm_ABM_Usuarios_Load(object sender, EventArgs e)
        {
            grid_usuarios.Formatear("Id,40, C; Nombre de Usuario, 130, I; Apellido, 150, I; Nombres, 150, I; Tipo Doc, 80, I; Numero Doc, 132, I");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NE_Usuarios usuario = new NE_Usuarios();

            string columna = "";

            if (txt_patron.Text != string.Empty)
            {
                if (rb_nombre_usuario.Checked == true)
                    columna = rb_nombre_usuario.Text;
                if (rb_apellido.Checked == true)
                    columna = rb_apellido.Text;
                if (rb_nombre.Checked == true)
                    columna = rb_nombre.Text;
                if (rb_nro_doc.Checked == true)
                    columna = rb_nro_doc.Text;

                grid_usuarios.Cargar(usuario.BuscarUsuario(txt_patron.Text, columna));
                return;
            }
            if (txt_id_usuario.Text != string.Empty)
            {
                grid_usuarios.Cargar(usuario.BuscarUsuario(txt_id_usuario.Text));
                return;
            }

            MessageBox.Show("No hay parámetros de búsqueda", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            Frm_Usuarios_Alta frm_alta = new Frm_Usuarios_Alta();
            frm_alta.ShowDialog();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (grid_usuarios.Rows.Count == 0)
            {
                MessageBox.Show("Falta buscar usuarios", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_usuarios.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("No selección un usuario", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Frm_Usuarios_Modificaciones frm_modificar = new Frm_Usuarios_Modificaciones();
            frm_modificar.id = grid_usuarios.CurrentRow.Cells[0].Value.ToString();
            frm_modificar.ShowDialog();
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (grid_usuarios.Rows.Count == 0)
            {
                MessageBox.Show("Falta buscar usuarios", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_usuarios.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("No selección un usuario", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Frm_Usuarios_Borrar frm_borrar = new Frm_Usuarios_Borrar();
            frm_borrar.id = grid_usuarios.CurrentRow.Cells[0].Value.ToString();
            frm_borrar.ShowDialog();
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            NE_Usuarios usuarios = new NE_Usuarios();

            grid_usuarios.Cargar(usuarios.BuscarUsuariosTodos());
            return;
        }
    }
}
