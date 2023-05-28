using DTO;
using System;
using System.Collections.Generic;
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
    }
}
