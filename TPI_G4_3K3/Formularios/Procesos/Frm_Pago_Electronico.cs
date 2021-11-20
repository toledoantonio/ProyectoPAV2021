using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankApp.Clases;
using BankApp.Negocios;

namespace BankApp.Formularios.Procesos
{
    public partial class Frm_Pago_Electronico : BankApp.Formularios.Procesos.Frm_Procesos_Base
    {
        public string puntos_obtenidos { get; set; }
        public string saldo_restante { get; set; }

        public Frm_Pago_Electronico()
        {
            InitializeComponent();
        }
        
        private void Frm_Pago_Electronico_Load(object sender, EventArgs e)
        {
            cmb_servicios._Cargar();
            grid_pago_electronico.Formatear("ID, 50, C; Cuenta Origen, 135, I; Fecha, 100, I; Hora, 80, I; Tipo Operacion, 150, I; Importe, 80, I; Servicio, 100, I; Puntos Sumados, 80, I");
        }
        private void btn_ver_Click(object sender, EventArgs e)
        {
            grid_pago_electronico.Rows.Clear();
            NE_Pago_Electronico pg = new NE_Pago_Electronico();
            grid_pago_electronico.Cargar(pg.BuscarUltimoPago());
        }
        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            foreach (var item in this.Controls)
            {
                if (item.GetType().Name == "LabelText")
                {
                    ((LabelText)item)._Text = "";
                    lbl_id_moneda._Text = "";
                    lbl_Saldo._Text = "";
                }
                if (item.GetType().Name == "ComboBox01")
                {
                    ((ComboBox01)item).SelectedIndex = -1;
                }
                if (item.GetType().Name == "Grid01")
                {
                    ((Grid01)item).Rows.Clear();
                }
                
            }
        }
        private void btn_CargarCuentaOrigen_Click(object sender, EventArgs e)
        {
            if (lbl_cta_origen._Text != string.Empty)
            {
                NE_Cuentas ct = new NE_Cuentas();

                DataTable tabla = ct.RecuperarMonedaYSaldo(lbl_cta_origen._Text);

                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show("No existe una cuenta con ese número.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                lbl_Saldo._Text = tabla.Rows[0]["saldo"].ToString();
                lbl_id_moneda._Text = tabla.Rows[0]["simbolo"].ToString();
                return;
               
            }
            MessageBox.Show("No Ingreso el Numero de Cuenta", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btn_grabar_Click_1(object sender, EventArgs e)
        {
            if (lbl_cta_origen._Text == "" || lbl_fecha._Text.Trim().Remove(0, 1).Trim() == "/"
                || lbl_importe._Text.Trim() == "." || cmb_servicios.SelectedIndex == -1 || lbl_hora._Text.Trim().Remove(0, 1).Trim() == ":" )
            {
                MessageBox.Show("Faltan datos para realizar el Pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (decimal.Parse(lbl_Saldo._Text) < decimal.Parse(lbl_importe._Text))
            {
                MessageBox.Show("No tiene el Saldo Suficiente para realizar el Pago.\n" +
                    "Saldo Actual: " + lbl_Saldo._Text + "\nSaldo Necesario: " + lbl_importe._Text,
                    "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            NE_Pago_Electronico pg = new NE_Pago_Electronico();
            TratamientosEspeciales _TE = new TratamientosEspeciales();

            puntos_obtenidos = Convert.ToInt32(decimal.Parse(lbl_importe._Text) / 25).ToString();
            saldo_restante = (decimal.Parse(lbl_Saldo._Text) - decimal.Parse(lbl_importe._Text)).ToString();

            if (_TE.Validar(this.Controls) == TratamientosEspeciales.RespuestaValidacion.Correcta)
            {
                pg.cuenta_origen = lbl_cta_origen._Text.ToString();
                pg.fecha = lbl_fecha._Text.ToString();
                pg.hora = lbl_hora._Text.ToString();
                pg.importe = lbl_importe._Text.ToString();
                pg.id_servicio = cmb_servicios.SelectedValue.ToString();

                pg.PagarServicio(saldo_restante, puntos_obtenidos);
                
                MessageBox.Show("Se Registro correctamente El Pago Electronico", "Importante");

            }
        }
    }
}
