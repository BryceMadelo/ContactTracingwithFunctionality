namespace ContactTracingwithFunctionality
{
    public partial class KonohaContactTracing : Form
    {
        public KonohaContactTracing()
        {
            InitializeComponent();
        }

        private void btnSavenSub_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@".\KonohaVisits.txt", true);
            //Personal Information Section
            file.Write(TxtBoxNm.Text);
            file.Write(";" + TxtboxAge.Text);
            if (rdbtnMale.Checked)
                file.Write(";" + rdbtnMale.Text);
            else
                file.Write(";" + rdbtnFemale.Text);
            file.Write(";" + TxtboxPhNum.Text);
            file.Write(";" + TxtboxAdd.Text);
            file.Write(";" + DDateofVisit.Value.ToString("MM/dd/yyyy"));

            //Health Information Section
            if (rdbtnCoughYes.Checked)
                file.Write(";" + rdbtnCoughYes.Text);
            else
                file.Write(";" + rdbtnCoughNo.Text);

            if (rdbtnFeverYes.Checked)
                file.Write(";" + rdbtnFeverYes.Text);
            else
                file.Write(";" + rdbtnFeverNo.Text);

            if (rdbtnSoreThroatYes.Checked)
                file.Write(";" + rdbtnSoreThroatYes.Text);
            else
                file.Write(";" + rdbtnSoreThroatNo.Text);

            if (rdbtnRunnyNoseYes.Checked)
                file.Write(";" + rdbtnRunnyNoseYes.Text);
            else
                file.Write(";" + rdbtnRunnyNoseNo.Text);

            if (rdbtnLossTasteYes.Checked)
                file.Write(";" + rdbtnLossTasteYes.Text);
            else
                file.Write(";" + rdbtnLossTasteNo.Text);

            if (rdbtnDiffBreathYes.Checked)
                file.Write(";" + rdbtnDiffBreathYes.Text);
            else
                file.Write(";" + rdbtnDiffBreathNo.Text);

            if (rdbtnCloseContactYes.Checked)
                file.Write(";" + rdbtnCloseContactYes.Text);
            else
                file.Write(";" + rdbtnCloseContactNo.Text);

            if (rdbtnTraveledYes.Checked)
                file.Write(";" + rdbtnTraveledYes.Text);
            else
                file.Write(";" + rdbtnTraveledNo.Text);

            if (rdbtnVaxxYes.Checked)
                file.Write(";" + rdbtnVaxxYes.Text);
            else if (rdbtnVaxxNo.Checked)
                file.Write(";" + rdbtnVaxxNo.Text);
            else
                file.Write(";" + rdbtnVaxxwithBoosterYes.Text);

            file.WriteLine();
            file.Close();

            TxtBoxNm.Text = "";
            TxtboxAge.Text = "";
            rdbtnMale.Checked = false;
            rdbtnFemale.Checked = false;
            TxtboxPhNum.Text = "";
            TxtboxAdd.Text = "";
            DDateofVisit.ResetText();

            rdbtnCoughYes.Checked = false;
            rdbtnCoughNo.Checked = false;
            rdbtnFeverYes.Checked = false;
            rdbtnFeverNo.Checked = false;
            rdbtnSoreThroatYes.Checked = false;
            rdbtnSoreThroatNo.Checked = false;
            rdbtnRunnyNoseYes.Checked = false;
            rdbtnRunnyNoseNo.Checked = false;
            rdbtnLossTasteYes.Checked = false;
            rdbtnLossTasteNo.Checked = false;
            rdbtnDiffBreathYes.Checked = false;
            rdbtnDiffBreathNo.Checked = false;
            rdbtnCloseContactYes.Checked = false;
            rdbtnCloseContactNo.Checked = false;
            rdbtnTraveledYes.Checked = false;
            rdbtnTraveledNo.Checked = false;

            rdbtnVaxxYes.Checked = false;
            rdbtnVaxxNo.Checked = false;
            rdbtnVaxxwithBoosterYes.Checked = false;

        }

        private void btnNextPage_Click(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void grpbxSex_Enter(object sender, EventArgs e)
        {

        }
    }
}