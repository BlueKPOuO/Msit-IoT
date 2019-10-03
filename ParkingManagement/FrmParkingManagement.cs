using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using FormLogoClassLibrary;
using ParkInfomation;
using EntityLibrary;

namespace ParkingManagement
{
    public partial class FrmParkingManagement : FrmLogo3
    {
        public FrmParkingManagement()
        {
            InitializeComponent();
            this.Title = "停車管理系統";

            /*生成停車格*/
            int Num = 1;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Button bn = new Button();
                    bn.Location = new Point(95 + 70 * j, ((this.Height - 30 - 420) / 4) + 181 * i);
                    bn.FlatAppearance.BorderSize = 0;
                    bn.FlatStyle = FlatStyle.Standard;
                    bn.Name = "btn" + Num;
                    bn.Text = Num.ToString();
                    bn.Size = new Size(70, 140);
                    bn.UseVisualStyleBackColor = true;
                    bn.BackColor = this.FC3;
                    bn.Font = new Font("Times New Roman", 12F);
                    bn.ForeColor = this.FC4;
                    this.tPParkingUI.Controls.Add(bn);
                    bn.Click += Bn_Click;
                    Num++;
                }
            }

            /*控制項設定*/
            this.Size = new Size(1200, 600);
            this.btnUpdate.Enabled = false;
            this.btnDelete.Enabled = false;
            this.btnPay.Enabled = false;
            this.txtNum.BackColor = this.panel1.BackColor;
            this.txtNum.ForeColor = this.FC2;
            this.txtNum.BorderStyle = BorderStyle.None;
            this.txtEnterTime.BackColor = this.panel1.BackColor;
            this.txtEnterTime.ForeColor = this.FC2;
            this.txtEnterTime.BorderStyle = BorderStyle.None;

            /*tabControl1*/
            this.tabControl1.SelectedIndex = 0;

            /*tabControl2*/
            this.tabControl2.SelectedIndex = 0;

            this.tPMain.BackColor = this.panel1.BackColor;          //第一頁
            lblStatus0.ForeColor = FC2;

            this.tPParkingUI_1.BackColor = this.panel1.BackColor;   //第二頁
            this.btnParking.BackColor = this.panel1.BackColor;
            this.btnSearch.BackColor = this.panel1.BackColor; ;
            this.btnChart.BackColor = this.panel1.BackColor;
            this.btnBack1.BackColor = this.panel1.BackColor;
            this.btnBack1.ForeColor = this.FC2;
            this.btnBack1.FlatAppearance.MouseOverBackColor = this.FC4;
            this.btnBack1.FlatAppearance.MouseDownBackColor = this.FC3;
            lblStatus1.ForeColor = FC2;

            this.tPSearchUI_1.BackColor = this.panel1.BackColor;    //第三頁
            this.btnFind.BackColor = this.panel1.BackColor;
            this.btnBack2.BackColor = this.panel1.BackColor;
            this.btnBack2.ForeColor = this.FC2;
            this.btnBack2.FlatAppearance.MouseOverBackColor = this.FC4;
            this.btnBack2.FlatAppearance.MouseDownBackColor = this.FC3;
            lblStatus2.ForeColor = FC2;

            this.tPChartUI_1.BackColor = this.panel1.BackColor;     //第四頁
            this.cmbChartType.SelectedIndex = 0;
            this.btnBack3.BackColor =this.panel1.BackColor;
            this.btnBack3.ForeColor = this.FC2;
            this.btnBack3.FlatAppearance.MouseOverBackColor = this.FC4;
            this.btnBack3.FlatAppearance.MouseDownBackColor = this.FC3;
            lblStatus3.ForeColor = FC2;
        }

        Buliding_ManagementEntities BMContext = new Buliding_ManagementEntities();
        ParkInfo[] Info = Properties.Settings.Default.CarIn;        //所有停車格資訊
        int Num;                                                    //停車格編號

        /*點擊停車格事件*/
        private void Bn_Click(object sender, EventArgs e)
        {
            /*控制項設定*/
            this.timer1.Enabled = true;
            this.btnNew.Enabled = true;
            this.btnUpdate.Enabled = false;
            this.btnDelete.Enabled = false;
            this.btnPay.Enabled = false;

            /*清除TextBox內的資訊*/
            ClearText();

            Num = Convert.ToInt32(((Button)sender).Text);
            this.txtNum.Text = Num.ToString();
            this.btnNew.Enabled = true;

            /*若有停放車輛時，將停車資訊顯示於TextBox中*/
            if (Info[Num - 1] != null)
            {
                this.txtLicencePlate.Text = Info[Num - 1].LicensePlate;
                this.txtEnterTime.Text = Info[Num - 1].EnterTime.ToString("MM月dd日 HH:mm:ss");
                this.txtContactName.Text = Info[Num - 1].ContactName;
                this.txtContactPhone.Text = Info[Num - 1].ContactPhone;
                /*控制項設定*/
                this.timer1.Enabled = false;
                this.btnNew.Enabled = false;
                this.btnUpdate.Enabled = true;
                this.btnDelete.Enabled = true;
                this.btnPay.Enabled = true;
            }
        }

        /*新增*/
        int rid_i;
        DateTime datecheck;
        private void btnNew_Click(object sender, EventArgs e)
        {
            var q = from pm in this.BMContext.ParkingManagement
                    select pm.EnterTime;
            if (q.ToList().LastOrDefault().Date != null)
                datecheck = q.ToList().LastOrDefault().Date;

            //換日rid_i重置為1
            if (datecheck != DateTime.Now.Date)
            {
                rid_i = 1;
            }

            /*RID*/
            string result = "";
            switch (rid_i / 10)             //RID後三碼的規則
            {
                case 0:
                    result = "00" + rid_i;
                    break;
                case 1:
                    result = "0" + rid_i;
                    break;
            }
            string rid = (DateTime.Now.Year - 1911).ToString() + DateTime.Now.Date.ToString("MMdd") + result;

            /*取得StaffID資訊*/
            var SID = from n in this.BMContext.UserAccount
                      where n.Account == this.UserName
                      select n.StaffID;

            /*取得Key in的資料*/
            Info[Num - 1] = new ParkInfo
            {
                RID = rid,
                ParkingNum = Convert.ToInt32(this.txtNum.Text),
                LicensePlate = this.txtLicencePlate.Text,
                EnterTime = Convert.ToDateTime(this.txtEnterTime.Text),
                ContactName = this.txtContactName.Text,
                ContactPhone = this.txtContactPhone.Text,
                StaffID = SID.Single(),
            };

            /*新增提示*/
            MessageBox.Show("已新增一筆停車資訊\n車輛入場時間："+Info[Num - 1].EnterTime.ToString($"{DateTime.Now.Year - 1911}/MM/dd HH:mm:ss"));

            /*新增停放車輛後改變停車格的顏色*/
            CarIn();

            /*控制項設定*/
            this.btnUpdate.Enabled = true;
            this.btnDelete.Enabled = true;
            this.btnPay.Enabled = true;
            this.btnNew.Enabled = false;


            /*新增至資料庫*/
            this.BMContext.ParkingManagement.Add(new EntityLibrary.ParkingManagement
            {
                RID = rid,
                ParkingNum = Info[Num - 1].ParkingNum,
                LicensePlate = Info[Num - 1].LicensePlate,
                EnterTime = Info[Num - 1].EnterTime,
                ContactName = Info[Num - 1].ContactName,
                ContactPhone = Info[Num - 1].ContactPhone,
                StaffID = Info[Num - 1].StaffID,
            });
            this.BMContext.SaveChanges();
            rid_i++;
        }

        /*修改*/
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var Parkinfo = this.BMContext.ParkingManagement.AsEnumerable().FirstOrDefault(x => x.RID == Info[Num - 1].RID);
            if (!String.IsNullOrEmpty(this.txtLicencePlate.Text))
            {
                Info[Num - 1].LicensePlate = this.txtLicencePlate.Text;
                Parkinfo.LicensePlate = Info[Num - 1].LicensePlate;
            }
            if (!String.IsNullOrEmpty(this.txtContactName.Text))
            {
                Info[Num - 1].ContactName = this.txtContactName.Text;
                Parkinfo.ContactName = Info[Num - 1].ContactName;
            }
            if (!String.IsNullOrEmpty(this.txtContactPhone.Text))
            {
                Info[Num - 1].ContactPhone = this.txtContactPhone.Text;
                Parkinfo.ContactPhone = Info[Num - 1].ContactPhone;
            }
            this.BMContext.SaveChanges();
            MessageBox.Show($"車格編號：{Info[Num-1].ParkingNum} 之資訊已更新！");
        }

        /*刪除*/
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"是否要刪除車格編號：{Info[Num-1].ParkingNum}之資料？", "刪除確認...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var Parkinfo = this.BMContext.ParkingManagement.AsEnumerable().FirstOrDefault(x => x.RID == Info[Num - 1].RID);
                if (Parkinfo != null)
                {
                    this.BMContext.ParkingManagement.Remove(Parkinfo);
                    this.BMContext.SaveChanges();
                }
                Info[Num - 1] = null;
                CarOut();                   //車子離開，改變車格狀態
                ClearText();                //清除TextBox內的資訊

                /*控制項設定*/
                this.btnNew.Enabled = true;
                this.btnUpdate.Enabled = false;
                this.btnDelete.Enabled = false;
                this.btnPay.Enabled = false;
            }

        }

        /*繳費離場*/
        private void btnPay_Click(object sender, EventArgs e)
        {
            DateTime quit = DateTime.Now;
            int Fee = ParkInfo.FeeCal(Info[Num - 1].EnterTime, quit);
            if (MessageBox.Show("車輛是否要繳費並離場？", "繳費確認...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("入場時間：" + Info[Num - 1].EnterTime + "\n離場時間：" + quit + "\n應繳金額：" + Fee);
            }
            var Parkinfo = this.BMContext.ParkingManagement.AsEnumerable().FirstOrDefault(x => x.RID == Info[Num - 1].RID);
            Parkinfo.QuitTime = quit;
            Parkinfo.ParkingFee = Fee;
            this.BMContext.SaveChanges();
            Info[Num - 1] = null;
            CarOut();                   //車子離開，改變車格狀態
            ClearText();                //清除TextBox內的資訊

            /*控制項設定*/
            this.btnNew.Enabled = true;
            this.btnUpdate.Enabled = false;
            this.btnDelete.Enabled = false;
            this.btnPay.Enabled = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.txtEnterTime.Text = DateTime.Now.ToString("MM月dd日 HH:mm:ss");
        }

        /*關閉表單，儲存設定、變數*/
        private void FrmParkingManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.rid = rid_i;
            Properties.Settings.Default.CarIn = Info;
            Properties.Settings.Default.Save();
        }

        /*介面還原到程式關閉表單前的介面*/
        private void FrmParkingManagement_Load(object sender, EventArgs e)
        {
            this.lblStatus0.Text = this.UserName + ", Welcome";
            this.lblStatus1.Text = this.UserName + ", Welcome";
            this.lblStatus2.Text = this.UserName + ", Welcome";
            this.lblStatus3.Text = this.UserName + ", Welcome";//登入狀態lb

            ParkInfo[] Info_settings = new ParkInfo[30];
            rid_i = Properties.Settings.Default.rid;
            Info_settings = Properties.Settings.Default.CarIn;
            foreach (var x in Info_settings)
            {
                if (x != null)
                {
                    foreach (Control b in this.tPParkingUI.Controls)
                    {
                        if (int.TryParse(b.Text, out int num))
                        {
                            if (b is Button && x.ParkingNum == num)
                            {
                                b.BackColor = this.FC1;
                                b.ForeColor = this.FC4;
                            }
                        }
                    }
                }
            }


            var q = from pm in this.BMContext.ParkingManagement
                    where pm.QuitTime.HasValue
                    select pm.QuitTime.Value.Year;
            foreach (int year in q.Distinct().OrderByDescending(x => x).ToList())
            {
                this.cmbChartYear.Items.Add(year);
            }
            this.cmbChartYear.SelectedIndex = 0;

            var r = from pm in this.BMContext.ParkingManagement
                    where pm.QuitTime.HasValue
                    select pm.QuitTime.Value.Month;
            this.cmbChartMonth.Items.Add("整年度");
            foreach (int month in r.Distinct().OrderBy(x => x).ToList())
            {
                this.cmbChartMonth.Items.Add(month);
            }
            this.cmbChartMonth.SelectedIndex = 0;

            this.txtFEnterTime1.Text = DateTime.Now.ToString("yyyyMMddhhmmss");
            this.txtFEnterTime2.Text = DateTime.Now.ToString("yyyyMMddhhmmss");
        }

        #region 頁面切換功能
        /*切換頁面*/
        private void btnParking_Click(object sender, EventArgs e)
        {
            ChangePage(1);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ChangePage(2);
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            ChangePage(3);
        }

        private void btnBack1_Click(object sender, EventArgs e)
        {
            ChangePage(0);
        }

        private void btnBack2_Click(object sender, EventArgs e)
        {
            ChangePage(0);
        }

        private void btnBack3_Click(object sender, EventArgs e)
        {
            ChangePage(0);
        }
        #endregion

        /*產生報表*/
        private void createChart()
        {
            if (this.cmbChartMonth.Text == "整年度")
            {
                var q = from pm in this.BMContext.ParkingManagement.AsEnumerable()
                        where pm.QuitTime.HasValue && pm.QuitTime.Value.Year.ToString() == this.cmbChartYear.Text
                        group pm by pm.QuitTime.Value.Month into g
                        select new { Month = $"{g.Key}", MonthlyFee = g.Sum(x => x.ParkingFee) };

                this.chart1.Visible = true;
                this.chart1.DataSource = q.ToList();
                this.chart1.ChartAreas[0].Axes[0].Title = "月份";
                this.chart1.ChartAreas[0].AxisX.Interval = 1;
                this.chart1.ChartAreas[0].Axes[1].Title = $"月停車費收入︵NT︶";
                this.chart1.Series[0].Name = $"{this.cmbChartYear.Text}年";
                this.chart1.Series[0].XValueMember = "Month";
                this.chart1.Series[0].YValueMembers = "MonthlyFee";
                this.chart1.Titles[0].Text = $"{this.cmbChartYear.Text}年度停車費報表";
            }
            else
            {
                var q = from pm in this.BMContext.ParkingManagement.AsEnumerable()
                        where pm.QuitTime.HasValue && pm.QuitTime.Value.Year.ToString() == this.cmbChartYear.Text && pm.QuitTime.Value.Month.ToString() == this.cmbChartMonth.Text
                        group pm by pm.QuitTime.Value.Date into g
                        select new { day = $"{g.Key:dd}", DaylyFee = g.Sum(x => x.ParkingFee) };

                this.chart1.Visible = true;
                this.chart1.DataSource = q.ToList();
                this.chart1.ChartAreas[0].Axes[0].Title = "日期";
                this.chart1.ChartAreas[0].AxisX.Interval = 1;
                this.chart1.ChartAreas[0].Axes[1].Title = $"該日停車費收入︵NT︶";
                this.chart1.Series[0].Name = $"{this.cmbChartYear.Text}年{this.cmbChartMonth.Text}月停車費";
                this.chart1.Series[0].XValueMember = "day";
                this.chart1.Series[0].YValueMembers = "DaylyFee";
                this.chart1.Titles[0].Text = $"{this.cmbChartYear.Text}年{this.cmbChartMonth.Text}月份停車費報表";
            }
        }

        private void cmbChartYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            createChart();
        }

        private void cmbChartMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            createChart();
        }

        /*報表類型選擇事件*/
        private void cmbChartType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.cmbChartType.SelectedIndex)
            {
                case 0:
                    this.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    break;
                case 1:
                    this.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    this.chart1.Series[0].BorderWidth = 2;
                    break;
                case 2:
                    this.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                    break;
            }
        }

        //private void btnChartCompare_Click(object sender, EventArgs e)
        //{
        //    Series compare = new Series();
        //    if (this.cmbChartMonth.Text == "")
        //    {
        //        //var q = from pm in this.BMContext.ParkingManagement.AsEnumerable()
        //        //        where pm.QuitTime.HasValue && pm.QuitTime.Value.Year.ToString() == this.cmbChartYear.Text
        //        //        group pm by pm.QuitTime.Value.Month into g
        //        //        select new { Month = $"{g.Key}", MonthlyFee = g.Sum(x => x.ParkingFee) };

        //        compare.Name = $"{this.cmbChartYear.Text}年";
        //        compare.XValueMember = "Month";
        //        compare.YValueMembers = "MonthlyFee";

        //    }
        //    else
        //    {
        //        //var q = from pm in this.BMContext.ParkingManagement.AsEnumerable()
        //        //        where pm.QuitTime.HasValue && pm.QuitTime.Value.Year.ToString() == this.cmbChartYear.Text && pm.QuitTime.Value.Month.ToString() == this.cmbChartMonth.Text
        //        //        group pm by pm.QuitTime.Value.Date into g
        //        //        select new { day = $"{g.Key:dd}", DaylyFee = g.Sum(x => x.ParkingFee) };

        //        compare.Name = $"{this.cmbChartYear.Text}年{this.cmbChartMonth.Text}月";
        //        compare.XValueMember = "day";
        //        compare.YValueMembers = "DaylyFee";
        //    }
        //    this.chart1.Series.Add(compare);
        //}

        /*清除停車頁面的TextBox的內容*/
        private void ClearText()
        {
            foreach (Control x in this.tPParkingUI_1.Controls)
            {
                if (x is TextBox)
                {
                    x.Text = "";
                }
            }
        }

        /*停放車輛時改變車格顏色*/
        private void CarIn()
        {
            foreach (Control x in this.tPParkingUI.Controls)
            {
                if (x is Button && (int.TryParse(x.Text, out int num)))
                {
                    if (num == Info[Num - 1].ParkingNum)
                    {
                        x.BackColor = this.FC1;
                        x.ForeColor = this.FC4;
                    }
                }
            }
        }

        /*車輛離開時改變車格顏色*/
        private void CarOut()
        {
            foreach (Control x in this.tPParkingUI.Controls)
            {
                if (x is Button && (int.TryParse(x.Text, out int num)))
                {
                    if (Num == num)
                    {
                        x.BackColor = this.FC3;
                        x.ForeColor = this.FC4;
                    }
                }
            }

        }

        /*換頁*/
        private void ChangePage(int index)
        {
            this.tabControl1.SelectedIndex = index;
            this.tabControl2.SelectedIndex = index;
        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {
            this.txtNum.Text = Num.ToString();
        }

        private void FrmParkingManagement_Resize(object sender, EventArgs e)
        {
            this.Titlelb.Size = new Size(300, 100);
            this.panel1.Size = new Size(300, 561);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked)
                {
                    if (this.txtFLicensePlate.Text.Trim()!="")
                    {
                        var q = from pm in this.BMContext.ParkingManagement.AsEnumerable()
                                where pm.LicensePlate == this.txtFLicensePlate.Text && pm.QuitTime is null
                                select new { 車格編號 = pm.ParkingNum, 車牌號碼 = pm.LicensePlate, 入場時間 = pm.EnterTime, 聯絡人 = pm.ContactName, 聯絡電話 = pm.ContactPhone, 登錄人員 = pm.StaffDataTable.StaffName };
                        if (q == null)
                        {
                            MessageBox.Show("查無資料！");
                        }
                        else
                        {
                            this.dataGridView1.DataSource = q.ToList();
                        }
                    }
                    else
                    {
                        MessageBox.Show("請填入欲查詢之資料！");
                    }
                }
                else if (radioButton2.Checked)
                {
                    if (this.txtFContactName.Text.Trim() != "")
                    {
                        var q = from pm in this.BMContext.ParkingManagement.AsEnumerable()
                                where pm.ContactName == this.txtFContactName.Text && pm.QuitTime is null
                                select new { 車格編號 = pm.ParkingNum, 車牌號碼 = pm.LicensePlate, 入場時間 = pm.EnterTime, 聯絡人 = pm.ContactName, 聯絡電話 = pm.ContactPhone, 登錄人員 = pm.StaffDataTable.StaffName };
                        if (q == null)
                        {
                            MessageBox.Show("查無資料！");
                        }
                        else
                        {
                            this.dataGridView1.DataSource = q.ToList();
                        }
                    }
                    else
                    {
                        MessageBox.Show("請填入欲查詢之資料！");
                    }
                }
                else if (radioButton3.Checked)
                {
                    if (this.txtFContactPhone.Text.Trim() != "")
                    {
                        var q = from pm in this.BMContext.ParkingManagement.AsEnumerable()
                                where pm.ContactPhone == this.txtFContactPhone.Text && pm.QuitTime is null
                                select new { 車格編號 = pm.ParkingNum, 車牌號碼 = pm.LicensePlate, 入場時間 = pm.EnterTime, 聯絡人 = pm.ContactName, 聯絡電話 = pm.ContactPhone, 登錄人員 = pm.StaffDataTable.StaffName };
                        if (q == null)
                        {
                            MessageBox.Show("查無資料！");
                        }
                        else
                        {
                            this.dataGridView1.DataSource = q.ToList();
                        }
                    }
                    else
                    {
                        MessageBox.Show("請填入欲查詢之資料！");
                    }
                }
                else if (radioButton4.Checked)
                {
                    if (this.txtFEnterTime1.Text.Trim() != "" && this.txtFEnterTime2.Text.Trim() != "")
                    {
                        var q = from pm in this.BMContext.ParkingManagement.AsEnumerable()
                                where pm.EnterTime >= Convert.ToDateTime(this.txtFEnterTime1.Text) && pm.EnterTime <= Convert.ToDateTime(this.txtFEnterTime2.Text) && pm.QuitTime is null
                                select new { 車格編號 = pm.ParkingNum, 車牌號碼 = pm.LicensePlate, 入場時間 = pm.EnterTime, 聯絡人 = pm.ContactName, 聯絡電話 = pm.ContactPhone, 登錄人員 = pm.StaffDataTable.StaffName };
                        if (q == null)
                        {
                            MessageBox.Show("查無資料！");
                        }
                        else
                        {
                            this.dataGridView1.DataSource = q.ToList();
                        }
                    }
                    else
                    {
                        MessageBox.Show("請填入欲查詢之資料！");
                    }
                }
                else if(radioButton5.Checked)
                {
                    if (this.txtfStay.Text.Trim() != "")
                    {
                        var q = from pm in this.BMContext.ParkingManagement.AsEnumerable()
                                where pm.QuitTime is null && ((DateTime.Now - pm.EnterTime).Days >= Convert.ToInt32(this.txtfStay.Text))
                                select new { 滯留天數 = (DateTime.Now- pm.EnterTime).Days,車格編號 = pm.ParkingNum, 車牌號碼 = pm.LicensePlate, 入場時間 = pm.EnterTime, 聯絡人 = pm.ContactName, 聯絡電話 = pm.ContactPhone, 登錄人員 = pm.StaffDataTable.StaffName };
                        if (q == null)
                        {
                            MessageBox.Show("查無資料！");
                        }
                        else
                        {
                            this.dataGridView1.DataSource = q.ToList();
                        }
                    }
                    else
                    {
                        MessageBox.Show("請填入欲查詢之資料！");
                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show("請填入欲查詢之資料！");
            }
        }

        private void txtFLicensePlate_Enter(object sender, EventArgs e)
        {
            this.radioButton1.Checked = true;
        }

        private void txtFContactName_Enter(object sender, EventArgs e)
        {
            this.radioButton2.Checked = true;
        }

        private void txtFContactPhone_Enter(object sender, EventArgs e)
        {
            this.radioButton3.Checked = true;
        }

        private void txtFEnterTime1_Enter(object sender, EventArgs e)
        {
            this.radioButton4.Checked = true;
        }

        private void txtFEnterTime2_Enter(object sender, EventArgs e)
        {
            this.radioButton4.Checked = true;
        }

        private void txtfStay_Enter(object sender, EventArgs e)
        {
            this.radioButton5.Checked = true;
        }


        /*DEMO*/
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime quit = Info[Num - 1].EnterTime.AddMinutes(30);
            int Fee = ParkInfo.FeeCal(Info[Num - 1].EnterTime, quit);
            if (MessageBox.Show("確定車輛是否要繳費並離場？", "繳費確認...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("入場時間：" + Info[Num - 1].EnterTime + "\n離場時間：" + quit + "\n應繳金額：" + Fee);
            }
            var Parkinfo = this.BMContext.ParkingManagement.AsEnumerable().FirstOrDefault(x => x.RID == Info[Num - 1].RID);
            Parkinfo.QuitTime = quit;
            Parkinfo.ParkingFee = Fee;
            this.BMContext.SaveChanges();
            Info[Num - 1] = null;
            CarOut();
            ClearText();             //清除TextBox內的資訊

            /*控制項設定*/
            this.btnNew.Enabled = true;
            this.btnUpdate.Enabled = false;
            this.btnDelete.Enabled = false;
            this.btnPay.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime quit = Info[Num - 1].EnterTime.AddMinutes(61);
            int Fee = ParkInfo.FeeCal(Info[Num - 1].EnterTime, quit);
            if (MessageBox.Show("確定車輛是否要繳費並離場？", "繳費確認...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("入場時間：" + Info[Num - 1].EnterTime + "\n離場時間：" + quit + "\n應繳金額：" + Fee);
            }
            var Parkinfo = this.BMContext.ParkingManagement.AsEnumerable().FirstOrDefault(x => x.RID == Info[Num - 1].RID);
            Parkinfo.QuitTime = quit;
            Parkinfo.ParkingFee = Fee;
            this.BMContext.SaveChanges();
            Info[Num - 1] = null;
            CarOut();
            ClearText();              //清除TextBox內的資訊

            /*控制項設定*/
            this.btnNew.Enabled = true;
            this.btnUpdate.Enabled = false;
            this.btnDelete.Enabled = false;
            this.btnPay.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime quit = Info[Num - 1].EnterTime.AddMinutes(91);
            int Fee = ParkInfo.FeeCal(Info[Num - 1].EnterTime, quit);
            if (MessageBox.Show("確定車輛是否要繳費並離場？", "繳費確認...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("入場時間：" + Info[Num - 1].EnterTime + "\n離場時間：" + quit + "\n應繳金額：" + Fee);
            }
            var Parkinfo = this.BMContext.ParkingManagement.AsEnumerable().FirstOrDefault(x => x.RID == Info[Num - 1].RID);
            Parkinfo.QuitTime = quit;
            Parkinfo.ParkingFee = Fee;
            this.BMContext.SaveChanges();
            Info[Num - 1] = null;
            CarOut();
            ClearText();              //清除TextBox內的資訊

            /*控制項設定*/
            this.btnNew.Enabled = true;
            this.btnUpdate.Enabled = false;
            this.btnDelete.Enabled = false;
            this.btnPay.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            
            for (int yyy = 106; yyy < 109; yyy++)
            {
                for (int m = 1; m < 13; m++)
                {
                    string mm;
                    if (m < 10)
                    {
                        mm = "0" + m;
                    }
                    else
                    {
                        mm = m.ToString();
                    }
                    for (int d = 1; d < 29; d++)
                    {
                        string dd;
                        if (d < 10)
                        {
                            dd = "0" + d;
                        }
                        else
                        {
                            dd = d.ToString();
                        }
                        int count = r.Next(1, 5);
                        for (int i = 1; i < count+1; i++)
                        {
                            string rid;
                            if (i < 10)
                            {
                                rid = "00" + i;
                            }
                            else
                            {
                                rid = "0" + i;
                            }

                            DateTime et = new DateTime(yyy + 1911, m, d, 9, 0, 0, 0);
                            this.BMContext.ParkingManagement.Add(new EntityLibrary.ParkingManagement
                            {
                                RID = yyy + mm + dd + rid,
                                ParkingNum = i,
                                LicensePlate = "1",
                                EnterTime = et,
                                QuitTime = et.AddHours(count),
                                ParkingFee = ParkInfo.FeeCal(et, et.AddHours(count)),
                                StaffID = "test",
                            }
                            );
                        }
                    }
                }
            }

            this.BMContext.SaveChanges();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 11; i < 18; i++)
            {
                /*RID*/
                string result = "";
                switch (i / 10)             //RID後三碼的規則
                {
                    case 0:
                        result = "00" + rid_i;
                        break;
                    case 1:
                        result = "0" + rid_i;
                        break;
                }
                string rid = (DateTime.Now.Year - 1911).ToString() + DateTime.Now.Date.ToString("MMdd") + result;

                /*取得StaffID資訊*/
                var SID = from n in this.BMContext.UserAccount
                          where n.Account == this.UserName
                          select n.StaffID;

                /*取得Key in的資料*/
                Info[i - 1] = new ParkInfo
                {
                    RID = rid,
                    ParkingNum = i,
                    LicensePlate = "ABC-"+i,
                    EnterTime = DateTime.Now.AddDays(-7),
                    ContactName = ""+i,
                    ContactPhone = ""+i,
                    StaffID = SID.Single(),
                };

                /*新增停放車輛後改變停車格的顏色*/
                foreach (Control x in this.tPParkingUI.Controls)
                {
                    if (x is Button && (int.TryParse(x.Text, out int num)))
                    {
                        if (num == Info[i - 1].ParkingNum)
                        {
                            x.BackColor = this.FC1;
                            x.ForeColor = this.FC4;
                        }
                    }
                }

                /*控制項設定*/
                this.btnUpdate.Enabled = true;
                this.btnDelete.Enabled = true;
                this.btnPay.Enabled = true;
                this.btnNew.Enabled = false;

                /*新增至資料庫*/
                this.BMContext.ParkingManagement.Add(new EntityLibrary.ParkingManagement
                {
                    RID = rid,
                    ParkingNum = Info[i - 1].ParkingNum,
                    LicensePlate = Info[i - 1].LicensePlate,
                    EnterTime = Info[i - 1].EnterTime,
                    ContactName = Info[i - 1].ContactName,
                    ContactPhone = Info[i - 1].ContactPhone,
                    StaffID = Info[i - 1].StaffID,
                });
                this.BMContext.SaveChanges();
                rid_i++;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.txtFContactPhone.Text += "        ";
        }
    }
}
