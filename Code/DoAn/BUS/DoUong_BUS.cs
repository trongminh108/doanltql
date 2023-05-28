using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class DoUong_BUS
    {
        public static List<DoUong_DTO> LayDoUong()
        {
            return DoUong_DAO.LayDoUong();
        }

        public static int getGia(int id)
        {
            return DoUong_DAO.getGia(id);
        }

        public static int getID(string ten)
        {
            return DoUong_DAO.getID(ten);
        }

        public static bool CheckDoUong(DoUong_DTO doUong, string chucNang="capnhat")
        {
            if (doUong.Name.Trim() == "")
            {
                DialogResult answer = MessageBox.Show(
                    "Tên đồ uống không được trống",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            else if (doUong.Price < 0)
            {
                DialogResult answer = MessageBox.Show(
                   "Giá đồ uống không được âm",
                   "Thông báo",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                return false;
            }
            else if (getID(doUong.Name) != -1 && chucNang=="them")
            {
                DialogResult answer = MessageBox.Show(
                    "Đồ uống đã tồn tại!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public static bool ThemDoUong(DoUong_DTO doUong)
        {
            if (CheckDoUong(doUong, "them"))
                return DoUong_DAO.ThemDoUong(doUong);
            return false;
        }

        public static bool CapNhatDoUong(DoUong_DTO doUong)
        {   
            if (CheckDoUong(doUong))
                return DoUong_DAO.CapNhatDoUong(doUong);
            return false;
        }

        public static bool XoaDoUong(int idDoUong)
        {
            return DoUong_DAO.XoaDoUong(idDoUong);
        }
    }
}
