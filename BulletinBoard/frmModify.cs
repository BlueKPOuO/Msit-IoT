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
    public partial class frmModify : FrmLogo3
    {
        protected int id;
        public frmModify()
        {
            InitializeComponent();
        }

        public void SetData(string ID)
        {
            Buliding_ManagementEntities1 ef = new Buliding_ManagementEntities1();
            int annID = int.Parse(ID);
            id = annID;
            BulletinBoard ann = ef.BulletinBoards.Where(x => x.annID == annID).FirstOrDefault();
            textBox8.Text = ann.StaffDataTable.StaffName;
            comboBox4.Text = ann.annClass;
            comboBox3.Text = ann.annGrade;
            dateTimePicker2.Text = ann.annDate.ToString();
            textBox7.Text = ann.annTitle;
            textBox6.Text = ann.annContent;
            textBox5.Text = ann.annFilename;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Buliding_ManagementEntities1 ef = new Buliding_ManagementEntities1();
            BulletinBoard ann = ef.BulletinBoards.Where(x => x.annID == id).FirstOrDefault();
            ann.annClass = comboBox4.Text;
            ann.annGrade = comboBox3.Text;
            ann.annDate = DateTime.Parse(dateTimePicker2.Text);
            ann.annTitle = textBox7.Text;
            ann.annContent = textBox6.Text;
            if (textBox5.Text.Contains(":"))
            {
                ann.annAnnex = ByteHelper.ReadFileToByte(textBox5.Text);
                string sourcefilename = Path.GetFileName(textBox5.Text);
                ann.annFilename = sourcefilename;
            }
            ef.SaveChanges();
            MessageBox.Show("修改成功");
            this.Close();
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
    }
}
