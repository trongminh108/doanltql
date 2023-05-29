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
    public partial class Form_DangNhap : Form
    {
        public static bool isExit = false;
        public static bool isLogout = false;
        private Size originFormSize;
        private List<Rectangle> originControl;
        private List<float> originSize;

        public Form_DangNhap()
        {
            InitializeComponent();
        }

        private void Form_DangNhap_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
            this.originFormSize = this.Size;
            originControl = new List<Rectangle>();
            originSize = new List<float>();
            foreach (Control con in this.Controls)
            {
                originControl.Add(new Rectangle(con.Location, con.Size));
                originSize.Add(con.Font.Size);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string ten = txtUsername.Text;
            string matkhau = txtPassword.Text;
            TaiKhoan_DTO tk = TaiKhoan_BUS.DangNhapTaiKhoan(ten, matkhau);
            if (tk != null)
            {
                this.Hide();
                (new Form_Main(tk)).ShowDialog();
                txtUsername.Text = "";
                txtPassword.Text = "";
                if (isExit && !isLogout)
                    Application.Exit();
                this.Show();
                isLogout = false;
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form_DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult answer = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.No) {
                e.Cancel = true;
            }
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, new EventArgs());
            }
        }

        private void Form_DangNhap_Resize(object sender, EventArgs e)
        {
            int i = 0;
            foreach (Control con in this.Controls)
            {
                Functions.ResizeControl(this.Size, originFormSize, con, originControl[i], originSize[i]);
                i++;
            }
        }
    }
}
