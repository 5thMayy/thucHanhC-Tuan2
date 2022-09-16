using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucHanh2_Bai3
{
    public partial class Form1 : Form
    {
        List<KhachHang> khachHangs = new List<KhachHang>();
        public Form1()
        {
            InitializeComponent();
            AddDrinks();
            AddAmount();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }

        private void AddDrinks()
        {
            cbPickDrinks.Items.Add("Coca cola");
            cbPickDrinks.Items.Add("Pepsi");
            cbPickDrinks.Items.Add("Seven up");
        }

        private void AddAmount()
        {
            cbDrinkAmount.Items.Add(1);
            cbDrinkAmount.Items.Add(2);
            cbDrinkAmount.Items.Add(3);
            cbDrinkAmount.Items.Add(4);
            cbDrinkAmount.Items.Add(5);
            cbDrinkAmount.Items.Add(6);
            cbDrinkAmount.Items.Add(7);
            cbDrinkAmount.Items.Add(8);
            cbDrinkAmount.Items.Add(9);
            cbDrinkAmount.Items.Add(10);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt == true && e.KeyCode == Keys.H)
            {
                btnExit.PerformClick();
            }
            if (e.Alt == true && e.KeyCode == Keys.M)
            {
                btnAddNew.PerformClick();
            }
        }

        private void rdoFullTime_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoFullTime.Checked )
            {
                tbCost.Text = "200";
            }
        }

        private void rdoPartTime_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoPartTime.Checked)
            {
                tbCost.Text = "100";
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            txbName.Text = "";
            rdoFullTime.Checked = false; 
            rdoPartTime.Checked = false;
            tbCost.Text = "";
            cbPickDrinks.SelectedIndex = -1;
            cbDrinkAmount.SelectedIndex = -1;
            tbCostDrinks.Text = "";
            txbName.Focus();
        }

        private void cbDrinkAmount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPickDrinks.SelectedIndex == 0)
            {
                if (cbDrinkAmount.SelectedIndex == 0)
                {
                    tbCostDrinks.Text = (0.5 * 1).ToString();
                }
                if (cbDrinkAmount.SelectedIndex == 1)
                {
                    tbCostDrinks.Text = (0.5 * 2).ToString();
                }
                if (cbDrinkAmount.SelectedIndex == 2)
                {
                    tbCostDrinks.Text = (0.5 * 3).ToString();
                }
                if (cbDrinkAmount.SelectedIndex == 3)
                {
                    tbCostDrinks.Text = (0.5 * 4).ToString();
                }
                if (cbDrinkAmount.SelectedIndex == 4)
                {
                    tbCostDrinks.Text = (0.5 * 5).ToString();
                }
                if (cbDrinkAmount.SelectedIndex == 5)
                {
                    tbCostDrinks.Text = (0.5 * 6).ToString();
                }
                if (cbDrinkAmount.SelectedIndex == 6)
                {
                    tbCostDrinks.Text = (0.5 * 7).ToString();
                }
                if (cbDrinkAmount.SelectedIndex == 7)
                {
                    tbCostDrinks.Text = (0.5 * 8).ToString();
                }
                if (cbDrinkAmount.SelectedIndex == 8)
                {
                    tbCostDrinks.Text = (0.5 * 9).ToString();
                }
                if (cbDrinkAmount.SelectedIndex == 9)
                {
                    tbCostDrinks.Text = (0.5 * 10).ToString();
                }
            }
            if (cbPickDrinks.SelectedIndex == 1)
            {
                if (cbDrinkAmount.SelectedIndex == 0)
                {
                    tbCostDrinks.Text = (0.8 * 1).ToString();
                }
                if (cbDrinkAmount.SelectedIndex == 1)
                {
                    tbCostDrinks.Text = (0.8 * 2).ToString();
                }
                if (cbDrinkAmount.SelectedIndex == 2)
                {
                    tbCostDrinks.Text = (0.8 * 3).ToString();
                }
                if (cbDrinkAmount.SelectedIndex == 3)
                {
                    tbCostDrinks.Text = (0.8 * 4).ToString();
                }
                if (cbDrinkAmount.SelectedIndex == 4)
                {
                    tbCostDrinks.Text = (0.8 * 5).ToString();
                }
                if (cbDrinkAmount.SelectedIndex == 5)
                {
                    tbCostDrinks.Text = (0.8 * 6).ToString();
                }
                if (cbDrinkAmount.SelectedIndex == 6)
                {
                    tbCostDrinks.Text = (0.8 * 7).ToString();
                }
                if (cbDrinkAmount.SelectedIndex == 7)
                {
                    tbCostDrinks.Text = (0.8 * 8).ToString();
                }
                if (cbDrinkAmount.SelectedIndex == 8)
                {
                    tbCostDrinks.Text = (0.8 * 9).ToString();
                }
                if (cbDrinkAmount.SelectedIndex == 9)
                {
                    tbCostDrinks.Text = (0.8 * 10).ToString();
                }
            }
            if (cbPickDrinks.SelectedIndex == 2)
            {
                if (cbDrinkAmount.SelectedIndex == 0)
                {
                    tbCostDrinks.Text = (1 * 1).ToString();
                }
                if (cbDrinkAmount.SelectedIndex == 1)
                {
                    tbCostDrinks.Text = (1 * 2).ToString();
                }
                if (cbDrinkAmount.SelectedIndex == 2)
                {
                    tbCostDrinks.Text = (1 * 3).ToString();
                }
                if (cbDrinkAmount.SelectedIndex == 3)
                {
                    tbCostDrinks.Text = (1 * 4).ToString();
                }
                if (cbDrinkAmount.SelectedIndex == 4)
                {
                    tbCostDrinks.Text = (1 * 5).ToString();
                }
                if (cbDrinkAmount.SelectedIndex == 5)
                {
                    tbCostDrinks.Text = (1 * 6).ToString();
                }
                if (cbDrinkAmount.SelectedIndex == 6)
                {
                    tbCostDrinks.Text = (1 * 7).ToString();
                }
                if (cbDrinkAmount.SelectedIndex == 7)
                {
                    tbCostDrinks.Text = (1 * 8).ToString();
                }
                if (cbDrinkAmount.SelectedIndex == 8)
                {
                    tbCostDrinks.Text = (1 * 9).ToString();
                }
                if (cbDrinkAmount.SelectedIndex == 9)
                {
                    tbCostDrinks.Text = (1 * 10).ToString();
                }
            }
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            int flag = 1;
            bool htt = false;
            if (txbName.TextLength == 0)
            {
                MessageBox.Show("Ban chua nhap ten");
                flag = 0;
            }
            if (rdoFullTime.Checked == false && rdoPartTime.Checked == false)
            {
                MessageBox.Show("Ban chua chon hinh thuc thue");
                flag = 0;
            }
            if (rdoFullTime.Checked == true)
            {
                htt = true;
            }
            if (cbPickDrinks.SelectedIndex == -1 || cbDrinkAmount.SelectedIndex == -1)
            {
                MessageBox.Show("Ban chua chon do uong");
                flag = 0;
            }
            
            double tongTien = 0;
            if (flag == 1 && htt == true)
            {
                tongTien = 200 + Convert.ToDouble(tbCostDrinks.Text);
                listCus.Items.Add(txbName.Text + " | " + rdoFullTime.Text + " | " + " 200 " + " | " + cbPickDrinks.Text + " | " + cbDrinkAmount.Text + " | " + tongTien);
            }
            if (flag == 1 && htt == false)
            {
                tongTien = 100 + Convert.ToDouble(tbCostDrinks.Text);
                listCus.Items.Add(txbName.Text + " | " + rdoPartTime.Text + " | " + " 100 " + " | " + cbPickDrinks.Text + " | " + cbDrinkAmount.Text + " | " + tongTien);
            }
        }
    }
}
