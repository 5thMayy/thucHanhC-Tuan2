namespace Bai5
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAddToList = new System.Windows.Forms.Button();
            this.txbNumber = new System.Windows.Forms.TextBox();
            this.lbNumber = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lvArray = new System.Windows.Forms.ListView();
            this.clNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbListView = new System.Windows.Forms.Label();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbSum = new System.Windows.Forms.Label();
            this.lbMax = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Controls.Add(this.btnAddToList);
            this.panel1.Controls.Add(this.txbNumber);
            this.panel1.Controls.Add(this.lbNumber);
            this.panel1.Location = new System.Drawing.Point(25, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 444);
            this.panel1.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(46, 256);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(164, 45);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(46, 171);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(164, 45);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Xóa khỏi danh sách";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAddToList
            // 
            this.btnAddToList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToList.Location = new System.Drawing.Point(46, 87);
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.Size = new System.Drawing.Size(164, 45);
            this.btnAddToList.TabIndex = 2;
            this.btnAddToList.Text = "Thêm vào danh sách";
            this.btnAddToList.UseVisualStyleBackColor = true;
            this.btnAddToList.Click += new System.EventHandler(this.btnAddToList_Click);
            // 
            // txbNumber
            // 
            this.txbNumber.Location = new System.Drawing.Point(97, 18);
            this.txbNumber.Multiline = true;
            this.txbNumber.Name = "txbNumber";
            this.txbNumber.Size = new System.Drawing.Size(139, 27);
            this.txbNumber.TabIndex = 1;
            // 
            // lbNumber
            // 
            this.lbNumber.AutoSize = true;
            this.lbNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumber.Location = new System.Drawing.Point(13, 25);
            this.lbNumber.Name = "lbNumber";
            this.lbNumber.Size = new System.Drawing.Size(68, 20);
            this.lbNumber.TabIndex = 0;
            this.lbNumber.Text = "Nhập số";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lvArray);
            this.panel2.Location = new System.Drawing.Point(329, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(254, 445);
            this.panel2.TabIndex = 1;
            // 
            // lvArray
            // 
            this.lvArray.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clNumber});
            this.lvArray.FullRowSelect = true;
            this.lvArray.GridLines = true;
            this.lvArray.HideSelection = false;
            this.lvArray.Location = new System.Drawing.Point(20, 19);
            this.lvArray.Name = "lvArray";
            this.lvArray.Size = new System.Drawing.Size(216, 407);
            this.lvArray.TabIndex = 0;
            this.lvArray.UseCompatibleStateImageBehavior = false;
            this.lvArray.View = System.Windows.Forms.View.Details;
            // 
            // clNumber
            // 
            this.clNumber.Text = "";
            this.clNumber.Width = 220;
            // 
            // lbListView
            // 
            this.lbListView.AutoSize = true;
            this.lbListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListView.Location = new System.Drawing.Point(345, 10);
            this.lbListView.Name = "lbListView";
            this.lbListView.Size = new System.Drawing.Size(58, 20);
            this.lbListView.TabIndex = 1;
            this.lbListView.Text = "Dãy số";
            // 
            // btnSum
            // 
            this.btnSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSum.Location = new System.Drawing.Point(599, 47);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(101, 40);
            this.btnSum.TabIndex = 3;
            this.btnSum.Text = "Tính tổng";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnMax
            // 
            this.btnMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMax.Location = new System.Drawing.Point(599, 109);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(101, 34);
            this.btnMax.TabIndex = 4;
            this.btnMax.Text = "Tìm max";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(599, 167);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(101, 40);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbSum
            // 
            this.lbSum.AutoSize = true;
            this.lbSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSum.Location = new System.Drawing.Point(715, 57);
            this.lbSum.Name = "lbSum";
            this.lbSum.Size = new System.Drawing.Size(0, 20);
            this.lbSum.TabIndex = 6;
            this.lbSum.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbMax
            // 
            this.lbMax.AutoSize = true;
            this.lbMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMax.Location = new System.Drawing.Point(715, 116);
            this.lbMax.Name = "lbMax";
            this.lbMax.Size = new System.Drawing.Size(0, 20);
            this.lbMax.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 519);
            this.Controls.Add(this.lbMax);
            this.Controls.Add(this.lbSum);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.lbListView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAddToList;
        private System.Windows.Forms.TextBox txbNumber;
        private System.Windows.Forms.Label lbNumber;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lvArray;
        private System.Windows.Forms.Label lbListView;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbSum;
        private System.Windows.Forms.Label lbMax;
        private System.Windows.Forms.ColumnHeader clNumber;
    }
}

