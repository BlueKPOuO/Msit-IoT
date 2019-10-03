using System.Windows.Forms;

namespace ParkingManagement
{
    partial class FrmParkingManagement
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmParkingManagement));
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtContactPhone = new System.Windows.Forms.TextBox();
            this.lblContactPhone = new System.Windows.Forms.Label();
            this.txtContactName = new System.Windows.Forms.TextBox();
            this.lblContactName = new System.Windows.Forms.Label();
            this.txtEnterTime = new System.Windows.Forms.TextBox();
            this.lblEnterTime = new System.Windows.Forms.Label();
            this.txtLicencePlate = new System.Windows.Forms.TextBox();
            this.lblLicensePlate = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tPIndex = new System.Windows.Forms.TabPage();
            this.tPParkingUI = new System.Windows.Forms.TabPage();
            this.tPSearchUI = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tPChartUI = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tPMain = new System.Windows.Forms.TabPage();
            this.lblStatus0 = new System.Windows.Forms.Label();
            this.btnChart = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnParking = new System.Windows.Forms.Button();
            this.tPParkingUI_1 = new System.Windows.Forms.TabPage();
            this.lblStatus1 = new System.Windows.Forms.Label();
            this.btnBack1 = new System.Windows.Forms.Button();
            this.tPSearchUI_1 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.txtFEnterTime2 = new System.Windows.Forms.MaskedTextBox();
            this.txtFEnterTime1 = new System.Windows.Forms.MaskedTextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtfStay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFContactPhone = new System.Windows.Forms.TextBox();
            this.lblFContactPhone = new System.Windows.Forms.Label();
            this.txtFContactName = new System.Windows.Forms.TextBox();
            this.txtFLicensePlate = new System.Windows.Forms.TextBox();
            this.lblFindCar = new System.Windows.Forms.Label();
            this.lblStatus2 = new System.Windows.Forms.Label();
            this.btnBack2 = new System.Windows.Forms.Button();
            this.tPChartUI_1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbChartMonth = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbChartYear = new System.Windows.Forms.ComboBox();
            this.cmbChartType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStatus3 = new System.Windows.Forms.Label();
            this.btnBack3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tPParkingUI.SuspendLayout();
            this.tPSearchUI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tPChartUI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tPMain.SuspendLayout();
            this.tPParkingUI_1.SuspendLayout();
            this.tPSearchUI_1.SuspendLayout();
            this.tPChartUI_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl2);
            this.panel1.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Controls.SetChildIndex(this.tabControl2, 0);
            this.panel1.Controls.SetChildIndex(this.Titlelb, 0);
            // 
            // txtNum
            // 
            this.txtNum.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum.Location = new System.Drawing.Point(135, 17);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(138, 26);
            this.txtNum.TabIndex = 28;
            this.txtNum.TextChanged += new System.EventHandler(this.txtNum_TextChanged);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnPay.Font = new System.Drawing.Font("標楷體", 14F);
            this.btnPay.Location = new System.Drawing.Point(24, 321);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(261, 46);
            this.btnPay.TabIndex = 27;
            this.btnPay.Text = "繳費離場";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDelete.Font = new System.Drawing.Font("標楷體", 14F);
            this.btnDelete.Location = new System.Drawing.Point(205, 270);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 32);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "刪除";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnUpdate.Font = new System.Drawing.Font("標楷體", 14F);
            this.btnUpdate.Location = new System.Drawing.Point(114, 270);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 32);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnNew.Font = new System.Drawing.Font("標楷體", 14F);
            this.btnNew.Location = new System.Drawing.Point(24, 270);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(80, 32);
            this.btnNew.TabIndex = 24;
            this.btnNew.Text = "新增";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtContactPhone
            // 
            this.txtContactPhone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactPhone.Location = new System.Drawing.Point(135, 193);
            this.txtContactPhone.Name = "txtContactPhone";
            this.txtContactPhone.Size = new System.Drawing.Size(138, 26);
            this.txtContactPhone.TabIndex = 23;
            // 
            // lblContactPhone
            // 
            this.lblContactPhone.AutoSize = true;
            this.lblContactPhone.Font = new System.Drawing.Font("標楷體", 14F);
            this.lblContactPhone.ForeColor = this.FC2;
            this.lblContactPhone.Location = new System.Drawing.Point(20, 193);
            this.lblContactPhone.Name = "lblContactPhone";
            this.lblContactPhone.Size = new System.Drawing.Size(109, 19);
            this.lblContactPhone.TabIndex = 22;
            this.lblContactPhone.Text = "聯絡電話：";
            // 
            // txtContactName
            // 
            this.txtContactName.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactName.Location = new System.Drawing.Point(135, 149);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(138, 27);
            this.txtContactName.TabIndex = 21;
            // 
            // lblContactName
            // 
            this.lblContactName.AutoSize = true;
            this.lblContactName.Font = new System.Drawing.Font("標楷體", 14F);
            this.lblContactName.ForeColor = this.FC2;
            this.lblContactName.Location = new System.Drawing.Point(20, 149);
            this.lblContactName.Name = "lblContactName";
            this.lblContactName.Size = new System.Drawing.Size(89, 19);
            this.lblContactName.TabIndex = 20;
            this.lblContactName.Text = "聯絡人：";
            // 
            // txtEnterTime
            // 
            this.txtEnterTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterTime.Location = new System.Drawing.Point(135, 105);
            this.txtEnterTime.Name = "txtEnterTime";
            this.txtEnterTime.Size = new System.Drawing.Size(138, 26);
            this.txtEnterTime.TabIndex = 19;
            // 
            // lblEnterTime
            // 
            this.lblEnterTime.AutoSize = true;
            this.lblEnterTime.Font = new System.Drawing.Font("標楷體", 14F);
            this.lblEnterTime.ForeColor = this.FC2;
            this.lblEnterTime.Location = new System.Drawing.Point(20, 105);
            this.lblEnterTime.Name = "lblEnterTime";
            this.lblEnterTime.Size = new System.Drawing.Size(109, 19);
            this.lblEnterTime.TabIndex = 18;
            this.lblEnterTime.Text = "入場時間：";
            // 
            // txtLicencePlate
            // 
            this.txtLicencePlate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLicencePlate.Location = new System.Drawing.Point(135, 61);
            this.txtLicencePlate.Name = "txtLicencePlate";
            this.txtLicencePlate.Size = new System.Drawing.Size(138, 26);
            this.txtLicencePlate.TabIndex = 17;
            // 
            // lblLicensePlate
            // 
            this.lblLicensePlate.AutoSize = true;
            this.lblLicensePlate.Font = new System.Drawing.Font("標楷體", 14F);
            this.lblLicensePlate.ForeColor = this.FC2;
            this.lblLicensePlate.Location = new System.Drawing.Point(20, 61);
            this.lblLicensePlate.Name = "lblLicensePlate";
            this.lblLicensePlate.Size = new System.Drawing.Size(109, 19);
            this.lblLicensePlate.TabIndex = 16;
            this.lblLicensePlate.Text = "車牌號碼：";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("標楷體", 14F);
            this.lblNum.ForeColor = this.FC2;
            this.lblNum.Location = new System.Drawing.Point(20, 17);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(109, 19);
            this.lblNum.TabIndex = 15;
            this.lblNum.Text = "車格編號：";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(919, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 65);
            this.button2.TabIndex = 5;
            this.button2.Text = "Demo 停車1小時15分";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(919, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 65);
            this.button1.TabIndex = 4;
            this.button1.Text = "Demo 停車45分鐘";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(919, 312);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 65);
            this.button3.TabIndex = 6;
            this.button3.Text = "Demo 停車1小時45分";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tPIndex);
            this.tabControl1.Controls.Add(this.tPParkingUI);
            this.tabControl1.Controls.Add(this.tPSearchUI);
            this.tabControl1.Controls.Add(this.tPChartUI);
            this.tabControl1.Location = new System.Drawing.Point(299, -23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(899, 590);
            this.tabControl1.TabIndex = 7;
            // 
            // tPIndex
            // 
            this.tPIndex.Location = new System.Drawing.Point(4, 22);
            this.tPIndex.Name = "tPIndex";
            this.tPIndex.Padding = new System.Windows.Forms.Padding(3);
            this.tPIndex.Size = new System.Drawing.Size(891, 564);
            this.tPIndex.TabIndex = 0;
            this.tPIndex.Text = "停車管理及收費";
            this.tPIndex.UseVisualStyleBackColor = true;
            // 
            // tPParkingUI
            // 
            this.tPParkingUI.Controls.Add(this.button1);
            this.tPParkingUI.Controls.Add(this.button2);
            this.tPParkingUI.Controls.Add(this.button3);
            this.tPParkingUI.Location = new System.Drawing.Point(4, 22);
            this.tPParkingUI.Name = "tPParkingUI";
            this.tPParkingUI.Padding = new System.Windows.Forms.Padding(3);
            this.tPParkingUI.Size = new System.Drawing.Size(891, 564);
            this.tPParkingUI.TabIndex = 1;
            this.tPParkingUI.Text = "查詢";
            this.tPParkingUI.UseVisualStyleBackColor = true;
            // 
            // tPSearchUI
            // 
            this.tPSearchUI.Controls.Add(this.dataGridView1);
            this.tPSearchUI.Location = new System.Drawing.Point(4, 22);
            this.tPSearchUI.Name = "tPSearchUI";
            this.tPSearchUI.Padding = new System.Windows.Forms.Padding(3);
            this.tPSearchUI.Size = new System.Drawing.Size(891, 564);
            this.tPSearchUI.TabIndex = 2;
            this.tPSearchUI.Text = "報表";
            this.tPSearchUI.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(885, 558);
            this.dataGridView1.TabIndex = 0;
            // 
            // tPChartUI
            // 
            this.tPChartUI.AutoScroll = true;
            this.tPChartUI.Controls.Add(this.button4);
            this.tPChartUI.Controls.Add(this.chart1);
            this.tPChartUI.Location = new System.Drawing.Point(4, 22);
            this.tPChartUI.Name = "tPChartUI";
            this.tPChartUI.Size = new System.Drawing.Size(891, 564);
            this.tPChartUI.TabIndex = 3;
            this.tPChartUI.Text = "tabPage8";
            this.tPChartUI.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.Location = new System.Drawing.Point(919, 264);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(176, 74);
            this.button4.TabIndex = 35;
            this.button4.Text = "擴增資料庫";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // chart1
            // 
            chartArea3.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Stacked;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(7, 3);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(833, 559);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title3.Name = "Title1";
            this.chart1.Titles.Add(title3);
            this.chart1.Visible = false;
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl2.Controls.Add(this.tPMain);
            this.tabControl2.Controls.Add(this.tPParkingUI_1);
            this.tabControl2.Controls.Add(this.tPSearchUI_1);
            this.tabControl2.Controls.Add(this.tPChartUI_1);
            this.tabControl2.Location = new System.Drawing.Point(-4, 74);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(308, 493);
            this.tabControl2.TabIndex = 29;
            // 
            // tPMain
            // 
            this.tPMain.Controls.Add(this.lblStatus0);
            this.tPMain.Controls.Add(this.btnChart);
            this.tPMain.Controls.Add(this.btnSearch);
            this.tPMain.Controls.Add(this.btnParking);
            this.tPMain.Location = new System.Drawing.Point(4, 26);
            this.tPMain.Name = "tPMain";
            this.tPMain.Padding = new System.Windows.Forms.Padding(3);
            this.tPMain.Size = new System.Drawing.Size(300, 463);
            this.tPMain.TabIndex = 0;
            this.tPMain.Text = "主表單";
            this.tPMain.UseVisualStyleBackColor = true;
            // 
            // lblStatus0
            // 
            this.lblStatus0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatus0.AutoSize = true;
            this.lblStatus0.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.lblStatus0.Location = new System.Drawing.Point(3, 440);
            this.lblStatus0.Name = "lblStatus0";
            this.lblStatus0.Size = new System.Drawing.Size(54, 20);
            this.lblStatus0.TabIndex = 3;
            this.lblStatus0.Text = "label1";
            // 
            // btnChart
            // 
            this.btnChart.Font = new System.Drawing.Font("標楷體", 14F);
            this.btnChart.Image = ((System.Drawing.Image)(resources.GetObject("btnChart.Image")));
            this.btnChart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChart.Location = new System.Drawing.Point(3, 303);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(294, 85);
            this.btnChart.TabIndex = 2;
            this.btnChart.Text = "報表        ";
            this.btnChart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChart.UseVisualStyleBackColor = true;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("標楷體", 14F);
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(3, 189);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(294, 85);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "查詢        ";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnParking
            // 
            this.btnParking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnParking.Font = new System.Drawing.Font("標楷體", 14F);
            this.btnParking.Image = ((System.Drawing.Image)(resources.GetObject("btnParking.Image")));
            this.btnParking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParking.Location = new System.Drawing.Point(3, 75);
            this.btnParking.Name = "btnParking";
            this.btnParking.Size = new System.Drawing.Size(294, 85);
            this.btnParking.TabIndex = 0;
            this.btnParking.Text = "停車管理與收費  ";
            this.btnParking.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnParking.UseVisualStyleBackColor = true;
            this.btnParking.Click += new System.EventHandler(this.btnParking_Click);
            // 
            // tPParkingUI_1
            // 
            this.tPParkingUI_1.Controls.Add(this.lblStatus1);
            this.tPParkingUI_1.Controls.Add(this.btnBack1);
            this.tPParkingUI_1.Controls.Add(this.lblNum);
            this.tPParkingUI_1.Controls.Add(this.lblLicensePlate);
            this.tPParkingUI_1.Controls.Add(this.txtNum);
            this.tPParkingUI_1.Controls.Add(this.txtLicencePlate);
            this.tPParkingUI_1.Controls.Add(this.btnPay);
            this.tPParkingUI_1.Controls.Add(this.lblEnterTime);
            this.tPParkingUI_1.Controls.Add(this.btnDelete);
            this.tPParkingUI_1.Controls.Add(this.txtEnterTime);
            this.tPParkingUI_1.Controls.Add(this.btnUpdate);
            this.tPParkingUI_1.Controls.Add(this.lblContactName);
            this.tPParkingUI_1.Controls.Add(this.btnNew);
            this.tPParkingUI_1.Controls.Add(this.txtContactName);
            this.tPParkingUI_1.Controls.Add(this.txtContactPhone);
            this.tPParkingUI_1.Controls.Add(this.lblContactPhone);
            this.tPParkingUI_1.Location = new System.Drawing.Point(4, 26);
            this.tPParkingUI_1.Name = "tPParkingUI_1";
            this.tPParkingUI_1.Padding = new System.Windows.Forms.Padding(3);
            this.tPParkingUI_1.Size = new System.Drawing.Size(300, 463);
            this.tPParkingUI_1.TabIndex = 1;
            this.tPParkingUI_1.Text = "停車管理及收費";
            this.tPParkingUI_1.UseVisualStyleBackColor = true;
            // 
            // lblStatus1
            // 
            this.lblStatus1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatus1.AutoSize = true;
            this.lblStatus1.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.lblStatus1.Location = new System.Drawing.Point(3, 440);
            this.lblStatus1.Name = "lblStatus1";
            this.lblStatus1.Size = new System.Drawing.Size(54, 20);
            this.lblStatus1.TabIndex = 30;
            this.lblStatus1.Text = "label1";
            // 
            // btnBack1
            // 
            this.btnBack1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack1.FlatAppearance.BorderSize = 0;
            this.btnBack1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack1.Image = ((System.Drawing.Image)(resources.GetObject("btnBack1.Image")));
            this.btnBack1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack1.Location = new System.Drawing.Point(157, 411);
            this.btnBack1.Name = "btnBack1";
            this.btnBack1.Size = new System.Drawing.Size(136, 46);
            this.btnBack1.TabIndex = 29;
            this.btnBack1.Text = "回上一頁";
            this.btnBack1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack1.UseVisualStyleBackColor = true;
            this.btnBack1.Click += new System.EventHandler(this.btnBack1_Click);
            // 
            // tPSearchUI_1
            // 
            this.tPSearchUI_1.BackColor = System.Drawing.Color.Blue;
            this.tPSearchUI_1.Controls.Add(this.button6);
            this.tPSearchUI_1.Controls.Add(this.txtFEnterTime2);
            this.tPSearchUI_1.Controls.Add(this.txtFEnterTime1);
            this.tPSearchUI_1.Controls.Add(this.button5);
            this.tPSearchUI_1.Controls.Add(this.radioButton5);
            this.tPSearchUI_1.Controls.Add(this.radioButton4);
            this.tPSearchUI_1.Controls.Add(this.radioButton3);
            this.tPSearchUI_1.Controls.Add(this.radioButton2);
            this.tPSearchUI_1.Controls.Add(this.radioButton1);
            this.tPSearchUI_1.Controls.Add(this.btnFind);
            this.tPSearchUI_1.Controls.Add(this.txtfStay);
            this.tPSearchUI_1.Controls.Add(this.label4);
            this.tPSearchUI_1.Controls.Add(this.txtFContactPhone);
            this.tPSearchUI_1.Controls.Add(this.lblFContactPhone);
            this.tPSearchUI_1.Controls.Add(this.txtFContactName);
            this.tPSearchUI_1.Controls.Add(this.txtFLicensePlate);
            this.tPSearchUI_1.Controls.Add(this.lblFindCar);
            this.tPSearchUI_1.Controls.Add(this.lblStatus2);
            this.tPSearchUI_1.Controls.Add(this.btnBack2);
            this.tPSearchUI_1.Location = new System.Drawing.Point(4, 26);
            this.tPSearchUI_1.Name = "tPSearchUI_1";
            this.tPSearchUI_1.Size = new System.Drawing.Size(300, 463);
            this.tPSearchUI_1.TabIndex = 2;
            this.tPSearchUI_1.Text = "查詢";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(226, 377);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(67, 28);
            this.button6.TabIndex = 55;
            this.button6.Text = "Demo 新增5筆資料";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtFEnterTime2
            // 
            this.txtFEnterTime2.Location = new System.Drawing.Point(121, 236);
            this.txtFEnterTime2.Mask = "0000/00/00 00:00:00";
            this.txtFEnterTime2.Name = "txtFEnterTime2";
            this.txtFEnterTime2.Size = new System.Drawing.Size(160, 27);
            this.txtFEnterTime2.TabIndex = 54;
            this.txtFEnterTime2.ValidatingType = typeof(System.DateTime);
            this.txtFEnterTime2.Enter += new System.EventHandler(this.txtFEnterTime2_Enter);
            // 
            // txtFEnterTime1
            // 
            this.txtFEnterTime1.Location = new System.Drawing.Point(120, 186);
            this.txtFEnterTime1.Mask = "0000/00/00 00:00:00";
            this.txtFEnterTime1.Name = "txtFEnterTime1";
            this.txtFEnterTime1.Size = new System.Drawing.Size(160, 27);
            this.txtFEnterTime1.TabIndex = 53;
            this.txtFEnterTime1.ValidatingType = typeof(System.DateTime);
            this.txtFEnterTime1.Enter += new System.EventHandler(this.txtFEnterTime1_Enter);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 377);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(67, 28);
            this.button5.TabIndex = 52;
            this.button5.Text = "Demo 新增5筆資料";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.radioButton5.Location = new System.Drawing.Point(8, 305);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(106, 20);
            this.radioButton5.TabIndex = 51;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "滯留天數：";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.radioButton4.Location = new System.Drawing.Point(7, 211);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(170, 20);
            this.radioButton4.TabIndex = 50;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "進場時間範圍：　～";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.radioButton3.Location = new System.Drawing.Point(8, 137);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(106, 20);
            this.radioButton3.TabIndex = 49;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "聯絡電話：";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.radioButton2.Location = new System.Drawing.Point(8, 90);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(90, 20);
            this.radioButton2.TabIndex = 48;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "聯絡人：";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.radioButton1.Location = new System.Drawing.Point(7, 44);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(106, 20);
            this.radioButton1.TabIndex = 47;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "車牌號碼：";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.Transparent;
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.Location = new System.Drawing.Point(120, 345);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(60, 60);
            this.btnFind.TabIndex = 46;
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtfStay
            // 
            this.txtfStay.Location = new System.Drawing.Point(121, 305);
            this.txtfStay.Name = "txtfStay";
            this.txtfStay.Size = new System.Drawing.Size(140, 27);
            this.txtfStay.TabIndex = 45;
            this.txtfStay.Enter += new System.EventHandler(this.txtfStay_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("標楷體", 14F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.label4.Location = new System.Drawing.Point(4, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 19);
            this.label4.TabIndex = 43;
            this.label4.Text = "滯留車輛：";
            // 
            // txtFContactPhone
            // 
            this.txtFContactPhone.Location = new System.Drawing.Point(121, 137);
            this.txtFContactPhone.Name = "txtFContactPhone";
            this.txtFContactPhone.Size = new System.Drawing.Size(140, 27);
            this.txtFContactPhone.TabIndex = 38;
            this.txtFContactPhone.Enter += new System.EventHandler(this.txtFContactPhone_Enter);
            // 
            // lblFContactPhone
            // 
            this.lblFContactPhone.AutoSize = true;
            this.lblFContactPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.lblFContactPhone.Location = new System.Drawing.Point(27, 137);
            this.lblFContactPhone.Name = "lblFContactPhone";
            this.lblFContactPhone.Size = new System.Drawing.Size(0, 16);
            this.lblFContactPhone.TabIndex = 37;
            // 
            // txtFContactName
            // 
            this.txtFContactName.Location = new System.Drawing.Point(121, 90);
            this.txtFContactName.Name = "txtFContactName";
            this.txtFContactName.Size = new System.Drawing.Size(140, 27);
            this.txtFContactName.TabIndex = 36;
            this.txtFContactName.Enter += new System.EventHandler(this.txtFContactName_Enter);
            // 
            // txtFLicensePlate
            // 
            this.txtFLicensePlate.Location = new System.Drawing.Point(121, 43);
            this.txtFLicensePlate.Name = "txtFLicensePlate";
            this.txtFLicensePlate.Size = new System.Drawing.Size(140, 27);
            this.txtFLicensePlate.TabIndex = 34;
            this.txtFLicensePlate.Enter += new System.EventHandler(this.txtFLicensePlate_Enter);
            // 
            // lblFindCar
            // 
            this.lblFindCar.AutoSize = true;
            this.lblFindCar.Font = new System.Drawing.Font("標楷體", 14F);
            this.lblFindCar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.lblFindCar.Location = new System.Drawing.Point(4, 11);
            this.lblFindCar.Name = "lblFindCar";
            this.lblFindCar.Size = new System.Drawing.Size(109, 19);
            this.lblFindCar.TabIndex = 32;
            this.lblFindCar.Text = "尋找車輛：";
            // 
            // lblStatus2
            // 
            this.lblStatus2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatus2.AutoSize = true;
            this.lblStatus2.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.lblStatus2.Location = new System.Drawing.Point(3, 440);
            this.lblStatus2.Name = "lblStatus2";
            this.lblStatus2.Size = new System.Drawing.Size(54, 20);
            this.lblStatus2.TabIndex = 31;
            this.lblStatus2.Text = "label1";
            // 
            // btnBack2
            // 
            this.btnBack2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack2.FlatAppearance.BorderSize = 0;
            this.btnBack2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack2.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBack2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.btnBack2.Image = ((System.Drawing.Image)(resources.GetObject("btnBack2.Image")));
            this.btnBack2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack2.Location = new System.Drawing.Point(157, 411);
            this.btnBack2.Name = "btnBack2";
            this.btnBack2.Size = new System.Drawing.Size(136, 46);
            this.btnBack2.TabIndex = 30;
            this.btnBack2.Text = "   回上一頁 ";
            this.btnBack2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack2.UseVisualStyleBackColor = true;
            this.btnBack2.Click += new System.EventHandler(this.btnBack2_Click);
            // 
            // tPChartUI_1
            // 
            this.tPChartUI_1.Controls.Add(this.label3);
            this.tPChartUI_1.Controls.Add(this.cmbChartMonth);
            this.tPChartUI_1.Controls.Add(this.label2);
            this.tPChartUI_1.Controls.Add(this.cmbChartYear);
            this.tPChartUI_1.Controls.Add(this.cmbChartType);
            this.tPChartUI_1.Controls.Add(this.label1);
            this.tPChartUI_1.Controls.Add(this.lblStatus3);
            this.tPChartUI_1.Controls.Add(this.btnBack3);
            this.tPChartUI_1.Location = new System.Drawing.Point(4, 26);
            this.tPChartUI_1.Name = "tPChartUI_1";
            this.tPChartUI_1.Size = new System.Drawing.Size(300, 463);
            this.tPChartUI_1.TabIndex = 3;
            this.tPChartUI_1.Text = "報表";
            this.tPChartUI_1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("標楷體", 14F);
            this.label3.ForeColor = this.FC2;
            this.label3.Location = new System.Drawing.Point(42, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 19);
            this.label3.TabIndex = 39;
            this.label3.Text = "圖表類型：";
            // 
            // cmbChartMonth
            // 
            this.cmbChartMonth.FormattingEnabled = true;
            this.cmbChartMonth.Location = new System.Drawing.Point(157, 95);
            this.cmbChartMonth.Name = "cmbChartMonth";
            this.cmbChartMonth.Size = new System.Drawing.Size(121, 24);
            this.cmbChartMonth.TabIndex = 38;
            this.cmbChartMonth.SelectedIndexChanged += new System.EventHandler(this.cmbChartMonth_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("標楷體", 14F);
            this.label2.ForeColor = this.FC2;
            this.label2.Location = new System.Drawing.Point(82, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 37;
            this.label2.Text = "月份：";
            // 
            // cmbChartYear
            // 
            this.cmbChartYear.FormattingEnabled = true;
            this.cmbChartYear.Location = new System.Drawing.Point(157, 46);
            this.cmbChartYear.Name = "cmbChartYear";
            this.cmbChartYear.Size = new System.Drawing.Size(121, 24);
            this.cmbChartYear.TabIndex = 36;
            this.cmbChartYear.SelectedIndexChanged += new System.EventHandler(this.cmbChartYear_SelectedIndexChanged);
            // 
            // cmbChartType
            // 
            this.cmbChartType.FormattingEnabled = true;
            this.cmbChartType.Items.AddRange(new object[] {
            "長條圖",
            "折線圖",
            "圓餅圖"});
            this.cmbChartType.Location = new System.Drawing.Point(157, 146);
            this.cmbChartType.Name = "cmbChartType";
            this.cmbChartType.Size = new System.Drawing.Size(121, 24);
            this.cmbChartType.TabIndex = 35;
            this.cmbChartType.SelectedIndexChanged += new System.EventHandler(this.cmbChartType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 14F);
            this.label1.ForeColor = this.FC2;
            this.label1.Location = new System.Drawing.Point(22, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 19);
            this.label1.TabIndex = 32;
            this.label1.Text = "年度(西元)：";
            // 
            // lblStatus3
            // 
            this.lblStatus3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatus3.AutoSize = true;
            this.lblStatus3.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.lblStatus3.Location = new System.Drawing.Point(3, 440);
            this.lblStatus3.Name = "lblStatus3";
            this.lblStatus3.Size = new System.Drawing.Size(54, 20);
            this.lblStatus3.TabIndex = 31;
            this.lblStatus3.Text = "label1";
            // 
            // btnBack3
            // 
            this.btnBack3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack3.FlatAppearance.BorderSize = 0;
            this.btnBack3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack3.Image = ((System.Drawing.Image)(resources.GetObject("btnBack3.Image")));
            this.btnBack3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack3.Location = new System.Drawing.Point(157, 411);
            this.btnBack3.Name = "btnBack3";
            this.btnBack3.Size = new System.Drawing.Size(136, 46);
            this.btnBack3.TabIndex = 30;
            this.btnBack3.Text = "回上一頁";
            this.btnBack3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack3.UseVisualStyleBackColor = true;
            this.btnBack3.Click += new System.EventHandler(this.btnBack3_Click);
            // 
            // FrmParkingManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmParkingManagement";
            this.Text = "FrmParkingManagement";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmParkingManagement_FormClosed);
            this.Load += new System.EventHandler(this.FrmParkingManagement_Load);
            this.Resize += new System.EventHandler(this.FrmParkingManagement_Resize);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tPParkingUI.ResumeLayout(false);
            this.tPSearchUI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tPChartUI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tPMain.ResumeLayout(false);
            this.tPMain.PerformLayout();
            this.tPParkingUI_1.ResumeLayout(false);
            this.tPParkingUI_1.PerformLayout();
            this.tPSearchUI_1.ResumeLayout(false);
            this.tPSearchUI_1.PerformLayout();
            this.tPChartUI_1.ResumeLayout(false);
            this.tPChartUI_1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtContactPhone;
        private System.Windows.Forms.Label lblContactPhone;
        private System.Windows.Forms.TextBox txtContactName;
        private System.Windows.Forms.Label lblContactName;
        private System.Windows.Forms.TextBox txtEnterTime;
        private System.Windows.Forms.Label lblEnterTime;
        private System.Windows.Forms.TextBox txtLicencePlate;
        private System.Windows.Forms.Label lblLicensePlate;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tPIndex;
        private System.Windows.Forms.TabPage tPParkingUI;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tPParkingUI_1;
        private System.Windows.Forms.TabPage tPSearchUI_1;
        private System.Windows.Forms.TabPage tPChartUI_1;
        private System.Windows.Forms.TabPage tPMain;
        private System.Windows.Forms.Button btnParking;
        private System.Windows.Forms.TabPage tPSearchUI;
        private System.Windows.Forms.Button btnChart;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblStatus0;
        private System.Windows.Forms.TabPage tPChartUI;
        private System.Windows.Forms.Button btnBack1;
        private System.Windows.Forms.Button btnBack2;
        private System.Windows.Forms.Button btnBack3;
        private System.Windows.Forms.Label lblStatus1;
        private System.Windows.Forms.Label lblStatus2;
        private System.Windows.Forms.Label lblStatus3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox cmbChartType;
        private System.Windows.Forms.ComboBox cmbChartYear;
        private System.Windows.Forms.ComboBox cmbChartMonth;
        private System.Windows.Forms.Label label2;
        private Label label3;
        private DataGridView dataGridView1;
        private Button btnFind;
        private TextBox txtfStay;
        private Label label4;
        private TextBox txtFContactPhone;
        private Label lblFContactPhone;
        private TextBox txtFContactName;
        private TextBox txtFLicensePlate;
        private Label lblFindCar;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private Button button5;
        private MaskedTextBox txtFEnterTime2;
        private MaskedTextBox txtFEnterTime1;
        private Button button6;
    }
}