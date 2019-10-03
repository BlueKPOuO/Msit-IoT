using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormLogoClassLibrary;
using EntityLibrary;

namespace StaffSystem
{
    public partial class StaffSys : FrmLogo3
    {
        public StaffSys()
        {//檢視資料
            InitializeComponent();
            Title = "大樓管理系統\r\n工作人員管理";
            tabControl1.SelectedIndex = 0;
            cbEShift.SelectedIndex = 0;
            cbNShift.SelectedIndex = 0;
            cbSShift.SelectedIndex = 0;            
        }

        private void button1_Click(object sender, EventArgs e)
        {//查詢頁
            tabControl1.SelectedIndex = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {//新增頁
            tabControl1.SelectedIndex = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {//編輯頁
            tabControl1.SelectedIndex = 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {//刪除頁
            tabControl1.SelectedIndex = 4;
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            switch (((RadioButton)sender).TabIndex)
            {
                case 1:
                    tbSID.Enabled = true;
                    tbSName.Enabled = false;
                    dtpEnTime1.Enabled = false;
                    dtpEnTime2.Enabled = false;
                    tbSPhone.Enabled = false;
                    cbStatus.Enabled = false;
                    cbSShift.Enabled = false;
                    break;
                case 2:
                    tbSID.Enabled = false;
                    tbSName.Enabled = true;
                    dtpEnTime1.Enabled = false;
                    dtpEnTime2.Enabled = false;
                    tbSPhone.Enabled = false;
                    cbStatus.Enabled = false;
                    cbSShift.Enabled = false;
                    break;
                case 3:
                    tbSID.Enabled = false;
                    tbSName.Enabled = false;
                    dtpEnTime1.Enabled = true;
                    dtpEnTime2.Enabled = true;
                    tbSPhone.Enabled = false;
                    cbStatus.Enabled = false;
                    cbSShift.Enabled = false;
                    break;
                case 4:
                    tbSID.Enabled = false;
                    tbSName.Enabled = false;
                    dtpEnTime1.Enabled = false;
                    dtpEnTime2.Enabled = false;
                    tbSPhone.Enabled = true;
                    cbStatus.Enabled = false;
                    cbSShift.Enabled = false;
                    break;
                case 5:
                    tbSID.Enabled = false;
                    tbSName.Enabled = false;
                    dtpEnTime1.Enabled = false;
                    dtpEnTime2.Enabled = false;
                    tbSPhone.Enabled = false;
                    cbStatus.Enabled = true;
                    cbSShift.Enabled = false;
                    break;
                case 6:
                    tbSID.Enabled = false;
                    tbSName.Enabled = false;
                    dtpEnTime1.Enabled = false;
                    dtpEnTime2.Enabled = false;
                    tbSPhone.Enabled = false;
                    cbStatus.Enabled = false;
                    cbSShift.Enabled = true;
                    break;
            }
        }

        private void cbStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (cbStatus.Checked)
                cbStatus.Text = "任職中";
            else
                cbStatus.Text = "已離職";
        }
        /*
        public IEnumerable<property> NormalSelect(property qq)
        {
            Buliding_ManagementEntities db = new Buliding_ManagementEntities();
            var q = from n in db.StaffDataTable.AsEnumerable()
                    select new property
                    {
                        工作人員編號 = n.StaffID,
                        工作人員姓名 = n.StaffName,
                        入職時間 = n.EntryDate,
                        離職時間 = n.LeaveDate,
                        連絡電話 = n.StaffPhone,
                        Line_ID = n.StaffLINE_ID,
                        //值班時間 = Worktime(n.ShiftTable.First().StartTime, n.ShiftTable.First().EndTime)
                    };
            return q;
        }

        public class property
        {
            public string 工作人員編號;
            public string 工作人員姓名;
            public DateTime 入職時間;
            public DateTime? 離職時間;
            public string 連絡電話;
            public string Line_ID;
            public string 值班時間;
        }*/

        string Worktime(TimeSpan? a,TimeSpan? b)
        {
            return a.Value.ToString() +" - " + b.Value.ToString();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            Buliding_ManagementEntities db = new Buliding_ManagementEntities();
            var q = from a in db.StaffDataWorkTime
                    select new
                    {
                        工作人員編號 = a.StaffID,
                        工作人員姓名 = a.StaffName,
                        入職時間 = a.EntryDate,
                        離職時間 = a.LeaveDate,
                        連絡電話 = a.StaffPhone,
                        Line_ID = a.StaffLINE_ID,
                        工作時間 = a.WorkTime
                    };

            dataGridView1.DataSource = q.ToList();
            EditPageclear();
        }

        private void btAll_Click(object sender, EventArgs e)
        {
            Buliding_ManagementEntities db = new Buliding_ManagementEntities();
            var q = db.StaffDataWorkTime.Select(n=>new
            {
                工作人員編號 = n.StaffID,
                工作人員姓名 = n.StaffName,
                入職時間 = n.EntryDate,
                離職時間 = n.LeaveDate,
                連絡電話 = n.StaffPhone,
                Line_ID = n.StaffLINE_ID,
                工作時間 = n.WorkTime
            });
            dataGridView1.DataSource = q.ToList();
        }

        private void btSearch1_Click(object sender, EventArgs e)
        {
            Buliding_ManagementEntities db = new Buliding_ManagementEntities();
            int rTabindex = -1;
            foreach(Control x in tabControl1.TabPages[1].Controls)
            {
                if(x is RadioButton)
                {
                    if(((RadioButton)x).Checked)
                    {
                        rTabindex = ((RadioButton)x).TabIndex;
                    }
                }
            }
            switch (rTabindex)
            {
                case 1:
                    //tbSID.Text
                    var q1 = db.StaffDataWorkTime.Where(d => d.StaffID==tbSID.Text).Select(n => new
                    {
                        工作人員編號 = n.StaffID,
                        工作人員姓名 = n.StaffName,
                        入職時間 = n.EntryDate,
                        離職時間 = n.LeaveDate,
                        連絡電話 = n.StaffPhone,
                        Line_ID = n.StaffLINE_ID,
                        工作時間 = n.WorkTime
                    });/*
                    var q1 = from a in db.StaffDataTable.AsEnumerable()
                            where a.StaffID == tbSID.Text
                            select new
                            {
                                工作人員編號 = a.StaffID,
                                工作人員姓名 = a.StaffName,
                                入職時間 = a.EntryDate,
                                離職時間 = a.LeaveDate,
                                連絡電話 = a.StaffPhone,
                                Line_ID = a.StaffLINE_ID,
                                值班時間 = Worktime(a.ShiftTable.Select(b => b.StartTime).First(), a.ShiftTable.Select(b => b.EndTime).First())
                            }; */
                    dataGridView1.DataSource = q1.ToList();
                    tabControl1.SelectedIndex = 0;
                    break;
                case 2:
                    //tbSName
                    var q2 = from a in db.StaffDataTable
                             where a.StaffName == tbSName.Text
                             select a;
                    dataGridView1.DataSource = q2.ToList();
                    tabControl1.SelectedIndex = 0;
                    break;
                case 3:
                    //dtpEnTime1
                    //dtpEnTime2
                    var q3 = from a in db.StaffDataWorkTime
                             where a.EntryDate > dtpEnTime1.Value && a.EntryDate < dtpEnTime2.Value
                             select new
                             {
                                 工作人員編號 = a.StaffID,
                                 工作人員姓名 = a.StaffName,
                                 入職時間 = a.EntryDate,
                                 離職時間 = a.LeaveDate,
                                 連絡電話 = a.StaffPhone,
                                 Line_ID = a.StaffLINE_ID,
                                 工作時間 = a.WorkTime
                             }; 
                    dataGridView1.DataSource = q3.ToList();
                    tabControl1.SelectedIndex = 0;
                    break;
                case 4:
                    //tbSPhone
                    var q4 = from a in db.StaffDataWorkTime
                             where a.StaffPhone == tbSPhone.Text
                             select new
                             {
                                 工作人員編號 = a.StaffID,
                                 工作人員姓名 = a.StaffName,
                                 入職時間 = a.EntryDate,
                                 離職時間 = a.LeaveDate,
                                 連絡電話 = a.StaffPhone,
                                 Line_ID = a.StaffLINE_ID,
                                 工作時間 = a.WorkTime
                             };
                    dataGridView1.DataSource = q4.ToList();
                    tabControl1.SelectedIndex = 0;
                    break;
                case 5:
                    //cbStatus
                    var q5 = from a in db.StaffDataWorkTime
                             where a.OnWork == cbStatus.Checked
                             select new
                             {
                                 工作人員編號 = a.StaffID,
                                 工作人員姓名 = a.StaffName,
                                 入職時間 = a.EntryDate,
                                 離職時間 = a.LeaveDate,
                                 連絡電話 = a.StaffPhone,
                                 Line_ID = a.StaffLINE_ID,
                                 工作時間 = a.WorkTime
                             };
                    dataGridView1.DataSource = q5.ToList();
                    tabControl1.SelectedIndex = 0;
                    break;
                case 6://comboBox
                    switch(cbSShift.SelectedIndex)
                    {
                        case 0:
                            var q6 = from a in db.StaffDataWorkTime
                                     where a.WorkTime == "08:00:00 - 17:00:00"
                                     select new
                                     {
                                            工作人員編號 = a.StaffID,
                                            工作人員姓名 = a.StaffName,
                                            入職時間 = a.EntryDate,
                                            離職時間 = a.LeaveDate,
                                            連絡電話 = a.StaffPhone,
                                            Line_ID = a.StaffLINE_ID,
                                            工作時間 = a.WorkTime
                                     };
                            dataGridView1.DataSource = q6.ToList();
                            tabControl1.SelectedIndex = 0;
                            break;
                        case 1:
                            var q7 = from a in db.StaffDataWorkTime
                                     where a.WorkTime == "16:00:00 - 01:00:00"
                                     select new
                                     {
                                         工作人員編號 = a.StaffID,
                                         工作人員姓名 = a.StaffName,
                                         入職時間 = a.EntryDate,
                                         離職時間 = a.LeaveDate,
                                         連絡電話 = a.StaffPhone,
                                         Line_ID = a.StaffLINE_ID,
                                         工作時間 = a.WorkTime
                                     };
                            dataGridView1.DataSource = q7.ToList();
                            tabControl1.SelectedIndex = 0;
                            break;
                        case 2:
                            var q8 = from a in db.StaffDataWorkTime
                                     where a.WorkTime == "00:00:00 - 09:00:00"
                                     select new
                                     {
                                         工作人員編號 = a.StaffID,
                                         工作人員姓名 = a.StaffName,
                                         入職時間 = a.EntryDate,
                                         離職時間 = a.LeaveDate,
                                         連絡電話 = a.StaffPhone,
                                         Line_ID = a.StaffLINE_ID,
                                         工作時間 = a.WorkTime
                                     };
                            dataGridView1.DataSource = q8.ToList();
                            tabControl1.SelectedIndex = 0;
                            break;
                    }
                    break;
            }
        }

        private void btnESearch_Click(object sender, EventArgs e)
        {
            Buliding_ManagementEntities db = new Buliding_ManagementEntities();
            if (tbEID.Text != "" || tbEID.Text != null) 
            {
                try
                {
                    var q = from a in db.StaffDataTable
                            where a.StaffID == tbEID.Text
                            select new
                            {
                                工作人員編號 = a.StaffID,
                                工作人員姓名 = a.StaffName,
                                入職時間 = a.EntryDate,
                                離職時間 = a.LeaveDate,
                                連絡電話 = a.StaffPhone,
                                Line_ID = a.StaffLINE_ID,
                                a.OnWork,
                                a.ShiftID
                            };
                    tbEName.Text = q.First().工作人員姓名;
                    dtpEeD.Value = q.First().入職時間;
                    dtpELD.Value = q.First().離職時間.Value;
                    tbEPhone.Text = q.First().連絡電話;
                    tbELine.Text = q.First().Line_ID;
                    chbEStatus.Checked = q.First().OnWork;
                    switch (q.First().ShiftID)
                    {
                        case "ShA":
                            cbEShift.SelectedIndex = 0;
                            break;
                        case "ShB":
                            cbEShift.SelectedIndex = 1;
                            break;
                        case "ShC":
                            cbEShift.SelectedIndex = 2;
                            break;
                    }
                    tbEID.Enabled = false;
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"沒有找到資料,{ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("請輸入編號");
            }
        }
        void EditPageclear()
        {
            tbEID.Text = "";
            tbEName.Text = "";
            tbELine.Text = "";
            tbEPhone.Text = "";
            chbEStatus.Checked = false;
            tbEID.Enabled = true;
        }
        private void btnESave_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("確定要修改?","是否儲存資料",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if(dr == DialogResult.OK)
            {
                Buliding_ManagementEntities db = new Buliding_ManagementEntities();
                var q = from a in db.StaffDataTable
                        where a.StaffID == tbEID.Text
                        select a;
                q.First().StaffID = tbEID.Text;
                q.First().StaffName = tbEName.Text;
                q.First().EntryDate = dtpEeD.Value;
                q.First().LeaveDate = dtpELD.Value;
                q.First().StaffPhone = tbEPhone.Text;
                q.First().StaffLINE_ID = tbELine.Text;
                q.First().OnWork = chbEStatus.Checked;
                switch(cbEShift.SelectedIndex)
                {
                    case 0:
                        q.First().ShiftID = "ShA";
                        break;
                    case 1:
                        q.First().ShiftID = "ShB";
                        break;
                    case 2:
                        q.First().ShiftID = "ShC";
                        break;
                }
                db.SaveChanges();
                EditPageclear();
                MessageBox.Show("儲存成功");
            }
            
        }

        private void chbEStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (chbEStatus.Checked)
                chbEStatus.Text = "任職中";
            else
                chbEStatus.Text = "已離職";
        }

        private void btnNData_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("確定要新增資料?", "是否新增", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Buliding_ManagementEntities db = new Buliding_ManagementEntities();
                StaffDataTable sdt = new StaffDataTable();
                sdt.StaffID = tbNID.Text;
                sdt.StaffName = tbNName.Text;
                sdt.EntryDate = dtpNET.Value;
                sdt.LeaveDate = dtpNLT.Value;
                sdt.StaffPhone = tbNPhone.Text;
                sdt.StaffLINE_ID = tbNLine.Text;
                sdt.OnWork = chbNStatus.Checked;
                switch (cbNShift.SelectedIndex)
                {
                    case 0:
                        sdt.ShiftID = "ShA";
                        break;
                    case 1:
                        sdt.ShiftID = "ShB";
                        break;
                    case 2:
                        sdt.ShiftID = "ShC";
                        break;
                }
                db.StaffDataTable.Add(sdt);
                try
                {
                    db.SaveChanges();

                }
                catch(Exception ex)
                {
                    MessageBox.Show("請確認編號是否有重複,或者資料是否填寫完整 \r\n" + ex.Message);
                }
                MessageBox.Show("儲存完成!");
            }
        }
        string dID = "";
        private void btnDsearch_Click(object sender, EventArgs e)
        {
            Buliding_ManagementEntities db = new Buliding_ManagementEntities();
            var q = from a in db.StaffDataWorkTime
                    where a.StaffID == tbDSID.Text
                    select new
                    {
                        工作人員編號 = a.StaffID,
                        工作人員姓名 = a.StaffName,
                        入職時間 = a.EntryDate,
                        離職時間 = a.LeaveDate,
                        連絡電話 = a.StaffPhone,
                        Line_ID = a.StaffLINE_ID,
                        在職狀態 = a.OnWork,
                        班別 = a.WorkTime
                    };
            dataGridView2.DataSource = q.ToList();
            dID = tbDSID.Text;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dID=="")
            {
                MessageBox.Show("請先查詢資料");
                return;
            }
            DialogResult dr = MessageBox.Show($"確定要刪除編號{dID}資料?", "是否刪除", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            DialogResult drr = MessageBox.Show($"真的確定要刪除資料?可能會造成資料庫錯誤", "再次確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (drr == DialogResult.Yes)
                {
                    Buliding_ManagementEntities db = new Buliding_ManagementEntities();
                    var q = from a in db.StaffDataTable
                            where a.StaffID == dID
                            select a;
                    try
                    {
                        StaffDataTable sdt = new StaffDataTable();
                        sdt = q.First();
                        db.StaffDataTable.Remove(sdt);
                        db.SaveChanges();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("資料刪除失敗 \r\n" + ex.Message);
                        return;
                    }
                    MessageBox.Show("資料已刪除");
                    dataGridView2.DataSource = null;
                }
            }
        }

        private void chbNStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (chbEStatus.Checked)
                chbEStatus.Text = "任職中";
            else
                chbEStatus.Text = "已離職";
        }
    }
}
