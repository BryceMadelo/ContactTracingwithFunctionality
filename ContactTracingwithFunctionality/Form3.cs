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
    public partial class QRCode : Form
    {
        public DATABASE Secondform;
        public QRCode()
        {

        }

        public QRCode(QRCoder.QRCodeData data)
        {
            InitializeComponent();
        }

        private void btnGenerator_Click(object sender, EventArgs e)
        {
            QRCoder.QRCodeGenerator QG = new QRCoder.QRCodeGenerator();
            var Data = QG.CreateQrCode(txtboxQR.Text, QRCoder.QRCodeGenerator.ECCLevel.H);
            var code = new QRCoder.QRCode(Data);
            picboxQR.Image = code.GetGraphic(100);
       
        }
    }
}
