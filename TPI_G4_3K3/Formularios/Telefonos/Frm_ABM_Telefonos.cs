using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankApp.Negocios;

namespace BankApp.Formularios.Telefonos
{
    public partial class Frm_ABM_Telefonos : BankApp.Formularios.FrmBase.Frm_Base_ABM
    {
        public Frm_ABM_Telefonos()
        {
            InitializeComponent();
        }

        private void lbl_titulo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Frm_ABM_Telefonos_Load(object sender, EventArgs e)
        {
            grid_telefonos.Formatear("Numero,342, C; IdUsuario, 340, I");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NE_Telefonos telefono = new NE_Telefonos();


            if (txt_telefono.Text != string.Empty)
            {
                grid_telefonos.Cargar(telefono.BuscarNumero(txt_telefono.Text));
                return;
            }

            if (txt_id.Text != string.Empty)
            {
                grid_telefonos.Cargar(telefono.BuscarId_usuario(txt_id.Text));
                return;
            }

            MessageBox.Show("No hay parámetros de búsqueda", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            Frm_Telefonos_Alta frm_alta = new Frm_Telefonos_Alta();
            frm_alta.ShowDialog();
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (grid_telefonos.Rows.Count == 0)
            {
                MessageBox.Show("Falta buscar un telefono", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_telefonos.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("No selecciono un telefono", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Frm_Telefonos_Borrar frm_borrar = new Frm_Telefonos_Borrar();
            frm_borrar.numero = grid_telefonos.CurrentRow.Cells[0].Value.ToString();
            frm_borrar.ShowDialog();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (grid_telefonos.Rows.Count == 0)
            {
                MessageBox.Show("Falta buscar un telefono", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_telefonos.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("No selecciono un telefono", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Frm_Telefonos_Modificar frm_modificar = new Frm_Telefonos_Modificar();
            frm_modificar.numero = grid_telefonos.CurrentRow.Cells[0].Value.ToString();
            frm_modificar.ShowDialog();
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            NE_Telefonos telefono = new NE_Telefonos();

            grid_telefonos.Cargar(telefono.BuscarTelefonosTodos());
            return;
        }
    }
}
