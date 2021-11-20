using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankApp.Negocios;
using BankApp.Clases;

namespace BankApp.Formularios.Procesos
{
    public partial class Frm_Canje_Premio : BankApp.Formularios.FrmBase.Frm_Base
    {
        public string numero { get; set; }
        public string puntos_restantes { get; set; }
        public string stock_restante { get; set; }

        NE_Canjes canje = new NE_Canjes();
        NE_Cuentas cuenta = new NE_Cuentas();
        NE_Premios premio = new NE_Premios();
        TratamientosEspeciales _TE = new TratamientosEspeciales();
        public Frm_Canje_Premio()
        {
            InitializeComponent();
        }

        private void Frm_Canje_Premio_Load(object sender, EventArgs e)
        {
            grid_premio.Formatear("Código, 70, C; Descripción, 150, I; Puntos, 100, I; Stock, 80, I");
            grid_premio.Cargar(premio.BuscarPremiosTodosCanje());
            grid_canje.Formatear("Id, 70, C; Fecha, 130, I; Id Usuario, 100, I;Codigo de Premio, 100, I; Puntos Usados, 100, I");
        }

        private void btn_fechasistema_Click(object sender, EventArgs e)
        {
            lbl_fecha._Text = _TE.RecuperarFechaSistema();
        }

        private void btn_cargar_cuenta_Click(object sender, EventArgs e)
        {
            if(txt_numero_cuenta._Text == "")
            {
                MessageBox.Show("Debe ingresar un numero de cuenta para buscar.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DataTable tabla = cuenta.RecuperarPuntos(txt_numero_cuenta._Text);
            if(tabla.Rows.Count == 0)
            {
                MessageBox.Show("No existe una cuenta con ese número.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            txt_puntos_total._Text = tabla.Rows[0]["puntos_total"].ToString();
        }

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            if(txt_puntos_total._Text != "")
            {
                if(grid_premio.CurrentCell.RowIndex == -1)
                {
                    MessageBox.Show("No seleccionó ningun premio.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                int puntos_req = int.Parse(grid_premio.CurrentRow.Cells[2].Value.ToString());
                int stock = int.Parse(grid_premio.CurrentRow.Cells[3].Value.ToString());
                if(stock == 0)
                {
                    MessageBox.Show("No hay Stock del premio seleccionado.", "Importante", 
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if(int.Parse(txt_puntos_total._Text)<puntos_req)
                {
                    MessageBox.Show("No tiene los puntos necesarios para canjear ese premio.\n" +
                        "Puntos Actuales: " + txt_puntos_total._Text + "\nPuntos Necesarios: " + puntos_req, 
                        "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if(lbl_fecha._Text == "  /  /")
                {
                    if (MessageBox.Show("La fecha no ha sido cargada.\n¿Quiere cargar automaticamente la del día de hoy?",
                        "Importante", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        lbl_fecha._Text = _TE.RecuperarFechaSistema();
                    else
                        return;
                }

                numero = txt_numero_cuenta._Text;
                puntos_restantes = (int.Parse(txt_puntos_total._Text) - puntos_req).ToString();
                stock_restante = (stock - 1).ToString();

                canje.fecha = lbl_fecha._Text;
                canje.id_usuario = cuenta.RecuperarIdUsuario(numero);
                canje.codigo_premio = grid_premio.CurrentRow.Cells[0].Value.ToString();
                canje.puntos_usados = puntos_req.ToString();

                txt_puntos_restantes._Text = puntos_restantes;
                btn_grabar.Visible = true;
                return;
            }
            
            MessageBox.Show("Debe buscar una cuenta para hacer el canje.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
        }

        private void btn_grabar_Click(object sender, EventArgs e)
        {
            canje.CanjearPremio(numero, puntos_restantes, stock_restante);
            btn_seleccionar.Enabled = false;
            grid_premio.Rows.Clear();
            grid_premio.Cargar(premio.BuscarPremiosTodosCanje());
        }

        private void btn_ver_Click(object sender, EventArgs e)
        {
            grid_canje.Rows.Clear();
            NE_Canjes canje = new NE_Canjes();
            grid_canje.Cargar(canje.RecuperarUltimoCanje());
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            btn_seleccionar.Enabled = true;
            btn_grabar.Visible = false;

            txt_numero_cuenta._Text = "";
            txt_puntos_restantes._Text = "";
            txt_puntos_total._Text = "";
            grid_canje.Rows.Clear();
            foreach (var item in this.Controls)
            {
                if (item.GetType().Name == "LabelText")
                {
                    ((LabelText)item)._Text = "";
                }
            }
        }
    }
}
