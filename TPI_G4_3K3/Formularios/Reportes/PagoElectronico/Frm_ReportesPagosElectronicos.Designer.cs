
namespace BankApp.Formularios.Reportes.Pagos_Electronicos
{
    partial class Frm_ReportesPagosElectronicos
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
            this.btn_buscar01 = new System.Windows.Forms.Button();
            this.PagElec = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_servicios = new BankApp.Clases.ComboBox01();
            this.txt_ano = new BankApp.Clases.LabelText();
            this.txt_mes = new BankApp.Clases.LabelText();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_id_pago = new BankApp.Clases.LabelText();
            this.txt_importe_max = new BankApp.Clases.LabelText();
            this.txt_importe_min = new BankApp.Clases.LabelText();
            this.txt_puntos_max = new BankApp.Clases.LabelText();
            this.txt_puntos_min = new BankApp.Clases.LabelText();
            this.btn_buscar02 = new System.Windows.Forms.Button();
            this.PagElec2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
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
            this.pnl_titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_titulo.Size = new System.Drawing.Size(1073, 35);
            // 
            // btn_restaurar
            // 
            this.btn_restaurar.Location = new System.Drawing.Point(1009, 5);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Location = new System.Drawing.Point(978, 5);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.Location = new System.Drawing.Point(1009, 5);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(1040, 5);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 132);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1049, 541);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_buscar01);
            this.tabPage1.Controls.Add(this.PagElec);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cmb_servicios);
            this.tabPage1.Controls.Add(this.txt_ano);
            this.tabPage1.Controls.Add(this.txt_mes);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1041, 515);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Por Servicio y Fecha";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_buscar01
            // 
            this.btn_buscar01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar01.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar01.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(96)))), ((int)(((byte)(230)))));
            this.btn_buscar01.Location = new System.Drawing.Point(747, 51);
            this.btn_buscar01.Name = "btn_buscar01";
            this.btn_buscar01.Size = new System.Drawing.Size(83, 29);
            this.btn_buscar01.TabIndex = 27;
            this.btn_buscar01.Text = "Calcular";
            this.btn_buscar01.UseVisualStyleBackColor = true;
            this.btn_buscar01.Click += new System.EventHandler(this.btn_buscar01_Click_1);
            // 
            // PagElec
            // 
            this.PagElec.Location = new System.Drawing.Point(6, 91);
            this.PagElec.Name = "PagElec";
            this.PagElec.ServerReport.BearerToken = null;
            this.PagElec.Size = new System.Drawing.Size(1029, 418);
            this.PagElec.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(336, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "Servicio: ";
            // 
            // cmb_servicios
            // 
            this.cmb_servicios._ComboSinSeleccion = true;
            this.cmb_servicios._MensajeError = null;
            this.cmb_servicios._Nombre_campo = null;
            this.cmb_servicios._Nombre_tabla = null;
            this.cmb_servicios._tabla_cargar_combo = "Servicios";
            this.cmb_servicios._tabla_cargar_descriptor = "nombre";
            this.cmb_servicios._tabla_cargar_pk = "id";
            this.cmb_servicios._Validable = false;
            this.cmb_servicios.FormattingEnabled = true;
            this.cmb_servicios.Location = new System.Drawing.Point(421, 29);
            this.cmb_servicios.Name = "cmb_servicios";
            this.cmb_servicios.Size = new System.Drawing.Size(121, 21);
            this.cmb_servicios.TabIndex = 24;
            // 
            // txt_ano
            // 
            this.txt_ano._Ancho = 4;
            this.txt_ano._Decimales = 2;
            this.txt_ano._Etiqueta = "Año";
            this.txt_ano._Mask = "CCCC";
            this.txt_ano._MensajeError = null;
            this.txt_ano._Nombre_Campo = null;
            this.txt_ano._Nombre_Tabla = null;
            this.txt_ano._ReadOnly = false;
            this.txt_ano._Text = "";
            this.txt_ano._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_ano._TipoDato = BankApp.Clases.LabelText.TipoDato.texto;
            this.txt_ano._Validable = false;
            this.txt_ano.Location = new System.Drawing.Point(502, 51);
            this.txt_ano.Name = "txt_ano";
            this.txt_ano.Size = new System.Drawing.Size(211, 29);
            this.txt_ano.TabIndex = 1;
            // 
            // txt_mes
            // 
            this.txt_mes._Ancho = 2;
            this.txt_mes._Decimales = 2;
            this.txt_mes._Etiqueta = "Mes";
            this.txt_mes._Mask = "CC";
            this.txt_mes._MensajeError = null;
            this.txt_mes._Nombre_Campo = null;
            this.txt_mes._Nombre_Tabla = null;
            this.txt_mes._ReadOnly = false;
            this.txt_mes._Text = "";
            this.txt_mes._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_mes._TipoDato = BankApp.Clases.LabelText.TipoDato.texto;
            this.txt_mes._Validable = false;
            this.txt_mes.Location = new System.Drawing.Point(502, 21);
            this.txt_mes.Name = "txt_mes";
            this.txt_mes.Size = new System.Drawing.Size(211, 29);
            this.txt_mes.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt_id_pago);
            this.tabPage2.Controls.Add(this.txt_importe_max);
            this.tabPage2.Controls.Add(this.txt_importe_min);
            this.tabPage2.Controls.Add(this.txt_puntos_max);
            this.tabPage2.Controls.Add(this.txt_puntos_min);
            this.tabPage2.Controls.Add(this.btn_buscar02);
            this.tabPage2.Controls.Add(this.PagElec2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1041, 515);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Por Puntos e Importe";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_id_pago
            // 
            this.txt_id_pago._Ancho = 2;
            this.txt_id_pago._Decimales = 0;
            this.txt_id_pago._Etiqueta = "ID Pago Electronico";
            this.txt_id_pago._Mask = "99";
            this.txt_id_pago._MensajeError = null;
            this.txt_id_pago._Nombre_Campo = null;
            this.txt_id_pago._Nombre_Tabla = null;
            this.txt_id_pago._ReadOnly = false;
            this.txt_id_pago._Text = "";
            this.txt_id_pago._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_id_pago._TipoDato = BankApp.Clases.LabelText.TipoDato.numero;
            this.txt_id_pago._Validable = false;
            this.txt_id_pago.Location = new System.Drawing.Point(55, 58);
            this.txt_id_pago.Name = "txt_id_pago";
            this.txt_id_pago.Size = new System.Drawing.Size(200, 29);
            this.txt_id_pago.TabIndex = 33;
            this.txt_id_pago.Visible = false;
            // 
            // txt_importe_max
            // 
            this.txt_importe_max._Ancho = 8;
            this.txt_importe_max._Decimales = 0;
            this.txt_importe_max._Etiqueta = "Importe Max.";
            this.txt_importe_max._Mask = "99999999";
            this.txt_importe_max._MensajeError = null;
            this.txt_importe_max._Nombre_Campo = null;
            this.txt_importe_max._Nombre_Tabla = null;
            this.txt_importe_max._ReadOnly = false;
            this.txt_importe_max._Text = "";
            this.txt_importe_max._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_importe_max._TipoDato = BankApp.Clases.LabelText.TipoDato.numero;
            this.txt_importe_max._Validable = false;
            this.txt_importe_max.Location = new System.Drawing.Point(231, 62);
            this.txt_importe_max.Name = "txt_importe_max";
            this.txt_importe_max.Size = new System.Drawing.Size(239, 29);
            this.txt_importe_max.TabIndex = 32;
            // 
            // txt_importe_min
            // 
            this.txt_importe_min._Ancho = 8;
            this.txt_importe_min._Decimales = 0;
            this.txt_importe_min._Etiqueta = "Importe Min.";
            this.txt_importe_min._Mask = "99999999";
            this.txt_importe_min._MensajeError = null;
            this.txt_importe_min._Nombre_Campo = null;
            this.txt_importe_min._Nombre_Tabla = null;
            this.txt_importe_min._ReadOnly = false;
            this.txt_importe_min._Text = "";
            this.txt_importe_min._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_importe_min._TipoDato = BankApp.Clases.LabelText.TipoDato.numero;
            this.txt_importe_min._Validable = false;
            this.txt_importe_min.Location = new System.Drawing.Point(231, 27);
            this.txt_importe_min.Name = "txt_importe_min";
            this.txt_importe_min.Size = new System.Drawing.Size(239, 29);
            this.txt_importe_min.TabIndex = 31;
            // 
            // txt_puntos_max
            // 
            this.txt_puntos_max._Ancho = 8;
            this.txt_puntos_max._Decimales = 0;
            this.txt_puntos_max._Etiqueta = "Puntos Max.";
            this.txt_puntos_max._Mask = "99999999";
            this.txt_puntos_max._MensajeError = null;
            this.txt_puntos_max._Nombre_Campo = null;
            this.txt_puntos_max._Nombre_Tabla = null;
            this.txt_puntos_max._ReadOnly = false;
            this.txt_puntos_max._Text = "";
            this.txt_puntos_max._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_puntos_max._TipoDato = BankApp.Clases.LabelText.TipoDato.numero;
            this.txt_puntos_max._Validable = false;
            this.txt_puntos_max.Location = new System.Drawing.Point(446, 62);
            this.txt_puntos_max.Name = "txt_puntos_max";
            this.txt_puntos_max.Size = new System.Drawing.Size(239, 29);
            this.txt_puntos_max.TabIndex = 30;
            // 
            // txt_puntos_min
            // 
            this.txt_puntos_min._Ancho = 8;
            this.txt_puntos_min._Decimales = 0;
            this.txt_puntos_min._Etiqueta = "Puntos Min.";
            this.txt_puntos_min._Mask = "99999999";
            this.txt_puntos_min._MensajeError = null;
            this.txt_puntos_min._Nombre_Campo = null;
            this.txt_puntos_min._Nombre_Tabla = null;
            this.txt_puntos_min._ReadOnly = false;
            this.txt_puntos_min._Text = "";
            this.txt_puntos_min._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_puntos_min._TipoDato = BankApp.Clases.LabelText.TipoDato.numero;
            this.txt_puntos_min._Validable = false;
            this.txt_puntos_min.Location = new System.Drawing.Point(446, 27);
            this.txt_puntos_min.Name = "txt_puntos_min";
            this.txt_puntos_min.Size = new System.Drawing.Size(239, 29);
            this.txt_puntos_min.TabIndex = 29;
            // 
            // btn_buscar02
            // 
            this.btn_buscar02.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar02.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar02.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(96)))), ((int)(((byte)(230)))));
            this.btn_buscar02.Location = new System.Drawing.Point(726, 58);
            this.btn_buscar02.Name = "btn_buscar02";
            this.btn_buscar02.Size = new System.Drawing.Size(83, 29);
            this.btn_buscar02.TabIndex = 28;
            this.btn_buscar02.Text = "Calcular";
            this.btn_buscar02.UseVisualStyleBackColor = true;
            this.btn_buscar02.Click += new System.EventHandler(this.btn_buscar02_Click);
            // 
            // PagElec2
            // 
            this.PagElec2.Location = new System.Drawing.Point(6, 107);
            this.PagElec2.Name = "PagElec2";
            this.PagElec2.ServerReport.BearerToken = null;
            this.PagElec2.Size = new System.Drawing.Size(1029, 405);
            this.PagElec2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Reporte sobre Pagos Electronicos";
            // 
            // Frm_ReportesPagosElectronicos
            // 
            this._FormularioMovil = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1073, 685);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Frm_ReportesPagosElectronicos";
            this.Load += new System.EventHandler(this.Frm_ReportesPagosElectronicos_Load);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
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

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Clases.LabelText txt_ano;
        private Clases.LabelText txt_mes;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Clases.ComboBox01 cmb_servicios;
        private Microsoft.Reporting.WinForms.ReportViewer PagElec;
        private Microsoft.Reporting.WinForms.ReportViewer PagElec2;
        public System.Windows.Forms.Button btn_buscar01;
        public System.Windows.Forms.Button btn_buscar02;
        private Clases.LabelText txt_puntos_min;
        private Clases.LabelText txt_importe_max;
        private Clases.LabelText txt_importe_min;
        private Clases.LabelText txt_puntos_max;
        private Clases.LabelText txt_id_pago;
    }
}
