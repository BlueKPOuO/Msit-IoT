using FormLogoClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipSys
{
    public partial class FormEqCreate : FrmLogo3
    {
        public FormEqCreate()
        {
            InitializeComponent();
            this.Title = "新增設備";
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strConn = @"Data source=.;Initial Catalog=Buliding_Management;Integrated Security=true";
            string strSQL = "CreatEquipment";
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand(strSQL, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter pEquipmentName = new SqlParameter("@EquipmentName", SqlDbType.NVarChar, 50);
            pEquipmentName.Direction = ParameterDirection.Input;
            pEquipmentName.Value = this.textBox1.Text;
            cmd.Parameters.Add(pEquipmentName);

            SqlParameter pPlace = new SqlParameter("@Place", SqlDbType.NVarChar, 50);
            pPlace.Direction = ParameterDirection.Input;
            pPlace.Value = this.textBox2.Text;
            cmd.Parameters.Add(pPlace);

            SqlParameter pVendor = new SqlParameter("@Vendor", SqlDbType.NVarChar, 50);
            pVendor.Direction = ParameterDirection.Input;
            pVendor.Value = this.textBox3.Text;
            cmd.Parameters.Add(pVendor);

            SqlParameter pStatus = new SqlParameter("@Status", SqlDbType.NVarChar, 10);
            pStatus.Direction = ParameterDirection.Input;
            pStatus.Value = this.textBox4.Text;
            cmd.Parameters.Add(pStatus);

            SqlParameter pBuydate = new SqlParameter("@Buydate", SqlDbType.Date);
            pBuydate.Direction = ParameterDirection.Input;
            pBuydate.Value = this.dateTimePicker1.Value;
            cmd.Parameters.Add(pBuydate);

            SqlParameter pUseYear = new SqlParameter("@UseYear", SqlDbType.Int);
            pUseYear.Direction = ParameterDirection.Input;
            pUseYear.Value = this.textBox5.Text;
            cmd.Parameters.Add(pUseYear);

            conn.Open();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            conn.Dispose();
            MessageBox.Show("新增完成");
        }

    }
}
