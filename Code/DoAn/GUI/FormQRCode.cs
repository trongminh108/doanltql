using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormQRCode : Form
    {
        public static string text = "\nChân thành cảm ơn quý khách!";
        public FormQRCode()
        {
            InitializeComponent();
        }

        private void FormQRCode_Load(object sender, EventArgs e)
        {
            QRCodeGenerator qRCodeGenerator = new QRCodeGenerator();
            QRCodeData data = qRCodeGenerator.CreateQrCode(text, QRCodeGenerator.ECCLevel.Q);
            QRCode qRCode = new QRCode(data);
            pbQRCode.Image = qRCode.GetGraphic(10);
        }
    }
}
