namespace QR_code_example
{
    partial class Formcamara
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
            this.pictureCaptura = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmboxDispositivos = new System.Windows.Forms.ComboBox();
            this.Empezar = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureCamara = new System.Windows.Forms.PictureBox();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.LabelRTA = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCaptura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCamara)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureCaptura
            // 
            this.pictureCaptura.Location = new System.Drawing.Point(344, 55);
            this.pictureCaptura.Name = "pictureCaptura";
            this.pictureCaptura.Size = new System.Drawing.Size(251, 230);
            this.pictureCaptura.TabIndex = 0;
            this.pictureCaptura.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dispositivos:";
            // 
            // cmboxDispositivos
            // 
            this.cmboxDispositivos.FormattingEnabled = true;
            this.cmboxDispositivos.Location = new System.Drawing.Point(175, 11);
            this.cmboxDispositivos.Name = "cmboxDispositivos";
            this.cmboxDispositivos.Size = new System.Drawing.Size(121, 21);
            this.cmboxDispositivos.TabIndex = 2;
            // 
            // Empezar
            // 
            this.Empezar.Location = new System.Drawing.Point(344, 9);
            this.Empezar.Name = "Empezar";
            this.Empezar.Size = new System.Drawing.Size(75, 23);
            this.Empezar.TabIndex = 3;
            this.Empezar.Text = "Empezar";
            this.Empezar.UseVisualStyleBackColor = true;
            this.Empezar.Click += new System.EventHandler(this.Empezar_Click);
            // 
            // btnParar
            // 
            this.btnParar.Location = new System.Drawing.Point(437, 9);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(75, 23);
            this.btnParar.TabIndex = 4;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureCamara
            // 
            this.pictureCamara.Location = new System.Drawing.Point(45, 55);
            this.pictureCamara.Name = "pictureCamara";
            this.pictureCamara.Size = new System.Drawing.Size(251, 230);
            this.pictureCamara.TabIndex = 6;
            this.pictureCamara.TabStop = false;
            // 
            // btnCapturar
            // 
            this.btnCapturar.Location = new System.Drawing.Point(520, 9);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(75, 23);
            this.btnCapturar.TabIndex = 7;
            this.btnCapturar.Text = "Capturar Codigo";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // LabelRTA
            // 
            this.LabelRTA.AutoSize = true;
            this.LabelRTA.Location = new System.Drawing.Point(163, 296);
            this.LabelRTA.Name = "LabelRTA";
            this.LabelRTA.Size = new System.Drawing.Size(0, 13);
            this.LabelRTA.TabIndex = 8;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(486, 296);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(109, 23);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar Y volver";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // Formcamara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 326);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.LabelRTA);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.pictureCamara);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.Empezar);
            this.Controls.Add(this.cmboxDispositivos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureCaptura);
            this.Name = "Formcamara";
            this.Text = "Formcamara";
            ((System.ComponentModel.ISupportInitialize)(this.pictureCaptura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCamara)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureCaptura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmboxDispositivos;
        private System.Windows.Forms.Button Empezar;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureCamara;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.Label LabelRTA;
        private System.Windows.Forms.Button btnAceptar;
    }
}