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
using global::EntityLibrary;

namespace PackageSys
{
    public partial class FrmPackageSys : FrmLogo3
    {
        public FrmPackageSys()
        {
            InitializeComponent();
            button2.BackColor = FC2;
            button3.BackColor = FC2;
            button4.BackColor = FC2;
            button5.BackColor = FC2;
            for(int i=0;i<tabControl1.TabPages.Count;i++)
            {
                tabControl1.TabPages[i].BackColor = Color.White;
            }

            //comboBox導入資料
            Buliding_ManagementEntities shi = new Buliding_ManagementEntities();
            this.comboBox3.DataSource = shi.PackageCompany.Select(p => p.CompanyName).ToList();
            this.comboBox4.DataSource = shi.ResidentDataTable.Select(n => n.ResidentName).ToList();
            this.comboBox10.DataSource = shi.PackageCompany.Select(p => p.CompanyName).ToList();
            this.comboBox9.DataSource = shi.ResidentDataTable.Select(n => n.ResidentName).ToList();
            Title = "社區管理系統\r\n包裹管理";
            this.comboBox11.DataSource = shi.ResidentDataTable.Select(p => p.ResidentName).ToList();
            this.comboBox14.DataSource = shi.ResidentDataTable.Select(p => p.ResidentName).ToList();
            this.comboBox1.DataSource = shi.StaffDataTable.Where(s=>s.OnWork==true).Select(f => f.StaffName).ToList();
            this.comboBox2.DataSource = shi.StaffDataTable.Where(s => s.OnWork == true).Select(f => f.StaffName).ToList();
        }
         
        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //導入資料庫資料(只顯示住戶未領包裹)

            Buliding_ManagementEntities shi = new Buliding_ManagementEntities();
            tabControl1.SelectedIndex = 1;
            var q = shi.PackageTable.Where(r => r.Sign == false).Select(emp => new
            {
                收貨編號 = emp.PackageID,
                收件日期 = emp.PackageArrivalDate,
                貨運公司 = emp.PackageCompanyID,
                收件人ID = emp.ReceiverID.ToString(),                
                簽收 = emp.Sign.Value,
                警衛 = emp.StaffID
            });
            //var q = from a in shi.PackageTable
            //        where a.Sign == false
            //        select a;
            this.dataGridView1.DataSource = q.ToList();

        }
        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //導入資料庫資料(只顯示運貨未收走的退件)

            Buliding_ManagementEntities shi = new Buliding_ManagementEntities();
            tabControl1.SelectedIndex = 3;            
            var q = shi.ReturnPackage.Where(r => r.Sign == false ).Select(emp => new
            {
                退貨編號 = emp.ReturnDataID,
                收件日期 = emp.ReturnArrivalDate,
                貨運公司 = emp.ReturnCompanyID,
                退件人ID = emp.ReturneeID.ToString(),                
                簽收 = emp.Sign.Value,
                警衛 = emp.StaffID
            });
            this.dataGridView2.DataSource = q.ToList();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {   
            //收件人、ＩＤ、電話-作連動
            Buliding_ManagementEntities shi = new Buliding_ManagementEntities();
            var q = shi.ResidentDataTable.Where(n => n.ResidentName == comboBox4.Text).First();
            this.comboBox5.Text = q.ResidentID.ToString();
            this.comboBox6.Text = q.CommunityAddress;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //新增收件資料-並顯示更新後的資料表

            Buliding_ManagementEntities shi = new Buliding_ManagementEntities();
            var q = shi.PackageCompany.Where(w => w.CompanyName == this.comboBox3.Text).First().PackageCompanyID;
            var q1 = shi.StaffDataTable.Where(s=>s.StaffName == this.comboBox1.Text).First().StaffID;
            PackageTable x = new PackageTable
            {
                PackageArrivalDate = this.dateTimePicker1.Value,
                PackageCompanyID = q,
                Receiver = this.comboBox4.Text,
                ReceiverID = int.Parse(this.comboBox5.Text),
                StaffID = q1,
                Sign = false
                 

            };
            shi.PackageTable.Add(x);
            shi.SaveChanges();

            MessageBox.Show("新增收件成功:"+"收貨編號-"+x.PackageID);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //新增退件資料-並顯示更新後的資料表

            Buliding_ManagementEntities shi = new Buliding_ManagementEntities();
            var q = shi.PackageCompany.Where(w => w.CompanyName == this.comboBox10.Text).First().PackageCompanyID;
            var q1 = shi.StaffDataTable.Where(s => s.StaffName == this.comboBox2.Text).First().StaffID;
            ReturnPackage x = new ReturnPackage
            {
                ReturnArrivalDate = this.dateTimePicker2.Value,
                ReturnCompanyID = q,
                Returnee = this.comboBox9.Text,
                ReturneeID = int.Parse(this.comboBox8.Text),
                StaffID = q1,
                Sign = false
            };
            shi.ReturnPackage.Add(x);
            shi.SaveChanges();

            MessageBox.Show("新增退件成功:"+"退件編號-"+x.ReturnDataID);
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            //退件人、ID、樓層-作連動
            Buliding_ManagementEntities shi = new Buliding_ManagementEntities();
            var q = shi.ResidentDataTable.Where(n => n.ResidentName == comboBox9.Text).First();
            this.comboBox8.Text = q.ResidentID.ToString();
            this.comboBox7.Text = q.CommunityAddress;
        }


        private void button8_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("確定是此貨物?", "退件資料", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //修改貨物狀態-
                Buliding_ManagementEntities shi = new Buliding_ManagementEntities();
                var q = from p in shi.ReturnPackage.AsEnumerable()
                        where p.ReturnDataID == int.Parse((this.dataGridView2.Rows[this.dataGridView2.CurrentCell.RowIndex].Cells[0].Value).ToString())
                        select p;
                q.First().Sign = true;
                shi.SaveChanges();
                MessageBox.Show("OK，已記錄~");

                //導入更新後資料 - 
                Buliding_ManagementEntities shii = new Buliding_ManagementEntities();
                var qq = shii.ReturnPackage.Where(r => r.Sign == false).Select(emp => new
                {
                    退貨編號 = emp.ReturnDataID,
                    收件日期 = emp.ReturnArrivalDate,
                    貨運公司 = emp.ReturnCompanyID,
                    收件姓名 = emp.Returnee,
                    簽收 = emp.Sign.Value,
                    警衛 = emp.StaffID
                });
                this.dataGridView2.DataSource = qq.ToList();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //查詢選取人是否有包裹未領取,還沒領取就顯示出來

            Buliding_ManagementEntities shi = new Buliding_ManagementEntities();
            tabControl1.SelectedIndex = 1;
            var q = shi.PackageTable.Where(r => r.Sign == false && r.ResidentDataTable.ResidentName == this.comboBox11.Text).Select(emp => new
            {
                收貨編號 = emp.PackageID,
                收件日期 = emp.PackageArrivalDate,
                貨運公司 = emp.PackageCompanyID,
                收件ID = emp.ReceiverID,
                簽收 = emp.Sign.Value,
                警衛 = emp.StaffID
            });
            //var q = from a in shi.PackageTable
            //        where a.Sign == false
            //        select a;
            this.dataGridView1.DataSource = q.ToList();
    
        }
       

        private void button13_Click(object sender, EventArgs e)
        {
            //再次確認
            if (MessageBox.Show("確定要刪除嗎?", "刪除此紀錄", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                //刪除所選列 
                Buliding_ManagementEntities shi = new Buliding_ManagementEntities();
                var q = from p in shi.PackageTable.AsEnumerable()
                        where p.PackageID == int.Parse((this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[0].Value).ToString())
                        select p;
                shi.PackageTable.Remove(q.ToList().First());

                shi.SaveChanges();
                MessageBox.Show("已刪除");

                //導入更新後資料
                Buliding_ManagementEntities shii = new Buliding_ManagementEntities();
                tabControl1.SelectedIndex = 1;
                var qq = shii.PackageTable.Where(r => r.Sign == false).Select(emp => new
                {
                    收貨編號 = emp.PackageID,
                    收件日期 = emp.PackageArrivalDate,
                    貨運公司 = emp.PackageCompanyID,
                    收件姓名 = emp.Receiver,
                    簽收 = emp.Sign.Value,
                    警衛 = emp.StaffID
                });
                this.dataGridView1.DataSource = qq.ToList();
            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("確定要刪除嗎?", "刪除此紀錄", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                //刪除所選列 
                Buliding_ManagementEntities shi = new Buliding_ManagementEntities();
                var q = from p in shi.ReturnPackage.AsEnumerable()
                        where p.ReturnDataID == int.Parse((this.dataGridView2.Rows[this.dataGridView2.CurrentCell.RowIndex].Cells[0].Value).ToString())
                        select p;
                shi.ReturnPackage.Remove(q.ToList().First());
                shi.SaveChanges();
                MessageBox.Show("已刪除");

                //導入更新後資料表
                Buliding_ManagementEntities shii = new Buliding_ManagementEntities();
                var qq = shii.ReturnPackage.Where(r => r.Sign == false).Select(emp => new
                {
                    退貨編號 = emp.ReturnDataID,
                    收件日期 = emp.ReturnArrivalDate,
                    貨運公司 = emp.ReturnCompanyID,
                    收件姓名 = emp.Returnee,
                    簽收 = emp.Sign.Value,
                    警衛 = emp.StaffID
                });
                this.dataGridView2.DataSource = qq.ToList();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("確定是此貨物?", "領件紀錄", MessageBoxButtons.YesNo, MessageBoxIcon.Question )== DialogResult.Yes)
            {
                //修改貨物狀態-
                Buliding_ManagementEntities shi = new Buliding_ManagementEntities();
                var q = from p in shi.PackageTable.AsEnumerable()
                        where p.PackageID == int.Parse((this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[0].Value).ToString())
                        select p;
                q.First().Sign = true;
                shi.SaveChanges();
                MessageBox.Show("取貨完成");

                //重新導入更新後資料表
                Buliding_ManagementEntities shii = new Buliding_ManagementEntities();
                tabControl1.SelectedIndex = 1;
                var qq = shii.PackageTable.Where(r => r.Sign == false).Select(emp => new
                {
                    收貨編號 = emp.PackageID,
                    收件日期 = emp.PackageArrivalDate,
                    貨運公司 = emp.PackageCompanyID,
                    收件姓名 = emp.Receiver,
                    簽收 = emp.Sign.Value,
                    警衛 = emp.StaffID
                });
                this.dataGridView1.DataSource = qq.ToList();
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            //查詢選取人是否有退件包裹未被運貨收走,還沒領取的話就顯示出來

            Buliding_ManagementEntities shi = new Buliding_ManagementEntities();
            tabControl1.SelectedIndex = 3;
            var q = shi.ReturnPackage.Where(r => r.Sign == false && r.ResidentDataTable.ResidentName == this.comboBox14.Text).Select(emp => new
            {
                退貨編號 = emp.ReturnDataID,
                收件日期 = emp.ReturnArrivalDate,
                貨運公司 = emp.ReturnCompanyID,
                收件ID = emp.ReturneeID,
                簽收 = emp.Sign.Value,
                警衛 = emp.StaffID
            });
            this.dataGridView2.DataSource = q.ToList();
        }

    
    }
}
