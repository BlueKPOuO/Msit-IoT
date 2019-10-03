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
using StaffSystem;
using global::PublicSpacesys;
using BulletinBoard;

namespace GeneralAffairsSystem
{
    public partial class GASys : FrmLogo3
    {
        public GASys()
        {
            InitializeComponent();
            Title = "大樓管理系統\r\n庶務";
            //for(int i =0;i<tabControl1.TabCount;i++)
            //{
            //    tabControl1.TabPages[i].BackColor = FC4;
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StaffSys s = new StaffSys();
            s.UserName = UserName;
            s.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            PublicSpace ps = new PublicSpace();
            ps.UserName = UserName;
            ps.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmboard fb = new frmboard();
            fb.UserName = UserName;
            fb.Show();
        }

        private void GASys_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
