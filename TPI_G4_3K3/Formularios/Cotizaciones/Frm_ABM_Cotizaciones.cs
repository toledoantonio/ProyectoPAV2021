using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankApp.Negocios;

namespace BankApp.Formularios.Cotizaciones
{
    public partial class Frm_ABM_Cotizaciones : BankApp.Formularios.FrmBase.Frm_Base_ABM
    {
        public Frm_ABM_Cotizaciones()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NE_Cotizaciones cotizacion = new NE_Cotizaciones();

            if (txt_id.Text != string.Empty)
            {
                grid_cotizaciones.Cargar(cotizacion.BuscarCotizacionesID(txt_id.Text));
                return;
            }

            if ((txt_patron.Text != "  /  /") && (txt_patron2.Text != "  /  /"))
            {
                grid_cotizaciones.Cargar(cotizacion.BuscarCotizacionesPatron(txt_patron.Text,txt_patron2.Text));
                return;
            }
            MessageBox.Show("No hay parámetros de búsqueda", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void Frm_ABM_Cotizaciones_Load(object sender, EventArgs e)
        {
            grid_cotizaciones.Formatear("ID,69, I; Moneda Origen, 125, I; Moneda Destino, 126, I; Fecha, 150, I; Valor, 210, I");
        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            Frm_Cotizaciones_Alta frm_alta = new Frm_Cotizaciones_Alta();
            frm_alta.ShowDialog();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (grid_cotizaciones.Rows.Count == 0)
            {
                MessageBox.Show("Falta buscar Cotizaciones", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_cotizaciones.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("No selección una Cotizacion", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Frm_Cotizaciones_Modificar frm_modificar = new Frm_Cotizaciones_Modificar();
            frm_modificar.id = grid_cotizaciones.CurrentRow.Cells[0].Value.ToString();
            frm_modificar.ShowDialog();
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (grid_cotizaciones.Rows.Count == 0)
            {
                MessageBox.Show("Falta buscar Cotizaciones", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_cotizaciones.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("No selección una Cotizacion", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Frm_Cotizaciones_Baja frm_borrar = new Frm_Cotizaciones_Baja();
            frm_borrar.id = grid_cotizaciones.CurrentRow.Cells[0].Value.ToString();
            frm_borrar.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            NE_Cotizaciones cot = new NE_Cotizaciones();

            grid_cotizaciones.Cargar(cot.BuscarCotizacionesTodos());
            return;
        }
    }
}
