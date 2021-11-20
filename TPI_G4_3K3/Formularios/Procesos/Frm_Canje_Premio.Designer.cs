
namespace BankApp.Formularios.Procesos
{
    partial class Frm_Canje_Premio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Canje_Premio));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_cargar_cuenta = new System.Windows.Forms.Button();
            this.txt_puntos_total = new BankApp.Clases.LabelText();
            this.txt_numero_cuenta = new BankApp.Clases.LabelText();
            this.label2 = new System.Windows.Forms.Label();
            this.grid_premio = new BankApp.Clases.Grid01();
            this.lbl_fecha = new BankApp.Clases.LabelText();
            this.btn_fechasistema = new System.Windows.Forms.Button();
            this.btn_seleccionar = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.PictureBox();
            this.btn_grabar = new System.Windows.Forms.PictureBox();
            this.btn_ver = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grid_canje = new BankApp.Clases.Grid01();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_puntos_restantes = new BankApp.Clases.LabelText();
            this.pnl_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_premio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_actualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_grabar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_canje)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_titulo
            // 
            this.pnl_titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.pnl_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_titulo.Size = new System.Drawing.Size(839, 35);
            // 
            // btn_restaurar
            // 
            this.btn_restaurar.Location = new System.Drawing.Point(5203, 5);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_minimizar.Location = new System.Drawing.Point(778, 5);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.Location = new System.Drawing.Point(5203, 5);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(809, 5);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 34);
            this.label1.TabIndex = 23;
            this.label1.Text = "Canje de Premios";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btn_cargar_cuenta);
            this.groupBox1.Controls.Add(this.txt_puntos_total);
            this.groupBox1.Controls.Add(this.txt_numero_cuenta);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(58, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 119);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // btn_cargar_cuenta
            // 
            this.btn_cargar_cuenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cargar_cuenta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_cargar_cuenta.Location = new System.Drawing.Point(244, 91);
            this.btn_cargar_cuenta.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cargar_cuenta.Name = "btn_cargar_cuenta";
            this.btn_cargar_cuenta.Size = new System.Drawing.Size(27, 23);
            this.btn_cargar_cuenta.TabIndex = 39;
            this.btn_cargar_cuenta.UseVisualStyleBackColor = false;
            this.btn_cargar_cuenta.Click += new System.EventHandler(this.btn_cargar_cuenta_Click);
            // 
            // txt_puntos_total
            // 
            this.txt_puntos_total._Ancho = 10;
            this.txt_puntos_total._Decimales = 2;
            this.txt_puntos_total._Etiqueta = "Puntos Totales";
            this.txt_puntos_total._Mask = "CCCCCCCCCC";
            this.txt_puntos_total._MensajeError = null;
            this.txt_puntos_total._Nombre_Campo = "puntos_total";
            this.txt_puntos_total._Nombre_Tabla = "Cuentas";
            this.txt_puntos_total._ReadOnly = true;
            this.txt_puntos_total._Text = "";
            this.txt_puntos_total._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_puntos_total._TipoDato = BankApp.Clases.LabelText.TipoDato.texto;
            this.txt_puntos_total._Validable = false;
            this.txt_puntos_total.Location = new System.Drawing.Point(27, 54);
            this.txt_puntos_total.Name = "txt_puntos_total";
            this.txt_puntos_total.Size = new System.Drawing.Size(254, 29);
            this.txt_puntos_total.TabIndex = 1;
            // 
            // txt_numero_cuenta
            // 
            this.txt_numero_cuenta._Ancho = 10;
            this.txt_numero_cuenta._Decimales = 0;
            this.txt_numero_cuenta._Etiqueta = "Numero de Cuenta";
            this.txt_numero_cuenta._Mask = "9999999999";
            this.txt_numero_cuenta._MensajeError = null;
            this.txt_numero_cuenta._Nombre_Campo = "numero";
            this.txt_numero_cuenta._Nombre_Tabla = "Cuentas";
            this.txt_numero_cuenta._ReadOnly = false;
            this.txt_numero_cuenta._Text = "";
            this.txt_numero_cuenta._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_numero_cuenta._TipoDato = BankApp.Clases.LabelText.TipoDato.numero;
            this.txt_numero_cuenta._Validable = false;
            this.txt_numero_cuenta.Location = new System.Drawing.Point(27, 19);
            this.txt_numero_cuenta.Name = "txt_numero_cuenta";
            this.txt_numero_cuenta.Size = new System.Drawing.Size(254, 29);
            this.txt_numero_cuenta.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(351, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Seleccione Algún Premio:";
            // 
            // grid_premio
            // 
            this.grid_premio.AllowUserToAddRows = false;
            this.grid_premio.AllowUserToDeleteRows = false;
            this.grid_premio.BackgroundColor = System.Drawing.Color.White;
            this.grid_premio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_premio.Location = new System.Drawing.Point(355, 139);
            this.grid_premio.Name = "grid_premio";
            this.grid_premio.ReadOnly = true;
            this.grid_premio.Size = new System.Drawing.Size(472, 202);
            this.grid_premio.TabIndex = 26;
            // 
            // lbl_fecha
            // 
            this.lbl_fecha._Ancho = 10;
            this.lbl_fecha._Decimales = 2;
            this.lbl_fecha._Etiqueta = "Fecha";
            this.lbl_fecha._Mask = "00/00/0000";
            this.lbl_fecha._MensajeError = null;
            this.lbl_fecha._Nombre_Campo = null;
            this.lbl_fecha._Nombre_Tabla = null;
            this.lbl_fecha._ReadOnly = false;
            this.lbl_fecha._Text = "  /  /";
            this.lbl_fecha._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.lbl_fecha._TipoDato = BankApp.Clases.LabelText.TipoDato.fecha;
            this.lbl_fecha._Validable = false;
            this.lbl_fecha.Location = new System.Drawing.Point(561, 37);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(245, 29);
            this.lbl_fecha.TabIndex = 27;
            // 
            // btn_fechasistema
            // 
            this.btn_fechasistema.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_fechasistema.Location = new System.Drawing.Point(800, 40);
            this.btn_fechasistema.Margin = new System.Windows.Forms.Padding(2);
            this.btn_fechasistema.Name = "btn_fechasistema";
            this.btn_fechasistema.Size = new System.Drawing.Size(27, 23);
            this.btn_fechasistema.TabIndex = 39;
            this.btn_fechasistema.UseVisualStyleBackColor = false;
            this.btn_fechasistema.Click += new System.EventHandler(this.btn_fechasistema_Click);
            // 
            // btn_seleccionar
            // 
            this.btn_seleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_seleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_seleccionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(96)))), ((int)(((byte)(230)))));
            this.btn_seleccionar.Location = new System.Drawing.Point(561, 347);
            this.btn_seleccionar.Name = "btn_seleccionar";
            this.btn_seleccionar.Size = new System.Drawing.Size(266, 35);
            this.btn_seleccionar.TabIndex = 40;
            this.btn_seleccionar.Text = "Seleccionar Premio";
            this.btn_seleccionar.UseVisualStyleBackColor = true;
            this.btn_seleccionar.Click += new System.EventHandler(this.btn_seleccionar_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_actualizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_actualizar.Image")));
            this.btn_actualizar.Location = new System.Drawing.Point(772, 405);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(55, 55);
            this.btn_actualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_actualizar.TabIndex = 42;
            this.btn_actualizar.TabStop = false;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_grabar
            // 
            this.btn_grabar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_grabar.Image = ((System.Drawing.Image)(resources.GetObject("btn_grabar.Image")));
            this.btn_grabar.Location = new System.Drawing.Point(694, 405);
            this.btn_grabar.Name = "btn_grabar";
            this.btn_grabar.Size = new System.Drawing.Size(55, 55);
            this.btn_grabar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_grabar.TabIndex = 41;
            this.btn_grabar.TabStop = false;
            this.btn_grabar.Visible = false;
            this.btn_grabar.Click += new System.EventHandler(this.btn_grabar_Click);
            // 
            // btn_ver
            // 
            this.btn_ver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ver.Image = ((System.Drawing.Image)(resources.GetObject("btn_ver.Image")));
            this.btn_ver.Location = new System.Drawing.Point(155, 450);
            this.btn_ver.Name = "btn_ver";
            this.btn_ver.Size = new System.Drawing.Size(37, 42);
            this.btn_ver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_ver.TabIndex = 45;
            this.btn_ver.TabStop = false;
            this.btn_ver.Click += new System.EventHandler(this.btn_ver_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(208, 469);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(359, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "Presione el Boton para Visualizar Datos del Canje";
            // 
            // grid_canje
            // 
            this.grid_canje.AllowUserToAddRows = false;
            this.grid_canje.AllowUserToDeleteRows = false;
            this.grid_canje.BackgroundColor = System.Drawing.Color.White;
            this.grid_canje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_canje.Location = new System.Drawing.Point(137, 498);
            this.grid_canje.Name = "grid_canje";
            this.grid_canje.ReadOnly = true;
            this.grid_canje.Size = new System.Drawing.Size(563, 86);
            this.grid_canje.TabIndex = 43;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_puntos_restantes);
            this.groupBox2.Location = new System.Drawing.Point(58, 264);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 77);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            // 
            // txt_puntos_restantes
            // 
            this.txt_puntos_restantes._Ancho = 10;
            this.txt_puntos_restantes._Decimales = 2;
            this.txt_puntos_restantes._Etiqueta = "Puntos Restantes";
            this.txt_puntos_restantes._Mask = "CCCCCCCCCC";
            this.txt_puntos_restantes._MensajeError = null;
            this.txt_puntos_restantes._Nombre_Campo = "puntos_total";
            this.txt_puntos_restantes._Nombre_Tabla = "Cuentas";
            this.txt_puntos_restantes._ReadOnly = true;
            this.txt_puntos_restantes._Text = "";
            this.txt_puntos_restantes._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_puntos_restantes._TipoDato = BankApp.Clases.LabelText.TipoDato.texto;
            this.txt_puntos_restantes._Validable = false;
            this.txt_puntos_restantes.Location = new System.Drawing.Point(27, 28);
            this.txt_puntos_restantes.Name = "txt_puntos_restantes";
            this.txt_puntos_restantes.Size = new System.Drawing.Size(254, 29);
            this.txt_puntos_restantes.TabIndex = 40;
            // 
            // Frm_Canje_Premio
            // 
            this._ControlSalida = true;
            this._FormularioMovil = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(839, 596);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_ver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grid_canje);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.btn_grabar);
            this.Controls.Add(this.btn_seleccionar);
            this.Controls.Add(this.btn_fechasistema);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.grid_premio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Canje_Premio";
            this.Load += new System.EventHandler(this.Frm_Canje_Premio_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.grid_premio, 0);
            this.Controls.SetChildIndex(this.lbl_fecha, 0);
            this.Controls.SetChildIndex(this.btn_fechasistema, 0);
            this.Controls.SetChildIndex(this.btn_seleccionar, 0);
            this.Controls.SetChildIndex(this.pnl_titulo, 0);
            this.Controls.SetChildIndex(this.btn_grabar, 0);
            this.Controls.SetChildIndex(this.btn_actualizar, 0);
            this.Controls.SetChildIndex(this.grid_canje, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.btn_ver, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.pnl_titulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_premio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_actualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_grabar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_canje)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Clases.LabelText txt_numero_cuenta;
        private Clases.LabelText txt_puntos_total;
        private System.Windows.Forms.Button btn_cargar_cuenta;
        private System.Windows.Forms.Label label2;
        private Clases.Grid01 grid_premio;
        private Clases.LabelText lbl_fecha;
        private System.Windows.Forms.Button btn_fechasistema;
        public System.Windows.Forms.Button btn_seleccionar;
        protected System.Windows.Forms.PictureBox btn_actualizar;
        protected System.Windows.Forms.PictureBox btn_grabar;
        protected System.Windows.Forms.PictureBox btn_ver;
        private System.Windows.Forms.Label label3;
        private Clases.Grid01 grid_canje;
        private System.Windows.Forms.GroupBox groupBox2;
        private Clases.LabelText txt_puntos_restantes;
    }
}
