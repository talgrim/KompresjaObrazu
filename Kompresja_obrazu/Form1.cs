using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kompresja_obrazu
{
    public partial class Form1 : Form
    {
        private string openedFilePath;
        private string savedFilePath;
        private Graphics input;
        private Graphics output;
        private Image inputImage;
        public Form1()
        {
            InitializeComponent();
            input = groupBoxInputImage.CreateGraphics();
            output = groupBoxOutputImage.CreateGraphics();
            groupBoxOutputFormat.Visible = false;
            buttonConvert.Visible = false;
        }

        private void bBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image files |*.png;*.bmp;*.gif;*.jpg;*.tiff";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    inputImage = Image.FromFile(ofd.FileName);
                    input.DrawImage(inputImage, 3, 20);
                    groupBoxOutputFormat.Visible = true;
                    buttonConvert.Visible = true;
                    openedFilePath = ofd.FileName;
                }
            }
        }

        private void radioTIFF_CheckedChanged(object sender, EventArgs e)
        {
            if (radioTIFF.Checked)
                groupBoxTIFFCompression.Visible = true;
            else
                groupBoxTIFFCompression.Visible = false;
        }

        private void radioJPG_CheckedChanged(object sender, EventArgs e)
        {
            if (radioJPG.Checked)
            {
                numericUpDownQuality.Enabled = true;
                trackBarJPGQuality.Enabled = true;
            }
            else
            {
                numericUpDownQuality.Enabled = false;
                trackBarJPGQuality.Enabled = false;
            }
        }

        private void trackBarJPGQuality_Scroll(object sender, EventArgs e)
        {
            numericUpDownQuality.Value = trackBarJPGQuality.Value;
        }

        private void numericUpDownQuality_ValueChanged(object sender, EventArgs e)
        {
            trackBarJPGQuality.Value = (int)numericUpDownQuality.Value;
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            var checkedButton = groupBoxOutputFormat.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            string param = "";
            string format = checkedButton.Text;
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = format + "| *." + format;
                sfd.FileName = "CompressedImage." + format;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    savedFilePath = sfd.FileName;
                    switch (format)
                    {
                        case "PNG":
                            inputImage.Save(sfd.FileName, ImageFormat.Png);
                            break;
                        case "BMP":
                            inputImage.Save(sfd.FileName, ImageFormat.Bmp);
                            break;
                        case "GIF":
                            inputImage.Save(sfd.FileName, ImageFormat.Gif);
                            break;
                        case "JPG":
                            {
                                ImageCodecInfo myImageCodecInfo = GetEncoderInfo("image/jpeg");
                                EncoderParameters myEncoderParamaters = new EncoderParameters(1);
                                myEncoderParamaters.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, (long)trackBarJPGQuality.Value);
                                inputImage.Save(sfd.FileName, myImageCodecInfo, myEncoderParamaters);
                                param = trackBarJPGQuality.Value.ToString();
                                break;
                            }
                        case "TIFF":
                            {
                                ImageCodecInfo myImageCodecInfo = GetEncoderInfo("image/tiff");
                                EncoderParameters myEncoderParamaters = new EncoderParameters(1);
                                var checkedCompressionButton = groupBoxTIFFCompression.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                                switch (checkedCompressionButton.Text)
                                {
                                    case "CCITT3":
                                        myEncoderParamaters.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Compression, (long)EncoderValue.CompressionCCITT3);
                                        break;
                                    case "CCITT4":
                                        myEncoderParamaters.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Compression, (long)EncoderValue.CompressionCCITT4);
                                        break;
                                    case "LZW":
                                        myEncoderParamaters.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Compression, (long)EncoderValue.CompressionLZW);
                                        break;
                                    case "RLE":
                                        myEncoderParamaters.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Compression, (long)EncoderValue.CompressionRle);
                                        break;
                                    case "Brak":
                                        myEncoderParamaters.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Compression, (long)EncoderValue.CompressionNone);
                                        break;
                                }
                                inputImage.Save(sfd.FileName, myImageCodecInfo, myEncoderParamaters);
                                param = checkedCompressionButton.Text;
                                break;
                            }
                    }
                    using (Image outputImage = Image.FromFile(sfd.FileName))
                        output.DrawImage(outputImage, 3, 20);
                    double saved = new FileInfo(savedFilePath).Length;
                    double opened = new FileInfo(openedFilePath).Length;
                    double ratio = saved / opened;
                    labelFileCompressionRate.Visible = true;
                    labelFileCompressionRate.Text = "Stopień kompresji plików: ";
                    labelFileCompressionRate.Text += saved.ToString() + " b / " + opened.ToString() + " b = " + ratio.ToString("0.000");
                }
            }
            //PrintScreen(format,param);
        }

        private static ImageCodecInfo GetEncoderInfo(String mimeType)
        {
            int j;
            ImageCodecInfo[] encoders;
            encoders = ImageCodecInfo.GetImageEncoders();
            for (j = 0; j < encoders.Length; ++j)
            {
                if (encoders[j].MimeType == mimeType)
                    return encoders[j];
            }
            return null;
        }

        private void PrintScreen(string format, string param = "")
        {
            using (Bitmap printscreen = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height))
            {
                using (Graphics graphics = Graphics.FromImage(printscreen as Image))
                {
                    graphics.CopyFromScreen(0, 0, 0, 0, printscreen.Size);
                    string folder = Path.GetFileName(openedFilePath);
                    string filename = format + param;
                    printscreen.Save(@"C:\Saves\" + folder + "\\" + filename + ".jpg", ImageFormat.Jpeg);
                }
            }

        }
    }
}
