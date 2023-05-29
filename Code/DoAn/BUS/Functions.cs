using DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class Functions
    {
        public static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
        public static int TinhTongTien(List<ChiTietHoaDon_DTO> cthd)
        {
            int res = 0;
            try
            {
                foreach (ChiTietHoaDon_DTO ct in cthd)
                {
                    res += ct.Price * ct.Quantity;
                }
            }
            catch
            {

            }
            return res;
        }

        static Form currentForm = null;
        public static void OpenChildForm(Form form, Panel pnChildForm)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnChildForm.Controls.Add(form);
            pnChildForm.Tag = form;
            form.BringToFront();
            form.Show();
            currentForm = form;
        }

        public static void ResizeControl(Size formSize, Size originFormSize, Control c, Rectangle r, float originSize)
        {
            float xRatio = (float)(formSize.Width) / originFormSize.Width;
            float yRatio = (float)(formSize.Height) / originFormSize.Height;
            int newX = (int)(xRatio * r.X);
            int newY = (int)(yRatio * r.Y);
            int newW = (int)(xRatio * r.Width);
            int newH = (int)(yRatio * r.Height);
            c.Location = new Point(newX, newY);
            c.Size = new Size(newW, newH);
            float newSize = c.Font.Size;
            if (xRatio > yRatio)
                newSize = yRatio * originSize;
            else
                newSize = xRatio * originSize;
            c.Font = new Font(c.Font.Name, newSize);
        }

        public static string RemoveUnicode(string input)
        {
            return Regex.Replace(input, @"[^\u0000-\u007F]", String.Empty);
        }

        public static void FormatDGV(DataGridView dgv, string[] names, double[] widths)
        {
            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font(dgv.Font, FontStyle.Bold); // Make header text bold
            int width = dgv.Width;
            int i = 0;
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                col.HeaderText = names[i];
                col.Width = (int)(widths[i] * width);
                i += 1;
            }
        }
    }
}
