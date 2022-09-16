using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thucHanhTuan2
{
    public partial class Form2 : Form
    {
        List<NguoiGui> listNguoiGui = new List<NguoiGui>();
        public Form2()
        {
            InitializeComponent();
            listNguoiGui = staticData._NguoiGui;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int timThay = 0;
            foreach (NguoiGui i in listNguoiGui)
            {
                if (i.ID == Convert.ToInt32(tbTimKiem.Text))
                {
                    timThay = 1;
                    lbSearchCustommer.Text = "Khach hang " + i.NameCus + " phai tra "
                        + i.Tien + " nghin dong";
                }
            }
            if (timThay == 0)
            {
                lbSearchCustommer.Text = "Khách hàng " + tbTimKiem.Text + " không có trong danh sách";
            }
        }
    }
}
