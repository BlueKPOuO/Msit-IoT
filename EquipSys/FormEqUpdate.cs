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
    public partial class FormEqUpdate : FrmLogo3
    {
        public FormEqUpdate()
        {
            InitializeComponent();
            this.Title = "修改設備";
        }
        Buliding_ManagementEntitiesEq dbContext = new Buliding_ManagementEntitiesEq();

        private void button1_Click(object sender, EventArgs e)
        {
            var q = dbContext.Equipments.AsEnumerable()
                                         .Where(eq => eq.EquipmentID == int.Parse(this.textBox6.Text));
            var updateEq = q.First();
            updateEq.EquipmentName = textBox1.Text;
            updateEq.Place = textBox2.Text;
            updateEq.Vendor = textBox3.Text;
            updateEq.Status = textBox4.Text;
            updateEq.Buydate = dateTimePicker1.Value;
            updateEq.UseYear = int.Parse(textBox5.Text) ;
            dbContext.SaveChanges();
            MessageBox.Show("修改完成");
        }

        private void Formupdate_Load(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
