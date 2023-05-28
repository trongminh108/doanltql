using DTO;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form_ChiTietHoaDon : Form
    {
        List<InCTHD> lstInCTHD;
        public Form_ChiTietHoaDon(List<InCTHD> lstInCTHD)
        {
            InitializeComponent();
            this.lstInCTHD = lstInCTHD;
        }

        private void Form_ThanhToanHoaDon_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportPath = "ChiTietHoaDon.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            var source = new ReportDataSource("DataSetChiTietHoaDon", lstInCTHD);
            reportViewer1.LocalReport.DataSources.Add(source);
            this.reportViewer1.RefreshReport();
        }
    }
}
