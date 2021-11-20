
namespace BankApp.Formularios.GraficosEstadisticos.PagosElectronicos
{
    partial class Frm_EstadisticasPagosElectronicos
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chk_01 = new System.Windows.Forms.CheckBox();
            this.txt_mes2 = new BankApp.Clases.LabelText();
            this.btn_buscar01 = new System.Windows.Forms.Button();
            this.txt_ano = new BankApp.Clases.LabelText();
            this.txt_mes = new BankApp.Clases.LabelText();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rv02 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_buscar02 = new System.Windows.Forms.Button();
            this.txt_ano01 = new BankApp.Clases.LabelText();
            this.txt_mes01 = new BankApp.Clases.LabelText();
            this.label1 = new System.Windows.Forms.Label();
            this.rv01 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pnl_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_titulo
            // 
            this.pnl_titulo.Size = new System.Drawing.Size(984, 35);
            // 
            // btn_restaurar
            // 
            this.btn_restaurar.Location = new System.Drawing.Point(920, 5);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Location = new System.Drawing.Point(889, 5);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.Location = new System.Drawing.Point(920, 5);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(950, 5);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 115);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(963, 565);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rv01);
            this.tabPage1.Controls.Add(this.chk_01);
            this.tabPage1.Controls.Add(this.txt_mes2);
            this.tabPage1.Controls.Add(this.btn_buscar01);
            this.tabPage1.Controls.Add(this.txt_ano);
            this.tabPage1.Controls.Add(this.txt_mes);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(955, 539);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Estadistica sobre Valores de  Cantidad de Pagos e Importes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chk_01
            // 
            this.chk_01.AutoSize = true;
            this.chk_01.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_01.Location = new System.Drawing.Point(504, 51);
            this.chk_01.Name = "chk_01";
            this.chk_01.Size = new System.Drawing.Size(85, 22);
            this.chk_01.TabIndex = 34;
            this.chk_01.Text = "Importes";
            this.chk_01.UseVisualStyleBackColor = true;
            // 
            // txt_mes2
            // 
            this.txt_mes2._Ancho = 2;
            this.txt_mes2._Decimales = 0;
            this.txt_mes2._Etiqueta = "Mes";
            this.txt_mes2._Mask = "99";
            this.txt_mes2._MensajeError = null;
            this.txt_mes2._Nombre_Campo = null;
            this.txt_mes2._Nombre_Tabla = null;
            this.txt_mes2._ReadOnly = false;
            this.txt_mes2._Text = "";
            this.txt_mes2._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_mes2._TipoDato = BankApp.Clases.LabelText.TipoDato.numero;
            this.txt_mes2._Validable = false;
            this.txt_mes2.Location = new System.Drawing.Point(234, 47);
            this.txt_mes2.Name = "txt_mes2";
            this.txt_mes2.Size = new System.Drawing.Size(208, 29);
            this.txt_mes2.TabIndex = 33;
            // 
            // btn_buscar01
            // 
            this.btn_buscar01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar01.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar01.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(96)))), ((int)(((byte)(230)))));
            this.btn_buscar01.Location = new System.Drawing.Point(672, 47);
            this.btn_buscar01.Name = "btn_buscar01";
            this.btn_buscar01.Size = new System.Drawing.Size(83, 29);
            this.btn_buscar01.TabIndex = 30;
            this.btn_buscar01.Text = "Buscar";
            this.btn_buscar01.UseVisualStyleBackColor = true;
            this.btn_buscar01.Click += new System.EventHandler(this.btn_buscar01_Click);
            // 
            // txt_ano
            // 
            this.txt_ano._Ancho = 4;
            this.txt_ano._Decimales = 0;
            this.txt_ano._Etiqueta = "Año";
            this.txt_ano._Mask = "9999";
            this.txt_ano._MensajeError = null;
            this.txt_ano._Nombre_Campo = null;
            this.txt_ano._Nombre_Tabla = null;
            this.txt_ano._ReadOnly = false;
            this.txt_ano._Text = "";
            this.txt_ano._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_ano._TipoDato = BankApp.Clases.LabelText.TipoDato.numero;
            this.txt_ano._Validable = false;
            this.txt_ano.Location = new System.Drawing.Point(34, 14);
            this.txt_ano.Name = "txt_ano";
            this.txt_ano.Size = new System.Drawing.Size(209, 29);
            this.txt_ano.TabIndex = 29;
            // 
            // txt_mes
            // 
            this.txt_mes._Ancho = 2;
            this.txt_mes._Decimales = 0;
            this.txt_mes._Etiqueta = "Mes";
            this.txt_mes._Mask = "99";
            this.txt_mes._MensajeError = null;
            this.txt_mes._Nombre_Campo = null;
            this.txt_mes._Nombre_Tabla = null;
            this.txt_mes._ReadOnly = false;
            this.txt_mes._Text = "";
            this.txt_mes._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_mes._TipoDato = BankApp.Clases.LabelText.TipoDato.numero;
            this.txt_mes._Validable = false;
            this.txt_mes.Location = new System.Drawing.Point(34, 47);
            this.txt_mes.Name = "txt_mes";
            this.txt_mes.Size = new System.Drawing.Size(209, 29);
            this.txt_mes.TabIndex = 28;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rv02);
            this.tabPage2.Controls.Add(this.btn_buscar02);
            this.tabPage2.Controls.Add(this.txt_ano01);
            this.tabPage2.Controls.Add(this.txt_mes01);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(955, 539);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Estadistica sobre Valores de Servicios ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rv02
            // 
            this.rv02.Location = new System.Drawing.Point(6, 82);
            this.rv02.Name = "rv02";
            this.rv02.ServerReport.BearerToken = null;
            this.rv02.Size = new System.Drawing.Size(943, 451);
            this.rv02.TabIndex = 37;
            // 
            // btn_buscar02
            // 
            this.btn_buscar02.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar02.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar02.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(96)))), ((int)(((byte)(230)))));
            this.btn_buscar02.Location = new System.Drawing.Point(402, 47);
            this.btn_buscar02.Name = "btn_buscar02";
            this.btn_buscar02.Size = new System.Drawing.Size(83, 29);
            this.btn_buscar02.TabIndex = 36;
            this.btn_buscar02.Text = "Buscar";
            this.btn_buscar02.UseVisualStyleBackColor = true;
            this.btn_buscar02.Click += new System.EventHandler(this.btn_buscar02_Click);
            // 
            // txt_ano01
            // 
            this.txt_ano01._Ancho = 4;
            this.txt_ano01._Decimales = 2;
            this.txt_ano01._Etiqueta = "Año";
            this.txt_ano01._Mask = "CCCC";
            this.txt_ano01._MensajeError = null;
            this.txt_ano01._Nombre_Campo = null;
            this.txt_ano01._Nombre_Tabla = null;
            this.txt_ano01._ReadOnly = false;
            this.txt_ano01._Text = "";
            this.txt_ano01._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_ano01._TipoDato = BankApp.Clases.LabelText.TipoDato.texto;
            this.txt_ano01._Validable = false;
            this.txt_ano01.Location = new System.Drawing.Point(42, 14);
            this.txt_ano01.Name = "txt_ano01";
            this.txt_ano01.Size = new System.Drawing.Size(209, 29);
            this.txt_ano01.TabIndex = 35;
            // 
            // txt_mes01
            // 
            this.txt_mes01._Ancho = 2;
            this.txt_mes01._Decimales = 2;
            this.txt_mes01._Etiqueta = "Mes";
            this.txt_mes01._Mask = "CC";
            this.txt_mes01._MensajeError = null;
            this.txt_mes01._Nombre_Campo = null;
            this.txt_mes01._Nombre_Tabla = null;
            this.txt_mes01._ReadOnly = false;
            this.txt_mes01._Text = "";
            this.txt_mes01._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_mes01._TipoDato = BankApp.Clases.LabelText.TipoDato.texto;
            this.txt_mes01._Validable = false;
            this.txt_mes01.Location = new System.Drawing.Point(42, 47);
            this.txt_mes01.Name = "txt_mes01";
            this.txt_mes01.Size = new System.Drawing.Size(209, 29);
            this.txt_mes01.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Graficos Estadisticos sobre Pagos Electronicos";
            // 
            // rv01
            // 
            this.rv01.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rv01.Location = new System.Drawing.Point(6, 82);
            this.rv01.Name = "rv01";
            this.rv01.ServerReport.BearerToken = null;
            this.rv01.Size = new System.Drawing.Size(943, 451);
            this.rv01.TabIndex = 35;
            // 
            // Frm_EstadisticasPagosElectronicos
            // 
            this._FormularioMovil = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(984, 692);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Frm_EstadisticasPagosElectronicos";
            this.Load += new System.EventHandler(this.Frm_EstadisticasPagosElectronicos_Load);
            this.Controls.SetChildIndex(this.pnl_titulo, 0);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.pnl_titulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btn_buscar01;
        private Clases.LabelText txt_ano;
        private Clases.LabelText txt_mes;
        private Clases.LabelText txt_mes2;
        private System.Windows.Forms.CheckBox chk_01;
        public System.Windows.Forms.Button btn_buscar02;
        private Clases.LabelText txt_ano01;
        private Clases.LabelText txt_mes01;
        private Microsoft.Reporting.WinForms.ReportViewer rv02;
        private Microsoft.Reporting.WinForms.ReportViewer rv01;
    }
}
