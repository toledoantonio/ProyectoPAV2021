
namespace BankApp.Formularios.Tipos_de_Operaciones
{
    partial class Frm_ABM_TiposOperaciones
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
            this.grid_tipo_operacion = new BankApp.Clases.Grid01();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.MaskedTextBox();
            this.txt_id = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_alta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_modificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_borrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).BeginInit();
            this.pnl_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_tipo_operacion)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Size = new System.Drawing.Size(417, 32);
            this.lbl_titulo.Text = "ABM TIPOS DE OPERACIONES";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_mostrar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.SetChildIndex(this.button1, 0);
            this.groupBox1.Controls.SetChildIndex(this.label2, 0);
            this.groupBox1.Controls.SetChildIndex(this.txt_id, 0);
            this.groupBox1.Controls.SetChildIndex(this.txt_nombre, 0);
            this.groupBox1.Controls.SetChildIndex(this.label1, 0);
            this.groupBox1.Controls.SetChildIndex(this.btn_mostrar, 0);
            // 
            // button1
            // 
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(96)))), ((int)(((byte)(230)))));
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_alta
            // 
            this.btn_alta.Click += new System.EventHandler(this.btn_alta_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_borrar
            // 
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // grid_tipo_operacion
            // 
            this.grid_tipo_operacion.AllowUserToAddRows = false;
            this.grid_tipo_operacion.BackgroundColor = System.Drawing.Color.White;
            this.grid_tipo_operacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_tipo_operacion.Location = new System.Drawing.Point(13, 266);
            this.grid_tipo_operacion.Name = "grid_tipo_operacion";
            this.grid_tipo_operacion.Size = new System.Drawing.Size(724, 196);
            this.grid_tipo_operacion.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(224, 84);
            this.txt_nombre.Mask = "LLLLLLLLLLLLLLL";
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(156, 30);
            this.txt_nombre.TabIndex = 10;
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(224, 37);
            this.txt_id.Mask = "999";
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(43, 30);
            this.txt_id.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID";
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_mostrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_mostrar.FlatAppearance.BorderSize = 0;
            this.btn_mostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mostrar.Image = global::BankApp.Properties.Resources.icons8_mostrar_propiedad_50__1_;
            this.btn_mostrar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_mostrar.Location = new System.Drawing.Point(6, 93);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(58, 55);
            this.btn_mostrar.TabIndex = 17;
            this.btn_mostrar.UseVisualStyleBackColor = false;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // Frm_ABM_TiposOperaciones
            // 
            this._titulo = "ABM TIPOS DE OPERACIONES";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(749, 535);
            this.Controls.Add(this.grid_tipo_operacion);
            this.Name = "Frm_ABM_TiposOperaciones";
            this.Load += new System.EventHandler(this.Frm_ABM_TiposOperaciones_Load);
            this.Controls.SetChildIndex(this.pnl_titulo, 0);
            this.Controls.SetChildIndex(this.lbl_titulo, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btn_alta, 0);
            this.Controls.SetChildIndex(this.btn_modificar, 0);
            this.Controls.SetChildIndex(this.btn_borrar, 0);
            this.Controls.SetChildIndex(this.grid_tipo_operacion, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_alta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_modificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_borrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).EndInit();
            this.pnl_titulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_tipo_operacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clases.Grid01 grid_tipo_operacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txt_nombre;
        private System.Windows.Forms.MaskedTextBox txt_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_mostrar;
    }
}
