using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApp.Formularios.FrmBase
{
    public partial class Frm_Base : Form
    {
        bool dragging;
        int posicionX, posicionY;

        public bool _FormularioMovil { get; set; }

        public bool Pp_minimizarVisible
        {
            set { btn_minimizar.Visible = value; }
        }
        public bool Pp_maximizarVisible
        {
            set { btn_maximizar.Visible = value; }
        }
        public bool _ControlSalida { get; set; } = false;

        public Frm_Base()
        {
            InitializeComponent();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.cerrar();
        }

        private void btn_maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_maximizar.Visible = false;
            btn_restaurar.Visible = true;
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btn_restaurar.Visible = false;
            btn_maximizar.Visible = true;
        }

        private void Frm_Base_MouseMove(object sender, MouseEventArgs e)
        {
            if (_FormularioMovil == false)
                return;
            if (dragging == true)
            {
                this.Location = new Point(this.Location.X + e.X - posicionX, this.Location.Y + e.Y - posicionY);
                this.Refresh();
            }
        }

        private void Frm_Base_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void Frm_Base_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            posicionX = e.X;
            posicionY = e.Y;
        }

        private void pnl_titulo_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            posicionX = e.X;
            posicionY = e.Y;
        }

        private void pnl_titulo_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void pnl_titulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (_FormularioMovil == false)
                return;
            if (dragging == true)
            {
                this.Location = new Point(this.Location.X + e.X - posicionX, this.Location.Y + e.Y - posicionY);
                this.Refresh();
            }
        }

        private void FrmBase_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_ControlSalida == true)
            {
                if (MessageBox.Show("¿Quiere salir del Programa?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        public void cerrar()
        {
            this.Close();
        }
    }
}
