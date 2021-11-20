
namespace BankApp.Formularios.Procesos
{
    partial class Frm_Procesos_Base
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Procesos_Base));
            this.lbl_cta_origen = new BankApp.Clases.LabelText();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_fecha = new BankApp.Clases.LabelText();
            this.lbl_hora = new BankApp.Clases.LabelText();
            this.lbl_importe = new BankApp.Clases.LabelText();
            this.btn_grabar = new System.Windows.Forms.PictureBox();
            this.btn_actualizar = new System.Windows.Forms.PictureBox();
            this.btn_FechaSistema = new System.Windows.Forms.Button();
            this.btn_HoraSistema = new System.Windows.Forms.Button();
            this.pnl_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_grabar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_actualizar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_titulo
            // 
            this.pnl_titulo.Margin = new System.Windows.Forms.Padding(5);
            this.pnl_titulo.Size = new System.Drawing.Size(1195, 43);
            // 
            // btn_restaurar
            // 
            this.btn_restaurar.Location = new System.Drawing.Point(1109, 6);
            this.btn_restaurar.Margin = new System.Windows.Forms.Padding(5);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Location = new System.Drawing.Point(1068, 6);
            this.btn_minimizar.Margin = new System.Windows.Forms.Padding(5);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.Location = new System.Drawing.Point(1109, 6);
            this.btn_maximizar.Margin = new System.Windows.Forms.Padding(5);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(1151, 6);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(5);
            // 
            // lbl_cta_origen
            // 
            this.lbl_cta_origen._Ancho = 10;
            this.lbl_cta_origen._Decimales = 2;
            this.lbl_cta_origen._Etiqueta = "Cuenta Origen";
            this.lbl_cta_origen._Mask = "CCCCCCCCCC";
            this.lbl_cta_origen._MensajeError = null;
            this.lbl_cta_origen._Nombre_Campo = "numero";
            this.lbl_cta_origen._Nombre_Tabla = "Cuentas";
            this.lbl_cta_origen._ReadOnly = false;
            this.lbl_cta_origen._Text = "";
            this.lbl_cta_origen._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.lbl_cta_origen._TipoDato = BankApp.Clases.LabelText.TipoDato.texto;
            this.lbl_cta_origen._Validable = false;
            this.lbl_cta_origen.Location = new System.Drawing.Point(43, 154);
            this.lbl_cta_origen.Margin = new System.Windows.Forms.Padding(5);
            this.lbl_cta_origen.Name = "lbl_cta_origen";
            this.lbl_cta_origen.Size = new System.Drawing.Size(339, 36);
            this.lbl_cta_origen.TabIndex = 10;
            this.lbl_cta_origen.Load += new System.EventHandler(this.lbl_cta_origen_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 44);
            this.label1.TabIndex = 22;
            this.label1.Text = "Titulo";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha._Ancho = 10;
            this.lbl_fecha._Decimales = 2;
            this.lbl_fecha._Etiqueta = "Fecha";
            this.lbl_fecha._Mask = "00/00/0000";
            this.lbl_fecha._MensajeError = null;
            this.lbl_fecha._Nombre_Campo = null;
            this.lbl_fecha._Nombre_Tabla = null;
            this.lbl_fecha._ReadOnly = false;
            this.lbl_fecha._Text = "  /  /";
            this.lbl_fecha._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.lbl_fecha._TipoDato = BankApp.Clases.LabelText.TipoDato.fecha;
            this.lbl_fecha._Validable = false;
            this.lbl_fecha.Enabled = false;
            this.lbl_fecha.Location = new System.Drawing.Point(777, 82);
            this.lbl_fecha.Margin = new System.Windows.Forms.Padding(5);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(339, 36);
            this.lbl_fecha.TabIndex = 23;
            // 
            // lbl_hora
            // 
            this.lbl_hora._Ancho = 6;
            this.lbl_hora._Decimales = 2;
            this.lbl_hora._Etiqueta = "Hora";
            this.lbl_hora._Mask = "00/00/0000";
            this.lbl_hora._MensajeError = null;
            this.lbl_hora._Nombre_Campo = null;
            this.lbl_hora._Nombre_Tabla = null;
            this.lbl_hora._ReadOnly = false;
            this.lbl_hora._Text = "  /  /";
            this.lbl_hora._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.lbl_hora._TipoDato = BankApp.Clases.LabelText.TipoDato.fecha;
            this.lbl_hora._Validable = false;
            this.lbl_hora.Enabled = false;
            this.lbl_hora.Location = new System.Drawing.Point(777, 130);
            this.lbl_hora.Margin = new System.Windows.Forms.Padding(5);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(339, 36);
            this.lbl_hora.TabIndex = 24;
            // 
            // lbl_importe
            // 
            this.lbl_importe._Ancho = 10;
            this.lbl_importe._Decimales = 2;
            this.lbl_importe._Etiqueta = "Importe";
            this.lbl_importe._Mask = "9999999.99";
            this.lbl_importe._MensajeError = null;
            this.lbl_importe._Nombre_Campo = null;
            this.lbl_importe._Nombre_Tabla = null;
            this.lbl_importe._ReadOnly = false;
            this.lbl_importe._Text = "       ,";
            this.lbl_importe._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.lbl_importe._TipoDato = BankApp.Clases.LabelText.TipoDato.numero;
            this.lbl_importe._Validable = false;
            this.lbl_importe.Location = new System.Drawing.Point(43, 197);
            this.lbl_importe.Margin = new System.Windows.Forms.Padding(5);
            this.lbl_importe.Name = "lbl_importe";
            this.lbl_importe.Size = new System.Drawing.Size(339, 36);
            this.lbl_importe.TabIndex = 25;
            // 
            // btn_grabar
            // 
            this.btn_grabar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_grabar.Image = ((System.Drawing.Image)(resources.GetObject("btn_grabar.Image")));
            this.btn_grabar.Location = new System.Drawing.Point(43, 810);
            this.btn_grabar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_grabar.Name = "btn_grabar";
            this.btn_grabar.Size = new System.Drawing.Size(73, 68);
            this.btn_grabar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_grabar.TabIndex = 27;
            this.btn_grabar.TabStop = false;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_actualizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_actualizar.Image")));
            this.btn_actualizar.Location = new System.Drawing.Point(147, 810);
            this.btn_actualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(73, 68);
            this.btn_actualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_actualizar.TabIndex = 28;
            this.btn_actualizar.TabStop = false;
            // 
            // btn_FechaSistema
            // 
            this.btn_FechaSistema.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_FechaSistema.Location = new System.Drawing.Point(1117, 86);
            this.btn_FechaSistema.Margin = new System.Windows.Forms.Padding(4);
            this.btn_FechaSistema.Name = "btn_FechaSistema";
            this.btn_FechaSistema.Size = new System.Drawing.Size(36, 28);
            this.btn_FechaSistema.TabIndex = 29;
            this.btn_FechaSistema.UseVisualStyleBackColor = false;
            this.btn_FechaSistema.Click += new System.EventHandler(this.btn_FechaSistema_Click);
            // 
            // btn_HoraSistema
            // 
            this.btn_HoraSistema.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_HoraSistema.Location = new System.Drawing.Point(1117, 138);
            this.btn_HoraSistema.Margin = new System.Windows.Forms.Padding(4);
            this.btn_HoraSistema.Name = "btn_HoraSistema";
            this.btn_HoraSistema.Size = new System.Drawing.Size(36, 28);
            this.btn_HoraSistema.TabIndex = 30;
            this.btn_HoraSistema.UseVisualStyleBackColor = false;
            this.btn_HoraSistema.Click += new System.EventHandler(this.btn_HoraSistema_Click_1);
            // 
            // Frm_Procesos_Base
            // 
            this._ControlSalida = true;
            this._FormularioMovil = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1195, 892);
            this.Controls.Add(this.btn_HoraSistema);
            this.Controls.Add(this.btn_FechaSistema);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.btn_grabar);
            this.Controls.Add(this.lbl_importe);
            this.Controls.Add(this.lbl_hora);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_cta_origen);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frm_Procesos_Base";
            this.Controls.SetChildIndex(this.lbl_cta_origen, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lbl_fecha, 0);
            this.Controls.SetChildIndex(this.lbl_hora, 0);
            this.Controls.SetChildIndex(this.lbl_importe, 0);
            this.Controls.SetChildIndex(this.pnl_titulo, 0);
            this.Controls.SetChildIndex(this.btn_grabar, 0);
            this.Controls.SetChildIndex(this.btn_actualizar, 0);
            this.Controls.SetChildIndex(this.btn_FechaSistema, 0);
            this.Controls.SetChildIndex(this.btn_HoraSistema, 0);
            this.pnl_titulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_grabar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_actualizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label label1;
        protected System.Windows.Forms.PictureBox btn_grabar;
        protected System.Windows.Forms.PictureBox btn_actualizar;
        public Clases.LabelText lbl_cta_origen;
        public Clases.LabelText lbl_fecha;
        public Clases.LabelText lbl_hora;
        public Clases.LabelText lbl_importe;
        public System.Windows.Forms.Button btn_FechaSistema;
        public System.Windows.Forms.Button btn_HoraSistema;
    }
}
