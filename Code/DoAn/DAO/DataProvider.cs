using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace DAO
{
    public class DataProvider
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

        public static bool DongKetNoi(SqlConnection conn)
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
                conn.Dispose();
                SqlConnection.ClearPool(conn);
                return true;
            }
            return false;
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
            catch (Exception ex)
            {
                MessageBox.Show("Không thể thực thi câu lệnh này!\n" + ex.Message);
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

        public static bool SaoLuuDuLieu(string sDuongDan)
        {
            string sTen = sDuongDan + @"\qlcafe(" + DateTime.Now.Day.ToString() + "_" +
             DateTime.Now.Month.ToString() + "_" +
             DateTime.Now.Year.ToString() + "_" +
             DateTime.Now.Hour.ToString() + "_" +
             DateTime.Now.Minute.ToString() + ").bak";
            string sql = @"
                BACKUP DATABASE qlcafe 
                TO DISK = N'" + sTen + "'" +
                "WITH INIT, COMPRESSION";
            SqlConnection con = MoKetNoi();
            bool kq = TruyVanKhongLayDuLieu(sql, con);
            DongKetNoi(con);
            return kq;
        }

        public static SqlConnection MoKetNoiMaster()
        {
            string connectionString = "Data Source=TRONGMINH;Initial Catalog=master;Integrated Security=True";

            // Tạo kết nối với database master
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            return conn;
            
        }

        public static bool PhucHoiDuLieu(string sDuongDan)
        {

            string sql = @"
                RESTORE DATABASE qlcafe
                FROM DISK = N'{0}'
                WITH REPLACE, RECOVERY;
            ";
            SqlConnection.ClearAllPools();
            sql = string.Format(sql, sDuongDan);
            SqlConnection con = MoKetNoiMaster();
            bool kq = TruyVanKhongLayDuLieu(sql, con);
            DongKetNoi(con);
            return kq;
        }
    }
}
