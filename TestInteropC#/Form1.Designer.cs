namespace TestInteropC_
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblTextoxd = new System.Windows.Forms.Label();
            this.btnexcel = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 22);
            this.textBox1.TabIndex = 1;
            // 
            // lblTextoxd
            // 
            this.lblTextoxd.AutoSize = true;
            this.lblTextoxd.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoxd.Location = new System.Drawing.Point(25, 39);
            this.lblTextoxd.Name = "lblTextoxd";
            this.lblTextoxd.Size = new System.Drawing.Size(201, 24);
            this.lblTextoxd.TabIndex = 3;
            this.lblTextoxd.Text = "Generador de Formato";
            // 
            // btnexcel
            // 
            this.btnexcel.BackColor = System.Drawing.Color.Transparent;
            this.btnexcel.BackgroundImage = global::TestInteropC_.Properties.Resources.Exce;
            this.btnexcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnexcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexcel.ForeColor = System.Drawing.Color.Transparent;
            this.btnexcel.Location = new System.Drawing.Point(128, 151);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(63, 53);
            this.btnexcel.TabIndex = 2;
            this.btnexcel.UseVisualStyleBackColor = false;
            this.btnexcel.Click += new System.EventHandler(this.btnexcel_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.Transparent;
            this.btnguardar.BackgroundImage = global::TestInteropC_.Properties.Resources.Word;
            this.btnguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.ForeColor = System.Drawing.Color.Transparent;
            this.btnguardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnguardar.Location = new System.Drawing.Point(38, 151);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(60, 53);
            this.btnguardar.TabIndex = 0;
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(263, 233);
            this.Controls.Add(this.lblTextoxd);
            this.Controls.Add(this.btnexcel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnguardar);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "TestInteropC#";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnexcel;
        private System.Windows.Forms.Label lblTextoxd;
    }
}

