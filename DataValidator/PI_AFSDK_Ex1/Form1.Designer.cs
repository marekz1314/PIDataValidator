namespace PI_AFSDK_Ex1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.piSystemPicker1 = new OSIsoft.AF.UI.PISystemPicker();
            this.afDatabasePicker1 = new OSIsoft.AF.UI.AFDatabasePicker();
            this.afTreeView1 = new OSIsoft.AF.UI.AFTreeView();
            this.lbAttributes = new System.Windows.Forms.ListBox();
            this.tbStartTime = new System.Windows.Forms.TextBox();
            this.tbEndTime = new System.Windows.Forms.TextBox();
            this.btnGetData = new System.Windows.Forms.Button();
            this.lbValues = new System.Windows.Forms.ListBox();
            this.cbUOM = new System.Windows.Forms.ComboBox();
            this.lbStartTime = new System.Windows.Forms.Label();
            this.lbEndTime = new System.Windows.Forms.Label();
            this.lbUOM = new System.Windows.Forms.Label();
            this.tbHiLimit = new System.Windows.Forms.TextBox();
            this.lbHiLimit = new System.Windows.Forms.Label();
            this.lbLoLimit = new System.Windows.Forms.Label();
            this.tbLoLimit = new System.Windows.Forms.TextBox();
            this.btnShowQuestionableData = new System.Windows.Forms.Button();
            this.btnShowValidData = new System.Windows.Forms.Button();
            this.btnValidateData = new System.Windows.Forms.Button();
            this.btnClearValidation = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // piSystemPicker1
            // 
            this.piSystemPicker1.AccessibleDescription = "PI System Picker";
            this.piSystemPicker1.AccessibleName = "PI System Picker";
            this.piSystemPicker1.ConnectAutomatically = true;
            this.piSystemPicker1.Cursor = System.Windows.Forms.Cursors.Default;
            this.piSystemPicker1.Location = new System.Drawing.Point(13, 13);
            this.piSystemPicker1.LoginPromptSetting = OSIsoft.AF.UI.PISystemPicker.LoginPromptSettingOptions.Default;
            this.piSystemPicker1.Name = "piSystemPicker1";
            this.piSystemPicker1.ShowBegin = false;
            this.piSystemPicker1.ShowDelete = false;
            this.piSystemPicker1.ShowEnd = false;
            this.piSystemPicker1.ShowFind = false;
            this.piSystemPicker1.ShowList = false;
            this.piSystemPicker1.ShowNavigation = false;
            this.piSystemPicker1.ShowNew = false;
            this.piSystemPicker1.ShowNext = false;
            this.piSystemPicker1.ShowPrevious = false;
            this.piSystemPicker1.ShowProperties = false;
            this.piSystemPicker1.Size = new System.Drawing.Size(284, 22);
            this.piSystemPicker1.TabIndex = 0;
            // 
            // afDatabasePicker1
            // 
            this.afDatabasePicker1.AccessibleDescription = "Database Picker";
            this.afDatabasePicker1.AccessibleName = "Database Picker";
            this.afDatabasePicker1.Location = new System.Drawing.Point(13, 42);
            this.afDatabasePicker1.Name = "afDatabasePicker1";
            this.afDatabasePicker1.ShowBegin = false;
            this.afDatabasePicker1.ShowDelete = false;
            this.afDatabasePicker1.ShowEnd = false;
            this.afDatabasePicker1.ShowFind = false;
            this.afDatabasePicker1.ShowList = false;
            this.afDatabasePicker1.ShowNavigation = false;
            this.afDatabasePicker1.ShowNew = false;
            this.afDatabasePicker1.ShowNext = false;
            this.afDatabasePicker1.ShowPrevious = false;
            this.afDatabasePicker1.ShowProperties = false;
            this.afDatabasePicker1.Size = new System.Drawing.Size(284, 22);
            this.afDatabasePicker1.TabIndex = 1;
            this.afDatabasePicker1.SelectionChange += new OSIsoft.AF.UI.SelectionChangeEventHandler(this.afDatabasePicker1_SelectionChange);
            // 
            // afTreeView1
            // 
            this.afTreeView1.HideSelection = false;
            this.afTreeView1.Location = new System.Drawing.Point(13, 71);
            this.afTreeView1.Name = "afTreeView1";
            this.afTreeView1.ShowNodeToolTips = true;
            this.afTreeView1.Size = new System.Drawing.Size(284, 302);
            this.afTreeView1.TabIndex = 2;
            this.afTreeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.afTreeView1_AfterSelect);
            // 
            // lbAttributes
            // 
            this.lbAttributes.FormattingEnabled = true;
            this.lbAttributes.Location = new System.Drawing.Point(303, 13);
            this.lbAttributes.Name = "lbAttributes";
            this.lbAttributes.Size = new System.Drawing.Size(366, 121);
            this.lbAttributes.TabIndex = 3;
            this.lbAttributes.SelectedIndexChanged += new System.EventHandler(this.lbAttributes_SelectedIndexChanged);
            // 
            // tbStartTime
            // 
            this.tbStartTime.Location = new System.Drawing.Point(680, 28);
            this.tbStartTime.Name = "tbStartTime";
            this.tbStartTime.Size = new System.Drawing.Size(108, 20);
            this.tbStartTime.TabIndex = 4;
            this.tbStartTime.Text = "t-2d";
            this.tbStartTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbEndTime
            // 
            this.tbEndTime.Location = new System.Drawing.Point(680, 71);
            this.tbEndTime.Name = "tbEndTime";
            this.tbEndTime.Size = new System.Drawing.Size(108, 20);
            this.tbEndTime.TabIndex = 5;
            this.tbEndTime.Text = "t-1d";
            this.tbEndTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(680, 151);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(108, 23);
            this.btnGetData.TabIndex = 6;
            this.btnGetData.Text = "Show all values";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // lbValues
            // 
            this.lbValues.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbValues.FormattingEnabled = true;
            this.lbValues.Location = new System.Drawing.Point(303, 213);
            this.lbValues.Name = "lbValues";
            this.lbValues.Size = new System.Drawing.Size(485, 160);
            this.lbValues.TabIndex = 7;
            // 
            // cbUOM
            // 
            this.cbUOM.DisplayMember = "Abbreviation";
            this.cbUOM.FormattingEnabled = true;
            this.cbUOM.Location = new System.Drawing.Point(680, 113);
            this.cbUOM.Name = "cbUOM";
            this.cbUOM.Size = new System.Drawing.Size(108, 21);
            this.cbUOM.TabIndex = 8;
            // 
            // lbStartTime
            // 
            this.lbStartTime.AutoSize = true;
            this.lbStartTime.Location = new System.Drawing.Point(683, 13);
            this.lbStartTime.Name = "lbStartTime";
            this.lbStartTime.Size = new System.Drawing.Size(52, 13);
            this.lbStartTime.TabIndex = 9;
            this.lbStartTime.Text = "StartTime";
            // 
            // lbEndTime
            // 
            this.lbEndTime.AutoSize = true;
            this.lbEndTime.Location = new System.Drawing.Point(683, 55);
            this.lbEndTime.Name = "lbEndTime";
            this.lbEndTime.Size = new System.Drawing.Size(49, 13);
            this.lbEndTime.TabIndex = 10;
            this.lbEndTime.Text = "EndTime";
            // 
            // lbUOM
            // 
            this.lbUOM.AutoSize = true;
            this.lbUOM.Location = new System.Drawing.Point(683, 97);
            this.lbUOM.Name = "lbUOM";
            this.lbUOM.Size = new System.Drawing.Size(26, 13);
            this.lbUOM.TabIndex = 11;
            this.lbUOM.Text = "Unit";
            // 
            // tbHiLimit
            // 
            this.tbHiLimit.Location = new System.Drawing.Point(410, 152);
            this.tbHiLimit.Name = "tbHiLimit";
            this.tbHiLimit.Size = new System.Drawing.Size(100, 20);
            this.tbHiLimit.TabIndex = 12;
            this.tbHiLimit.Text = "900";
            this.tbHiLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbHiLimit
            // 
            this.lbHiLimit.AutoSize = true;
            this.lbHiLimit.Location = new System.Drawing.Point(410, 136);
            this.lbHiLimit.Name = "lbHiLimit";
            this.lbHiLimit.Size = new System.Drawing.Size(41, 13);
            this.lbHiLimit.TabIndex = 13;
            this.lbHiLimit.Text = "Hi Limit";
            // 
            // lbLoLimit
            // 
            this.lbLoLimit.AutoSize = true;
            this.lbLoLimit.Location = new System.Drawing.Point(304, 136);
            this.lbLoLimit.Name = "lbLoLimit";
            this.lbLoLimit.Size = new System.Drawing.Size(43, 13);
            this.lbLoLimit.TabIndex = 15;
            this.lbLoLimit.Text = "Lo Limit";
            // 
            // tbLoLimit
            // 
            this.tbLoLimit.Location = new System.Drawing.Point(304, 152);
            this.tbLoLimit.Name = "tbLoLimit";
            this.tbLoLimit.Size = new System.Drawing.Size(100, 20);
            this.tbLoLimit.TabIndex = 14;
            this.tbLoLimit.Text = "0";
            this.tbLoLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnShowQuestionableData
            // 
            this.btnShowQuestionableData.Location = new System.Drawing.Point(516, 152);
            this.btnShowQuestionableData.Name = "btnShowQuestionableData";
            this.btnShowQuestionableData.Size = new System.Drawing.Size(108, 23);
            this.btnShowQuestionableData.TabIndex = 16;
            this.btnShowQuestionableData.Text = "Show Questionable";
            this.btnShowQuestionableData.UseVisualStyleBackColor = true;
            this.btnShowQuestionableData.Click += new System.EventHandler(this.btnShowQuestionableData_Click);
            // 
            // btnShowValidData
            // 
            this.btnShowValidData.Location = new System.Drawing.Point(516, 180);
            this.btnShowValidData.Name = "btnShowValidData";
            this.btnShowValidData.Size = new System.Drawing.Size(108, 23);
            this.btnShowValidData.TabIndex = 17;
            this.btnShowValidData.Text = "Show Valid";
            this.btnShowValidData.UseVisualStyleBackColor = true;
            this.btnShowValidData.Click += new System.EventHandler(this.btnShowValidData_Click);
            // 
            // btnValidateData
            // 
            this.btnValidateData.Location = new System.Drawing.Point(303, 180);
            this.btnValidateData.Name = "btnValidateData";
            this.btnValidateData.Size = new System.Drawing.Size(101, 23);
            this.btnValidateData.TabIndex = 18;
            this.btnValidateData.Text = "Validate Data";
            this.btnValidateData.UseVisualStyleBackColor = true;
            this.btnValidateData.Click += new System.EventHandler(this.btnValidateData_Click);
            // 
            // btnClearValidation
            // 
            this.btnClearValidation.Location = new System.Drawing.Point(413, 180);
            this.btnClearValidation.Name = "btnClearValidation";
            this.btnClearValidation.Size = new System.Drawing.Size(97, 23);
            this.btnClearValidation.TabIndex = 19;
            this.btnClearValidation.Text = "Clear Validation";
            this.btnClearValidation.UseVisualStyleBackColor = true;
            this.btnClearValidation.Click += new System.EventHandler(this.btnClearValidation_Click);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 379);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.EmptyPointStyle.MarkerSize = 6;
            series1.EmptyPointStyle.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Legend = "Legend1";
            series1.MarkerSize = 6;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(775, 250);
            this.chart1.TabIndex = 20;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 641);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnClearValidation);
            this.Controls.Add(this.btnValidateData);
            this.Controls.Add(this.btnShowValidData);
            this.Controls.Add(this.btnShowQuestionableData);
            this.Controls.Add(this.lbLoLimit);
            this.Controls.Add(this.tbLoLimit);
            this.Controls.Add(this.lbHiLimit);
            this.Controls.Add(this.tbHiLimit);
            this.Controls.Add(this.lbUOM);
            this.Controls.Add(this.lbEndTime);
            this.Controls.Add(this.lbStartTime);
            this.Controls.Add(this.cbUOM);
            this.Controls.Add(this.lbValues);
            this.Controls.Add(this.btnGetData);
            this.Controls.Add(this.tbEndTime);
            this.Controls.Add(this.tbStartTime);
            this.Controls.Add(this.lbAttributes);
            this.Controls.Add(this.afTreeView1);
            this.Controls.Add(this.afDatabasePicker1);
            this.Controls.Add(this.piSystemPicker1);
            this.Name = "Form1";
            this.Text = "Data Validation Tool";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OSIsoft.AF.UI.PISystemPicker piSystemPicker1;
        private OSIsoft.AF.UI.AFDatabasePicker afDatabasePicker1;
        private OSIsoft.AF.UI.AFTreeView afTreeView1;
        private System.Windows.Forms.ListBox lbAttributes;
        private System.Windows.Forms.TextBox tbStartTime;
        private System.Windows.Forms.TextBox tbEndTime;
        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.ListBox lbValues;
        private System.Windows.Forms.ComboBox cbUOM;
        private System.Windows.Forms.Label lbStartTime;
        private System.Windows.Forms.Label lbEndTime;
        private System.Windows.Forms.Label lbUOM;
        private System.Windows.Forms.TextBox tbHiLimit;
        private System.Windows.Forms.Label lbHiLimit;
        private System.Windows.Forms.Label lbLoLimit;
        private System.Windows.Forms.TextBox tbLoLimit;
        private System.Windows.Forms.Button btnShowQuestionableData;
        private System.Windows.Forms.Button btnShowValidData;
        private System.Windows.Forms.Button btnValidateData;
        private System.Windows.Forms.Button btnClearValidation;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

