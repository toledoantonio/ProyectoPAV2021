
namespace BankApp.Formularios.Reportes.Telefonos
{
    partial class Frm_ReportesUsuarios
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
            this.txt_nombre = new BankApp.Clases.LabelText();
            this.cmb_tipo_doc = new BankApp.Clases.ComboBox01();
            this.btn_calcular1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rv_usuarios = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_titulo
            // 
            this.pnl_titulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_titulo.Size = new System.Drawing.Size(887, 35);
            // 
            // btn_restaurar
            // 
            this.btn_restaurar.Location = new System.Drawing.Point(823, 5);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Location = new System.Drawing.Point(792, 5);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.Location = new System.Drawing.Point(823, 5);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(854, 5);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(17, 98);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(857, 499);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_nombre);
            this.tabPage1.Controls.Add(this.cmb_tipo_doc);
            this.tabPage1.Controls.Add(this.btn_calcular1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.rv_usuarios);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(849, 473);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado de Usuarios por Nombre y Tipo de Documento";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txt_nombre
            // 
            this.txt_nombre._Ancho = 15;
            this.txt_nombre._Decimales = 0;
            this.txt_nombre._Etiqueta = "Nombre";
            this.txt_nombre._Mask = "CCCCCCCCCCCCCCC";
            this.txt_nombre._MensajeError = null;
            this.txt_nombre._Nombre_Campo = null;
            this.txt_nombre._Nombre_Tabla = null;
            this.txt_nombre._ReadOnly = false;
            this.txt_nombre._Text = "";
            this.txt_nombre._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_nombre._TipoDato = BankApp.Clases.LabelText.TipoDato.texto;
            this.txt_nombre._Validable = false;
            this.txt_nombre.Location = new System.Drawing.Point(156, 8);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(285, 29);
            this.txt_nombre.TabIndex = 25;
            // 
            // cmb_tipo_doc
            // 
            this.cmb_tipo_doc._ComboSinSeleccion = false;
            this.cmb_tipo_doc._MensajeError = "Falta seleccionar el tipo de documento.";
            this.cmb_tipo_doc._Nombre_campo = null;
            this.cmb_tipo_doc._Nombre_tabla = null;
            this.cmb_tipo_doc._tabla_cargar_combo = "Tipos_Documentos";
            this.cmb_tipo_doc._tabla_cargar_descriptor = "descripcion";
            this.cmb_tipo_doc._tabla_cargar_pk = "id";
            this.cmb_tipo_doc._Validable = true;
            this.cmb_tipo_doc.FormattingEnabled = true;
            this.cmb_tipo_doc.Location = new System.Drawing.Point(320, 43);
            this.cmb_tipo_doc.Name = "cmb_tipo_doc";
            this.cmb_tipo_doc.Size = new System.Drawing.Size(121, 21);
            this.cmb_tipo_doc.TabIndex = 24;
            // 
            // btn_calcular1
            // 
            this.btn_calcular1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calcular1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcular1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(96)))), ((int)(((byte)(230)))));
            this.btn_calcular1.Location = new System.Drawing.Point(472, 38);
            this.btn_calcular1.Name = "btn_calcular1";
            this.btn_calcular1.Size = new System.Drawing.Size(81, 27);
            this.btn_calcular1.TabIndex = 23;
            this.btn_calcular1.Text = "Calcular";
            this.btn_calcular1.UseVisualStyleBackColor = true;
            this.btn_calcular1.Click += new System.EventHandler(this.btn_calcular1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(182, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tipo de Documento";
            // 
            // rv_usuarios
            // 
            this.rv_usuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rv_usuarios.Location = new System.Drawing.Point(6, 88);
            this.rv_usuarios.Name = "rv_usuarios";
            this.rv_usuarios.ServerReport.BearerToken = null;
            this.rv_usuarios.Size = new System.Drawing.Size(837, 379);
            this.rv_usuarios.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "Reportes de Usuarios";
            // 
            // Frm_ReportesUsuarios
            // 
            this._FormularioMovil = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(886, 609);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Frm_ReportesUsuarios";
            this.Load += new System.EventHandler(this.Frm_ReportesTelefonos_Load);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer rv_usuarios;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btn_calcular1;
        private Clases.ComboBox01 cmb_tipo_doc;
        private Clases.LabelText txt_nombre;
    }
}
