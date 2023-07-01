namespace BTL_ThiTracNghiem
{
    partial class qlyMonHoc
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxmamon = new System.Windows.Forms.TextBox();
            this.textBoxtenmon = new System.Windows.Forms.TextBox();
            this.buttontkmom = new System.Windows.Forms.Button();
            this.buttonsuamon = new System.Windows.Forms.Button();
            this.buttonxoamon = new System.Windows.Forms.Button();
            this.buttonthemmon = new System.Windows.Forms.Button();
            this.dataGridViewmonthi = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewmonthi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(573, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ MÔN THI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(330, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Môn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(330, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã Môn";
            // 
            // textBoxmamon
            // 
            this.textBoxmamon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxmamon.Location = new System.Drawing.Point(459, 317);
            this.textBoxmamon.Name = "textBoxmamon";
            this.textBoxmamon.Size = new System.Drawing.Size(200, 35);
            this.textBoxmamon.TabIndex = 4;
            // 
            // textBoxtenmon
            // 
            this.textBoxtenmon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxtenmon.Location = new System.Drawing.Point(459, 358);
            this.textBoxtenmon.Name = "textBoxtenmon";
            this.textBoxtenmon.Size = new System.Drawing.Size(200, 35);
            this.textBoxtenmon.TabIndex = 5;
            // 
            // buttontkmom
            // 
            this.buttontkmom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttontkmom.Location = new System.Drawing.Point(445, 461);
            this.buttontkmom.Name = "buttontkmom";
            this.buttontkmom.Size = new System.Drawing.Size(214, 51);
            this.buttontkmom.TabIndex = 21;
            this.buttontkmom.Text = "Tìm Kiếm";
            this.buttontkmom.UseVisualStyleBackColor = true;
            this.buttontkmom.Click += new System.EventHandler(this.buttontkmom_Click);
            // 
            // buttonsuamon
            // 
            this.buttonsuamon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsuamon.Location = new System.Drawing.Point(555, 407);
            this.buttonsuamon.Name = "buttonsuamon";
            this.buttonsuamon.Size = new System.Drawing.Size(104, 48);
            this.buttonsuamon.TabIndex = 20;
            this.buttonsuamon.Text = "Sửa";
            this.buttonsuamon.UseVisualStyleBackColor = true;
            this.buttonsuamon.Click += new System.EventHandler(this.buttonsuamon_Click);
            // 
            // buttonxoamon
            // 
            this.buttonxoamon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonxoamon.Location = new System.Drawing.Point(444, 407);
            this.buttonxoamon.Name = "buttonxoamon";
            this.buttonxoamon.Size = new System.Drawing.Size(105, 48);
            this.buttonxoamon.TabIndex = 19;
            this.buttonxoamon.Text = "Xóa";
            this.buttonxoamon.UseVisualStyleBackColor = true;
            this.buttonxoamon.Click += new System.EventHandler(this.buttonxoamon_Click);
            // 
            // buttonthemmon
            // 
            this.buttonthemmon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonthemmon.Location = new System.Drawing.Point(325, 407);
            this.buttonthemmon.Name = "buttonthemmon";
            this.buttonthemmon.Size = new System.Drawing.Size(104, 48);
            this.buttonthemmon.TabIndex = 18;
            this.buttonthemmon.Text = "Thêm";
            this.buttonthemmon.UseVisualStyleBackColor = true;
            this.buttonthemmon.Click += new System.EventHandler(this.buttonthemmon_Click);
            // 
            // dataGridViewmonthi
            // 
            this.dataGridViewmonthi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewmonthi.Location = new System.Drawing.Point(704, 258);
            this.dataGridViewmonthi.Name = "dataGridViewmonthi";
            this.dataGridViewmonthi.RowHeadersWidth = 62;
            this.dataGridViewmonthi.RowTemplate.Height = 28;
            this.dataGridViewmonthi.Size = new System.Drawing.Size(386, 288);
            this.dataGridViewmonthi.TabIndex = 22;
            this.dataGridViewmonthi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewmonthi_CellContentClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(325, 461);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 51);
            this.button1.TabIndex = 23;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // qlyMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 845);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewmonthi);
            this.Controls.Add(this.buttontkmom);
            this.Controls.Add(this.buttonsuamon);
            this.Controls.Add(this.buttonxoamon);
            this.Controls.Add(this.buttonthemmon);
            this.Controls.Add(this.textBoxtenmon);
            this.Controls.Add(this.textBoxmamon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "qlyMonHoc";
            this.Text = "Quản Lý Môn Học";
            this.Load += new System.EventHandler(this.qlyMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewmonthi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxmamon;
        private System.Windows.Forms.TextBox textBoxtenmon;
        private System.Windows.Forms.Button buttontkmom;
        private System.Windows.Forms.Button buttonsuamon;
        private System.Windows.Forms.Button buttonxoamon;
        private System.Windows.Forms.Button buttonthemmon;
        private System.Windows.Forms.DataGridView dataGridViewmonthi;
        private System.Windows.Forms.Button button1;
    }
}