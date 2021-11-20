
namespace BankApp.Formularios.Reportes.Canjes
{
    partial class Frm_ReportesCanjes
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
            this.txt_id_usuario = new BankApp.Clases.LabelText();
            this.rv_canjes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.txt_fecha_hasta = new BankApp.Clases.LabelText();
            this.txt_fecha_desde = new BankApp.Clases.LabelText();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_tipo_premio = new BankApp.Clases.ComboBox01();
            this.btn_calcular2 = new System.Windows.Forms.Button();
            this.rv_premios = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txt_puntos_max = new BankApp.Clases.LabelText();
            this.txt_id_tipo = new BankApp.Clases.LabelText();
            this.txt_puntos_min = new BankApp.Clases.LabelText();
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
            this.pnl_titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.pnl_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_titulo.Size = new System.Drawing.Size(951, 35);
            // 
            // btn_restaurar
            // 
            this.btn_restaurar.Location = new System.Drawing.Point(3751, 5);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_minimizar.Location = new System.Drawing.Point(889, 5);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.Location = new System.Drawing.Point(3751, 5);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(920, 5);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 114);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(927, 544);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_id_usuario);
            this.tabPage1.Controls.Add(this.rv_canjes);
            this.tabPage1.Controls.Add(this.btn_calcular);
            this.tabPage1.Controls.Add(this.txt_fecha_hasta);
            this.tabPage1.Controls.Add(this.txt_fecha_desde);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(919, 518);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado Canjes de Premios";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txt_id_usuario
            // 
            this.txt_id_usuario._Ancho = 2;
            this.txt_id_usuario._Decimales = 0;
            this.txt_id_usuario._Etiqueta = "Id Usuario";
            this.txt_id_usuario._Mask = "99";
            this.txt_id_usuario._MensajeError = null;
            this.txt_id_usuario._Nombre_Campo = null;
            this.txt_id_usuario._Nombre_Tabla = null;
            this.txt_id_usuario._ReadOnly = false;
            this.txt_id_usuario._Text = "";
            this.txt_id_usuario._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_id_usuario._TipoDato = BankApp.Clases.LabelText.TipoDato.numero;
            this.txt_id_usuario._Validable = false;
            this.txt_id_usuario.Location = new System.Drawing.Point(153, 23);
            this.txt_id_usuario.Name = "txt_id_usuario";
            this.txt_id_usuario.Size = new System.Drawing.Size(198, 29);
            this.txt_id_usuario.TabIndex = 22;
            // 
            // rv_canjes
            // 
            this.rv_canjes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rv_canjes.Location = new System.Drawing.Point(6, 93);
            this.rv_canjes.Name = "rv_canjes";
            this.rv_canjes.ServerReport.BearerToken = null;
            this.rv_canjes.Size = new System.Drawing.Size(907, 419);
            this.rv_canjes.TabIndex = 21;
            // 
            // btn_calcular
            // 
            this.btn_calcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(96)))), ((int)(((byte)(230)))));
            this.btn_calcular.Location = new System.Drawing.Point(548, 58);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(83, 29);
            this.btn_calcular.TabIndex = 20;
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
            this.txt_fecha_hasta.Location = new System.Drawing.Point(297, 58);
            this.txt_fecha_hasta.Name = "txt_fecha_hasta";
            this.txt_fecha_hasta.Size = new System.Drawing.Size(245, 29);
            this.txt_fecha_hasta.TabIndex = 1;
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
            this.txt_fecha_desde.Location = new System.Drawing.Point(297, 23);
            this.txt_fecha_desde.Name = "txt_fecha_desde";
            this.txt_fecha_desde.Size = new System.Drawing.Size(245, 29);
            this.txt_fecha_desde.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.cmb_tipo_premio);
            this.tabPage2.Controls.Add(this.btn_calcular2);
            this.tabPage2.Controls.Add(this.rv_premios);
            this.tabPage2.Controls.Add(this.txt_puntos_max);
            this.tabPage2.Controls.Add(this.txt_id_tipo);
            this.tabPage2.Controls.Add(this.txt_puntos_min);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(919, 518);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Listado de Premios";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(179, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "Tipo de Premio";
            // 
            // cmb_tipo_premio
            // 
            this.cmb_tipo_premio._ComboSinSeleccion = true;
            this.cmb_tipo_premio._MensajeError = null;
            this.cmb_tipo_premio._Nombre_campo = null;
            this.cmb_tipo_premio._Nombre_tabla = null;
            this.cmb_tipo_premio._tabla_cargar_combo = "Tipo_Premio";
            this.cmb_tipo_premio._tabla_cargar_descriptor = "nombre";
            this.cmb_tipo_premio._tabla_cargar_pk = "id";
            this.cmb_tipo_premio._Validable = false;
            this.cmb_tipo_premio.FormattingEnabled = true;
            this.cmb_tipo_premio.Location = new System.Drawing.Point(294, 35);
            this.cmb_tipo_premio.Name = "cmb_tipo_premio";
            this.cmb_tipo_premio.Size = new System.Drawing.Size(121, 21);
            this.cmb_tipo_premio.TabIndex = 22;
            // 
            // btn_calcular2
            // 
            this.btn_calcular2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calcular2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcular2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(96)))), ((int)(((byte)(230)))));
            this.btn_calcular2.Location = new System.Drawing.Point(598, 62);
            this.btn_calcular2.Name = "btn_calcular2";
            this.btn_calcular2.Size = new System.Drawing.Size(83, 29);
            this.btn_calcular2.TabIndex = 21;
            this.btn_calcular2.Text = "Calcular";
            this.btn_calcular2.UseVisualStyleBackColor = true;
            this.btn_calcular2.Click += new System.EventHandler(this.btn_calcular2_Click);
            // 
            // rv_premios
            // 
            this.rv_premios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rv_premios.Location = new System.Drawing.Point(6, 97);
            this.rv_premios.Name = "rv_premios";
            this.rv_premios.ServerReport.BearerToken = null;
            this.rv_premios.Size = new System.Drawing.Size(907, 415);
            this.rv_premios.TabIndex = 3;
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
            this.txt_puntos_max.Location = new System.Drawing.Point(353, 62);
            this.txt_puntos_max.Name = "txt_puntos_max";
            this.txt_puntos_max.Size = new System.Drawing.Size(239, 29);
            this.txt_puntos_max.TabIndex = 2;
            // 
            // txt_id_tipo
            // 
            this.txt_id_tipo._Ancho = 2;
            this.txt_id_tipo._Decimales = 0;
            this.txt_id_tipo._Etiqueta = "Id Tipo de Premio";
            this.txt_id_tipo._Mask = "99";
            this.txt_id_tipo._MensajeError = null;
            this.txt_id_tipo._Nombre_Campo = null;
            this.txt_id_tipo._Nombre_Tabla = null;
            this.txt_id_tipo._ReadOnly = false;
            this.txt_id_tipo._Text = "";
            this.txt_id_tipo._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_id_tipo._TipoDato = BankApp.Clases.LabelText.TipoDato.numero;
            this.txt_id_tipo._Validable = false;
            this.txt_id_tipo.Location = new System.Drawing.Point(713, 6);
            this.txt_id_tipo.Name = "txt_id_tipo";
            this.txt_id_tipo.Size = new System.Drawing.Size(200, 29);
            this.txt_id_tipo.TabIndex = 0;
            this.txt_id_tipo.Visible = false;
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
            this.txt_puntos_min.Location = new System.Drawing.Point(353, 27);
            this.txt_puntos_min.Name = "txt_puntos_min";
            this.txt_puntos_min.Size = new System.Drawing.Size(239, 29);
            this.txt_puntos_min.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Reporte sobre Canje de Premios";
            // 
            // Frm_ReportesCanjes
            // 
            this._FormularioMovil = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(951, 670);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Frm_ReportesCanjes";
            this.Load += new System.EventHandler(this.Frm_ReportesCanjes_Load);
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
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private Clases.LabelText txt_fecha_hasta;
        private Clases.LabelText txt_fecha_desde;
        private Microsoft.Reporting.WinForms.ReportViewer rv_canjes;
        public System.Windows.Forms.Button btn_calcular;
        private Clases.LabelText txt_id_usuario;
        private Microsoft.Reporting.WinForms.ReportViewer rv_premios;
        private Clases.LabelText txt_puntos_max;
        private Clases.LabelText txt_id_tipo;
        private Clases.LabelText txt_puntos_min;
        public System.Windows.Forms.Button btn_calcular2;
        private System.Windows.Forms.Label label2;
        private Clases.ComboBox01 cmb_tipo_premio;
    }
}
