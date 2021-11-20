
namespace BankApp.Formularios.Cotizaciones
{
    partial class Frm_Cotizaciones
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
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.txt_valor = new BankApp.Clases.LabelText();
            this.txt_cmb_mon_org = new BankApp.Clases.ComboBox01();
            this.Moneda_Origen = new System.Windows.Forms.Label();
            this.txt_fecha = new BankApp.Clases.LabelText();
            this.txt_id = new BankApp.Clases.LabelText();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cmb_mon_dest = new BankApp.Clases.ComboBox01();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_titulo
            // 
            this.pnl_titulo.Location = new System.Drawing.Point(-132, 0);
            this.pnl_titulo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            // 
            // btn_restaurar
            // 
            this.btn_restaurar.Location = new System.Drawing.Point(567, 9);
            this.btn_restaurar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Location = new System.Drawing.Point(525, 9);
            this.btn_minimizar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.Location = new System.Drawing.Point(567, 9);
            this.btn_maximizar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(608, 9);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(96)))), ((int)(((byte)(230)))));
            this.btn_aceptar.Location = new System.Drawing.Point(283, 398);
            this.btn_aceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(153, 43);
            this.btn_aceptar.TabIndex = 41;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            // 
            // txt_valor
            // 
            this.txt_valor._Ancho = 10;
            this.txt_valor._Decimales = 2;
            this.txt_valor._Etiqueta = "Valor";
            this.txt_valor._Mask = "9999999.99";
            this.txt_valor._MensajeError = "Falta ingresar Valor de la Cotiszacion";
            this.txt_valor._Nombre_Campo = "valor";
            this.txt_valor._Nombre_Tabla = null;
            this.txt_valor._ReadOnly = false;
            this.txt_valor._Text = "       ,";
            this.txt_valor._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_valor._TipoDato = BankApp.Clases.LabelText.TipoDato.numero;
            this.txt_valor._Validable = true;
            this.txt_valor.Location = new System.Drawing.Point(-4, 325);
            this.txt_valor.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(331, 36);
            this.txt_valor.TabIndex = 39;
            // 
            // txt_cmb_mon_org
            // 
            this.txt_cmb_mon_org._ComboSinSeleccion = true;
            this.txt_cmb_mon_org._MensajeError = "Falta seleccionar la Moneda Origen.";
            this.txt_cmb_mon_org._Nombre_campo = null;
            this.txt_cmb_mon_org._Nombre_tabla = null;
            this.txt_cmb_mon_org._tabla_cargar_combo = "Monedas";
            this.txt_cmb_mon_org._tabla_cargar_descriptor = "nombre";
            this.txt_cmb_mon_org._tabla_cargar_pk = "id";
            this.txt_cmb_mon_org._Validable = true;
            this.txt_cmb_mon_org.FormattingEnabled = true;
            this.txt_cmb_mon_org.Location = new System.Drawing.Point(213, 207);
            this.txt_cmb_mon_org.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_cmb_mon_org.Name = "txt_cmb_mon_org";
            this.txt_cmb_mon_org.Size = new System.Drawing.Size(160, 24);
            this.txt_cmb_mon_org.TabIndex = 38;
            // 
            // Moneda_Origen
            // 
            this.Moneda_Origen.AutoSize = true;
            this.Moneda_Origen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Moneda_Origen.Location = new System.Drawing.Point(59, 210);
            this.Moneda_Origen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Moneda_Origen.Name = "Moneda_Origen";
            this.Moneda_Origen.Size = new System.Drawing.Size(143, 24);
            this.Moneda_Origen.TabIndex = 37;
            this.Moneda_Origen.Text = "Moneda Origen";
            // 
            // txt_fecha
            // 
            this.txt_fecha._Ancho = 10;
            this.txt_fecha._Decimales = 2;
            this.txt_fecha._Etiqueta = "Fecha";
            this.txt_fecha._Mask = "00/00/0000";
            this.txt_fecha._MensajeError = "La descripcion está vacía.";
            this.txt_fecha._Nombre_Campo = "fecha";
            this.txt_fecha._Nombre_Tabla = null;
            this.txt_fecha._ReadOnly = false;
            this.txt_fecha._Text = "  /  /";
            this.txt_fecha._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_fecha._TipoDato = BankApp.Clases.LabelText.TipoDato.fecha;
            this.txt_fecha._Validable = false;
            this.txt_fecha.Location = new System.Drawing.Point(-4, 282);
            this.txt_fecha.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(331, 36);
            this.txt_fecha.TabIndex = 36;
            this.txt_fecha.Load += new System.EventHandler(this.txt_descripcion_Load);
            // 
            // txt_id
            // 
            this.txt_id._Ancho = 3;
            this.txt_id._Decimales = 0;
            this.txt_id._Etiqueta = "Id";
            this.txt_id._Mask = "999";
            this.txt_id._MensajeError = null;
            this.txt_id._Nombre_Campo = "id";
            this.txt_id._Nombre_Tabla = null;
            this.txt_id._ReadOnly = false;
            this.txt_id._Text = "";
            this.txt_id._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_id._TipoDato = BankApp.Clases.LabelText.TipoDato.numero;
            this.txt_id._Validable = false;
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(-5, 164);
            this.txt_id.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(271, 36);
            this.txt_id.TabIndex = 35;
            this.txt_id.Load += new System.EventHandler(this.txt_codigo_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 35);
            this.label1.TabIndex = 34;
            this.label1.Text = "Titulo";
            // 
            // txt_cmb_mon_dest
            // 
            this.txt_cmb_mon_dest._ComboSinSeleccion = true;
            this.txt_cmb_mon_dest._MensajeError = "Falta seleccionar la Moneda Destino.";
            this.txt_cmb_mon_dest._Nombre_campo = null;
            this.txt_cmb_mon_dest._Nombre_tabla = null;
            this.txt_cmb_mon_dest._tabla_cargar_combo = "Monedas";
            this.txt_cmb_mon_dest._tabla_cargar_descriptor = "nombre";
            this.txt_cmb_mon_dest._tabla_cargar_pk = "id";
            this.txt_cmb_mon_dest._Validable = true;
            this.txt_cmb_mon_dest.FormattingEnabled = true;
            this.txt_cmb_mon_dest.Location = new System.Drawing.Point(213, 249);
            this.txt_cmb_mon_dest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_cmb_mon_dest.Name = "txt_cmb_mon_dest";
            this.txt_cmb_mon_dest.Size = new System.Drawing.Size(160, 24);
            this.txt_cmb_mon_dest.TabIndex = 43;
            this.txt_cmb_mon_dest.SelectedIndexChanged += new System.EventHandler(this.comboBox011_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 249);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 24);
            this.label2.TabIndex = 42;
            this.label2.Text = "Moneda Destino";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Frm_Cotizaciones
            // 
            this._FormularioMovil = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(525, 516);
            this.Controls.Add(this.txt_cmb_mon_dest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.txt_cmb_mon_org);
            this.Controls.Add(this.Moneda_Origen);
            this.Controls.Add(this.txt_fecha);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Frm_Cotizaciones";
            this.Load += new System.EventHandler(this.Frm_Cotizaciones_Load);
            this.Controls.SetChildIndex(this.pnl_titulo, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txt_id, 0);
            this.Controls.SetChildIndex(this.txt_fecha, 0);
            this.Controls.SetChildIndex(this.Moneda_Origen, 0);
            this.Controls.SetChildIndex(this.txt_cmb_mon_org, 0);
            this.Controls.SetChildIndex(this.txt_valor, 0);
            this.Controls.SetChildIndex(this.btn_aceptar, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txt_cmb_mon_dest, 0);
            this.pnl_titulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_aceptar;
        public Clases.LabelText txt_valor;
        public Clases.ComboBox01 txt_cmb_mon_org;
        public System.Windows.Forms.Label Moneda_Origen;
        public Clases.LabelText txt_fecha;
        public Clases.LabelText txt_id;
        public System.Windows.Forms.Label label1;
        public Clases.ComboBox01 txt_cmb_mon_dest;
        public System.Windows.Forms.Label label2;
    }
}
