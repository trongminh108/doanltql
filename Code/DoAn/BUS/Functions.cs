using DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class Functions
    {
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

    }
}
