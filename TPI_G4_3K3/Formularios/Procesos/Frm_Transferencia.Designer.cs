
namespace BankApp.Formularios.Procesos
{
    partial class Frm_Transferencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Transferencia));
            this.btn_CargarCuentaOrigen = new System.Windows.Forms.Button();
            this.lbl_Saldo = new BankApp.Clases.LabelText();
            this.lbl_MonedaOrigen = new BankApp.Clases.LabelText();
            this.lbl_CuentaDestino = new BankApp.Clases.LabelText();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_MonedaDestino = new BankApp.Clases.LabelText();
            this.btn_CargarCuentaDestino = new System.Windows.Forms.Button();
            this.grid_transferencia = new BankApp.Clases.Grid01();
            this.btn_ver = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btn_grabar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_actualizar)).BeginInit();
            this.pnl_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_transferencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ver)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(263, 44);
            this.label1.Text = "Transferencia";
            // 
            // btn_grabar
            // 
            this.btn_grabar.Location = new System.Drawing.Point(944, 385);
            this.btn_grabar.Size = new System.Drawing.Size(55, 50);
            this.btn_grabar.Click += new System.EventHandler(this.btn_grabar_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Location = new System.Drawing.Point(1039, 385);
            this.btn_actualizar.Size = new System.Drawing.Size(55, 50);
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // lbl_cta_origen
            // 
            this.lbl_cta_origen._Decimales = 0;
            this.lbl_cta_origen.Location = new System.Drawing.Point(121, 188);
            // 
            // lbl_hora
            // 
            this.lbl_hora._Mask = "00:00:00";
            this.lbl_hora._Text = "  :  :";
            // 
            // lbl_importe
            // 
            this.lbl_importe.Location = new System.Drawing.Point(542, 336);
            this.lbl_importe.Size = new System.Drawing.Size(323, 36);
            // 
            // pnl_titulo
            // 
            this.pnl_titulo.Location = new System.Drawing.Point(-7, 0);
            // 
            // btn_CargarCuentaOrigen
            // 
            this.btn_CargarCuentaOrigen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_CargarCuentaOrigen.Location = new System.Drawing.Point(360, 24);
            this.btn_CargarCuentaOrigen.Name = "btn_CargarCuentaOrigen";
            this.btn_CargarCuentaOrigen.Size = new System.Drawing.Size(36, 28);
            this.btn_CargarCuentaOrigen.TabIndex = 31;
            this.btn_CargarCuentaOrigen.UseVisualStyleBackColor = false;
            this.btn_CargarCuentaOrigen.Click += new System.EventHandler(this.btn_CargarCuentaOrigen_Click);
            // 
            // lbl_Saldo
            // 
            this.lbl_Saldo._Ancho = 10;
            this.lbl_Saldo._Decimales = 2;
            this.lbl_Saldo._Etiqueta = "Saldo";
            this.lbl_Saldo._Mask = "9999999.99";
            this.lbl_Saldo._MensajeError = null;
            this.lbl_Saldo._Nombre_Campo = "saldo";
            this.lbl_Saldo._Nombre_Tabla = "Cuentas";
            this.lbl_Saldo._ReadOnly = true;
            this.lbl_Saldo._Text = "       ,";
            this.lbl_Saldo._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.lbl_Saldo._TipoDato = BankApp.Clases.LabelText.TipoDato.numero;
            this.lbl_Saldo._Validable = false;
            this.lbl_Saldo.Location = new System.Drawing.Point(427, 61);
            this.lbl_Saldo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbl_Saldo.Name = "lbl_Saldo";
            this.lbl_Saldo.Size = new System.Drawing.Size(331, 36);
            this.lbl_Saldo.TabIndex = 32;
            // 
            // lbl_MonedaOrigen
            // 
            this.lbl_MonedaOrigen._Ancho = 3;
            this.lbl_MonedaOrigen._Decimales = 0;
            this.lbl_MonedaOrigen._Etiqueta = "Moneda Origen";
            this.lbl_MonedaOrigen._Mask = "CCC";
            this.lbl_MonedaOrigen._MensajeError = null;
            this.lbl_MonedaOrigen._Nombre_Campo = "id_moneda";
            this.lbl_MonedaOrigen._Nombre_Tabla = "Cuentas";
            this.lbl_MonedaOrigen._ReadOnly = true;
            this.lbl_MonedaOrigen._Text = "";
            this.lbl_MonedaOrigen._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.lbl_MonedaOrigen._TipoDato = BankApp.Clases.LabelText.TipoDato.texto;
            this.lbl_MonedaOrigen._Validable = false;
            this.lbl_MonedaOrigen.Location = new System.Drawing.Point(14, 61);
            this.lbl_MonedaOrigen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbl_MonedaOrigen.Name = "lbl_MonedaOrigen";
            this.lbl_MonedaOrigen.Size = new System.Drawing.Size(291, 36);
            this.lbl_MonedaOrigen.TabIndex = 33;
            this.lbl_MonedaOrigen.Load += new System.EventHandler(this.lbt_MonedaOrigen_Load);
            // 
            // lbl_CuentaDestino
            // 
            this.lbl_CuentaDestino._Ancho = 10;
            this.lbl_CuentaDestino._Decimales = 0;
            this.lbl_CuentaDestino._Etiqueta = "Cuenta Destino";
            this.lbl_CuentaDestino._Mask = "CCCCCCCCCC";
            this.lbl_CuentaDestino._MensajeError = null;
            this.lbl_CuentaDestino._Nombre_Campo = "numero";
            this.lbl_CuentaDestino._Nombre_Tabla = "Cuentas";
            this.lbl_CuentaDestino._ReadOnly = false;
            this.lbl_CuentaDestino._Text = "";
            this.lbl_CuentaDestino._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.lbl_CuentaDestino._TipoDato = BankApp.Clases.LabelText.TipoDato.texto;
            this.lbl_CuentaDestino._Validable = false;
            this.lbl_CuentaDestino.Location = new System.Drawing.Point(14, 22);
            this.lbl_CuentaDestino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbl_CuentaDestino.Name = "lbl_CuentaDestino";
            this.lbl_CuentaDestino.Size = new System.Drawing.Size(339, 36);
            this.lbl_CuentaDestino.TabIndex = 34;
            this.lbl_CuentaDestino.Load += new System.EventHandler(this.labelText2_Load);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_Saldo);
            this.groupBox1.Controls.Add(this.lbl_MonedaOrigen);
            this.groupBox1.Controls.Add(this.btn_CargarCuentaOrigen);
            this.groupBox1.Location = new System.Drawing.Point(107, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(879, 121);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_MonedaDestino);
            this.groupBox2.Controls.Add(this.btn_CargarCuentaDestino);
            this.groupBox2.Controls.Add(this.lbl_CuentaDestino);
            this.groupBox2.Location = new System.Drawing.Point(107, 314);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(419, 121);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            // 
            // lbl_MonedaDestino
            // 
            this.lbl_MonedaDestino._Ancho = 3;
            this.lbl_MonedaDestino._Decimales = 0;
            this.lbl_MonedaDestino._Etiqueta = "Moneda Destino";
            this.lbl_MonedaDestino._Mask = "CCC";
            this.lbl_MonedaDestino._MensajeError = null;
            this.lbl_MonedaDestino._Nombre_Campo = "id_moneda";
            this.lbl_MonedaDestino._Nombre_Tabla = "Cuentas";
            this.lbl_MonedaDestino._ReadOnly = true;
            this.lbl_MonedaDestino._Text = "";
            this.lbl_MonedaDestino._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.lbl_MonedaDestino._TipoDato = BankApp.Clases.LabelText.TipoDato.texto;
            this.lbl_MonedaDestino._Validable = false;
            this.lbl_MonedaDestino.Location = new System.Drawing.Point(14, 66);
            this.lbl_MonedaDestino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbl_MonedaDestino.Name = "lbl_MonedaDestino";
            this.lbl_MonedaDestino.Size = new System.Drawing.Size(291, 36);
            this.lbl_MonedaDestino.TabIndex = 37;
            // 
            // btn_CargarCuentaDestino
            // 
            this.btn_CargarCuentaDestino.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_CargarCuentaDestino.Location = new System.Drawing.Point(360, 30);
            this.btn_CargarCuentaDestino.Name = "btn_CargarCuentaDestino";
            this.btn_CargarCuentaDestino.Size = new System.Drawing.Size(36, 28);
            this.btn_CargarCuentaDestino.TabIndex = 37;
            this.btn_CargarCuentaDestino.UseVisualStyleBackColor = false;
            this.btn_CargarCuentaDestino.Click += new System.EventHandler(this.btn_CargarCuentaDestino_Click);
            // 
            // grid_transferencia
            // 
            this.grid_transferencia.AllowUserToAddRows = false;
            this.grid_transferencia.AllowUserToDeleteRows = false;
            this.grid_transferencia.BackgroundColor = System.Drawing.Color.White;
            this.grid_transferencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_transferencia.Location = new System.Drawing.Point(42, 534);
            this.grid_transferencia.Margin = new System.Windows.Forms.Padding(4);
            this.grid_transferencia.Name = "grid_transferencia";
            this.grid_transferencia.ReadOnly = true;
            this.grid_transferencia.RowHeadersWidth = 51;
            this.grid_transferencia.Size = new System.Drawing.Size(1093, 106);
            this.grid_transferencia.TabIndex = 37;
            // 
            // btn_ver
            // 
            this.btn_ver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ver.Image = ((System.Drawing.Image)(resources.GetObject("btn_ver.Image")));
            this.btn_ver.Location = new System.Drawing.Point(61, 474);
            this.btn_ver.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ver.Name = "btn_ver";
            this.btn_ver.Size = new System.Drawing.Size(49, 52);
            this.btn_ver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_ver.TabIndex = 38;
            this.btn_ver.TabStop = false;
            this.btn_ver.Click += new System.EventHandler(this.btn_ver_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 501);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(533, 25);
            this.label3.TabIndex = 39;
            this.label3.Text = "Presione el Boton para Visualizar Datos de su Transferencia";
            // 
            // Frm_Transferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1181, 665);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_ver);
            this.Controls.Add(this.grid_transferencia);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Frm_Transferencia";
            this.Load += new System.EventHandler(this.Frm_Transferencia_Load);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lbl_fecha, 0);
            this.Controls.SetChildIndex(this.lbl_hora, 0);
            this.Controls.SetChildIndex(this.lbl_importe, 0);
            this.Controls.SetChildIndex(this.pnl_titulo, 0);
            this.Controls.SetChildIndex(this.btn_grabar, 0);
            this.Controls.SetChildIndex(this.btn_actualizar, 0);
            this.Controls.SetChildIndex(this.btn_FechaSistema, 0);
            this.Controls.SetChildIndex(this.btn_HoraSistema, 0);
            this.Controls.SetChildIndex(this.lbl_cta_origen, 0);
            this.Controls.SetChildIndex(this.grid_transferencia, 0);
            this.Controls.SetChildIndex(this.btn_ver, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btn_grabar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_actualizar)).EndInit();
            this.pnl_titulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_transferencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_CargarCuentaOrigen;
        private Clases.LabelText lbl_Saldo;
        private Clases.LabelText lbl_MonedaOrigen;
        private Clases.LabelText lbl_CuentaDestino;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_CargarCuentaDestino;
        private Clases.LabelText lbl_MonedaDestino;
        private Clases.Grid01 grid_transferencia;
        protected System.Windows.Forms.PictureBox btn_ver;
        private System.Windows.Forms.Label label3;
    }
}
