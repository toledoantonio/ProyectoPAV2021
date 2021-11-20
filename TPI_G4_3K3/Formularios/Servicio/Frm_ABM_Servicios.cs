using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankApp.Negocios;

namespace BankApp.Formularios.Servicio
{
    public partial class Frm_ABM_Servicios : BankApp.Formularios.FrmBase.Frm_Base_ABM
    {
        public Frm_ABM_Servicios()
        {
            InitializeComponent();
        }

        private void grid011_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                NE_Servicios servicio = new NE_Servicios();

                if (txt_nombre.Text != string.Empty)
            {
                grid_Servicios.Cargar(servicio.BuscarServiciosxNombre(txt_nombre.Text));
                return;
            }

            if (txt_id.Text != string.Empty)
            {
                grid_Servicios.Cargar(servicio.BuscarServiciosxID(txt_id.Text));
                return;
            }

            MessageBox.Show("No hay parámetros de búsqueda", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void Frm_ABM_Servicios_Load(object sender, EventArgs e)
        {
            grid_Servicios.Formatear("Codigo,201, I; Nombre, 481, I");
        }

        private void btn_alta_Click_1(object sender, EventArgs e)
        {
            Frm_Servicios_Alta frm_alta = new Frm_Servicios_Alta();
            frm_alta.ShowDialog();
        }

        private void btn_modificar_Click_1(object sender, EventArgs e)
        {
            if (grid_Servicios.Rows.Count == 0)
            {
                MessageBox.Show("Falta buscar servicios", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_Servicios.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("No selecciono un servicio", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Frm_Servicios_Modificar frm_modificar = new Frm_Servicios_Modificar();
            frm_modificar.id = grid_Servicios.CurrentRow.Cells[0].Value.ToString();
            frm_modificar.ShowDialog();
        }

        private void btn_borrar_Click_1(object sender, EventArgs e)
        {
            if (grid_Servicios.Rows.Count == 0)
            {
                MessageBox.Show("Falta buscar servicios", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_Servicios.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("No selecciono un servicio", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Frm_Servicios_Baja frm_borrar = new Frm_Servicios_Baja();
            frm_borrar.id = grid_Servicios.CurrentRow.Cells[0].Value.ToString();
            frm_borrar.ShowDialog();
            }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            NE_Servicios servicio = new NE_Servicios();

            grid_Servicios.Cargar(servicio.BuscarServiciosTodos());
            return;

         
        }
    }
}
