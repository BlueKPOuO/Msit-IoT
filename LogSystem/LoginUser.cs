using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace LogSystem
{
    class LoginUser
    {
        string strCon = ConfigurationManager.ConnectionStrings["LogSystemConnectionConfig"].ConnectionString;
        //public string strCon { get; set; }
        //string strCon = @"Data Source=.;Initial Catalog=Northwind;Integrated Security=true";
        private string m_UserName;
        public string UserName
        {
            get
            {
                return m_UserName;
            }
            set
            {
                string rule = @"[a-zA-Z0-9]\S";//帳號命名規則
                if (Regex.IsMatch(value, rule))
                {//登入帳號驗證 先連資料庫確定帳號存在
                    string strcmd = "IsNameExists";
                    SqlConnection conn = new SqlConnection(strCon);
                    SqlCommand cmd = new SqlCommand(strcmd, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    //帳號
                    SqlParameter pUsername = new SqlParameter("@UserName", SqlDbType.NVarChar, 256);
                    pUsername.Direction = ParameterDirection.Input;
                    pUsername.Value = value;
                    cmd.Parameters.Add(pUsername);
                    //回傳值
                    SqlParameter Return_Value = new SqlParameter("@RETURN_VALUE", SqlDbType.Int);
                    Return_Value.Direction = ParameterDirection.ReturnValue;
                    cmd.Parameters.Add(Return_Value);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    int result = Convert.ToInt32(cmd.Parameters["@RETURN_VALUE"].Value);
                    cmd.Dispose();
                    conn.Close();
                    conn.Dispose();
                    if (result == 1)
                    {
                        m_UserName = value;
                    }
                    else
                    {
                        throw new Exception("帳號或密碼錯誤");//其實是帳號不存在
                    }
                }
                else
                {
                    throw new Exception("帳號有非法字元");
                }
            }
        }
        private string m_password;
        public string Password
        {
            get
            {
                return m_password;
            }
            set
            {   //密碼規則 含各式符號
                string rule = @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[\-\+\?\*\$\[\]\^\.\(\)\|`~!@#%&_ ={}:;',/]).{8,}$";
                if (Regex.IsMatch(value, rule))
                {
                    m_password = value;
                }
                else
                {
                    throw new Exception("密碼不符合規則");
                }
            }
        }
        public bool loginStatus { get; set; }
        public void login()
        {
            loginStatus = false;
            string strCmd1 = "GetSalted";
            string strCmd2 = "Login";
            SqlConnection conn = new SqlConnection(strCon);
            //登入時先取得鹽
            SqlCommand saltcmd = new SqlCommand(strCmd1, conn);
            saltcmd.CommandType = CommandType.StoredProcedure;
            //帳號參數
            SqlParameter pUsername = new SqlParameter("@UserName", SqlDbType.NVarChar, 256);
            pUsername.Direction = ParameterDirection.Input;
            pUsername.Value = m_UserName;
            saltcmd.Parameters.Add(pUsername);
            //鹽參數
            SqlParameter psalt = new SqlParameter("@salted", SqlDbType.NVarChar, 128);
            psalt.Direction = ParameterDirection.Output;
            saltcmd.Parameters.Add(psalt);
            //開始取得鹽的連線
            conn.Open();
            saltcmd.ExecuteNonQuery();
            string salted = (string)saltcmd.Parameters["@salted"].Value;//得到鹽
            saltcmd.Dispose();
            conn.Close();
            //開始登入l
            int n;
            using (SqlCommand logincmd = new SqlCommand(strCmd2, conn))
            {
                logincmd.CommandType = CommandType.StoredProcedure;
                //帳號參數
                SqlParameter lUsername = new SqlParameter("@UserName", SqlDbType.NVarChar, 16);
                lUsername.Direction = ParameterDirection.Input;
                lUsername.Value = m_UserName;
                logincmd.Parameters.Add(lUsername);
                //密碼參數
                SqlParameter lpassword = new SqlParameter("@Password", SqlDbType.VarBinary);
                lUsername.Direction = ParameterDirection.Input;
                //登入鹽+密碼雜湊
                byte[] bytesPasswordAndSalt = Encoding.Unicode.GetBytes(salted + Password);
                byte[] newPassword = new System.Security.Cryptography.SHA256Managed().ComputeHash(bytesPasswordAndSalt);
                lpassword.Value = newPassword;
                logincmd.Parameters.Add(lpassword);

                SqlParameter lReturn_Value = new SqlParameter("@RETURN_VALUE", SqlDbType.Int);
                lReturn_Value.Direction = ParameterDirection.ReturnValue;
                logincmd.Parameters.Add(lReturn_Value);
                conn.Open();
                logincmd.ExecuteNonQuery();
                n = Convert.ToInt32(logincmd.Parameters["@RETURN_VALUE"].Value);
            }
            conn.Close();
            conn.Dispose();
            if (n == 0)
            {
                throw new Exception("登入驗證失敗(帳號或密碼錯誤)");
            }
            else
            {
                //登入成功
                loginStatus = true;
            }
        }
    }
}
