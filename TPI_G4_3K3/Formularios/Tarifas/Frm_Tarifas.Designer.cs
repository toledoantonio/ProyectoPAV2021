
namespace BankApp.Formularios.Tarifas
{
    partial class Frm_Tarifas
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
            this.labelText1 = new BankApp.Clases.LabelText();
            this.labelText2 = new BankApp.Clases.LabelText();
            this.labelText4 = new BankApp.Clases.LabelText();
            this.labelText5 = new BankApp.Clases.LabelText();
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
            this.pnl_titulo.Location = new System.Drawing.Point(-107, 0);
            // 
            // btn_restaurar
            // 
            this.btn_restaurar.Location = new System.Drawing.Point(597, 4);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Location = new System.Drawing.Point(555, 4);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.Location = new System.Drawing.Point(596, 4);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(637, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 35);
            this.label1.TabIndex = 12;
            this.label1.Text = "Titulo";
            // 
            // txt_numero
            // 
            this.txt_numero._Ancho = 6;
            this.txt_numero._Decimales = 0;
            this.txt_numero._Etiqueta = "Id";
            this.txt_numero._MensajeError = null;
            this.txt_numero._Nombre_Campo = null;
            this.txt_numero._Nombre_Tabla = null;
            this.txt_numero._ReadOnly = false;
            this.txt_numero._Text = "";
            this.txt_numero._TipoDato = BankApp.Clases.LabelText.TipoDato.numero;
            this.txt_numero._Validable = false;
            this.txt_numero.Enabled = false;
            this.txt_numero.Location = new System.Drawing.Point(14, 147);
            this.txt_numero.Margin = new System.Windows.Forms.Padding(5);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(295, 36);
            this.txt_numero.TabIndex = 13;
            // 
            // labelText1
            // 
            this.labelText1._Ancho = 6;
            this.labelText1._Decimales = 0;
            this.labelText1._Etiqueta = "Fecha Vigencia Desde";
            this.labelText1._MensajeError = null;
            this.labelText1._Nombre_Campo = null;
            this.labelText1._Nombre_Tabla = null;
            this.labelText1._ReadOnly = false;
            this.labelText1._Text = "  /  /";
            this.labelText1._TipoDato = BankApp.Clases.LabelText.TipoDato.fecha;
            this.labelText1._Validable = false;
            this.labelText1.Location = new System.Drawing.Point(14, 193);
            this.labelText1.Margin = new System.Windows.Forms.Padding(5);
            this.labelText1.Name = "labelText1";
            this.labelText1.Size = new System.Drawing.Size(324, 36);
            this.labelText1.TabIndex = 14;
            // 
            // labelText2
            // 
            this.labelText2._Ancho = 6;
            this.labelText2._Decimales = 0;
            this.labelText2._Etiqueta = "Fecha Vigencia Hasta";
            this.labelText2._MensajeError = null;
            this.labelText2._Nombre_Campo = null;
            this.labelText2._Nombre_Tabla = null;
            this.labelText2._ReadOnly = false;
            this.labelText2._Text = "  /  /";
            this.labelText2._TipoDato = BankApp.Clases.LabelText.TipoDato.fecha;
            this.labelText2._Validable = false;
            this.labelText2.Location = new System.Drawing.Point(14, 239);
            this.labelText2.Margin = new System.Windows.Forms.Padding(5);
            this.labelText2.Name = "labelText2";
            this.labelText2.Size = new System.Drawing.Size(324, 36);
            this.labelText2.TabIndex = 15;
            // 
            // labelText4
            // 
            this.labelText4._Ancho = 10;
            this.labelText4._Decimales = 2;
            this.labelText4._Etiqueta = "Porcentaje";
            this.labelText4._MensajeError = null;
            this.labelText4._Nombre_Campo = null;
            this.labelText4._Nombre_Tabla = null;
            this.labelText4._ReadOnly = false;
            this.labelText4._Text = "       ,";
            this.labelText4._TipoDato = BankApp.Clases.LabelText.TipoDato.numero;
            this.labelText4._Validable = false;
            this.labelText4.Location = new System.Drawing.Point(14, 331);
            this.labelText4.Margin = new System.Windows.Forms.Padding(5);
            this.labelText4.Name = "labelText4";
            this.labelText4.Size = new System.Drawing.Size(324, 36);
            this.labelText4.TabIndex = 17;
            // 
            // labelText5
            // 
            this.labelText5._Ancho = 10;
            this.labelText5._Decimales = 2;
            this.labelText5._Etiqueta = "Monto";
            this.labelText5._MensajeError = null;
            this.labelText5._Nombre_Campo = null;
            this.labelText5._Nombre_Tabla = null;
            this.labelText5._ReadOnly = false;
            this.labelText5._Text = "       ,";
            this.labelText5._TipoDato = BankApp.Clases.LabelText.TipoDato.numero;
            this.labelText5._Validable = false;
            this.labelText5.Location = new System.Drawing.Point(14, 285);
            this.labelText5.Margin = new System.Windows.Forms.Padding(5);
            this.labelText5.Name = "labelText5";
            this.labelText5.Size = new System.Drawing.Size(324, 36);
            this.labelText5.TabIndex = 18;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(96)))), ((int)(((byte)(230)))));
            this.btn_aceptar.Location = new System.Drawing.Point(233, 388);
            this.btn_aceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(153, 43);
            this.btn_aceptar.TabIndex = 21;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            // 
            // Frm_Tarifas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(576, 459);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.labelText5);
            this.Controls.Add(this.labelText4);
            this.Controls.Add(this.labelText2);
            this.Controls.Add(this.labelText1);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Tarifas";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txt_numero, 0);
            this.Controls.SetChildIndex(this.labelText1, 0);
            this.Controls.SetChildIndex(this.labelText2, 0);
            this.Controls.SetChildIndex(this.labelText4, 0);
            this.Controls.SetChildIndex(this.labelText5, 0);
            this.Controls.SetChildIndex(this.pnl_titulo, 0);
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
        public Clases.LabelText txt_numero;
        public Clases.LabelText labelText1;
        public Clases.LabelText labelText2;
        public Clases.LabelText labelText4;
        public Clases.LabelText labelText5;
        public System.Windows.Forms.Button btn_aceptar;
    }
}
