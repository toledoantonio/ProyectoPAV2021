
namespace BankApp.Formularios.GraficosEstadisticos.Transferencias
{
    partial class Frm_Estadisticas_Transferencias
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chk_DatosValorTotal = new System.Windows.Forms.CheckBox();
            this.txt_MesHasta01 = new BankApp.Clases.LabelText();
            this.rv01 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_buscar01 = new System.Windows.Forms.Button();
            this.txt_MesDesde01 = new BankApp.Clases.LabelText();
            this.txt_Año01 = new BankApp.Clases.LabelText();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txt_CuentaDestino = new BankApp.Clases.LabelText();
            this.txt_CuentaOrigen = new BankApp.Clases.LabelText();
            this.buttonLC = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txt_fechaHasta01 = new BankApp.Clases.LabelText();
            this.txt_fechaDesde01 = new BankApp.Clases.LabelText();
            this.btn_buscar02 = new System.Windows.Forms.Button();
            this.rv02 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pnl_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_titulo
            // 
            this.pnl_titulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_titulo.Size = new System.Drawing.Size(951, 35);
            // 
            // btn_restaurar
            // 
            this.btn_restaurar.Location = new System.Drawing.Point(886, 5);
            this.btn_restaurar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Location = new System.Drawing.Point(856, 5);
            this.btn_minimizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.Location = new System.Drawing.Point(886, 5);
            this.btn_maximizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(916, 4);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 26);
            this.label1.TabIndex = 12;
            this.label1.Text = "Gráficos Estadísticos de Transferencias";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 114);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(951, 529);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chk_DatosValorTotal);
            this.tabPage1.Controls.Add(this.txt_MesHasta01);
            this.tabPage1.Controls.Add(this.rv01);
            this.tabPage1.Controls.Add(this.btn_buscar01);
            this.tabPage1.Controls.Add(this.txt_MesDesde01);
            this.tabPage1.Controls.Add(this.txt_Año01);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(943, 503);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Estadisticas Mensuales sobre Transferencias";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chk_DatosValorTotal
            // 
            this.chk_DatosValorTotal.AutoSize = true;
            this.chk_DatosValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_DatosValorTotal.Location = new System.Drawing.Point(538, 50);
            this.chk_DatosValorTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chk_DatosValorTotal.Name = "chk_DatosValorTotal";
            this.chk_DatosValorTotal.Size = new System.Drawing.Size(67, 17);
            this.chk_DatosValorTotal.TabIndex = 25;
            this.chk_DatosValorTotal.Text = "Montos";
            this.chk_DatosValorTotal.UseVisualStyleBackColor = true;
            // 
            // txt_MesHasta01
            // 
            this.txt_MesHasta01._Ancho = 2;
            this.txt_MesHasta01._Decimales = 0;
            this.txt_MesHasta01._Etiqueta = "Mes Hasta";
            this.txt_MesHasta01._Mask = "99";
            this.txt_MesHasta01._MensajeError = null;
            this.txt_MesHasta01._Nombre_Campo = null;
            this.txt_MesHasta01._Nombre_Tabla = null;
            this.txt_MesHasta01._ReadOnly = false;
            this.txt_MesHasta01._Text = "";
            this.txt_MesHasta01._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_MesHasta01._TipoDato = BankApp.Clases.LabelText.TipoDato.numero;
            this.txt_MesHasta01._Validable = false;
            this.txt_MesHasta01.Location = new System.Drawing.Point(305, 41);
            this.txt_MesHasta01.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_MesHasta01.Name = "txt_MesHasta01";
            this.txt_MesHasta01.Size = new System.Drawing.Size(198, 29);
            this.txt_MesHasta01.TabIndex = 24;
            // 
            // rv01
            // 
            this.rv01.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rv01.Location = new System.Drawing.Point(2, 84);
            this.rv01.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rv01.Name = "rv01";
            this.rv01.ServerReport.BearerToken = null;
            this.rv01.Size = new System.Drawing.Size(941, 420);
            this.rv01.TabIndex = 23;
            // 
            // btn_buscar01
            // 
            this.btn_buscar01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar01.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar01.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(96)))), ((int)(((byte)(230)))));
            this.btn_buscar01.Location = new System.Drawing.Point(643, 41);
            this.btn_buscar01.Name = "btn_buscar01";
            this.btn_buscar01.Size = new System.Drawing.Size(83, 29);
            this.btn_buscar01.TabIndex = 22;
            this.btn_buscar01.Text = "Buscar";
            this.btn_buscar01.UseVisualStyleBackColor = true;
            this.btn_buscar01.Click += new System.EventHandler(this.btn_buscar01_Click);
            // 
            // txt_MesDesde01
            // 
            this.txt_MesDesde01._Ancho = 2;
            this.txt_MesDesde01._Decimales = 0;
            this.txt_MesDesde01._Etiqueta = "Mes Desde";
            this.txt_MesDesde01._Mask = "99";
            this.txt_MesDesde01._MensajeError = null;
            this.txt_MesDesde01._Nombre_Campo = null;
            this.txt_MesDesde01._Nombre_Tabla = null;
            this.txt_MesDesde01._ReadOnly = false;
            this.txt_MesDesde01._Text = "";
            this.txt_MesDesde01._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_MesDesde01._TipoDato = BankApp.Clases.LabelText.TipoDato.numero;
            this.txt_MesDesde01._Validable = false;
            this.txt_MesDesde01.Location = new System.Drawing.Point(87, 41);
            this.txt_MesDesde01.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_MesDesde01.Name = "txt_MesDesde01";
            this.txt_MesDesde01.Size = new System.Drawing.Size(198, 29);
            this.txt_MesDesde01.TabIndex = 1;
            // 
            // txt_Año01
            // 
            this.txt_Año01._Ancho = 4;
            this.txt_Año01._Decimales = 0;
            this.txt_Año01._Etiqueta = "Año";
            this.txt_Año01._Mask = "9999";
            this.txt_Año01._MensajeError = null;
            this.txt_Año01._Nombre_Campo = null;
            this.txt_Año01._Nombre_Tabla = null;
            this.txt_Año01._ReadOnly = false;
            this.txt_Año01._Text = "";
            this.txt_Año01._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_Año01._TipoDato = BankApp.Clases.LabelText.TipoDato.numero;
            this.txt_Año01._Validable = false;
            this.txt_Año01.Location = new System.Drawing.Point(87, 13);
            this.txt_Año01.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Año01.Name = "txt_Año01";
            this.txt_Año01.Size = new System.Drawing.Size(213, 29);
            this.txt_Año01.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reportViewer1);
            this.tabPage2.Controls.Add(this.txt_CuentaDestino);
            this.tabPage2.Controls.Add(this.txt_CuentaOrigen);
            this.tabPage2.Controls.Add(this.buttonLC);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(943, 503);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Estadisticas sobre Cuentas en Dias";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(5, 131);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(930, 364);
            this.reportViewer1.TabIndex = 0;
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
            this.txt_CuentaDestino.Location = new System.Drawing.Point(130, 77);
            this.txt_CuentaDestino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_CuentaDestino.Name = "txt_CuentaDestino";
            this.txt_CuentaDestino.Size = new System.Drawing.Size(254, 29);
            this.txt_CuentaDestino.TabIndex = 23;
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
            this.txt_CuentaOrigen.Location = new System.Drawing.Point(130, 40);
            this.txt_CuentaOrigen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_CuentaOrigen.Name = "txt_CuentaOrigen";
            this.txt_CuentaOrigen.Size = new System.Drawing.Size(254, 29);
            this.txt_CuentaOrigen.TabIndex = 24;
            // 
            // buttonLC
            // 
            this.buttonLC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(96)))), ((int)(((byte)(230)))));
            this.buttonLC.Location = new System.Drawing.Point(438, 77);
            this.buttonLC.Name = "buttonLC";
            this.buttonLC.Size = new System.Drawing.Size(83, 29);
            this.buttonLC.TabIndex = 25;
            this.buttonLC.Text = "Calcular";
            this.buttonLC.UseVisualStyleBackColor = true;
            this.buttonLC.Click += new System.EventHandler(this.buttonLC_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txt_fechaHasta01);
            this.tabPage3.Controls.Add(this.txt_fechaDesde01);
            this.tabPage3.Controls.Add(this.btn_buscar02);
            this.tabPage3.Controls.Add(this.rv02);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(943, 503);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Estadisticas sobre Monedas usadas en Transferencias";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txt_fechaHasta01
            // 
            this.txt_fechaHasta01._Ancho = 10;
            this.txt_fechaHasta01._Decimales = 2;
            this.txt_fechaHasta01._Etiqueta = "fechaHasta";
            this.txt_fechaHasta01._Mask = "00/00/0000";
            this.txt_fechaHasta01._MensajeError = null;
            this.txt_fechaHasta01._Nombre_Campo = null;
            this.txt_fechaHasta01._Nombre_Tabla = null;
            this.txt_fechaHasta01._ReadOnly = false;
            this.txt_fechaHasta01._Text = "  /  /";
            this.txt_fechaHasta01._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_fechaHasta01._TipoDato = BankApp.Clases.LabelText.TipoDato.fecha;
            this.txt_fechaHasta01._Validable = false;
            this.txt_fechaHasta01.Location = new System.Drawing.Point(249, 28);
            this.txt_fechaHasta01.Name = "txt_fechaHasta01";
            this.txt_fechaHasta01.Size = new System.Drawing.Size(244, 29);
            this.txt_fechaHasta01.TabIndex = 25;
            // 
            // txt_fechaDesde01
            // 
            this.txt_fechaDesde01._Ancho = 10;
            this.txt_fechaDesde01._Decimales = 2;
            this.txt_fechaDesde01._Etiqueta = "fechaDesde";
            this.txt_fechaDesde01._Mask = "00/00/0000";
            this.txt_fechaDesde01._MensajeError = null;
            this.txt_fechaDesde01._Nombre_Campo = null;
            this.txt_fechaDesde01._Nombre_Tabla = null;
            this.txt_fechaDesde01._ReadOnly = false;
            this.txt_fechaDesde01._Text = "  /  /";
            this.txt_fechaDesde01._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_fechaDesde01._TipoDato = BankApp.Clases.LabelText.TipoDato.fecha;
            this.txt_fechaDesde01._Validable = false;
            this.txt_fechaDesde01.Location = new System.Drawing.Point(11, 28);
            this.txt_fechaDesde01.Name = "txt_fechaDesde01";
            this.txt_fechaDesde01.Size = new System.Drawing.Size(245, 29);
            this.txt_fechaDesde01.TabIndex = 24;
            // 
            // btn_buscar02
            // 
            this.btn_buscar02.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar02.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar02.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(96)))), ((int)(((byte)(230)))));
            this.btn_buscar02.Location = new System.Drawing.Point(592, 28);
            this.btn_buscar02.Name = "btn_buscar02";
            this.btn_buscar02.Size = new System.Drawing.Size(83, 29);
            this.btn_buscar02.TabIndex = 23;
            this.btn_buscar02.Text = "Buscar";
            this.btn_buscar02.UseVisualStyleBackColor = true;
            this.btn_buscar02.Click += new System.EventHandler(this.btn_buscar02_Click);
            // 
            // rv02
            // 
            this.rv02.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rv02.Location = new System.Drawing.Point(2, 84);
            this.rv02.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rv02.Name = "rv02";
            this.rv02.ServerReport.BearerToken = null;
            this.rv02.Size = new System.Drawing.Size(941, 420);
            this.rv02.TabIndex = 0;
            // 
            // Frm_Estadisticas_Transferencias
            // 
            this._FormularioMovil = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(951, 643);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_Estadisticas_Transferencias";
            this.Load += new System.EventHandler(this.Frm_Estadisticas_Transferencias_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.Controls.SetChildIndex(this.pnl_titulo, 0);
            this.pnl_titulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Clases.LabelText txt_MesDesde01;
        private Clases.LabelText txt_Año01;
        private Microsoft.Reporting.WinForms.ReportViewer rv01;
        public System.Windows.Forms.Button btn_buscar01;
        private Clases.LabelText txt_MesHasta01;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        public System.Windows.Forms.Button buttonLC;
        private Clases.LabelText txt_CuentaOrigen;
        private Clases.LabelText txt_CuentaDestino;
        private System.Windows.Forms.CheckBox chk_DatosValorTotal;
        private System.Windows.Forms.TabPage tabPage3;
        private Microsoft.Reporting.WinForms.ReportViewer rv02;
        private Clases.LabelText txt_fechaHasta01;
        private Clases.LabelText txt_fechaDesde01;
        public System.Windows.Forms.Button btn_buscar02;
    }
}
