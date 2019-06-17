using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ZPI
{
    public partial class Form1 : Form
    {
        List<double> lista;
        Series series;
        Series buy;
        Series sold;

        public Form1()
        {
            InitializeComponent();
        }

        private void periodListBox_SelectedIndexChanged(object sender, EventArgs e) { }

        private void executeButton_Click(object sender, EventArgs e)
        {
            string url = CreateURL();
            Console.WriteLine(url);
            WebClient w = new WebClient();
            try
            {

                string json = w.DownloadString(url);
                dynamic main = JObject.Parse(json);
                JArray rates = main.rates;

                if (tableComboBox.SelectedItem.ToString() == "Average")
                {
                    lista = new List<double>();
                    this.chart1.Series.Clear();
                    series = this.chart1.Series.Add(main.code.ToString());
                    series.ChartType = SeriesChartType.Spline;
                    series.Points.Clear();
                    series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    foreach (var tmp in rates)
                    {
                        dynamic jrates = JObject.Parse(tmp.ToString());
                        series.Points.AddXY(jrates.effectiveDate.ToString(), double.Parse(jrates.mid.ToString()));
                        lista.Add(double.Parse(jrates.mid.ToString()));
                    }

                    lista.Sort();
                    chart1.ChartAreas[0].AxisY.Minimum = lista.Min() - 0.001* lista.Min();
                    chart1.ChartAreas[0].AxisY.Maximum = lista.Max() + 0.001 * lista.Max();

                    double median = lista[lista.Count / 2];
                    double dominant = getDominant(lista)[0];
                    double stdev = getStandardDeviation(lista);
                    double variation = getVariance(lista);

                    medianValue.Text = median.ToString("N4");
                    dominantValue.Text = dominant.ToString("N4");
                    standardDeviationValue.Text = stdev.ToString("N4");
                    variationValue.Text = variation.ToString("N4");
                }
                else if (tableComboBox.SelectedItem.ToString() == "buy/sold")
                {
                    lista = new List<double>();
                    this.chart1.Series.Clear();
                    buy = this.chart1.Series.Add(main.code.ToString() + " Buy");
                    buy.ChartType = SeriesChartType.Spline;
                    buy.Points.Clear();
                    buy.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    sold = this.chart1.Series.Add(main.code.ToString() + " Sold");
                    sold.ChartType = SeriesChartType.Spline;
                    sold.Points.Clear();
                    sold.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    foreach (var tmp in rates)
                    {
                        dynamic jrates = JObject.Parse(tmp.ToString());
                        buy.Points.AddXY(jrates.effectiveDate.ToString(), double.Parse(jrates.bid.ToString()));
                        sold.Points.AddXY(jrates.effectiveDate.ToString(), double.Parse(jrates.ask.ToString()));
                        lista.Add(double.Parse(jrates.bid.ToString()));
                        lista.Add(double.Parse(jrates.ask.ToString()));
                    }
                }

                chart1.ChartAreas[0].AxisY.Minimum = lista.Min() - 0.001 * lista.Min();
                chart1.ChartAreas[0].AxisY.Maximum = lista.Max() + 0.001 * lista.Max();
            }
            catch(WebException)
            {
                string message = currencyComboBox1.Text + " is not avalaibe in " + tableComboBox.Text;
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
        }

        public string CreateURL()
        {
            string url = "http://api.nbp.pl/api/exchangerates/rates/";

            if (tableComboBox.SelectedItem.ToString() == "Average")
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
            if(tableComboBox.SelectedItem.ToString() == "Average")
            {
                currencyLabel2.Visible = false;
                currencyComboBox2.Visible = false;

                medianLabel.Visible = true;
                medianValue.Visible = true;
                dominantLable.Visible = true;
                dominantValue.Visible = true;
                standardDeviationLabel.Visible = true;
                standardDeviationValue.Visible = true;
                variationLabel.Visible = true;
                variationValue.Visible = true;
            }
            else if (tableComboBox.SelectedItem.ToString() == "buy/sold")
            {
                currencyLabel2.Visible = false;
                currencyComboBox2.Visible = false;

                medianLabel.Visible = false;
                medianValue.Visible = false;
                dominantLable.Visible = false;
                dominantValue.Visible = false;
                standardDeviationLabel.Visible = false;
                standardDeviationValue.Visible = false;
                variationLabel.Visible = false;
                variationValue.Visible = false;
            }
            else
            {
                currencyLabel2.Visible = true;
                currencyComboBox2.Visible = true;

                medianLabel.Visible = false;
                medianValue.Visible = false;
                dominantLable.Visible = false;
                dominantValue.Visible = false;
                standardDeviationLabel.Visible = false;
                standardDeviationValue.Visible = false;
                variationLabel.Visible = false;
                variationValue.Visible = false;
            }
        }

        public double getStandardDeviation(List<double> doubleList)
        {
            return Math.Sqrt(getVariance(doubleList));
        }
        public double getVariance(List<double> doubleList)
        {
            double average = doubleList.Average();
            double sumOfVariance = 0;
            foreach (double value in doubleList)
            {
                sumOfVariance += (value - average) * (value - average);
            }
            return sumOfVariance / (doubleList.Count - 1);
        }

        public List<double> getDominant(List<double> doubleList)
        {
            List<double> result = new List<double>();
            Dictionary<double, int> tmp = new Dictionary<double, int>();

            foreach(double d in doubleList)
            {
                if(tmp.Keys.Contains(d))
                    tmp[d]++;
                else
                    tmp.Add(d, 0);
            }
            
            var sortedDict = from entry in tmp orderby entry.Value ascending select entry;
            int dominant = sortedDict.Last().Value;

            for (int i=0; i<tmp.Count; i++)
            {
                if(tmp.Values.ElementAt(i) == dominant)
                {
                    result.Add(tmp.Keys.ElementAt(i));
                }
            }
            return result;
        }
    }
}
