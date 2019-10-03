using FormLogoClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PublicSpacesys
{
    public partial class PublicSpace : FrmLogo3
    {
        public PublicSpace()
        {
            InitializeComponent();

            this._Refresh();
            L1panel.Tag = 1;
            L2panel.Tag = 1;
            L3panel.Tag = 1;
            L4panel.Tag = 1;
            L5panel.Tag = 1;
            L6panel.Tag = 1;
            L7panel.Tag = 1;
            L8panel.Tag = 1;

            timer1.Start();
        }
        public void _Refresh()
        {
            inincontrol();

            //string sqlConnectionString = "server=.\\SQLExpress;database=Space;User ID=desktop-616e58r;Password=;Trusted_Connection=True;";
            //string sqlConnectionString = ConfigurationManager.ConnectionStrings["Buliding_Management"].ConnectionString;
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["Buliding_Management"].ConnectionString;

            //建立連接
             SqlConnection myConn = new SqlConnection(sqlConnectionString);

            //打開連接
            myConn.Open();

            String strSQL = string.Format(@"select * from PublicSpace where StartTime <= '{0}'
                                         ", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));

            //建立SQL命令對象
            SqlCommand myCommand = new SqlCommand(strSQL, myConn);

            //得到Data結果集
            SqlDataReader myDataReader = myCommand.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(myDataReader);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {                    
                    switch (dr["LocationID"].ToString()) //Location資料判斷
                    {
                        case "L1":
                            L1Time.Text = DateTime.Parse(dr["EndTime"].ToString()).ToString("yyyy/MM/dd");
                            L1Name.Text = dr["BarrierName"].ToString();
                            L1Reason.Text = dr["Reason"].ToString();
                            L1status.Text = "借用中";
                            L1status.ForeColor = Color.Red;
                            break;
                        case "L2":
                            L2Time.Text = DateTime.Parse(dr["EndTime"].ToString()).ToString("yyyy/MM/dd");
                            L2Name.Text = dr["BarrierName"].ToString();
                            L2Reason.Text = dr["Reason"].ToString();
                            L2status.Text = "借用中";
                            L2status.ForeColor = Color.Red;
                            break;
                        case "L3":
                            L3Time.Text = DateTime.Parse(dr["EndTime"].ToString()).ToString("yyyy/MM/dd");
                            L3Name.Text = dr["BarrierName"].ToString();
                            L3Reason.Text = dr["Reason"].ToString();
                            L3status.Text = "借用中";
                            L3status.ForeColor = Color.Red;
                            break;
                        case "L4":
                            L4Time.Text = DateTime.Parse(dr["EndTime"].ToString()).ToString("yyyy/MM/dd");
                            L4Name.Text = dr["BarrierName"].ToString();
                            L4Reason.Text = dr["Reason"].ToString();
                            L4status.Text = "借用中";
                            L4status.ForeColor = Color.Red;
                            break;
                        case "L5":
                            L5Time.Text = DateTime.Parse(dr["EndTime"].ToString()).ToString("yyyy/MM/dd");
                            L5Name.Text = dr["BarrierName"].ToString();
                            L5Reason.Text = dr["Reason"].ToString();
                            L5status.Text = "借用中";
                            L5status.ForeColor = Color.Red;
                            break;
                        case "L6":
                            L6Time.Text = DateTime.Parse(dr["EndTime"].ToString()).ToString("yyyy/MM/dd");
                            L6Name.Text = dr["BarrierName"].ToString();
                            L6Reason.Text = dr["Reason"].ToString();
                            L6status.Text = "借用中";
                            L6status.ForeColor = Color.Red;
                            break;
                        case "L7":
                            L7Time.Text = DateTime.Parse(dr["EndTime"].ToString()).ToString("yyyy/MM/dd");
                            L7Name.Text = dr["BarrierName"].ToString();
                            L7Reason.Text = dr["Reason"].ToString();
                            L7status.Text = "借用中";
                            L7status.ForeColor = Color.Red;
                            break;
                        case "L8":
                            L8Time.Text = DateTime.Parse(dr["EndTime"].ToString()).ToString("yyyy/MM/dd");
                            L8Name.Text = dr["BarrierName"].ToString();
                            L8Reason.Text = dr["Reason"].ToString();
                            L8status.Text = "借用中";
                            L8status.ForeColor = Color.Red;
                            break;                       
                    }
                }
            }
            //關閉連接並釋放記憶體資源
            myConn.Close();
            myConn.Dispose();
        }

        private void inincontrol()
        {
            //panel顯示預設

            //L1
            L1Time.Text = "";
            L1Name.Text = "";
            L1Reason.Text = "";
            L1status.Text = "空閒中";
            L1status.ForeColor = Color.Black;
            //L2
            L2Time.Text = "";
            L2Name.Text = "";
            L2Reason.Text = "";
            L2status.Text = "空閒中";
            L2status.ForeColor = Color.Black;
            //L3
            L3Time.Text = "";
            L3Name.Text = "";
            L3Reason.Text = "";
            L3status.Text = "空閒中";
            L3status.ForeColor = Color.Black;
            //L4
            L4Time.Text = "";
            L4Name.Text = "";
            L4Reason.Text = "";
            L4status.Text = "空閒中";
            L4status.ForeColor = Color.Black;
            //L5
            L5Time.Text = "";
            L5Name.Text = "";
            L5Reason.Text = "";
            L5status.Text = "空閒中";
            L5status.ForeColor = Color.Black;
            //L6
            L6Time.Text = "";
            L6Name.Text = "";
            L6Reason.Text = "";
            L6status.Text = "空閒中";
            L6status.ForeColor = Color.Black;
            //L7
            L7Time.Text = "";
            L7Name.Text = "";
            L7Reason.Text = "";
            L7status.Text = "空閒中";
            L7status.ForeColor = Color.Black;
            //L8
            L8Time.Text = "";
            L8Name.Text = "";
            L8Reason.Text = "";
            L8status.Text = "空閒中";
            L8status.ForeColor = Color.Black;
        }
       
        private void button9_Click(object sender, EventArgs e)
        {
            ChartForm c = new ChartForm();
            c.Show();
        }

        private void L4btnReg_Click_1(object sender, EventArgs e)
        {
            if (L4status.Text == "空閒中")
            {
                Register r = new Register("三樓健身房", this);
                r.Show();
            }
            else
            {
                MessageBox.Show("三樓健身房已被借用");
            }
        }

        private void L1btnReg_Click(object sender, EventArgs e)
        {
            if (L1status.Text == "空閒中")
            {
                Register r = new Register("一樓大廳", this);
                r.Show();
            }
            else
            {
                MessageBox.Show("一樓大廳已被借用");
            }
        }

        private void L2btnReg_Click(object sender, EventArgs e)
        {
            if (L2status.Text == "空閒中")
            {
                Register r = new Register("B1停車場", this);
                r.Show();
            }
            else
            {
                MessageBox.Show("B1停車場已被借用");
            }
        }

        private void L3btnReg_Click(object sender, EventArgs e)
        {
            if (L3status.Text == "空閒中")
            {
                Register r = new Register("一樓交誼廳", this);
                r.Show();
            }
            else
            {
                MessageBox.Show("一樓交誼廳已被借用");
            }
        }

        private void L5btnReg_Click(object sender, EventArgs e)
        {
            if (L5status.Text == "空閒中")
            {
                Register r = new Register("五樓會議室", this);
                r.Show();
            }
            else
            {
                MessageBox.Show("五樓會議室已被借用");
            }
        }

        private void L6btnReg_Click(object sender, EventArgs e)
        {
            if (L6status.Text == "空閒中")
            {
                Register r = new Register("三樓韻律室", this);
                r.Show();
            }
            else
            {
                MessageBox.Show("三樓韻律室已被借用");
            }
        }

        private void L7btnReg_Click(object sender, EventArgs e)
        {
            if (L7status.Text == "空閒中")
            {
                Register r = new Register("屋頂花園", this);
                r.Show();
            }
            else
            {
                MessageBox.Show("屋頂花園已被借用");
            }
        }

        private void L8btnReg_Click(object sender, EventArgs e)
        {
            if (L8status.Text == "空閒中")
            {
                Register r = new Register("中庭花園", this);
                r.Show();
            }
            else
            {
                MessageBox.Show("中庭花園已被借用");
            }
        }
       
        private void L1btnReturn_Click(object sender, EventArgs e)
        {
            //string sqlConnectionString = "server=.\\SQLExpress;database=Space;User ID=desktop-616e58r;Password=;Trusted_Connection=True;";
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["Buliding_Management"].ConnectionString;

            //建立連接
            SqlConnection myConn = new SqlConnection(sqlConnectionString);

            //打開連接
            myConn.Open();

            String strSQL = string.Format(@"Update PublicSpace      
                                            Set EndTime = GetDate() 
                                            Where LocationID = 'L1'
                                            
                                            insert into History
                                            select * from PublicSpace
                                            where LocationID = 'L1'

                                            delete from PublicSpace
                                            where LocationID = 'L1'");  //歸還時間更新，複製資料至History，刪除PublicSpace資料                              

            //建立SQL命令對象
            SqlCommand myCommand = new SqlCommand(strSQL, myConn);

            //得到Data結果集
            SqlDataReader myDataReader = myCommand.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(myDataReader);

            //刷新
            this._Refresh();

            //關閉資料庫連接
            myConn.Close();
            myConn.Dispose();

            //提醒回復預設
            this.L1panel.BackColor = Color.White;
            this.L1panel.Tag = 1;
        }

        private void L2btnReturn_Click(object sender, EventArgs e)
        {
            //string sqlConnectionString = "server=.\\SQLExpress;database=Space;User ID=desktop-616e58r;Password=;Trusted_Connection=True;";
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["Buliding_Management"].ConnectionString;

            //建立連接
            SqlConnection myConn = new SqlConnection(sqlConnectionString);

            //打開連接
            myConn.Open();

            String strSQL = string.Format(@"Update PublicSpace 
                                            Set EndTime = GetDate() 
                                            Where LocationID = 'L2'
                                            
                                            insert into History
                                            select * from PublicSpace
                                            where LocationID = 'L2'

                                            delete from PublicSpace
                                            where LocationID = 'L2'");//歸還時間更新，複製資料至History，刪除PublicSpace資料

            //建立SQL命令對象
            SqlCommand myCommand = new SqlCommand(strSQL, myConn);

            //得到Data結果集
            SqlDataReader myDataReader = myCommand.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(myDataReader);

            //刷新
            this._Refresh();

            //關閉資料庫連結
            myConn.Close();
            myConn.Dispose();

            //提醒回復預設
            this.L2panel.BackColor = Color.White;
            this.L2panel.Tag = 1;
        }

        private void L3btnReturn_Click(object sender, EventArgs e)
        {
            //string sqlConnectionString = "server=.\\SQLExpress;database=Space;User ID=desktop-616e58r;Password=;Trusted_Connection=True;";
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["Buliding_Management"].ConnectionString;

            //建立連接
            SqlConnection myConn = new SqlConnection(sqlConnectionString);

            //打開連接
            myConn.Open();

            String strSQL = string.Format(@"Update PublicSpace 
                                            Set EndTime = GetDate() 
                                            Where LocationID = 'L3'
                                            
                                            insert into History
                                            select * from PublicSpace
                                            where LocationID = 'L3'


                                            delete from PublicSpace
                                            where LocationID = 'L3'");//歸還時間更新，複製資料至History，刪除PublicSpace資料
            //建立SQL命令對象
            SqlCommand myCommand = new SqlCommand(strSQL, myConn);

            //得到Data結果集
            SqlDataReader myDataReader = myCommand.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(myDataReader);

            //刷新
            this._Refresh();

            //關閉資料庫連結
            myConn.Close();
            myConn.Dispose();

            //提醒回復預設
            this.L3panel.BackColor = Color.White;
            this.L3panel.Tag = 1;
        }

        private void L4btnReturn_Click(object sender, EventArgs e)
        {
            //string sqlConnectionString = "server=.\\SQLExpress;database=Space;User ID=desktop-616e58r;Password=;Trusted_Connection=True;";
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["Buliding_Management"].ConnectionString;

            //建立連接
            SqlConnection myConn = new SqlConnection(sqlConnectionString);

            //打開連接
            myConn.Open();

            String strSQL = string.Format(@"Update PublicSpace 
                                            Set EndTime = GetDate() 
                                            Where LocationID = 'L4'
                                            
                                            insert into History
                                            select * from PublicSpace
                                            where LocationID = 'L4'


                                            delete from PublicSpace
                                            where LocationID = 'L4'");//歸還時間更新，複製資料至History，刪除PublicSpace資料

            //建立SQL命令對象
            SqlCommand myCommand = new SqlCommand(strSQL, myConn);

            //得到Data結果集
            SqlDataReader myDataReader = myCommand.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(myDataReader);

            //刷新
            this._Refresh();

            //關閉資料庫連結
            myConn.Close();
            myConn.Dispose();

            //提醒回復預設
            this.L4panel.BackColor = Color.White;
            this.L4panel.Tag = 1;
        }

        private void L5btnReturn_Click(object sender, EventArgs e)
        {
            //string sqlConnectionString = "server=.\\SQLExpress;database=Space;User ID=desktop-616e58r;Password=;Trusted_Connection=True;";
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["Buliding_Management"].ConnectionString;

            //建立連接
            SqlConnection myConn = new SqlConnection(sqlConnectionString);

            //打開連接
            myConn.Open();

            String strSQL = string.Format(@"Update PublicSpace 
                                            Set EndTime = GetDate() 
                                            Where LocationID = 'L5'
                                            
                                            insert into History
                                            select * from PublicSpace
                                            where LocationID = 'L5'


                                            delete from PublicSpace
                                            where LocationID = 'L5'");//歸還時間更新，複製資料至History，刪除PublicSpace資料
            //建立SQL命令對象
            SqlCommand myCommand = new SqlCommand(strSQL, myConn);

            //得到Data結果集
            SqlDataReader myDataReader = myCommand.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(myDataReader);

            //刷新
            this._Refresh();

            //關閉資料庫連結
            myConn.Close();
            myConn.Dispose();

            //提醒回復預設
            this.L5panel.BackColor = Color.White;
            this.L5panel.Tag = 1;
        }

        private void L6btnReturn_Click(object sender, EventArgs e)
        {
            //string sqlConnectionString = "server=.\\SQLExpress;database=Space;User ID=desktop-616e58r;Password=;Trusted_Connection=True;";
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["Buliding_Management"].ConnectionString;

            //建立連接
            SqlConnection myConn = new SqlConnection(sqlConnectionString);

            //打開連接
            myConn.Open();

            String strSQL = string.Format(@"Update PublicSpace 
                                            Set EndTime = GetDate() 
                                            Where LocationID = 'L6'
                                            
                                            insert into History
                                            select * from PublicSpace
                                            where LocationID = 'L6'


                                            delete from PublicSpace
                                            where LocationID = 'L6'");//歸還時間更新，複製資料至History，刪除PublicSpace資料

            //建立SQL命令對象
            SqlCommand myCommand = new SqlCommand(strSQL, myConn);

            //得到Data結果集
            SqlDataReader myDataReader = myCommand.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(myDataReader);

            //刷新
            this._Refresh();

            //關閉資料庫連結
            myConn.Close();
            myConn.Dispose();
            
            //提醒回復預設
            this.L6panel.BackColor = Color.White;
            this.L6panel.Tag = 1;
        }

        private void L7btnReturn_Click(object sender, EventArgs e)
        {
            //string sqlConnectionString = "server=.\\SQLExpress;database=Space;User ID=desktop-616e58r;Password=;Trusted_Connection=True;";
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["Buliding_Management"].ConnectionString;

            //建立連接
            SqlConnection myConn = new SqlConnection(sqlConnectionString);

            //打開連接
            myConn.Open();

            String strSQL = string.Format(@"Update PublicSpace 
                                            Set EndTime = GetDate() 
                                            Where LocationID = 'L7'
                                            
                                            insert into History
                                            select * from PublicSpace
                                            where LocationID = 'L7'


                                            delete from PublicSpace
                                            where LocationID = 'L7'");//歸還時間更新，複製資料至History，刪除PublicSpace資料
            //建立SQL命令對象
            SqlCommand myCommand = new SqlCommand(strSQL, myConn);

            //得到Data結果集
            SqlDataReader myDataReader = myCommand.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(myDataReader);

            //刷新
            this._Refresh();
            
            //關閉資料庫連結
            myConn.Close();
            myConn.Dispose();
            
            //提醒回復預設
            this.L7panel.BackColor = Color.White;
            this.L7panel.Tag = 1;
        }

        private void L8btnReturn_Click(object sender, EventArgs e)
        {
            //string sqlConnectionString = "server=.\\SQLExpress;database=Space;User ID=desktop-616e58r;Password=;Trusted_Connection=True;";
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["Buliding_Management"].ConnectionString;

            //建立連接
            SqlConnection myConn = new SqlConnection(sqlConnectionString);

            //打開連接
            myConn.Open();

            String strSQL = string.Format(@"Update PublicSpace 
                                            Set EndTime = GetDate() 
                                            Where LocationID = 'L8'
                                            
                                            insert into History
                                            select * from PublicSpace
                                            where LocationID = 'L8'


                                            delete from PublicSpace
                                            where LocationID = 'L8'");//歸還時間更新，複製資料至History，刪除PublicSpace資料

            //建立SQL命令對象
            SqlCommand myCommand = new SqlCommand(strSQL, myConn);

            //得到Data結果集
            SqlDataReader myDataReader = myCommand.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(myDataReader);
            
            //刷新
            this._Refresh();
            
            //關閉資料庫連接
            myConn.Close();
            myConn.Dispose();
            
            //提醒回復預設
            this.L8panel.BackColor = Color.White;
            this.L8panel.Tag = 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //string sqlConnectionString = "server=.\\SQLExpress;database=Space;User ID=desktop-616e58r;Password=;Trusted_Connection=True;";
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["Buliding_Management"].ConnectionString;

            //建立連接
            SqlConnection myConn = new SqlConnection(sqlConnectionString);

            //打開連接
            myConn.Open();

            String strSQL = string.Format(@"Select * From PublicSpace 
                                            Where EndTime >= GetDate()");

            //建立SQL命令對象
            SqlCommand myCommand = new SqlCommand(strSQL, myConn);

            //得到Data結果集
            SqlDataReader myDataReader = myCommand.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(myDataReader);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    switch (dr["LocationID"].ToString())
                    {
                        case"L1":
                            if(int.Parse(L1panel.Tag.ToString()) == 1)
                            {
                                L1panel.BackColor = Color.Red;
                                L1panel.Tag = 0;
                            }
                            else
                            {
                                L1panel.BackColor = Color.White;
                                L1panel.Tag = 1;
                            }
                            break;
                        case "L2":
                            if (int.Parse(L2panel.Tag.ToString()) == 1)
                            {
                                L2panel.BackColor = Color.Red;
                                L2panel.Tag = 0;
                            }
                            else
                            {
                                L1panel.BackColor = Color.White;
                                L1panel.Tag = 1;
                            }
                            break;
                        case "L3":
                            if (int.Parse(L3panel.Tag.ToString()) == 1)
                            {
                                L3panel.BackColor = Color.Red;
                                L3panel.Tag = 0;
                            }
                            else
                            {
                                L3panel.BackColor = Color.White;
                                L3panel.Tag = 1;
                            }
                            break;
                        case "L4":
                            if (int.Parse(L4panel.Tag.ToString()) == 1)
                            {
                                L4panel.BackColor = Color.Red;
                                L4panel.Tag = 0;
                            }
                            else
                            {
                                L4panel.BackColor = Color.White;
                                L4panel.Tag = 1;
                            }
                            break;
                        case "L5":
                            if (int.Parse(L5panel.Tag.ToString()) == 1)
                            {
                                L5panel.BackColor = Color.Red;
                                L5panel.Tag = 0;
                            }
                            else
                            {
                                L5panel.BackColor = Color.White;
                                L5panel.Tag = 1;
                            }
                            break;
                        case "L6":
                            if (int.Parse(L6panel.Tag.ToString()) == 1)
                            {
                                L6panel.BackColor = Color.Red;
                                L6panel.Tag = 0;
                            }
                            else
                            {
                                L6panel.BackColor = Color.White;
                                L6panel.Tag = 1;
                            }
                            break;
                        case "L7":
                            if (int.Parse(L7panel.Tag.ToString()) == 1)
                            {
                                L7panel.BackColor = Color.Red;
                                L7panel.Tag = 0;
                            }
                            else
                            {
                                L7panel.BackColor = Color.White;
                                L7panel.Tag = 1;
                            }
                            break;
                        case "L8":
                            if (int.Parse(L8panel.Tag.ToString()) == 1)
                            {
                                L8panel.BackColor = Color.Red;
                                L8panel.Tag = 0;
                            }
                            else
                            {
                                L8panel.BackColor = Color.White;
                                L8panel.Tag = 1;
                            }
                            break;
                    }
                }
            }

            myConn.Close();
            myConn.Dispose();
        }
    }
}

