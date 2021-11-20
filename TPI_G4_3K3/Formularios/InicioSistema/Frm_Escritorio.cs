using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankApp.Formularios.Usuarios;
using BankApp.Formularios.Premios;
using BankApp.Formularios.Cotizaciones;
using BankApp.Formularios.Telefonos;
using BankApp.Formularios.Servicio;
using BankApp.Formularios.Monedas;
using BankApp.Formularios.Tipo_de_Premio;
using BankApp.Formularios.Tipos_de_Operaciones;
using BankApp.Formularios.Tipos_de_Cuentas;
using BankApp.Formularios.Tipos_de_Documentos;
using BankApp.Formularios.Ayuda;
using BankApp.Formularios.Tarifa;
using BankApp.Formularios.Procesos;
using BankApp.Formularios.Reportes.Pagos_Electronicos;
using BankApp.Formularios;
using BankApp.Formularios.Reportes.Canjes;
using BankApp.Formularios.Reportes.Tranferencias;
using BankApp.Formularios.Reportes.Cuentas;
using BankApp.Formularios.Reportes.Telefonos;
using BankApp.Formularios.GraficosEstadisticos.PagosElectronicos;
using BankApp.Formularios.GraficosEstadisticos.Canjes;
using BankApp.Formularios.GraficosEstadisticos.Usuarios;
using BankApp.Formularios.GraficosEstadisticos.Cuentas;
using BankApp.Formularios.GraficosEstadisticos.Transferencias;




namespace BankApp
{
    public partial class Frm_Escritorio : Form
    {
        public Frm_Escritorio()
        {
            InitializeComponent();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_maximizar.Visible = false;
            btn_restaurar.Visible = true;
        }

        private void btn_restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btn_restaurar.Visible = false;
            btn_maximizar.Visible = true;
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void OcultarSubmenu()
        {
            if (pnl_submenu_procesos.Visible == true)
                pnl_submenu_procesos.Visible = false;
            
            if (pnl_submenu_abm.Visible == true)
                pnl_submenu_abm.Visible = false;

            if (pnl_submenu_reportes.Visible == true)
                pnl_submenu_reportes.Visible = false;
        }
        private void MostrarSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                OcultarSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void btn_abm_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(pnl_submenu_abm);
        }

        private void btn_usuarios_Click(object sender, EventArgs e)
        {
            Frm_ABM_Usuarios frm_usuarios_abm = new Frm_ABM_Usuarios();
            frm_usuarios_abm.ShowDialog();
            //....
            //....
            //....
            //OcultarSubmenu();
        }

        private void btn_cuentas_Click(object sender, EventArgs e)
        {
            Frm_ABM_Cuentas frm_cuentas_abm = new Frm_ABM_Cuentas();
            frm_cuentas_abm.ShowDialog();
            //....
            //....
            //....
            //OcultarSubmenu();
        }

        private void btn_premios_Click(object sender, EventArgs e)
        {
            Frm_ABM_Premios frm_premios_abm = new Frm_ABM_Premios();
            frm_premios_abm.ShowDialog();
            //....
            //....
            //....
            //OcultarSubmenu();
        }

        private void btn_cotizaciones_Click(object sender, EventArgs e)
        {
            Frm_ABM_Cotizaciones frm_cotizaciones_abm = new Frm_ABM_Cotizaciones();
            frm_cotizaciones_abm.ShowDialog();
            //....
            //....
            //....
            //OcultarSubmenu();
        }

        private void btn_referidos_Click(object sender, EventArgs e)
        {
            //....
            //....
            //....
            //OcultarSubmenu();
        }

        private void btn_procesos_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(pnl_submenu_procesos);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btn_telefonos_Click(object sender, EventArgs e)
        {
            Frm_ABM_Telefonos frm_telefonos_abm = new Frm_ABM_Telefonos();
            frm_telefonos_abm.ShowDialog();
        }

        private void btn_servicios_Click(object sender, EventArgs e)
        {
            Frm_ABM_Servicios Frm_Servicios_ABM = new Frm_ABM_Servicios();
            Frm_Servicios_ABM.ShowDialog();
        }

        private void btn_monedas_Click_1(object sender, EventArgs e)
        {
            Frm_ABM_Monedas frm_monedas_abm = new Frm_ABM_Monedas();
            frm_monedas_abm.ShowDialog();
        }

        private void btn_tipopremio_Click(object sender, EventArgs e)
        {
            Frm_ABM_TipoDePremio frm_tipoPremio_abm = new Frm_ABM_TipoDePremio();
            frm_tipoPremio_abm.ShowDialog();
        }

        private void btn_tipooperaciones_Click(object sender, EventArgs e)
        {
            Frm_ABM_TiposOperaciones frm_tipoOperacion_abm = new Frm_ABM_TiposOperaciones();
            frm_tipoOperacion_abm.ShowDialog();
        }

        private void btn_tipocuentas_Click(object sender, EventArgs e)
        {
            Frm_ABM_TiposCuentas frm_tipoCuenta_abm = new Frm_ABM_TiposCuentas();
            frm_tipoCuenta_abm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_ABM_TiposDocumentos frm_tipoDocumento_abm = new Frm_ABM_TiposDocumentos();
            frm_tipoDocumento_abm.ShowDialog();
        }

        //Frm_ayuda frm_help = new Frm_ayuda();
        //frm_help.ShowDialog();
        private void btn_ayuda_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_pagoelectronico_Click(object sender, EventArgs e)
        {
            Frm_Pago_Electronico frm_pago_elect = new Frm_Pago_Electronico();
            frm_pago_elect.ShowDialog();
        }

        private void btn_tarifas_Click(object sender, EventArgs e)
        {
            Frm_ABM_Tarifas frm_tarifas_abm = new Frm_ABM_Tarifas();
            frm_tarifas_abm.ShowDialog();
        }

        private void btn_transferencia_Click(object sender, EventArgs e)
        {
            Frm_Transferencia frm_transferencia = new Frm_Transferencia();
            frm_transferencia.ShowDialog();
        }

        private void btn_canje_Click(object sender, EventArgs e)
        {
            Frm_Canje_Premio frm_canje = new Frm_Canje_Premio();
            frm_canje.ShowDialog();
        }

        private void btn_ayuda_Click_1(object sender, EventArgs e)
        {
            Frm_ayuda frm_help = new Frm_ayuda();
            frm_help.ShowDialog();
        }

        private void btn_reportes_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(pnl_submenu_reportes);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frm_ReportesPagosElectronicos frm_Rpg = new Frm_ReportesPagosElectronicos();
            frm_Rpg.ShowDialog();
        }

        private void btn_reporte_canje_Click(object sender, EventArgs e)
        {
            Frm_ReportesCanjes frm_RpCanje = new Frm_ReportesCanjes();
            frm_RpCanje.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Frm_ReportesCanjes frm_RpCanje = new Frm_ReportesCanjes();
            frm_RpCanje.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_ReportesTransferencias frm_RpTransferencia = new Frm_ReportesTransferencias();
            frm_RpTransferencia.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Frm_ReportesCuentas frm_ReportesCuentas = new Frm_ReportesCuentas();
            frm_ReportesCuentas.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Frm_ReportesUsuarios frm_ReportesUsuarios = new Frm_ReportesUsuarios();
            frm_ReportesUsuarios.ShowDialog();
        }

        private void btn_graficos_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(pnl_submenu_graficos);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Frm_EstadisticasPagosElectronicos frm_GEP = new Frm_EstadisticasPagosElectronicos();
            frm_GEP.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Frm_EstadisticasCanjes frm_GEC = new Frm_EstadisticasCanjes();
            frm_GEC.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Frm_EstadisticasUsuarios frm_GEU = new Frm_EstadisticasUsuarios();
            frm_GEU.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Frm_EstadisticasCuentas frm_GEC = new Frm_EstadisticasCuentas();
            frm_GEC.ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Frm_Estadisticas_Transferencias frm_GET = new Frm_Estadisticas_Transferencias();
            frm_GET.ShowDialog();
        }
    }
}
