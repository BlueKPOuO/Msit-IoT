using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogSystem
{
    public partial class FrmCreate : Form
    {
        public FrmCreate()
        {
            InitializeComponent();
            foreach(Control x in this.Controls)
            {
                if(x is TextBox)
                {
                    x.TextChanged += X_TextChanged;
                }
            }
            btnCreate.Enabled = false;
        }

        private void X_TextChanged(object sender, EventArgs e)
        {
            button_enable();
        }

        private void tbUN_Leave(object sender, EventArgs e)
        {
            string rule = @"[a-zA-Z0-9]\S{5,}";//帳號命名規則
            if (!Regex.IsMatch(tbUN.Text, rule))
            {
                errorProvider1.SetError(tbUN, "帳號請以字母及數字組合而成(至少5位)");
            }
            else
            {
                errorProvider1.SetError(tbUN, "");
            }
        }

        private void tbPW_Leave(object sender, EventArgs e)
        {
            string rule = @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[\-\+\?\*\$\[\]\^\.\(\)\|`~!@#%&_ ={}:;',/]).{8,}$";
            if (!Regex.IsMatch(tbPW.Text, rule))
            {
                errorProvider1.SetError(tbPW, "密碼請以大小寫英文、數字及鍵盤上的符號組成(至少8位)");
            }
            else
            {
                errorProvider1.SetError(tbPW, "");
            }
        }

        private void tbAPW_Leave(object sender, EventArgs e)
        {
            if(tbPW.Text!=tbAPW.Text)
            {
                errorProvider1.SetError(tbAPW, "輸入錯誤");
            }
            else
            {
                errorProvider1.SetError(tbAPW, "");
            }
        }

        private void tbemail_Leave(object sender, EventArgs e)
        {
            string rule = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            if(!Regex.IsMatch(tbemail.Text,rule))
            {
                errorProvider1.SetError(tbemail, "請輸入正確的email");
            }
            else
            {
                errorProvider1.SetError(tbemail, "");
            }
        }
        void button_enable()
        {//全部格子有值才能按鈕
            btnCreate.Enabled = true;
            foreach(Control x in Controls)
            {
                if(x is TextBox)
                {
                    if(x.Text.Trim() == "")
                    {
                        btnCreate.Enabled = false;
                        return;
                    }
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (errorProvider1.GetError(tbUN) == ""&& errorProvider1.GetError(tbPW) == ""
             && errorProvider1.GetError(tbAPW) == ""&& errorProvider1.GetError(tbemail) == "")
            {
                CreateUser cu = new CreateUser();
                try
                {
                    cu.UserName = tbUN.Text;
                    cu.Password = tbPW.Text;
                    cu.email = tbemail.Text;
                    cu.StaffID = tbStaffID.Text;
                    cu.create();
                    MessageBox.Show($"帳號創建成功");

                    //改
                    //Member member = new Member(tbUN.Text, tbPW.Text, tbemail.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("還有格子還沒輸入完成");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
