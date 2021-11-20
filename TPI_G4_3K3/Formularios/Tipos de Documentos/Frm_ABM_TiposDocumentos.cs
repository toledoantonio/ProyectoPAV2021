using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankApp.Negocios;

namespace BankApp.Formularios.Tipos_de_Documentos
{
    public partial class Frm_ABM_TiposDocumentos : BankApp.Formularios.FrmBase.Frm_Base_ABM
    {
        public Frm_ABM_TiposDocumentos()
        {
            InitializeComponent();
        }

        private void Frm_ABM_TiposDocumentos_Load(object sender, EventArgs e)
        {
            grid_tipo_documento.Formatear("ID,200, I; Descripcion, 480, I");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NE_Tipos_Documentos tipo_documentos = new NE_Tipos_Documentos();

            if (txt_descripcion.Text != string.Empty)
            {
                grid_tipo_documento.Cargar(tipo_documentos.BuscarTipos_DocumentosDescripcion(txt_descripcion.Text));
                return;
            }

            if (txt_id.Text != string.Empty)
            {
                grid_tipo_documento.Cargar(tipo_documentos.BuscarTipos_DocumentosID(txt_id.Text));
                return;
            }

            MessageBox.Show("No hay parámetros de búsqueda", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            Frm_Tipos_Documentos_Alta frm_alta = new Frm_Tipos_Documentos_Alta();
            frm_alta.ShowDialog();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (grid_tipo_documento.Rows.Count == 0)
            {
                MessageBox.Show("Falta buscar Tipo de Documento", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_tipo_documento.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("No selección un Tipo de Documento", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Frm_Tipos_Documentos_Modificar frm_modificar = new Frm_Tipos_Documentos_Modificar();
            frm_modificar.id = grid_tipo_documento.CurrentRow.Cells[0].Value.ToString();
            frm_modificar.ShowDialog();
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (grid_tipo_documento.Rows.Count == 0)
            {
                MessageBox.Show("Falta buscar Tipo de Documento", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_tipo_documento.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("No selección un Tipo de Documento", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Frm_Tipos_Documentos_Borrar frm_borrar = new Frm_Tipos_Documentos_Borrar();
            frm_borrar.id = grid_tipo_documento.CurrentRow.Cells[0].Value.ToString();
            frm_borrar.ShowDialog();
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            NE_Tipos_Documentos tipdoc = new NE_Tipos_Documentos();

            grid_tipo_documento.Cargar(tipdoc.BuscarTipos_DocumentosTodos());
            return;
        }
    }
}
