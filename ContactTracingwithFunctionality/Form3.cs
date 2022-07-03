using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video.DirectShow;
using ZXing;

namespace ContactTracingwithFunctionality
{
    public partial class QRScanner : Form
    {
        public DATABASE SecondForm;
        public QRScanner()
        {
            InitializeComponent();
        }

        private FilterInfoCollection filterInfoCollection;
        private VideoCaptureDevice captureDevice;

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QRScanner_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                cmbboxDevice.Items.Add(filterInfo.Name);
            cmbboxDevice.SelectedIndex = 0;
            Timer.Start();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[cmbboxDevice.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
        }

        private void CaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            picboxQR.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void QRScanner_Closing(object sender, FormClosingEventArgs e)
        {
            if (captureDevice != null)
                captureDevice.Stop();
        }
        private void Timer_Tick(object sender, EventArgs e)
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
    }
}
