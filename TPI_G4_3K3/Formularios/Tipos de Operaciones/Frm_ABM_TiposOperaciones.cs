using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankApp.Negocios;

namespace BankApp.Formularios.Tipos_de_Operaciones
{
    public partial class Frm_ABM_TiposOperaciones : BankApp.Formularios.FrmBase.Frm_Base_ABM
    {
        public Frm_ABM_TiposOperaciones()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NE_Tipos_Operaciones tipo_operacion = new NE_Tipos_Operaciones();

            if (txt_nombre.Text != string.Empty)
            {
                grid_tipo_operacion.Cargar(tipo_operacion.BuscarTipos_OperacionesNombre(txt_nombre.Text));
                return;
            }

            if (txt_id.Text != string.Empty)
            {
                grid_tipo_operacion.Cargar(tipo_operacion.BuscarTipos_OperacionesID(txt_id.Text));
                return;
            }

            MessageBox.Show("No hay parámetros de búsqueda", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void Frm_ABM_TiposOperaciones_Load(object sender, EventArgs e)
        {
            grid_tipo_operacion.Formatear("ID,200, I; Nombre, 480, I");
        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            Frm_Tipos_Operaciones_Alta frm_alta = new Frm_Tipos_Operaciones_Alta();
            frm_alta.ShowDialog();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (grid_tipo_operacion.Rows.Count == 0)
            {
                MessageBox.Show("Falta buscar un tipo de operacion", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_tipo_operacion.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("No selecciono un tipo de operacion", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Frm_Tipos_Operaciones_Modificar frm_modificar = new Frm_Tipos_Operaciones_Modificar();
            frm_modificar.id = grid_tipo_operacion.CurrentRow.Cells[0].Value.ToString();
            frm_modificar.ShowDialog();
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (grid_tipo_operacion.Rows.Count == 0)
            {
                MessageBox.Show("Falta buscar un tipo de operacion", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_tipo_operacion.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("No selecciono un tipo de operacion", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Frm_Tipos_Operaciones_Borrar frm_borrar = new Frm_Tipos_Operaciones_Borrar();
            frm_borrar.id = grid_tipo_operacion.CurrentRow.Cells[0].Value.ToString();
            frm_borrar.ShowDialog();
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            NE_Tipos_Operaciones tipops = new NE_Tipos_Operaciones();

            grid_tipo_operacion.Cargar(tipops.BuscarTipos_Operaciones_Todos());
            return;
        }
    }
}
