namespace ContactTracingwithFunctionality
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSavenSub_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\user\Documents\New folder\KonohaVisitors1.txt");
            //Personal Information Section
            file.WriteLine(DDateofVisit.Value.ToString("o"));
            file.WriteLine(TxtBoxNm.Text);
            file.WriteLine("-----PERSONAL INFORMATION-----");
            file.WriteLine("Name: " + TxtBoxNm.Text);
            file.WriteLine("Age: " + TxtboxAge.Text);
            if (rdbtnMale.Checked)
            {
                file.WriteLine("Sex: " + rdbtnMale.Text);
            }
            else
            {
                file.WriteLine("Sex: " + rdbtnFemale.Text);
            }
            file.WriteLine("Phone #: " + TxtboxPhNum.Text);
            file.WriteLine("Address: " + TxtboxAdd.Text);
            file.WriteLine("Date of Visit: " + DDateofVisit.Text);

            //Health Information Section
            file.WriteLine("-----HEALTH INFORMATION-----");
            file.WriteLine("Have you been exepriencing the following symptoms in the past few days?");
            if (rdbtnCoughYes.Checked)
            {
                file.WriteLine("Cough: " + rdbtnCoughYes.Text);
            }
            else
            {
                file.WriteLine("Cough: " + rdbtnCoughNo.Text);
            }
            if (rdbtnFeverYes.Checked)
            {
                file.WriteLine("Fever: " + rdbtnFeverYes.Text);
            }
            else
            {
                file.WriteLine("Fever: " + rdbtnFeverNo.Text);
            }
            if (rdbtnSoreThroatYes.Checked)
            {
                file.WriteLine("Soar Throat: " + rdbtnSoreThroatYes.Text);
            }
            else
            {
                file.WriteLine("Soar Throat: " + rdbtnSoreThroatNo.Text);
            }
            if (rdbtnRunnyNoseYes.Checked)
            {
                file.WriteLine("Runny Nose: " + rdbtnRunnyNoseYes.Text);
            }
            else
            {
                file.WriteLine("Runny Nose: " + rdbtnRunnyNoseNo.Text);
            }
            if (rdbtnLossTasteYes.Checked)
            {
                file.WriteLine("Loss of taste or smell: " + rdbtnLossTasteYes.Text);
            }
            else
            {
                file.WriteLine("Loss of taste or smell: " + rdbtnLossTasteNo.Text);
            }
            if (rdbtnDiffBreathYes.Checked)
            {
                file.WriteLine("Difficulty breathing: " + rdbtnDiffBreathYes.Text);
            }
            else
            {
                file.WriteLine("Diffculty breathing: " + rdbtnDiffBreathNo.Text);
            }
            if (rdbtnCloseContactYes.Checked)
            {
                file.WriteLine("Have you been in close contact with a Covid - 19 case?: " + rdbtnCloseContactYes.Text);
            }
            else
            {
                file.WriteLine("Have you been in close contact with a Covid - 19 case?: " + rdbtnCloseContactNo.Text);
            }
            if (rdbtnTraveledYes.Checked)
            {
                file.WriteLine("Have you traveled outside the country in the last 14 days?: " + rdbtnTraveledYes.Text);
            }
            else
            {
                file.WriteLine("Have you traveled outside the country in the last 14 days?: " + rdbtnTraveledNo.Text);
            }
            if (rdbtnVaxxYes.Checked)
            {
                file.WriteLine("Have you received vaccine doses?: " + rdbtnVaxxYes.Text);
            }
            else
            {
                file.WriteLine("Have you received vaccine doses?: " + rdbtnVaxxNo.Text);
            }
            if (rdbtnVaxxwithBoosterYes.Checked)
            {
                file.WriteLine("Have you received vaccine doses?: " + rdbtnVaxxwithBoosterYes.Text);
            }
            file.Close();
        }
    }
}