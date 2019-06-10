using Newtonsoft.Json.Linq;
using System;
using System.Net;
using System.Windows.Forms;

namespace ZPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void periodListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(periodComboBox.SelectedItem.ToString());
        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            string url = CreateURL();
            Console.WriteLine(url);

            WebClient w = new WebClient();
            string json = w.DownloadString(url);
            Console.WriteLine(json);

            dynamic main = JObject.Parse(json);
            JArray rates = main.rates;

            Console.WriteLine(rates.Count);

            series.Points.Clear();
            foreach (var tmp in rates)
            {
                dynamic jrates = JObject.Parse(tmp.ToString());
                series.Points.AddXY(jrates.effectiveDate.ToString(), double.Parse(jrates.mid.ToString()));
            }
        }

        public string CreateURL()
        {
            string url = "http://api.nbp.pl/api/exchangerates/rates/";

            if (tableComboBox.SelectedItem.ToString() == "Avarage")
                url += "a/";
            else
                url += "c/";

            url += currencyComboBox1.Text.ToLower();
            url += "/";

            DateTime today = DateTime.Today;

            DateTime start = DateTime.Today;
            switch(periodComboBox.Text)
            {
                case "1 week":
                    start = DateTime.Today.AddDays(-7);
                    break;
                case "2 weeks":
                    start = DateTime.Today.AddDays(-14);
                    break;
                case "1 month":
                    start = DateTime.Today.AddMonths(-1);
                    break;
                case "3 months":
                    start = DateTime.Today.AddMonths(-3);
                    break;
                case "6 months":
                    start = DateTime.Today.AddMonths(-6);
                    break;
                case "1 year":
                    start = DateTime.Today.AddYears(-1);
                    break;

            }
            string sstart = start.Year.ToString() + "-" + ((start.Month < 10) ? "0" + start.Month.ToString() : start.Month.ToString()) + "-" + ((start.Day < 10) ? "0" + start.Day.ToString() : start.Day.ToString());
            url += sstart;
            url += "/";
            string stoday = today.Year.ToString() + "-" + ((today.Month < 10) ? "0" + today.Month.ToString() : today.Month.ToString()) + "-" + ((today.Day < 10) ? "0" + today.Day.ToString() : today.Day.ToString());
            url += stoday;
            url += "/";

            url += "?format=json";

            return url;
        }

        private void tableListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tableComboBox.SelectedItem.ToString() == "Avarage")
            {
                currencyLabel2.Visible = false;
                currencyComboBox2.Visible = false;
            }
            else
            {
                currencyLabel2.Visible = true;
                currencyComboBox2.Visible = true;
            }
        }
    }
}
