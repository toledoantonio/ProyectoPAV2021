
namespace BankApp.Formularios.Reportes.Cuentas
{
    partial class Frm_ReportesCuentas
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
            this.btn_calcular1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_monedas = new BankApp.Clases.ComboBox01();
            this.cmb_tipo_cuenta = new BankApp.Clases.ComboBox01();
            this.rv_cuentas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_SaldoMax = new BankApp.Clases.LabelText();
            this.txt_SaldoMin = new BankApp.Clases.LabelText();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
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
            this.pnl_titulo.Size = new System.Drawing.Size(857, 35);
            // 
            // btn_restaurar
            // 
            this.btn_restaurar.Location = new System.Drawing.Point(793, 5);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Location = new System.Drawing.Point(762, 5);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.Location = new System.Drawing.Point(793, 5);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(824, 5);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 100);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(833, 425);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_calcular1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cmb_monedas);
            this.tabPage1.Controls.Add(this.cmb_tipo_cuenta);
            this.tabPage1.Controls.Add(this.rv_cuentas);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(825, 399);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado de Cuentas por Tipo de Cuenta y Moneda";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_calcular1
            // 
            this.btn_calcular1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calcular1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcular1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(96)))), ((int)(((byte)(230)))));
            this.btn_calcular1.Location = new System.Drawing.Point(355, 40);
            this.btn_calcular1.Name = "btn_calcular1";
            this.btn_calcular1.Size = new System.Drawing.Size(81, 27);
            this.btn_calcular1.TabIndex = 22;
            this.btn_calcular1.Text = "Calcular";
            this.btn_calcular1.UseVisualStyleBackColor = true;
            this.btn_calcular1.Click += new System.EventHandler(this.btn_calcular1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(114, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Moneda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo de Cuenta";
            // 
            // cmb_monedas
            // 
            this.cmb_monedas._ComboSinSeleccion = false;
            this.cmb_monedas._MensajeError = "Falta Seleccionar Monedas";
            this.cmb_monedas._Nombre_campo = "id_moneda";
            this.cmb_monedas._Nombre_tabla = null;
            this.cmb_monedas._tabla_cargar_combo = "Monedas";
            this.cmb_monedas._tabla_cargar_descriptor = "simbolo";
            this.cmb_monedas._tabla_cargar_pk = "id";
            this.cmb_monedas._Validable = true;
            this.cmb_monedas.FormattingEnabled = true;
            this.cmb_monedas.Location = new System.Drawing.Point(195, 43);
            this.cmb_monedas.Name = "cmb_monedas";
            this.cmb_monedas.Size = new System.Drawing.Size(121, 21);
            this.cmb_monedas.TabIndex = 2;
            // 
            // cmb_tipo_cuenta
            // 
            this.cmb_tipo_cuenta._ComboSinSeleccion = false;
            this.cmb_tipo_cuenta._MensajeError = "Falta Seleccionar Tipo de Cuenta";
            this.cmb_tipo_cuenta._Nombre_campo = "tipo_cuenta";
            this.cmb_tipo_cuenta._Nombre_tabla = "";
            this.cmb_tipo_cuenta._tabla_cargar_combo = "Tipos_Cuentas";
            this.cmb_tipo_cuenta._tabla_cargar_descriptor = "descripcion";
            this.cmb_tipo_cuenta._tabla_cargar_pk = "id";
            this.cmb_tipo_cuenta._Validable = true;
            this.cmb_tipo_cuenta.FormattingEnabled = true;
            this.cmb_tipo_cuenta.Location = new System.Drawing.Point(195, 16);
            this.cmb_tipo_cuenta.Name = "cmb_tipo_cuenta";
            this.cmb_tipo_cuenta.Size = new System.Drawing.Size(121, 21);
            this.cmb_tipo_cuenta.TabIndex = 1;
            // 
            // rv_cuentas
            // 
            this.rv_cuentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rv_cuentas.Location = new System.Drawing.Point(1, 82);
            this.rv_cuentas.Name = "rv_cuentas";
            this.rv_cuentas.ServerReport.BearerToken = null;
            this.rv_cuentas.Size = new System.Drawing.Size(824, 317);
            this.rv_cuentas.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reportViewer1);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.txt_SaldoMax);
            this.tabPage2.Controls.Add(this.txt_SaldoMin);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(825, 399);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Listado de cuenta entre Saldos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(96)))), ((int)(((byte)(230)))));
            this.button1.Location = new System.Drawing.Point(357, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 29);
            this.button1.TabIndex = 23;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.txt_SaldoMax.Location = new System.Drawing.Point(76, 53);
            this.txt_SaldoMax.Name = "txt_SaldoMax";
            this.txt_SaldoMax.Size = new System.Drawing.Size(254, 29);
            this.txt_SaldoMax.TabIndex = 2;
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
            this.txt_SaldoMin.Location = new System.Drawing.Point(76, 18);
            this.txt_SaldoMin.Name = "txt_SaldoMin";
            this.txt_SaldoMin.Size = new System.Drawing.Size(254, 29);
            this.txt_SaldoMin.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Reporte de Cuentas";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(6, 88);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(813, 305);
            this.reportViewer1.TabIndex = 24;
            // 
            // Frm_ReportesCuentas
            // 
            this._FormularioMovil = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(857, 537);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Frm_ReportesCuentas";
            this.Load += new System.EventHandler(this.Frm_ReportesCuentas_Load);
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
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer rv_cuentas;
        private Clases.ComboBox01 cmb_monedas;
        private Clases.ComboBox01 cmb_tipo_cuenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btn_calcular1;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.Button button1;
        private Clases.LabelText txt_SaldoMax;
        private Clases.LabelText txt_SaldoMin;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}
