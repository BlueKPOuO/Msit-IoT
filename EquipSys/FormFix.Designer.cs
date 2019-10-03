namespace EquipSys
{
    partial class FormFix
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
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.SetChildIndex(this.Titlelb, 0);
            this.panel1.Controls.SetChildIndex(this.label7, 0);
            this.panel1.Controls.SetChildIndex(this.textBox6, 0);
            this.panel1.Controls.SetChildIndex(this.label1, 0);
            this.panel1.Controls.SetChildIndex(this.dateTimePicker1, 0);
            this.panel1.Controls.SetChildIndex(this.button1, 0);
            this.panel1.Controls.SetChildIndex(this.textBox1, 0);
            this.panel1.Controls.SetChildIndex(this.label2, 0);
            this.panel1.Controls.SetChildIndex(this.button2, 0);
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(127, 126);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.label7.Location = new System.Drawing.Point(40, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 16);
            this.label7.TabIndex = 31;
            this.label7.Text = "設備編號:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.label1.Location = new System.Drawing.Point(40, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "報修日期:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(127, 183);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(127, 22);
            this.dateTimePicker1.TabIndex = 33;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 52);
            this.button1.TabIndex = 34;
            this.button1.Text = "確定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 275);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 155);
            this.textBox1.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.label2.Location = new System.Drawing.Point(40, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "報修原因:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(179, 453);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 52);
            this.button2.TabIndex = 37;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormFix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 561);
            this.Name = "FormFix";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormFix";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}