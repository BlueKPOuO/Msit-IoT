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
    public partial class FrmAnnouncement : FrmLogo3
    {
        public FrmAnnouncement()
        {
            InitializeComponent();
        }
        protected byte[] filecontent;
        protected string filename;
        public void SetData(string ID)
        {
            Buliding_ManagementEntities1 ef = new Buliding_ManagementEntities1();
            int annID = int.Parse(ID);
            BulletinBoard ann = ef.BulletinBoards.Where(x => x.annID == annID).FirstOrDefault();
            textBox8.Text = ann.StaffDataTable.StaffName;
            comboBox4.Text = ann.annClass;
            comboBox3.Text = ann.annGrade;
            dateTimePicker2.Text = ann.annDate.ToString();
            textBox7.Text = ann.annTitle;
            textBox6.Text = ann.annContent;
            if (ann.annFilename != null)
            {
                Button btn = new Button();
                btn.Text = ann.annFilename;
                filename = ann.annFilename;
                btn.Click += Btn_Click;
                groupBox1.Controls.Add(btn);
                filecontent = ann.annAnnex;
            }
            SetUnSelect();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.FileName = filename;
            string ext = Path.GetExtension(filename).ToLower();
            string exttype = string.Empty;
            switch (ext)
            {
                case ".png":
                    exttype = "Png Image|*.png|";
                    break;
                case ".jpg":
                case ".jpeg":
                    exttype = "JPG Image|*.jpg|JPEG Image|*.jpeg|";
                    break;
                case ".gif":
                    exttype ="Gif Image | *.gif | ";
                    break;
                case ".doc":
                case ".docx":
                    exttype = "word 97-2003文件|*.doc|word 文件|*.docx";
                    break;
            }

            string filtercontent = exttype + "所有檔案 *.*|*.*";
            dlg.Filter = filtercontent;
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ByteHelper.WriteByteToFile(filecontent, dlg.FileName);
            }
        }

        protected void SetUnSelect()
        {
            foreach (var item in this.Controls)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    ((TextBox)item).Enabled = false;
                }
                if (item.GetType() == typeof(ComboBox))
                {
                    ((ComboBox)item).Enabled = false;
                }
                if (item.GetType() == typeof(DateTimePicker))
                {
                    ((DateTimePicker)item).Enabled = false;
                }
            }
        }
    }
}
