using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    internal class DataProvider
    {
        static string strCon = @"Data Source=TRONGMINH;Initial Catalog=qlcafe;Integrated Security=True";

        public static SqlConnection MoKetNoi()
        {
            SqlConnection conn = new SqlConnection(strCon);
            try
            {
                conn.Open();
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối CSDL");
                return null;
            }
            return conn;
        }

        public static SqlConnection DongKetNoi(SqlConnection conn)
        {
            conn = new SqlConnection(strCon);
            conn.Close();
            return conn;
        }

        //Thực hiện truy vấn trả về bảng dữ liệu
        public static DataTable TruyVanLayDuLieu(string query, SqlConnection conn)
        {
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt); // đổ dữ liệu
            return dt; //trả về bảng
        }

        //Thực hiện truy vấn không trả về dữ liệu
        public static bool TruyVanKhongLayDuLieu(string query, SqlConnection conn)
        {
            try
            {
                SqlCommand cm = new SqlCommand(query, conn); //thực hiện truy vấn
                cm.ExecuteNonQuery(); //thực hiện truy vấn
                return true; // trả kết quả thực hiện truy vấn thành công
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể thực thi câu lệnh này!");
                return false;
            }
        }

        public static void CapNhatIndentity(string table, SqlConnection conn)
        {
            string sTruyVan = string.Format(@"
                DECLARE
	            @gtMoi INT 
	            SELECT @gtMoi = MAX(id) FROM {0};
	            DBCC CHECKIDENT ('{1}', RESEED, @gtMoi);
            ", table, table);
            TruyVanKhongLayDuLieu(sTruyVan, conn);
        }
    }
}
