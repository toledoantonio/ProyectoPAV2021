
namespace BankApp.Formularios.Cuentas
{
    partial class Frm_Cuentas_Alta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cuentas_Alta));
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
            this.label1.Size = new System.Drawing.Size(181, 29);
            this.label1.Text = "Alta de Cuenta";
            // 
            // txt_numero
            // 
            this.txt_numero._Nombre_Campo = "numero";
            this.txt_numero.Margin = new System.Windows.Forms.Padding(3);
            // 
            // txt_id_usuario
            // 
            this.txt_id_usuario._Nombre_Campo = "";
            this.txt_id_usuario.Location = new System.Drawing.Point(19, 157);
            this.txt_id_usuario.Margin = new System.Windows.Forms.Padding(3);
            this.txt_id_usuario.Size = new System.Drawing.Size(201, 29);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Text = "Registrar";
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // cmb_tiposCuentas
            // 
            this.cmb_tiposCuentas.DisplayMember = "descripcion";
            this.cmb_tiposCuentas.Size = new System.Drawing.Size(107, 21);
            this.cmb_tiposCuentas.ValueMember = "id";
            // 
            // cmb_monedas
            // 
            this.cmb_monedas.DisplayMember = "nombre";
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
            this.pnl_titulo.Location = new System.Drawing.Point(1, 0);
            // 
            // Frm_Cuentas_Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(433, 406);
            this.Name = "Frm_Cuentas_Alta";
            this.Load += new System.EventHandler(this.Frm_Cuentas_Alta_Load);
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
