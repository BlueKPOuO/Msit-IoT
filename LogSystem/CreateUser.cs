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
    class CreateUser
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
                string rule = @"[a-zA-Z0-9]\S";//帳號命名規則 只允許大小寫數字
                if(Regex.IsMatch(value,rule))
                {//帳號驗證 先連資料庫確定無重複帳號
                    value = value.ToLower();//帳號不分大小寫 先全部變小寫
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
                        throw new Exception("帳號已存在");
                    }
                    else
                    {
                        m_UserName = value;
                    }
                }
                else
                {
                    throw new Exception("帳號請以數字和字母組成(禁止特殊字元、空格)");
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
                if(Regex.IsMatch(value,rule))
                {
                    m_password = value;
                }
                else
                {
                    throw new Exception("密碼不符合複雜密碼規則(需含有大、小寫字母、特殊字元、數字)");
                }
            }
        }
        private string m_StaffID;
        public string StaffID
        {
            get
            {
                return m_StaffID;
            }
            set
            {
                SqlConnection conn = new SqlConnection(strCon);
                string strcmd = "select StaffID from [dbo].[StaffDataTable] where StaffID=@StaffID";
                SqlCommand cmd = new SqlCommand(strcmd, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter() { ParameterName = "@StaffID", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = value });
                conn.Open();
                string result = Convert.ToString(cmd.ExecuteScalar());
                if (result == null || result == "")
                {
                    throw new Exception("無此警衛ID,請聯絡其他管理員");
                }
                else
                {
                    m_StaffID = value;
                }
            }
        }
        public string email { get; set; }
        public void create()
        {
            string strcmd = @"CreateUser";
            SqlConnection conn = new SqlConnection(strCon);
            SqlCommand cmd = new SqlCommand(strcmd, conn);
            cmd.CommandType = CommandType.StoredProcedure;//預存程序
            //回傳一個帳號ID(編號)
            SqlParameter pID = new SqlParameter("@ID", SqlDbType.Int);
            pID.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(pID);

            //設定預存程序需求參數 帳號參數
            SqlParameter pUserName = new SqlParameter("@UserName", SqlDbType.NVarChar, 256);
            pUserName.Direction = ParameterDirection.Input;
            pUserName.Value = UserName;
            cmd.Parameters.Add(pUserName);
            
            //加料(鹽巴)參數
            SqlParameter psalt = new SqlParameter("@salted", SqlDbType.NVarChar, 128);
            psalt.Direction = ParameterDirection.Input;
            string salt = Guid.NewGuid().ToString();//鹽巴數值 
            psalt.Value = salt;
            cmd.Parameters.Add(psalt);

            //密碼參數
            SqlParameter pPassword = new SqlParameter("@Password", SqlDbType.VarBinary);
            pPassword.Direction = ParameterDirection.Input;
            byte[] bytesPasswordAndSalt = Encoding.Unicode.GetBytes(salt + Password);
            //建立帳密 密碼雜湊
            byte[] newpassword = new System.Security.Cryptography.SHA256Managed().ComputeHash(bytesPasswordAndSalt);
            pPassword.Value = newpassword;
            cmd.Parameters.Add(pPassword);

            //email
            SqlParameter pemail = new SqlParameter("@email", SqlDbType.NVarChar, 256);
            pemail.Direction = ParameterDirection.Input;
            pemail.Value = email;
            cmd.Parameters.Add(pemail);

            //警衛ID
            SqlParameter pStaffID = new SqlParameter("@StaffID", SqlDbType.NVarChar, 10);
            pStaffID.Direction = ParameterDirection.Input;
            pStaffID.Value = StaffID;
            cmd.Parameters.Add(pStaffID);

            conn.Open();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            conn.Dispose();
        }

        
    }
    
}
