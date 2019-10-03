using FormLogoClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PublicSpacesys
{
    public partial class ChartForm : FrmLogo3
    {
        public ChartForm()
        {
            InitializeComponent();

            this.historyTableAdapter1.Fill(this.historyDataSet1.History);
            this.locationTableAdapter1.Fill(this.historyDataSet1.Location);

            PublicSpace ps = new PublicSpace();

            var q = from h in this.historyDataSet1.History
                    join L in this.historyDataSet1.Location 
                    on h.LocationID equals L.LocationID
                    group h by L.Location into g
                    select new
                    {
                        Location = g.Key,
                        Mycount = g.Count()                        
                    };    


            this.chart1.DataSource = q.ToList();
            this.chart1.Series[0].XValueMember = "Location";
            this.chart1.Series[0].YValueMembers = "Mycount";
            this.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            this.chart2.DataSource = q.ToList();
            this.chart2.Series[0].XValueMember = "Location";
            this.chart2.Series[0].YValueMembers = "Mycount";
            this.chart2.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
        }

    }
}
