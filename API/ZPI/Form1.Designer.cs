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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableListBox = new System.Windows.Forms.ListBox();
            this.tableLabel = new System.Windows.Forms.Label();
            this.periodLabel = new System.Windows.Forms.Label();
            this.periodListBox = new System.Windows.Forms.ListBox();
            this.currencyLabel1 = new System.Windows.Forms.Label();
            this.currencyListBox1 = new System.Windows.Forms.ListBox();
            this.currencyLabel2 = new System.Windows.Forms.Label();
            this.currencyListBox2 = new System.Windows.Forms.ListBox();
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
            // tableListBox
            // 
            this.tableListBox.FormattingEnabled = true;
            this.tableListBox.Location = new System.Drawing.Point(120, 70);
            this.tableListBox.Name = "tableListBox";
            this.tableListBox.Size = new System.Drawing.Size(90, 30);
            this.tableListBox.TabIndex = 0;
            // 
            // tableLabel
            // 
            this.tableLabel.AutoSize = true;
            this.tableLabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLabel.Location = new System.Drawing.Point(10, 70);
            this.tableLabel.Name = "tableLabel";
            this.tableLabel.Size = new System.Drawing.Size(70, 24);
            this.tableLabel.TabIndex = 1;
            this.tableLabel.Text = "Table";
            // 
            // periodLabel
            // 
            this.periodLabel.AutoSize = true;
            this.periodLabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.periodLabel.Location = new System.Drawing.Point(10, 110);
            this.periodLabel.Name = "periodLabel";
            this.periodLabel.Size = new System.Drawing.Size(82, 24);
            this.periodLabel.TabIndex = 3;
            this.periodLabel.Text = "Period";
            // 
            // periodListBox
            // 
            this.periodListBox.FormattingEnabled = true;
            this.periodListBox.Location = new System.Drawing.Point(120, 110);
            this.periodListBox.Name = "periodListBox";
            this.periodListBox.Size = new System.Drawing.Size(90, 30);
            this.periodListBox.TabIndex = 2;
            // 
            // currencyLabel1
            // 
            this.currencyLabel1.AutoSize = true;
            this.currencyLabel1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currencyLabel1.Location = new System.Drawing.Point(10, 190);
            this.currencyLabel1.Name = "currencyLabel1";
            this.currencyLabel1.Size = new System.Drawing.Size(106, 24);
            this.currencyLabel1.TabIndex = 7;
            this.currencyLabel1.Text = "Currency";
            // 
            // currencyListBox1
            // 
            this.currencyListBox1.FormattingEnabled = true;
            this.currencyListBox1.Location = new System.Drawing.Point(120, 190);
            this.currencyListBox1.Name = "currencyListBox1";
            this.currencyListBox1.Size = new System.Drawing.Size(90, 30);
            this.currencyListBox1.TabIndex = 6;
            // 
            // currencyLabel2
            // 
            this.currencyLabel2.AutoSize = true;
            this.currencyLabel2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currencyLabel2.Location = new System.Drawing.Point(10, 230);
            this.currencyLabel2.Name = "currencyLabel2";
            this.currencyLabel2.Size = new System.Drawing.Size(106, 24);
            this.currencyLabel2.TabIndex = 9;
            this.currencyLabel2.Text = "Currency";
            // 
            // currencyListBox2
            // 
            this.currencyListBox2.FormattingEnabled = true;
            this.currencyListBox2.Location = new System.Drawing.Point(120, 230);
            this.currencyListBox2.Name = "currencyListBox2";
            this.currencyListBox2.Size = new System.Drawing.Size(90, 30);
            this.currencyListBox2.TabIndex = 8;
            // 
            // executeButton
            // 
            this.executeButton.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.executeButton.Location = new System.Drawing.Point(10, 10);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(200, 50);
            this.executeButton.TabIndex = 10;
            this.executeButton.Text = "Execute";
            this.executeButton.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(220, 10);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(571, 425);
            this.chart1.TabIndex = 11;
            this.chart1.Text = "chart1";
            // 
            // medianLabel
            // 
            this.medianLabel.AutoSize = true;
            this.medianLabel.Location = new System.Drawing.Point(220, 440);
            this.medianLabel.Name = "medianLabel";
            this.medianLabel.Size = new System.Drawing.Size(48, 13);
            this.medianLabel.TabIndex = 12;
            this.medianLabel.Text = "Median: ";
            // 
            // medianValue
            // 
            this.medianValue.AutoSize = true;
            this.medianValue.Location = new System.Drawing.Point(260, 440);
            this.medianValue.Name = "medianValue";
            this.medianValue.Size = new System.Drawing.Size(13, 13);
            this.medianValue.TabIndex = 13;
            this.medianValue.Text = "0";
            // 
            // dominantLable
            // 
            this.dominantLable.AutoSize = true;
            this.dominantLable.Location = new System.Drawing.Point(340, 440);
            this.dominantLable.Name = "dominantLable";
            this.dominantLable.Size = new System.Drawing.Size(58, 13);
            this.dominantLable.TabIndex = 14;
            this.dominantLable.Text = "Dominant: ";
            // 
            // dominantValue
            // 
            this.dominantValue.AutoSize = true;
            this.dominantValue.Location = new System.Drawing.Point(390, 440);
            this.dominantValue.Name = "dominantValue";
            this.dominantValue.Size = new System.Drawing.Size(13, 13);
            this.dominantValue.TabIndex = 15;
            this.dominantValue.Text = "0";
            // 
            // standardDeviationLabel
            // 
            this.standardDeviationLabel.AutoSize = true;
            this.standardDeviationLabel.Location = new System.Drawing.Point(450, 440);
            this.standardDeviationLabel.Name = "standardDeviationLabel";
            this.standardDeviationLabel.Size = new System.Drawing.Size(104, 13);
            this.standardDeviationLabel.TabIndex = 16;
            this.standardDeviationLabel.Text = "Standard Deviation: ";
            // 
            // standardDeviationValue
            // 
            this.standardDeviationValue.AutoSize = true;
            this.standardDeviationValue.Location = new System.Drawing.Point(550, 440);
            this.standardDeviationValue.Name = "standardDeviationValue";
            this.standardDeviationValue.Size = new System.Drawing.Size(13, 13);
            this.standardDeviationValue.TabIndex = 17;
            this.standardDeviationValue.Text = "0";
            // 
            // variationLabel
            // 
            this.variationLabel.AutoSize = true;
            this.variationLabel.Location = new System.Drawing.Point(600, 440);
            this.variationLabel.Name = "variationLabel";
            this.variationLabel.Size = new System.Drawing.Size(54, 13);
            this.variationLabel.TabIndex = 18;
            this.variationLabel.Text = "Variation: ";
            // 
            // variationValue
            // 
            this.variationValue.AutoSize = true;
            this.variationValue.Location = new System.Drawing.Point(650, 440);
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
            this.Controls.Add(this.currencyListBox2);
            this.Controls.Add(this.currencyLabel1);
            this.Controls.Add(this.currencyListBox1);
            this.Controls.Add(this.periodLabel);
            this.Controls.Add(this.periodListBox);
            this.Controls.Add(this.tableLabel);
            this.Controls.Add(this.tableListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox tableListBox;
        private System.Windows.Forms.Label tableLabel;
        private System.Windows.Forms.Label periodLabel;
        private System.Windows.Forms.ListBox periodListBox;
        private System.Windows.Forms.Label currencyLabel1;
        private System.Windows.Forms.ListBox currencyListBox1;
        private System.Windows.Forms.Label currencyLabel2;
        private System.Windows.Forms.ListBox currencyListBox2;
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

