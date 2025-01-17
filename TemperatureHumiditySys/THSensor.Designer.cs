﻿namespace TemperatureHumiditySys
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpSearch = new System.Windows.Forms.TabPage();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnEditSensor = new System.Windows.Forms.Button();
            this.btnDeleteSensor = new System.Windows.Forms.Button();
            this.btnNewSensor = new System.Windows.Forms.Button();
            this.dgvSensorList = new System.Windows.Forms.DataGridView();
            this.lbSearch1 = new System.Windows.Forms.Label();
            this.tpReport = new System.Windows.Forms.TabPage();
            this.lbReport1 = new System.Windows.Forms.Label();
            this.tpTest = new System.Windows.Forms.TabPage();
            this.btn_AlertTest = new System.Windows.Forms.Button();
            this.lbdgv = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btTSave = new System.Windows.Forms.Button();
            this.dgvHTData = new System.Windows.Forms.DataGridView();
            this.tbHum = new System.Windows.Forms.TextBox();
            this.lbHum = new System.Windows.Forms.Label();
            this.tbTemp = new System.Windows.Forms.TextBox();
            this.lbTemp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFrequency = new System.Windows.Forms.TextBox();
            this.lbTTime = new System.Windows.Forms.Label();
            this.cbSensorID = new System.Windows.Forms.ComboBox();
            this.lbTID = new System.Windows.Forms.Label();
            this.lbTest1 = new System.Windows.Forms.Label();
            this.GetDataTime = new System.Windows.Forms.Timer(this.components);
            this.lbName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbLocation = new System.Windows.Forms.TextBox();
            this.lbLocation = new System.Windows.Forms.Label();
            this.tbVendor = new System.Windows.Forms.TextBox();
            this.lbVendor = new System.Windows.Forms.Label();
            this.lbstatus = new System.Windows.Forms.Label();
            this.chbStatus = new System.Windows.Forms.CheckBox();
            this.tbSearchFrequency = new System.Windows.Forms.TextBox();
            this.lbFrequency = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSensorList)).BeginInit();
            this.tpReport.SuspendLayout();
            this.tpTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHTData)).BeginInit();
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
            this.tpSearch.Controls.Add(this.tbSearchFrequency);
            this.tpSearch.Controls.Add(this.lbFrequency);
            this.tpSearch.Controls.Add(this.chbStatus);
            this.tpSearch.Controls.Add(this.lbstatus);
            this.tpSearch.Controls.Add(this.tbVendor);
            this.tpSearch.Controls.Add(this.lbVendor);
            this.tpSearch.Controls.Add(this.tbLocation);
            this.tpSearch.Controls.Add(this.lbLocation);
            this.tpSearch.Controls.Add(this.tbName);
            this.tpSearch.Controls.Add(this.lbName);
            this.tpSearch.Controls.Add(this.btnRefresh);
            this.tpSearch.Controls.Add(this.btnEditSensor);
            this.tpSearch.Controls.Add(this.btnDeleteSensor);
            this.tpSearch.Controls.Add(this.btnNewSensor);
            this.tpSearch.Controls.Add(this.dgvSensorList);
            this.tpSearch.Controls.Add(this.lbSearch1);
            this.tpSearch.Location = new System.Drawing.Point(4, 22);
            this.tpSearch.Name = "tpSearch";
            this.tpSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tpSearch.Size = new System.Drawing.Size(895, 573);
            this.tpSearch.TabIndex = 0;
            this.tpSearch.Text = "tpSearch";
            this.tpSearch.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Location = new System.Drawing.Point(199, 54);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(121, 47);
            this.btnRefresh.TabIndex = 17;
            this.btnRefresh.Text = "重新整理";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnEditSensor
            // 
            this.btnEditSensor.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Bold);
            this.btnEditSensor.Location = new System.Drawing.Point(571, 54);
            this.btnEditSensor.Name = "btnEditSensor";
            this.btnEditSensor.Size = new System.Drawing.Size(121, 47);
            this.btnEditSensor.TabIndex = 16;
            this.btnEditSensor.Text = "編輯感測器";
            this.btnEditSensor.UseVisualStyleBackColor = true;
            this.btnEditSensor.Visible = false;
            // 
            // btnDeleteSensor
            // 
            this.btnDeleteSensor.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Bold);
            this.btnDeleteSensor.Location = new System.Drawing.Point(719, 54);
            this.btnDeleteSensor.Name = "btnDeleteSensor";
            this.btnDeleteSensor.Size = new System.Drawing.Size(121, 47);
            this.btnDeleteSensor.TabIndex = 15;
            this.btnDeleteSensor.Text = "刪除感測器";
            this.btnDeleteSensor.UseVisualStyleBackColor = true;
            this.btnDeleteSensor.Click += new System.EventHandler(this.btnDeleteSensor_Click);
            // 
            // btnNewSensor
            // 
            this.btnNewSensor.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Bold);
            this.btnNewSensor.Location = new System.Drawing.Point(57, 54);
            this.btnNewSensor.Name = "btnNewSensor";
            this.btnNewSensor.Size = new System.Drawing.Size(121, 47);
            this.btnNewSensor.TabIndex = 14;
            this.btnNewSensor.Text = "新增感測器";
            this.btnNewSensor.UseVisualStyleBackColor = true;
            this.btnNewSensor.Click += new System.EventHandler(this.btnNewSensor_Click);
            // 
            // dgvSensorList
            // 
            this.dgvSensorList.AllowUserToResizeColumns = false;
            this.dgvSensorList.AllowUserToResizeRows = false;
            dataGridViewCellStyle41.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle41.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dgvSensorList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle41;
            this.dgvSensorList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSensorList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSensorList.BackgroundColor = System.Drawing.Color.White;
            this.dgvSensorList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle42.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(109)))), ((int)(((byte)(158)))));
            dataGridViewCellStyle42.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle42.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle42.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(189)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle42.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(255)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle42.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSensorList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle42;
            this.dgvSensorList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle43.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle43.Font = new System.Drawing.Font("微軟正黑體", 12F);
            dataGridViewCellStyle43.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle43.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(189)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle43.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle43.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSensorList.DefaultCellStyle = dataGridViewCellStyle43;
            this.dgvSensorList.EnableHeadersVisualStyles = false;
            this.dgvSensorList.Location = new System.Drawing.Point(322, 130);
            this.dgvSensorList.Name = "dgvSensorList";
            dataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle44.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle44.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle44.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle44.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle44.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle44.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSensorList.RowHeadersDefaultCellStyle = dataGridViewCellStyle44;
            this.dgvSensorList.RowHeadersVisible = false;
            this.dgvSensorList.RowTemplate.Height = 24;
            this.dgvSensorList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSensorList.Size = new System.Drawing.Size(539, 409);
            this.dgvSensorList.TabIndex = 13;
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
            this.tpTest.Controls.Add(this.btn_AlertTest);
            this.tpTest.Controls.Add(this.lbdgv);
            this.tpTest.Controls.Add(this.label3);
            this.tpTest.Controls.Add(this.label2);
            this.tpTest.Controls.Add(this.btTSave);
            this.tpTest.Controls.Add(this.dgvHTData);
            this.tpTest.Controls.Add(this.tbHum);
            this.tpTest.Controls.Add(this.lbHum);
            this.tpTest.Controls.Add(this.tbTemp);
            this.tpTest.Controls.Add(this.lbTemp);
            this.tpTest.Controls.Add(this.label1);
            this.tpTest.Controls.Add(this.tbFrequency);
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
            // btn_AlertTest
            // 
            this.btn_AlertTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_AlertTest.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btn_AlertTest.Location = new System.Drawing.Point(743, 28);
            this.btn_AlertTest.Name = "btn_AlertTest";
            this.btn_AlertTest.Size = new System.Drawing.Size(108, 39);
            this.btn_AlertTest.TabIndex = 17;
            this.btn_AlertTest.Text = "警報測試";
            this.btn_AlertTest.UseVisualStyleBackColor = false;
            this.btn_AlertTest.Click += new System.EventHandler(this.btn_AlertTest_Click);
            // 
            // lbdgv
            // 
            this.lbdgv.AutoSize = true;
            this.lbdgv.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbdgv.Location = new System.Drawing.Point(33, 200);
            this.lbdgv.Name = "lbdgv";
            this.lbdgv.Size = new System.Drawing.Size(105, 20);
            this.lbdgv.TabIndex = 16;
            this.lbdgv.Text = "資料庫資料：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(745, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(745, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "℃";
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
            // dgvHTData
            // 
            this.dgvHTData.AllowUserToResizeColumns = false;
            this.dgvHTData.AllowUserToResizeRows = false;
            dataGridViewCellStyle45.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle45.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dgvHTData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle45;
            this.dgvHTData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvHTData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvHTData.BackgroundColor = System.Drawing.Color.White;
            this.dgvHTData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            dataGridViewCellStyle46.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle46.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(109)))), ((int)(((byte)(158)))));
            dataGridViewCellStyle46.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle46.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle46.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(189)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle46.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(255)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle46.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHTData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle46;
            this.dgvHTData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle47.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle47.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle47.Font = new System.Drawing.Font("微軟正黑體", 12F);
            dataGridViewCellStyle47.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle47.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(189)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle47.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle47.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHTData.DefaultCellStyle = dataGridViewCellStyle47;
            this.dgvHTData.EnableHeadersVisualStyles = false;
            this.dgvHTData.Location = new System.Drawing.Point(37, 235);
            this.dgvHTData.Name = "dgvHTData";
            dataGridViewCellStyle48.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle48.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle48.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle48.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle48.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle48.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle48.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHTData.RowHeadersDefaultCellStyle = dataGridViewCellStyle48;
            this.dgvHTData.RowHeadersVisible = false;
            this.dgvHTData.RowTemplate.Height = 24;
            this.dgvHTData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHTData.Size = new System.Drawing.Size(814, 294);
            this.dgvHTData.TabIndex = 12;
            // 
            // tbHum
            // 
            this.tbHum.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.tbHum.Location = new System.Drawing.Point(580, 140);
            this.tbHum.Name = "tbHum";
            this.tbHum.ReadOnly = true;
            this.tbHum.Size = new System.Drawing.Size(159, 29);
            this.tbHum.TabIndex = 11;
            this.tbHum.Text = "0";
            // 
            // lbHum
            // 
            this.lbHum.AutoSize = true;
            this.lbHum.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbHum.Location = new System.Drawing.Point(485, 143);
            this.lbHum.Name = "lbHum";
            this.lbHum.Size = new System.Drawing.Size(89, 20);
            this.lbHum.TabIndex = 10;
            this.lbHum.Text = "目前濕度：";
            // 
            // tbTemp
            // 
            this.tbTemp.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.tbTemp.Location = new System.Drawing.Point(580, 91);
            this.tbTemp.Name = "tbTemp";
            this.tbTemp.ReadOnly = true;
            this.tbTemp.Size = new System.Drawing.Size(159, 29);
            this.tbTemp.TabIndex = 9;
            this.tbTemp.Text = "0";
            // 
            // lbTemp
            // 
            this.lbTemp.AutoSize = true;
            this.lbTemp.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbTemp.Location = new System.Drawing.Point(485, 94);
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
            // tbFrequency
            // 
            this.tbFrequency.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.tbFrequency.Location = new System.Drawing.Point(173, 147);
            this.tbFrequency.Name = "tbFrequency";
            this.tbFrequency.Size = new System.Drawing.Size(100, 29);
            this.tbFrequency.TabIndex = 6;
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
            this.GetDataTime.Interval = 50000;
            this.GetDataTime.Tick += new System.EventHandler(this.GetDataTime_Tick);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.lbName.Location = new System.Drawing.Point(35, 162);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(115, 20);
            this.lbName.TabIndex = 18;
            this.lbName.Text = "名稱(訂閱主題)";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbName.Location = new System.Drawing.Point(156, 153);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(120, 29);
            this.tbName.TabIndex = 19;
            // 
            // tbLocation
            // 
            this.tbLocation.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbLocation.Location = new System.Drawing.Point(156, 194);
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.Size = new System.Drawing.Size(120, 29);
            this.tbLocation.TabIndex = 21;
            // 
            // lbLocation
            // 
            this.lbLocation.AutoSize = true;
            this.lbLocation.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.lbLocation.Location = new System.Drawing.Point(61, 203);
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Size = new System.Drawing.Size(89, 20);
            this.lbLocation.TabIndex = 20;
            this.lbLocation.Text = "感測器位置";
            this.lbLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbVendor
            // 
            this.tbVendor.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbVendor.Location = new System.Drawing.Point(156, 242);
            this.tbVendor.Name = "tbVendor";
            this.tbVendor.Size = new System.Drawing.Size(120, 29);
            this.tbVendor.TabIndex = 23;
            // 
            // lbVendor
            // 
            this.lbVendor.AutoSize = true;
            this.lbVendor.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.lbVendor.Location = new System.Drawing.Point(77, 251);
            this.lbVendor.Name = "lbVendor";
            this.lbVendor.Size = new System.Drawing.Size(73, 20);
            this.lbVendor.TabIndex = 22;
            this.lbVendor.Text = "製造廠商";
            this.lbVendor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbstatus
            // 
            this.lbstatus.AutoSize = true;
            this.lbstatus.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.lbstatus.Location = new System.Drawing.Point(77, 300);
            this.lbstatus.Name = "lbstatus";
            this.lbstatus.Size = new System.Drawing.Size(73, 20);
            this.lbstatus.TabIndex = 24;
            this.lbstatus.Text = "運作狀態";
            this.lbstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chbStatus
            // 
            this.chbStatus.AutoSize = true;
            this.chbStatus.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.chbStatus.Location = new System.Drawing.Point(172, 296);
            this.chbStatus.Name = "chbStatus";
            this.chbStatus.Size = new System.Drawing.Size(60, 24);
            this.chbStatus.TabIndex = 26;
            this.chbStatus.Text = "關閉";
            this.chbStatus.UseVisualStyleBackColor = true;
            // 
            // tbSearchFrequency
            // 
            this.tbSearchFrequency.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbSearchFrequency.Location = new System.Drawing.Point(172, 332);
            this.tbSearchFrequency.Name = "tbSearchFrequency";
            this.tbSearchFrequency.Size = new System.Drawing.Size(104, 29);
            this.tbSearchFrequency.TabIndex = 28;
            // 
            // lbFrequency
            // 
            this.lbFrequency.AutoSize = true;
            this.lbFrequency.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.lbFrequency.Location = new System.Drawing.Point(33, 341);
            this.lbFrequency.Name = "lbFrequency";
            this.lbFrequency.Size = new System.Drawing.Size(121, 20);
            this.lbFrequency.TabIndex = 27;
            this.lbFrequency.Text = "資料庫接收頻率";
            this.lbFrequency.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // THSensor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.tabControl1);
            this.Name = "THSensor";
            this.Text = "溫濕度感測器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.THSensor_FormClosing);
            this.Load += new System.EventHandler(this.THSensor_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tpSearch.ResumeLayout(false);
            this.tpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSensorList)).EndInit();
            this.tpReport.ResumeLayout(false);
            this.tpReport.PerformLayout();
            this.tpTest.ResumeLayout(false);
            this.tpTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHTData)).EndInit();
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
        private System.Windows.Forms.TextBox tbFrequency;
        private System.Windows.Forms.Label lbTTime;
        private System.Windows.Forms.DataGridView dgvHTData;
        private System.Windows.Forms.Button btTSave;
        private System.Windows.Forms.Timer GetDataTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbdgv;
        private System.Windows.Forms.Button btn_AlertTest;
        private System.Windows.Forms.DataGridView dgvSensorList;
        private System.Windows.Forms.Button btnEditSensor;
        private System.Windows.Forms.Button btnDeleteSensor;
        private System.Windows.Forms.Button btnNewSensor;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSearchFrequency;
        private System.Windows.Forms.Label lbFrequency;
        private System.Windows.Forms.CheckBox chbStatus;
        private System.Windows.Forms.Label lbstatus;
        private System.Windows.Forms.TextBox tbVendor;
        private System.Windows.Forms.Label lbVendor;
        private System.Windows.Forms.TextBox tbLocation;
        private System.Windows.Forms.Label lbLocation;
    }
}