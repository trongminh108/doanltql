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
    public partial class Form_ChuyenBan : Form
    {
        public static int tableWidth = 100;
        public static int tableHeight = 100;
        int idBanChuyen = -1;
        List<Ban_DTO> lstBan;
        public Form_ChuyenBan(int id)
        {
            InitializeComponent();
            idBanChuyen = id;
        }

        public void HienThiBan()
        {
            fpnDanhSachBan.Controls.Clear();
            lstBan = Ban_BUS.LayBan();
            foreach (Ban_DTO ban in lstBan)
            {
                string status = ban.Status ? "Có người" : "Trống";
                Button btn = new Button() { Width = tableWidth, Height = tableHeight };
                btn.Text = "Bàn " + ban.Id + Environment.NewLine + status;
                btn.Tag = ban;
                btn.Click += new System.EventHandler(this.btnBan_Click);
                if (ban.Status)
                {
                    btn.BackColor = Color.Aqua;
                }

                fpnDanhSachBan.Controls.Add(btn);
            }
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            //idBan = ((sender as Button).Tag as Ban_DTO).Id;
            //lblIdBan.Text = idBan + "";
            foreach (Control control in fpnDanhSachBan.Controls)
            {
                (control as Button).BackColor = Color.Transparent;
                if (((control as Button).Tag as Ban_DTO).Status)
                    control.BackColor = Color.Aqua;
            }
            int currentID = ((sender as Button).Tag as Ban_DTO).Id;
            if (currentID != idBanChuyen)
            {
                (sender as Button).BackColor = Color.Red;
                lblChuyenBan.Text = "Chuyển từ bàn " + idBanChuyen + " đến bàn " + currentID;
            }
            else
                lblChuyenBan.Text = "";
        }

        private void Form_ChuyenBan_Load(object sender, EventArgs e)
        {
            HienThiBan();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
