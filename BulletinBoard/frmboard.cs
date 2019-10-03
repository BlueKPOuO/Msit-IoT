using FormLogoClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BulletinBoard
{
    public partial class frmboard : FrmLogo3
    {
        protected string StaffID = "P02";
        protected string StaffName { get; set; }
        public frmboard()
        {

            InitializeComponent();
            dateTimePicker3.CustomFormat = " ";
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker4.CustomFormat = " ";
            dateTimePicker4.Format = DateTimePickerFormat.Custom;
            Buliding_ManagementEntities1 ef = new Buliding_ManagementEntities1();
            this.StaffName = ef.BulletinBoards.Where(x => x.StaffID == "P02").Select(x => x.StaffDataTable.StaffName).FirstOrDefault();
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker3.Format = DateTimePickerFormat.Long;
        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker4.Format = DateTimePickerFormat.Long;
        }

        private void btAnnouncement_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedIndex = 0;
            Buliding_ManagementEntities1 ef = new Buliding_ManagementEntities1();
            List<BulletinBoard> ann = ef.BulletinBoards.Select(x => x).ToList();
            AnnList(ann);
        }

        private void btNew_Click(object sender, EventArgs e)
        {//新增公告button
            tabControl2.SelectedIndex = 1;
            dateTimePicker2.CustomFormat = " ";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            textBox8.Text = this.StaffName;

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Format = DateTimePickerFormat.Long;
        }

        private void btEdit_Click(object sender, EventArgs e)
        {//編輯公告button
            this.listViewEdit.Clear();
            this.listViewEdit.Controls.Clear();
            listViewEdit.View = View.Details;
            listViewEdit.GridLines = true;
            listViewEdit.LabelEdit = false;
            listViewEdit.FullRowSelect = true;
            listViewEdit.Columns.Add("編號", 100);
            listViewEdit.Columns.Add("發布日期", 150);
            listViewEdit.Columns.Add("主旨", 300);
            listViewEdit.Columns.Add("公告類別", 100);
            listViewEdit.Columns.Add("發布人員", 100);
            listViewEdit.Columns.Add("修改", 50);
            listViewEdit.Columns.Add("刪除", 50);

            tabControl2.SelectedIndex = 2;

            dateTimePicker5.CustomFormat = " ";
            dateTimePicker5.Format = DateTimePickerFormat.Custom;
            dateTimePicker6.CustomFormat = " ";
            dateTimePicker6.Format = DateTimePickerFormat.Custom;

            Buliding_ManagementEntities1 ef = new Buliding_ManagementEntities1();
            var ann = ef.BulletinBoards.Select(x => x).ToList();
            var r = from b in ef.BulletinBoards
                    join s in ef.StaffDataTables
                    on b.StaffID equals s.StaffID
                    select new { b.annDate, b.annTitle, b.annClass, b.annID, s.StaffName };

            int i = 1;
            foreach (var annitem in r)
            {
                var item = new ListViewItem($"{i}");
                item.SubItems.Add(annitem.annDate.Value.ToString("yyyy/MM/dd"));
                item.SubItems.Add(annitem.annTitle);
                //item.SubItems.Add(annitem.StaffID);
                item.SubItems.Add(annitem.annClass);
                item.SubItems.Add(annitem.StaffName);
                item.SubItems.Add("");
                item.SubItems.Add("");
                listViewEdit.Items.Add(item);
                //修改button
                Button btn = new Button();
                btn.Tag = annitem.annID;
                btn.Visible = true;
                btn.Text = "";
                btn.Click += this.button_Click;
                btn.Location = new Point(this.listViewEdit.Items[i - 1].SubItems[5].Bounds.Left, this.listViewEdit.Items[i - 1].SubItems[5].Bounds.Top);
                this.listViewEdit.Controls.Add(btn);
                btn.Size = new Size(this.listViewEdit.Items[i - 1].SubItems[5].Bounds.Width,
                this.listViewEdit.Items[i - 1].SubItems[5].Bounds.Height);
                btn.Image = Image.FromFile(@"image/modify.png");
                //刪除button
                Button btn1 = new Button();
                btn1.Tag = annitem.annID;
                btn1.Visible = true;
                btn1.Text = "";
                btn1.Click += this.btnDelete_Click;
                btn1.Location = new Point(this.listViewEdit.Items[i - 1].SubItems[6].Bounds.Left, this.listViewEdit.Items[i - 1].SubItems[6].Bounds.Top);
                this.listViewEdit.Controls.Add(btn1);
                btn1.Size = new Size(this.listViewEdit.Items[i - 1].SubItems[6].Bounds.Width,
                this.listViewEdit.Items[i - 1].SubItems[6].Bounds.Height);
                btn1.Image = Image.FromFile(@"image/delete.png");

                i += 1;
            }
        }
        private void dateTimePicker6_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker6.Format = DateTimePickerFormat.Long;
        }

        private void dateTimePicker5_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker5.Format = DateTimePickerFormat.Long;
        }
        private void button_Click(object sender, EventArgs e)
        {
            frmModify editform = new frmModify();
            editform.SetData(((Button)sender).Tag.ToString());
            editform.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
          
            int annid = int.Parse(((Button)sender).Tag.ToString());

            var confirmResult = MessageBox.Show("確定要刪除此則公告嗎?", "刪除提醒", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Buliding_ManagementEntities1 ef = new Buliding_ManagementEntities1();
                var ann = ef.BulletinBoards.Where(x => x.annID == annid).FirstOrDefault();
                ef.BulletinBoards.Remove(ann);
                ef.SaveChanges();
                btEdit_Click(btEdit, e);
            }


        }

        private void button9_Click(object sender, EventArgs e)
        {
            BulletinBoard Announcement = new BulletinBoard()
            {
                StaffID = this.StaffID,                            //TODO
                annClass = cbxClass.SelectedItem.ToString(),
                annGrade = cbxGrade.SelectedItem.ToString(),
                annTitle = txtTitle.Text,
                annContent = txtContent.Text,
                annDate = DateTime.Now
            };
            if (!string.IsNullOrEmpty(textBox5.Text.Trim()))
            {
                string sourcefilename = Path.GetFileName(textBox5.Text);
                Announcement.annFilename = sourcefilename;
                Announcement.annAnnex = ByteHelper.ReadFileToByte(textBox5.Text);
            }
            Buliding_ManagementEntities1 ef = new Buliding_ManagementEntities1();
            ef.BulletinBoards.Add(Announcement);
            ef.SaveChanges();
            cbxClass.SelectedIndex = -1;
            cbxGrade.SelectedIndex = -1;
            txtTitle.Text = "";
            txtContent.Text = "";
            textBox5.Text = "";
            dateTimePicker2.CustomFormat = " ";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            MessageBox.Show("發布成功");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime? start = null;
            DateTime? end = null;
            if (!string.IsNullOrEmpty(dateTimePicker3.Text.Trim()))
            {
                start = DateTime.Parse(dateTimePicker3.Text);
            }
            if (!string.IsNullOrEmpty(dateTimePicker4.Text.Trim()))
            {
                end = DateTime.Parse(dateTimePicker4.Text);
            }

            string keyword = textBox9.Text.Trim();
            string annClass = comboBox5.SelectedItem == null ? "" : comboBox5.SelectedItem.ToString();
            Buliding_ManagementEntities1 ef = new Buliding_ManagementEntities1();
            List<BulletinBoard> ann = ef.BulletinBoards.Select(x => x).ToList();

            var result1 = ann;
            if (start.HasValue)
            {
                result1 = result1.FindAll(x => x.annDate >= start.Value);
            }
            if (end.HasValue)
            {
                result1 = result1.FindAll(x => x.annDate <= end.Value);
            }
            if (!string.IsNullOrEmpty(keyword))
            {
                result1 = result1.FindAll(x => x.annTitle.Contains(keyword));
            }
            if (!string.IsNullOrEmpty(annClass))
            {
                result1 = result1.FindAll(x => x.annClass == annClass);
            }
            AnnList(result1);
        }

        private void AnnList(List<BulletinBoard> datas)
        {
            //公告button
            this.listViewAnnouncement.Clear();
            listViewAnnouncement.View = View.Details;
            listViewAnnouncement.GridLines = true;
            listViewAnnouncement.LabelEdit = false;
            listViewAnnouncement.FullRowSelect = true;
            listViewAnnouncement.Columns.Add("真實ID", 100);
            listViewAnnouncement.Columns.Add("編號", 100);
            listViewAnnouncement.Columns.Add("發布日期", 150);
            listViewAnnouncement.Columns.Add("主旨", 400);
            listViewAnnouncement.Columns.Add("公告類別", 100);
            listViewAnnouncement.Columns.Add("發布人員", 100);
            listViewAnnouncement.Columns[0].Width = 0;


            int i = 1;
            foreach (var annitem in datas)
            {
                var item = new ListViewItem(annitem.annID.ToString());
                item.SubItems.Add($"{i}");
                item.SubItems.Add(annitem.annDate.Value.ToString("yyyy/MM/dd"));
                item.SubItems.Add(annitem.annTitle);
                item.SubItems.Add(annitem.annClass);
                item.SubItems.Add(annitem.StaffDataTable.StaffName);
                listViewAnnouncement.Items.Add(item);
                i += 1;
            }
        }



        private void button6_Click(object sender, EventArgs e)
        {
            //清除內容button
            textBox10.Text = "";
            comboBox6.SelectedIndex = -1;
            dateTimePicker5.CustomFormat = " ";
            dateTimePicker5.Format = DateTimePickerFormat.Custom;
            dateTimePicker6.CustomFormat = " ";
            dateTimePicker6.Format = DateTimePickerFormat.Custom;
            this.listViewEdit.Controls.Clear();
            this.listViewEdit.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //清除內容button
            textBox9.Text = "";
            comboBox5.SelectedIndex = -1;
            dateTimePicker3.CustomFormat = " ";
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker4.CustomFormat = " ";
            dateTimePicker4.Format = DateTimePickerFormat.Custom;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox5.Text = openFileDialog1.FileName;
            }
        }

        private void listViewAnnouncement_MouseClick(object sender, MouseEventArgs e)
        {
            FrmAnnouncement showForm = new FrmAnnouncement();
            showForm.SetData(((ListView)sender).SelectedItems[0].Text);
            showForm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.listViewEdit.Controls.Clear();
            this.listViewEdit.Clear();

            listViewEdit.View = View.Details;
            listViewEdit.GridLines = true;
            listViewEdit.LabelEdit = false;
            listViewEdit.FullRowSelect = true;
            listViewEdit.Columns.Add("編號", 100);
            listViewEdit.Columns.Add("發布日期", 150);
            listViewEdit.Columns.Add("主旨", 300);
            listViewEdit.Columns.Add("公告類別", 100);
            listViewEdit.Columns.Add("發布人員", 100);
            listViewEdit.Columns.Add("修改", 50);
            listViewEdit.Columns.Add("刪除", 50);

            DateTime? start = null;
            DateTime? end = null;
            if (!string.IsNullOrEmpty(dateTimePicker6.Text.Trim()))
            {
                start = DateTime.Parse(dateTimePicker6.Text);
            }
            if (!string.IsNullOrEmpty(dateTimePicker5.Text.Trim()))
            {
                end = DateTime.Parse(dateTimePicker5.Text);
            }

            string keyword = textBox10.Text.Trim();
            string annClass = comboBox6.SelectedItem == null ? "" : comboBox6.SelectedItem.ToString();
            Buliding_ManagementEntities1 ef = new Buliding_ManagementEntities1();
            List<BulletinBoard> ann = ef.BulletinBoards.Select(x => x).ToList();

            var result1 = ann;
            if (start.HasValue)
            {
                result1 = result1.FindAll(x => x.annDate.Value.Date >= start.Value.Date);
            }
            if (end.HasValue)
            {
                result1 = result1.FindAll(x => x.annDate.Value.Date <= end.Value.Date);
            }
            if (!string.IsNullOrEmpty(keyword))
            {
                result1 = result1.FindAll(x => x.annTitle.Contains(keyword));
            }
            if (!string.IsNullOrEmpty(annClass))
            {
                result1 = result1.FindAll(x => x.annClass == annClass);
            }

            var r = from b in result1
                    join s in ef.StaffDataTables
                    on b.StaffID equals s.StaffID
                    select new { b.annDate, b.annTitle, b.annClass, b.annID, s.StaffName };

            int i = 1;
            foreach (var annitem in r)
            {
                if (!string.IsNullOrEmpty(annitem.annTitle.Trim()))
                {
                    var item = new ListViewItem($"{i}");
                    item.SubItems.Add(annitem.annDate.Value.ToString("yyyy/MM/dd"));
                    item.SubItems.Add(annitem.annTitle);
                    //item.SubItems.Add(annitem.StaffID);
                    item.SubItems.Add(annitem.annClass);
                    item.SubItems.Add(annitem.StaffName);
                    item.SubItems.Add("");
                    item.SubItems.Add("");
                    listViewEdit.Items.Add(item);
                    //修改button
                    Button btn = new Button();
                    btn.Tag = annitem.annID;
                    btn.Visible = true;
                    btn.Text = "";
                    btn.Click += this.button_Click;
                    btn.Location = new Point(this.listViewEdit.Items[i - 1].SubItems[5].Bounds.Left, this.listViewEdit.Items[i - 1].SubItems[5].Bounds.Top);
                    this.listViewEdit.Controls.Add(btn);
                    btn.Size = new Size(this.listViewEdit.Items[i - 1].SubItems[5].Bounds.Width,
                    this.listViewEdit.Items[i - 1].SubItems[5].Bounds.Height);
                    btn.Image = Image.FromFile(@"image/modify.png");
                    //刪除button
                    Button btn1 = new Button();
                    btn1.Tag = annitem.annID;
                    btn1.Visible = true;
                    btn1.Text = "";
                    btn1.Click += this.btnDelete_Click;
                    btn1.Location = new Point(this.listViewEdit.Items[i - 1].SubItems[6].Bounds.Left, this.listViewEdit.Items[i - 1].SubItems[6].Bounds.Top);
                    this.listViewEdit.Controls.Add(btn1);
                    btn1.Size = new Size(this.listViewEdit.Items[i - 1].SubItems[6].Bounds.Width,
                    this.listViewEdit.Items[i - 1].SubItems[6].Bounds.Height);
                    btn1.Image = Image.FromFile(@"image/delete.png");

                    i += 1;
                }
            }
        }
    }
}
