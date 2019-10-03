using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormLogoClassLibrary;
using System.Configuration;

namespace LogSystem
{
    public partial class FrmLogin : FrmLogo3
    {
        public FrmLogin()
        {
            InitializeComponent();
            Title = "大樓管理系統\r\n登入";
            foreach (Control x in this.panel1.Controls)
            {
                if (x is TextBox)
                {
                    x.TextChanged += X_TextChanged; ;
                }
            }
            btnLogin.Enabled = false;
            if (ConfigurationManager.AppSettings["Savecheck"]=="true")
            {
                tbUN.Text = ConfigurationManager.AppSettings["SaveAccount"];
                tbPW.Text = ConfigurationManager.AppSettings["SavePassword"];
                checkBox1.Checked = true;
            }
        }

        private void X_TextChanged(object sender, EventArgs e)
        {
            button_enable();
        }

        private void button_enable()
        {//全部格子有值才能按鈕
            btnLogin.Enabled = true;
            foreach (Control x in this.panel1.Controls)
            {
                if (x is TextBox)
                {
                    if (x.Text.Trim() == "")
                    {
                        btnLogin.Enabled = false;
                        return;
                    }
                }
            }
        }

        private void btnCreateFrm_Click(object sender, EventArgs e)
        {
            FrmCreate fc = new FrmCreate();
            fc.TopLevel = false;
            fc.Show();
            panel3.Controls.Add(fc);
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
        public string username;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (errorProvider1.GetError(tbUN) == "" && errorProvider1.GetError(tbPW) == "")
            {
                LoginUser lu = new LoginUser();
                try
                {
                    lu.UserName = tbUN.Text;
                    lu.Password = tbPW.Text;
                    lu.login();
                    if (lu.loginStatus)
                    {
                        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                        // 移除指定的AppSettings (記住密碼)
                        config.AppSettings.Settings.Remove("SaveAccount");
                        config.AppSettings.Settings.Remove("SavePassword");
                        config.AppSettings.Settings.Remove("Savecheck");
                        if (checkBox1.Checked)
                        {
                            // 新增指定的appSettings (記住密碼)
                            config.AppSettings.Settings.Add("SaveAccount", tbUN.Text);
                            config.AppSettings.Settings.Add("SavePassword", tbPW.Text);
                            config.AppSettings.Settings.Add("Savecheck", "true");
                            // 加密
                            ConfigurationSection section = config.Sections["appSettings"];
                            section.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
                        }
                        // 儲存設定
                        config.Save(ConfigurationSaveMode.Modified);
                        DialogResult = MessageBox.Show($"歡迎!{tbUN.Text}");
                        username = tbUN.Text;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("登入失敗");
                    }
                        
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("還有格子沒輸入完成");
            }
        }


        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

       
    }
}
