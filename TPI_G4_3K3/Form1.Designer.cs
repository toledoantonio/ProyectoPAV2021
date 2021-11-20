
namespace BankApp
{
    partial class Form1
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
            this.labelText1 = new BankApp.Clases.LabelText();
            this.labelText2 = new BankApp.Clases.LabelText();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(564, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pruebas";
            // 
            // labelText1
            // 
            this.labelText1._Ancho = 10;
            this.labelText1._Decimales = 2;
            this.labelText1._Etiqueta = "Precio";
            this.labelText1._MensajeError = null;
            this.labelText1._Nombre_Campo = null;
            this.labelText1._Nombre_Tabla = null;
            this.labelText1._ReadOnly = false;
            this.labelText1._Text = "       ,";
            this.labelText1._TipoDato = BankApp.Clases.LabelText.TipoDato.numero;
            this.labelText1._Validable = false;
            this.labelText1.Location = new System.Drawing.Point(420, 105);
            this.labelText1.Name = "labelText1";
            this.labelText1.Size = new System.Drawing.Size(254, 29);
            this.labelText1.TabIndex = 1;
            // 
            // labelText2
            // 
            this.labelText2._Ancho = 10;
            this.labelText2._Decimales = 2;
            this.labelText2._Etiqueta = "Fecha";
            this.labelText2._MensajeError = null;
            this.labelText2._Nombre_Campo = null;
            this.labelText2._Nombre_Tabla = null;
            this.labelText2._ReadOnly = false;
            this.labelText2._Text = "  /  /";
            this.labelText2._TipoDato = BankApp.Clases.LabelText.TipoDato.fecha;
            this.labelText2._Validable = false;
            this.labelText2.Location = new System.Drawing.Point(420, 140);
            this.labelText2.Name = "labelText2";
            this.labelText2.Size = new System.Drawing.Size(254, 29);
            this.labelText2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelText2);
            this.Controls.Add(this.labelText1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Clases.LabelText labelText1;
        private Clases.LabelText labelText2;
    }
}

