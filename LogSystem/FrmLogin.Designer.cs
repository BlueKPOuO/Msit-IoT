namespace LogSystem
{
    partial class FrmLogin
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
            this.tbPW = new System.Windows.Forms.TextBox();
            this.lbPW = new System.Windows.Forms.Label();
            this.tbUN = new System.Windows.Forms.TextBox();
            this.lbUserName = new System.Windows.Forms.Label();
            this.btnCreateFrm = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.btnCreateFrm);
            this.panel1.Controls.Add(this.lbPW);
            this.panel1.Controls.Add(this.tbUN);
            this.panel1.Controls.Add(this.lbUserName);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.tbPW);
            this.panel1.Size = new System.Drawing.Size(300, 569);
            this.panel1.Controls.SetChildIndex(this.Titlelb, 0);
            this.panel1.Controls.SetChildIndex(this.tbPW, 0);
            this.panel1.Controls.SetChildIndex(this.btnLogin, 0);
            this.panel1.Controls.SetChildIndex(this.lbUserName, 0);
            this.panel1.Controls.SetChildIndex(this.tbUN, 0);
            this.panel1.Controls.SetChildIndex(this.lbPW, 0);
            this.panel1.Controls.SetChildIndex(this.btnCreateFrm, 0);
            this.panel1.Controls.SetChildIndex(this.checkBox1, 0);
            // 
            // tbPW
            // 
            this.tbPW.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbPW.Location = new System.Drawing.Point(120, 209);
            this.tbPW.Name = "tbPW";
            this.tbPW.Size = new System.Drawing.Size(165, 29);
            this.tbPW.TabIndex = 7;
            this.tbPW.Leave += new System.EventHandler(this.tbPW_Leave);
            // 
            // lbPW
            // 
            this.lbPW.AutoSize = true;
            this.lbPW.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbPW.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(181)))));
            this.lbPW.Location = new System.Drawing.Point(53, 212);
            this.lbPW.Name = "lbPW";
            this.lbPW.Size = new System.Drawing.Size(41, 20);
            this.lbPW.TabIndex = 6;
            this.lbPW.Text = "密碼";
            // 
            // tbUN
            // 
            this.tbUN.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbUN.Location = new System.Drawing.Point(120, 163);
            this.tbUN.Name = "tbUN";
            this.tbUN.Size = new System.Drawing.Size(165, 29);
            this.tbUN.TabIndex = 5;
            this.tbUN.Leave += new System.EventHandler(this.tbUN_Leave);
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(181)))));
            this.lbUserName.Location = new System.Drawing.Point(5, 166);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(89, 20);
            this.lbUserName.TabIndex = 4;
            this.lbUserName.Text = "使用者名稱";
            // 
            // btnCreateFrm
            // 
            this.btnCreateFrm.Location = new System.Drawing.Point(177, 353);
            this.btnCreateFrm.Name = "btnCreateFrm";
            this.btnCreateFrm.Size = new System.Drawing.Size(106, 25);
            this.btnCreateFrm.TabIndex = 11;
            this.btnCreateFrm.Text = "沒有帳號建立";
            this.btnCreateFrm.UseVisualStyleBackColor = true;
            this.btnCreateFrm.Click += new System.EventHandler(this.btnCreateFrm_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnLogin.Location = new System.Drawing.Point(89, 290);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(127, 39);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "登入";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(300, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 569);
            this.panel3.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(181)))));
            this.checkBox1.Location = new System.Drawing.Point(68, 254);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(217, 21);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "記住帳號密碼(公用電腦請勿勾選)";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 569);
            this.Controls.Add(this.panel3);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLogin_FormClosing);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbPW;
        private System.Windows.Forms.Label lbPW;
        private System.Windows.Forms.TextBox tbUN;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Button btnCreateFrm;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}