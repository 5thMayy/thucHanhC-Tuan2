using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucHanhTuan2Bai2
{
    public partial class Form1 : Form
    {
        List<MonHoc_TinChi> mhS = new List<MonHoc_TinChi>();
        public Form1()
        {
            InitializeComponent();
            addData();
        }      
        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }     
        private void addData()
        {
            comboBox1.Items.Add("Kỹ thuật lập trình C#");
            comboBox1.Items.Add("Giải tích F1");
            comboBox1.Items.Add("Tiếng Anh A0");
            comboBox1.Items.Add("Triết học Mác - Lênin");
            comboBox1.Items.Add("Vật lý F1");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            if(comboBox1.SelectedIndex == 0)
            {
                textBox1.Text = 2.ToString();            
            }
            if (comboBox1.SelectedIndex == 1)
            {
                textBox1.Text = 3.ToString();
            }
            if (comboBox1.SelectedIndex == 2)
            {
                textBox1.Text = 3.ToString();
            }
            if (comboBox1.SelectedIndex == 3)
            {
                textBox1.Text = 2.ToString();
            }
            if (comboBox1.SelectedIndex == 4)
            {
                textBox1.Text = 3.ToString();
            }
            textBox2.Focus();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int flag = 1;
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Ban chua chon mon hoc");
                flag = 0;
            }
            if (textBox2.TextLength == 0)
            {
                MessageBox.Show("Ban chua nhap diem");
                flag = 0;
            }
            if (flag == 1)
            {
                listBox1.Items.Add(comboBox1.Text + " | " + textBox1.Text + " | " + textBox2.Text);
                mhS.Add(new MonHoc_TinChi(comboBox1.Text, Convert.ToInt32(textBox1.Text), Convert.ToDouble(textBox2.Text)));
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            double tongDiem = 0;
            double diemTB = 0;
            int soTin = 0;
            foreach (MonHoc_TinChi i in mhS)
            {
                tongDiem += Convert.ToDouble(i.Diem);
                soTin += Convert.ToInt32(i.SoTinChi);
                diemTB += Convert.ToDouble(i.Diem) * Convert.ToInt32(i.SoTinChi);
            }
            textBox4.Text = tongDiem.ToString();
            textBox3.Text = soTin.ToString();
            textBox5.Text = (diemTB / Convert.ToDouble(soTin)).ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && (e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
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
                button3.PerformClick();
            } 
            if (e.Alt == true && e.KeyCode == Keys.D)
            {
                button1.PerformClick();
            }
        }
    }
}
