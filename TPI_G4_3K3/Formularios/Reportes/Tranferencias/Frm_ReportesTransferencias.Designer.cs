
namespace BankApp.Formularios.Reportes.Tranferencias
{
    partial class Frm_ReportesTransferencias
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
            this.Listado = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmb_monedasDestino = new BankApp.Clases.ComboBox01();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_monedasOrigen = new BankApp.Clases.ComboBox01();
            this.btn_calcular01 = new System.Windows.Forms.Button();
            this.rv01 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonLC = new System.Windows.Forms.Button();
            this.txt_CuentaOrigen = new BankApp.Clases.LabelText();
            this.txt_CuentaDestino = new BankApp.Clases.LabelText();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.txt_fecha_hasta = new BankApp.Clases.LabelText();
            this.txt_fecha_desde = new BankApp.Clases.LabelText();
            this.txt_cuenta_origen = new BankApp.Clases.LabelText();
            this.rv03 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).BeginInit();
            this.Listado.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_titulo
            // 
            this.pnl_titulo.Location = new System.Drawing.Point(-1, 0);
            this.pnl_titulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_titulo.Size = new System.Drawing.Size(952, 35);
            // 
            // btn_restaurar
            // 
            this.btn_restaurar.Location = new System.Drawing.Point(888, 5);
            this.btn_restaurar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Location = new System.Drawing.Point(857, 5);
            this.btn_minimizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.Location = new System.Drawing.Point(888, 5);
            this.btn_maximizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(917, 5);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            // 
            // Listado
            // 
            this.Listado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Listado.Controls.Add(this.tabPage1);
            this.Listado.Controls.Add(this.tabPage2);
            this.Listado.Controls.Add(this.tabPage3);
            this.Listado.Location = new System.Drawing.Point(9, 110);
            this.Listado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Listado.Name = "Listado";
            this.Listado.SelectedIndex = 0;
            this.Listado.Size = new System.Drawing.Size(932, 521);
            this.Listado.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmb_monedasDestino);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cmb_monedasOrigen);
            this.tabPage1.Controls.Add(this.btn_calcular01);
            this.tabPage1.Controls.Add(this.rv01);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(924, 495);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado por Monedas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmb_monedasDestino
            // 
            this.cmb_monedasDestino._ComboSinSeleccion = true;
            this.cmb_monedasDestino._MensajeError = "Falta Seleccionar Monedas";
            this.cmb_monedasDestino._Nombre_campo = "id_moneda";
            this.cmb_monedasDestino._Nombre_tabla = null;
            this.cmb_monedasDestino._tabla_cargar_combo = "Monedas";
            this.cmb_monedasDestino._tabla_cargar_descriptor = "simbolo";
            this.cmb_monedasDestino._tabla_cargar_pk = "id";
            this.cmb_monedasDestino._Validable = true;
            this.cmb_monedasDestino.FormattingEnabled = true;
            this.cmb_monedasDestino.Location = new System.Drawing.Point(466, 44);
            this.cmb_monedasDestino.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_monedasDestino.Name = "cmb_monedasDestino";
            this.cmb_monedasDestino.Size = new System.Drawing.Size(106, 21);
            this.cmb_monedasDestino.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(350, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Moneda Destino";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(356, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Moneda Origen";
            // 
            // cmb_monedasOrigen
            // 
            this.cmb_monedasOrigen._ComboSinSeleccion = true;
            this.cmb_monedasOrigen._MensajeError = "Falta Seleccionar Monedas";
            this.cmb_monedasOrigen._Nombre_campo = "id_moneda";
            this.cmb_monedasOrigen._Nombre_tabla = null;
            this.cmb_monedasOrigen._tabla_cargar_combo = "Monedas";
            this.cmb_monedasOrigen._tabla_cargar_descriptor = "simbolo";
            this.cmb_monedasOrigen._tabla_cargar_pk = "id";
            this.cmb_monedasOrigen._Validable = true;
            this.cmb_monedasOrigen.FormattingEnabled = true;
            this.cmb_monedasOrigen.Location = new System.Drawing.Point(466, 18);
            this.cmb_monedasOrigen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_monedasOrigen.Name = "cmb_monedasOrigen";
            this.cmb_monedasOrigen.Size = new System.Drawing.Size(106, 21);
            this.cmb_monedasOrigen.TabIndex = 24;
            // 
            // btn_calcular01
            // 
            this.btn_calcular01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calcular01.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcular01.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(96)))), ((int)(((byte)(230)))));
            this.btn_calcular01.Location = new System.Drawing.Point(608, 44);
            this.btn_calcular01.Name = "btn_calcular01";
            this.btn_calcular01.Size = new System.Drawing.Size(83, 29);
            this.btn_calcular01.TabIndex = 21;
            this.btn_calcular01.Text = "Calcular";
            this.btn_calcular01.UseVisualStyleBackColor = true;
            this.btn_calcular01.Click += new System.EventHandler(this.btn_calcular01_Click);
            // 
            // rv01
            // 
            this.rv01.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rv01.Location = new System.Drawing.Point(2, 80);
            this.rv01.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rv01.Name = "rv01";
            this.rv01.ServerReport.BearerToken = null;
            this.rv01.Size = new System.Drawing.Size(918, 418);
            this.rv01.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonLC);
            this.tabPage2.Controls.Add(this.txt_CuentaOrigen);
            this.tabPage2.Controls.Add(this.txt_CuentaDestino);
            this.tabPage2.Controls.Add(this.reportViewer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(924, 495);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Listado por Cuentas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonLC
            // 
            this.buttonLC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(96)))), ((int)(((byte)(230)))));
            this.buttonLC.Location = new System.Drawing.Point(368, 71);
            this.buttonLC.Name = "buttonLC";
            this.buttonLC.Size = new System.Drawing.Size(83, 29);
            this.buttonLC.TabIndex = 22;
            this.buttonLC.Text = "Calcular";
            this.buttonLC.UseVisualStyleBackColor = true;
            this.buttonLC.Click += new System.EventHandler(this.buttonLC_Click);
            // 
            // txt_CuentaOrigen
            // 
            this.txt_CuentaOrigen._Ancho = 10;
            this.txt_CuentaOrigen._Decimales = 2;
            this.txt_CuentaOrigen._Etiqueta = "Cuenta Origen";
            this.txt_CuentaOrigen._Mask = "CCCCCCCCCC";
            this.txt_CuentaOrigen._MensajeError = null;
            this.txt_CuentaOrigen._Nombre_Campo = null;
            this.txt_CuentaOrigen._Nombre_Tabla = null;
            this.txt_CuentaOrigen._ReadOnly = false;
            this.txt_CuentaOrigen._Text = "";
            this.txt_CuentaOrigen._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_CuentaOrigen._TipoDato = BankApp.Clases.LabelText.TipoDato.texto;
            this.txt_CuentaOrigen._Validable = false;
            this.txt_CuentaOrigen.Location = new System.Drawing.Point(70, 36);
            this.txt_CuentaOrigen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_CuentaOrigen.Name = "txt_CuentaOrigen";
            this.txt_CuentaOrigen.Size = new System.Drawing.Size(254, 29);
            this.txt_CuentaOrigen.TabIndex = 2;
            // 
            // txt_CuentaDestino
            // 
            this.txt_CuentaDestino._Ancho = 10;
            this.txt_CuentaDestino._Decimales = 2;
            this.txt_CuentaDestino._Etiqueta = "Cuenta Destino";
            this.txt_CuentaDestino._Mask = "CCCCCCCCCC";
            this.txt_CuentaDestino._MensajeError = null;
            this.txt_CuentaDestino._Nombre_Campo = null;
            this.txt_CuentaDestino._Nombre_Tabla = null;
            this.txt_CuentaDestino._ReadOnly = false;
            this.txt_CuentaDestino._Text = "";
            this.txt_CuentaDestino._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_CuentaDestino._TipoDato = BankApp.Clases.LabelText.TipoDato.texto;
            this.txt_CuentaDestino._Validable = false;
            this.txt_CuentaDestino.Location = new System.Drawing.Point(70, 71);
            this.txt_CuentaDestino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_CuentaDestino.Name = "txt_CuentaDestino";
            this.txt_CuentaDestino.Size = new System.Drawing.Size(254, 29);
            this.txt_CuentaDestino.TabIndex = 1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.Location = new System.Drawing.Point(5, 138);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(914, 352);
            this.reportViewer1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_calcular);
            this.tabPage3.Controls.Add(this.txt_fecha_hasta);
            this.tabPage3.Controls.Add(this.txt_fecha_desde);
            this.tabPage3.Controls.Add(this.txt_cuenta_origen);
            this.tabPage3.Controls.Add(this.rv03);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(924, 495);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Listado por Fecha";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_calcular
            // 
            this.btn_calcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(96)))), ((int)(((byte)(230)))));
            this.btn_calcular.Location = new System.Drawing.Point(656, 64);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(83, 29);
            this.btn_calcular.TabIndex = 26;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // txt_fecha_hasta
            // 
            this.txt_fecha_hasta._Ancho = 10;
            this.txt_fecha_hasta._Decimales = 2;
            this.txt_fecha_hasta._Etiqueta = "Fecha Hasta";
            this.txt_fecha_hasta._Mask = "00/00/0000";
            this.txt_fecha_hasta._MensajeError = null;
            this.txt_fecha_hasta._Nombre_Campo = null;
            this.txt_fecha_hasta._Nombre_Tabla = null;
            this.txt_fecha_hasta._ReadOnly = false;
            this.txt_fecha_hasta._Text = "  /  /";
            this.txt_fecha_hasta._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_fecha_hasta._TipoDato = BankApp.Clases.LabelText.TipoDato.fecha;
            this.txt_fecha_hasta._Validable = false;
            this.txt_fecha_hasta.Location = new System.Drawing.Point(356, 64);
            this.txt_fecha_hasta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_fecha_hasta.Name = "txt_fecha_hasta";
            this.txt_fecha_hasta.Size = new System.Drawing.Size(244, 29);
            this.txt_fecha_hasta.TabIndex = 25;
            // 
            // txt_fecha_desde
            // 
            this.txt_fecha_desde._Ancho = 10;
            this.txt_fecha_desde._Decimales = 2;
            this.txt_fecha_desde._Etiqueta = "Fecha Desde";
            this.txt_fecha_desde._Mask = "00/00/0000";
            this.txt_fecha_desde._MensajeError = null;
            this.txt_fecha_desde._Nombre_Campo = null;
            this.txt_fecha_desde._Nombre_Tabla = null;
            this.txt_fecha_desde._ReadOnly = false;
            this.txt_fecha_desde._Text = "  /  /";
            this.txt_fecha_desde._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_fecha_desde._TipoDato = BankApp.Clases.LabelText.TipoDato.fecha;
            this.txt_fecha_desde._Validable = false;
            this.txt_fecha_desde.Location = new System.Drawing.Point(356, 27);
            this.txt_fecha_desde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_fecha_desde.Name = "txt_fecha_desde";
            this.txt_fecha_desde.Size = new System.Drawing.Size(244, 29);
            this.txt_fecha_desde.TabIndex = 24;
            this.txt_fecha_desde.Load += new System.EventHandler(this.txt_fecha_desde_Load);
            // 
            // txt_cuenta_origen
            // 
            this.txt_cuenta_origen._Ancho = 2;
            this.txt_cuenta_origen._Decimales = 0;
            this.txt_cuenta_origen._Etiqueta = "Cuenta Origen";
            this.txt_cuenta_origen._Mask = "99";
            this.txt_cuenta_origen._MensajeError = null;
            this.txt_cuenta_origen._Nombre_Campo = null;
            this.txt_cuenta_origen._Nombre_Tabla = null;
            this.txt_cuenta_origen._ReadOnly = false;
            this.txt_cuenta_origen._Text = "";
            this.txt_cuenta_origen._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_cuenta_origen._TipoDato = BankApp.Clases.LabelText.TipoDato.numero;
            this.txt_cuenta_origen._Validable = false;
            this.txt_cuenta_origen.Location = new System.Drawing.Point(151, 27);
            this.txt_cuenta_origen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_cuenta_origen.Name = "txt_cuenta_origen";
            this.txt_cuenta_origen.Size = new System.Drawing.Size(198, 29);
            this.txt_cuenta_origen.TabIndex = 23;
            // 
            // rv03
            // 
            this.rv03.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rv03.Location = new System.Drawing.Point(4, 116);
            this.rv03.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rv03.Name = "rv03";
            this.rv03.ServerReport.BearerToken = null;
            this.rv03.Size = new System.Drawing.Size(920, 372);
            this.rv03.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Reporte sobre Transferencias";
            // 
            // Frm_ReportesTransferencias
            // 
            this._FormularioMovil = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(951, 641);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Listado);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_ReportesTransferencias";
            this.Load += new System.EventHandler(this.Frm_ReportesTransferencias_Load);
            this.Controls.SetChildIndex(this.Listado, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.pnl_titulo, 0);
            this.pnl_titulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).EndInit();
            this.Listado.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Listado;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.Button btn_calcular01;
        private Microsoft.Reporting.WinForms.ReportViewer rv01;
        public Clases.ComboBox01 cmb_monedasOrigen;
        private System.Windows.Forms.Label label3;
        public Clases.ComboBox01 cmb_monedasDestino;
        private System.Windows.Forms.Label label2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        public System.Windows.Forms.Button buttonLC;
        private Clases.LabelText txt_CuentaOrigen;
        private Clases.LabelText txt_CuentaDestino;
        private System.Windows.Forms.TabPage tabPage3;
        private Microsoft.Reporting.WinForms.ReportViewer rv03;
        private Clases.LabelText txt_cuenta_origen;
        private Clases.LabelText txt_fecha_desde;
        private Clases.LabelText txt_fecha_hasta;
        public System.Windows.Forms.Button btn_calcular;
    }
}
