namespace QR_code_example
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureCODE = new System.Windows.Forms.PictureBox();
            this.URL = new System.Windows.Forms.Label();
            this.txbURL = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnGuardian = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnExtraer = new System.Windows.Forms.Button();
            this.btnCapturar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCODE)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureCODE
            // 
            this.pictureCODE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureCODE.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureCODE.Location = new System.Drawing.Point(12, 1);
            this.pictureCODE.Name = "pictureCODE";
            this.pictureCODE.Size = new System.Drawing.Size(286, 246);
            this.pictureCODE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureCODE.TabIndex = 0;
            this.pictureCODE.TabStop = false;
            // 
            // URL
            // 
            this.URL.AutoSize = true;
            this.URL.Location = new System.Drawing.Point(12, 265);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(29, 13);
            this.URL.TabIndex = 1;
            this.URL.Text = "URL";
            // 
            // txbURL
            // 
            this.txbURL.Location = new System.Drawing.Point(47, 262);
            this.txbURL.Name = "txbURL";
            this.txbURL.Size = new System.Drawing.Size(251, 20);
            this.txbURL.TabIndex = 2;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(15, 288);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(283, 23);
            this.btnCrear.TabIndex = 3;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnGuardian
            // 
            this.btnGuardian.Location = new System.Drawing.Point(15, 317);
            this.btnGuardian.Name = "btnGuardian";
            this.btnGuardian.Size = new System.Drawing.Size(283, 23);
            this.btnGuardian.TabIndex = 4;
            this.btnGuardian.Text = "Guardar QR";
            this.btnGuardian.UseVisualStyleBackColor = true;
            this.btnGuardian.Click += new System.EventHandler(this.btnGuardian_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(15, 346);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(133, 23);
            this.btnCargar.TabIndex = 5;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnExtraer
            // 
            this.btnExtraer.Location = new System.Drawing.Point(154, 346);
            this.btnExtraer.Name = "btnExtraer";
            this.btnExtraer.Size = new System.Drawing.Size(144, 23);
            this.btnExtraer.TabIndex = 6;
            this.btnExtraer.Text = "Extraer";
            this.btnExtraer.UseVisualStyleBackColor = true;
            this.btnExtraer.Click += new System.EventHandler(this.btnExtraer_Click);
            // 
            // btnCapturar
            // 
            this.btnCapturar.Location = new System.Drawing.Point(304, 12);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(75, 23);
            this.btnCapturar.TabIndex = 7;
            this.btnCapturar.Text = "Capturar QR";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 376);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.btnExtraer);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnGuardian);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txbURL);
            this.Controls.Add(this.URL);
            this.Controls.Add(this.pictureCODE);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureCODE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureCODE;
        private System.Windows.Forms.Label URL;
        private System.Windows.Forms.TextBox txbURL;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnGuardian;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnExtraer;
        private System.Windows.Forms.Button btnCapturar;
    }
}

