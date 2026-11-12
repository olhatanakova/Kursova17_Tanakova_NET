namespace Kursova17
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblXmin = new System.Windows.Forms.Label();
            this.lblXmax = new System.Windows.Forms.Label();
            this.lblDx = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.txtXmin = new System.Windows.Forms.TextBox();
            this.txtXmax = new System.Windows.Forms.TextBox();
            this.txtDx = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.lblF1 = new System.Windows.Forms.Label();
            this.lblF2 = new System.Windows.Forms.Label();
            this.txtF1 = new System.Windows.Forms.TextBox();
            this.txtF2 = new System.Windows.Forms.TextBox();
            this.lstF1 = new System.Windows.Forms.ListBox();
            this.lstF2 = new System.Windows.Forms.ListBox();
            this.lblList1 = new System.Windows.Forms.Label();
            this.lblList2 = new System.Windows.Forms.Label();
            this.lblCnt1 = new System.Windows.Forms.Label();
            this.lblCnt2 = new System.Windows.Forms.Label();
            this.txtCnt1 = new System.Windows.Forms.TextBox();
            this.txtCnt2 = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPhoto = new System.Windows.Forms.Button();
            this.picStudent = new System.Windows.Forms.PictureBox();
            this.lblPhoto = new System.Windows.Forms.Label();
            this.txtStudent = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // lblXmin
            // 
            this.lblXmin.AutoSize = true;
            this.lblXmin.Location = new System.Drawing.Point(16, 18);
            this.lblXmin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblXmin.Name = "lblXmin";
            this.lblXmin.Size = new System.Drawing.Size(37, 16);
            this.lblXmin.TabIndex = 25;
            this.lblXmin.Text = "xmin:";
            // 
            // lblXmax
            // 
            this.lblXmax.AutoSize = true;
            this.lblXmax.Location = new System.Drawing.Point(200, 18);
            this.lblXmax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblXmax.Name = "lblXmax";
            this.lblXmax.Size = new System.Drawing.Size(41, 16);
            this.lblXmax.TabIndex = 23;
            this.lblXmax.Text = "xmax:";
            // 
            // lblDx
            // 
            this.lblDx.AutoSize = true;
            this.lblDx.Location = new System.Drawing.Point(387, 18);
            this.lblDx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDx.Name = "lblDx";
            this.lblDx.Size = new System.Drawing.Size(24, 16);
            this.lblDx.TabIndex = 21;
            this.lblDx.Text = "dx:";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(540, 18);
            this.lblA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(18, 16);
            this.lblA.TabIndex = 19;
            this.lblA.Text = "a:";
            // 
            // txtXmin
            // 
            this.txtXmin.Location = new System.Drawing.Point(73, 15);
            this.txtXmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtXmin.Name = "txtXmin";
            this.txtXmin.Size = new System.Drawing.Size(105, 22);
            this.txtXmin.TabIndex = 24;
            this.txtXmin.Text = "-1";
            // 
            // txtXmax
            // 
            this.txtXmax.Location = new System.Drawing.Point(260, 15);
            this.txtXmax.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtXmax.Name = "txtXmax";
            this.txtXmax.Size = new System.Drawing.Size(105, 22);
            this.txtXmax.TabIndex = 22;
            this.txtXmax.Text = "2";
            // 
            // txtDx
            // 
            this.txtDx.Location = new System.Drawing.Point(427, 15);
            this.txtDx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDx.Name = "txtDx";
            this.txtDx.Size = new System.Drawing.Size(92, 22);
            this.txtDx.TabIndex = 20;
            this.txtDx.Text = "0.25";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(567, 15);
            this.txtA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(92, 22);
            this.txtA.TabIndex = 18;
            this.txtA.Text = "1";
            // 
            // lblF1
            // 
            this.lblF1.AutoSize = true;
            this.lblF1.Location = new System.Drawing.Point(16, 55);
            this.lblF1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblF1.Name = "lblF1";
            this.lblF1.Size = new System.Drawing.Size(96, 16);
            this.lblF1.TabIndex = 17;
            this.lblF1.Text = "f1 (0 < q ≤ 0.25):";
            // 
            // lblF2
            // 
            this.lblF2.AutoSize = true;
            this.lblF2.Location = new System.Drawing.Point(16, 89);
            this.lblF2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblF2.Name = "lblF2";
            this.lblF2.Size = new System.Drawing.Size(96, 16);
            this.lblF2.TabIndex = 15;
            this.lblF2.Text = "f2 (0.25 < q ≤ 1):";
            // 
            // txtF1
            // 
            this.txtF1.Location = new System.Drawing.Point(187, 52);
            this.txtF1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtF1.Name = "txtF1";
            this.txtF1.ReadOnly = true;
            this.txtF1.Size = new System.Drawing.Size(472, 22);
            this.txtF1.TabIndex = 16;
            this.txtF1.Text = "log(q · cos(a − x)) / (q · x)";
            // 
            // txtF2
            // 
            this.txtF2.Location = new System.Drawing.Point(187, 85);
            this.txtF2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtF2.Name = "txtF2";
            this.txtF2.ReadOnly = true;
            this.txtF2.Size = new System.Drawing.Size(472, 22);
            this.txtF2.TabIndex = 14;
            this.txtF2.Text = "∛(q − sin(a · x))";
            // 
            // lstF1
            // 
            this.lstF1.FormattingEnabled = true;
            this.lstF1.HorizontalScrollbar = true;
            this.lstF1.ItemHeight = 16;
            this.lstF1.Location = new System.Drawing.Point(16, 150);
            this.lstF1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstF1.Name = "lstF1";
            this.lstF1.Size = new System.Drawing.Size(505, 276);
            this.lstF1.TabIndex = 10;
            // 
            // lstF2
            // 
            this.lstF2.FormattingEnabled = true;
            this.lstF2.HorizontalScrollbar = true;
            this.lstF2.ItemHeight = 16;
            this.lstF2.Location = new System.Drawing.Point(540, 150);
            this.lstF2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstF2.Name = "lstF2";
            this.lstF2.Size = new System.Drawing.Size(505, 276);
            this.lstF2.TabIndex = 11;
            // 
            // lblList1
            // 
            this.lblList1.AutoSize = true;
            this.lblList1.Location = new System.Drawing.Point(16, 129);
            this.lblList1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblList1.Name = "lblList1";
            this.lblList1.Size = new System.Drawing.Size(101, 16);
            this.lblList1.TabIndex = 13;
            this.lblList1.Text = "Результати f1:";
            // 
            // lblList2
            // 
            this.lblList2.AutoSize = true;
            this.lblList2.Location = new System.Drawing.Point(540, 129);
            this.lblList2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblList2.Name = "lblList2";
            this.lblList2.Size = new System.Drawing.Size(101, 16);
            this.lblList2.TabIndex = 12;
            this.lblList2.Text = "Результати f2:";
            // 
            // lblCnt1
            // 
            this.lblCnt1.AutoSize = true;
            this.lblCnt1.Location = new System.Drawing.Point(16, 443);
            this.lblCnt1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCnt1.Name = "lblCnt1";
            this.lblCnt1.Size = new System.Drawing.Size(81, 16);
            this.lblCnt1.TabIndex = 10;
            this.lblCnt1.Text = "Успішних f1:";
            // 
            // lblCnt2
            // 
            this.lblCnt2.AutoSize = true;
            this.lblCnt2.Location = new System.Drawing.Point(280, 443);
            this.lblCnt2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCnt2.Name = "lblCnt2";
            this.lblCnt2.Size = new System.Drawing.Size(81, 16);
            this.lblCnt2.TabIndex = 8;
            this.lblCnt2.Text = "Успішних f2:";
            // 
            // txtCnt1
            // 
            this.txtCnt1.Location = new System.Drawing.Point(167, 439);
            this.txtCnt1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCnt1.Name = "txtCnt1";
            this.txtCnt1.ReadOnly = true;
            this.txtCnt1.Size = new System.Drawing.Size(79, 22);
            this.txtCnt1.TabIndex = 9;
            this.txtCnt1.Text = "0";
            // 
            // txtCnt2
            // 
            this.txtCnt2.Location = new System.Drawing.Point(427, 439);
            this.txtCnt2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCnt2.Name = "txtCnt2";
            this.txtCnt2.ReadOnly = true;
            this.txtCnt2.Size = new System.Drawing.Size(79, 22);
            this.txtCnt2.TabIndex = 7;
            this.txtCnt2.Text = "0";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(16, 486);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(147, 37);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Обчислити";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(180, 486);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(147, 37);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Очистити";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPhoto
            // 
            this.btnPhoto.Location = new System.Drawing.Point(347, 486);
            this.btnPhoto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPhoto.Name = "btnPhoto";
            this.btnPhoto.Size = new System.Drawing.Size(173, 37);
            this.btnPhoto.TabIndex = 4;
            this.btnPhoto.Text = "Завантажити фото";
            this.btnPhoto.UseVisualStyleBackColor = true;
            this.btnPhoto.Click += new System.EventHandler(this.btnPhoto_Click);
            // 
            // picStudent
            // 
            this.picStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picStudent.Location = new System.Drawing.Point(1066, 18);
            this.picStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picStudent.Name = "picStudent";
            this.picStudent.Size = new System.Drawing.Size(213, 221);
            this.picStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picStudent.TabIndex = 3;
            this.picStudent.TabStop = false;
            // 
            // lblPhoto
            // 
            this.lblPhoto.AutoSize = true;
            this.lblPhoto.Location = new System.Drawing.Point(1093, 111);
            this.lblPhoto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhoto.Name = "lblPhoto";
            this.lblPhoto.Size = new System.Drawing.Size(159, 16);
            this.lblPhoto.TabIndex = 2;
            this.lblPhoto.Text = "(фото не завантажено)";
            // 
            // txtStudent
            // 
            this.txtStudent.Location = new System.Drawing.Point(1067, 246);
            this.txtStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStudent.Name = "txtStudent";
            this.txtStudent.ReadOnly = true;
            this.txtStudent.Size = new System.Drawing.Size(212, 22);
            this.txtStudent.TabIndex = 1;
            this.txtStudent.Text = "Танакова О. І., КН-52/1";
            this.txtStudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(16, 542);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 16);
            this.lblStatus.TabIndex = 0;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 578);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtStudent);
            this.Controls.Add(this.lblPhoto);
            this.Controls.Add(this.picStudent);
            this.Controls.Add(this.btnPhoto);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtCnt2);
            this.Controls.Add(this.lblCnt2);
            this.Controls.Add(this.txtCnt1);
            this.Controls.Add(this.lblCnt1);
            this.Controls.Add(this.lstF2);
            this.Controls.Add(this.lblList2);
            this.Controls.Add(this.lstF1);
            this.Controls.Add(this.lblList1);
            this.Controls.Add(this.txtF2);
            this.Controls.Add(this.lblF2);
            this.Controls.Add(this.txtF1);
            this.Controls.Add(this.lblF1);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.txtDx);
            this.Controls.Add(this.lblDx);
            this.Controls.Add(this.txtXmax);
            this.Controls.Add(this.lblXmax);
            this.Controls.Add(this.txtXmin);
            this.Controls.Add(this.lblXmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Табуляція функцій (варіант 17) — Танакова О. І., КН-52/1";
            ((System.ComponentModel.ISupportInitialize)(this.picStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblXmin;
        private System.Windows.Forms.Label lblXmax;
        private System.Windows.Forms.Label lblDx;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txtXmin;
        private System.Windows.Forms.TextBox txtXmax;
        private System.Windows.Forms.TextBox txtDx;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lblF1;
        private System.Windows.Forms.Label lblF2;
        private System.Windows.Forms.TextBox txtF1;
        private System.Windows.Forms.TextBox txtF2;
        private System.Windows.Forms.ListBox lstF1;
        private System.Windows.Forms.ListBox lstF2;
        private System.Windows.Forms.Label lblList1;
        private System.Windows.Forms.Label lblList2;
        private System.Windows.Forms.Label lblCnt1;
        private System.Windows.Forms.Label lblCnt2;
        private System.Windows.Forms.TextBox txtCnt1;
        private System.Windows.Forms.TextBox txtCnt2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPhoto;
        private System.Windows.Forms.PictureBox picStudent;
        private System.Windows.Forms.Label lblPhoto;
        private System.Windows.Forms.TextBox txtStudent;
        private System.Windows.Forms.Label lblStatus;
    }
}
