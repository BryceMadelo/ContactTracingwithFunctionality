using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace ContactTracingwithFunctionality
{
    public partial class QRCode : Form
    {
        public DATABASE Secondform;
        public QRCode()
        {
            InitializeComponent();
        }
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;

        private void QRCode_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                cmbboxDevice.Items.Add(filterInfo.Name);
            cmbboxDevice.SelectedIndex = 0;
            Timer.Start();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[cmbboxDevice.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            picboxQR.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void QRCode_Closing(object sender, FormClosingEventArgs e)
        {
            if (captureDevice.IsRunning)
                captureDevice.Stop();
        }

        private void Timer_Click(object sender, EventArgs e)
        {
            if (picboxQR.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)picboxQR.Image);
                if (result != null)
                {
                    txtboxResult.Text = result.ToString();
                    Timer.Stop();

                    if (captureDevice.IsRunning)
                        captureDevice.Stop();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
