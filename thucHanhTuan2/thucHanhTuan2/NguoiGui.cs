using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thucHanhTuan2
{
    public class NguoiGui
    {
        private int Id;
        private string Name;
        private string Address;
        private double balance;
        private string Date;
        private string Time;
        private double tien;
        public NguoiGui(int Id)
        {
            this.Id = Id;
        }
        public NguoiGui(int id, string name, string address, double balance, string date, string time, double tien)
        {
            this.Id = id;
            Name = name;
            Address = address;
            this.balance = balance;
            Date = date;
            Time = time;
            this.Tien = tien;
        }
        public int ID { get => Id; set => Id = value; }
        public string NameCus { get => Name; set => Name = value; }
        public double Tien { get => tien; set => tien = value; }
    }
    class staticData
    {
        public static List<NguoiGui> _NguoiGui = new List<NguoiGui>();
    }
}
