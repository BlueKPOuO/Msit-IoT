using FormLogoClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipSys
{
    public partial class FormEqAll : FrmLogo3
    {
        public FormEqAll()
        {
            InitializeComponent();
            this.Title = "設備詳細資料";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Buliding_ManagementEntitiesEq dbContext = new Buliding_ManagementEntitiesEq();

        private void FormEqAll_Load(object sender, EventArgs e)
        {
            var q = dbContext.Equipments.AsEnumerable()
                                        .Where(eq => eq.EquipmentID == int.Parse(this.textBox6.Text));

            var updateEq = q.First();
            textBox1.Text = updateEq.EquipmentName;
            textBox2.Text = updateEq.Place;
            textBox3.Text = updateEq.Vendor;
            textBox4.Text = updateEq.Status;
            dateTimePicker1.Value = updateEq.Buydate;
            textBox5.Text = updateEq.UseYear.ToString();
        }
    }
}
