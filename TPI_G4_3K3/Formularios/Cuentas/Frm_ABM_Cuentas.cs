using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankApp.Negocios;
using BankApp.Formularios.Cuentas;

namespace BankApp.Formularios
{
    public partial class Frm_ABM_Cuentas : BankApp.Formularios.FrmBase.Frm_Base_ABM
    {
        public Frm_ABM_Cuentas()
        {
            InitializeComponent();
        }

        private void Frm_ABM_Cuentas_Load(object sender, EventArgs e)
        {
            grid_cuentas.Formatear("Numero,100, C; Tipo de Cuenta, 162, I; ID de Usuario, 90, I; Moneda, 150, I; Puntos Totales, 85, I; Saldo, 85, I");
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            NE_Cuentas cuentas = new NE_Cuentas();

            string columna = "";

            if (txt_patron.Text != string.Empty)
            {
                if (rb_numero_cuenta.Checked == true)
                    columna = rb_numero_cuenta.Text;
                if (rb_id_usuario.Checked == true)
                    columna = rb_id_usuario.Text;

                grid_cuentas.Cargar(cuentas.BuscarCuenta(txt_patron.Text, columna));
                if (grid_cuentas.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontró ninguna cuenta", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return;
            }

            MessageBox.Show("No hay parámetros de búsqueda", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }


        private void btn_alta_Click(object sender, EventArgs e)
        {
            Frm_Cuentas_Alta frm_alta_cuenta = new Frm_Cuentas_Alta();
            frm_alta_cuenta.ShowDialog();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (grid_cuentas.Rows.Count == 0)
            {
                MessageBox.Show("Falta buscar cuentas", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_cuentas.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("No seleccionó una cuenta", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            Frm_Cuentas_Modificacion frm_modificar_cuenta = new Frm_Cuentas_Modificacion();
            frm_modificar_cuenta.numero = grid_cuentas.CurrentRow.Cells[0].Value.ToString();
            frm_modificar_cuenta.ShowDialog();
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (grid_cuentas.Rows.Count == 0)
            {
                MessageBox.Show("Falta buscar cuentas", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_cuentas.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("No seleccionó una cuenta", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            Frm_Cuentas_Borrar frm_cuentas_borrar = new Frm_Cuentas_Borrar();
            frm_cuentas_borrar.numero = grid_cuentas.CurrentRow.Cells[0].Value.ToString();
            frm_cuentas_borrar.ShowDialog();
        }

        private void txt_patron_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rb_nombre_usuario_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void grid_usuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            NE_Cuentas cuentas = new NE_Cuentas();

            grid_cuentas.Cargar(cuentas.BuscarCuentasTodos());
            return;
        }
    }
}
