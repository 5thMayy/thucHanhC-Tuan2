using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanhTuan2Bai2
{
    public class MonHoc_TinChi
    {
        private string tenMonHoc;
        private int soTinChi;
        private double diem;
        public MonHoc_TinChi(string tenMonHoc, int soTinChi, double diem)
        {
            this.tenMonHoc = tenMonHoc;
            this.soTinChi = soTinChi;
            this.diem = diem;
        }
        public string TenMonHoc { get => tenMonHoc; set => tenMonHoc = value; }
        public int SoTinChi { get => soTinChi; set => soTinChi = value; }
        public double Diem { get => diem; set => diem = value; }
    }
    class staticData
    {
        public static List<MonHoc_TinChi> monHoc = new List<MonHoc_TinChi>();
    }
}
