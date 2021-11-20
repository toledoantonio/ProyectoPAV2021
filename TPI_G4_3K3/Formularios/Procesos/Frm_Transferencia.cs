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
    public partial class Frm_Transferencia : BankApp.Formularios.Procesos.Frm_Procesos_Base
    {
        bool b_orig = false;
        bool b_dest = false;
        string valor = "";
        public Frm_Transferencia()
        {
            InitializeComponent();
        }

        private void labelText2_Load(object sender, EventArgs e)
        {

        }

        private void lbt_MonedaOrigen_Load(object sender, EventArgs e)
        {

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

                lbl_MonedaOrigen._Text = tabla.Rows[0]["simbolo"].ToString();
                lbl_Saldo._Text = tabla.Rows[0]["saldo"].ToString();
                b_orig = true;
                return;
            }

            MessageBox.Show("No se ingreso una cuenta", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btn_CargarCuentaDestino_Click(object sender, EventArgs e)
        {
            if (lbl_CuentaDestino._Text != string.Empty)
            {
                if (int.Parse(lbl_cta_origen._Text) != int.Parse(lbl_CuentaDestino._Text))
                {
                    NE_Cuentas ct = new NE_Cuentas();

                    DataTable tabla = ct.RecuperarMonedaYSaldo(lbl_CuentaDestino._Text);

                    if (tabla.Rows.Count == 0)
                    {
                        MessageBox.Show("No existe una cuenta con ese número.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    lbl_MonedaDestino._Text = tabla.Rows[0]["simbolo"].ToString();
                    b_dest = true;
                    return;
                }
                MessageBox.Show("No se puede hacer una transferencia a una misma cuenta.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            MessageBox.Show("No se ingreso una cuenta.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private string buscarCotizacion()
        {
            NE_Cotizaciones cot = new NE_Cotizaciones();

            DataTable tablaCot = cot.BuscarCotizacionTransferencia(lbl_MonedaOrigen._Text, lbl_MonedaDestino._Text, lbl_fecha._Text);

            if (tablaCot.Rows.Count == 0)
            {
                MessageBox.Show("No se cargo la cotización, faltan datos.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return "";
            }

            string idCot = tablaCot.Rows[0]["id"].ToString();
            valor = tablaCot.Rows[0]["valor"].ToString();

            MessageBox.Show("La cotizacion usada en la transferencia fue de: " + valor, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return idCot;
        }

        private void btn_grabar_Click(object sender, EventArgs e)
        {
            if (b_dest == false || b_orig == false || lbl_fecha._Text.Trim().Remove(0, 1).Trim() == "/"
                || lbl_importe._Text.Trim() == "," || lbl_hora._Text.Trim().Remove(0, 1).Trim() == ":" || lbl_cta_origen._Text == "" || lbl_CuentaDestino._Text == "")
            {
                MessageBox.Show("Faltan datos para la transferencia.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (decimal.Parse(lbl_Saldo._Text) < decimal.Parse(lbl_importe._Text))
            {
                MessageBox.Show("No tiene el Saldo Suficiente para realizar el Pago.\n" +
                    "Saldo Actual: " + lbl_Saldo._Text + "\nSaldo Necesario: " + lbl_importe._Text,
                    "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            NE_Transferencias transferencia = new NE_Transferencias();

            //Busca la tarifa usada e informa por mensaje el valor
            NE_Tarifas tar = new NE_Tarifas();

            DataTable tablaTar = tar.BuscarTarifaTransferencia(lbl_importe._Text.ToString(), lbl_fecha._Text.ToString());

            if (tablaTar.Rows.Count == 0)
            {
                MessageBox.Show("No se cargó la tarifa, faltan datos.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string idTar = tablaTar.Rows[0]["id"].ToString();
            string porcentaje = tablaTar.Rows[0]["porcentaje"].ToString();

            //calcula el importe total a descontar con la tarifa aplicada
            double totalADesc = Convert.ToDouble(lbl_importe._Text.ToString()) * (1 + Convert.ToDouble(porcentaje));

            MessageBox.Show("Se aplico una tarifa de: " + porcentaje + "%. El total a descontar es: " +  totalADesc, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);            

            //Cargar los datos de transferencia
            transferencia.cuenta_origen = lbl_cta_origen._Text.ToString();
            transferencia.cuenta_destino = lbl_CuentaDestino._Text.ToString();
            transferencia.fecha = lbl_fecha._Text.ToString();
            transferencia.hora = lbl_hora._Text.ToString();
            transferencia.id_tipo_operacion = "1";
            transferencia.importe = lbl_importe._Text.ToString();
            transferencia.id_tarifas = idTar;
            //Saldos a descontar 
            transferencia.imp_A_Desc = totalADesc.ToString();

            //Validacion de que se usa cotizacion o no                
            if (lbl_MonedaOrigen._Text != lbl_MonedaDestino._Text)
            {
                //Busca la cotizacion usada y la carga en transferencia
                string idCot = buscarCotizacion();
                if (idCot == "")
                {
                    return;
                }

                transferencia.id_cotizaciones = idCot;
                transferencia.valorCot = valor;              

                //Carga con cotizacion
                string id = transferencia.insertarConCot();
                if (id != "")
                {
                    MessageBox.Show("Se realizo exitosamente la transferencia.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return;
            }
            else
            {
                //Carga sin cotizacion
                string id = transferencia.insertarSinCot();
                if (id != "")
                {
                    MessageBox.Show("Se realizo exitosamente la transferencia.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return;
            }


        }

        private void Frm_Transferencia_Load(object sender, EventArgs e)
        {
            grid_transferencia.Formatear("ID, 50, C; Cuenta Origen, 135, I; Cuenta Destino, 135, I; Fecha, 100, I; Hora, 80, I; ID Cotizacion, 100, I; Tipo Operacion, 120, I; Importe, 80, I; ID Tarifa, 100, I");
        }

        private void btn_ver_Click(object sender, EventArgs e)
        {
            grid_transferencia.Rows.Clear();
            NE_Transferencias tran = new NE_Transferencias();
            grid_transferencia.Cargar(tran.buscarUltimoTransferencia());
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            foreach (var item in this.Controls)
            {
                if (item.GetType().Name == "LabelText")
                {
                    ((LabelText)item)._Text = "";
                    lbl_MonedaOrigen._Text = "";
                    lbl_Saldo._Text = "";
                    lbl_MonedaDestino._Text = "";
                    lbl_CuentaDestino._Text = "";
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
    }
}
