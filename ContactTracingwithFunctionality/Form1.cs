namespace ContactTracingwithFunctionality
{
    public partial class KonohaContactTracing : Form
    {
        public KonohaContactTracing()
        {
            InitializeComponent();
        }

        private void btnSavenSub_Click_1(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@".\KonohaVisits.txt", true);
            //Personal Information Section
            file.Write(TxtBoxNm1.Text);
            file.Write(";" + TxtboxAge2.Text);
            file.Write(";" + cmbboxSex3.Text);
            file.Write(";" + TxtboxPhNum5.Text);
            file.Write(";" + TxtboxAdd6.Text);
            file.Write(";" + DDateofVisit4.Value.ToString("MM/dd/yyyy"));

            //Health Information Section
            file.Write(";" + cmbboxCough7.Text);
            file.Write(";" + cmbboxFever8.Text);
            file.Write(";" + cmbboxSore9.Text);
            file.Write(";" + cmbboxRunny10.Text);
            file.Write(";" + cmbboxLoss11.Text);
            file.Write(";" + cmbboxDiff12.Text);
            file.Write(";" + cmbboxContact13.Text);
            file.Write(";" + cmbboxTraveled14.Text);
            file.Write(";" + cmbboxVaxx15.Text);

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

        private void KonohaContactTracing_Load(object sender, EventArgs e)
        {

        }

        private void btnQR_Click(object sender, EventArgs e)
        {
            
            var Data = TxtBoxNm1.Text + "\n" + TxtboxAge2.Text + "\n" + cmbboxSex3.Text + "\n" + DDateofVisit4.Text + "\n" + TxtboxPhNum5.Text + "\n" + TxtboxAdd6.Text + "\n" + cmbboxCough7.Text + "\n" + cmbboxFever8.Text + "\n" + cmbboxSore9.Text + "\n" + cmbboxRunny10.Text + "\n" + cmbboxLoss11.Text + "\n" + cmbboxDiff12.Text + "\n" + cmbboxContact13.Text + "\n" + cmbboxTraveled14.Text + "\n" + cmbboxVaxx15.Text;

            QRCoder.QRCodeGenerator qr = new QRCoder.QRCodeGenerator();
            var Info = qr.CreateQrCode(Data, QRCoder.QRCodeGenerator.ECCLevel.M);
            var code = new QRCoder.QRCode(Info);
            picboxQR.Image = code.GetGraphic(100);

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

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}