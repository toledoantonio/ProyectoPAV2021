
namespace BankApp.Formularios.Monedas
{
    partial class Frm_Monedas
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
            this.txt_nombre = new BankApp.Clases.LabelText();
            this.labelText3 = new BankApp.Clases.LabelText();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.pnl_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_titulo
            // 
            this.pnl_titulo.Size = new System.Drawing.Size(361, 35);
            // 
            // btn_restaurar
            // 
            this.btn_restaurar.Location = new System.Drawing.Point(297, 3);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Location = new System.Drawing.Point(266, 3);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.Location = new System.Drawing.Point(65, 5);
            this.btn_maximizar.Visible = false;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar.Location = new System.Drawing.Point(328, 3);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Titulo";
            // 
            // txt_id
            // 
            this.txt_id._Ancho = 2;
            this.txt_id._Decimales = 0;
            this.txt_id._Etiqueta = "Id Moneda";
            this.txt_id._Mask = "CC";
            this.txt_id._MensajeError = null;
            this.txt_id._Nombre_Campo = null;
            this.txt_id._Nombre_Tabla = null;
            this.txt_id._ReadOnly = false;
            this.txt_id._Text = "";
            this.txt_id._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_id._TipoDato = BankApp.Clases.LabelText.TipoDato.texto;
            this.txt_id._Validable = false;
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(0, 113);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(197, 29);
            this.txt_id.TabIndex = 12;
            // 
            // txt_nombre
            // 
            this.txt_nombre._Ancho = 25;
            this.txt_nombre._Decimales = 2;
            this.txt_nombre._Etiqueta = "Nombre ";
            this.txt_nombre._Mask = "CCCCCCCCCCCCCCCCCCCCCCCCC";
            this.txt_nombre._MensajeError = "El nombre está vacío.";
            this.txt_nombre._Nombre_Campo = "nombre";
            this.txt_nombre._Nombre_Tabla = null;
            this.txt_nombre._ReadOnly = false;
            this.txt_nombre._Text = "";
            this.txt_nombre._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_nombre._TipoDato = BankApp.Clases.LabelText.TipoDato.texto;
            this.txt_nombre._Validable = true;
            this.txt_nombre.Location = new System.Drawing.Point(0, 146);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(353, 29);
            this.txt_nombre.TabIndex = 13;
            // 
            // labelText3
            // 
            this.labelText3._Ancho = 10;
            this.labelText3._Decimales = 0;
            this.labelText3._Etiqueta = "Símbolo";
            this.labelText3._Mask = "CCCCCCCCCC";
            this.labelText3._MensajeError = "Falta ingresar el símbolo.";
            this.labelText3._Nombre_Campo = "simbolo";
            this.labelText3._Nombre_Tabla = null;
            this.labelText3._ReadOnly = false;
            this.labelText3._Text = "";
            this.labelText3._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.labelText3._TipoDato = BankApp.Clases.LabelText.TipoDato.texto;
            this.labelText3._Validable = true;
            this.labelText3.Location = new System.Drawing.Point(0, 179);
            this.labelText3.Name = "labelText3";
            this.labelText3.Size = new System.Drawing.Size(259, 29);
            this.labelText3.TabIndex = 14;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(96)))), ((int)(((byte)(230)))));
            this.btn_aceptar.Location = new System.Drawing.Point(164, 233);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(115, 35);
            this.btn_aceptar.TabIndex = 20;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            // 
            // Frm_Monedas
            // 
            this._FormularioMovil = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(361, 289);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.labelText3);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Monedas";
            this.Controls.SetChildIndex(this.pnl_titulo, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txt_id, 0);
            this.Controls.SetChildIndex(this.txt_nombre, 0);
            this.Controls.SetChildIndex(this.labelText3, 0);
            this.Controls.SetChildIndex(this.btn_aceptar, 0);
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
        public Clases.LabelText txt_id;
        public Clases.LabelText txt_nombre;
        public Clases.LabelText labelText3;
        public System.Windows.Forms.Button btn_aceptar;
    }
}
