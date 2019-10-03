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
    public partial class FormEqReservation : FrmLogo3
    {
        public FormEqReservation()
        {
            InitializeComponent();
            this.Title = "設備預約";
        }
        Buliding_ManagementEntitiesEq dbContext = new Buliding_ManagementEntitiesEq();
        private void button1_Click(object sender, EventArgs e)
        {
           

            if (this.dateTimePicker1.Value < this.dateTimePicker2.Value)
            {
                string strConn = @"Data source=.;Initial Catalog=Buliding_Management;Integrated Security=true";
                string strSQL = "ReservationNumber";
                SqlConnection conn = new SqlConnection(strConn);
                SqlCommand cmd = new SqlCommand(strSQL, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter pEquipmentID = new SqlParameter("@EquipmentID", SqlDbType.Int);
                pEquipmentID.Direction = ParameterDirection.Input;
                pEquipmentID.Value = this.textBox1.Text;
                cmd.Parameters.Add(pEquipmentID);

                SqlParameter pReservationDate = new SqlParameter("@ReservationDate", SqlDbType.DateTime);
                pReservationDate.Direction = ParameterDirection.Input;
                pReservationDate.Value = this.dateTimePicker1.Value;
                cmd.Parameters.Add(pReservationDate);

                SqlParameter pResidentID = new SqlParameter("@ResidentID", SqlDbType.Int);
                pResidentID.Direction = ParameterDirection.Input;
                pResidentID.Value = this.textBox2.Text;
                cmd.Parameters.Add(pResidentID);

                SqlParameter pReturnDate = new SqlParameter("@ReturnDate", SqlDbType.DateTime);
                pReturnDate.Direction = ParameterDirection.Input;
                if (this.dateTimePicker1.Value == this.dateTimePicker2.Value)
                {
                    pReturnDate.Value = null;
                }
                else
                {
                    pReturnDate.Value = this.dateTimePicker2.Value;
                }
                cmd.Parameters.Add(pReturnDate);

                conn.Open();
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                conn.Dispose();
                MessageBox.Show("預約完成");

                var q = from eq in dbContext.EquipReservations.AsEnumerable()
                        where eq.EquipmentID == int.Parse(this.textBox1.Text)
                        join eqname in dbContext.Equipments
                        on eq.EquipmentID equals eqname.EquipmentID
                        select new { 預約編號=eq.EquipReservationID,設備ID= eq.EquipmentID,租借日期= eq.ReservationDate,
                                   設備名稱=eqname.EquipmentName, 住戶ID=eq.ResidentID, 歸還日期=eq.ReturnDate };

                this.dataGridView1.DataSource = q.ToList();
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
            else
                MessageBox.Show("租借日大於歸還日");
        }

        private void FormEqReservation_Load(object sender, EventArgs e)
        {
            var q = from eq in dbContext.EquipReservations.AsEnumerable()
                    where eq.EquipmentID == int.Parse(this.textBox1.Text)
                    join eqname in dbContext.Equipments
                        on eq.EquipmentID equals eqname.EquipmentID
                    select new
                    {
                        預約編號 = eq.EquipReservationID,
                        設備ID = eq.EquipmentID,
                        租借日期 = eq.ReservationDate,
                        設備名稱 = eqname.EquipmentName,
                        住戶ID = eq.ResidentID,
                        歸還日期 = eq.ReturnDate
                    };

            this.dataGridView1.DataSource = q.ToList();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
    }
}
