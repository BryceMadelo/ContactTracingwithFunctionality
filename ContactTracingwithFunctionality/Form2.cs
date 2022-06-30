using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ContactTracingwithFunctionality
{
    public partial class DATABASE : Form
    {
        public KonohaContactTracing Mainform;
        List<string[]> listData = new List<string[]> { };
        public DATABASE()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int counter = 0;
            string line;
            StreamReader file = new StreamReader(@".\KonohaVisits.txt");
            while ((line = file.ReadLine()) != null)
            {
                String[] data = line.Split(';');
                listData.Add(data);
                listViewData.Items.Add(new ListViewItem(new string[] { data[5], data[0] }));

                counter++;
            }
            file.Close();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            listViewData.Items.Clear();
            foreach (string[] data in listData)
            {
                if (SelectedDate.Value.ToString("MM/dd/yyyy") == data[5])
                {
                    listViewData.Items.Add(new ListViewItem(new string[] { data[5], data[0] }));
                }
            }
        }

        private void SelectedD_IndexChanged(object sender, EventArgs e)
        {
            if (listViewData.SelectedItems.Count > 0)
            {
                string[] infoNames =
                {
                    "   Name: ",
                    "   Age: ",
                    "   Sex: ",
                    "   Phone #: ",
                    "   Address: ",
                    "   Date of Visit: ",
                    "   Cough: ",
                    "   Fever: ",
                    "   Soar Throat: ",
                    "   Runny Nose: ",
                    "   Loss of taste or smell: ",
                    "   Diffculty breathing: ",
                    "   Have you been in close contact with a Covid - 19 case?: ",
                    "   Have you traveled outside the country in the last 14 days?: ",
                    "   Have you received vaccine doses?: ",
                };

                ListViewItem item = listViewData.SelectedItems[0];
                String[] selectedData = new String[] { };


                foreach (String[] itm in listData)
                {
                    if (itm[0] == item.SubItems[1].Text && itm[5] == item.SubItems[0].Text)
                    {
                        selectedData = itm;
                        break;
                    }
                }
                listBoxFilterResult.Items.Clear();


                for (int i = 0; i < selectedData.Length; i++)
                {
                    if (i == 0)
                        listBoxFilterResult.Items.Add("PERSONAL INFO");
                    else if (i == 5)
                        listBoxFilterResult.Items.Add("HEALTH INFO");

                    listBoxFilterResult.Items.Add(infoNames[i] + selectedData[i]);
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            listBoxFilterResult.Items.Clear();
        }

        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            SelectedDate.ResetText();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form3_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnNext2_Click(object sender, EventArgs e)
        {
            QRCode form3 = new QRCode();
            form3.Secondform = this;
            form3.Show();

            form3.FormClosed += Form3_FormClosed;
            this.Hide();
        }
    }
}
