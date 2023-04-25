namespace Proyecto_Final_2._0
{
    partial class Registro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.Titulo = new System.Windows.Forms.Label();
            this.TituloUsuario = new System.Windows.Forms.Label();
            this.TituloContrasena = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtIngresaPresupuesto = new System.Windows.Forms.TextBox();
            this.tituloIngresaPresupuesto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.BackColor = System.Drawing.Color.Red;
            this.btnRegistrarse.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarse.Location = new System.Drawing.Point(116, 368);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(174, 51);
            this.btnRegistrarse.TabIndex = 0;
            this.btnRegistrarse.Text = "Registrase";
            this.btnRegistrarse.UseVisualStyleBackColor = false;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(129, 9);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(132, 36);
            this.Titulo.TabIndex = 1;
            this.Titulo.Text = "Registro";
            // 
            // TituloUsuario
            // 
            this.TituloUsuario.AutoSize = true;
            this.TituloUsuario.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloUsuario.Location = new System.Drawing.Point(48, 96);
            this.TituloUsuario.Name = "TituloUsuario";
            this.TituloUsuario.Size = new System.Drawing.Size(139, 23);
            this.TituloUsuario.TabIndex = 2;
            this.TituloUsuario.Text = "Crea tu usuario";
            // 
            // TituloContrasena
            // 
            this.TituloContrasena.AutoSize = true;
            this.TituloContrasena.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloContrasena.Location = new System.Drawing.Point(48, 184);
            this.TituloContrasena.Name = "TituloContrasena";
            this.TituloContrasena.Size = new System.Drawing.Size(166, 23);
            this.TituloContrasena.TabIndex = 3;
            this.TituloContrasena.Text = "Crea tu contraseña";
            // 
            // txtContrasena
            // 
            this.txtContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.Location = new System.Drawing.Point(52, 210);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(160, 26);
            this.txtContrasena.TabIndex = 4;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(52, 122);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(160, 26);
            this.txtUsuario.TabIndex = 5;
            // 
            // txtIngresaPresupuesto
            // 
            this.txtIngresaPresupuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngresaPresupuesto.Location = new System.Drawing.Point(52, 300);
            this.txtIngresaPresupuesto.Name = "txtIngresaPresupuesto";
            this.txtIngresaPresupuesto.Size = new System.Drawing.Size(160, 26);
            this.txtIngresaPresupuesto.TabIndex = 7;
            // 
            // tituloIngresaPresupuesto
            // 
            this.tituloIngresaPresupuesto.AutoSize = true;
            this.tituloIngresaPresupuesto.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloIngresaPresupuesto.Location = new System.Drawing.Point(48, 274);
            this.tituloIngresaPresupuesto.Name = "tituloIngresaPresupuesto";
            this.tituloIngresaPresupuesto.Size = new System.Drawing.Size(201, 23);
            this.tituloIngresaPresupuesto.TabIndex = 6;
            this.tituloIngresaPresupuesto.Text = "Ingresa tu presupuesto";
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 450);
            this.Controls.Add(this.txtIngresaPresupuesto);
            this.Controls.Add(this.tituloIngresaPresupuesto);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.TituloContrasena);
            this.Controls.Add(this.TituloUsuario);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.btnRegistrarse);
            this.Name = "Registro";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label TituloUsuario;
        private System.Windows.Forms.Label TituloContrasena;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtIngresaPresupuesto;
        private System.Windows.Forms.Label tituloIngresaPresupuesto;
    }
}