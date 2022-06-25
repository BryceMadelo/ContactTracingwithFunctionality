using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactTracingwithFunctionality
{
    public partial class Form2 : Form
    {
        public Form1 Mainform;
        List<string[]> listData = new List<string[]> { };
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int counter = 0;
            string line;
            StreamReader file = new StreamReader(@"C:\Users\user\Documents\Konoha\KonohaVisitors1.txt");
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

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

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
                    listBox1.Items.Clear();


                    for (int i = 0; i < selectedData.Length; i++)
                    {
                        if (i == 0)
                            listBox1.Items.Add("PERSONAL INFO");
                        else if (i == 5)
                            listBox1.Items.Add("HEALTH INFO");

                        listBox1.Items.Add(infoNames[i] + selectedData[i]);
                    }
                }
            }
        }
    }
}
