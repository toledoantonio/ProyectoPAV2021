using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankApp.Negocios;

namespace BankApp.Formularios.Premios
{
    public partial class Frm_ABM_Premios : BankApp.Formularios.FrmBase.Frm_Base_ABM
    {
        public Frm_ABM_Premios()
        {
            InitializeComponent();
        }

        private void grid011_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Frm_ABM_Premios_Load(object sender, EventArgs e)
        {
            grid_premios.Formatear("Codigo,75, C; Tipo de Premio, 150, I; Descripcion, 150, I; Stock, 150, I; Puntos, 140, I");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NE_Premios premio = new NE_Premios();


            if (txt_descripcion.Text != string.Empty)
            {
                grid_premios.Cargar(premio.BuscarPremio(txt_descripcion.Text));
                return;
            }

            if (txt_codigo.Text != string.Empty)
            {
                grid_premios.Cargar(premio.BuscarPremioCodigo(txt_codigo.Text));
                return;
            }

            MessageBox.Show("No hay parámetros de búsqueda", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            Frm_Premios_Alta frm_alta = new Frm_Premios_Alta();
            frm_alta.ShowDialog();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (grid_premios.Rows.Count == 0)
            {
                MessageBox.Show("Falta buscar Premios", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_premios.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("No selección un premio", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Frm_Premios_Modificar frm_modificar = new Frm_Premios_Modificar();
            frm_modificar.codigo = grid_premios.CurrentRow.Cells[0].Value.ToString();
            frm_modificar.ShowDialog();
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (grid_premios.Rows.Count == 0)
            {
                MessageBox.Show("Falta buscar Premios", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_premios.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("No selección un premio", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Frm_Premios_Borrar frm_borrar = new Frm_Premios_Borrar();
            frm_borrar.codigo = grid_premios.CurrentRow.Cells[0].Value.ToString();
            frm_borrar.ShowDialog();
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            NE_Premios prem = new NE_Premios();

            grid_premios.Cargar(prem.BuscarPremiosTodos());
            return;
        }
    }
}
