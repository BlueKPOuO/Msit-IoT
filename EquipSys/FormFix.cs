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
    public partial class FormFix : FrmLogo3
    {
        public FormFix()
        {
            InitializeComponent();
            this.Title = "設備報修";
        }
       Buliding_ManagementEntitiesEq dbContext = new Buliding_ManagementEntitiesEq();
        private void button1_Click(object sender, EventArgs e)
        {
            string strConn = @"Data source=.;Initial Catalog=Buliding_Management;Integrated Security=true";
            string strSQL = "EquipmentFix";
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand(strSQL, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter pEquipmentID = new SqlParameter("@EquipmentID", SqlDbType.Int);
            pEquipmentID.Direction = ParameterDirection.Input;
            pEquipmentID.Value = this.textBox6.Text;
            cmd.Parameters.Add(pEquipmentID);

            SqlParameter pReportDate = new SqlParameter("@ReportDate", SqlDbType.Date);
            pReportDate.Direction = ParameterDirection.Input;
            pReportDate.Value = this.dateTimePicker1.Value;
            cmd.Parameters.Add(pReportDate);

            SqlParameter pReason = new SqlParameter("@Reason", SqlDbType.NVarChar, 50);
            pReason.Direction = ParameterDirection.Input;
            pReason.Value = this.textBox1.Text;
            cmd.Parameters.Add(pReason);

            SqlParameter pRepaired = new SqlParameter("@Repaired", SqlDbType.Bit);
            pRepaired.Direction = ParameterDirection.Input;
            pRepaired.Value = 0;
            cmd.Parameters.Add(pRepaired);

            conn.Open();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            conn.Dispose();

            var q = dbContext.Equipments.AsEnumerable()
                                        .Where(eq => eq.EquipmentID == int.Parse(this.textBox6.Text));
            var updateEq = q.First();
            updateEq.Status = "維修中";
            dbContext.SaveChanges();

            MessageBox.Show("申請報修完成");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
