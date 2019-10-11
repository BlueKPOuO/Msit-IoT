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

        }

        private void cbSensorID_SelectedIndexChanged(object sender, EventArgs e)
        {
            subTopic = Convert.ToString(cbSensorID.SelectedItem);

        }
    }
}
