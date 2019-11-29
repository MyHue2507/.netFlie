namespace AppG32019
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
            this.components = new System.ComponentModel.Container();
            this.txtSoThuHai = new System.Windows.Forms.TextBox();
            this.txtSoThuNhat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPhepToan = new System.Windows.Forms.ComboBox();
            this.btnTinhToan = new System.Windows.Forms.Button();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSoThuHai
            // 
            this.txtSoThuHai.BackColor = System.Drawing.Color.Red;
            this.txtSoThuHai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoThuHai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoThuHai.ForeColor = System.Drawing.Color.White;
            this.txtSoThuHai.Location = new System.Drawing.Point(106, 133);
            this.txtSoThuHai.Name = "txtSoThuHai";
            this.txtSoThuHai.Size = new System.Drawing.Size(357, 22);
            this.txtSoThuHai.TabIndex = 2;
            // 
            // txtSoThuNhat
            // 
            this.txtSoThuNhat.BackColor = System.Drawing.Color.Red;
            this.txtSoThuNhat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoThuNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoThuNhat.ForeColor = System.Drawing.Color.White;
            this.txtSoThuNhat.Location = new System.Drawing.Point(106, 105);
            this.txtSoThuNhat.Name = "txtSoThuNhat";
            this.txtSoThuNhat.Size = new System.Drawing.Size(357, 22);
            this.txtSoThuNhat.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(12, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số thứ hai:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Số thứ nhất:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Bisque;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(451, 57);
            this.label1.TabIndex = 3;
            this.label1.Text = "BÀI TẬP SỐ 2";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(12, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Phép toán:";
            // 
            // cmbPhepToan
            // 
            this.cmbPhepToan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPhepToan.FormattingEnabled = true;
            this.cmbPhepToan.Items.AddRange(new object[] {
            "Chọn phép tính",
            "Cộng",
            "Trừ",
            "Nhân",
            "Chia"});
            this.cmbPhepToan.Location = new System.Drawing.Point(106, 76);
            this.cmbPhepToan.Name = "cmbPhepToan";
            this.cmbPhepToan.Size = new System.Drawing.Size(141, 21);
            this.cmbPhepToan.TabIndex = 0;
            // 
            // btnTinhToan
            // 
            this.btnTinhToan.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTinhToan.FlatAppearance.BorderSize = 0;
            this.btnTinhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTinhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhToan.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnTinhToan.Location = new System.Drawing.Point(106, 161);
            this.btnTinhToan.Name = "btnTinhToan";
            this.btnTinhToan.Size = new System.Drawing.Size(101, 39);
            this.btnTinhToan.TabIndex = 3;
            this.btnTinhToan.Text = "Tính";
            this.btnTinhToan.UseVisualStyleBackColor = false;
            this.btnTinhToan.Click += new System.EventHandler(this.btnTinhToan_Click);
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 211);
            this.Controls.Add(this.btnTinhToan);
            this.Controls.Add(this.cmbPhepToan);
            this.Controls.Add(this.txtSoThuHai);
            this.Controls.Add(this.txtSoThuNhat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Bài số 2";
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSoThuHai;
        private System.Windows.Forms.TextBox txtSoThuNhat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbPhepToan;
        private System.Windows.Forms.Button btnTinhToan;
        private System.Windows.Forms.ErrorProvider errProvider;
    }
}