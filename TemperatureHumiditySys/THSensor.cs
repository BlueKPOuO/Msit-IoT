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
using global::uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using System.Net.Sockets;
using System.Net;

namespace TemperatureHumiditySys
{
    public partial class THSensor : FrmLogo3
    {
        public THSensor()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Buliding_ManagementEntities db = new Buliding_ManagementEntities();
            cbSensorID.DataSource = db.HumiTemperSenser.Select(p => p.SensorID).ToList();
            
        }
        
        private MqttClient client;
        public string brokerHostname = "192.168.8.101";
        public int brokerPort = 1883;
        public string userName = "";
        public string password = "";
        
        static string subTopic = "home_dht";//全訂閱# 溫濕度home_dht 聲納距離US_01 瓦斯MQ5_01 //Alarm_01 relay topic
        static string subTopic2 = "MQ5_01";

        private void btnSearch_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void btTSave_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("確定要修改?", "是否儲存資料", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                Buliding_ManagementEntities db = new Buliding_ManagementEntities();
                var q = from a in db.HumiTemperSenser
                        where a.SensorID == subTopic
                        select a;
                q.First().Frequency = Convert.ToDouble(tbFrequency.Text);
                
                db.SaveChanges();
                MessageBox.Show("儲存成功");
                GetDataTime.Interval = Convert.ToInt32(tbFrequency.Text) * 1000 * 60;
            }
        }

        private void cbSensorID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSensorID.SelectedItem == null || cbSensorID.SelectedItem.ToString() == "") return;
            /*try
            {
                client.Disconnect();
            }
            catch { }*/
            Buliding_ManagementEntities db = new Buliding_ManagementEntities();
            var qq = from a in db.HTDataTable
                     where a.SensorID == subTopic
                     select new
                     {
                         a.SensorID,
                         a.Time,
                         a.Temperature,
                         a.Humidity
                     };
            dgvHTData.DataSource = qq.ToList();
            var fre = db.HumiTemperSenser.Where(n => n.SensorID == subTopic).First().Frequency;
            tbFrequency.Text = fre.ToString();
            

        }
        
        void Client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            string msg = Encoding.UTF8.GetString(e.Message);
            if (msg != null && msg != "")
            {
                try
                {
                    tbTemp.Text = msg.Substring(15, 5);
                    tbHum.Text = msg.Substring(32, 5);
                }
                catch
                {

                }
            }
            /*if (old_hum != null && old_hum != "" && old_temp != null && old_temp != "") 
            { 
                if (Convert.ToDouble(old_temp) > 80 && Convert.ToDouble(tbTemp.Text) > 80)
                {
                    Iot_Alert();
                }
            }*/
        }
        /*
        private void Iot_Alert()
        {
            MessageBox.Show($"{subTopic}疑似發生火災!該處連續出現多筆高溫數據!!");
        }
        */
        static bool Check(string IPStr, int Port, int Timeout)
        {
            bool success = false;
            try
            {
                using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
                    success = socket.BeginConnect(IPAddress.Parse(IPStr), Port, null, null).AsyncWaitHandle.WaitOne(Timeout, true);
            }
            catch { }
            return success;
        }
        
        string error = "No Error";

        private void Connect()
        {
            string clientId = Guid.NewGuid().ToString();

            try
            {
                //client.Connect(clientId, userName, password);
                Random random = new Random();
                int rand = random.Next(0, 100000);
                client.Connect("iot" + rand);

            }
            catch (Exception e)
            {
                error = "Connection error: " + e.ToString();
            }
        }
        
        private void GetDataTime_Tick(object sender, EventArgs e)
        {
            Buliding_ManagementEntities db = new Buliding_ManagementEntities();

            var q = from a in db.HTDataTable
                    select new
                    {
                        a.SensorID,
                        a.Time,
                        a.Temperature,
                        a.Humidity
                    };
            dgvHTData.DataSource = q.ToList();
        }
        
        private void THSensor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(client!=null)
                client.Disconnect();
        }
        
        async private void btn_AlertTest_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 3; i++)
            {//溫度待填回傳字串進去
                await Task.Run(()=> Publish("home_dht", "{\"temperature\":95.00,\"humidity\":00.00}", 2));
            }
        }
        
        private void Publish(string _topic, string msg, int Qos)
        {
            switch (Qos)
            {
                case 0:
                    client.Publish(_topic, Encoding.UTF8.GetBytes(msg), MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE, true);
                    break;
                case 1:
                    client.Publish(_topic, Encoding.UTF8.GetBytes(msg), MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE, true);
                    break;
                case 2:
                    client.Publish(_topic, Encoding.UTF8.GetBytes(msg), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
                    break;
            }

        }

        private void btnNewSensor_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定要新增資料?", "是否新增", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                if (tbName.Text == "" || tbLocation.Text == "" || tbVendor.Text == "" || tbSearchFrequency.Text == ""|| !double.TryParse(tbSearchFrequency.Text,out double fre))
                {
                    MessageBox.Show("有格子還沒填完!");
                    return;
                }
                Buliding_ManagementEntities db = new Buliding_ManagementEntities();
                HumiTemperSenser hts = new HumiTemperSenser();
                hts.SensorID = tbName.Text;
                hts.Place = tbLocation.Text;
                hts.Vendor = tbVendor.Text;
                hts.Status = chbStatus.Checked;
                hts.Frequency = fre;
                hts.CategoryID = "HT";
                db.HumiTemperSenser.Add(hts);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("請確認是否有重複,或者資料是否填寫完整 \r\n" + ex.Message);
                }
                MessageBox.Show("儲存完成!");
                Refresh_Method();

            }
        }

        private void btnDeleteSensor_Click(object sender, EventArgs e)
        {
            Buliding_ManagementEntities db = new Buliding_ManagementEntities();
            /*
            var qq = from a in db.HumiTemperSenser.AsEnumerable()
                     select a;
            var q = qq.Skip(dgvSensorList.CurrentCell.RowIndex).First();*/
            var q = db.HumiTemperSenser.AsEnumerable().Skip(dgvSensorList.CurrentCell.RowIndex).First();
            HumiTemperSenser h = new HumiTemperSenser();
            h = q;
            if(MessageBox.Show($"確定要刪除感應器{h.SensorID}資料?", "是否刪除", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    db.HumiTemperSenser.Remove(h);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("資料刪除失敗 \r\n" + ex.Message);
                    return;
                }
                MessageBox.Show("資料已刪除");
                Refresh_Method();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Refresh_Method();
        }

        private void Refresh_Method()
        {
            Buliding_ManagementEntities db = new Buliding_ManagementEntities();
            var q = from a in db.HumiTemperSenser
                    select a;
            dgvSensorList.DataSource = q.ToList(); 
            cbSensorID.DataSource = null;
            cbSensorID.DataSource = db.HumiTemperSenser.Select(p => p.SensorID).ToList();
        }

        private void THSensor_Load(object sender, EventArgs e)
        {
            Refresh_Method();

            if (brokerHostname != null && userName != null && password != null)
            {
                Connect();
                client = new MqttClient(brokerHostname);
                if (Check(brokerHostname, brokerPort, 1000))
                {
                    if (brokerHostname != null && userName != null && password != null)
                    {
                        Connect();
                        client.MqttMsgPublishReceived += Client_MqttMsgPublishReceived;
                        byte[] qosLevels = { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE };
                        client.Subscribe(new string[] { subTopic }, qosLevels);
                    }
                }
                else
                {
                    MessageBox.Show("連接不到IoT系統,請確認連線後再嘗試");
                    return;
                }
            }
        }
    }
}
