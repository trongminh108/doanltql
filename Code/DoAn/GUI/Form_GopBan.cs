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
    public partial class Form_GopBan : Form
    {
        public static int tableWidth = 100;
        public static int tableHeight = 100;
        int idBanGoc = -1;
        List<Ban_DTO> lstBan;
        int currentID = -1;
        public static int IDres = -1;
        public Form_GopBan(int id)
        {
            InitializeComponent();
            idBanGoc = id;
            lblGopBan.Text = "Chọn bàn để chuyển gộp " + idBanGoc;
            btnGop.Enabled = false;
        }

        public void HienThiBan()
        {
            fpnDanhSachBan.Controls.Clear();
            lstBan = Ban_BUS.LayBan();
            foreach (Ban_DTO ban in lstBan)
            {
                string status = ban.Status ? "Có người" : "Trống";
                if (ban.Status)
                {
                    Button btn = new Button() { Width = tableWidth, Height = tableHeight };
                    btn.Text = "Bàn " + ban.Id + Environment.NewLine + status;
                    btn.Tag = ban;
                    btn.Click += new System.EventHandler(this.btnBan_Click);
                    if (ban.Status)
                    {
                        btn.BackColor = Color.Aqua;
                        btn.TextAlign = ContentAlignment.TopCenter;
                        btn.BackgroundImage = Properties.Resources.FullTableIcon;
                        btn.Font = new Font(btn.Font, FontStyle.Bold);
                    }
                    if (ban.Id == idBanGoc)
                    {
                        btn.BackColor = Color.Red;
                    }

                    fpnDanhSachBan.Controls.Add(btn);
                }
            }
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            foreach (Control control in fpnDanhSachBan.Controls)
            {
                (control as Button).BackColor = Color.Transparent;
                Ban_DTO ban = ((control as Button).Tag as Ban_DTO);
                if (ban.Status)
                    control.BackColor = Color.Aqua;
                if (ban.Id == idBanGoc)
                    control.BackColor = Color.Red;
            }
            currentID = ((sender as Button).Tag as Ban_DTO).Id;
            if (currentID != idBanGoc && lstBan[currentID-1].Status)
            {
                (sender as Button).BackColor = Color.Red;
                lblGopBan.Text = "Gộp bàn " + idBanGoc + " và bàn " + currentID;
                btnGop.Enabled = true;
            }
            else
            {
                lblGopBan.Text = "";
                btnGop.Enabled = false;
            }
        }

        private void Form_GopBan_Load(object sender, EventArgs e)
        {
            HienThiBan();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGop_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show(
                    "Bạn chắc gộp bàn " + idBanGoc + " và bàn " + currentID,
                    "Thông báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                int idHDBanGoc = HoaDon_BUS.LayIDHoaDon(idBanGoc);
                int idHDBanDich = HoaDon_BUS.LayIDHoaDon(currentID);
                List<ThongTinHoaDon_DTO> lstHDGoc = ThongTinHoaDon_BUS.LayThongTinHoaDon(idHDBanGoc);
                foreach (ThongTinHoaDon_DTO tthd in lstHDGoc)
                {
                    tthd.IdBill = idHDBanDich;
                    ThongTinHoaDon_BUS.ThemThongTinHoaDon(tthd);
                }
                HoaDon_BUS.XoaHoaDon(idHDBanGoc);
                //Ban_BUS.ThanhToanBan(idBanGoc, 0);
                IDres = currentID;
                this.Close();
            }
        }
    }
}
