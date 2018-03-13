namespace AplicacionBotica.Formulario
{
    partial class frmProducto_Registrar
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
            this.txtPrecioBase = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtP_Descripcion = new System.Windows.Forms.TextBox();
            this.btnP_Registrar = new System.Windows.Forms.Button();
            this.cmbP_Presentacion = new System.Windows.Forms.ComboBox();
            this.cmbP_Categoria = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelStock = new System.Windows.Forms.Label();
            this.nudP_S_Actual = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudP_S_Minimo = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudP_PreAdquirido = new System.Windows.Forms.NumericUpDown();
            this.txtP_Nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevo_Categoria = new System.Windows.Forms.Button();
            this.btnNuevo_Presentacion = new System.Windows.Forms.Button();
            this.panelFormulario = new System.Windows.Forms.Panel();
            this.btnAtras = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudP_S_Actual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudP_S_Minimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudP_PreAdquirido)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPrecioBase
            // 
            this.txtPrecioBase.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioBase.Location = new System.Drawing.Point(188, 149);
            this.txtPrecioBase.Name = "txtPrecioBase";
            this.txtPrecioBase.Size = new System.Drawing.Size(108, 27);
            this.txtPrecioBase.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 58;
            this.label5.Text = "Precio Base";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Baskerville Old Face", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 58);
            this.panel1.TabIndex = 57;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Font = new System.Drawing.Font("Century Schoolbook", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label8.Location = new System.Drawing.Point(310, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(295, 38);
            this.label8.TabIndex = 19;
            this.label8.Text = "Registrar Producto";
            // 
            // txtP_Descripcion
            // 
            this.txtP_Descripcion.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtP_Descripcion.Location = new System.Drawing.Point(188, 225);
            this.txtP_Descripcion.Multiline = true;
            this.txtP_Descripcion.Name = "txtP_Descripcion";
            this.txtP_Descripcion.Size = new System.Drawing.Size(210, 74);
            this.txtP_Descripcion.TabIndex = 3;
            // 
            // btnP_Registrar
            // 
            this.btnP_Registrar.BackColor = System.Drawing.Color.Green;
            this.btnP_Registrar.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnP_Registrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnP_Registrar.Location = new System.Drawing.Point(259, 467);
            this.btnP_Registrar.Name = "btnP_Registrar";
            this.btnP_Registrar.Size = new System.Drawing.Size(129, 46);
            this.btnP_Registrar.TabIndex = 10;
            this.btnP_Registrar.Text = "Registrar";
            this.btnP_Registrar.UseVisualStyleBackColor = false;
            this.btnP_Registrar.Click += new System.EventHandler(this.btnP_Registrar_Click);
            // 
            // cmbP_Presentacion
            // 
            this.cmbP_Presentacion.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbP_Presentacion.FormattingEnabled = true;
            this.cmbP_Presentacion.Location = new System.Drawing.Point(188, 433);
            this.cmbP_Presentacion.Name = "cmbP_Presentacion";
            this.cmbP_Presentacion.Size = new System.Drawing.Size(210, 28);
            this.cmbP_Presentacion.TabIndex = 8;
            // 
            // cmbP_Categoria
            // 
            this.cmbP_Categoria.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbP_Categoria.FormattingEnabled = true;
            this.cmbP_Categoria.Location = new System.Drawing.Point(188, 389);
            this.cmbP_Categoria.Name = "cmbP_Categoria";
            this.cmbP_Categoria.Size = new System.Drawing.Size(210, 28);
            this.cmbP_Categoria.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 429);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 52;
            this.label6.Text = "Presentacion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 389);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 51;
            this.label7.Text = "Categoria";
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelStock.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStock.Location = new System.Drawing.Point(52, 348);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(102, 20);
            this.labelStock.TabIndex = 50;
            this.labelStock.Text = "Stock Actual";
            // 
            // nudP_S_Actual
            // 
            this.nudP_S_Actual.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudP_S_Actual.Location = new System.Drawing.Point(188, 348);
            this.nudP_S_Actual.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudP_S_Actual.Name = "nudP_S_Actual";
            this.nudP_S_Actual.Size = new System.Drawing.Size(108, 27);
            this.nudP_S_Actual.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 48;
            this.label4.Text = "Stock Minimo";
            // 
            // nudP_S_Minimo
            // 
            this.nudP_S_Minimo.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudP_S_Minimo.Location = new System.Drawing.Point(188, 306);
            this.nudP_S_Minimo.Name = "nudP_S_Minimo";
            this.nudP_S_Minimo.Size = new System.Drawing.Size(108, 27);
            this.nudP_S_Minimo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Precio Adquirido";
            // 
            // nudP_PreAdquirido
            // 
            this.nudP_PreAdquirido.DecimalPlaces = 2;
            this.nudP_PreAdquirido.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudP_PreAdquirido.Location = new System.Drawing.Point(188, 192);
            this.nudP_PreAdquirido.Name = "nudP_PreAdquirido";
            this.nudP_PreAdquirido.Size = new System.Drawing.Size(108, 27);
            this.nudP_PreAdquirido.TabIndex = 2;
            // 
            // txtP_Nombre
            // 
            this.txtP_Nombre.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtP_Nombre.Location = new System.Drawing.Point(126, 101);
            this.txtP_Nombre.Name = "txtP_Nombre";
            this.txtP_Nombre.Size = new System.Drawing.Size(240, 27);
            this.txtP_Nombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "Nombre";
            // 
            // btnNuevo_Categoria
            // 
            this.btnNuevo_Categoria.BackColor = System.Drawing.Color.Green;
            this.btnNuevo_Categoria.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo_Categoria.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNuevo_Categoria.Location = new System.Drawing.Point(404, 386);
            this.btnNuevo_Categoria.Name = "btnNuevo_Categoria";
            this.btnNuevo_Categoria.Size = new System.Drawing.Size(83, 37);
            this.btnNuevo_Categoria.TabIndex = 7;
            this.btnNuevo_Categoria.Text = "Registrar";
            this.btnNuevo_Categoria.UseVisualStyleBackColor = false;
            this.btnNuevo_Categoria.Click += new System.EventHandler(this.btnNuevo_Categoria_Click);
            // 
            // btnNuevo_Presentacion
            // 
            this.btnNuevo_Presentacion.BackColor = System.Drawing.Color.Green;
            this.btnNuevo_Presentacion.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo_Presentacion.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNuevo_Presentacion.Location = new System.Drawing.Point(404, 429);
            this.btnNuevo_Presentacion.Name = "btnNuevo_Presentacion";
            this.btnNuevo_Presentacion.Size = new System.Drawing.Size(83, 37);
            this.btnNuevo_Presentacion.TabIndex = 9;
            this.btnNuevo_Presentacion.Text = "Registrar";
            this.btnNuevo_Presentacion.UseVisualStyleBackColor = false;
            this.btnNuevo_Presentacion.Click += new System.EventHandler(this.btnNuevo_Presentacion_Click);
            // 
            // panelFormulario
            // 
            this.panelFormulario.AutoSize = true;
            this.panelFormulario.Location = new System.Drawing.Point(866, 531);
            this.panelFormulario.Name = "panelFormulario";
            this.panelFormulario.Size = new System.Drawing.Size(32, 23);
            this.panelFormulario.TabIndex = 59;
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(12, 493);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(88, 50);
            this.btnAtras.TabIndex = 60;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // frmProducto_Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 555);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.panelFormulario);
            this.Controls.Add(this.btnNuevo_Presentacion);
            this.Controls.Add(this.btnNuevo_Categoria);
            this.Controls.Add(this.txtPrecioBase);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtP_Descripcion);
            this.Controls.Add(this.btnP_Registrar);
            this.Controls.Add(this.cmbP_Presentacion);
            this.Controls.Add(this.cmbP_Categoria);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelStock);
            this.Controls.Add(this.nudP_S_Actual);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudP_S_Minimo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudP_PreAdquirido);
            this.Controls.Add(this.txtP_Nombre);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProducto_Registrar";
            this.Text = "frmProducto_Registrar";
            this.Load += new System.EventHandler(this.frmProducto_Registrar_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudP_S_Actual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudP_S_Minimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudP_PreAdquirido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrecioBase;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtP_Descripcion;
        private System.Windows.Forms.Button btnP_Registrar;
        private System.Windows.Forms.ComboBox cmbP_Presentacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.NumericUpDown nudP_S_Actual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudP_S_Minimo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudP_PreAdquirido;
        private System.Windows.Forms.TextBox txtP_Nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNuevo_Categoria;
        private System.Windows.Forms.Button btnNuevo_Presentacion;
        private System.Windows.Forms.ComboBox cmbP_Categoria;
        private System.Windows.Forms.Panel panelFormulario;
        private System.Windows.Forms.Button btnAtras;
    }
}