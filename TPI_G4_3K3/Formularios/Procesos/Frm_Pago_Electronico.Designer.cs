
namespace BankApp.Formularios.Procesos
{
    partial class Frm_Pago_Electronico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Pago_Electronico));
            this.cmb_servicios = new BankApp.Clases.ComboBox01();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Saldo = new BankApp.Clases.LabelText();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_id_moneda = new BankApp.Clases.LabelText();
            this.btn_CargarCuentaOrigen = new System.Windows.Forms.Button();
            this.grid_pago_electronico = new BankApp.Clases.Grid01();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ver = new System.Windows.Forms.PictureBox();
            this.lbl_id = new BankApp.Clases.LabelText();
            ((System.ComponentModel.ISupportInitialize)(this.btn_grabar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_actualizar)).BeginInit();
            this.pnl_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_pago_electronico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ver)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(252, 34);
            this.label1.Text = "Pago Electronico";
            // 
            // btn_grabar
            // 
            this.btn_grabar.Location = new System.Drawing.Point(705, 247);
            this.btn_grabar.Size = new System.Drawing.Size(41, 41);
            this.btn_grabar.Click += new System.EventHandler(this.btn_grabar_Click_1);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Location = new System.Drawing.Point(773, 247);
            this.btn_actualizar.Size = new System.Drawing.Size(44, 41);
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // lbl_cta_origen
            // 
            this.lbl_cta_origen._Ancho = 8;
            this.lbl_cta_origen._Decimales = 0;
            this.lbl_cta_origen._Mask = "99999999";
            this.lbl_cta_origen._TipoDato = BankApp.Clases.LabelText.TipoDato.numero;
            this.lbl_cta_origen.Location = new System.Drawing.Point(36, 141);
            this.lbl_cta_origen.Size = new System.Drawing.Size(224, 29);
            // 
            // lbl_fecha
            // 
            this.lbl_fecha._ReadOnly = true;
            this.lbl_fecha.Enabled = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_fecha.Location = new System.Drawing.Point(531, 70);
            this.lbl_fecha.Size = new System.Drawing.Size(295, 29);
            // 
            // lbl_hora
            // 
            this.lbl_hora._Mask = "00:00:00";
            this.lbl_hora._ReadOnly = true;
            this.lbl_hora._Text = "  :  :";
            this.lbl_hora.Enabled = true;
            this.lbl_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora.Location = new System.Drawing.Point(506, 100);
            this.lbl_hora.Size = new System.Drawing.Size(307, 34);
            // 
            // lbl_importe
            // 
            this.lbl_importe._Nombre_Campo = "importe";
            this.lbl_importe._Nombre_Tabla = "Operaciones";
            this.lbl_importe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_importe.Location = new System.Drawing.Point(345, 182);
            this.lbl_importe.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_importe.Size = new System.Drawing.Size(271, 29);
            // 
            // btn_FechaSistema
            // 
            this.btn_FechaSistema.Location = new System.Drawing.Point(839, 71);
            // 
            // btn_HoraSistema
            // 
            this.btn_HoraSistema.Location = new System.Drawing.Point(839, 106);
            // 
            // cmb_servicios
            // 
            this.cmb_servicios._ComboSinSeleccion = true;
            this.cmb_servicios._MensajeError = "Falta seleccionar el Servicio.";
            this.cmb_servicios._Nombre_campo = null;
            this.cmb_servicios._Nombre_tabla = null;
            this.cmb_servicios._tabla_cargar_combo = "Servicios";
            this.cmb_servicios._tabla_cargar_descriptor = "nombre";
            this.cmb_servicios._tabla_cargar_pk = "id";
            this.cmb_servicios._Validable = true;
            this.cmb_servicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_servicios.FormattingEnabled = true;
            this.cmb_servicios.Location = new System.Drawing.Point(535, 151);
            this.cmb_servicios.Name = "cmb_servicios";
            this.cmb_servicios.Size = new System.Drawing.Size(139, 23);
            this.cmb_servicios.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(409, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 32;
            this.label2.Text = "Servicio a Pagar";
            // 
            // lbl_Saldo
            // 
            this.lbl_Saldo._Ancho = 10;
            this.lbl_Saldo._Decimales = 2;
            this.lbl_Saldo._Etiqueta = "Saldo";
            this.lbl_Saldo._Mask = "9999999.99";
            this.lbl_Saldo._MensajeError = null;
            this.lbl_Saldo._Nombre_Campo = "saldo";
            this.lbl_Saldo._Nombre_Tabla = "Cuentas";
            this.lbl_Saldo._ReadOnly = true;
            this.lbl_Saldo._Text = "       ,";
            this.lbl_Saldo._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.lbl_Saldo._TipoDato = BankApp.Clases.LabelText.TipoDato.numero;
            this.lbl_Saldo._Validable = false;
            this.lbl_Saldo.Location = new System.Drawing.Point(9, 56);
            this.lbl_Saldo.Name = "lbl_Saldo";
            this.lbl_Saldo.Size = new System.Drawing.Size(246, 29);
            this.lbl_Saldo.TabIndex = 33;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_id_moneda);
            this.groupBox1.Controls.Add(this.btn_CargarCuentaOrigen);
            this.groupBox1.Controls.Add(this.lbl_Saldo);
            this.groupBox1.Location = new System.Drawing.Point(27, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 139);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // lbl_id_moneda
            // 
            this.lbl_id_moneda._Ancho = 3;
            this.lbl_id_moneda._Decimales = 0;
            this.lbl_id_moneda._Etiqueta = "Moneda";
            this.lbl_id_moneda._Mask = "CCC";
            this.lbl_id_moneda._MensajeError = null;
            this.lbl_id_moneda._Nombre_Campo = "id_moneda";
            this.lbl_id_moneda._Nombre_Tabla = "Cuentas";
            this.lbl_id_moneda._ReadOnly = true;
            this.lbl_id_moneda._Text = "";
            this.lbl_id_moneda._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.lbl_id_moneda._TipoDato = BankApp.Clases.LabelText.TipoDato.texto;
            this.lbl_id_moneda._Validable = false;
            this.lbl_id_moneda.Location = new System.Drawing.Point(10, 91);
            this.lbl_id_moneda.Name = "lbl_id_moneda";
            this.lbl_id_moneda.Size = new System.Drawing.Size(209, 29);
            this.lbl_id_moneda.TabIndex = 39;
            // 
            // btn_CargarCuentaOrigen
            // 
            this.btn_CargarCuentaOrigen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_CargarCuentaOrigen.Location = new System.Drawing.Point(286, 111);
            this.btn_CargarCuentaOrigen.Margin = new System.Windows.Forms.Padding(2);
            this.btn_CargarCuentaOrigen.Name = "btn_CargarCuentaOrigen";
            this.btn_CargarCuentaOrigen.Size = new System.Drawing.Size(27, 23);
            this.btn_CargarCuentaOrigen.TabIndex = 38;
            this.btn_CargarCuentaOrigen.UseVisualStyleBackColor = false;
            this.btn_CargarCuentaOrigen.Click += new System.EventHandler(this.btn_CargarCuentaOrigen_Click);
            // 
            // grid_pago_electronico
            // 
            this.grid_pago_electronico.AllowUserToAddRows = false;
            this.grid_pago_electronico.AllowUserToDeleteRows = false;
            this.grid_pago_electronico.BackgroundColor = System.Drawing.Color.White;
            this.grid_pago_electronico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_pago_electronico.Location = new System.Drawing.Point(37, 365);
            this.grid_pago_electronico.Name = "grid_pago_electronico";
            this.grid_pago_electronico.ReadOnly = true;
            this.grid_pago_electronico.Size = new System.Drawing.Size(820, 86);
            this.grid_pago_electronico.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(373, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Presione el Boton para Visualizar Datos de su Pago";
            // 
            // btn_ver
            // 
            this.btn_ver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ver.Image = ((System.Drawing.Image)(resources.GetObject("btn_ver.Image")));
            this.btn_ver.Location = new System.Drawing.Point(55, 317);
            this.btn_ver.Name = "btn_ver";
            this.btn_ver.Size = new System.Drawing.Size(37, 42);
            this.btn_ver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_ver.TabIndex = 37;
            this.btn_ver.TabStop = false;
            this.btn_ver.Click += new System.EventHandler(this.btn_ver_Click);
            // 
            // lbl_id
            // 
            this.lbl_id._Ancho = 5;
            this.lbl_id._Decimales = 0;
            this.lbl_id._Etiqueta = "ID";
            this.lbl_id._Mask = "99999";
            this.lbl_id._MensajeError = null;
            this.lbl_id._Nombre_Campo = null;
            this.lbl_id._Nombre_Tabla = null;
            this.lbl_id._ReadOnly = false;
            this.lbl_id._Text = "";
            this.lbl_id._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.lbl_id._TipoDato = BankApp.Clases.LabelText.TipoDato.numero;
            this.lbl_id._Validable = false;
            this.lbl_id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_id.Enabled = false;
            this.lbl_id.Location = new System.Drawing.Point(412, 285);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(113, 29);
            this.lbl_id.TabIndex = 38;
            // 
            // Frm_Pago_Electronico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(896, 471);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.btn_ver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grid_pago_electronico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_servicios);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_Pago_Electronico";
            this.Load += new System.EventHandler(this.Frm_Pago_Electronico_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.cmb_servicios, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.grid_pago_electronico, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.lbl_cta_origen, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lbl_fecha, 0);
            this.Controls.SetChildIndex(this.lbl_hora, 0);
            this.Controls.SetChildIndex(this.pnl_titulo, 0);
            this.Controls.SetChildIndex(this.btn_grabar, 0);
            this.Controls.SetChildIndex(this.btn_actualizar, 0);
            this.Controls.SetChildIndex(this.btn_FechaSistema, 0);
            this.Controls.SetChildIndex(this.btn_HoraSistema, 0);
            this.Controls.SetChildIndex(this.btn_ver, 0);
            this.Controls.SetChildIndex(this.lbl_importe, 0);
            this.Controls.SetChildIndex(this.lbl_id, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btn_grabar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_actualizar)).EndInit();
            this.pnl_titulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_pago_electronico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Clases.ComboBox01 cmb_servicios;
        public System.Windows.Forms.Label label2;
        private Clases.LabelText lbl_Saldo;
        private System.Windows.Forms.GroupBox groupBox1;
        private Clases.Grid01 grid_pago_electronico;
        private System.Windows.Forms.Label label3;
        protected System.Windows.Forms.PictureBox btn_ver;
        private System.Windows.Forms.Button btn_CargarCuentaOrigen;
        private Clases.LabelText lbl_id_moneda;
        private Clases.LabelText lbl_id;
    }
}
