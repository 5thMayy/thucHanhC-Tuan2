using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            checkButton();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkButton()
        {
            if (lvArray.Items.Count == 0)
            {
                btnRemove.Enabled = false;
                btnSum.Enabled = false;
                btnMax.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txbNumber.Text = "";
            txbNumber.Focus();
            lvArray.Items.Clear();
            btnRemove.Enabled = false;
            btnSum.Enabled = false;
            btnMax.Enabled = false;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lvArray.SelectedIndices.Count <= 0)
            {
                MessageBox.Show("Ban chua chon vi tri");
            } else
            {
                if (lvArray.SelectedItems.Count > 0)
                {
                    if (DialogResult.OK == MessageBox.Show("ban co muon xoa ", "tb", MessageBoxButtons.OKCancel))
                    {
                        int i = lvArray.SelectedItems[0].Index;
                        lvArray.Items.RemoveAt(i);
                    }
                }
            }
            if (lvArray.Items.Count == 0)
            {
                btnRemove.Enabled = false;
                btnSum.Enabled = false;
                btnMax.Enabled = false;
            }
        }
        private bool checkNullTxbNumer()
        {
            if (txbNumber.Text.Length == 0)
            {
                return false;
            }
            return true;
        }
        private void btnAddToList_Click(object sender, EventArgs e)
        {
            int flag = 1;
            int parsedValue;
            if (!checkNullTxbNumer() || !int.TryParse(txbNumber.Text, out parsedValue))
            {
                MessageBox.Show("Ban nhap sai du lieu");
                txbNumber.Focus();
                flag = 0;
            }
            if (flag == 1)
            {
                btnRemove.Enabled = true;
                btnSum.Enabled = true;
                btnMax.Enabled = true;
                lvArray.Items.Add(txbNumber.Text);
                txbNumber.Text = "";
                txbNumber.Focus();
            }
        }

        

        private void btnSum_Click(object sender, EventArgs e)
        {   
            if (lvArray.Items.Count == 0)
            {
                btnSum.Enabled = false;
            }
            else
            {
                int sum = 0;
                for (int i = 0; i < lvArray.Items.Count; i++)
                {
                    sum += Convert.ToInt32(lvArray.Items[i].Text);
                }
                lbSum.Text = "Tổng =" + sum.ToString();
            }
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (lvArray.Items.Count == 0)
            {
                btnMax.Enabled = false;
            } else
            {
                int max = Convert.ToInt32(lvArray.Items[0].Text);
                for (int i = 0; i < lvArray.Items.Count; i++)
                {
                    if (Convert.ToInt32(lvArray.Items[i].Text) > max)
                    {
                        max = Convert.ToInt32(lvArray.Items[i].Text);
                    }
                }
                lbMax.Text = "Max =" + max.ToString();
            }
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
            if (e.Alt == true && e.KeyCode == Keys.L)
            {
                btnRefresh.PerformClick();
            }
            if (e.Alt == true && e.KeyCode == Keys.D)
            {
                btnAddToList.PerformClick();
            }
            if (e.Alt == true && e.KeyCode == Keys.L)
            {
                btnRefresh.PerformClick();
            }
            if (e.Alt == true && e.KeyCode == Keys.X)
            {
                btnRemove.PerformClick();
            }
            if (e.Alt == true && e.KeyCode == Keys.N)
            {
                btnSum.PerformClick();
            }
            if (e.Alt == true && e.KeyCode == Keys.A)
            {
                btnMax.PerformClick();
            }
        }
    }
}
