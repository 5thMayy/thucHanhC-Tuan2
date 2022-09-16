namespace Bai3
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listCus = new System.Windows.Forms.ListBox();
            this.cbPickDrinks = new System.Windows.Forms.ComboBox();
            this.cbCost = new System.Windows.Forms.ComboBox();
            this.cbDrinkNames = new System.Windows.Forms.ComboBox();
            this.rdoPartTime = new System.Windows.Forms.RadioButton();
            this.rdoFullTime = new System.Windows.Forms.RadioButton();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnAddToList = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listCus
            // 
            this.listCus.FormattingEnabled = true;
            this.listCus.Location = new System.Drawing.Point(12, 10);
            this.listCus.Name = "listCus";
            this.listCus.Size = new System.Drawing.Size(518, 420);
            this.listCus.TabIndex = 0;
            // 
            // cbPickDrinks
            // 
            this.cbPickDrinks.FormattingEnabled = true;
            this.cbPickDrinks.Location = new System.Drawing.Point(49, 262);
            this.cbPickDrinks.Name = "cbPickDrinks";
            this.cbPickDrinks.Size = new System.Drawing.Size(96, 21);
            this.cbPickDrinks.TabIndex = 18;
            // 
            // cbCost
            // 
            this.cbCost.FormattingEnabled = true;
            this.cbCost.Location = new System.Drawing.Point(341, 261);
            this.cbCost.Name = "cbCost";
            this.cbCost.Size = new System.Drawing.Size(96, 21);
            this.cbCost.TabIndex = 17;
            // 
            // cbDrinkNames
            // 
            this.cbDrinkNames.FormattingEnabled = true;
            this.cbDrinkNames.Location = new System.Drawing.Point(207, 262);
            this.cbDrinkNames.Name = "cbDrinkNames";
            this.cbDrinkNames.Size = new System.Drawing.Size(68, 21);
            this.cbDrinkNames.TabIndex = 16;
            // 
            // rdoPartTime
            // 
            this.rdoPartTime.AutoSize = true;
            this.rdoPartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoPartTime.ForeColor = System.Drawing.Color.Black;
            this.rdoPartTime.Location = new System.Drawing.Point(257, 85);
            this.rdoPartTime.Name = "rdoPartTime";
            this.rdoPartTime.Size = new System.Drawing.Size(83, 20);
            this.rdoPartTime.TabIndex = 14;
            this.rdoPartTime.TabStop = true;
            this.rdoPartTime.Text = "Nửa ngày";
            this.rdoPartTime.UseVisualStyleBackColor = true;
            // 
            // rdoFullTime
            // 
            this.rdoFullTime.AutoSize = true;
            this.rdoFullTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFullTime.ForeColor = System.Drawing.Color.Black;
            this.rdoFullTime.Location = new System.Drawing.Point(92, 85);
            this.rdoFullTime.Name = "rdoFullTime";
            this.rdoFullTime.Size = new System.Drawing.Size(75, 20);
            this.rdoFullTime.TabIndex = 13;
            this.rdoFullTime.TabStop = true;
            this.rdoFullTime.Text = "Cả ngày";
            this.rdoFullTime.UseVisualStyleBackColor = true;
            // 
            // tbCost
            // 
            this.tbCost.Location = new System.Drawing.Point(171, 135);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(175, 20);
            this.tbCost.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(354, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "$";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(173, 35);
            this.txbName.Multiline = true;
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(175, 20);
            this.txbName.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(364, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Tiền";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(203, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(57, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Giá du thuyền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(57, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Họ Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(539, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Danh Sách Khách Hàng Đặt Tour";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(58, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nhập Thông Tin Khách Hàng Đặt Tour";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbPickDrinks);
            this.panel1.Controls.Add(this.cbCost);
            this.panel1.Controls.Add(this.cbDrinkNames);
            this.panel1.Controls.Add(this.rdoPartTime);
            this.panel1.Controls.Add(this.rdoFullTime);
            this.panel1.Controls.Add(this.tbCost);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txbName);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnAddNew);
            this.panel1.Controls.Add(this.btnAddToList);
            this.panel1.Location = new System.Drawing.Point(31, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 445);
            this.panel1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(45, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Chọn đồ uống";
            // 
            // btnAddNew
            // 
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.ForeColor = System.Drawing.Color.Black;
            this.btnAddNew.Location = new System.Drawing.Point(301, 349);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(87, 35);
            this.btnAddNew.TabIndex = 4;
            this.btnAddNew.Text = "Thoát";
            this.btnAddNew.UseVisualStyleBackColor = true;
            // 
            // btnAddToList
            // 
            this.btnAddToList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToList.ForeColor = System.Drawing.Color.Black;
            this.btnAddToList.Location = new System.Drawing.Point(61, 349);
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.Size = new System.Drawing.Size(106, 35);
            this.btnAddToList.TabIndex = 3;
            this.btnAddToList.Text = "Thêm vào DS";
            this.btnAddToList.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(934, 539);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 35);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listCus);
            this.panel2.Location = new System.Drawing.Point(522, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(547, 445);
            this.panel2.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 621);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listCus;
        private System.Windows.Forms.ComboBox cbPickDrinks;
        private System.Windows.Forms.ComboBox cbCost;
        private System.Windows.Forms.ComboBox cbDrinkNames;
        private System.Windows.Forms.RadioButton rdoPartTime;
        private System.Windows.Forms.RadioButton rdoFullTime;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnAddToList;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel2;
    }
}