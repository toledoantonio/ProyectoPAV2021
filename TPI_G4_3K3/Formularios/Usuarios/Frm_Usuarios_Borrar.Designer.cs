
namespace BankApp.Formularios.Usuarios
{
    partial class Frm_Usuarios_Borrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Usuarios_Borrar));
            this.pnl_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(194, 29);
            this.label1.Text = "Borrar Usuarios";
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            // 
            // txt_nombre_usuario
            // 
            this.txt_nombre_usuario.Enabled = false;
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Enabled = false;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Enabled = false;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Enabled = false;
            // 
            // cmb_tipo_doc
            // 
            this.cmb_tipo_doc.DisplayMember = "descripcion";
            this.cmb_tipo_doc.Enabled = false;
            this.cmb_tipo_doc.ValueMember = "id";
            // 
            // txt_nro_doc
            // 
            this.txt_nro_doc.Enabled = false;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Text = "Borrar";
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // Frm_Usuarios_Borrar
            // 
            this._Titulo = "Borrar Usuarios";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(431, 418);
            this.Name = "Frm_Usuarios_Borrar";
            this.Load += new System.EventHandler(this.Frm_Usuarios_Borrar_Load);
            this.pnl_titulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
