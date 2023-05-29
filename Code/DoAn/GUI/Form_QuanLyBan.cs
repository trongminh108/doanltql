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
    public partial class Form_QuanLyBan : Form
    {
        List<Ban_DTO> lstBan;
        int tableWidth = 100;
        int tableHeight = 100;
        int idBan = -1;
        string[] names = { "ID", "ID Bàn", "Ngày lập", "Tình trạng", "Tổng tiền" };
        double[] widths = {0.1, 0.1, 0.27, 0.13, 0.3};
        
        public Form_QuanLyBan()
        {
            InitializeComponent();
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
                btn.BackColor = Color.White;
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
            idBan = ((sender as Button).Tag as Ban_DTO).Id;
            foreach (Control control in fpnDanhSachBan.Controls)
            {
                (control as Button).BackColor = Color.White;
                if (((control as Button).Tag as Ban_DTO).Status)
                    control.BackColor = Color.Aqua;
            }
            (sender as Button).BackColor = Color.Yellow;
            List<HoaDon_DTO> lstHoaDon = HoaDon_BUS.LayHoaDon(idBan);
            if (lstHoaDon!= null)
            {
                dgvHoaDon.DataSource = lstHoaDon;
                dgvHoaDon.ReadOnly = true;
                dgvHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                Functions.FormatDGV(dgvHoaDon, names, widths);
            }
            else
            {
                dgvHoaDon.DataSource = null;
            }
        }

        private void Form_QuanLyBan_Load(object sender, EventArgs e)
        {
            HienThiBan();
        }

        private void btnThemBan_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show(
                    "Bạn chắc chắn thêm bàn chứ?",
                    "Thông báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                Ban_BUS.ThemBan();
                MessageBox.Show(
                    "Đã thêm thành công",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                HienThiBan();
            }
        }

        private void btnXoaBan_Click(object sender, EventArgs e)
        {
            if (idBan != -1)
            {
                DialogResult answer = MessageBox.Show(
                    "Bạn thật sự muốn xóa bàn này sao?",
                    "Thông báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    bool status = Ban_BUS.LayTinhTrangBan(idBan);
                    if (status){
                        MessageBox.Show(
                        "Bàn này đang có người ngồi, không thể xóa",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Stop);
                    }
                    else
                    {
                        Ban_BUS.XoaBan(idBan);
                        HienThiBan();
                    }
                }
            }
            else
            {
                MessageBox.Show(
                    "Vui lòng chọn bàn cần xóa",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }
    }
}
