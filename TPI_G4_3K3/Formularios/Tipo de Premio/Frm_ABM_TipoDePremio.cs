using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankApp.Negocios;

namespace BankApp.Formularios.Tipo_de_Premio
{
    public partial class Frm_ABM_TipoDePremio : BankApp.Formularios.FrmBase.Frm_Base_ABM
    {
        public Frm_ABM_TipoDePremio()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Frm_ABM_TipoDePremio_Load(object sender, EventArgs e)
        {
            grid_tipo_premio.Formatear("ID,100, I; Nombre, 200, I; Descripcion, 382, I");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NE_TipoDePremio tipoPremio = new NE_TipoDePremio();

            if (txt_nombre.Text != string.Empty)
            {
                grid_tipo_premio.Cargar(tipoPremio.BuscarTipoPremioNombre(txt_nombre.Text));
                return;
            }

            if (txt_id.Text != string.Empty)
            {
                grid_tipo_premio.Cargar(tipoPremio.BuscarTipoPremioId(txt_id.Text));
                return;
            }

            MessageBox.Show("No hay parámetros de búsqueda", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            Frm_Tipo_Premio_Alta frm_alta = new Frm_Tipo_Premio_Alta();
            frm_alta.ShowDialog();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (grid_tipo_premio.Rows.Count == 0)
            {
                MessageBox.Show("Falta buscar Tipos de Premios", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_tipo_premio.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("No selección un Tipo de Premio", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Frm_Tipo_Premio_Modificar frm_modificar = new Frm_Tipo_Premio_Modificar();
            frm_modificar.id = grid_tipo_premio.CurrentRow.Cells[0].Value.ToString();
            frm_modificar.ShowDialog();
            
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (grid_tipo_premio.Rows.Count == 0)
            {
                MessageBox.Show("Falta buscar Tipo de Premio", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_tipo_premio.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("No selección un Tipo de Premio", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Frm_Tipo_Premio_Borrar frm_borrar = new Frm_Tipo_Premio_Borrar();
            frm_borrar.id = grid_tipo_premio.CurrentRow.Cells[0].Value.ToString();
            frm_borrar.ShowDialog();
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            NE_TipoDePremio premio = new NE_TipoDePremio();
            grid_tipo_premio.Cargar(premio.BuscarTipoDePremiosTodos());
            return;
        }
    }
}
