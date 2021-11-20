
namespace BankApp.Formularios.GraficosEstadisticos.Cuentas
{
    partial class Frm_EstadisticasCuentas
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
            this.rv01 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_tipo_cuenta = new BankApp.Clases.ComboBox01();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_SaldoMin = new BankApp.Clases.LabelText();
            this.txt_SaldoMax = new BankApp.Clases.LabelText();
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
            this.pnl_titulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_titulo.Location = new System.Drawing.Point(-143, 0);
            this.pnl_titulo.Size = new System.Drawing.Size(1038, 35);
            // 
            // btn_restaurar
            // 
            this.btn_restaurar.Location = new System.Drawing.Point(974, 5);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Location = new System.Drawing.Point(943, 5);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.Location = new System.Drawing.Point(974, 5);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(1004, 5);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Graficos Estadisticos sobre Cuentas\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 124);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(871, 447);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rv01);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cmb_tipo_cuenta);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(863, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cuentas por Tipo de Cuentas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rv01
            // 
            this.rv01.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rv01.Location = new System.Drawing.Point(3, 67);
            this.rv01.Name = "rv01";
            this.rv01.ServerReport.BearerToken = null;
            this.rv01.Size = new System.Drawing.Size(857, 351);
            this.rv01.TabIndex = 28;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(96)))), ((int)(((byte)(230)))));
            this.button2.Location = new System.Drawing.Point(271, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 29);
            this.button2.TabIndex = 27;
            this.button2.Text = "Calcular";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de Cuenta";
            // 
            // cmb_tipo_cuenta
            // 
            this.cmb_tipo_cuenta._ComboSinSeleccion = false;
            this.cmb_tipo_cuenta._MensajeError = null;
            this.cmb_tipo_cuenta._Nombre_campo = "tipo_cuenta";
            this.cmb_tipo_cuenta._Nombre_tabla = null;
            this.cmb_tipo_cuenta._tabla_cargar_combo = "Tipos_Cuentas";
            this.cmb_tipo_cuenta._tabla_cargar_descriptor = "descripcion";
            this.cmb_tipo_cuenta._tabla_cargar_pk = "id";
            this.cmb_tipo_cuenta._Validable = true;
            this.cmb_tipo_cuenta.FormattingEnabled = true;
            this.cmb_tipo_cuenta.Location = new System.Drawing.Point(135, 20);
            this.cmb_tipo_cuenta.Name = "cmb_tipo_cuenta";
            this.cmb_tipo_cuenta.Size = new System.Drawing.Size(121, 21);
            this.cmb_tipo_cuenta.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reportViewer1);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.txt_SaldoMin);
            this.tabPage2.Controls.Add(this.txt_SaldoMax);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(863, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cuentas por Saldos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.Location = new System.Drawing.Point(6, 101);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(851, 314);
            this.reportViewer1.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(96)))), ((int)(((byte)(230)))));
            this.button1.Location = new System.Drawing.Point(287, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 29);
            this.button1.TabIndex = 26;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_SaldoMin
            // 
            this.txt_SaldoMin._Ancho = 10;
            this.txt_SaldoMin._Decimales = 2;
            this.txt_SaldoMin._Etiqueta = "Saldo Min.";
            this.txt_SaldoMin._Mask = "CCCCCCCCCC";
            this.txt_SaldoMin._MensajeError = null;
            this.txt_SaldoMin._Nombre_Campo = null;
            this.txt_SaldoMin._Nombre_Tabla = null;
            this.txt_SaldoMin._ReadOnly = false;
            this.txt_SaldoMin._Text = "";
            this.txt_SaldoMin._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_SaldoMin._TipoDato = BankApp.Clases.LabelText.TipoDato.texto;
            this.txt_SaldoMin._Validable = false;
            this.txt_SaldoMin.Location = new System.Drawing.Point(6, 19);
            this.txt_SaldoMin.Name = "txt_SaldoMin";
            this.txt_SaldoMin.Size = new System.Drawing.Size(254, 29);
            this.txt_SaldoMin.TabIndex = 24;
            // 
            // txt_SaldoMax
            // 
            this.txt_SaldoMax._Ancho = 10;
            this.txt_SaldoMax._Decimales = 2;
            this.txt_SaldoMax._Etiqueta = "Saldo Max.";
            this.txt_SaldoMax._Mask = "CCCCCCCCCC";
            this.txt_SaldoMax._MensajeError = null;
            this.txt_SaldoMax._Nombre_Campo = null;
            this.txt_SaldoMax._Nombre_Tabla = null;
            this.txt_SaldoMax._ReadOnly = false;
            this.txt_SaldoMax._Text = "";
            this.txt_SaldoMax._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_SaldoMax._TipoDato = BankApp.Clases.LabelText.TipoDato.texto;
            this.txt_SaldoMax._Validable = false;
            this.txt_SaldoMax.Location = new System.Drawing.Point(6, 54);
            this.txt_SaldoMax.Name = "txt_SaldoMax";
            this.txt_SaldoMax.Size = new System.Drawing.Size(254, 29);
            this.txt_SaldoMax.TabIndex = 25;
            // 
            // Frm_EstadisticasCuentas
            // 
            this._FormularioMovil = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(895, 583);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "Frm_EstadisticasCuentas";
            this.Load += new System.EventHandler(this.Frm_EstadisticasCuentas_Load);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.Button button1;
        private Clases.LabelText txt_SaldoMax;
        private Clases.LabelText txt_SaldoMin;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer rv01;
        public System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private Clases.ComboBox01 cmb_tipo_cuenta;
    }
}
