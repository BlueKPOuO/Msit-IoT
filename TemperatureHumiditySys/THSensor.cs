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

        private MqttClient client;
        public string brokerHostname = "192.168.8.101";
        public int brokerPort = 1883;
        public string userName = "";
        public string password = "";

        static string subTopic = "";//全訂閱# 溫濕度home_dht 聲納距離US_01 瓦斯MQ5_01 //Alarm_01 relay topic
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
            try
            {
                client.Disconnect();
            }
            catch { }
            subTopic = Convert.ToString(cbSensorID.SelectedItem); 
            if (brokerHostname != null && userName != null && password != null)
            {
                Connect(); client = new MqttClient(brokerHostname);
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
                Buliding_ManagementEntities db = new Buliding_ManagementEntities();
                var q = from a in db.HumiTemperSenser
                        where a.SensorID == subTopic
                        select a.Frequency;
                tbFrequency.Text = q.First().ToString();
                GetDataTime.Interval = Convert.ToInt32(tbFrequency.Text) * 1000 * 60;
            }

        }

        void Client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            string msg = Encoding.UTF8.GetString(e.Message);
            if (msg != null && msg != "")
            {
                tbTemp.Text = msg.Substring(15, 5);
                tbHum.Text = msg.Substring(32, 5);
            }

        }

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
            string now = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff");
            HTDataTable x = new HTDataTable
            {
                SensorID = subTopic,
                Time = Convert.ToDateTime(now),
                Temperature = Convert.ToDouble(tbTemp.Text),
                Humidity = Convert.ToDouble(tbHum.Text)
            };
            db.HTDataTable.Add(x);
            db.SaveChanges();

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
            client.Disconnect();
        }
    }
}
