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

namespace PublicSpaceSys
{
    public partial class Chart : FrmLogo3
    {
        public Chart()
        {
            InitializeComponent();

            this.historyTableAdapter1.Fill(this.historyDataSet1.History);

            PublicSpace ps = new PublicSpace();

            var q = from n in this.historyDataSet1.History                    
                    group n by n.Location into g                    
                    select new
                    {
                        Mykey = g.Key,
                        Mycount = g.Count()
                    };

            

            this.chart1.DataSource = q.ToList();
            this.chart1.Series[0].XValueMember = "Mykey";
            this.chart1.Series[0].YValueMembers = "Mycount";
            this.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            this.chart2.DataSource = q.ToList();
            this.chart2.Series[0].XValueMember = "Mykey";
            this.chart2.Series[0].YValueMembers = "Mycount";
            this.chart2.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
        }

    }
}
