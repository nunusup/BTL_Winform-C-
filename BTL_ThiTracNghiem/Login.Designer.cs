namespace BTL_ThiTracNghiem
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.rdsinhvienck = new System.Windows.Forms.RadioButton();
            this.rdquanlyck = new System.Windows.Forms.RadioButton();
            this.batdau = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(471, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "HỆ THỐNG THI TRẮC NGHIỆM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(400, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Sinh Viên / Mã AD";
            // 
            // txtcode
            // 
            this.txtcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcode.Location = new System.Drawing.Point(667, 370);
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(309, 35);
            this.txtcode.TabIndex = 2;
            this.txtcode.Validating += new System.ComponentModel.CancelEventHandler(this.txtcode_Validating);
            // 
            // rdsinhvienck
            // 
            this.rdsinhvienck.AutoSize = true;
            this.rdsinhvienck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdsinhvienck.Location = new System.Drawing.Point(657, 438);
            this.rdsinhvienck.Name = "rdsinhvienck";
            this.rdsinhvienck.Size = new System.Drawing.Size(140, 33);
            this.rdsinhvienck.TabIndex = 3;
            this.rdsinhvienck.TabStop = true;
            this.rdsinhvienck.Text = "Sinh Viên";
            this.rdsinhvienck.UseVisualStyleBackColor = true;
            // 
            // rdquanlyck
            // 
            this.rdquanlyck.AutoSize = true;
            this.rdquanlyck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdquanlyck.Location = new System.Drawing.Point(829, 438);
            this.rdquanlyck.Name = "rdquanlyck";
            this.rdquanlyck.Size = new System.Drawing.Size(158, 33);
            this.rdquanlyck.TabIndex = 4;
            this.rdquanlyck.TabStop = true;
            this.rdquanlyck.Text = "Quản lý HT";
            this.rdquanlyck.UseVisualStyleBackColor = true;
            // 
            // batdau
            // 
            this.batdau.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batdau.Location = new System.Drawing.Point(560, 496);
            this.batdau.Name = "batdau";
            this.batdau.Size = new System.Drawing.Size(260, 64);
            this.batdau.TabIndex = 5;
            this.batdau.Text = "Bắt Đầu";
            this.batdau.UseVisualStyleBackColor = true;
            this.batdau.Click += new System.EventHandler(this.batdau_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1487, 807);
            this.Controls.Add(this.batdau);
            this.Controls.Add(this.rdquanlyck);
            this.Controls.Add(this.rdsinhvienck);
            this.Controls.Add(this.txtcode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Đăng Nhập Vào Hệ Thống Thi Trắc Nghiệm";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.RadioButton rdsinhvienck;
        private System.Windows.Forms.RadioButton rdquanlyck;
        private System.Windows.Forms.Button batdau;
    }
}