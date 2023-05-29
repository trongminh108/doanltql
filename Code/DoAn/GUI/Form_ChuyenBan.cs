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
        int currentID = -1;
        
        public Form_ChuyenBan(int id)
        {
            InitializeComponent();
            idBanChuyen = id;
            lblChuyenBan.Text = "Chọn bàn để chuyển bàn " + idBanChuyen;
            btnChuyen.Enabled = false;
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
                    btn.TextAlign = ContentAlignment.TopCenter;
                    btn.BackgroundImage = Properties.Resources.FullTableIcon;
                    btn.Font = new Font(btn.Font, FontStyle.Bold);
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
            currentID = ((sender as Button).Tag as Ban_DTO).Id;
            if (currentID != idBanChuyen && !lstBan[currentID-1].Status)
            {
                (sender as Button).BackColor = Color.Red;
                lblChuyenBan.Text = "Chuyển từ bàn " + idBanChuyen + " đến bàn " + currentID;
                btnChuyen.Enabled = true;
            }
            else
            {
                if (currentID == idBanChuyen)
                {
                    lblChuyenBan.Text = "";
                    btnChuyen.Enabled = false;
                }
                else
                {
                    (sender as Button).BackColor = Color.Red;
                    lblChuyenBan.Text = "Chuyển từ bàn " + idBanChuyen + " đến bàn " + currentID;
                    btnChuyen.Enabled = true;
                }
            }
        }

        private void Form_ChuyenBan_Load(object sender, EventArgs e)
        {
            HienThiBan();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            Ban_DTO banHienTai = Ban_BUS.LayBan(currentID);
            if (idBanChuyen != currentID && !banHienTai.Status)
            {
                int idHD = HoaDon_BUS.LayIDHoaDon(idBanChuyen);
                HoaDon_BUS.ChuyenBan(idHD, currentID);
                Ban_BUS.ThanhToanBan(idBanChuyen, 0);
                Ban_BUS.ThanhToanBan(currentID, 1);
                MessageBox.Show("Đã chuyển từ bàn " + idBanChuyen + " đến bàn " + currentID, "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                DialogResult answer = MessageBox.Show(
                    "Bàn này đã có người ngồi, bạn có muốn chuyển?",
                    "Thông báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    int idHDBanGoc = HoaDon_BUS.LayIDHoaDon(idBanChuyen);
                    int idHDBanDich = HoaDon_BUS.LayIDHoaDon(currentID);
                    List<ThongTinHoaDon_DTO> lstHDGoc = ThongTinHoaDon_BUS.LayThongTinHoaDon(idHDBanGoc);
                    foreach (ThongTinHoaDon_DTO tthd in lstHDGoc)
                    {
                        tthd.IdBill = idHDBanDich;
                        ThongTinHoaDon_BUS.ThemThongTinHoaDon(tthd);
                    }
                    HoaDon_BUS.XoaHoaDon(idHDBanGoc);
                    Ban_BUS.ThanhToanBan(idBanChuyen, 0);
                    this.Close();
                }
            }
        }
    }
}
