using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZPI;

namespace Form1Test
{
    [TestClass]
    public class UnitTest1
    {
        Form1 form1 = new Form1();
        DateTime today = DateTime.Today;
        DateTime start = DateTime.Today;
        String url;
        String expectedUrl;
        String startDate;
        String todayDate;

        //  ----------------------------------------------------------------
        //  ------------- Testing create URL from all currency -------------
        //  ----------------------------------------------------------------

        [TestMethod]
        public void TestEqCreateUrlUsdWeekAverage()
        {
            form1.TableComboBox.SelectedItem = "Avarage";
            form1.PeriodComboBox.Text = "1 week";
            form1.CurrencyComboBox1.Text = "USD";

            start = DateTime.Today.AddDays(-7);
            setDateToString();
            expectedUrl = "http://api.nbp.pl/api/exchangerates/rates/a/usd/" + startDate + "/" + todayDate + "/?format=json";

            url = form1.CreateURL();

            Assert.AreEqual(expectedUrl, url);
        }

        [TestMethod]
        public void TestEqCreateUrlEurWeekAverage()
        {
            form1.TableComboBox.SelectedItem = "Avarage";
            form1.PeriodComboBox.Text = "1 week";
            form1.CurrencyComboBox1.Text = "EUR";

            start = DateTime.Today.AddDays(-7);
            setDateToString();
            expectedUrl = "http://api.nbp.pl/api/exchangerates/rates/a/eur/" + startDate + "/" + todayDate + "/?format=json";

            url = form1.CreateURL();

            Assert.AreEqual(expectedUrl, url);
        }

        [TestMethod]
        public void TestEqCreateUrlJpyWeekAverage()
        {
            form1.TableComboBox.SelectedItem = "Avarage";
            form1.PeriodComboBox.Text = "1 week";
            form1.CurrencyComboBox1.Text = "JPY";

            start = DateTime.Today.AddDays(-7);
            setDateToString();
            expectedUrl = "http://api.nbp.pl/api/exchangerates/rates/a/jpy/" + startDate + "/" + todayDate + "/?format=json";

            url = form1.CreateURL();

            Assert.AreEqual(expectedUrl, url);
        }

        [TestMethod]
        public void TestEqCreateUrlGbpWeekAverage()
        {
            form1.TableComboBox.SelectedItem = "Avarage";
            form1.PeriodComboBox.Text = "1 week";
            form1.CurrencyComboBox1.Text = "GBP";

            start = DateTime.Today.AddDays(-7);
            setDateToString();
            expectedUrl = "http://api.nbp.pl/api/exchangerates/rates/a/gbp/" + startDate + "/" + todayDate + "/?format=json";

            url = form1.CreateURL();

            Assert.AreEqual(expectedUrl, url);
        }

        [TestMethod]
        public void TestEqCreateUrlAudWeekAverage()
        {
            form1.TableComboBox.SelectedItem = "Avarage";
            form1.PeriodComboBox.Text = "1 week";
            form1.CurrencyComboBox1.Text = "AUD";

            start = DateTime.Today.AddDays(-7);
            setDateToString();
            expectedUrl = "http://api.nbp.pl/api/exchangerates/rates/a/aud/" + startDate + "/" + todayDate + "/?format=json";

            url = form1.CreateURL();

            Assert.AreEqual(expectedUrl, url);
        }

        [TestMethod]
        public void TestEqCreateUrlChfWeekAverage()
        {
            form1.TableComboBox.SelectedItem = "Avarage";
            form1.PeriodComboBox.Text = "1 week";
            form1.CurrencyComboBox1.Text = "CHF";

            start = DateTime.Today.AddDays(-7);
            setDateToString();
            expectedUrl = "http://api.nbp.pl/api/exchangerates/rates/a/chf/" + startDate + "/" + todayDate + "/?format=json";

            url = form1.CreateURL();

            Assert.AreEqual(expectedUrl, url);
        }

        [TestMethod]
        public void TestEqCreateUrlCadWeekAverage()
        {
            form1.TableComboBox.SelectedItem = "Avarage";
            form1.PeriodComboBox.Text = "1 week";
            form1.CurrencyComboBox1.Text = "CAD";

            start = DateTime.Today.AddDays(-7);
            setDateToString();
            expectedUrl = "http://api.nbp.pl/api/exchangerates/rates/a/cad/" + startDate + "/" + todayDate + "/?format=json";

            url = form1.CreateURL();

            Assert.AreEqual(expectedUrl, url);
        }

        [TestMethod]
        public void TestEqCreateUrlMxnWeekAverage()
        {
            form1.TableComboBox.SelectedItem = "Avarage";
            form1.PeriodComboBox.Text = "1 week";
            form1.CurrencyComboBox1.Text = "MXN";

            start = DateTime.Today.AddDays(-7);
            setDateToString();
            expectedUrl = "http://api.nbp.pl/api/exchangerates/rates/a/mxn/" + startDate + "/" + todayDate + "/?format=json";

            url = form1.CreateURL();

            Assert.AreEqual(expectedUrl, url);
        }

        [TestMethod]
        public void TestEqCreateUrlCnyWeekAverage()
        {
            form1.TableComboBox.SelectedItem = "Avarage";
            form1.PeriodComboBox.Text = "1 week";
            form1.CurrencyComboBox1.Text = "CNY";

            start = DateTime.Today.AddDays(-7);
            setDateToString();
            expectedUrl = "http://api.nbp.pl/api/exchangerates/rates/a/cny/" + startDate + "/" + todayDate + "/?format=json";

            url = form1.CreateURL();

            Assert.AreEqual(expectedUrl, url);
        }

        [TestMethod]
        public void TestEqCreateUrlPlnWeekAverage()
        {
            form1.TableComboBox.SelectedItem = "Avarage";
            form1.PeriodComboBox.Text = "1 week";
            form1.CurrencyComboBox1.Text = "PLN";

            start = DateTime.Today.AddDays(-7);
            setDateToString();
            expectedUrl = "http://api.nbp.pl/api/exchangerates/rates/a/pln/" + startDate + "/" + todayDate + "/?format=json";

            url = form1.CreateURL();

            Assert.AreEqual(expectedUrl, url);
        }

        //  ----------------------------------------------------------------
        //  ------------- Testing create URL from type course --------------
        //  ----------------------------------------------------------------

        [TestMethod]
        public void TestEqCreateUrlUsdWeekBuySold()
        {
            form1.TableComboBox.SelectedItem = "buy/sold";
            form1.PeriodComboBox.Text = "1 week";
            form1.CurrencyComboBox1.Text = "USD";

            start = DateTime.Today.AddDays(-7);
            setDateToString();
            expectedUrl = "http://api.nbp.pl/api/exchangerates/rates/c/usd/" + startDate + "/" + todayDate + "/?format=json";

            url = form1.CreateURL();

            Assert.AreEqual(expectedUrl, url);
        }

        [TestMethod]
        public void TestEqCreateUrlUsdMonthAverage()
        {
            form1.TableComboBox.SelectedItem = "Avarage";
            form1.PeriodComboBox.Text = "1 month";
            form1.CurrencyComboBox1.Text = "USD";

            start = DateTime.Today.AddMonths(-1);
            setDateToString();
            expectedUrl = "http://api.nbp.pl/api/exchangerates/rates/a/usd/" + startDate + "/" + todayDate + "/?format=json";

            url = form1.CreateURL();

            Assert.AreEqual(expectedUrl, url);
        }

        //  ----------------------------------------------------------------
        //  ------------- Testing create URL from period time --------------
        //  ----------------------------------------------------------------

        [TestMethod]
        public void TestEqCreateUrlChfWeekBuySold()
        {
            form1.TableComboBox.SelectedItem = "buy/sold";
            form1.PeriodComboBox.Text = "1 week";
            form1.CurrencyComboBox1.Text = "CHF";

            start = DateTime.Today.AddDays(-7);
            setDateToString();
            expectedUrl = "http://api.nbp.pl/api/exchangerates/rates/c/chf/" + startDate + "/" + todayDate + "/?format=json";

            url = form1.CreateURL();

            Assert.AreEqual(expectedUrl, url);
        }

        [TestMethod]
        public void TestEqCreateUrlChfTwoWeeksBuySold()
        {
            form1.TableComboBox.SelectedItem = "buy/sold";
            form1.PeriodComboBox.Text = "2 weeks";
            form1.CurrencyComboBox1.Text = "CHF";

            start = DateTime.Today.AddDays(-14);
            setDateToString();
            expectedUrl = "http://api.nbp.pl/api/exchangerates/rates/c/chf/" + startDate + "/" + todayDate + "/?format=json";

            url = form1.CreateURL();

            Assert.AreEqual(expectedUrl, url);
        }

        [TestMethod]
        public void TestEqCreateUrlChfMonthBuySold()
        {
            form1.TableComboBox.SelectedItem = "buy/sold";
            form1.PeriodComboBox.Text = "1 month";
            form1.CurrencyComboBox1.Text = "CHF";

            start = DateTime.Today.AddMonths(-1);
            setDateToString();
            expectedUrl = "http://api.nbp.pl/api/exchangerates/rates/c/chf/" + startDate + "/" + todayDate + "/?format=json";

            url = form1.CreateURL();

            Assert.AreEqual(expectedUrl, url);
        }

        [TestMethod]
        public void TestEqCreateUrlChfThreeMonthsBuySold()
        {
            form1.TableComboBox.SelectedItem = "buy/sold";
            form1.PeriodComboBox.Text = "3 months";
            form1.CurrencyComboBox1.Text = "CHF";

            start = DateTime.Today.AddMonths(-3);
            setDateToString();
            expectedUrl = "http://api.nbp.pl/api/exchangerates/rates/c/chf/" + startDate + "/" + todayDate + "/?format=json";

            url = form1.CreateURL();

            Assert.AreEqual(expectedUrl, url);
        }

        [TestMethod]
        public void TestEqCreateUrlChfSixMonthsBuySold()
        {
            form1.TableComboBox.SelectedItem = "buy/sold";
            form1.PeriodComboBox.Text = "6 months";
            form1.CurrencyComboBox1.Text = "CHF";

            start = DateTime.Today.AddMonths(-6);
            setDateToString();
            expectedUrl = "http://api.nbp.pl/api/exchangerates/rates/c/chf/" + startDate + "/" + todayDate + "/?format=json";

            url = form1.CreateURL();

            Assert.AreEqual(expectedUrl, url);
        }

        [TestMethod]
        public void TestEqCreateUrlChfYearBuySold()
        {
            form1.TableComboBox.SelectedItem = "buy/sold";
            form1.PeriodComboBox.Text = "1 year";
            form1.CurrencyComboBox1.Text = "CHF";

            start = DateTime.Today.AddYears(-1);
            setDateToString();
            expectedUrl = "http://api.nbp.pl/api/exchangerates/rates/c/chf/" + startDate + "/" + todayDate + "/?format=json";

            url = form1.CreateURL();

            Assert.AreEqual(expectedUrl, url);
        }

        //  ----------------------------------------------------------------
        //  ----------------------- Testing dominante ----------------------
        //  ----------------------------------------------------------------

        [TestMethod]
        public void TestEqDominanteIntegerEven()
        {
            List<double> listToDominante = new List<double> { 1, 2, 3, 2, 2, 1 };
            double expectedDominante = 2;
            double resultDominante;

            resultDominante = form1.getDominant(listToDominante);

            Assert.AreEqual(expectedDominante, resultDominante);
        }

        [TestMethod]
        public void TestEqDominanteIntegerOdd()
        {
            List<double> listToDominante = new List<double> { 1, 2, 3, 2, 2, 1, 5 };
            double expectedDominante = 2;
            double resultDominante;

            resultDominante = form1.getDominant(listToDominante);

            Assert.AreEqual(expectedDominante, resultDominante);
        }

        [TestMethod]
        public void TestEqDominanteIntegerOddOnes()
        {
            List<double> listToDominante = new List<double> { 1, 1, 1, 1, 1, 1, 1 };
            double expectedDominante = 1;
            double resultDominante;

            resultDominante = form1.getDominant(listToDominante);

            Assert.AreEqual(expectedDominante, resultDominante);
        }

        [TestMethod]
        public void TestEqDominanteIntegerZeros()
        {
            List<double> listToDominante = new List<double> { 0, 0, 0, 0, 0, 0 };
            double expectedDominante = 0;
            double resultDominante;

            resultDominante = form1.getDominant(listToDominante);

            Assert.AreEqual(expectedDominante, resultDominante);
        }

        [TestMethod]
        public void TestEqDominanteDouble()
        {
            List<double> listToDominante = new List<double> { 1.21, 1.21, 2.03, 0.08 };
            double expectedDominante = 1.21;
            double resultDominante;

            resultDominante = form1.getDominant(listToDominante);

            Assert.AreEqual(expectedDominante, resultDominante);
        }

        [TestMethod]
        public void TestEqDominanteDoubleSameNumber()
        {
            List<double> listToDominante = new List<double> { 2.03, 2.03, 2.03, 2.03 };
            double expectedDominante = 2.03;
            double resultDominante;

            resultDominante = form1.getDominant(listToDominante);

            Assert.AreEqual(expectedDominante, resultDominante);
        }

        //  ----------------------------------------------------------------
        //  ------------------ Testing Standard Deviation ------------------
        //  ----------------------------------------------------------------

        [TestMethod]
        public void TestEqstDevZerosOdd()
        {
            List<double> listToStDev = new List<double> { 0, 0, 0, 0, 0, 0, 0 };
            double expectedStDev = 0;
            double resultStDev;

            resultStDev = form1.getStandardDeviation(listToStDev);

            Assert.AreEqual(expectedStDev, resultStDev);
        }

        [TestMethod]
        public void TestEqstDevZerosEven()
        {
            List<double> listToStDev = new List<double> { 0, 0, 0, 0, 0, 0 };
            double expectedStDev = 0;
            double resultStDev;

            resultStDev = form1.getStandardDeviation(listToStDev);

            Assert.AreEqual(expectedStDev, resultStDev);
        }

        [TestMethod]
        public void TestEqstDevOnesEven()
        {
            List<double> listToStDev = new List<double> { 1, 1, 1, 1, 1, 1 };
            double expectedStDev = 0;
            double resultStDev;

            resultStDev = form1.getStandardDeviation(listToStDev);

            Assert.AreEqual(expectedStDev, resultStDev);
        }

        [TestMethod]
        public void TestEqstDevOnesOdd()
        {
            List<double> listToStDev = new List<double> { 1, 1, 1, 1, 1, 1, 1 };
            double expectedStDev = 0;
            double resultStDev;

            resultStDev = form1.getStandardDeviation(listToStDev);

            Assert.AreEqual(expectedStDev, resultStDev);
        }

        // <=<=<=<=<=<=<=<=<=<=<=<=<=<=<=<=<= Developer must correct formula stDev
        // After correct write next tests to "getStandardDeviation"


        //  ----------------------------------------------------------------
        //  ----------------------- Testing variance -----------------------
        //  ----------------------------------------------------------------

        [TestMethod]
        public void TestEqVarianceZerosOdd()
        {
            List<double> listToStDev = new List<double> { 0, 0, 0, 0, 0, 0, 0 };
            double expectedVariance = 0;
            double resultVariance;

            resultVariance = form1.getVariance(listToStDev);

            Assert.AreEqual(expectedVariance, resultVariance);
        }

        [TestMethod]
        public void TestEqVarianceZerosEven()
        {
            List<double> listToStDev = new List<double> { 0, 0, 0, 0, 0, 0 };
            double expectedVariance = 0;
            double resultVariance;

            resultVariance = form1.getVariance(listToStDev);

            Assert.AreEqual(expectedVariance, resultVariance);
        }

        [TestMethod]
        public void TestEqVarianceOnesOdd()
        {
            List<double> listToStDev = new List<double> { 1, 1, 1, 1, 1, 1, 1 };
            double expectedVariance = 0;
            double resultVariance;

            resultVariance = form1.getVariance(listToStDev);

            Assert.AreEqual(expectedVariance, resultVariance);
        }

        [TestMethod]
        public void TestEqVarianceOnesEven()
        {
            List<double> listToStDev = new List<double> { 1, 1, 1, 1, 1, 1 };
            double expectedVariance = 0;
            double resultVariance;

            resultVariance = form1.getVariance(listToStDev);

            Assert.AreEqual(expectedVariance, resultVariance);
        }

        // <=<=<=<=<=<=<=<=<=<=<=<=<=<=<=<=<= Developer must correct formula variance
        // After correct write next tests to "getStandardDeviation"


        public void setDateToString()
        {
            startDate = start.Year.ToString() + "-" + ((start.Month < 10) ? "0"
                + start.Month.ToString() : start.Month.ToString()) + "-"
                + ((start.Day < 10) ? "0" + start.Day.ToString() : start.Day.ToString());
            todayDate = today.Year.ToString() + "-" + ((today.Month < 10) ? "0"
                + today.Month.ToString() : today.Month.ToString()) + "-"
                + ((today.Day < 10) ? "0" + today.Day.ToString() : today.Day.ToString());
        }
    }
}
