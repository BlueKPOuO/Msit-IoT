using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkInfomation
{
    public class ParkInfo
    {
        public string RID { get; set; }
        public int ParkingNum { get; set; }
        public string LicensePlate { get; set; }
        public DateTime EnterTime { get; set; }
        public DateTime QuitTime { get; set; }
        public string ContactName { get; set; }
        public string ContactPhone { get; set; }
        public int ParkingFee { get; set; }
        public string StaffID { get; set; }

        public static int FeeCal(DateTime T1, DateTime T2)
        {
            double Hours = (T2 - T1).TotalHours;
            if (Hours < 1)
            {
                Hours = 1;
                return (int)Hours * 20;
            }
            else
            {
                if (Hours % 1 <= 0.5)
                {
                    Hours = (int)Hours / 1 + 0.5;
                    return (int)(Hours * 20);
                }
                else
                {
                    Hours = (int)Hours + 1;
                    return (int)Hours * 20;
                }
            }
        }
    }
}
