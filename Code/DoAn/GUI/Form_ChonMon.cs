using BUS;
using DTO;
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
    public partial class Form_ChonMon : Form
    {
        int tableWidth = 100;
        int tableHeight = 100;
        public static int idMon = -1;
        public Form_ChonMon()
        {
            InitializeComponent();
        }

        private void Form_ChonMon_Load(object sender, EventArgs e)
        {
            List<DoUong_DTO> lstDoUong = DoUong_BUS.LayDoUong();
            fpnDSMon.Controls.Clear();
            foreach (DoUong_DTO du in lstDoUong)
            {
                Button btn = new Button() { Width = tableWidth, Height = tableHeight };
                btn.Text = "Món " + du.Id + Environment.NewLine + du.Name;
                btn.Tag = du;
                btn.Font = new Font(btn.Font.FontFamily, 12);
                btn.Click += new System.EventHandler(this.btndu_Click);
                btn.BackColor = Color.Lime;
                btn.TextAlign = ContentAlignment.MiddleCenter;
                fpnDSMon.Controls.Add(btn);
            }
        }

        private void btndu_Click(object sender, EventArgs e)
        {
            idMon = ((sender as Button).Tag as DoUong_DTO).Id;
            this.Close();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
