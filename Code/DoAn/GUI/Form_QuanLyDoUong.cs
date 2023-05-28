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
    public partial class Form_QuanLyDoUong : Form
    {
        List<DoUong_DTO> lstDoUong = null;
        int idx = -1;
        public Form_QuanLyDoUong()
        {
            InitializeComponent();
            dgvTU.ReadOnly = true;
            dgvTU.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTU.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTU.ColumnHeadersDefaultCellStyle.Font = new Font(dgvTU.Font, FontStyle.Bold); // Make header text bold
        }

        public void HienThiDoUong()
        {
            lstDoUong = DoUong_BUS.LayDoUong();
            dgvTU.DataSource = lstDoUong;
            lblTongDoUong.Text = "Tổng đồ uống: " + lstDoUong.Count;
        }

        private void Form_QuanLyDoUong_Load(object sender, EventArgs e)
        {
            HienThiDoUong();
            string[] names = { "STT", "Tên đồ uống", "Đơn giá" };
            double[] widths = { 0.2, 0.4, 0.3 };
            int width = dgvTU.Width;
            int i = 0;
            foreach (DataGridViewColumn col in dgvTU.Columns)
            {
                col.HeaderText = names[i];
                col.Width = (int)(widths[i] * width);
                i += 1;
            }
            i = 0;
            foreach (DataGridViewRow row in dgvTU.Rows)
            {
                row.Cells[0].Value = ++i;
            }
        }

        private void dgvTU_Click(object sender, EventArgs e)
        {
            idx = dgvTU.CurrentRow.Index;
            if (idx >= 0 && idx <= dgvTU.Rows.Count - 1)
            {
                txtTenTU.Text = dgvTU[1, idx].Value.ToString();
                txtDonGiaTU.Text = dgvTU[2, idx].Value.ToString();
            }
        }

        private void btnThemTU_Click(object sender, EventArgs e)
        {
            try
            {
                string tenTU = txtTenTU.Text;
                int donGia = int.Parse(txtDonGiaTU.Text);
                DialogResult answer = MessageBox.Show("Bạn muốn thêm " + txtTenTU.Text + " không?",
                    "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    DoUong_DTO doUong = new DoUong_DTO(tenTU, donGia);
                    DoUong_BUS.ThemDoUong(doUong);
                    HienThiDoUong();
                }
            }
            catch
            {
                MessageBox.Show("Tên hoặc đơn giá không hợp lệ!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuaTU_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult answer = MessageBox.Show("Bạn muốn cập nhật " + dgvTU[1, idx].Value + " không?", 
                    "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    int id = int.Parse(dgvTU[0, idx].Value.ToString());
                    string tenTU = txtTenTU.Text;
                    int donGia = int.Parse(txtDonGiaTU.Text);
                    DoUong_DTO doUong = new DoUong_DTO(id, tenTU, donGia);
                    DoUong_BUS.CapNhatDoUong(doUong);
                    HienThiDoUong();
                }
            }
            catch
            {
                MessageBox.Show("Tên hoặc đơn giá không hợp lệ!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaTU_Click(object sender, EventArgs e)
        {
            if (idx != -1)
            {
                DialogResult answer = MessageBox.Show(
                    "Bạn muốn xóa " + dgvTU[1, idx].Value + " không?",
                    "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    int id = int.Parse(dgvTU[0, idx].Value.ToString());
                    DoUong_BUS.XoaDoUong(id);
                    HienThiDoUong();
                }
            }
        }
    }
}
