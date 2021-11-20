
namespace BankApp.Formularios.Tarifa
{
    partial class Frm_Tarifas
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
            this.txt_id = new BankApp.Clases.LabelText();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.txt_monto_base = new BankApp.Clases.LabelText();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_fecha_vig_hasta = new BankApp.Clases.LabelText();
            this.txt_fecha_vig_desde = new BankApp.Clases.LabelText();
            this.txt_porcentaje = new BankApp.Clases.LabelText();
            this.txt_monto_sup = new BankApp.Clases.LabelText();
            this.pnl_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_titulo
            // 
            this.pnl_titulo.Location = new System.Drawing.Point(-113, 0);
            // 
            // btn_restaurar
            // 
            this.btn_restaurar.Location = new System.Drawing.Point(411, 7);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Location = new System.Drawing.Point(380, 7);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.Location = new System.Drawing.Point(411, 7);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(442, 7);
            // 
            // txt_id
            // 
            this.txt_id._Ancho = 2;
            this.txt_id._Decimales = 0;
            this.txt_id._Etiqueta = "ID ";
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
            this.txt_id.Location = new System.Drawing.Point(13, 131);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(211, 29);
            this.txt_id.TabIndex = 30;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(96)))), ((int)(((byte)(230)))));
            this.btn_aceptar.Location = new System.Drawing.Point(219, 360);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(115, 35);
            this.btn_aceptar.TabIndex = 29;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // txt_monto_base
            // 
            this.txt_monto_base._Ancho = 25;
            this.txt_monto_base._Decimales = 2;
            this.txt_monto_base._Etiqueta = "Monto Base";
            this.txt_monto_base._Mask = "CCCCCCCCCCCCCCCCCCCCCCCCC";
            this.txt_monto_base._MensajeError = "El nombre está vacío.";
            this.txt_monto_base._Nombre_Campo = "nombre";
            this.txt_monto_base._Nombre_Tabla = null;
            this.txt_monto_base._ReadOnly = false;
            this.txt_monto_base._Text = "";
            this.txt_monto_base._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_monto_base._TipoDato = BankApp.Clases.LabelText.TipoDato.texto;
            this.txt_monto_base._Validable = true;
            this.txt_monto_base.Location = new System.Drawing.Point(12, 166);
            this.txt_monto_base.Name = "txt_monto_base";
            this.txt_monto_base.Size = new System.Drawing.Size(262, 29);
            this.txt_monto_base.TabIndex = 28;
            this.txt_monto_base.Load += new System.EventHandler(this.txt_nombre_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 29);
            this.label1.TabIndex = 27;
            this.label1.Text = "Titulo";
            // 
            // txt_fecha_vig_hasta
            // 
            this.txt_fecha_vig_hasta._Ancho = 10;
            this.txt_fecha_vig_hasta._Decimales = 2;
            this.txt_fecha_vig_hasta._Etiqueta = "Fecha Vigente Hasta";
            this.txt_fecha_vig_hasta._Mask = "00/00/0000";
            this.txt_fecha_vig_hasta._MensajeError = "La descripcion está vacía.";
            this.txt_fecha_vig_hasta._Nombre_Campo = "fecha";
            this.txt_fecha_vig_hasta._Nombre_Tabla = null;
            this.txt_fecha_vig_hasta._ReadOnly = false;
            this.txt_fecha_vig_hasta._Text = "  /  /";
            this.txt_fecha_vig_hasta._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_fecha_vig_hasta._TipoDato = BankApp.Clases.LabelText.TipoDato.fecha;
            this.txt_fecha_vig_hasta._Validable = false;
            this.txt_fecha_vig_hasta.Location = new System.Drawing.Point(12, 270);
            this.txt_fecha_vig_hasta.Name = "txt_fecha_vig_hasta";
            this.txt_fecha_vig_hasta.Size = new System.Drawing.Size(248, 29);
            this.txt_fecha_vig_hasta.TabIndex = 37;
            // 
            // txt_fecha_vig_desde
            // 
            this.txt_fecha_vig_desde._Ancho = 10;
            this.txt_fecha_vig_desde._Decimales = 2;
            this.txt_fecha_vig_desde._Etiqueta = "Fecha Vigente Desde";
            this.txt_fecha_vig_desde._Mask = "00/00/0000";
            this.txt_fecha_vig_desde._MensajeError = "La descripcion está vacía.";
            this.txt_fecha_vig_desde._Nombre_Campo = "fecha";
            this.txt_fecha_vig_desde._Nombre_Tabla = null;
            this.txt_fecha_vig_desde._ReadOnly = false;
            this.txt_fecha_vig_desde._Text = "  /  /";
            this.txt_fecha_vig_desde._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_fecha_vig_desde._TipoDato = BankApp.Clases.LabelText.TipoDato.fecha;
            this.txt_fecha_vig_desde._Validable = false;
            this.txt_fecha_vig_desde.Location = new System.Drawing.Point(12, 235);
            this.txt_fecha_vig_desde.Name = "txt_fecha_vig_desde";
            this.txt_fecha_vig_desde.Size = new System.Drawing.Size(248, 29);
            this.txt_fecha_vig_desde.TabIndex = 38;
            // 
            // txt_porcentaje
            // 
            this.txt_porcentaje._Ancho = 25;
            this.txt_porcentaje._Decimales = 2;
            this.txt_porcentaje._Etiqueta = "Porcentaje";
            this.txt_porcentaje._Mask = "CCCCCCCCCCCCCCCCCCCCCCCCC";
            this.txt_porcentaje._MensajeError = "El nombre está vacío.";
            this.txt_porcentaje._Nombre_Campo = "nombre";
            this.txt_porcentaje._Nombre_Tabla = null;
            this.txt_porcentaje._ReadOnly = false;
            this.txt_porcentaje._Text = "";
            this.txt_porcentaje._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_porcentaje._TipoDato = BankApp.Clases.LabelText.TipoDato.texto;
            this.txt_porcentaje._Validable = true;
            this.txt_porcentaje.Location = new System.Drawing.Point(12, 305);
            this.txt_porcentaje.Name = "txt_porcentaje";
            this.txt_porcentaje.Size = new System.Drawing.Size(262, 29);
            this.txt_porcentaje.TabIndex = 39;
            // 
            // txt_monto_sup
            // 
            this.txt_monto_sup._Ancho = 25;
            this.txt_monto_sup._Decimales = 2;
            this.txt_monto_sup._Etiqueta = "Monto Superior";
            this.txt_monto_sup._Mask = "CCCCCCCCCCCCCCCCCCCCCCCCC";
            this.txt_monto_sup._MensajeError = "El nombre está vacío.";
            this.txt_monto_sup._Nombre_Campo = "nombre";
            this.txt_monto_sup._Nombre_Tabla = null;
            this.txt_monto_sup._ReadOnly = false;
            this.txt_monto_sup._Text = "";
            this.txt_monto_sup._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_monto_sup._TipoDato = BankApp.Clases.LabelText.TipoDato.texto;
            this.txt_monto_sup._Validable = true;
            this.txt_monto_sup.Location = new System.Drawing.Point(12, 200);
            this.txt_monto_sup.Name = "txt_monto_sup";
            this.txt_monto_sup.Size = new System.Drawing.Size(262, 29);
            this.txt_monto_sup.TabIndex = 40;
            this.txt_monto_sup.Load += new System.EventHandler(this.labelText3_Load);
            // 
            // Frm_Tarifas
            // 
            this._FormularioMovil = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(366, 439);
            this.Controls.Add(this.txt_monto_sup);
            this.Controls.Add(this.txt_porcentaje);
            this.Controls.Add(this.txt_fecha_vig_desde);
            this.Controls.Add(this.txt_fecha_vig_hasta);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.txt_monto_base);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Tarifas";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txt_monto_base, 0);
            this.Controls.SetChildIndex(this.btn_aceptar, 0);
            this.Controls.SetChildIndex(this.pnl_titulo, 0);
            this.Controls.SetChildIndex(this.txt_id, 0);
            this.Controls.SetChildIndex(this.txt_fecha_vig_hasta, 0);
            this.Controls.SetChildIndex(this.txt_fecha_vig_desde, 0);
            this.Controls.SetChildIndex(this.txt_porcentaje, 0);
            this.Controls.SetChildIndex(this.txt_monto_sup, 0);
            this.pnl_titulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Clases.LabelText txt_id;
        public System.Windows.Forms.Button btn_aceptar;
        public Clases.LabelText txt_monto_base;
        public System.Windows.Forms.Label label1;
        public Clases.LabelText txt_fecha_vig_hasta;
        public Clases.LabelText txt_fecha_vig_desde;
        public Clases.LabelText txt_porcentaje;
        public Clases.LabelText txt_monto_sup;
    }
}
