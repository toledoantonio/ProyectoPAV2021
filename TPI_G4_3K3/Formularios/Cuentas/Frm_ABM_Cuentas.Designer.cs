
using System;

namespace BankApp.Formularios
{
    partial class Frm_ABM_Cuentas
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
            this.txt_patron = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_id_usuario = new System.Windows.Forms.RadioButton();
            this.rb_numero_cuenta = new System.Windows.Forms.RadioButton();
            this.grid_cuentas = new BankApp.Clases.Grid01();
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
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_cuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_titulo.Size = new System.Drawing.Size(216, 32);
            this.lbl_titulo.Text = "ABM CUENTAS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_mostrar);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txt_patron);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            this.groupBox1.Controls.SetChildIndex(this.button1, 0);
            this.groupBox1.Controls.SetChildIndex(this.label1, 0);
            this.groupBox1.Controls.SetChildIndex(this.txt_patron, 0);
            this.groupBox1.Controls.SetChildIndex(this.groupBox2, 0);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Patrón de Búsqueda";
            // 
            // txt_patron
            // 
            this.txt_patron.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patron.Location = new System.Drawing.Point(251, 44);
            this.txt_patron.Mask = "99";
            this.txt_patron.Name = "txt_patron";
            this.txt_patron.Size = new System.Drawing.Size(29, 30);
            this.txt_patron.TabIndex = 3;
            this.txt_patron.ValidatingType = typeof(int);
            this.txt_patron.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txt_patron_MaskInputRejected);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_id_usuario);
            this.groupBox2.Controls.Add(this.rb_numero_cuenta);
            this.groupBox2.Location = new System.Drawing.Point(392, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 69);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros";
            // 
            // rb_id_usuario
            // 
            this.rb_id_usuario.AutoSize = true;
            this.rb_id_usuario.Location = new System.Drawing.Point(7, 46);
            this.rb_id_usuario.Name = "rb_id_usuario";
            this.rb_id_usuario.Size = new System.Drawing.Size(75, 18);
            this.rb_id_usuario.TabIndex = 1;
            this.rb_id_usuario.TabStop = true;
            this.rb_id_usuario.Text = "id_usuario";
            this.rb_id_usuario.UseVisualStyleBackColor = true;
            // 
            // rb_numero_cuenta
            // 
            this.rb_numero_cuenta.AutoSize = true;
            this.rb_numero_cuenta.Location = new System.Drawing.Point(7, 21);
            this.rb_numero_cuenta.Name = "rb_numero_cuenta";
            this.rb_numero_cuenta.Size = new System.Drawing.Size(61, 18);
            this.rb_numero_cuenta.TabIndex = 0;
            this.rb_numero_cuenta.TabStop = true;
            this.rb_numero_cuenta.Text = "numero";
            this.rb_numero_cuenta.UseVisualStyleBackColor = true;
            this.rb_numero_cuenta.CheckedChanged += new System.EventHandler(this.rb_nombre_usuario_CheckedChanged);
            // 
            // grid_cuentas
            // 
            this.grid_cuentas.AllowUserToAddRows = false;
            this.grid_cuentas.BackgroundColor = System.Drawing.Color.White;
            this.grid_cuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_cuentas.Location = new System.Drawing.Point(12, 266);
            this.grid_cuentas.Name = "grid_cuentas";
            this.grid_cuentas.RowHeadersWidth = 51;
            this.grid_cuentas.Size = new System.Drawing.Size(725, 197);
            this.grid_cuentas.TabIndex = 17;
            this.grid_cuentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_usuarios_CellContentClick);
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_mostrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_mostrar.FlatAppearance.BorderSize = 0;
            this.btn_mostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mostrar.Image = global::BankApp.Properties.Resources.icons8_mostrar_propiedad_50__1_;
            this.btn_mostrar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_mostrar.Location = new System.Drawing.Point(0, 93);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(58, 55);
            this.btn_mostrar.TabIndex = 18;
            this.btn_mostrar.UseVisualStyleBackColor = false;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // Frm_ABM_Cuentas
            // 
            this._titulo = "ABM CUENTAS";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(749, 535);
            this.Controls.Add(this.grid_cuentas);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_ABM_Cuentas";
            this.Load += new System.EventHandler(this.Frm_ABM_Cuentas_Load);
            this.Controls.SetChildIndex(this.pnl_titulo, 0);
            this.Controls.SetChildIndex(this.lbl_titulo, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btn_alta, 0);
            this.Controls.SetChildIndex(this.btn_modificar, 0);
            this.Controls.SetChildIndex(this.btn_borrar, 0);
            this.Controls.SetChildIndex(this.grid_cuentas, 0);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_cuentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Frm_ABM_Cuentas_Load_1(object sender, EventArgs e)
        {

        }

        private void lbl_titulo_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txt_patron;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_id_usuario;
        private System.Windows.Forms.RadioButton rb_numero_cuenta;
        private Clases.Grid01 grid_cuentas;
        private System.Windows.Forms.Button btn_mostrar;
    }
}
