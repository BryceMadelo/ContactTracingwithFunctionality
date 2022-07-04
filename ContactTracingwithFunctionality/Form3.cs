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
using System.IO;

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
                    var QRData = result.Text.Split(new char[] { '\n' });
                    if(QRData.Length == 15)
                        TxtBoxNm1.Text = QRData[0];
                        TxtboxAge2.Text = QRData[1];
                        cmbboxSex3.Text = QRData[2];
                        DDateofVisit4.Text = QRData[3];
                        TxtboxPhNum5.Text = QRData[4];
                        TxtboxAdd6.Text = QRData[5];
                        cmbboxCough7.Text = QRData[6];
                        cmbboxFever8.Text = QRData[7];
                        cmbboxSore9.Text = QRData[8];
                        cmbboxRunny10.Text = QRData[9];
                        cmbboxLoss11.Text = QRData[10];
                        cmbboxDiff12.Text = QRData[11];
                        cmbboxContact13.Text = QRData[12];
                        cmbboxTraveled14.Text = QRData[13];
                        cmbboxVaxx15.Text = QRData[14];
                        
                      

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
            file.Write("Name: " + TxtBoxNm1.Text);
            file.Write("Age: " + TxtboxAge2.Text);
            file.Write("Sex: " + cmbboxSex3.Text);
            file.Write("Phone #: " + TxtboxPhNum5.Text);
            file.Write("Address: " + TxtboxAdd6.Text);
            file.Write("Date of Visit: " + DDateofVisit4.Value.ToString("MM/dd/yyyy"));

            //Health Information Section
            file.Write("Cough: " + cmbboxCough7.Text);
            file.Write("Fever: " + cmbboxFever8.Text);
            file.Write("Soar Throat: " + cmbboxSore9.Text);
            file.Write("Runny Nose: " + cmbboxRunny10.Text);
            file.Write("Loss of taste or smell: " + cmbboxLoss11.Text);
            file.Write("Diffculty breathing: " + cmbboxDiff12.Text);
            file.Write("Have you been in close contact with a Covid - 19 case?: " + cmbboxContact13.Text);
            file.Write("Have you traveled outside the country in the last 14 days?: " + cmbboxTraveled14.Text);
            file.Write("Have you received vaccine doses?: " + cmbboxVaxx15.Text);

            file.WriteLine();
            file.Close();

            TxtBoxNm1.Text = "";
            TxtboxAge2.Text = "";
            cmbboxSex3.Text = "";
            TxtboxPhNum5.Text = "";
            TxtboxAdd6.Text = "";
            DDateofVisit4.ResetText();

            cmbboxCough7.Text = "";
            cmbboxFever8.Text = "";
            cmbboxSore9.Text = "";
            cmbboxRunny10.Text = "";
            cmbboxLoss11.Text = "";
            cmbboxDiff12.Text = "";
            cmbboxContact13.Text = "";
            cmbboxTraveled14.Text = "";
            cmbboxVaxx15.Text = "";
        }
    }
}
