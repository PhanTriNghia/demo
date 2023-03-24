
namespace Tuan05
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btBinhPhuong = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btLapPhuong = new System.Windows.Forms.Button();
            this.btGiaiThua = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chương trình tính toán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số: ";
            // 
            // btBinhPhuong
            // 
            this.btBinhPhuong.Location = new System.Drawing.Point(415, 48);
            this.btBinhPhuong.Name = "btBinhPhuong";
            this.btBinhPhuong.Size = new System.Drawing.Size(121, 38);
            this.btBinhPhuong.TabIndex = 3;
            this.btBinhPhuong.Text = "Bình Phương";
            this.btBinhPhuong.UseVisualStyleBackColor = true;
            this.btBinhPhuong.Click += new System.EventHandler(this.btBinhPhuong_Click);
            this.btBinhPhuong.Enter += new System.EventHandler(this.btBinhPhuong_Click);
            this.btBinhPhuong.Leave += new System.EventHandler(this.btThoat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kết quả: ";
            // 
            // btLapPhuong
            // 
            this.btLapPhuong.Location = new System.Drawing.Point(415, 102);
            this.btLapPhuong.Name = "btLapPhuong";
            this.btLapPhuong.Size = new System.Drawing.Size(121, 31);
            this.btLapPhuong.TabIndex = 5;
            this.btLapPhuong.Text = "Lập Phương";
            this.btLapPhuong.UseVisualStyleBackColor = true;
            this.btLapPhuong.Click += new System.EventHandler(this.btLapPhuong_Click);
            // 
            // btGiaiThua
            // 
            this.btGiaiThua.Location = new System.Drawing.Point(415, 139);
            this.btGiaiThua.Name = "btGiaiThua";
            this.btGiaiThua.Size = new System.Drawing.Size(121, 34);
            this.btGiaiThua.TabIndex = 7;
            this.btGiaiThua.Text = "Giai Thừa";
            this.btGiaiThua.UseVisualStyleBackColor = true;
            this.btGiaiThua.Click += new System.EventHandler(this.btGiaiThua_Click);
            // 
            // btThoat
            // 
            this.btThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btThoat.Location = new System.Drawing.Point(303, 211);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(127, 38);
            this.btThoat.TabIndex = 8;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // txtkq
            // 
            this.txtkq.Enabled = false;
            this.txtkq.Location = new System.Drawing.Point(235, 102);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(159, 22);
            this.txtkq.TabIndex = 9;
            this.txtkq.TextChanged += new System.EventHandler(this.txtkq_TextChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.btBinhPhuong;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btThoat;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btGiaiThua);
            this.Controls.Add(this.btLapPhuong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btBinhPhuong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btBinhPhuong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btLapPhuong;
        private System.Windows.Forms.Button btGiaiThua;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.TextBox txtkq;
    }
}

