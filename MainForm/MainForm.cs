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
using GeneralAffairsSystem;
using LogSystem;
using ParkingManagement;
using PackageSys;
using EquipSys;
using DisasterPreventionSys;
using ControlLibrary;
using EntityLibrary;

namespace MainForm
{
    public partial class MainForm : FrmLogo3
    {
        bool loginStatus = false;
        public string Account;
        public MainForm()
        {
            InitializeComponent();
            
            Title = "大樓管理系統";
            foreach(Control x in this.Controls)
            {
                if(x is Button)
                {
                    ((Button)x).MouseEnter += button_MouseEnter;//註冊滑鼠進入按鈕事件
                    ((Button)x).MouseLeave += button_MouseLeave;//註冊滑鼠離開按鈕事件
                    ((Button)x).FlatAppearance.BorderSize=0;//按鈕除邊
                    ((Button)x).FlatStyle = FlatStyle.Flat;
                    ((Button)x).FlatAppearance.MouseDownBackColor = Color.FromArgb(143, 188, 139);//滑鼠按下
                    ((Button)x).FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);//滑鼠進入
                }
            }
        }

        private void button_MouseEnter(object sender, EventArgs e)
        {
            switch((sender as Button).Name)
            {
                case "button1":
                    button1.Text = "包裹";
                    break;
                case "button2":
                    button2.Text = "能源";
                    break;
                case "button3":
                    button3.Text = "庶務";
                    break;
                case "button4":
                    button4.Text = "設備";
                    break;
                case "button5":
                    button5.Text = "門禁";
                    break;
                case "button6":
                    button6.Text = "防災";
                    break;
            }
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            switch ((sender as Button).Name)
            {
                case "button1":
                    button1.Text = "";
                    break;
                case "button2":
                    button2.Text = "";
                    break;
                case "button3":
                    button3.Text = "";
                    break;
                case "button4":
                    button4.Text = "";
                    break;
                case "button5":
                    button5.Text = "";
                    break;
                case "button6":
                    button6.Text = "";
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GASys gas = new GASys();
            gas.UserName = UserName;
            gas.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmParkingManagement fpm = new FrmParkingManagement();
            fpm.UserName = UserName;
            fpm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!loginStatus)
            {
                FrmLogin fl = new FrmLogin();
                if (DialogResult.OK == fl.ShowDialog())
                {
                    Account = fl.username;
                    loginStatus = true;
                    UserName = Account;
                    IoTGetData a = new IoTGetData();
                    //a.Visible = false;
                    this.Controls.Add(a);
                    GetAlert.Enabled = true;
                }
                else
                    this.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmPackageSys fps = new FrmPackageSys();
            fps.UserName = UserName;
            fps.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormEqMain feqm = new FormEqMain();
            feqm.UserName = UserName;
            feqm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DPSys dps = new DPSys();
            dps.UserName = UserName;
            dps.Show();
        }

        int AlertCount = 0;
        private async void GetAlert_Tick(object sender, EventArgs e)
        {
            Buliding_ManagementEntities db = new Buliding_ManagementEntities();
            var q = db.IoTAlert;
            if(q.Any(n => n.Alert == true))
            {
                var x = q.Where(n => n.Alert == true).FirstOrDefault();
                string place = x.Place;
                string type = x.PS;
                DateTime time = x.Time;
                DialogResult a = await Task.Run(() => ShowAlert(place,type));
                if (a == DialogResult.Yes)
                {
                    AlertCount = 0;
                    x.Alert = false;
                    db.SaveChanges();
                }
                else if (a == DialogResult.No) 
                {
                    AlertCount--;
                }
                /*else { Task.WaitAll(); }*/
            }
        }
        
        public DialogResult ShowAlert(string Place,string Type)
        {
            while(AlertCount<5)
            {
                AlertCount++;
                DialogResult result = MessageBox.Show($@"位置{Place} {Type}數值超標", "警報", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                return result;
            }
            return DialogResult.Ignore;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
