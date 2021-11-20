
namespace BankApp.Formularios
{
    partial class Frm_Cotizaciones_Baja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cotizaciones_Baja));
            this.pnl_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Text = "Eliminar";
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // txt_valor
            // 
            this.txt_valor._TipoDato = BankApp.Clases.LabelText.TipoDato.texto;
            this.txt_valor.Enabled = false;
            // 
            // txt_cmb_mon_org
            // 
            this.txt_cmb_mon_org.DisplayMember = "nombre";
            this.txt_cmb_mon_org.Enabled = false;
            this.txt_cmb_mon_org.ValueMember = "id";
            // 
            // txt_fecha
            // 
            this.txt_fecha.Enabled = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(90, 75);
            this.label1.Size = new System.Drawing.Size(237, 29);
            this.label1.Text = "Eliminar Cotizacion";
            // 
            // txt_cmb_mon_dest
            // 
            this.txt_cmb_mon_dest.DisplayMember = "nombre";
            this.txt_cmb_mon_dest.Enabled = false;
            this.txt_cmb_mon_dest.ValueMember = "id";
            // 
            // Frm_Cotizaciones_Baja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(394, 419);
            this.Name = "Frm_Cotizaciones_Baja";
            this.Load += new System.EventHandler(this.Frm_Cotizaciones_Baja_Load_1);
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
