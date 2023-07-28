namespace AutoShutdown
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.autoresetbtn = new System.Windows.Forms.RadioButton();
            this.autoshutdownbtn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.actionhint = new System.Windows.Forms.Label();
            this.countdown = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cancelaction = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.autoresetbtn);
            this.groupBox1.Controls.Add(this.autoshutdownbtn);
            this.groupBox1.Location = new System.Drawing.Point(55, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(400, 53);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // autoresetbtn
            // 
            this.autoresetbtn.AutoSize = true;
            this.autoresetbtn.Location = new System.Drawing.Point(277, 18);
            this.autoresetbtn.Name = "autoresetbtn";
            this.autoresetbtn.Size = new System.Drawing.Size(83, 16);
            this.autoresetbtn.TabIndex = 1;
            this.autoresetbtn.Text = "自動重開機";
            this.autoresetbtn.UseVisualStyleBackColor = true;
            // 
            // autoshutdownbtn
            // 
            this.autoshutdownbtn.AutoSize = true;
            this.autoshutdownbtn.Checked = true;
            this.autoshutdownbtn.Location = new System.Drawing.Point(43, 18);
            this.autoshutdownbtn.Name = "autoshutdownbtn";
            this.autoshutdownbtn.Size = new System.Drawing.Size(71, 16);
            this.autoshutdownbtn.TabIndex = 0;
            this.autoshutdownbtn.TabStop = true;
            this.autoshutdownbtn.Text = "自動關機";
            this.autoshutdownbtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "請輸入欲多久後執行(分鐘)：";
            // 
            // actionhint
            // 
            this.actionhint.AutoSize = true;
            this.actionhint.ForeColor = System.Drawing.Color.Red;
            this.actionhint.Location = new System.Drawing.Point(257, 265);
            this.actionhint.Name = "actionhint";
            this.actionhint.Size = new System.Drawing.Size(68, 12);
            this.actionhint.TabIndex = 15;
            this.actionhint.Text = " 後自動關機";
            this.actionhint.Visible = false;
            // 
            // countdown
            // 
            this.countdown.AutoSize = true;
            this.countdown.ForeColor = System.Drawing.Color.Red;
            this.countdown.Location = new System.Drawing.Point(222, 265);
            this.countdown.Name = "countdown";
            this.countdown.Size = new System.Drawing.Size(35, 12);
            this.countdown.TabIndex = 14;
            this.countdown.Text = " 00:00";
            this.countdown.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 12);
            this.label2.TabIndex = 13;
            // 
            // cancelaction
            // 
            this.cancelaction.Location = new System.Drawing.Point(156, 293);
            this.cancelaction.Name = "cancelaction";
            this.cancelaction.Size = new System.Drawing.Size(222, 23);
            this.cancelaction.TabIndex = 12;
            this.cancelaction.UseVisualStyleBackColor = true;
            this.cancelaction.Visible = false;
            this.cancelaction.Click += new System.EventHandler(this.cancelaction_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(272, 146);
            this.maskedTextBox1.Mask = "99999";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.PromptChar = ' ';
            this.maskedTextBox1.Size = new System.Drawing.Size(81, 22);
            this.maskedTextBox1.TabIndex = 16;
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.maskedTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBox1_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 382);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.actionhint);
            this.Controls.Add(this.countdown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancelaction);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton autoresetbtn;
        private System.Windows.Forms.RadioButton autoshutdownbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label actionhint;
        private System.Windows.Forms.Label countdown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancelaction;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}

