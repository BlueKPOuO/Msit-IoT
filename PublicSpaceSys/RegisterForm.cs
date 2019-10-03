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
    public partial class Register : FrmLogo3
    {

        string _LOCATION;
        PublicSpace _P;
        public Register(string LOCATION, PublicSpace p)
        {
            InitializeComponent();
            _P = p;
            _LOCATION = LOCATION;
            cbLocation.SelectedItem = _LOCATION;
            
        }

        //string sqlConnectionString = ConfigurationManager.ConnectionStrings["Space"].ConnectionString;
        private void button1_Click(object sender, EventArgs e)
        {
            int seq = 0;
            int ResidentID = 1;
            string StaffID = "P01";
            string BarrierName = this.txtName.Text;
            string Location = "";
            switch (_LOCATION) //默認Location
            {
                case "一樓大廳":
                    Location = "L1";
                    break;
                case "B1停車場":
                    Location = "L2";
                    break;
                case "一樓交誼廳":
                    Location = "L3";
                    break;
                case "三樓健身房":
                    Location = "L4";
                    break;
                case "五樓會議室":
                    Location = "L5";
                    break;
                case "三樓韻律室":
                    Location = "L6";
                    break;
                case "屋頂花園":
                    Location = "L7";
                    break;
                case "中庭花園":
                    Location = "L8";
                    break;
            }

           

            string Reason = txtReason.Text;

            if (this.txtName.Text=="") //借用人姓名不可為空
            {
                MessageBox.Show("請輸入借用人姓名", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtName.Focus();
            }
            else
            {
                try
                {
                    DateTime StartTime = dtpTime1.Value;

                    //dtpTime2.Value = new DateTime(this.dtpTime2.Value.Year, this.dtpTime2.Value.Month, this.dtpTime2.Value.Day, this.dtpTime2.Value.Hour +2, 59, 59);
                    DateTime EndTime = new DateTime(this.dtpTime1.Value.Year,
                                                    this.dtpTime1.Value.Month,
                                                    this.dtpTime1.Value.Day,
                                                    this.dtpTime1.Value.Hour + int.Parse(comboBox1.SelectedItem.ToString()),
                                                    this.dtpTime1.Value.Minute,
                                                    this.dtpTime1.Value.Second);
                    //string sqlConnectionString = "server=.\\SQLExpress;database=Space;User ID=desktop-616e58r;Password=;Trusted_Connection=True;";
                    string sqlConnectionString = ConfigurationManager.ConnectionStrings["Buliding_Management"].ConnectionString;

                    //建立連接
                    SqlConnection myConn = new SqlConnection(sqlConnectionString);

                    //打開連接
                    myConn.Open();

                    String strSQL = @"select max(seq) AS MAX from PublicSpace";

                    //建立SQL命令對象
                    SqlCommand myCommand = new SqlCommand(strSQL, myConn);

                    //得到Data結果集
                    SqlDataReader myDataReader = myCommand.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(myDataReader);

                    if (dt.Rows.Count > 0)
                    {
                        seq = dt.Rows[0]["MAX"].ToString() == "" ? 0 : int.Parse(dt.Rows[0]["MAX"].ToString()) + 1;
                    }

                    string sql2 = @"INSERT INTO PublicSpace(ResidentID,seq, StaffID , BarrierName, LocationID, StartTime, EndTime, Reason)
                            values(@ResidentID,@seq, @StaffID, @BarrierName, @LocationID, @StartTime, @EndTime, @Reason)";

                    using (SqlCommand cmd = new SqlCommand(sql2, myConn))
                    {
                        cmd.Parameters.AddWithValue("@ResidentID", ResidentID);
                        cmd.Parameters.AddWithValue("@seq", seq.ToString());
                        cmd.Parameters.AddWithValue("@StaffID", StaffID);
                        cmd.Parameters.AddWithValue("@BarrierName", txtName.Text);
                        cmd.Parameters.AddWithValue("@LocationID", Location);
                        cmd.Parameters.AddWithValue("@StartTime", StartTime);
                        cmd.Parameters.AddWithValue("@EndTime", EndTime);
                        cmd.Parameters.AddWithValue("@Reason", txtReason.Text);
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                        myConn.Close();
                    }
                    MessageBox.Show("借用" + _LOCATION + "成功");

                    _P._Refresh();


                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("請輸入借用時數","錯誤",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    this.comboBox1.Focus();
                }
            }
            

           
                


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
