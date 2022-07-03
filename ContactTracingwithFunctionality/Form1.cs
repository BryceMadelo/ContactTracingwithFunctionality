namespace ContactTracingwithFunctionality
{
    public partial class KonohaContactTracing : Form
    {
        bool FormAnswers = false;
        public KonohaContactTracing()
        {
            InitializeComponent();
        }

        private void btnSavenSub_Click_1(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@".\KonohaVisits.txt", true);
            //Personal Information Section
            file.Write(TxtBoxNm.Text);
            file.Write(";" + TxtboxAge.Text);
            file.Write(";" + cmbboxSex.Text);
            file.Write(";" + TxtboxPhNum.Text);
            file.Write(";" + TxtboxAdd.Text);
            file.Write(";" + DDateofVisit.Value.ToString("MM/dd/yyyy"));

            //Health Information Section
            file.Write(";" + cmbboxCough.Text);
            file.Write(";" + cmbboxFever.Text);
            file.Write(";" + cmbboxSore.Text);
            file.Write(";" + cmbboxRunny.Text);
            file.Write(";" + cmbboxLoss.Text);
            file.Write(";" + cmbboxDiff.Text);
            file.Write(";" + cmbboxContact.Text);
            file.Write(";" + cmbboxTraveled.Text);
            file.Write(";" + cmbboxVaxx.Text);

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

        private void KonohaContactTracing_Load(object sender, EventArgs e)
        {

        }

        private void btnQR_Click(object sender, EventArgs e)
        {
            FormAnswers = true;
            Qrcode();
        }
        private void Qrcode()
        {
            
            var text = TxtBoxNm.Text + " " + TxtboxAge.Text + " " + cmbboxSex.Text + " " + DDateofVisit.Text + " " + TxtboxPhNum.Text + " " + TxtboxAdd.Text + " " + cmbboxCough.Text + " " + cmbboxFever.Text + " " + cmbboxSore.Text + " " + cmbboxRunny.Text + " " + cmbboxLoss.Text + " " + cmbboxDiff.Text + " " + cmbboxContact.Text + " " + cmbboxTraveled.Text + " " + cmbboxVaxx.Text;
            picboxQR.SizeMode = PictureBoxSizeMode.StretchImage;
            QRCoder.QRCodeGenerator qr = new QRCoder.QRCodeGenerator();
            var Info = qr.CreateQrCode("Personal Information" + "                                                        Name: " + TxtBoxNm.Text + " " + "                                                             Age: " + TxtboxAge.Text + "                                                                  Sex: " + cmbboxSex.Text + "                                                                     Date Visit: " + DDateofVisit.Text + "                                                                 Phone Number: " + TxtboxPhNum.Text + "                                                   Address: " + TxtboxAdd.Text + "                                                         Have you been experiencing these symptopms?" + "                                                 Cough: " + cmbboxCough.Text + "                                                                  Fever: " + cmbboxFever.Text + "                                                                   Sore Throat: " + cmbboxSore.Text + "                                                              Runny Nose: " + cmbboxRunny.Text + "                                                                  Loss of Taste: " + cmbboxLoss.Text + "                                                          Difficulty Breathing:" + cmbboxDiff.Text + "                                     Have you been in close contact with a Covid - 19 case?:" + cmbboxContact.Text + "                                                              Have you traveled outside the country in the last 14 days ?:" + cmbboxTraveled.Text + "                                                                     Have you received vaccine doses?:" + cmbboxVaxx.Text, QRCoder.QRCodeGenerator.ECCLevel.L);
            var code = new QRCoder.QRCode(Info);
            picboxQR.Image = code.GetGraphic(50);
        }
        private void lablLoss_Click(object sender, EventArgs e)
        {

        }
        private void btnNextPage_Click_1(object sender, EventArgs e)
        {
            DATABASE form2 = new DATABASE();
            form2.Mainform = this;
            form2.Show();

            form2.FormClosed += Form2_FormClosed;
            this.Hide();
        }
        private void Form2_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}