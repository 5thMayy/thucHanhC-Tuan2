using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanh2_Bai3
{

    public class KhachHang
    {
        private string HoTen;
        private string hinhThucThue;
        private double giaThue;
        private string doUong;
        private int soLuongDoUong;
        private double tienDoUong;
        private double tongTien;
        public KhachHang(string hoTen, string hinhThucThue, double giaThue, string doUong, int soLuongDoUong, double tienDoUong)
        {
            HoTen = hoTen;
            this.hinhThucThue = hinhThucThue;
            this.giaThue = giaThue;
            this.doUong = doUong;
            this.soLuongDoUong = soLuongDoUong;
            this.tienDoUong = tienDoUong;
        }
        public KhachHang()
        {

        }
        public double tongTien1 { get => this.giaThue + this.soLuongDoUong * this.tienDoUong; }
    }
    class StaticData
    {
        public static List<KhachHang> _KHs = new List<KhachHang>();
    }
}
