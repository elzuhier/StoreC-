using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class BuyReport : Form
    {
        public BuyReport()
        {
            InitializeComponent();
        }
        List<DateTime> dates = new List<DateTime>();
        List<Double> totalPrices = new List<Double>();
        double TotalTotalPrice = 0;
        private void btnClear_Click(object sender, EventArgs e)
        {
            if (FromTimePicker.Value == ToTimePicker.Value)
            {
                MessageBox.Show("Please Enter two diffrent intervals");
                return;
            }
            else
            {
                dates.Clear();
                totalPrices.Clear();
                ReportGrid.Rows.Clear();
                TotalTotalPrice = 0;

            }
            
            foreach (Buys buy in system.BuysList)
            {
                if (buy.DateTime >= FromTimePicker.Value && buy.DateTime <= ToTimePicker.Value)
                {
                    dates.Add(buy.DateTime);
                    totalPrices.Add(buy.TotalPrice);
                    TotalTotalPrice += buy.TotalPrice;

                }
            }
            for (int i = 0; i < dates.Count; i++)
            {
                ReportGrid.Rows.Add(dates[i].ToString(), totalPrices[i].ToString());
            }
            txtTotalPrice.Text = TotalTotalPrice.ToString();
            txtTotalBills.Text = dates.Count.ToString();
        }

        private void BuyReport_Load(object sender, EventArgs e)
        {

        }
    }
}
