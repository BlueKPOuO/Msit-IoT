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
using EntityLibrary;

namespace ControlLibrary
{
    public partial class IoTGetData : UserControl
    {
        public bool IsDesignerHosted
        {
            get
            {
                Control ctrl = this;
                while (((ctrl == null) == false))
                {
                    if ((((ctrl.Site) == null) == false) && ctrl.Site.DesignMode)
                    {
                        return true;
                    }
                    ctrl = ctrl.Parent;
                }
                return false;
            }
        }
        public IoTGetData()
        {
            if (true)
            {
                InitializeComponent();
            }
        }

        private MqttClient client;
        public string brokerHostname { get; set; } = "192.168.8.101";
        public int brokerPort { get; set; } = 1883;
        public string userName { get; set; } = "";
        public string password { get; set; } = "";
        /*
        public enum topic
        {
            [Description("home_dht")] HT,
            [Description("US_01")] Distance ,
            [Description("MQ5_01")] Gas,
            [Description("#")] all
        }
        */
        public string subTopic { get; set; } = "#";
        //public string subTopic = "home_dht";//全訂閱# 溫濕度home_dht 聲納距離US_01 瓦斯MQ5_01 //Alarm_01 relay topic

        public static string temp { get; set; } = "";
        public static string hum { get; set; } = "";
        public static string gas { get; set; } = "";
        public static string distance { get; set; } = "";

        void Client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            string old_temp = temp;
            string old_hum = hum;
            string msg = Encoding.UTF8.GetString(e.Message);
            if (msg != null && msg != "")
            {
                try
                {
                    if (msg.IndexOf("temperature") > 0)
                    {
                        temp = msg.Substring(15, 5);
                        hum = msg.Substring(32, 5);
                        temp_IoTAlert();
                    }
                    else if (msg.IndexOf("Gas Value") > 0)
                    {
                        gas = msg.Substring(13, 4);
                        gas = gas.Trim();
                        Gas_IoTAlert();
                    }
                    else if (msg.IndexOf("Distance") > 0)
                    {
                        distance = msg.Substring(12, 4);
                        distance = distance.Trim();
                    }
                }
                catch
                {

                }
            }
        }
        
        List<float> tempList = new List<float>();
        private void temp_IoTAlert()
        {
            tempList.Add(float.Parse(temp));
            if (tempList.Count > 3)
            {
                tempList.RemoveAt(0);
                for (int i = 0; i < tempList.Count; i++)
                {
                    if (tempList[i] > 80)
                        continue;
                    else
                        return;
                }
            }
            else return;
            Buliding_ManagementEntities db = new Buliding_ManagementEntities();
            IoTAlert a = new IoTAlert
            {
                Place = "2F",
                Alert = true,
                PS = "temp溫度",
                Time = DateTime.Now
            };
            db.IoTAlert.Add(a);
            db.SaveChanges();
        }

        List<int> GasList = new List<int>();
        private void Gas_IoTAlert()
        {
            GasList.Add(int.Parse(gas));
            if (GasList.Count > 3)
            {
                GasList.RemoveAt(0);
                for (int i = 0; i < GasList.Count; i++)
                {
                    if (GasList[i] > 5000)
                        continue;
                    else
                        return;
                }
            }
            else return;
            Buliding_ManagementEntities db = new Buliding_ManagementEntities();
            IoTAlert a = new IoTAlert
            {
                Place = "2F",
                Alert = true,
                PS = "Gas瓦斯",
                Time = DateTime.Now
            };
            db.IoTAlert.Add(a);
            db.SaveChanges();
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
                        client.Subscribe(new string[] { subTopic }, qosLevels);
                    }
                }
                else
                {
                    MessageBox.Show("連接不到IoT系統,請確認連線");
                    return;
                }
            }
            
            Buliding_ManagementEntities db = new Buliding_ManagementEntities();
            var q = from a in db.AllSensorTable.AsEnumerable()
                    select new { a.SensorID,a.Frequency,a.CategoryID };
            for(int i = 0; i < q.Count(); i++)
            {
                Timer a = new Timer();
                a.Enabled = true;
                a.Interval = Convert.ToInt32((q.Skip(i).First().Frequency * 1000 * 60).ToString());
                a.Tag = q.Skip(i).First().SensorID;
                switch (q.Skip(i).First().CategoryID)
                {
                    case "HT":
                        a.Tick += HTDataToDB;
                        break;
                    case "G":
                        a.Tick += GasDataToDB;
                        break;
                    case "DS":
                        a.Tick += DistanceToDB;
                        break;
                }
            }
        }

        private void DistanceToDB(object sender, EventArgs e)
        {
            Buliding_ManagementEntities db = new Buliding_ManagementEntities();
            string now = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff");
            DistanceData z = new DistanceData
            {
                SensorID = ((Timer)sender).Tag.ToString(),
                Time = Convert.ToDateTime(now),
                Distance = int.Parse(distance)
            };
            db.DistanceData.Add(z);
            db.SaveChanges();
        }

        private void GasDataToDB(object sender, EventArgs e)
        {
            Buliding_ManagementEntities db = new Buliding_ManagementEntities();
            string now = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff");
            GasSenserData y = new GasSenserData
            {
                SensorID = ((Timer)sender).Tag.ToString(),
                Time = Convert.ToDateTime(now),
                Gasvalue = double.Parse(gas)
            };
            db.GasSenserData.Add(y);
            db.SaveChanges();
        }

        private void HTDataToDB(object sender, EventArgs e)
        {
            Buliding_ManagementEntities db = new Buliding_ManagementEntities();
            string now = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff");
            HTDataTable x = new HTDataTable
            {
                SensorID = ((Timer)sender).Tag.ToString(),
                Time = Convert.ToDateTime(now),
                Temperature = Convert.ToDouble(temp),
                Humidity = Convert.ToDouble(hum)
            };
            db.HTDataTable.Add(x);
            db.SaveChanges();
        }

        public string GetDescription(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());
            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : value.ToString();
        }

        private void IoTGetData_Leave(object sender, EventArgs e)
        {
            if (client != null)
                client.Disconnect();
        }
        /*
        private void timer_Tick(object sender, EventArgs e)
        {
           Buliding_ManagementEntities db = new Buliding_ManagementEntities();
           string now = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff");
           HTDataTable x = new HTDataTable
           {
               SensorID = "home_dht",
               Time = Convert.ToDateTime(now),
               Temperature = Convert.ToDouble(temp),
               Humidity = Convert.ToDouble(hum)
           };
           GasSenserData y = new GasSenserData
           {
               SensorID = "MQ5_01",
               Time = Convert.ToDateTime(now),
               Gasvalue = double.Parse(gas)
           };
           DistanceData z = new DistanceData
           {
               SensorID = "",
               Time = Convert.ToDateTime(now),
               Distance = int.Parse(distance)
           };
        }*/
    }
}
