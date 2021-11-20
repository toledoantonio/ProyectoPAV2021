
namespace BankApp.Formularios.Cuentas
{
    partial class Frm_Cuentas_Borrar
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cuentas_Borrar));
            this.pnl_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Size = new System.Drawing.Size(173, 29);
            this.label1.Text = "Borrar Cuenta";
            // 
            // txt_id_usuario
            // 
            this.txt_id_usuario.Enabled = false;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Text = "Borrar";
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // cmb_tiposCuentas
            // 
            this.cmb_tiposCuentas.DisplayMember = "descripcion";
            this.cmb_tiposCuentas.Enabled = false;
            this.cmb_tiposCuentas.Size = new System.Drawing.Size(107, 21);
            this.cmb_tiposCuentas.ValueMember = "id";
            // 
            // cmb_monedas
            // 
            this.cmb_monedas.DisplayMember = "nombre";
            this.cmb_monedas.Enabled = false;
            this.cmb_monedas.Size = new System.Drawing.Size(107, 21);
            this.cmb_monedas.ValueMember = "id";
            // 
            // txt_puntos
            // 
            this.txt_puntos.Enabled = false;
            // 
            // txt_saldo
            // 
            this.txt_saldo.Enabled = false;
            // 
            // pnl_titulo
            // 
            this.pnl_titulo.Location = new System.Drawing.Point(3, 0);
            // 
            // Frm_Cuentas_Borrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(437, 406);
            this.Name = "Frm_Cuentas_Borrar";
            this.Load += new System.EventHandler(this.Frm_Cuentas_Borrar_Load);
            this.pnl_titulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
