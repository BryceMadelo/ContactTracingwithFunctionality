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
            
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[cmbboxDevice.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            Timer.Start();
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
                    var QRData = result.Text.Split(new char[] { '\n', ',' });
                    if(QRData.Length == 15)
                       TxtBoxNm.Text = QRData[0];
                       TxtboxAge.Text = QRData[1];
                       cmbboxSex.Text = QRData[2];
                    DDateofVisit.Text = QRData[3];
                    TxtboxPhNum.Text = QRData[4];
                    TxtboxAdd.Text = QRData[5];
                    cmbboxCough.Text = QRData[6];
                    cmbboxFever.Text = QRData[7];
                    cmbboxSore.Text = QRData[8];
                    cmbboxRunny.Text = QRData[9];
                    cmbboxLoss.Text = QRData[10];
                    cmbboxDiff.Text = QRData[11];
                    cmbboxContact.Text = QRData[12];
                    cmbboxTraveled.Text = QRData[13];
                    cmbboxVaxx.Text = QRData[14];

                    Timer.Stop();

                    if (captureDevice.IsRunning)
                        captureDevice.Stop();
                }
            }
        }

        private void btnSavenSub_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@".\KonohaVisits.txt", true);
            //Personal Information Section
            file.Write("Name: " + TxtBoxNm.Text);
            file.Write("Age: " + TxtboxAge.Text);
            file.Write("Sex: " + cmbboxSex.Text);
            file.Write("Phone #: " + TxtboxPhNum.Text);
            file.Write("Address: " + TxtboxAdd.Text);
            file.Write("Date of Visit: " + DDateofVisit.Value.ToString("MM/dd/yyyy"));

            //Health Information Section
            file.Write("Cough: " + cmbboxCough.Text);
            file.Write("Fever: " + cmbboxFever.Text);
            file.Write("Soar Throat: " + cmbboxSore.Text);
            file.Write("Runny Nose: " + cmbboxRunny.Text);
            file.Write("Loss of taste or smell: " + cmbboxLoss.Text);
            file.Write("Diffculty breathing: " + cmbboxDiff.Text);
            file.Write("Have you been in close contact with a Covid - 19 case?: " + cmbboxContact.Text);
            file.Write("Have you traveled outside the country in the last 14 days?: " + cmbboxTraveled.Text);
            file.Write("Have you received vaccine doses?: " + cmbboxVaxx.Text);

            file.WriteLine();
            file.Close();

            TxtBoxNm.Text = "";
            TxtboxAge.Text = "";
            cmbboxSex.Text = "";
            TxtboxPhNum.Text = "";
            TxtboxAdd.Text = "";
            DDateofVisit.ResetText();

            cmbboxCough.Text = "";
            cmbboxFever.Text = "";
            cmbboxSore.Text = "";
            cmbboxRunny.Text = "";
            cmbboxLoss.Text = "";
            cmbboxDiff.Text = "";
            cmbboxContact.Text = "";
            cmbboxTraveled.Text = "";
            cmbboxVaxx.Text = "";
        }
    }
}
