namespace EquipSys
{
    partial class FormEqMain
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.Controls.SetChildIndex(this.Titlelb, 0);
            this.panel1.Controls.SetChildIndex(this.treeView1, 0);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 123);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(275, 405);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(355, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(755, 450);
            this.dataGridView1.TabIndex = 3;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(856, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(96, 54);
            this.button6.TabIndex = 19;
            this.button6.Text = "全部物品";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_2);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(746, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(96, 54);
            this.button5.TabIndex = 17;
            this.button5.Text = "設備詳細資訊";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(636, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 54);
            this.button4.TabIndex = 16;
            this.button4.Text = "預約";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(526, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 54);
            this.button3.TabIndex = 15;
            this.button3.Text = "修改";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(416, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 54);
            this.button2.TabIndex = 14;
            this.button2.Text = "刪除";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 54);
            this.button1.TabIndex = 13;
            this.button1.Text = "新增";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(966, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(96, 54);
            this.button7.TabIndex = 20;
            this.button7.Text = "報修";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click_2);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(1076, 12);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(96, 54);
            this.button8.TabIndex = 21;
            this.button8.Text = "維修情形";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click_2);
            // 
            // FormEqMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormEqMain";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.button5, 0);
            this.Controls.SetChildIndex(this.button6, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.button7, 0);
            this.Controls.SetChildIndex(this.button8, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}