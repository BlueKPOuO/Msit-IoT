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
using TemperatureHumiditySys;

namespace DisasterPreventionSys
{
    public partial class DPSys : FrmLogo3
    {
        public DPSys()
        {
            InitializeComponent();
        }

        private void btnHT_Click(object sender, EventArgs e)
        {
            THSensor ths = new THSensor();
            ths.UserName = UserName;
            ths.Show();
        }
    }
}
