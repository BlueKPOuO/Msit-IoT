namespace PublicSpacesys
{
    partial class Register
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbLocation = new System.Windows.Forms.ComboBox();
            this.btnBarry = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpTime1 = new System.Windows.Forms.DateTimePicker();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(414, 166);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(275, 22);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(330, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "地點:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(330, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "借用時數:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(330, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "用途:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(330, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "租借人:";
            // 
            // cbLocation
            // 
            this.cbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.Items.AddRange(new object[] {
            "一樓大廳",
            "一樓交誼廳",
            "三樓健身房",
            "五樓會議室",
            "三樓韻律室",
            "屋頂花園",
            "中庭花園",
            "B1停車場"});
            this.cbLocation.Location = new System.Drawing.Point(414, 54);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(275, 20);
            this.cbLocation.TabIndex = 10;
            // 
            // btnBarry
            // 
            this.btnBarry.Location = new System.Drawing.Point(803, 55);
            this.btnBarry.Name = "btnBarry";
            this.btnBarry.Size = new System.Drawing.Size(104, 41);
            this.btnBarry.TabIndex = 11;
            this.btnBarry.Text = "登記借用";
            this.btnBarry.UseVisualStyleBackColor = true;
            this.btnBarry.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(803, 110);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 41);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(330, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "借用時間:";
            // 
            // dtpTime1
            // 
            this.dtpTime1.Location = new System.Drawing.Point(414, 89);
            this.dtpTime1.Name = "dtpTime1";
            this.dtpTime1.Size = new System.Drawing.Size(275, 22);
            this.dtpTime1.TabIndex = 13;
            this.dtpTime1.Value = new System.DateTime(2019, 9, 19, 9, 46, 12, 0);
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(414, 206);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(275, 275);
            this.txtReason.TabIndex = 15;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.comboBox1.Location = new System.Drawing.Point(413, 128);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(214, 20);
            this.comboBox1.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(644, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "小時";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.dtpTime1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnBarry);
            this.Controls.Add(this.cbLocation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Name = "Register";
            this.Text = "登記借用";
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.cbLocation, 0);
            this.Controls.SetChildIndex(this.btnBarry, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.dtpTime1, 0);
            this.Controls.SetChildIndex(this.txtReason, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.comboBox1, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbLocation;
        private System.Windows.Forms.Button btnBarry;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpTime1;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
    }
}