namespace TabControl
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rdbM2 = new System.Windows.Forms.RadioButton();
            this.rdbM1 = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rdbS3 = new System.Windows.Forms.RadioButton();
            this.rdbS2 = new System.Windows.Forms.RadioButton();
            this.rdbS1 = new System.Windows.Forms.RadioButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.rdbD4 = new System.Windows.Forms.RadioButton();
            this.rdbD3 = new System.Windows.Forms.RadioButton();
            this.rdbD2 = new System.Windows.Forms.RadioButton();
            this.rdbD1 = new System.Windows.Forms.RadioButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.chkD = new System.Windows.Forms.CheckBox();
            this.chkS = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAmt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(23, 21);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(452, 87);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rdbM2);
            this.tabPage1.Controls.Add(this.rdbM1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(444, 58);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "主餐";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rdbM2
            // 
            this.rdbM2.AutoSize = true;
            this.rdbM2.Location = new System.Drawing.Point(218, 20);
            this.rdbM2.Name = "rdbM2";
            this.rdbM2.Size = new System.Drawing.Size(164, 19);
            this.rdbM2.TabIndex = 1;
            this.rdbM2.Text = "2號餐：漢堡餐(95元)";
            this.rdbM2.UseVisualStyleBackColor = true;
            this.rdbM2.CheckedChanged += new System.EventHandler(this.rdbM2_CheckedChanged);
            // 
            // rdbM1
            // 
            this.rdbM1.AutoSize = true;
            this.rdbM1.Checked = true;
            this.rdbM1.Location = new System.Drawing.Point(26, 20);
            this.rdbM1.Name = "rdbM1";
            this.rdbM1.Size = new System.Drawing.Size(171, 19);
            this.rdbM1.TabIndex = 0;
            this.rdbM1.TabStop = true;
            this.rdbM1.Text = "1號餐：雞塊餐(115元)";
            this.rdbM1.UseVisualStyleBackColor = true;
            this.rdbM1.CheckedChanged += new System.EventHandler(this.rdbM1_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rdbS3);
            this.tabPage2.Controls.Add(this.rdbS2);
            this.tabPage2.Controls.Add(this.rdbS1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(444, 58);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "副餐";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rdbS3
            // 
            this.rdbS3.AutoSize = true;
            this.rdbS3.Location = new System.Drawing.Point(221, 18);
            this.rdbS3.Name = "rdbS3";
            this.rdbS3.Size = new System.Drawing.Size(88, 19);
            this.rdbS3.TabIndex = 2;
            this.rdbS3.TabStop = true;
            this.rdbS3.Text = "生菜沙拉";
            this.rdbS3.UseVisualStyleBackColor = true;
         
            // 
            // rdbS2
            // 
            this.rdbS2.AutoSize = true;
            this.rdbS2.Location = new System.Drawing.Point(117, 18);
            this.rdbS2.Name = "rdbS2";
            this.rdbS2.Size = new System.Drawing.Size(73, 19);
            this.rdbS2.TabIndex = 1;
            this.rdbS2.TabStop = true;
            this.rdbS2.Text = "可樂餅";
            this.rdbS2.UseVisualStyleBackColor = true;
            // 
            // rdbS1
            // 
            this.rdbS1.AutoSize = true;
            this.rdbS1.Checked = true;
            this.rdbS1.Location = new System.Drawing.Point(21, 18);
            this.rdbS1.Name = "rdbS1";
            this.rdbS1.Size = new System.Drawing.Size(58, 19);
            this.rdbS1.TabIndex = 0;
            this.rdbS1.TabStop = true;
            this.rdbS1.Text = "薯條";
            this.rdbS1.UseVisualStyleBackColor = true;
            this.rdbS1.CheckedChanged += new System.EventHandler(this.rdbS1_CheckedChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.rdbD4);
            this.tabPage3.Controls.Add(this.rdbD3);
            this.tabPage3.Controls.Add(this.rdbD2);
            this.tabPage3.Controls.Add(this.rdbD1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(444, 58);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "飲料";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // rdbD4
            // 
            this.rdbD4.AutoSize = true;
            this.rdbD4.Location = new System.Drawing.Point(259, 21);
            this.rdbD4.Name = "rdbD4";
            this.rdbD4.Size = new System.Drawing.Size(73, 19);
            this.rdbD4.TabIndex = 3;
            this.rdbD4.TabStop = true;
            this.rdbD4.Text = "冰咖啡";
            this.rdbD4.UseVisualStyleBackColor = true;
            // 
            // rdbD3
            // 
            this.rdbD3.AutoSize = true;
            this.rdbD3.Location = new System.Drawing.Point(169, 21);
            this.rdbD3.Name = "rdbD3";
            this.rdbD3.Size = new System.Drawing.Size(73, 19);
            this.rdbD3.TabIndex = 2;
            this.rdbD3.TabStop = true;
            this.rdbD3.Text = "檸檬茶";
            this.rdbD3.UseVisualStyleBackColor = true;
            // 
            // rdbD2
            // 
            this.rdbD2.AutoSize = true;
            this.rdbD2.Location = new System.Drawing.Point(96, 21);
            this.rdbD2.Name = "rdbD2";
            this.rdbD2.Size = new System.Drawing.Size(58, 19);
            this.rdbD2.TabIndex = 1;
            this.rdbD2.TabStop = true;
            this.rdbD2.Text = "紅茶";
            this.rdbD2.UseVisualStyleBackColor = true;
            // 
            // rdbD1
            // 
            this.rdbD1.AutoSize = true;
            this.rdbD1.Checked = true;
            this.rdbD1.Location = new System.Drawing.Point(20, 21);
            this.rdbD1.Name = "rdbD1";
            this.rdbD1.Size = new System.Drawing.Size(58, 19);
            this.rdbD1.TabIndex = 0;
            this.rdbD1.TabStop = true;
            this.rdbD1.Text = "汽水";
            this.rdbD1.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.chkD);
            this.tabPage4.Controls.Add(this.chkS);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(444, 58);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "升級";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // chkD
            // 
            this.chkD.AutoSize = true;
            this.chkD.Location = new System.Drawing.Point(196, 20);
            this.chkD.Name = "chkD";
            this.chkD.Size = new System.Drawing.Size(89, 19);
            this.chkD.TabIndex = 1;
            this.chkD.Text = "飲料加大";
            this.chkD.UseVisualStyleBackColor = true;
            this.chkD.CheckedChanged += new System.EventHandler(this.chkD_CheckedChanged);
            // 
            // chkS
            // 
            this.chkS.AutoSize = true;
            this.chkS.Enabled = false;
            this.chkS.Location = new System.Drawing.Point(55, 20);
            this.chkS.Name = "chkS";
            this.chkS.Size = new System.Drawing.Size(89, 19);
            this.chkS.TabIndex = 0;
            this.chkS.Text = "薯條加大";
            this.chkS.UseVisualStyleBackColor = true;
            this.chkS.CheckedChanged += new System.EventHandler(this.chkS_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(23, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "小計";
            // 
            // txtSum
            // 
            this.txtSum.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSum.Location = new System.Drawing.Point(78, 116);
            this.txtSum.Name = "txtSum";
            this.txtSum.ReadOnly = true;
            this.txtSum.Size = new System.Drawing.Size(84, 31);
            this.txtSum.TabIndex = 2;
            this.txtSum.Text = "115";
            this.txtSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(182, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "* 數量";
            // 
            // txtNum
            // 
            this.txtNum.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNum.Location = new System.Drawing.Point(252, 118);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(64, 31);
            this.txtNum.TabIndex = 4;
            this.txtNum.Text = "1";
            this.txtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNum.TextChanged += new System.EventHandler(this.txtNum_TextChanged); 
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(326, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "=";
            // 
            // txtAmt
            // 
            this.txtAmt.BackColor = System.Drawing.Color.Black;
            this.txtAmt.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAmt.ForeColor = System.Drawing.Color.White;
            this.txtAmt.Location = new System.Drawing.Point(353, 118);
            this.txtAmt.Name = "txtAmt";
            this.txtAmt.ReadOnly = true;
            this.txtAmt.Size = new System.Drawing.Size(76, 31);
            this.txtAmt.TabIndex = 6;
            this.txtAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(438, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "元";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 160);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAmt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "活力早餐店";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RadioButton rdbM2;
        private System.Windows.Forms.RadioButton rdbM1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.RadioButton rdbS3;
        private System.Windows.Forms.RadioButton rdbS2;
        private System.Windows.Forms.RadioButton rdbS1;
        private System.Windows.Forms.RadioButton rdbD4;
        private System.Windows.Forms.RadioButton rdbD3;
        private System.Windows.Forms.RadioButton rdbD2;
        private System.Windows.Forms.RadioButton rdbD1;
        private System.Windows.Forms.CheckBox chkD;
        private System.Windows.Forms.CheckBox chkS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAmt;
        private System.Windows.Forms.Label label4;
    }
}

