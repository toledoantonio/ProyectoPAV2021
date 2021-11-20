using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankApp.Negocios;

namespace BankApp.Formularios.Tarifa
{
    public partial class Frm_ABM_Tarifas : BankApp.Formularios.FrmBase.Frm_Base_ABM
    {
        public Frm_ABM_Tarifas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NE_Tarifas tarifa = new NE_Tarifas();

            if (txt_id.Text != string.Empty)
            {
                grid_tarifas.Cargar(tarifa.BuscarTarifasID(txt_id.Text));
                return;
            }

            if ((txt_patron.Text != "  /  /") && (txt_patron2.Text != "  /  /"))
            {
                grid_tarifas.Cargar(tarifa.BuscarTarifasPatron(txt_patron.Text, txt_patron2.Text));
                return;
            }
            MessageBox.Show("No hay parámetros de búsqueda", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void Frm_ABM_Tarifas_Load(object sender, EventArgs e)
        {
            grid_tarifas.Formatear("ID,59, I; Fecha Vigente Desde, 146, I; Fecha Vigente Hasta, 136, I; Monto Base, 140, I; Monto Superior, 140, I; Porcentaje, 60, I");
        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            Frm_Tarifas_Alta frm_alta = new Frm_Tarifas_Alta();
            frm_alta.ShowDialog();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (grid_tarifas.Rows.Count == 0)
            {
                MessageBox.Show("Falta buscar Tarifas", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_tarifas.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("No selección una Tarifa", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Frm_Tarifas_Modificacion frm_modificar = new Frm_Tarifas_Modificacion();
            frm_modificar.id = grid_tarifas.CurrentRow.Cells[0].Value.ToString();
            frm_modificar.ShowDialog();
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (grid_tarifas.Rows.Count == 0)
            {
                MessageBox.Show("Falta buscar Tarifas", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_tarifas.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("No selección una Tarifa", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Frm_Tarifas_Baja frm_borrar = new Frm_Tarifas_Baja();
            frm_borrar.id = grid_tarifas.CurrentRow.Cells[0].Value.ToString();
            frm_borrar.ShowDialog();
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            NE_Tarifas tarifas = new NE_Tarifas();

            grid_tarifas.Cargar(tarifas.BuscarTarifasTodos());
            return;
        }
    }
}
