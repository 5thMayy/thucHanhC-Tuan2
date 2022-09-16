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
    public partial class Form1 : Form
    {
        List<NguoiGui> lstNguoiGui = new List<NguoiGui>();
        public Form1()
        {
            InitializeComponent();
            addComboBoxTime();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
               this.Close();
        }
        private void addComboBoxTime()
        {
            cbTime.Items.Add("1");
            cbTime.Items.Add("3");
            cbTime.Items.Add("6");
            cbTime.Items.Add("12");
        }

        private void tbID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            tbID.Text = "";
            tbName.Text = "";
            tbAddress.Text = "";
            tbBalance.Text = "";
            dtpDate.Text = "";
            cbTime.Text = "";
            cbTime.SelectedIndex = -1;
            rdbtnNormal.Checked = false;
            rdbtnPremium.Checked = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int kt = 1;
            if (tbID.TextLength < 6)
            {
                MessageBox.Show("Nhap lai vi ma nho hon 6");
                kt = 0;
            }
            if(tbAddress.TextLength == 0 || tbName.TextLength == 0)
            {
                MessageBox.Show("Nhap lai vi ten hoac dia chi rong");
                kt = 0;
            }
            double tienlai = 0;
            if (kt == 1)
            {
                if (rdbtnNormal.Checked == true)
                {
                    if (cbTime.SelectedIndex == 0)
                    {
                        tienlai = Convert.ToInt32(tbBalance.Text) * 0.06;
                    }
                    if (cbTime.SelectedIndex == 1)
                    {
                        tienlai = Convert.ToInt32(tbBalance.Text) * 0.07;
                    }
                    if (cbTime.SelectedIndex == 2)
                    {
                        tienlai = Convert.ToInt32(tbBalance.Text) * 0.08;
                    }
                    if (cbTime.SelectedIndex == 3)
                    {
                        tienlai = Convert.ToInt32(tbBalance.Text) * 0.09;
                    }
                }
                else if (rdbtnPremium.Checked == true)
                {
                    if (cbTime.SelectedIndex == 0)
                    {
                        tienlai = Convert.ToInt32(tbBalance.Text) * 0.07;
                    }
                    if (cbTime.SelectedIndex == 1)
                    {
                        tienlai = Convert.ToInt32(tbBalance.Text) * 0.08;
                    }
                    if (cbTime.SelectedIndex == 2)
                    {
                        tienlai = Convert.ToInt32(tbBalance.Text) * 0.09;
                    }
                    if (cbTime.SelectedIndex == 3)
                    {
                        tienlai = Convert.ToInt32(tbBalance.Text) * 0.1;
                    }
                }
            }
            lbListCustomer.Items.Add(tbID.Text + " | " + tbName.Text + " | " + tbAddress.Text + " | " + dtpDate.Text + " | " + tbBalance.Text + " | " + cbTime.Text + " Thang | " + tienlai);
            lstNguoiGui.Add(new NguoiGui(Convert.ToInt32(tbID.Text), tbName.Text, tbAddress.Text, Convert.ToDouble(tbBalance.Text), dtpDate.Text, cbTime.Text, tienlai));
            staticData._NguoiGui = lstNguoiGui;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
