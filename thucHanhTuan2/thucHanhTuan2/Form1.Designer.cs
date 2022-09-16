namespace thucHanhTuan2
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbListCustomer = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbTime = new System.Windows.Forms.ComboBox();
            this.tbBalance = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbBalance = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdbtnPremium = new System.Windows.Forms.RadioButton();
            this.rdbtnNormal = new System.Windows.Forms.RadioButton();
            this.lbLTK = new System.Windows.Forms.Label();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbListCustomer);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(407, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 331);
            this.panel1.TabIndex = 0;
            // 
            // lbListCustomer
            // 
            this.lbListCustomer.FormattingEnabled = true;
            this.lbListCustomer.Location = new System.Drawing.Point(14, 16);
            this.lbListCustomer.Name = "lbListCustomer";
            this.lbListCustomer.Size = new System.Drawing.Size(666, 303);
            this.lbListCustomer.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, -3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Danh sách khách hàng";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtpDate);
            this.panel2.Controls.Add(this.cbTime);
            this.panel2.Controls.Add(this.tbBalance);
            this.panel2.Controls.Add(this.tbAddress);
            this.panel2.Controls.Add(this.tbName);
            this.panel2.Controls.Add(this.tbID);
            this.panel2.Controls.Add(this.lbTime);
            this.panel2.Controls.Add(this.lbDate);
            this.panel2.Controls.Add(this.lbBalance);
            this.panel2.Controls.Add(this.lbAddress);
            this.panel2.Controls.Add(this.lbName);
            this.panel2.Controls.Add(this.lbID);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnAddNew);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(389, 465);
            this.panel2.TabIndex = 1;
            // 
            // cbTime
            // 
            this.cbTime.FormattingEnabled = true;
            this.cbTime.Location = new System.Drawing.Point(148, 272);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(66, 21);
            this.cbTime.TabIndex = 19;
            // 
            // tbBalance
            // 
            this.tbBalance.Location = new System.Drawing.Point(148, 186);
            this.tbBalance.Name = "tbBalance";
            this.tbBalance.Size = new System.Drawing.Size(126, 20);
            this.tbBalance.TabIndex = 17;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(148, 135);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(205, 20);
            this.tbAddress.TabIndex = 16;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(148, 87);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(150, 20);
            this.tbName.TabIndex = 15;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(148, 37);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(150, 20);
            this.tbID.TabIndex = 14;
            this.tbID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbID_KeyPress);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(22, 272);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(78, 15);
            this.lbTime.TabIndex = 13;
            this.lbTime.Text = "Thời gian gửi";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(22, 230);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(55, 15);
            this.lbDate.TabIndex = 12;
            this.lbDate.Text = "Ngày gửi";
            // 
            // lbBalance
            // 
            this.lbBalance.AutoSize = true;
            this.lbBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBalance.Location = new System.Drawing.Point(22, 187);
            this.lbBalance.Name = "lbBalance";
            this.lbBalance.Size = new System.Drawing.Size(65, 15);
            this.lbBalance.TabIndex = 11;
            this.lbBalance.Text = "Số tiền gửi";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.Location = new System.Drawing.Point(22, 140);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(45, 15);
            this.lbAddress.TabIndex = 10;
            this.lbAddress.Text = "Địa chỉ";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(22, 92);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(63, 15);
            this.lbName.TabIndex = 9;
            this.lbName.Text = "Họ tên KH";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(22, 42);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(45, 15);
            this.lbID.TabIndex = 8;
            this.lbID.Text = "Mã KH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nhập thông tin khách hàng gửi tiết kiệm";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rdbtnPremium);
            this.panel3.Controls.Add(this.rdbtnNormal);
            this.panel3.Controls.Add(this.lbLTK);
            this.panel3.Location = new System.Drawing.Point(15, 326);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(354, 60);
            this.panel3.TabIndex = 5;
            // 
            // rdbtnPremium
            // 
            this.rdbtnPremium.AutoSize = true;
            this.rdbtnPremium.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnPremium.Location = new System.Drawing.Point(208, 21);
            this.rdbtnPremium.Name = "rdbtnPremium";
            this.rdbtnPremium.Size = new System.Drawing.Size(69, 19);
            this.rdbtnPremium.TabIndex = 1;
            this.rdbtnPremium.TabStop = true;
            this.rdbtnPremium.Text = "Phát lộc";
            this.rdbtnPremium.UseVisualStyleBackColor = true;
            // 
            // rdbtnNormal
            // 
            this.rdbtnNormal.AutoSize = true;
            this.rdbtnNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnNormal.Location = new System.Drawing.Point(39, 21);
            this.rdbtnNormal.Name = "rdbtnNormal";
            this.rdbtnNormal.Size = new System.Drawing.Size(67, 19);
            this.rdbtnNormal.TabIndex = 0;
            this.rdbtnNormal.TabStop = true;
            this.rdbtnNormal.Text = "Thường";
            this.rdbtnNormal.UseVisualStyleBackColor = true;
            // 
            // lbLTK
            // 
            this.lbLTK.AutoSize = true;
            this.lbLTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLTK.Location = new System.Drawing.Point(36, 0);
            this.lbLTK.Name = "lbLTK";
            this.lbLTK.Size = new System.Drawing.Size(85, 16);
            this.lbLTK.TabIndex = 6;
            this.lbLTK.Text = "Loại tiết kiệm";
            // 
            // btnAddNew
            // 
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Location = new System.Drawing.Point(224, 406);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(91, 27);
            this.btnAddNew.TabIndex = 4;
            this.btnAddNew.Text = "Thêm mới";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(56, 406);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 27);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Thêm vào";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(808, 428);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 27);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(956, 428);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 27);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(148, 230);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(99, 20);
            this.dtpDate.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 489);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tính lãi xuất gửi tiết kiệm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lbListCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbTime;
        private System.Windows.Forms.TextBox tbBalance;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbBalance;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbLTK;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rdbtnPremium;
        private System.Windows.Forms.RadioButton rdbtnNormal;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DateTimePicker dtpDate;
    }
}

