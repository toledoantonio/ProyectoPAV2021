
namespace BankApp.Formularios.GraficosEstadisticos.Canjes
{
    partial class Frm_EstadisticasCanjes
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
            this.chk_puntos_totales = new System.Windows.Forms.CheckBox();
            this.rv01 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_buscar01 = new System.Windows.Forms.Button();
            this.txt_mes_hasta = new BankApp.Clases.LabelText();
            this.txt_anno = new BankApp.Clases.LabelText();
            this.txt_mes_desde = new BankApp.Clases.LabelText();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rv02 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_buscar02 = new System.Windows.Forms.Button();
            this.txt_anno2 = new BankApp.Clases.LabelText();
            this.txt_mes2 = new BankApp.Clases.LabelText();
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
            this.pnl_titulo.Size = new System.Drawing.Size(930, 35);
            // 
            // btn_restaurar
            // 
            this.btn_restaurar.Location = new System.Drawing.Point(2214, 5);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Location = new System.Drawing.Point(1540, 3);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.Location = new System.Drawing.Point(2214, 5);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(897, 3);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(506, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Graficos Estadisticos sobre Canjes de Premios";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 112);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(910, 569);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chk_puntos_totales);
            this.tabPage1.Controls.Add(this.rv01);
            this.tabPage1.Controls.Add(this.btn_buscar01);
            this.tabPage1.Controls.Add(this.txt_mes_hasta);
            this.tabPage1.Controls.Add(this.txt_anno);
            this.tabPage1.Controls.Add(this.txt_mes_desde);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(902, 543);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Estadísticas sobre Valores Mensuales de Canjes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chk_puntos_totales
            // 
            this.chk_puntos_totales.AutoSize = true;
            this.chk_puntos_totales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_puntos_totales.Location = new System.Drawing.Point(487, 52);
            this.chk_puntos_totales.Name = "chk_puntos_totales";
            this.chk_puntos_totales.Size = new System.Drawing.Size(74, 20);
            this.chk_puntos_totales.TabIndex = 33;
            this.chk_puntos_totales.Text = "Puntos";
            this.chk_puntos_totales.UseVisualStyleBackColor = true;
            // 
            // rv01
            // 
            this.rv01.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rv01.Location = new System.Drawing.Point(6, 88);
            this.rv01.Name = "rv01";
            this.rv01.ServerReport.BearerToken = null;
            this.rv01.Size = new System.Drawing.Size(890, 449);
            this.rv01.TabIndex = 32;
            // 
            // btn_buscar01
            // 
            this.btn_buscar01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar01.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar01.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(96)))), ((int)(((byte)(230)))));
            this.btn_buscar01.Location = new System.Drawing.Point(567, 46);
            this.btn_buscar01.Name = "btn_buscar01";
            this.btn_buscar01.Size = new System.Drawing.Size(83, 29);
            this.btn_buscar01.TabIndex = 31;
            this.btn_buscar01.Text = "Buscar";
            this.btn_buscar01.UseVisualStyleBackColor = true;
            this.btn_buscar01.Click += new System.EventHandler(this.btn_buscar01_Click);
            // 
            // txt_mes_hasta
            // 
            this.txt_mes_hasta._Ancho = 2;
            this.txt_mes_hasta._Decimales = 0;
            this.txt_mes_hasta._Etiqueta = "Mes Hasta";
            this.txt_mes_hasta._Mask = "99";
            this.txt_mes_hasta._MensajeError = null;
            this.txt_mes_hasta._Nombre_Campo = null;
            this.txt_mes_hasta._Nombre_Tabla = null;
            this.txt_mes_hasta._ReadOnly = false;
            this.txt_mes_hasta._Text = "";
            this.txt_mes_hasta._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_mes_hasta._TipoDato = BankApp.Clases.LabelText.TipoDato.numero;
            this.txt_mes_hasta._Validable = false;
            this.txt_mes_hasta.Location = new System.Drawing.Point(280, 44);
            this.txt_mes_hasta.Name = "txt_mes_hasta";
            this.txt_mes_hasta.Size = new System.Drawing.Size(199, 29);
            this.txt_mes_hasta.TabIndex = 2;
            // 
            // txt_anno
            // 
            this.txt_anno._Ancho = 4;
            this.txt_anno._Decimales = 0;
            this.txt_anno._Etiqueta = "Año";
            this.txt_anno._Mask = "9999";
            this.txt_anno._MensajeError = null;
            this.txt_anno._Nombre_Campo = null;
            this.txt_anno._Nombre_Tabla = null;
            this.txt_anno._ReadOnly = false;
            this.txt_anno._Text = "";
            this.txt_anno._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_anno._TipoDato = BankApp.Clases.LabelText.TipoDato.numero;
            this.txt_anno._Validable = false;
            this.txt_anno.Location = new System.Drawing.Point(127, 9);
            this.txt_anno.Name = "txt_anno";
            this.txt_anno.Size = new System.Drawing.Size(215, 29);
            this.txt_anno.TabIndex = 0;
            // 
            // txt_mes_desde
            // 
            this.txt_mes_desde._Ancho = 2;
            this.txt_mes_desde._Decimales = 0;
            this.txt_mes_desde._Etiqueta = "Mes Desde";
            this.txt_mes_desde._Mask = "99";
            this.txt_mes_desde._MensajeError = null;
            this.txt_mes_desde._Nombre_Campo = null;
            this.txt_mes_desde._Nombre_Tabla = null;
            this.txt_mes_desde._ReadOnly = false;
            this.txt_mes_desde._Text = "";
            this.txt_mes_desde._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_mes_desde._TipoDato = BankApp.Clases.LabelText.TipoDato.numero;
            this.txt_mes_desde._Validable = false;
            this.txt_mes_desde.Location = new System.Drawing.Point(280, 9);
            this.txt_mes_desde.Name = "txt_mes_desde";
            this.txt_mes_desde.Size = new System.Drawing.Size(199, 29);
            this.txt_mes_desde.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rv02);
            this.tabPage2.Controls.Add(this.btn_buscar02);
            this.tabPage2.Controls.Add(this.txt_anno2);
            this.tabPage2.Controls.Add(this.txt_mes2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(902, 543);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Comparación Sobre Categoria de Premios";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rv02
            // 
            this.rv02.Location = new System.Drawing.Point(6, 77);
            this.rv02.Name = "rv02";
            this.rv02.ServerReport.BearerToken = null;
            this.rv02.Size = new System.Drawing.Size(890, 460);
            this.rv02.TabIndex = 40;
            // 
            // btn_buscar02
            // 
            this.btn_buscar02.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar02.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar02.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(96)))), ((int)(((byte)(230)))));
            this.btn_buscar02.Location = new System.Drawing.Point(419, 42);
            this.btn_buscar02.Name = "btn_buscar02";
            this.btn_buscar02.Size = new System.Drawing.Size(83, 29);
            this.btn_buscar02.TabIndex = 39;
            this.btn_buscar02.Text = "Buscar";
            this.btn_buscar02.UseVisualStyleBackColor = true;
            this.btn_buscar02.Click += new System.EventHandler(this.btn_buscar02_Click);
            // 
            // txt_anno2
            // 
            this.txt_anno2._Ancho = 4;
            this.txt_anno2._Decimales = 2;
            this.txt_anno2._Etiqueta = "Año";
            this.txt_anno2._Mask = "CCCC";
            this.txt_anno2._MensajeError = null;
            this.txt_anno2._Nombre_Campo = null;
            this.txt_anno2._Nombre_Tabla = null;
            this.txt_anno2._ReadOnly = false;
            this.txt_anno2._Text = "";
            this.txt_anno2._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_anno2._TipoDato = BankApp.Clases.LabelText.TipoDato.texto;
            this.txt_anno2._Validable = false;
            this.txt_anno2.Location = new System.Drawing.Point(183, 9);
            this.txt_anno2.Name = "txt_anno2";
            this.txt_anno2.Size = new System.Drawing.Size(209, 29);
            this.txt_anno2.TabIndex = 38;
            // 
            // txt_mes2
            // 
            this.txt_mes2._Ancho = 2;
            this.txt_mes2._Decimales = 2;
            this.txt_mes2._Etiqueta = "Mes";
            this.txt_mes2._Mask = "CC";
            this.txt_mes2._MensajeError = null;
            this.txt_mes2._Nombre_Campo = null;
            this.txt_mes2._Nombre_Tabla = null;
            this.txt_mes2._ReadOnly = false;
            this.txt_mes2._Text = "";
            this.txt_mes2._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_mes2._TipoDato = BankApp.Clases.LabelText.TipoDato.texto;
            this.txt_mes2._Validable = false;
            this.txt_mes2.Location = new System.Drawing.Point(196, 42);
            this.txt_mes2.Name = "txt_mes2";
            this.txt_mes2.Size = new System.Drawing.Size(196, 29);
            this.txt_mes2.TabIndex = 37;
            // 
            // Frm_EstadisticasCanjes
            // 
            this._FormularioMovil = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(930, 693);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "Frm_EstadisticasCanjes";
            this.Load += new System.EventHandler(this.Frm_EstadisticasCanjes_Load);
            this.Controls.SetChildIndex(this.pnl_titulo, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.tabControl1, 0);
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
        private Clases.LabelText txt_mes_desde;
        private Clases.LabelText txt_anno;
        private Clases.LabelText txt_mes_hasta;
        private Microsoft.Reporting.WinForms.ReportViewer rv01;
        public System.Windows.Forms.Button btn_buscar01;
        private System.Windows.Forms.CheckBox chk_puntos_totales;
        private Microsoft.Reporting.WinForms.ReportViewer rv02;
        public System.Windows.Forms.Button btn_buscar02;
        private Clases.LabelText txt_anno2;
        private Clases.LabelText txt_mes2;
    }
}
