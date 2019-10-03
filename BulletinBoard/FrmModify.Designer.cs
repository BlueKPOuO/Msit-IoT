namespace BulletinBoard
{
    partial class frmModify
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
            this.label15 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.button9 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(300, 561);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label15.Location = new System.Drawing.Point(407, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 21);
            this.label15.TabIndex = 50;
            this.label15.Text = "修改公告";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox5.Location = new System.Drawing.Point(585, 478);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(336, 29);
            this.textBox5.TabIndex = 49;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox6.Location = new System.Drawing.Point(585, 289);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(410, 175);
            this.textBox6.TabIndex = 47;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox7.Location = new System.Drawing.Point(585, 241);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(200, 29);
            this.textBox7.TabIndex = 46;
            // 
            // textBox8
            // 
            this.textBox8.Enabled = false;
            this.textBox8.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox8.Location = new System.Drawing.Point(585, 44);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(200, 29);
            this.textBox8.TabIndex = 43;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button8.Location = new System.Drawing.Point(927, 479);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(68, 28);
            this.button8.TabIndex = 48;
            this.button8.Text = "．．．";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(585, 185);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 45;
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "一般公告",
            "設備更換",
            "人事公告",
            "停車公告",
            "施工公告",
            "會議通知"});
            this.comboBox3.Location = new System.Drawing.Point(585, 145);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(200, 28);
            this.comboBox3.TabIndex = 44;
            // 
            // comboBox4
            // 
            this.comboBox4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "無",
            "公告",
            "重要公告"});
            this.comboBox4.Location = new System.Drawing.Point(585, 93);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(200, 28);
            this.comboBox4.TabIndex = 42;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button9.Location = new System.Drawing.Point(902, 513);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(93, 31);
            this.button9.TabIndex = 41;
            this.button9.Text = "確定修改";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(531, 483);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 21);
            this.label8.TabIndex = 40;
            this.label8.Text = "附件";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(493, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 21);
            this.label9.TabIndex = 39;
            this.label9.Text = "公告內容";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(493, 241);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 21);
            this.label10.TabIndex = 38;
            this.label10.Text = "公告標題";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(493, 193);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 21);
            this.label11.TabIndex = 37;
            this.label11.Text = "公告日期";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(493, 145);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 21);
            this.label12.TabIndex = 36;
            this.label12.Text = "公告類別";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.Location = new System.Drawing.Point(493, 97);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 21);
            this.label13.TabIndex = 35;
            this.label13.Text = "公告等級";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.Location = new System.Drawing.Point(493, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 21);
            this.label14.TabIndex = 34;
            this.label14.Text = "發布人";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Name = "frmModify";
            this.Text = "FrmModify";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.button9, 0);
            this.Controls.SetChildIndex(this.comboBox4, 0);
            this.Controls.SetChildIndex(this.comboBox3, 0);
            this.Controls.SetChildIndex(this.dateTimePicker2, 0);
            this.Controls.SetChildIndex(this.button8, 0);
            this.Controls.SetChildIndex(this.textBox8, 0);
            this.Controls.SetChildIndex(this.textBox7, 0);
            this.Controls.SetChildIndex(this.textBox6, 0);
            this.Controls.SetChildIndex(this.textBox5, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}