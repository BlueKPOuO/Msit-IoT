namespace TemperatureHumiditySys
{
    partial class THSensor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpSearch = new System.Windows.Forms.TabPage();
            this.lbSearch1 = new System.Windows.Forms.Label();
            this.tpReport = new System.Windows.Forms.TabPage();
            this.lbReport1 = new System.Windows.Forms.Label();
            this.tpTest = new System.Windows.Forms.TabPage();
            this.btTSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbHum = new System.Windows.Forms.TextBox();
            this.lbHum = new System.Windows.Forms.Label();
            this.tbTemp = new System.Windows.Forms.TextBox();
            this.lbTemp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbTTime = new System.Windows.Forms.Label();
            this.cbSensorID = new System.Windows.Forms.ComboBox();
            this.lbTID = new System.Windows.Forms.Label();
            this.lbTest1 = new System.Windows.Forms.Label();
            this.GetDataTime = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpSearch.SuspendLayout();
            this.tpReport.SuspendLayout();
            this.tpTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTest);
            this.panel1.Controls.Add(this.btnReport);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.SetChildIndex(this.btnSearch, 0);
            this.panel1.Controls.SetChildIndex(this.Titlelb, 0);
            this.panel1.Controls.SetChildIndex(this.btnReport, 0);
            this.panel1.Controls.SetChildIndex(this.btnTest, 0);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Location = new System.Drawing.Point(26, 139);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(250, 80);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "清單";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold);
            this.btnReport.Location = new System.Drawing.Point(26, 267);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(250, 80);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "報表";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnTest
            // 
            this.btnTest.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold);
            this.btnTest.Location = new System.Drawing.Point(26, 395);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(250, 80);
            this.btnTest.TabIndex = 3;
            this.btnTest.Text = "測試";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpSearch);
            this.tabControl1.Controls.Add(this.tpReport);
            this.tabControl1.Controls.Add(this.tpTest);
            this.tabControl1.Location = new System.Drawing.Point(294, -23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(903, 599);
            this.tabControl1.TabIndex = 1;
            // 
            // tpSearch
            // 
            this.tpSearch.Controls.Add(this.lbSearch1);
            this.tpSearch.Location = new System.Drawing.Point(4, 22);
            this.tpSearch.Name = "tpSearch";
            this.tpSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tpSearch.Size = new System.Drawing.Size(895, 573);
            this.tpSearch.TabIndex = 0;
            this.tpSearch.Text = "tpSearch";
            this.tpSearch.UseVisualStyleBackColor = true;
            // 
            // lbSearch1
            // 
            this.lbSearch1.AutoSize = true;
            this.lbSearch1.Font = new System.Drawing.Font("微軟正黑體", 20F);
            this.lbSearch1.Location = new System.Drawing.Point(341, 9);
            this.lbSearch1.Name = "lbSearch1";
            this.lbSearch1.Size = new System.Drawing.Size(177, 68);
            this.lbSearch1.TabIndex = 0;
            this.lbSearch1.Text = "溫濕度感測器\r清單";
            this.lbSearch1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tpReport
            // 
            this.tpReport.Controls.Add(this.lbReport1);
            this.tpReport.Location = new System.Drawing.Point(4, 22);
            this.tpReport.Name = "tpReport";
            this.tpReport.Padding = new System.Windows.Forms.Padding(3);
            this.tpReport.Size = new System.Drawing.Size(895, 573);
            this.tpReport.TabIndex = 1;
            this.tpReport.Text = "tpReport";
            this.tpReport.UseVisualStyleBackColor = true;
            // 
            // lbReport1
            // 
            this.lbReport1.AutoSize = true;
            this.lbReport1.Font = new System.Drawing.Font("微軟正黑體", 20F);
            this.lbReport1.Location = new System.Drawing.Point(341, 9);
            this.lbReport1.Name = "lbReport1";
            this.lbReport1.Size = new System.Drawing.Size(177, 68);
            this.lbReport1.TabIndex = 1;
            this.lbReport1.Text = "溫濕度感測器\r\n報表";
            this.lbReport1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tpTest
            // 
            this.tpTest.Controls.Add(this.btTSave);
            this.tpTest.Controls.Add(this.dataGridView1);
            this.tpTest.Controls.Add(this.tbHum);
            this.tpTest.Controls.Add(this.lbHum);
            this.tpTest.Controls.Add(this.tbTemp);
            this.tpTest.Controls.Add(this.lbTemp);
            this.tpTest.Controls.Add(this.label1);
            this.tpTest.Controls.Add(this.textBox1);
            this.tpTest.Controls.Add(this.lbTTime);
            this.tpTest.Controls.Add(this.cbSensorID);
            this.tpTest.Controls.Add(this.lbTID);
            this.tpTest.Controls.Add(this.lbTest1);
            this.tpTest.Location = new System.Drawing.Point(4, 22);
            this.tpTest.Name = "tpTest";
            this.tpTest.Padding = new System.Windows.Forms.Padding(3);
            this.tpTest.Size = new System.Drawing.Size(895, 573);
            this.tpTest.TabIndex = 2;
            this.tpTest.Text = "tpTest";
            this.tpTest.UseVisualStyleBackColor = true;
            // 
            // btTSave
            // 
            this.btTSave.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btTSave.Location = new System.Drawing.Point(64, 28);
            this.btTSave.Name = "btTSave";
            this.btTSave.Size = new System.Drawing.Size(108, 39);
            this.btTSave.TabIndex = 13;
            this.btTSave.Text = "儲存變更";
            this.btTSave.UseVisualStyleBackColor = true;
            this.btTSave.Click += new System.EventHandler(this.btTSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(109)))), ((int)(((byte)(158)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(189)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(255)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("微軟正黑體", 12F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(189)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(447, 100);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(404, 429);
            this.dataGridView1.TabIndex = 12;
            // 
            // tbHum
            // 
            this.tbHum.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbHum.Location = new System.Drawing.Point(135, 320);
            this.tbHum.Name = "tbHum";
            this.tbHum.ReadOnly = true;
            this.tbHum.Size = new System.Drawing.Size(159, 43);
            this.tbHum.TabIndex = 11;
            // 
            // lbHum
            // 
            this.lbHum.AutoSize = true;
            this.lbHum.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbHum.Location = new System.Drawing.Point(40, 334);
            this.lbHum.Name = "lbHum";
            this.lbHum.Size = new System.Drawing.Size(89, 20);
            this.lbHum.TabIndex = 10;
            this.lbHum.Text = "目前濕度：";
            // 
            // tbTemp
            // 
            this.tbTemp.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbTemp.Location = new System.Drawing.Point(135, 254);
            this.tbTemp.Name = "tbTemp";
            this.tbTemp.ReadOnly = true;
            this.tbTemp.Size = new System.Drawing.Size(159, 43);
            this.tbTemp.TabIndex = 9;
            // 
            // lbTemp
            // 
            this.lbTemp.AutoSize = true;
            this.lbTemp.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbTemp.Location = new System.Drawing.Point(40, 268);
            this.lbTemp.Name = "lbTemp";
            this.lbTemp.Size = new System.Drawing.Size(89, 20);
            this.lbTemp.TabIndex = 8;
            this.lbTemp.Text = "目前溫度：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.label1.Location = new System.Drawing.Point(279, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "分鐘";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.textBox1.Location = new System.Drawing.Point(173, 147);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 29);
            this.textBox1.TabIndex = 6;
            // 
            // lbTTime
            // 
            this.lbTTime.AutoSize = true;
            this.lbTTime.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.lbTTime.Location = new System.Drawing.Point(19, 150);
            this.lbTTime.Name = "lbTTime";
            this.lbTTime.Size = new System.Drawing.Size(153, 20);
            this.lbTTime.TabIndex = 5;
            this.lbTTime.Text = "設定資料儲存頻率：";
            this.lbTTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbSensorID
            // 
            this.cbSensorID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSensorID.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.cbSensorID.FormattingEnabled = true;
            this.cbSensorID.Location = new System.Drawing.Point(152, 97);
            this.cbSensorID.Name = "cbSensorID";
            this.cbSensorID.Size = new System.Drawing.Size(157, 28);
            this.cbSensorID.TabIndex = 4;
            this.cbSensorID.SelectedIndexChanged += new System.EventHandler(this.cbSensorID_SelectedIndexChanged);
            // 
            // lbTID
            // 
            this.lbTID.AutoSize = true;
            this.lbTID.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.lbTID.Location = new System.Drawing.Point(85, 100);
            this.lbTID.Name = "lbTID";
            this.lbTID.Size = new System.Drawing.Size(57, 20);
            this.lbTID.TabIndex = 3;
            this.lbTID.Text = "名稱：";
            this.lbTID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTest1
            // 
            this.lbTest1.AutoSize = true;
            this.lbTest1.Font = new System.Drawing.Font("微軟正黑體", 20F);
            this.lbTest1.Location = new System.Drawing.Point(341, 9);
            this.lbTest1.Name = "lbTest1";
            this.lbTest1.Size = new System.Drawing.Size(177, 68);
            this.lbTest1.TabIndex = 2;
            this.lbTest1.Text = "溫濕度感測器\r\n測試";
            this.lbTest1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GetDataTime
            // 
            this.GetDataTime.Enabled = true;
            // 
            // THSensor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.tabControl1);
            this.Name = "THSensor";
            this.Text = "溫濕度感測器";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tpSearch.ResumeLayout(false);
            this.tpSearch.PerformLayout();
            this.tpReport.ResumeLayout(false);
            this.tpReport.PerformLayout();
            this.tpTest.ResumeLayout(false);
            this.tpTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpSearch;
        private System.Windows.Forms.TabPage tpTest;
        private System.Windows.Forms.TabPage tpReport;
        private System.Windows.Forms.Label lbSearch1;
        private System.Windows.Forms.Label lbReport1;
        private System.Windows.Forms.Label lbTest1;
        private System.Windows.Forms.Label lbTID;
        private System.Windows.Forms.ComboBox cbSensorID;
        private System.Windows.Forms.TextBox tbHum;
        private System.Windows.Forms.Label lbHum;
        private System.Windows.Forms.TextBox tbTemp;
        private System.Windows.Forms.Label lbTemp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbTTime;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btTSave;
        private System.Windows.Forms.Timer GetDataTime;
    }
}