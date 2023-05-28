﻿using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DoUong_DAO
    {
        public static List<DoUong_DTO> LayDoUong()
        {
            string sTruyVan = string.Format(@"select * from douong");
            SqlConnection conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DoUong_DTO> lstDoUong = new List<DoUong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DoUong_DTO du = new DoUong_DTO();
                du.Id = int.Parse(dt.Rows[i]["id"].ToString());
                du.Name = dt.Rows[i]["ten"].ToString();
                du.Price = int.Parse(dt.Rows[i]["gia"].ToString());
                lstDoUong.Add(du);
            }
            DataProvider.DongKetNoi(conn);
            return lstDoUong;
        }

        public static int getGia(int id)
        {
            string sTruyVan = string.Format(@"select gia from douong where id={0}", id);
            SqlConnection conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return -1;
            }
            return int.Parse(dt.Rows[0]["gia"].ToString());
        }

        public static int getID(string ten)
        {
            string sTruyVan = string.Format(@"select id from douong where ten=N'{0}'", ten);
            SqlConnection conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return -1;
            }
            return int.Parse(dt.Rows[0]["id"].ToString());
        }
    }
}
