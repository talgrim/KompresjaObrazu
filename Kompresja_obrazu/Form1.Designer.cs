namespace Kompresja_obrazu
{
    partial class Form1
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
            this.bBrowse = new System.Windows.Forms.Button();
            this.groupBoxInputImage = new System.Windows.Forms.GroupBox();
            this.trackBarJPGQuality = new System.Windows.Forms.TrackBar();
            this.radioPNG = new System.Windows.Forms.RadioButton();
            this.radioBMP = new System.Windows.Forms.RadioButton();
            this.radioGIF = new System.Windows.Forms.RadioButton();
            this.labelJPGQuality = new System.Windows.Forms.Label();
            this.radioJPG = new System.Windows.Forms.RadioButton();
            this.radioTIFF = new System.Windows.Forms.RadioButton();
            this.groupBoxTIFFCompression = new System.Windows.Forms.GroupBox();
            this.radioNone = new System.Windows.Forms.RadioButton();
            this.radioRLE = new System.Windows.Forms.RadioButton();
            this.radioCCITT4 = new System.Windows.Forms.RadioButton();
            this.radioCCITT3 = new System.Windows.Forms.RadioButton();
            this.radioLZW = new System.Windows.Forms.RadioButton();
            this.groupBoxOutputFormat = new System.Windows.Forms.GroupBox();
            this.numericUpDownQuality = new System.Windows.Forms.NumericUpDown();
            this.groupBoxOutputImage = new System.Windows.Forms.GroupBox();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.labelFileCompressionRate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarJPGQuality)).BeginInit();
            this.groupBoxTIFFCompression.SuspendLayout();
            this.groupBoxOutputFormat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuality)).BeginInit();
            this.SuspendLayout();
            // 
            // bBrowse
            // 
            this.bBrowse.Location = new System.Drawing.Point(12, 12);
            this.bBrowse.Name = "bBrowse";
            this.bBrowse.Size = new System.Drawing.Size(75, 23);
            this.bBrowse.TabIndex = 0;
            this.bBrowse.Text = "Przeglądaj...";
            this.bBrowse.UseVisualStyleBackColor = true;
            this.bBrowse.Click += new System.EventHandler(this.bBrowse_Click);
            // 
            // groupBoxInputImage
            // 
            this.groupBoxInputImage.Location = new System.Drawing.Point(10, 41);
            this.groupBoxInputImage.Name = "groupBoxInputImage";
            this.groupBoxInputImage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBoxInputImage.Size = new System.Drawing.Size(530, 551);
            this.groupBoxInputImage.TabIndex = 0;
            this.groupBoxInputImage.TabStop = false;
            this.groupBoxInputImage.Text = "Wybrany obraz";
            // 
            // trackBarJPGQuality
            // 
            this.trackBarJPGQuality.Enabled = false;
            this.trackBarJPGQuality.LargeChange = 20;
            this.trackBarJPGQuality.Location = new System.Drawing.Point(80, 101);
            this.trackBarJPGQuality.Maximum = 100;
            this.trackBarJPGQuality.Minimum = 5;
            this.trackBarJPGQuality.Name = "trackBarJPGQuality";
            this.trackBarJPGQuality.Size = new System.Drawing.Size(104, 45);
            this.trackBarJPGQuality.SmallChange = 5;
            this.trackBarJPGQuality.TabIndex = 6;
            this.trackBarJPGQuality.TickFrequency = 5;
            this.trackBarJPGQuality.Value = 5;
            this.trackBarJPGQuality.Scroll += new System.EventHandler(this.trackBarJPGQuality_Scroll);
            // 
            // radioPNG
            // 
            this.radioPNG.AutoSize = true;
            this.radioPNG.Checked = true;
            this.radioPNG.Location = new System.Drawing.Point(6, 19);
            this.radioPNG.Name = "radioPNG";
            this.radioPNG.Size = new System.Drawing.Size(48, 17);
            this.radioPNG.TabIndex = 2;
            this.radioPNG.TabStop = true;
            this.radioPNG.Text = "PNG";
            this.radioPNG.UseVisualStyleBackColor = true;
            // 
            // radioBMP
            // 
            this.radioBMP.AutoSize = true;
            this.radioBMP.Location = new System.Drawing.Point(6, 42);
            this.radioBMP.Name = "radioBMP";
            this.radioBMP.Size = new System.Drawing.Size(48, 17);
            this.radioBMP.TabIndex = 3;
            this.radioBMP.Text = "BMP";
            this.radioBMP.UseVisualStyleBackColor = true;
            // 
            // radioGIF
            // 
            this.radioGIF.AutoSize = true;
            this.radioGIF.Location = new System.Drawing.Point(6, 65);
            this.radioGIF.Name = "radioGIF";
            this.radioGIF.Size = new System.Drawing.Size(42, 17);
            this.radioGIF.TabIndex = 4;
            this.radioGIF.Text = "GIF";
            this.radioGIF.UseVisualStyleBackColor = true;
            // 
            // labelJPGQuality
            // 
            this.labelJPGQuality.AutoSize = true;
            this.labelJPGQuality.Location = new System.Drawing.Point(101, 85);
            this.labelJPGQuality.Name = "labelJPGQuality";
            this.labelJPGQuality.Size = new System.Drawing.Size(64, 13);
            this.labelJPGQuality.TabIndex = 14;
            this.labelJPGQuality.Text = "Jakość JPG";
            // 
            // radioJPG
            // 
            this.radioJPG.AutoSize = true;
            this.radioJPG.Location = new System.Drawing.Point(6, 101);
            this.radioJPG.Name = "radioJPG";
            this.radioJPG.Size = new System.Drawing.Size(45, 17);
            this.radioJPG.TabIndex = 5;
            this.radioJPG.Text = "JPG";
            this.radioJPG.UseVisualStyleBackColor = true;
            this.radioJPG.CheckedChanged += new System.EventHandler(this.radioJPG_CheckedChanged);
            // 
            // radioTIFF
            // 
            this.radioTIFF.AutoSize = true;
            this.radioTIFF.Location = new System.Drawing.Point(6, 149);
            this.radioTIFF.Name = "radioTIFF";
            this.radioTIFF.Size = new System.Drawing.Size(47, 17);
            this.radioTIFF.TabIndex = 8;
            this.radioTIFF.Text = "TIFF";
            this.radioTIFF.UseVisualStyleBackColor = true;
            this.radioTIFF.CheckedChanged += new System.EventHandler(this.radioTIFF_CheckedChanged);
            // 
            // groupBoxTIFFCompression
            // 
            this.groupBoxTIFFCompression.Controls.Add(this.radioNone);
            this.groupBoxTIFFCompression.Controls.Add(this.radioRLE);
            this.groupBoxTIFFCompression.Controls.Add(this.radioCCITT4);
            this.groupBoxTIFFCompression.Controls.Add(this.radioCCITT3);
            this.groupBoxTIFFCompression.Controls.Add(this.radioLZW);
            this.groupBoxTIFFCompression.Location = new System.Drawing.Point(65, 149);
            this.groupBoxTIFFCompression.Name = "groupBoxTIFFCompression";
            this.groupBoxTIFFCompression.Size = new System.Drawing.Size(143, 145);
            this.groupBoxTIFFCompression.TabIndex = 15;
            this.groupBoxTIFFCompression.TabStop = false;
            this.groupBoxTIFFCompression.Text = "Kompresja TIFF";
            this.groupBoxTIFFCompression.Visible = false;
            // 
            // radioNone
            // 
            this.radioNone.AutoSize = true;
            this.radioNone.Checked = true;
            this.radioNone.Location = new System.Drawing.Point(12, 109);
            this.radioNone.Name = "radioNone";
            this.radioNone.Size = new System.Drawing.Size(47, 17);
            this.radioNone.TabIndex = 13;
            this.radioNone.TabStop = true;
            this.radioNone.Text = "Brak";
            this.radioNone.UseVisualStyleBackColor = true;
            // 
            // radioRLE
            // 
            this.radioRLE.AutoSize = true;
            this.radioRLE.Location = new System.Drawing.Point(12, 86);
            this.radioRLE.Name = "radioRLE";
            this.radioRLE.Size = new System.Drawing.Size(46, 17);
            this.radioRLE.TabIndex = 12;
            this.radioRLE.Text = "RLE";
            this.radioRLE.UseVisualStyleBackColor = true;
            // 
            // radioCCITT4
            // 
            this.radioCCITT4.AutoSize = true;
            this.radioCCITT4.Location = new System.Drawing.Point(12, 63);
            this.radioCCITT4.Name = "radioCCITT4";
            this.radioCCITT4.Size = new System.Drawing.Size(62, 17);
            this.radioCCITT4.TabIndex = 11;
            this.radioCCITT4.Text = "CCITT4";
            this.radioCCITT4.UseVisualStyleBackColor = true;
            // 
            // radioCCITT3
            // 
            this.radioCCITT3.AutoSize = true;
            this.radioCCITT3.Location = new System.Drawing.Point(12, 40);
            this.radioCCITT3.Name = "radioCCITT3";
            this.radioCCITT3.Size = new System.Drawing.Size(62, 17);
            this.radioCCITT3.TabIndex = 10;
            this.radioCCITT3.Text = "CCITT3";
            this.radioCCITT3.UseVisualStyleBackColor = true;
            // 
            // radioLZW
            // 
            this.radioLZW.AutoSize = true;
            this.radioLZW.Location = new System.Drawing.Point(12, 17);
            this.radioLZW.Name = "radioLZW";
            this.radioLZW.Size = new System.Drawing.Size(49, 17);
            this.radioLZW.TabIndex = 9;
            this.radioLZW.Text = "LZW";
            this.radioLZW.UseVisualStyleBackColor = true;
            // 
            // groupBoxOutputFormat
            // 
            this.groupBoxOutputFormat.Controls.Add(this.numericUpDownQuality);
            this.groupBoxOutputFormat.Controls.Add(this.groupBoxTIFFCompression);
            this.groupBoxOutputFormat.Controls.Add(this.radioTIFF);
            this.groupBoxOutputFormat.Controls.Add(this.radioJPG);
            this.groupBoxOutputFormat.Controls.Add(this.labelJPGQuality);
            this.groupBoxOutputFormat.Controls.Add(this.radioGIF);
            this.groupBoxOutputFormat.Controls.Add(this.radioBMP);
            this.groupBoxOutputFormat.Controls.Add(this.radioPNG);
            this.groupBoxOutputFormat.Controls.Add(this.trackBarJPGQuality);
            this.groupBoxOutputFormat.Location = new System.Drawing.Point(546, 41);
            this.groupBoxOutputFormat.Name = "groupBoxOutputFormat";
            this.groupBoxOutputFormat.Size = new System.Drawing.Size(264, 302);
            this.groupBoxOutputFormat.TabIndex = 16;
            this.groupBoxOutputFormat.TabStop = false;
            this.groupBoxOutputFormat.Text = "Format wyjściowy";
            // 
            // numericUpDownQuality
            // 
            this.numericUpDownQuality.Enabled = false;
            this.numericUpDownQuality.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownQuality.Location = new System.Drawing.Point(190, 98);
            this.numericUpDownQuality.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownQuality.Name = "numericUpDownQuality";
            this.numericUpDownQuality.Size = new System.Drawing.Size(43, 20);
            this.numericUpDownQuality.TabIndex = 17;
            this.numericUpDownQuality.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownQuality.ValueChanged += new System.EventHandler(this.numericUpDownQuality_ValueChanged);
            // 
            // groupBoxOutputImage
            // 
            this.groupBoxOutputImage.Location = new System.Drawing.Point(816, 41);
            this.groupBoxOutputImage.Name = "groupBoxOutputImage";
            this.groupBoxOutputImage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBoxOutputImage.Size = new System.Drawing.Size(530, 551);
            this.groupBoxOutputImage.TabIndex = 1;
            this.groupBoxOutputImage.TabStop = false;
            this.groupBoxOutputImage.Text = "Obraz wyjściowy";
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(623, 349);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(75, 23);
            this.buttonConvert.TabIndex = 17;
            this.buttonConvert.Text = "Konwertuj";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // labelFileCompressionRate
            // 
            this.labelFileCompressionRate.AutoSize = true;
            this.labelFileCompressionRate.Location = new System.Drawing.Point(543, 375);
            this.labelFileCompressionRate.Name = "labelFileCompressionRate";
            this.labelFileCompressionRate.Size = new System.Drawing.Size(129, 13);
            this.labelFileCompressionRate.TabIndex = 19;
            this.labelFileCompressionRate.Text = "Stopień kompresji plików: ";
            this.labelFileCompressionRate.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 597);
            this.Controls.Add(this.labelFileCompressionRate);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.groupBoxOutputImage);
            this.Controls.Add(this.groupBoxOutputFormat);
            this.Controls.Add(this.bBrowse);
            this.Controls.Add(this.groupBoxInputImage);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarJPGQuality)).EndInit();
            this.groupBoxTIFFCompression.ResumeLayout(false);
            this.groupBoxTIFFCompression.PerformLayout();
            this.groupBoxOutputFormat.ResumeLayout(false);
            this.groupBoxOutputFormat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuality)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bBrowse;
        private System.Windows.Forms.GroupBox groupBoxInputImage;
        private System.Windows.Forms.TrackBar trackBarJPGQuality;
        private System.Windows.Forms.RadioButton radioPNG;
        private System.Windows.Forms.RadioButton radioBMP;
        private System.Windows.Forms.RadioButton radioGIF;
        private System.Windows.Forms.Label labelJPGQuality;
        private System.Windows.Forms.RadioButton radioJPG;
        private System.Windows.Forms.RadioButton radioTIFF;
        private System.Windows.Forms.GroupBox groupBoxTIFFCompression;
        private System.Windows.Forms.RadioButton radioNone;
        private System.Windows.Forms.RadioButton radioRLE;
        private System.Windows.Forms.RadioButton radioCCITT4;
        private System.Windows.Forms.RadioButton radioCCITT3;
        private System.Windows.Forms.RadioButton radioLZW;
        private System.Windows.Forms.GroupBox groupBoxOutputFormat;
        private System.Windows.Forms.NumericUpDown numericUpDownQuality;
        private System.Windows.Forms.GroupBox groupBoxOutputImage;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Label labelFileCompressionRate;
    }
}

