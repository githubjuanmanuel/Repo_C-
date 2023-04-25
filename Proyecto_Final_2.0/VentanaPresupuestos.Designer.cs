namespace Proyecto_Final_2._0
{
    partial class VentanaPresupuestos
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
            this.listViewGastos = new System.Windows.Forms.ListView();
            this.ColumnaGastos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.lblPresupuesto = new System.Windows.Forms.Label();
            this.lblGasto = new System.Windows.Forms.Label();
            this.txtPresupuesto = new System.Windows.Forms.TextBox();
            this.txtGasto = new System.Windows.Forms.TextBox();
            this.btnPresupuesto = new System.Windows.Forms.Button();
            this.btnGasto = new System.Windows.Forms.Button();
            this.lblPresupuestoInicial = new System.Windows.Forms.Label();
            this.lblPresupestoFinal = new System.Windows.Forms.Label();
            this.txtPresupuestoInicial = new System.Windows.Forms.TextBox();
            this.txtPresupuestoFinal = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblModificar = new System.Windows.Forms.Label();
            this.txtModificar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listViewGastos
            // 
            this.listViewGastos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnaGastos});
            this.listViewGastos.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewGastos.FullRowSelect = true;
            this.listViewGastos.HideSelection = false;
            this.listViewGastos.Location = new System.Drawing.Point(299, 12);
            this.listViewGastos.Name = "listViewGastos";
            this.listViewGastos.Size = new System.Drawing.Size(190, 364);
            this.listViewGastos.TabIndex = 0;
            this.listViewGastos.UseCompatibleStateImageBehavior = false;
            this.listViewGastos.View = System.Windows.Forms.View.Details;
            this.listViewGastos.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewGastos_ItemSelectionChanged);
            // 
            // ColumnaGastos
            // 
            this.ColumnaGastos.Text = "Gastos";
            this.ColumnaGastos.Width = 186;
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.Location = new System.Drawing.Point(12, 12);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(148, 31);
            this.lblBienvenido.TabIndex = 1;
            this.lblBienvenido.Text = "Bienvenido";
            // 
            // lblPresupuesto
            // 
            this.lblPresupuesto.AutoSize = true;
            this.lblPresupuesto.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresupuesto.Location = new System.Drawing.Point(66, 113);
            this.lblPresupuesto.Name = "lblPresupuesto";
            this.lblPresupuesto.Size = new System.Drawing.Size(163, 16);
            this.lblPresupuesto.TabIndex = 2;
            this.lblPresupuesto.Text = "Cambiar el  presupuesto:";
            // 
            // lblGasto
            // 
            this.lblGasto.AutoSize = true;
            this.lblGasto.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGasto.Location = new System.Drawing.Point(73, 205);
            this.lblGasto.Name = "lblGasto";
            this.lblGasto.Size = new System.Drawing.Size(142, 16);
            this.lblGasto.TabIndex = 3;
            this.lblGasto.Text = "Ingresar nuevo gasto:";
            // 
            // txtPresupuesto
            // 
            this.txtPresupuesto.Location = new System.Drawing.Point(66, 132);
            this.txtPresupuesto.Name = "txtPresupuesto";
            this.txtPresupuesto.Size = new System.Drawing.Size(155, 20);
            this.txtPresupuesto.TabIndex = 4;
            // 
            // txtGasto
            // 
            this.txtGasto.Location = new System.Drawing.Point(64, 224);
            this.txtGasto.Name = "txtGasto";
            this.txtGasto.Size = new System.Drawing.Size(164, 20);
            this.txtGasto.TabIndex = 5;
            // 
            // btnPresupuesto
            // 
            this.btnPresupuesto.Location = new System.Drawing.Point(64, 158);
            this.btnPresupuesto.Name = "btnPresupuesto";
            this.btnPresupuesto.Size = new System.Drawing.Size(157, 27);
            this.btnPresupuesto.TabIndex = 6;
            this.btnPresupuesto.Text = "Ingresar Nuevo Presupuesto";
            this.btnPresupuesto.UseVisualStyleBackColor = true;
            this.btnPresupuesto.Click += new System.EventHandler(this.btnPresupuesto_Click);
            // 
            // btnGasto
            // 
            this.btnGasto.Location = new System.Drawing.Point(79, 250);
            this.btnGasto.Name = "btnGasto";
            this.btnGasto.Size = new System.Drawing.Size(127, 23);
            this.btnGasto.TabIndex = 7;
            this.btnGasto.Text = "Ingresar Gasto";
            this.btnGasto.UseVisualStyleBackColor = true;
            this.btnGasto.Click += new System.EventHandler(this.btnGasto_Click);
            // 
            // lblPresupuestoInicial
            // 
            this.lblPresupuestoInicial.AutoSize = true;
            this.lblPresupuestoInicial.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresupuestoInicial.Location = new System.Drawing.Point(2, 75);
            this.lblPresupuestoInicial.Name = "lblPresupuestoInicial";
            this.lblPresupuestoInicial.Size = new System.Drawing.Size(133, 18);
            this.lblPresupuestoInicial.TabIndex = 8;
            this.lblPresupuestoInicial.Text = "Presupuesto Inicial";
            // 
            // lblPresupestoFinal
            // 
            this.lblPresupestoFinal.AutoSize = true;
            this.lblPresupestoFinal.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresupestoFinal.Location = new System.Drawing.Point(2, 387);
            this.lblPresupestoFinal.Name = "lblPresupestoFinal";
            this.lblPresupestoFinal.Size = new System.Drawing.Size(125, 18);
            this.lblPresupestoFinal.TabIndex = 9;
            this.lblPresupestoFinal.Text = "Presupuesto Final";
            // 
            // txtPresupuestoInicial
            // 
            this.txtPresupuestoInicial.Location = new System.Drawing.Point(141, 76);
            this.txtPresupuestoInicial.Name = "txtPresupuestoInicial";
            this.txtPresupuestoInicial.Size = new System.Drawing.Size(100, 20);
            this.txtPresupuestoInicial.TabIndex = 10;
            // 
            // txtPresupuestoFinal
            // 
            this.txtPresupuestoFinal.Location = new System.Drawing.Point(133, 388);
            this.txtPresupuestoFinal.Name = "txtPresupuestoFinal";
            this.txtPresupuestoFinal.Size = new System.Drawing.Size(100, 20);
            this.txtPresupuestoFinal.TabIndex = 11;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(110, 336);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 12;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(414, 382);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblModificar
            // 
            this.lblModificar.AutoSize = true;
            this.lblModificar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificar.Location = new System.Drawing.Point(93, 291);
            this.lblModificar.Name = "lblModificar";
            this.lblModificar.Size = new System.Drawing.Size(110, 16);
            this.lblModificar.TabIndex = 14;
            this.lblModificar.Text = "Modificar Gasto";
            // 
            // txtModificar
            // 
            this.txtModificar.Location = new System.Drawing.Point(96, 310);
            this.txtModificar.Name = "txtModificar";
            this.txtModificar.Size = new System.Drawing.Size(100, 20);
            this.txtModificar.TabIndex = 15;
            // 
            // VentanaPresupuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 450);
            this.Controls.Add(this.txtModificar);
            this.Controls.Add(this.lblModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtPresupuestoFinal);
            this.Controls.Add(this.txtPresupuestoInicial);
            this.Controls.Add(this.lblPresupestoFinal);
            this.Controls.Add(this.lblPresupuestoInicial);
            this.Controls.Add(this.btnGasto);
            this.Controls.Add(this.btnPresupuesto);
            this.Controls.Add(this.txtGasto);
            this.Controls.Add(this.txtPresupuesto);
            this.Controls.Add(this.lblGasto);
            this.Controls.Add(this.lblPresupuesto);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.listViewGastos);
            this.Name = "VentanaPresupuestos";
            this.Text = "VentanaPresupuestos";
            this.Load += new System.EventHandler(this.VentanaPresupuestos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewGastos;
        private System.Windows.Forms.ColumnHeader ColumnaGastos;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Label lblPresupuesto;
        private System.Windows.Forms.Label lblGasto;
        private System.Windows.Forms.TextBox txtPresupuesto;
        private System.Windows.Forms.TextBox txtGasto;
        private System.Windows.Forms.Button btnPresupuesto;
        private System.Windows.Forms.Button btnGasto;
        private System.Windows.Forms.Label lblPresupuestoInicial;
        private System.Windows.Forms.Label lblPresupestoFinal;
        private System.Windows.Forms.TextBox txtPresupuestoInicial;
        private System.Windows.Forms.TextBox txtPresupuestoFinal;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblModificar;
        private System.Windows.Forms.TextBox txtModificar;
    }
}