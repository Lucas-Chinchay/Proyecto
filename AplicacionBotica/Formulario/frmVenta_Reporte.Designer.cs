namespace AplicacionBotica.Formulario
{
    partial class frmVenta_Reporte
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
            this.components = new System.ComponentModel.Container();
            this.lstvReporte = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.dtpFecha_De = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dtpFecha_Hasta = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SuspendLayout();
            // 
            // lstvReporte
            // 
            this.lstvReporte.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader7,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader8});
            this.lstvReporte.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstvReporte.FullRowSelect = true;
            this.lstvReporte.GridLines = true;
            this.lstvReporte.Location = new System.Drawing.Point(16, 104);
            this.lstvReporte.Name = "lstvReporte";
            this.lstvReporte.Size = new System.Drawing.Size(901, 228);
            this.lstvReporte.TabIndex = 0;
            this.lstvReporte.UseCompatibleStateImageBehavior = false;
            this.lstvReporte.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "N°";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "DNI (Vendedor)";
            this.columnHeader2.Width = 135;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nomdres y Apellidos";
            this.columnHeader3.Width = 143;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Producto";
            this.columnHeader7.Width = 103;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Cant.";
            this.columnHeader4.Width = 61;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "P. Unit.";
            this.columnHeader5.Width = 76;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Sub Total";
            this.columnHeader6.Width = 102;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Fecha Venta";
            this.columnHeader8.Width = 250;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "De";
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.Green;
            this.btnMostrar.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMostrar.Location = new System.Drawing.Point(752, 26);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(129, 46);
            this.btnMostrar.TabIndex = 45;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // dtpFecha_De
            // 
            this.dtpFecha_De.BackColor = System.Drawing.Color.SeaGreen;
            this.dtpFecha_De.BorderRadius = 0;
            this.dtpFecha_De.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha_De.ForeColor = System.Drawing.Color.White;
            this.dtpFecha_De.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpFecha_De.FormatCustom = null;
            this.dtpFecha_De.Location = new System.Drawing.Point(49, 26);
            this.dtpFecha_De.Margin = new System.Windows.Forms.Padding(5);
            this.dtpFecha_De.Name = "dtpFecha_De";
            this.dtpFecha_De.Size = new System.Drawing.Size(288, 35);
            this.dtpFecha_De.TabIndex = 46;
            this.dtpFecha_De.Value = new System.DateTime(2018, 3, 20, 0, 44, 23, 254);
            // 
            // dtpFecha_Hasta
            // 
            this.dtpFecha_Hasta.BackColor = System.Drawing.Color.SeaGreen;
            this.dtpFecha_Hasta.BorderRadius = 0;
            this.dtpFecha_Hasta.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha_Hasta.ForeColor = System.Drawing.Color.White;
            this.dtpFecha_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpFecha_Hasta.FormatCustom = null;
            this.dtpFecha_Hasta.Location = new System.Drawing.Point(426, 26);
            this.dtpFecha_Hasta.Margin = new System.Windows.Forms.Padding(8);
            this.dtpFecha_Hasta.Name = "dtpFecha_Hasta";
            this.dtpFecha_Hasta.Size = new System.Drawing.Size(285, 35);
            this.dtpFecha_Hasta.TabIndex = 47;
            this.dtpFecha_Hasta.Value = new System.DateTime(2018, 3, 20, 0, 44, 23, 254);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(362, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "Hasta";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Location = new System.Drawing.Point(752, 338);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(129, 46);
            this.btnCancelar.TabIndex = 49;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // frmVenta_Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(939, 407);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFecha_Hasta);
            this.Controls.Add(this.dtpFecha_De);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstvReporte);
            this.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmVenta_Reporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmVenta_Reporte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstvReporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMostrar;
        private Bunifu.Framework.UI.BunifuDatepicker dtpFecha_De;
        private Bunifu.Framework.UI.BunifuDatepicker dtpFecha_Hasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}