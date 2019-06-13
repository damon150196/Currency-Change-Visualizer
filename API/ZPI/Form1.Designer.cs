using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ZPI
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableComboBox = new System.Windows.Forms.ComboBox();
            this.tableLabel = new System.Windows.Forms.Label();
            this.periodLabel = new System.Windows.Forms.Label();
            this.periodComboBox = new System.Windows.Forms.ComboBox();
            this.currencyLabel1 = new System.Windows.Forms.Label();
            this.currencyComboBox1 = new System.Windows.Forms.ComboBox();
            this.currencyLabel2 = new System.Windows.Forms.Label();
            this.currencyComboBox2 = new System.Windows.Forms.ComboBox();
            this.executeButton = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.medianLabel = new System.Windows.Forms.Label();
            this.medianValue = new System.Windows.Forms.Label();
            this.dominantLable = new System.Windows.Forms.Label();
            this.dominantValue = new System.Windows.Forms.Label();
            this.standardDeviationLabel = new System.Windows.Forms.Label();
            this.standardDeviationValue = new System.Windows.Forms.Label();
            this.variationLabel = new System.Windows.Forms.Label();
            this.variationValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableComboBox
            // 
            this.tableComboBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableComboBox.FormattingEnabled = true;
            this.tableComboBox.ItemHeight = 19;
            this.tableComboBox.Items.AddRange(new object[] {
            "Avarage",
            "buy/sold"});
            this.tableComboBox.Location = new System.Drawing.Point(120, 66);
            this.tableComboBox.Name = "tableComboBox";
            this.tableComboBox.Size = new System.Drawing.Size(140, 27);
            this.tableComboBox.TabIndex = 0;
            this.tableComboBox.SelectedIndexChanged += new System.EventHandler(this.tableListBox_SelectedIndexChanged);
            this.tableComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            // 
            // tableLabel
            // 
            this.tableLabel.AutoSize = true;
            this.tableLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLabel.Location = new System.Drawing.Point(10, 70);
            this.tableLabel.Name = "tableLabel";
            this.tableLabel.Size = new System.Drawing.Size(63, 19);
            this.tableLabel.TabIndex = 1;
            this.tableLabel.Text = "Course";
            // 
            // periodLabel
            // 
            this.periodLabel.AutoSize = true;
            this.periodLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.periodLabel.Location = new System.Drawing.Point(10, 110);
            this.periodLabel.Name = "periodLabel";
            this.periodLabel.Size = new System.Drawing.Size(63, 19);
            this.periodLabel.TabIndex = 3;
            this.periodLabel.Text = "Period";
            // 
            // periodComboBox
            // 
            this.periodComboBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.periodComboBox.FormattingEnabled = true;
            this.periodComboBox.ItemHeight = 19;
            this.periodComboBox.Items.AddRange(new object[] {
            "1 week",
            "2 weeks",
            "1 month",
            "3 months",
            "6 months",
            "1 year"});
            this.periodComboBox.Location = new System.Drawing.Point(120, 110);
            this.periodComboBox.Name = "periodComboBox";
            this.periodComboBox.Size = new System.Drawing.Size(140, 27);
            this.periodComboBox.TabIndex = 2;
            this.periodComboBox.SelectedIndexChanged += new System.EventHandler(this.periodListBox_SelectedIndexChanged);
            this.periodComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            // 
            // currencyLabel1
            // 
            this.currencyLabel1.AutoSize = true;
            this.currencyLabel1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currencyLabel1.Location = new System.Drawing.Point(10, 190);
            this.currencyLabel1.Name = "currencyLabel1";
            this.currencyLabel1.Size = new System.Drawing.Size(81, 19);
            this.currencyLabel1.TabIndex = 7;
            this.currencyLabel1.Text = "Currency";
            // 
            // currencyComboBox1
            // 
            this.currencyComboBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currencyComboBox1.FormattingEnabled = true;
            this.currencyComboBox1.ItemHeight = 19;
            this.currencyComboBox1.Items.AddRange(new object[] {
            "USD",
            "EUR",
            "JPY",
            "GBP",
            "AUD",
            "CHF",
            "CAD",
            "MXN",
            "CNY",
            "PLN"});
            this.currencyComboBox1.Location = new System.Drawing.Point(120, 190);
            this.currencyComboBox1.Name = "currencyComboBox1";
            this.currencyComboBox1.Size = new System.Drawing.Size(140, 27);
            this.currencyComboBox1.TabIndex = 6;
            this.currencyComboBox1.UseWaitCursor = true;
            this.currencyComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            // 
            // currencyLabel2
            // 
            this.currencyLabel2.AutoSize = true;
            this.currencyLabel2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currencyLabel2.Location = new System.Drawing.Point(10, 230);
            this.currencyLabel2.Name = "currencyLabel2";
            this.currencyLabel2.Size = new System.Drawing.Size(81, 19);
            this.currencyLabel2.TabIndex = 9;
            this.currencyLabel2.Text = "Currency";
            this.currencyLabel2.Visible = false;
            // 
            // currencyComboBox2
            // 
            this.currencyComboBox2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currencyComboBox2.FormattingEnabled = true;
            this.currencyComboBox2.ItemHeight = 19;
            this.currencyComboBox2.Items.AddRange(new object[] {
            "USD",
            "EUR",
            "JPY",
            "GBP",
            "AUD",
            "CHF",
            "CAD",
            "MXN",
            "CNY",
            "PLN"});
            this.currencyComboBox2.Location = new System.Drawing.Point(120, 230);
            this.currencyComboBox2.Name = "currencyComboBox2";
            this.currencyComboBox2.Size = new System.Drawing.Size(140, 27);
            this.currencyComboBox2.TabIndex = 8;
            this.currencyComboBox2.Visible = false;
            this.currencyComboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            // 
            // executeButton
            // 
            this.executeButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.executeButton.Location = new System.Drawing.Point(10, 10);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(200, 50);
            this.executeButton.TabIndex = 10;
            this.executeButton.Text = "Execute";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(270, 10);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(521, 425);
            this.chart1.TabIndex = 11;
            this.chart1.Text = "chart1";
            // 
            // medianLabel
            // 
            this.medianLabel.AutoSize = true;
            this.medianLabel.Location = new System.Drawing.Point(267, 441);
            this.medianLabel.Name = "medianLabel";
            this.medianLabel.Size = new System.Drawing.Size(48, 13);
            this.medianLabel.TabIndex = 12;
            this.medianLabel.Text = "Median: ";
            // 
            // medianValue
            // 
            this.medianValue.AutoSize = true;
            this.medianValue.Location = new System.Drawing.Point(307, 441);
            this.medianValue.Name = "medianValue";
            this.medianValue.Size = new System.Drawing.Size(13, 13);
            this.medianValue.TabIndex = 13;
            this.medianValue.Text = "0";
            // 
            // dominantLable
            // 
            this.dominantLable.AutoSize = true;
            this.dominantLable.Location = new System.Drawing.Point(387, 441);
            this.dominantLable.Name = "dominantLable";
            this.dominantLable.Size = new System.Drawing.Size(58, 13);
            this.dominantLable.TabIndex = 14;
            this.dominantLable.Text = "Dominant: ";
            // 
            // dominantValue
            // 
            this.dominantValue.AutoSize = true;
            this.dominantValue.Location = new System.Drawing.Point(437, 441);
            this.dominantValue.Name = "dominantValue";
            this.dominantValue.Size = new System.Drawing.Size(13, 13);
            this.dominantValue.TabIndex = 15;
            this.dominantValue.Text = "0";
            // 
            // standardDeviationLabel
            // 
            this.standardDeviationLabel.AutoSize = true;
            this.standardDeviationLabel.Location = new System.Drawing.Point(497, 441);
            this.standardDeviationLabel.Name = "standardDeviationLabel";
            this.standardDeviationLabel.Size = new System.Drawing.Size(104, 13);
            this.standardDeviationLabel.TabIndex = 16;
            this.standardDeviationLabel.Text = "Standard Deviation: ";
            // 
            // standardDeviationValue
            // 
            this.standardDeviationValue.AutoSize = true;
            this.standardDeviationValue.Location = new System.Drawing.Point(597, 441);
            this.standardDeviationValue.Name = "standardDeviationValue";
            this.standardDeviationValue.Size = new System.Drawing.Size(13, 13);
            this.standardDeviationValue.TabIndex = 17;
            this.standardDeviationValue.Text = "0";
            // 
            // variationLabel
            // 
            this.variationLabel.AutoSize = true;
            this.variationLabel.Location = new System.Drawing.Point(647, 441);
            this.variationLabel.Name = "variationLabel";
            this.variationLabel.Size = new System.Drawing.Size(54, 13);
            this.variationLabel.TabIndex = 18;
            this.variationLabel.Text = "Variation: ";
            // 
            // variationValue
            // 
            this.variationValue.AutoSize = true;
            this.variationValue.Location = new System.Drawing.Point(697, 441);
            this.variationValue.Name = "variationValue";
            this.variationValue.Size = new System.Drawing.Size(13, 13);
            this.variationValue.TabIndex = 19;
            this.variationValue.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.variationValue);
            this.Controls.Add(this.variationLabel);
            this.Controls.Add(this.standardDeviationValue);
            this.Controls.Add(this.standardDeviationLabel);
            this.Controls.Add(this.dominantValue);
            this.Controls.Add(this.dominantLable);
            this.Controls.Add(this.medianValue);
            this.Controls.Add(this.medianLabel);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this.currencyLabel2);
            this.Controls.Add(this.currencyComboBox2);
            this.Controls.Add(this.currencyLabel1);
            this.Controls.Add(this.currencyComboBox1);
            this.Controls.Add(this.periodLabel);
            this.Controls.Add(this.periodComboBox);
            this.Controls.Add(this.tableLabel);
            this.Controls.Add(this.tableComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox tableComboBox;
        private System.Windows.Forms.Label tableLabel;
        private System.Windows.Forms.Label periodLabel;
        private System.Windows.Forms.ComboBox periodComboBox;
        private System.Windows.Forms.Label currencyLabel1;
        private System.Windows.Forms.ComboBox currencyComboBox1;
        private System.Windows.Forms.Label currencyLabel2;
        private System.Windows.Forms.ComboBox currencyComboBox2;
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label medianLabel;
        private System.Windows.Forms.Label medianValue;
        private System.Windows.Forms.Label dominantLable;
        private System.Windows.Forms.Label dominantValue;
        private System.Windows.Forms.Label standardDeviationLabel;
        private System.Windows.Forms.Label standardDeviationValue;
        private System.Windows.Forms.Label variationLabel;
        private System.Windows.Forms.Label variationValue;
    }
}

