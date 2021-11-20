
namespace BankApp.Formularios.Cuentas
{
    partial class Frm_Cuentas
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
            this.txt_numero = new BankApp.Clases.LabelText();
            this.txt_id_usuario = new BankApp.Clases.LabelText();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.cmb_tiposCuentas = new BankApp.Clases.ComboBox01();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_monedas = new BankApp.Clases.ComboBox01();
            this.txt_puntos = new BankApp.Clases.LabelText();
            this.txt_saldo = new BankApp.Clases.LabelText();
            this.pnl_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_titulo
            // 
            this.pnl_titulo.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_titulo.Size = new System.Drawing.Size(431, 35);
            this.pnl_titulo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_titulo_Paint);
            // 
            // btn_restaurar
            // 
            this.btn_restaurar.Location = new System.Drawing.Point(367, 5);
            this.btn_restaurar.Margin = new System.Windows.Forms.Padding(2);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Location = new System.Drawing.Point(336, 5);
            this.btn_minimizar.Margin = new System.Windows.Forms.Padding(2);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.Location = new System.Drawing.Point(367, 5);
            this.btn_maximizar.Margin = new System.Windows.Forms.Padding(2);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(398, 5);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Titulo";
            // 
            // txt_numero
            // 
            this.txt_numero._Ancho = 3;
            this.txt_numero._Decimales = 0;
            this.txt_numero._Etiqueta = "Numero";
            this.txt_numero._Mask = "CCC";
            this.txt_numero._MensajeError = null;
            this.txt_numero._Nombre_Campo = null;
            this.txt_numero._Nombre_Tabla = null;
            this.txt_numero._ReadOnly = false;
            this.txt_numero._Text = "";
            this.txt_numero._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_numero._TipoDato = BankApp.Clases.LabelText.TipoDato.texto;
            this.txt_numero._Validable = true;
            this.txt_numero.Enabled = false;
            this.txt_numero.Location = new System.Drawing.Point(19, 119);
            this.txt_numero.Margin = new System.Windows.Forms.Padding(4);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(201, 29);
            this.txt_numero.TabIndex = 12;
            this.txt_numero.Load += new System.EventHandler(this.txt_id_Load);
            // 
            // txt_id_usuario
            // 
            this.txt_id_usuario._Ancho = 3;
            this.txt_id_usuario._Decimales = 0;
            this.txt_id_usuario._Etiqueta = "Id Usuario";
            this.txt_id_usuario._Mask = "CCC";
            this.txt_id_usuario._MensajeError = "Falta seleccionar Id Usuario";
            this.txt_id_usuario._Nombre_Campo = null;
            this.txt_id_usuario._Nombre_Tabla = null;
            this.txt_id_usuario._ReadOnly = false;
            this.txt_id_usuario._Text = "";
            this.txt_id_usuario._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_id_usuario._TipoDato = BankApp.Clases.LabelText.TipoDato.texto;
            this.txt_id_usuario._Validable = true;
            this.txt_id_usuario.Location = new System.Drawing.Point(20, 156);
            this.txt_id_usuario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id_usuario.Name = "txt_id_usuario";
            this.txt_id_usuario.Size = new System.Drawing.Size(200, 29);
            this.txt_id_usuario.TabIndex = 13;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(96)))), ((int)(((byte)(230)))));
            this.btn_aceptar.Location = new System.Drawing.Point(175, 356);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(115, 35);
            this.btn_aceptar.TabIndex = 20;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            // 
            // cmb_tiposCuentas
            // 
            this.cmb_tiposCuentas._ComboSinSeleccion = true;
            this.cmb_tiposCuentas._MensajeError = "Falta Seleccionar Tipo de Cuenta";
            this.cmb_tiposCuentas._Nombre_campo = "tipo_cuenta";
            this.cmb_tiposCuentas._Nombre_tabla = null;
            this.cmb_tiposCuentas._tabla_cargar_combo = "Tipos_Cuentas";
            this.cmb_tiposCuentas._tabla_cargar_descriptor = "descripcion";
            this.cmb_tiposCuentas._tabla_cargar_pk = "id";
            this.cmb_tiposCuentas._Validable = true;
            this.cmb_tiposCuentas.FormattingEnabled = true;
            this.cmb_tiposCuentas.Location = new System.Drawing.Point(184, 200);
            this.cmb_tiposCuentas.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_tiposCuentas.Name = "cmb_tiposCuentas";
            this.cmb_tiposCuentas.Size = new System.Drawing.Size(106, 21);
            this.cmb_tiposCuentas.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 200);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tipo de Cuenta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(119, 237);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Moneda";
            // 
            // cmb_monedas
            // 
            this.cmb_monedas._ComboSinSeleccion = true;
            this.cmb_monedas._MensajeError = "Falta Seleccionar Monedas";
            this.cmb_monedas._Nombre_campo = "id_moneda";
            this.cmb_monedas._Nombre_tabla = null;
            this.cmb_monedas._tabla_cargar_combo = "Monedas";
            this.cmb_monedas._tabla_cargar_descriptor = "nombre";
            this.cmb_monedas._tabla_cargar_pk = "id";
            this.cmb_monedas._Validable = true;
            this.cmb_monedas.FormattingEnabled = true;
            this.cmb_monedas.Location = new System.Drawing.Point(184, 237);
            this.cmb_monedas.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_monedas.Name = "cmb_monedas";
            this.cmb_monedas.Size = new System.Drawing.Size(106, 21);
            this.cmb_monedas.TabIndex = 23;
            // 
            // txt_puntos
            // 
            this.txt_puntos._Ancho = 10;
            this.txt_puntos._Decimales = 0;
            this.txt_puntos._Etiqueta = "Puntos Totales";
            this.txt_puntos._Mask = "CCCCCCCCCC";
            this.txt_puntos._MensajeError = "Falta Seleccionar Puntos Totales";
            this.txt_puntos._Nombre_Campo = "puntos_total";
            this.txt_puntos._Nombre_Tabla = "Cuentas";
            this.txt_puntos._ReadOnly = false;
            this.txt_puntos._Text = "";
            this.txt_puntos._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_puntos._TipoDato = BankApp.Clases.LabelText.TipoDato.texto;
            this.txt_puntos._Validable = false;
            this.txt_puntos.Location = new System.Drawing.Point(20, 272);
            this.txt_puntos.Name = "txt_puntos";
            this.txt_puntos.Size = new System.Drawing.Size(254, 29);
            this.txt_puntos.TabIndex = 25;
            // 
            // txt_saldo
            // 
            this.txt_saldo._Ancho = 10;
            this.txt_saldo._Decimales = 2;
            this.txt_saldo._Etiqueta = "Saldo";
            this.txt_saldo._Mask = "CCCCCCCCCC";
            this.txt_saldo._MensajeError = "Falta Seleccionar Saldo";
            this.txt_saldo._Nombre_Campo = "saldo";
            this.txt_saldo._Nombre_Tabla = "Cuentas";
            this.txt_saldo._ReadOnly = false;
            this.txt_saldo._Text = "";
            this.txt_saldo._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_saldo._TipoDato = BankApp.Clases.LabelText.TipoDato.texto;
            this.txt_saldo._Validable = false;
            this.txt_saldo.Location = new System.Drawing.Point(20, 307);
            this.txt_saldo.Name = "txt_saldo";
            this.txt_saldo.Size = new System.Drawing.Size(254, 29);
            this.txt_saldo.TabIndex = 26;
            // 
            // Frm_Cuentas
            // 
            this._FormularioMovil = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(431, 412);
            this.Controls.Add(this.txt_saldo);
            this.Controls.Add(this.txt_puntos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_monedas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_tiposCuentas);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.txt_id_usuario);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_Cuentas";
            this.Load += new System.EventHandler(this.Frm_Cuentas_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.pnl_titulo, 0);
            this.Controls.SetChildIndex(this.txt_numero, 0);
            this.Controls.SetChildIndex(this.txt_id_usuario, 0);
            this.Controls.SetChildIndex(this.btn_aceptar, 0);
            this.Controls.SetChildIndex(this.cmb_tiposCuentas, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.cmb_monedas, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txt_puntos, 0);
            this.Controls.SetChildIndex(this.txt_saldo, 0);
            this.pnl_titulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public Clases.LabelText txt_numero;
        public Clases.LabelText txt_id_usuario;
        public System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public Clases.ComboBox01 cmb_tiposCuentas;
        public Clases.ComboBox01 cmb_monedas;
        public Clases.LabelText txt_puntos;
        public Clases.LabelText txt_saldo;
    }
}
