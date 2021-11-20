
namespace BankApp.Formularios.Premios
{
    partial class Frm_Premios
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
            this.txt_codigo = new BankApp.Clases.LabelText();
            this.txt_descripcion = new BankApp.Clases.LabelText();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_tipo_prem = new BankApp.Clases.ComboBox01();
            this.txt_puntos_req_actual = new BankApp.Clases.LabelText();
            this.txt_stock = new BankApp.Clases.LabelText();
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
            this.pnl_titulo.Location = new System.Drawing.Point(-83, 0);
            this.pnl_titulo.Margin = new System.Windows.Forms.Padding(4);
            // 
            // btn_restaurar
            // 
            this.btn_restaurar.Location = new System.Drawing.Point(425, 3);
            this.btn_restaurar.Margin = new System.Windows.Forms.Padding(4);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Location = new System.Drawing.Point(383, 5);
            this.btn_minimizar.Margin = new System.Windows.Forms.Padding(4);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.Location = new System.Drawing.Point(422, 6);
            this.btn_maximizar.Margin = new System.Windows.Forms.Padding(4);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(465, 5);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 29);
            this.label1.TabIndex = 22;
            this.label1.Text = "Titulo";
            // 
            // txt_codigo
            // 
            this.txt_codigo._Ancho = 3;
            this.txt_codigo._Decimales = 0;
            this.txt_codigo._Etiqueta = "Codigo";
            this.txt_codigo._Mask = "999";
            this.txt_codigo._MensajeError = null;
            this.txt_codigo._Nombre_Campo = "codigo";
            this.txt_codigo._Nombre_Tabla = null;
            this.txt_codigo._ReadOnly = false;
            this.txt_codigo._Text = "";
            this.txt_codigo._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_codigo._TipoDato = BankApp.Clases.LabelText.TipoDato.numero;
            this.txt_codigo._Validable = false;
            this.txt_codigo.Enabled = false;
            this.txt_codigo.Location = new System.Drawing.Point(30, 113);
            this.txt_codigo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(203, 29);
            this.txt_codigo.TabIndex = 27;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion._Ancho = 25;
            this.txt_descripcion._Decimales = 2;
            this.txt_descripcion._Etiqueta = "Descripcion";
            this.txt_descripcion._Mask = "CCCCCCCCCCCCCCCCCCCCCCCCC";
            this.txt_descripcion._MensajeError = "La descripcion está vacía.";
            this.txt_descripcion._Nombre_Campo = "descripcion";
            this.txt_descripcion._Nombre_Tabla = null;
            this.txt_descripcion._ReadOnly = false;
            this.txt_descripcion._Text = "";
            this.txt_descripcion._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_descripcion._TipoDato = BankApp.Clases.LabelText.TipoDato.texto;
            this.txt_descripcion._Validable = true;
            this.txt_descripcion.Location = new System.Drawing.Point(31, 189);
            this.txt_descripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(351, 29);
            this.txt_descripcion.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 18);
            this.label2.TabIndex = 29;
            this.label2.Text = "Tipo de Premio";
            // 
            // cmb_tipo_prem
            // 
            this.cmb_tipo_prem._ComboSinSeleccion = true;
            this.cmb_tipo_prem._MensajeError = "Falta seleccionar el tipo de premio.";
            this.cmb_tipo_prem._Nombre_campo = null;
            this.cmb_tipo_prem._Nombre_tabla = null;
            this.cmb_tipo_prem._tabla_cargar_combo = "Tipo_Premio";
            this.cmb_tipo_prem._tabla_cargar_descriptor = "nombre";
            this.cmb_tipo_prem._tabla_cargar_pk = "id";
            this.cmb_tipo_prem._Validable = true;
            this.cmb_tipo_prem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tipo_prem.FormattingEnabled = true;
            this.cmb_tipo_prem.Location = new System.Drawing.Point(195, 155);
            this.cmb_tipo_prem.Name = "cmb_tipo_prem";
            this.cmb_tipo_prem.Size = new System.Drawing.Size(121, 23);
            this.cmb_tipo_prem.TabIndex = 30;
            // 
            // txt_puntos_req_actual
            // 
            this.txt_puntos_req_actual._Ancho = 4;
            this.txt_puntos_req_actual._Decimales = 0;
            this.txt_puntos_req_actual._Etiqueta = "Puntos Requeridos";
            this.txt_puntos_req_actual._Mask = "9999";
            this.txt_puntos_req_actual._MensajeError = "Falta ingresar Puntos Requeridos.";
            this.txt_puntos_req_actual._Nombre_Campo = "puntos_req_actual";
            this.txt_puntos_req_actual._Nombre_Tabla = null;
            this.txt_puntos_req_actual._ReadOnly = false;
            this.txt_puntos_req_actual._Text = "";
            this.txt_puntos_req_actual._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_puntos_req_actual._TipoDato = BankApp.Clases.LabelText.TipoDato.numero;
            this.txt_puntos_req_actual._Validable = true;
            this.txt_puntos_req_actual.Location = new System.Drawing.Point(30, 229);
            this.txt_puntos_req_actual.Margin = new System.Windows.Forms.Padding(4);
            this.txt_puntos_req_actual.Name = "txt_puntos_req_actual";
            this.txt_puntos_req_actual.Size = new System.Drawing.Size(203, 29);
            this.txt_puntos_req_actual.TabIndex = 31;
            // 
            // txt_stock
            // 
            this.txt_stock._Ancho = 3;
            this.txt_stock._Decimales = 0;
            this.txt_stock._Etiqueta = "Stock";
            this.txt_stock._Mask = "999";
            this.txt_stock._MensajeError = "Falta ingresar el Stock.";
            this.txt_stock._Nombre_Campo = "stock";
            this.txt_stock._Nombre_Tabla = null;
            this.txt_stock._ReadOnly = false;
            this.txt_stock._Text = "";
            this.txt_stock._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_stock._TipoDato = BankApp.Clases.LabelText.TipoDato.numero;
            this.txt_stock._Validable = true;
            this.txt_stock.Location = new System.Drawing.Point(31, 269);
            this.txt_stock.Margin = new System.Windows.Forms.Padding(4);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(202, 29);
            this.txt_stock.TabIndex = 32;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(96)))), ((int)(((byte)(230)))));
            this.btn_aceptar.Location = new System.Drawing.Point(278, 316);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(115, 35);
            this.btn_aceptar.TabIndex = 33;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            // 
            // Frm_Premios
            // 
            this._FormularioMovil = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(427, 376);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.txt_stock);
            this.Controls.Add(this.txt_puntos_req_actual);
            this.Controls.Add(this.cmb_tipo_prem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Premios";
            this.Load += new System.EventHandler(this.Frm_Premios_Load);
            this.Controls.SetChildIndex(this.pnl_titulo, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txt_codigo, 0);
            this.Controls.SetChildIndex(this.txt_descripcion, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.cmb_tipo_prem, 0);
            this.Controls.SetChildIndex(this.txt_puntos_req_actual, 0);
            this.Controls.SetChildIndex(this.txt_stock, 0);
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

        public System.Windows.Forms.Label label1;
        public Clases.LabelText txt_codigo;
        public Clases.LabelText txt_descripcion;
        public Clases.ComboBox01 cmb_tipo_prem;
        public Clases.LabelText txt_puntos_req_actual;
        public Clases.LabelText txt_stock;
        public System.Windows.Forms.Button btn_aceptar;
        public System.Windows.Forms.Label label2;
    }
}
