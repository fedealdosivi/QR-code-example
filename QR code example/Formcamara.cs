using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;//necesaria para el bitmap
using System.Linq;
using System.Text;
using System.Windows.Forms;

//Librerias para el uso de la camara web
using AForge.Video;
using AForge.Video.DirectShow;
//libreria para leer imagenes qr
using ZXing.QrCode;
using ZXing;
using ZXing.QrCode.Internal;
using ZXing.Rendering;
using ZXing.Client.Result;
using ZXing.Common.Detector;
using ZXing.Common.ReedSolomon;
using ZXing.Datamatrix.Encoder;
using ZXing.Maxicode.Internal;
using ZXing.Multi.QrCode;
using ZXing.PDF417.Internal;
//using ZXing.Presentation;
using ZXing.Aztec.Internal;
using ZXing.OneD.RSS.Expanded.Decoders;
using ZXing.Datamatrix.Internal;
using ZXing.binazer;

//librerias de qr code// 
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;

namespace QR_code_example
{
    public partial class Formcamara : Form
    {
        public FilterInfoCollection dispositivos;//para buscar los dispositivos
        VideoCaptureDevice video = new VideoCaptureDevice();//El dispositivo que voy a usar
        Bitmap Captura;//La captura a guardar
        string MensajeDescifrado;// el mensaje traducido de la captura

        public Bitmap Captura1
        {
            get { return Captura; }
            set { Captura = value; }
        }

        public Formcamara()
        {
            InitializeComponent();

            try
            {
                //busca en la pc los dispositivos disponibles
                dispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                //Los mete en el Combobox
                foreach (FilterInfo aux in dispositivos)
                {
                    cmboxDispositivos.Items.Add(aux.Name);
                }
                cmboxDispositivos.SelectedIndex = 0;//deja el indice en 0
            }

            catch (Exception ex)
            {
                LabelRTA.Text = ex.Message;
            }
        }

        private void Empezar_Click(object sender, EventArgs e)
        {
            try
            {
                if (video.IsRunning)
                {
                    //Vacia los picture box
                    pictureCaptura.Image = null;
                    pictureCamara.Image = null;
                    pictureCamara.Invalidate();
                    pictureCaptura.Invalidate();
                }
                else
                {
                    //inicializa la camara con el dispositivo que se encuentra seleccionado en el combobox
                    video = new VideoCaptureDevice(dispositivos[cmboxDispositivos.SelectedIndex].MonikerString);

                    //llama al evento que captura la imagen de la camara
                    video.NewFrame += new NewFrameEventHandler(nuevaGrabacion);
                    //empieza la grabacion
                    video.Start();
                }
            }

            catch (Exception ex)
            {
                LabelRTA.Text = ex.Message;
            }
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            video.Stop();
            pictureCamara.Image = null;
            pictureCamara.Invalidate();
        }

        //Evento que clona la imagen de la camara disponible y lo manda al Picture box
        private void nuevaGrabacion(object sender,NewFrameEventArgs eventArgs)
        {
            Bitmap video = (Bitmap)eventArgs.Frame.Clone();
            pictureCamara.Image = video;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form para buscar dispositivos, para usar en vez del FilterInfoCollection
            VideoCaptureDeviceForm formvideo = new VideoCaptureDeviceForm();
            formvideo.ShowDialog();
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            try
            {
                if (video.IsRunning)
                {
                    //Captura el codigo que se esta grabando y lo manda al picture box de captura
                    pictureCaptura.Image = (Bitmap)pictureCamara.Image.Clone();

                    //guarda la captura en una variable aparte
                    Captura = (Bitmap)pictureCaptura.Image;
                }
            }
            catch (Exception ex)
            {
                LabelRTA.Text = ex.Message;
            }
        }


        private string desifrarCaptura()
        {
            try
            {
                BarcodeReader reader = new BarcodeReader
                    (null, newbitmap => new BitmapLuminanceSource(Captura), luminance => new GlobalHistogramBinarizer(luminance));

                reader.AutoRotate = true;
                reader.TryInverted = true;
                reader.Options = new ZXing.Common.DecodingOptions();

                var result = reader.Decode(Captura);

                if (result != null)
                {
                    MensajeDescifrado = result.Text;
                    return MensajeDescifrado;
                }
                else
                {
                    MensajeDescifrado = "No se puede descifrar el codigo";
                    return MensajeDescifrado;
                }
            }
            catch (Exception ex)
            {
                LabelRTA.Text = "No se puede descifrar el Codigo";
            }
        }
        

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
