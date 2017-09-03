using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using AForge.Video;


namespace QR_code_example
{
    public partial class Form1 : Form
    {
        Formcamara formCamaraWeb;

        public Form1()
        {
            InitializeComponent();
            formCamaraWeb = new Formcamara();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string url = txbURL.Text;
            QRCodeEncoder enconder = new QRCodeEncoder();
            Bitmap qrcode = enconder.Encode(url);
            pictureCODE.Image = qrcode as Image;
        }

        private void btnGuardian_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.Filter = "PNG|*.png|JPEG|*.jpg|GIF|*gif";

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                pictureCODE.Image.Save(guardar.FileName);
                MessageBox.Show("guardadito");
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog traer = new OpenFileDialog();
            traer.Filter = "PNG|*.png|JPEG|*.jpg|GIF|*gif";

            if (traer.ShowDialog() == DialogResult.OK)
            {
                pictureCODE.ImageLocation = traer.FileName;
            }
        }

        private void btnExtraer_Click(object sender, EventArgs e)
        {
            QRCodeDecoder decodificador = new QRCodeDecoder();
            MessageBox.Show(decodificador.Decode(new QRCodeBitmapImage(pictureCODE.Image as Bitmap)));
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            Bitmap imagenTraida;

            if (formCamaraWeb.ShowDialog() == DialogResult.OK)
            {
                imagenTraida = formCamaraWeb.Captura1;

                if (imagenTraida == null)
                {
                    MessageBox.Show("Tiene que capturar una imagen para que ande");
                }
                else
                {
                    pictureCODE.Image = imagenTraida as Image;
                    QRCodeDecoder decodificador = new QRCodeDecoder();
                    MessageBox.Show(decodificador.Decode(new QRCodeBitmapImage(pictureCODE.Image as Bitmap)));
                }
            }
        }

        
    }
}
