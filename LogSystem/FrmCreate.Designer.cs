namespace LogSystem
{
    partial class FrmCreate
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
            this.components = new System.ComponentModel.Container();
            this.lbUserName = new System.Windows.Forms.Label();
            this.tbUN = new System.Windows.Forms.TextBox();
            this.tbPW = new System.Windows.Forms.TextBox();
            this.lbPW = new System.Windows.Forms.Label();
            this.tbAPW = new System.Windows.Forms.TextBox();
            this.lbAPW = new System.Windows.Forms.Label();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.lbemail = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbStaffID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbUserName.Location = new System.Drawing.Point(27, 143);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(150, 34);
            this.lbUserName.TabIndex = 0;
            this.lbUserName.Text = "使用者名稱";
            // 
            // tbUN
            // 
            this.tbUN.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbUN.Location = new System.Drawing.Point(187, 138);
            this.tbUN.Name = "tbUN";
            this.tbUN.Size = new System.Drawing.Size(165, 43);
            this.tbUN.TabIndex = 1;
            this.tbUN.Leave += new System.EventHandler(this.tbUN_Leave);
            // 
            // tbPW
            // 
            this.tbPW.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbPW.Location = new System.Drawing.Point(187, 209);
            this.tbPW.Name = "tbPW";
            this.tbPW.Size = new System.Drawing.Size(165, 43);
            this.tbPW.TabIndex = 3;
            this.tbPW.Leave += new System.EventHandler(this.tbPW_Leave);
            // 
            // lbPW
            // 
            this.lbPW.AutoSize = true;
            this.lbPW.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbPW.Location = new System.Drawing.Point(106, 214);
            this.lbPW.Name = "lbPW";
            this.lbPW.Size = new System.Drawing.Size(69, 34);
            this.lbPW.TabIndex = 2;
            this.lbPW.Text = "密碼";
            // 
            // tbAPW
            // 
            this.tbAPW.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbAPW.Location = new System.Drawing.Point(187, 280);
            this.tbAPW.Name = "tbAPW";
            this.tbAPW.Size = new System.Drawing.Size(165, 43);
            this.tbAPW.TabIndex = 5;
            this.tbAPW.Leave += new System.EventHandler(this.tbAPW_Leave);
            // 
            // lbAPW
            // 
            this.lbAPW.AutoSize = true;
            this.lbAPW.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbAPW.Location = new System.Drawing.Point(51, 285);
            this.lbAPW.Name = "lbAPW";
            this.lbAPW.Size = new System.Drawing.Size(123, 34);
            this.lbAPW.TabIndex = 4;
            this.lbAPW.Text = "確認密碼";
            // 
            // tbemail
            // 
            this.tbemail.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbemail.Location = new System.Drawing.Point(187, 351);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(165, 43);
            this.tbemail.TabIndex = 7;
            this.tbemail.Leave += new System.EventHandler(this.tbemail_Leave);
            // 
            // lbemail
            // 
            this.lbemail.AutoSize = true;
            this.lbemail.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbemail.Location = new System.Drawing.Point(74, 356);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(97, 34);
            this.lbemail.TabIndex = 6;
            this.lbemail.Text = "E-Mail";
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCreate.Location = new System.Drawing.Point(146, 516);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(127, 39);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "建立";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBack.Location = new System.Drawing.Point(254, 567);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(141, 39);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "回到登入";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tbStaffID
            // 
            this.tbStaffID.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbStaffID.Location = new System.Drawing.Point(187, 422);
            this.tbStaffID.Name = "tbStaffID";
            this.tbStaffID.Size = new System.Drawing.Size(165, 43);
            this.tbStaffID.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(50, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 34);
            this.label1.TabIndex = 10;
            this.label1.Text = "警衛編號";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 24F);
            this.label2.Location = new System.Drawing.Point(118, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 40);
            this.label2.TabIndex = 12;
            this.label2.Text = "建立帳號";
            // 
            // FrmCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 644);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbStaffID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.tbemail);
            this.Controls.Add(this.lbemail);
            this.Controls.Add(this.tbAPW);
            this.Controls.Add(this.lbAPW);
            this.Controls.Add(this.tbPW);
            this.Controls.Add(this.lbPW);
            this.Controls.Add(this.tbUN);
            this.Controls.Add(this.lbUserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmCreate";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.TextBox tbUN;
        private System.Windows.Forms.TextBox tbPW;
        private System.Windows.Forms.Label lbPW;
        private System.Windows.Forms.TextBox tbAPW;
        private System.Windows.Forms.Label lbAPW;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.Label lbemail;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox tbStaffID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

