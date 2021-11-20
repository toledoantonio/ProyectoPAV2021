
namespace BankApp.Formularios.Tipos_de_Cuentas
{
    partial class Frm_TiposDeCuenta
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id = new BankApp.Clases.LabelText();
            this.txt_Descripcion = new BankApp.Clases.LabelText();
            this.pnl_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_titulo
            // 
            this.pnl_titulo.Location = new System.Drawing.Point(-110, 0);
            this.pnl_titulo.Size = new System.Drawing.Size(680, 43);
            // 
            // btn_restaurar
            // 
            this.btn_restaurar.Location = new System.Drawing.Point(594, 6);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Location = new System.Drawing.Point(553, 6);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.Location = new System.Drawing.Point(594, 6);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(634, 6);
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 35);
            this.label1.TabIndex = 23;
            this.label1.Text = "Titulo";
            // 
            // txt_id
            // 
            this.txt_id._Ancho = 8;
            this.txt_id._Decimales = 0;
            this.txt_id._Etiqueta = "Id";
            this.txt_id._MensajeError = null;
            this.txt_id._Nombre_Campo = null;
            this.txt_id._Nombre_Tabla = null;
            this.txt_id._ReadOnly = false;
            this.txt_id._Text = "";
            this.txt_id._TipoDato = BankApp.Clases.LabelText.TipoDato.texto;
            this.txt_id._Validable = false;
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(13, 141);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(339, 36);
            this.txt_id.TabIndex = 24;
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion._Ancho = 8;
            this.txt_Descripcion._Decimales = 0;
            this.txt_Descripcion._Etiqueta = "Descripcion";
            this.txt_Descripcion._MensajeError = null;
            this.txt_Descripcion._Nombre_Campo = null;
            this.txt_Descripcion._Nombre_Tabla = null;
            this.txt_Descripcion._ReadOnly = false;
            this.txt_Descripcion._Text = "";
            this.txt_Descripcion._TipoDato = BankApp.Clases.LabelText.TipoDato.texto;
            this.txt_Descripcion._Validable = false;
            this.txt_Descripcion.Location = new System.Drawing.Point(13, 185);
            this.txt_Descripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(339, 36);
            this.txt_Descripcion.TabIndex = 25;
            // 
            // Frm_TiposDeCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(570, 468);
            this.Controls.Add(this.txt_Descripcion);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label1);
            this.Name = "Frm_TiposDeCuenta";
            this.Controls.SetChildIndex(this.pnl_titulo, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txt_id, 0);
            this.Controls.SetChildIndex(this.txt_Descripcion, 0);
            this.pnl_titulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        private Clases.LabelText txt_id;
        private Clases.LabelText txt_Descripcion;
    }
}
