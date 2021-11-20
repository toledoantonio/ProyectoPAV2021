using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankApp.Negocios;
using BankApp.Formularios.Tipos_de_Cuentas;

namespace BankApp.Formularios.Tipos_de_Cuentas
{
    public partial class Frm_ABM_TiposCuentas : BankApp.Formularios.FrmBase.Frm_Base_ABM
    {
        public Frm_ABM_TiposCuentas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_nombre_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txt_id_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NE_Tipos_Cuentas premio = new NE_Tipos_Cuentas();

            if (txt_descripcion.Text != string.Empty)
            {
                grid_tipo_cuentas.Cargar(premio.BuscarTipos_CuentasDescripcion(txt_descripcion.Text));
                return;
            }

            if (txt_id.Text != string.Empty)
            {
                grid_tipo_cuentas.Cargar(premio.BuscarTipos_CuentasID(txt_id.Text));
                return;
            }

            MessageBox.Show("No hay parámetros de búsqueda", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void Frm_ABM_TiposCuentas_Load(object sender, EventArgs e)
        {
            grid_tipo_cuentas.Formatear("ID,200, I; Descripcion, 472, I");
        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            Frm_Tipos_Cuentas_Alta frm_alta = new Frm_Tipos_Cuentas_Alta();
            frm_alta.ShowDialog();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (grid_tipo_cuentas.Rows.Count == 0)
            {
                MessageBox.Show("Falta buscar Tipos de Cuentas", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_tipo_cuentas.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("No selección un Tipo de Cuenta", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            
            Frm_Tipos_Cuentas_Modificar frm_modificar = new Frm_Tipos_Cuentas_Modificar();
            frm_modificar.id = grid_tipo_cuentas.CurrentRow.Cells[0].Value.ToString();

            frm_modificar.ShowDialog();
        }

        private void btn_modificar_Click_1(object sender, EventArgs e)
        {
            if (grid_tipo_cuentas.Rows.Count == 0)
            {
                MessageBox.Show("Falta buscar Tipos de Cuentas", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_tipo_cuentas.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("No selección un Tipo de Cuenta", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            Frm_Tipos_Cuentas_Modificar frm_modificar = new Frm_Tipos_Cuentas_Modificar();
            frm_modificar.id = grid_tipo_cuentas.CurrentRow.Cells[0].Value.ToString();

            frm_modificar.ShowDialog();
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (grid_tipo_cuentas.Rows.Count == 0)
            {
                MessageBox.Show("Falta buscar Premios", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_tipo_cuentas.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("No selección un premio", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Frm_Tipos_Cuentas_Borrar frm_borrar = new Frm_Tipos_Cuentas_Borrar();
            frm_borrar.id = grid_tipo_cuentas.CurrentRow.Cells[0].Value.ToString();
            frm_borrar.ShowDialog();
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            NE_Tipos_Cuentas tipcu = new NE_Tipos_Cuentas();

            grid_tipo_cuentas.Cargar(tipcu.BuscarTipos_CuentasTodos());
            return;
        }
    }
}
