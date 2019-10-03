using FormLogoClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipSys
{
    public partial class FormFixMain : FrmLogo3
    {
        public FormFixMain()
        {
            InitializeComponent();
            this.Title = "維修情形";
        }
        Buliding_ManagementEntitiesEq dbContext = new Buliding_ManagementEntitiesEq();
        void loadfixdata()
        {
            this.dataGridView1.DataSource = null;
            var q = from fi in dbContext.EquipFixes
                    join eq in dbContext.Equipments
                   on fi.EquipmentID equals eq.EquipmentID
                    select new
                    {
                        維修編號 = fi.EquipmentFixID,
                        設備編號 = fi.EquipmentID,
                        設備名稱 = eq.EquipmentName,
                        報修日期 = fi.ReportDate,
                        維修日期 = fi.RepairedDate,
                        維修完成 = fi.Repaired,
                        報修原因 = fi.Reason
                    };
            this.dataGridView1.DataSource = q.ToList();
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadall();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = null;
            var q = from fi in dbContext.EquipFixes
                    where fi.Repaired == false
                    join eq in dbContext.Equipments
                   on fi.EquipmentID equals eq.EquipmentID
                    select new
                    {
                        維修編號 = fi.EquipmentFixID,
                        設備編號 = fi.EquipmentID,
                        設備名稱 = eq.EquipmentName,
                        報修日期 = fi.ReportDate,
                        維修日期 = fi.RepairedDate,
                        維修完成 = fi.Repaired,
                        報修原因 = fi.Reason
                    };
            this.dataGridView1.DataSource = q.ToList();
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = null;
            var q = from fi in dbContext.EquipFixes
                    where fi.Repaired == true
                    join eq in dbContext.Equipments
                   on fi.EquipmentID equals eq.EquipmentID
                    select new
                    {
                        維修編號 = fi.EquipmentFixID,
                        設備編號 = fi.EquipmentID,
                        設備名稱 = eq.EquipmentName,
                        報修日期 = fi.ReportDate,
                        維修日期 = fi.RepairedDate,
                        維修完成 = fi.Repaired,
                        報修原因 = fi.Reason
                    };
            this.dataGridView1.DataSource = q.ToList();
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (this.dataGridView1.CurrentCell.ColumnIndex == 1)
            {

                var q2 = dbContext.EquipFixes.AsEnumerable()
                                         .Where(eq => eq.EquipmentID == int.Parse(this.dataGridView1.CurrentCell.Value.ToString()));
                var fixEq = q2.First();
                fixEq.Repaired = true;
                dbContext.SaveChanges();

                var q3 = dbContext.Equipments.AsEnumerable()
                                         .Where(eq => eq.EquipmentID == int.Parse(this.dataGridView1.CurrentCell.Value.ToString()));

                var Eqst = q3.First();
                Eqst.Status = "正常";
                dbContext.SaveChanges();


                this.dataGridView1.DataSource = null;
                var q = from fi in dbContext.EquipFixes
                        where fi.Repaired == true
                        join eq in dbContext.Equipments
                  on fi.EquipmentID equals eq.EquipmentID
                        select new
                        {
                            維修編號 = fi.EquipmentFixID,
                            設備編號 = fi.EquipmentID,
                            設備名稱 = eq.EquipmentName,
                            報修日期 = fi.ReportDate,
                            維修日期 = fi.RepairedDate,
                            維修完成 = fi.Repaired,
                            報修原因 = fi.Reason
                        };
                this.dataGridView1.DataSource = q.ToList();
                //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

                MessageBox.Show("確認維修完成");
            }
            else
                MessageBox.Show("請選擇物品編號");
        }

        private void FormFixMain_Load(object sender, EventArgs e)
        {
            loadall();
        }
        void loadall()
        {
            this.dataGridView1.DataSource = null;
            var q = from fi in dbContext.EquipFixes
                    join eq in dbContext.Equipments
                    on fi.EquipmentID equals eq.EquipmentID
                    orderby fi.ReportDate descending
                    select new
                    {
                        維修編號 = fi.EquipmentFixID,
                        設備編號 = fi.EquipmentID,
                        設備名稱 = eq.EquipmentName,
                        報修日期 = fi.ReportDate,
                        維修日期 = fi.RepairedDate,
                        維修完成 = fi.Repaired,
                        報修原因 = fi.Reason
                    };
            this.dataGridView1.DataSource = q.ToList();
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
    }
}
