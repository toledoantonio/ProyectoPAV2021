
namespace BankApp.Formularios.Usuarios
{
    partial class Frm_Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Usuarios));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id = new BankApp.Clases.LabelText();
            this.txt_nombre_usuario = new BankApp.Clases.LabelText();
            this.txt_contraseña = new BankApp.Clases.LabelText();
            this.txt_apellido = new BankApp.Clases.LabelText();
            this.txt_nombre = new BankApp.Clases.LabelText();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_tipo_doc = new BankApp.Clases.ComboBox01();
            this.txt_nro_doc = new BankApp.Clases.LabelText();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.pnl_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_titulo
            // 
            this.pnl_titulo.Size = new System.Drawing.Size(431, 35);
            // 
            // btn_restaurar
            // 
            this.btn_restaurar.Location = new System.Drawing.Point(-123, 5);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Location = new System.Drawing.Point(-154, 5);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.Location = new System.Drawing.Point(-123, 5);
            this.btn_maximizar.Visible = false;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(394, 5);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Titulo";
            // 
            // txt_id
            // 
            this.txt_id._Ancho = 2;
            this.txt_id._Decimales = 2;
            this.txt_id._Etiqueta = "Id Usuario";
            this.txt_id._MensajeError = null;
            this.txt_id._Nombre_Campo = null;
            this.txt_id._Nombre_Tabla = null;
            this.txt_id._ReadOnly = false;
            this.txt_id._Text = "";
            this.txt_id._TipoDato = BankApp.Clases.LabelText.TipoDato.texto;
            this.txt_id._Validable = false;
            this.txt_id.Location = new System.Drawing.Point(22, 116);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(199, 29);
            this.txt_id.TabIndex = 11;
            // 
            // txt_nombre_usuario
            // 
            this.txt_nombre_usuario._Ancho = 30;
            this.txt_nombre_usuario._Decimales = 2;
            this.txt_nombre_usuario._Etiqueta = "Nombre de Usuario";
            this.txt_nombre_usuario._MensajeError = "El nombre de usuario está vacio.";
            this.txt_nombre_usuario._Nombre_Campo = "nombre_usuario";
            this.txt_nombre_usuario._Nombre_Tabla = null;
            this.txt_nombre_usuario._ReadOnly = false;
            this.txt_nombre_usuario._Text = "";
            this.txt_nombre_usuario._TipoDato = BankApp.Clases.LabelText.TipoDato.texto;
            this.txt_nombre_usuario._Validable = true;
            this.txt_nombre_usuario.Location = new System.Drawing.Point(22, 151);
            this.txt_nombre_usuario.Name = "txt_nombre_usuario";
            this.txt_nombre_usuario.Size = new System.Drawing.Size(389, 29);
            this.txt_nombre_usuario.TabIndex = 12;
            // 
            // txt_contraseña
            // 
            this.txt_contraseña._Ancho = 30;
            this.txt_contraseña._Decimales = 2;
            this.txt_contraseña._Etiqueta = "Contraseña";
            this.txt_contraseña._MensajeError = "Falta ingresar contraseña.";
            this.txt_contraseña._Nombre_Campo = "contraseña";
            this.txt_contraseña._Nombre_Tabla = null;
            this.txt_contraseña._ReadOnly = false;
            this.txt_contraseña._Text = "";
            this.txt_contraseña._TipoDato = BankApp.Clases.LabelText.TipoDato.texto;
            this.txt_contraseña._Validable = true;
            this.txt_contraseña.Location = new System.Drawing.Point(22, 186);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(389, 29);
            this.txt_contraseña.TabIndex = 13;
            // 
            // txt_apellido
            // 
            this.txt_apellido._Ancho = 30;
            this.txt_apellido._Decimales = 2;
            this.txt_apellido._Etiqueta = "Apellido";
            this.txt_apellido._MensajeError = "Falta ingresar el apellido.";
            this.txt_apellido._Nombre_Campo = "apellido";
            this.txt_apellido._Nombre_Tabla = null;
            this.txt_apellido._ReadOnly = false;
            this.txt_apellido._Text = "";
            this.txt_apellido._TipoDato = BankApp.Clases.LabelText.TipoDato.texto;
            this.txt_apellido._Validable = true;
            this.txt_apellido.Location = new System.Drawing.Point(22, 221);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(389, 29);
            this.txt_apellido.TabIndex = 14;
            // 
            // txt_nombre
            // 
            this.txt_nombre._Ancho = 30;
            this.txt_nombre._Decimales = 2;
            this.txt_nombre._Etiqueta = "Nombres";
            this.txt_nombre._MensajeError = "Falta ingresar nombre.";
            this.txt_nombre._Nombre_Campo = "nombre";
            this.txt_nombre._Nombre_Tabla = null;
            this.txt_nombre._ReadOnly = false;
            this.txt_nombre._Text = "";
            this.txt_nombre._TipoDato = BankApp.Clases.LabelText.TipoDato.texto;
            this.txt_nombre._Validable = true;
            this.txt_nombre.Location = new System.Drawing.Point(22, 256);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(389, 29);
            this.txt_nombre.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tipo de Documento";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmb_tipo_doc
            // 
            this.cmb_tipo_doc._ComboSinSeleccion = true;
            this.cmb_tipo_doc._MensajeError = "Falta seleccionar el tipo de documento.";
            this.cmb_tipo_doc._Nombre_campo = null;
            this.cmb_tipo_doc._Nombre_tabla = null;
            this.cmb_tipo_doc._tabla_cargar_combo = "Tipos_Documentos";
            this.cmb_tipo_doc._tabla_cargar_descriptor = "descripcion";
            this.cmb_tipo_doc._tabla_cargar_pk = "id";
            this.cmb_tipo_doc._Validable = true;
            this.cmb_tipo_doc.FormattingEnabled = true;
            this.cmb_tipo_doc.Location = new System.Drawing.Point(187, 291);
            this.cmb_tipo_doc.Name = "cmb_tipo_doc";
            this.cmb_tipo_doc.Size = new System.Drawing.Size(121, 21);
            this.cmb_tipo_doc.TabIndex = 17;
            // 
            // txt_nro_doc
            // 
            this.txt_nro_doc._Ancho = 8;
            this.txt_nro_doc._Decimales = 0;
            this.txt_nro_doc._Etiqueta = "Nro de Documento";
            this.txt_nro_doc._MensajeError = "Falta ingresar numero de documento.";
            this.txt_nro_doc._Nombre_Campo = "nro_doc";
            this.txt_nro_doc._Nombre_Tabla = null;
            this.txt_nro_doc._ReadOnly = false;
            this.txt_nro_doc._Text = "";
            this.txt_nro_doc._TipoDato = BankApp.Clases.LabelText.TipoDato.numero;
            this.txt_nro_doc._Validable = true;
            this.txt_nro_doc.Location = new System.Drawing.Point(22, 318);
            this.txt_nro_doc.Name = "txt_nro_doc";
            this.txt_nro_doc.Size = new System.Drawing.Size(239, 29);
            this.txt_nro_doc.TabIndex = 18;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(96)))), ((int)(((byte)(230)))));
            this.btn_aceptar.Location = new System.Drawing.Point(187, 358);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(115, 35);
            this.btn_aceptar.TabIndex = 19;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            // 
            // Frm_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(431, 418);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.txt_nro_doc);
            this.Controls.Add(this.cmb_tipo_doc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.txt_nombre_usuario);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Usuarios";
            this.Load += new System.EventHandler(this.Frm_Usuarios_Load);
            this.Controls.SetChildIndex(this.pnl_titulo, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txt_id, 0);
            this.Controls.SetChildIndex(this.txt_nombre_usuario, 0);
            this.Controls.SetChildIndex(this.txt_contraseña, 0);
            this.Controls.SetChildIndex(this.txt_apellido, 0);
            this.Controls.SetChildIndex(this.txt_nombre, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.cmb_tipo_doc, 0);
            this.Controls.SetChildIndex(this.txt_nro_doc, 0);
            this.Controls.SetChildIndex(this.btn_aceptar, 0);
            this.pnl_titulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public Clases.LabelText txt_id;
        public Clases.LabelText txt_nombre_usuario;
        public Clases.LabelText txt_contraseña;
        public Clases.LabelText txt_apellido;
        public Clases.LabelText txt_nombre;
        public Clases.ComboBox01 cmb_tipo_doc;
        public Clases.LabelText txt_nro_doc;
        public System.Windows.Forms.Button btn_aceptar;
    }
}
