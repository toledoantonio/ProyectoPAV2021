using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankApp.Negocios;

namespace BankApp.Formularios.Monedas
{
    public partial class Frm_ABM_Monedas : BankApp.Formularios.FrmBase.Frm_Base_ABM
    {
        public Frm_ABM_Monedas()
        {
            InitializeComponent();
        }

        private void Frm_ABM_Monedas_Load(object sender, EventArgs e)
        {
            grid_monedas.Formatear("Id, 80, C; Nombre, 180, I; Símbolo, 114, I");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NE_Monedas mon = new NE_Monedas();

            if (txt_nombre.Text != string.Empty)
            {
                grid_monedas.Cargar(mon.BuscarMoneda_Nombre(txt_nombre.Text));
                return;
            }
            if (txt_id.Text != string.Empty)
            {
                grid_monedas.Cargar(mon.BuscarMoneda(txt_id.Text));
                return;
            }
            MessageBox.Show("No hay parámetros de búsqueda", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            Frm_Monedas_Alta frm_alta = new Frm_Monedas_Alta();
            frm_alta.ShowDialog();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (grid_monedas.Rows.Count == 0)
            {
                MessageBox.Show("Falta buscar usuarios", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_monedas.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("No selección un usuario", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Frm_Monedas_Modificaciones frm_modificar = new Frm_Monedas_Modificaciones();
            frm_modificar.id = grid_monedas.CurrentRow.Cells[0].Value.ToString();
            frm_modificar.ShowDialog();
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (grid_monedas.Rows.Count == 0)
            {
                MessageBox.Show("Falta buscar usuarios", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_monedas.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("No selección un usuario", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Frm_Monedas_Borrar frm_borrar = new Frm_Monedas_Borrar();
            frm_borrar.id = grid_monedas.CurrentRow.Cells[0].Value.ToString();
            frm_borrar.ShowDialog();
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            NE_Monedas moneda = new NE_Monedas();

            grid_monedas.Cargar(moneda.BuscarMonedasTodas());
            return;
        }
    }
}
