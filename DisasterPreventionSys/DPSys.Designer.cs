namespace DisasterPreventionSys
{
    partial class DPSys
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DPSys));
            this.btnSmoke = new System.Windows.Forms.Button();
            this.btnHT = new System.Windows.Forms.Button();
            this.btnAntiTheft = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSmoke
            // 
            this.btnSmoke.BackColor = System.Drawing.Color.Transparent;
            this.btnSmoke.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSmoke.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSmoke.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSmoke.Location = new System.Drawing.Point(327, 161);
            this.btnSmoke.Name = "btnSmoke";
            this.btnSmoke.Size = new System.Drawing.Size(250, 250);
            this.btnSmoke.TabIndex = 5;
            this.btnSmoke.Text = "煙霧偵測";
            this.btnSmoke.UseVisualStyleBackColor = false;
            // 
            // btnHT
            // 
            this.btnHT.BackColor = System.Drawing.Color.Transparent;
            this.btnHT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHT.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHT.ForeColor = System.Drawing.Color.DarkRed;
            this.btnHT.Location = new System.Drawing.Point(616, 161);
            this.btnHT.Name = "btnHT";
            this.btnHT.Size = new System.Drawing.Size(250, 250);
            this.btnHT.TabIndex = 6;
            this.btnHT.Text = "溫度偵測";
            this.btnHT.UseVisualStyleBackColor = false;
            this.btnHT.Click += new System.EventHandler(this.btnHT_Click);
            // 
            // btnAntiTheft
            // 
            this.btnAntiTheft.BackColor = System.Drawing.Color.Transparent;
            this.btnAntiTheft.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAntiTheft.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAntiTheft.ForeColor = System.Drawing.Color.DarkRed;
            this.btnAntiTheft.Location = new System.Drawing.Point(905, 161);
            this.btnAntiTheft.Name = "btnAntiTheft";
            this.btnAntiTheft.Size = new System.Drawing.Size(250, 250);
            this.btnAntiTheft.TabIndex = 8;
            this.btnAntiTheft.Text = "防盜偵測";
            this.btnAntiTheft.UseVisualStyleBackColor = false;
            // 
            // DPSys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.btnSmoke);
            this.Controls.Add(this.btnHT);
            this.Controls.Add(this.btnAntiTheft);
            this.Name = "DPSys";
            this.Text = "DPSys";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.btnAntiTheft, 0);
            this.Controls.SetChildIndex(this.btnHT, 0);
            this.Controls.SetChildIndex(this.btnSmoke, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSmoke;
        private System.Windows.Forms.Button btnHT;
        private System.Windows.Forms.Button btnAntiTheft;
    }
}