using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using global::uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using System.Net.Sockets;
using System.Net;
using System.Reflection;

namespace ControlLibrary
{
    public partial class IoTGetData : UserControl
    {
        public IoTGetData()
        {
            InitializeComponent();
        }

        private MqttClient client;
        public string brokerHostname { get; set; } = "192.168.8.101";
        public int brokerPort { get; set; } = 1883;
        public string userName { get; set; } = "";
        public string password { get; set; } = "";
        string all = "#";
        public enum topic
        {
          [Description("home_dht")] HT,
          [Description("US_01")] Distance ,
          [Description("MQ5_01")] Gas,
          [Description("#")] all
        }
        public topic subTopic { get; set; } = topic.HT;
        //public string subTopic = "home_dht";//全訂閱# 溫濕度home_dht 聲納距離US_01 瓦斯MQ5_01 //Alarm_01 relay topic

        string temp = "";
        string hum = "";

        void Client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            switch (subTopic)
            {
                default:
                    break;
            }
            string old_temp = temp;
            string old_hum = hum;

            string msg = Encoding.UTF8.GetString(e.Message);
            if (msg != null && msg != "")
            {
                temp = msg.Substring(15, 5);
                hum = msg.Substring(32, 5);
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

        private void IoTGetData_Load(object sender, EventArgs e)
        {
            try
            {
                client.Disconnect();
            }
            catch { }
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
                        client.Subscribe(new string[] { GetDescription(subTopic) }, qosLevels);
                    }
                }
                else
                {
                    MessageBox.Show("連接不到IoT系統,請確認連線後再嘗試");
                    return;
                }
            }
        }

        public string GetDescription(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());
            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : value.ToString();
        }
    }
}
