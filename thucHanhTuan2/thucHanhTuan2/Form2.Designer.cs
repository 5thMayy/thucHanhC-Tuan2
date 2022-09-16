namespace thucHanhTuan2
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
            this.lbSearchCustommer = new System.Windows.Forms.Label();
            this.tbTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchCus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbSearchCustommer
            // 
            this.lbSearchCustommer.AutoSize = true;
            this.lbSearchCustommer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearchCustommer.Location = new System.Drawing.Point(165, 205);
            this.lbSearchCustommer.Name = "lbSearchCustommer";
            this.lbSearchCustommer.Size = new System.Drawing.Size(0, 25);
            this.lbSearchCustommer.TabIndex = 0;
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.Location = new System.Drawing.Point(303, 111);
            this.tbTimKiem.Multiline = true;
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(85, 32);
            this.tbTimKiem.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhap ID khach hang can tim kiem";
            // 
            // btnSearchCus
            // 
            this.btnSearchCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCus.Location = new System.Drawing.Point(303, 344);
            this.btnSearchCus.Name = "btnSearchCus";
            this.btnSearchCus.Size = new System.Drawing.Size(85, 33);
            this.btnSearchCus.TabIndex = 3;
            this.btnSearchCus.Text = "Tim Kiem";
            this.btnSearchCus.UseVisualStyleBackColor = true;
            this.btnSearchCus.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSearchCus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTimKiem);
            this.Controls.Add(this.lbSearchCustommer);
            this.Name = "Form2";
            this.Text = "Tìm kiếm khách hàng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSearchCustommer;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbTimKiem;
        private System.Windows.Forms.Button btnSearchCus;
    }
}