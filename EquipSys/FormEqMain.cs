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
    public partial class FormEqMain : FrmLogo3
    
    {
        public FormEqMain()
        {
            InitializeComponent();
            this.Title = "設備管理";
            this.dbContext.Database.Log = Console.Write;
        }

        Buliding_ManagementEntitiesEq dbContext = new Buliding_ManagementEntitiesEq();

        private void button1_Click(object sender, EventArgs e)
        {
            FormEqCreate f = new FormEqCreate();
            f.UserName = UserName;
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.CurrentCell.ColumnIndex == 0)
            {
                FormEqReservation f = new FormEqReservation();
                f.textBox1.Text = this.dataGridView1.CurrentCell.Value.ToString();
                f.UserName = UserName;
                f.ShowDialog();
            }
            else
                MessageBox.Show("請選擇物品編號");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var q = from eq in this.dbContext.Equipments
                    select new { 設備編號=eq.EquipmentID,設備名稱= eq.EquipmentName,設置地點= eq.Place,
                                品牌= eq.Vendor,目前狀態= eq.Status,購買日期= eq.Buydate,使用年限= eq.UseYear };
            this.dataGridView1.DataSource = q.ToList();
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定要刪?", "刪除", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var q = dbContext.Equipments.AsEnumerable()
                             .Where(eq => eq.EquipmentID == int.Parse(this.dataGridView1.CurrentCell.Value.ToString()))
                             .FirstOrDefault();
                    if (q != null)
                    {
                        dbContext.Equipments.Remove(q);
                        int re = dbContext.SaveChanges();
                        Debug.WriteLine(q);
                    }
                    var q2 = from eq in this.dbContext.Equipments
                             select eq;
                    MessageBox.Show("刪除成功");
                }
                catch (FormatException)
                {
                    MessageBox.Show("請選擇物品編號");
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormEqUpdate f = new FormEqUpdate();
            f.textBox6.Text= this.dataGridView1.CurrentCell.Value.ToString();
            f.UserName = UserName;
            f.ShowDialog();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
         
            var q2 = from pl in dbContext.Equipments
                     group pl by pl.Place into g
                     select new
                     {
                         MyPlace = g.Key,
                         MyEquipment = (from eq in g
                                        group eq by eq.EquipmentName into g2
                                        select new { MyEquipmentName = g2.Key })
                     };
            foreach (var group in q2)
            {
                TreeNode x = this.treeView1.Nodes.Add(group.MyPlace);
                x.Tag = "地方";
                foreach (var item in group.MyEquipment)
                {
                    TreeNode y = x.Nodes.Add(item.MyEquipmentName);
                    y.Tag = "物品名稱";
                }
            }

            var q = from eq in this.dbContext.Equipments
                    select new
                    {
                        設備編號 = eq.EquipmentID,
                        設備名稱 = eq.EquipmentName,
                        設置地點 = eq.Place,
                        品牌 = eq.Vendor,
                        目前狀態 = eq.Status,
                        購買日期 = eq.Buydate,
                        使用年限 = eq.UseYear
                    };
            this.dataGridView1.DataSource = q.ToList();
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        void treeload()
        {
            this.treeView1.Nodes.Clear();
            var q2 = from pl in dbContext.Equipments
                    group pl by pl.Place into g
                    select new
                    {
                        MyPlace=g.Key,
                        MyEquipment=(from eq in g
                                     group eq by eq.EquipmentName into g2
                                     select new { MyEquipmentName=g2.Key})
                    };
            foreach (var group in q2)
            {
                TreeNode x = this.treeView1.Nodes.Add(group.MyPlace);
                x.Tag = "地方";
                foreach (var item in group.MyEquipment)
                {
                    TreeNode y = x.Nodes.Add(item.MyEquipmentName);
                    y.Tag = "物品名稱";
                }
            }

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //e.Node.Expand();            
            switch (e.Node.Tag.ToString())
            {
                case "地方":
                    var q = from p in dbContext.Equipments.AsEnumerable()
                            where p.Place == e.Node.Text
                            select new { 設備編號 = p.EquipmentID, 設備名稱 = p.EquipmentName, 設置地點 = p.Place,
                                品牌 = p.Vendor,目前狀態 = p.Status,
                                購買日期 = p.Buydate,
                                使用年限 = p.UseYear };
                    this.dataGridView1.DataSource = q.ToList();
                    //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                    break;
                case "物品名稱":
                    var q2 = from eq in dbContext.Equipments.AsEnumerable()
                            where eq.EquipmentName == e.Node.Text
                             select new
                             {
                                 設備編號 = eq.EquipmentID,
                                 設備名稱 = eq.EquipmentName,
                                 設置地點 = eq.Place,
                                 品牌 = eq.Vendor,
                                 目前狀態 = eq.Status,
                                 購買日期 = eq.Buydate,
                                 使用年限 = eq.UseYear
                             };
                    this.dataGridView1.DataSource = q2.ToList();
                    //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                    break;
            }
            //同樣物品 不同地點一樣會出現
        }
             
        private void button6_Click_1(object sender, EventArgs e)
        {
            var q = from eq in this.dbContext.Equipments
                    select new { eq.EquipmentID, eq.EquipmentName, eq.Place, eq.Vendor, eq.Status, eq.Buydate, eq.UseYear };
            this.dataGridView1.DataSource = q.ToList();
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(this.dataGridView1.SelectedRows);
        
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormEqCreate f = new FormEqCreate();
            f.UserName = UserName;
            f.ShowDialog();
            loaddvdate();
            treeload();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定要刪?", "刪除", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var q = dbContext.Equipments.AsEnumerable()
                             .Where(eq => eq.EquipmentID == int.Parse(this.dataGridView1.CurrentCell.Value.ToString()))
                             .FirstOrDefault();
                    if (q != null)
                    {
                        dbContext.Equipments.Remove(q);
                        int re = dbContext.SaveChanges();
                    }
                    loaddvdate();
                    MessageBox.Show("刪除成功");
                }
                catch (FormatException)
                {
                    MessageBox.Show("請選擇物品編號");
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (this.dataGridView1.CurrentCell.ColumnIndex == 0)
            {
                FormEqUpdate f = new FormEqUpdate();
                f.textBox6.Text = this.dataGridView1.CurrentCell.Value.ToString();
                f.UserName = UserName;
                f.ShowDialog();
                loaddvdate();
            }
            else
                MessageBox.Show("請選擇物品編號");
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (this.dataGridView1.CurrentCell.ColumnIndex == 0)
            {
                FormEqReservation f = new FormEqReservation();
                f.textBox1.Text = this.dataGridView1.CurrentCell.Value.ToString();
                f.UserName = UserName;
                f.ShowDialog();
            }
            else
                MessageBox.Show("請選擇物品編號");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.CurrentCell.ColumnIndex == 0)
            {
                FormEqAll f = new FormEqAll();
                f.textBox6.Text = this.dataGridView1.CurrentCell.Value.ToString();
                f.UserName = UserName;
                f.ShowDialog();
            }
            else
                MessageBox.Show("請選擇物品編號");
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            treeload();
        }

        private void button6_Click_2(object sender, EventArgs e)
        {
            loaddvdate();
           
        }
        void loaddvdate()
        {
            this.dataGridView1.DataSource = null;
            var q = from eq in this.dbContext.Equipments
                     select new
                     {
                         設備編號 = eq.EquipmentID,
                         設備名稱 = eq.EquipmentName,
                         設置地點 = eq.Place,
                         品牌 = eq.Vendor,
                         目前狀態 = eq.Status,
                         購買日期 = eq.Buydate,
                         使用年限 = eq.UseYear
                     };
            this.dataGridView1.DataSource = q.ToList();
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void button7_Click_2(object sender, EventArgs e)
        {
            if (this.dataGridView1.CurrentCell.ColumnIndex == 0)
            {
                FormFix f = new FormFix();
                f.textBox6.Text = this.dataGridView1.CurrentCell.Value.ToString();
                f.UserName = UserName;
                f.ShowDialog();
                
            }
            else
                MessageBox.Show("請選擇物品編號");

            loaddvdate();

        }

        private void button8_Click_2(object sender, EventArgs e)
        {
            FormFixMain f = new FormFixMain();
            f.UserName = UserName;
            f.ShowDialog();
            loaddvdate();
        }
    }
}
