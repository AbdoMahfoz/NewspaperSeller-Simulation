namespace NewspaperSellerSimulation
{
    partial class MainForm
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
            this.NumberOfNewspapersLabel = new System.Windows.Forms.Label();
            this.NumberOfRecordsLabel = new System.Windows.Forms.Label();
            this.PurchasePriceLabel = new System.Windows.Forms.Label();
            this.ScrapPriceLabel = new System.Windows.Forms.Label();
            this.SellingPriceLabel = new System.Windows.Forms.Label();
            this.DayTypeLabel = new System.Windows.Forms.Label();
            this.NumOfNewsPapers = new System.Windows.Forms.NumericUpDown();
            this.NumofRecords = new System.Windows.Forms.NumericUpDown();
            this.PurchasePrice = new System.Windows.Forms.NumericUpDown();
            this.ScrapPrice = new System.Windows.Forms.NumericUpDown();
            this.SellingPrice = new System.Windows.Forms.NumericUpDown();
            this.GoodProbabilityLabel = new System.Windows.Forms.Label();
            this.FairProbabiltyLabel = new System.Windows.Forms.Label();
            this.PoorProbabilityLabel = new System.Windows.Forms.Label();
            this.GoodProbability = new System.Windows.Forms.NumericUpDown();
            this.FairProbability = new System.Windows.Forms.NumericUpDown();
            this.PoorProbabilty = new System.Windows.Forms.NumericUpDown();
            this.DemandDistributionGrid = new System.Windows.Forms.DataGridView();
            this.StartSimulationButton = new System.Windows.Forms.Button();
            this.AutomaticTestingButton = new System.Windows.Forms.Button();
            this.LoadFromFileButton = new System.Windows.Forms.Button();
            this.ExportToFileButton = new System.Windows.Forms.Button();
            this.Demand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fairP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poorP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.NumOfNewsPapers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumofRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PurchasePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScrapPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellingPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoodProbability)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FairProbability)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PoorProbabilty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DemandDistributionGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // NumberOfNewspapersLabel
            // 
            this.NumberOfNewspapersLabel.AutoSize = true;
            this.NumberOfNewspapersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfNewspapersLabel.Location = new System.Drawing.Point(67, 136);
            this.NumberOfNewspapersLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NumberOfNewspapersLabel.Name = "NumberOfNewspapersLabel";
            this.NumberOfNewspapersLabel.Size = new System.Drawing.Size(200, 18);
            this.NumberOfNewspapersLabel.TabIndex = 0;
            this.NumberOfNewspapersLabel.Text = "Number of Newspapers : ";
            // 
            // NumberOfRecordsLabel
            // 
            this.NumberOfRecordsLabel.AutoSize = true;
            this.NumberOfRecordsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfRecordsLabel.Location = new System.Drawing.Point(67, 159);
            this.NumberOfRecordsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NumberOfRecordsLabel.Name = "NumberOfRecordsLabel";
            this.NumberOfRecordsLabel.Size = new System.Drawing.Size(171, 18);
            this.NumberOfRecordsLabel.TabIndex = 1;
            this.NumberOfRecordsLabel.Text = "Number of Records : ";
            // 
            // PurchasePriceLabel
            // 
            this.PurchasePriceLabel.AutoSize = true;
            this.PurchasePriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchasePriceLabel.Location = new System.Drawing.Point(67, 183);
            this.PurchasePriceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PurchasePriceLabel.Name = "PurchasePriceLabel";
            this.PurchasePriceLabel.Size = new System.Drawing.Size(138, 18);
            this.PurchasePriceLabel.TabIndex = 2;
            this.PurchasePriceLabel.Text = "Purchase Price : ";
            // 
            // ScrapPriceLabel
            // 
            this.ScrapPriceLabel.AutoSize = true;
            this.ScrapPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScrapPriceLabel.Location = new System.Drawing.Point(67, 206);
            this.ScrapPriceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ScrapPriceLabel.Name = "ScrapPriceLabel";
            this.ScrapPriceLabel.Size = new System.Drawing.Size(111, 18);
            this.ScrapPriceLabel.TabIndex = 3;
            this.ScrapPriceLabel.Text = "Scrap Price : ";
            // 
            // SellingPriceLabel
            // 
            this.SellingPriceLabel.AutoSize = true;
            this.SellingPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellingPriceLabel.Location = new System.Drawing.Point(67, 231);
            this.SellingPriceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SellingPriceLabel.Name = "SellingPriceLabel";
            this.SellingPriceLabel.Size = new System.Drawing.Size(117, 18);
            this.SellingPriceLabel.TabIndex = 4;
            this.SellingPriceLabel.Text = "Selling Price : ";
            this.SellingPriceLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DayTypeLabel
            // 
            this.DayTypeLabel.AutoSize = true;
            this.DayTypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.DayTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DayTypeLabel.Location = new System.Drawing.Point(67, 268);
            this.DayTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DayTypeLabel.Name = "DayTypeLabel";
            this.DayTypeLabel.Size = new System.Drawing.Size(193, 18);
            this.DayTypeLabel.TabIndex = 5;
            this.DayTypeLabel.Text = "Day Type Distributions : ";
            // 
            // NumOfNewsPapers
            // 
            this.NumOfNewsPapers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumOfNewsPapers.Location = new System.Drawing.Point(259, 136);
            this.NumOfNewsPapers.Margin = new System.Windows.Forms.Padding(2);
            this.NumOfNewsPapers.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.NumOfNewsPapers.Name = "NumOfNewsPapers";
            this.NumOfNewsPapers.Size = new System.Drawing.Size(51, 23);
            this.NumOfNewsPapers.TabIndex = 6;
            // 
            // NumofRecords
            // 
            this.NumofRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumofRecords.Location = new System.Drawing.Point(259, 159);
            this.NumofRecords.Margin = new System.Windows.Forms.Padding(2);
            this.NumofRecords.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.NumofRecords.Name = "NumofRecords";
            this.NumofRecords.Size = new System.Drawing.Size(51, 23);
            this.NumofRecords.TabIndex = 7;
            // 
            // PurchasePrice
            // 
            this.PurchasePrice.DecimalPlaces = 2;
            this.PurchasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchasePrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.PurchasePrice.Location = new System.Drawing.Point(259, 180);
            this.PurchasePrice.Margin = new System.Windows.Forms.Padding(2);
            this.PurchasePrice.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.PurchasePrice.Name = "PurchasePrice";
            this.PurchasePrice.Size = new System.Drawing.Size(51, 23);
            this.PurchasePrice.TabIndex = 8;
            // 
            // ScrapPrice
            // 
            this.ScrapPrice.DecimalPlaces = 2;
            this.ScrapPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScrapPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ScrapPrice.Location = new System.Drawing.Point(259, 203);
            this.ScrapPrice.Margin = new System.Windows.Forms.Padding(2);
            this.ScrapPrice.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.ScrapPrice.Name = "ScrapPrice";
            this.ScrapPrice.Size = new System.Drawing.Size(51, 23);
            this.ScrapPrice.TabIndex = 9;
            // 
            // SellingPrice
            // 
            this.SellingPrice.DecimalPlaces = 2;
            this.SellingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellingPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.SellingPrice.Location = new System.Drawing.Point(259, 227);
            this.SellingPrice.Margin = new System.Windows.Forms.Padding(2);
            this.SellingPrice.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.SellingPrice.Name = "SellingPrice";
            this.SellingPrice.Size = new System.Drawing.Size(50, 23);
            this.SellingPrice.TabIndex = 10;
            // 
            // GoodProbabilityLabel
            // 
            this.GoodProbabilityLabel.AutoSize = true;
            this.GoodProbabilityLabel.BackColor = System.Drawing.Color.Transparent;
            this.GoodProbabilityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoodProbabilityLabel.Location = new System.Drawing.Point(88, 294);
            this.GoodProbabilityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GoodProbabilityLabel.Name = "GoodProbabilityLabel";
            this.GoodProbabilityLabel.Size = new System.Drawing.Size(154, 17);
            this.GoodProbabilityLabel.TabIndex = 11;
            this.GoodProbabilityLabel.Text = "Good Day Probability : ";
            // 
            // FairProbabiltyLabel
            // 
            this.FairProbabiltyLabel.AutoSize = true;
            this.FairProbabiltyLabel.BackColor = System.Drawing.Color.Transparent;
            this.FairProbabiltyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FairProbabiltyLabel.Location = new System.Drawing.Point(295, 292);
            this.FairProbabiltyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FairProbabiltyLabel.Name = "FairProbabiltyLabel";
            this.FairProbabiltyLabel.Size = new System.Drawing.Size(143, 17);
            this.FairProbabiltyLabel.TabIndex = 12;
            this.FairProbabiltyLabel.Text = "Fair Day Probability : ";
            // 
            // PoorProbabilityLabel
            // 
            this.PoorProbabilityLabel.AutoSize = true;
            this.PoorProbabilityLabel.BackColor = System.Drawing.Color.Transparent;
            this.PoorProbabilityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PoorProbabilityLabel.Location = new System.Drawing.Point(505, 292);
            this.PoorProbabilityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PoorProbabilityLabel.Name = "PoorProbabilityLabel";
            this.PoorProbabilityLabel.Size = new System.Drawing.Size(149, 17);
            this.PoorProbabilityLabel.TabIndex = 13;
            this.PoorProbabilityLabel.Text = "Poor Day Probability : ";
            // 
            // GoodProbability
            // 
            this.GoodProbability.DecimalPlaces = 2;
            this.GoodProbability.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoodProbability.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.GoodProbability.Location = new System.Drawing.Point(233, 291);
            this.GoodProbability.Margin = new System.Windows.Forms.Padding(2);
            this.GoodProbability.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.GoodProbability.Name = "GoodProbability";
            this.GoodProbability.Size = new System.Drawing.Size(50, 23);
            this.GoodProbability.TabIndex = 14;
            // 
            // FairProbability
            // 
            this.FairProbability.DecimalPlaces = 2;
            this.FairProbability.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FairProbability.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.FairProbability.Location = new System.Drawing.Point(430, 289);
            this.FairProbability.Margin = new System.Windows.Forms.Padding(2);
            this.FairProbability.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.FairProbability.Name = "FairProbability";
            this.FairProbability.Size = new System.Drawing.Size(50, 23);
            this.FairProbability.TabIndex = 15;
            // 
            // PoorProbabilty
            // 
            this.PoorProbabilty.DecimalPlaces = 2;
            this.PoorProbabilty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PoorProbabilty.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.PoorProbabilty.Location = new System.Drawing.Point(658, 289);
            this.PoorProbabilty.Margin = new System.Windows.Forms.Padding(2);
            this.PoorProbabilty.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.PoorProbabilty.Name = "PoorProbabilty";
            this.PoorProbabilty.Size = new System.Drawing.Size(50, 23);
            this.PoorProbabilty.TabIndex = 16;
            // 
            // DemandDistributionGrid
            // 
            this.DemandDistributionGrid.AllowUserToResizeColumns = false;
            this.DemandDistributionGrid.AllowUserToResizeRows = false;
            this.DemandDistributionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DemandDistributionGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Demand,
            this.goodP,
            this.fairP,
            this.poorP});
            this.DemandDistributionGrid.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DemandDistributionGrid.Location = new System.Drawing.Point(462, 133);
            this.DemandDistributionGrid.Margin = new System.Windows.Forms.Padding(2);
            this.DemandDistributionGrid.Name = "DemandDistributionGrid";
            this.DemandDistributionGrid.RowTemplate.Height = 28;
            this.DemandDistributionGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DemandDistributionGrid.Size = new System.Drawing.Size(305, 123);
            this.DemandDistributionGrid.TabIndex = 17;
            // 
            // StartSimulationButton
            // 
            this.StartSimulationButton.Location = new System.Drawing.Point(319, 133);
            this.StartSimulationButton.Margin = new System.Windows.Forms.Padding(2);
            this.StartSimulationButton.Name = "StartSimulationButton";
            this.StartSimulationButton.Size = new System.Drawing.Size(134, 28);
            this.StartSimulationButton.TabIndex = 18;
            this.StartSimulationButton.Text = "Start Simulation";
            this.StartSimulationButton.UseVisualStyleBackColor = true;
            this.StartSimulationButton.Click += new System.EventHandler(this.StartSimulationButton_Click);
            // 
            // AutomaticTestingButton
            // 
            this.AutomaticTestingButton.Location = new System.Drawing.Point(319, 164);
            this.AutomaticTestingButton.Margin = new System.Windows.Forms.Padding(2);
            this.AutomaticTestingButton.Name = "AutomaticTestingButton";
            this.AutomaticTestingButton.Size = new System.Drawing.Size(134, 28);
            this.AutomaticTestingButton.TabIndex = 19;
            this.AutomaticTestingButton.Text = "Automatic Testing";
            this.AutomaticTestingButton.UseVisualStyleBackColor = true;
            // 
            // LoadFromFileButton
            // 
            this.LoadFromFileButton.Location = new System.Drawing.Point(319, 196);
            this.LoadFromFileButton.Margin = new System.Windows.Forms.Padding(2);
            this.LoadFromFileButton.Name = "LoadFromFileButton";
            this.LoadFromFileButton.Size = new System.Drawing.Size(134, 28);
            this.LoadFromFileButton.TabIndex = 20;
            this.LoadFromFileButton.Text = "Load From File";
            this.LoadFromFileButton.UseVisualStyleBackColor = true;
            // 
            // ExportToFileButton
            // 
            this.ExportToFileButton.Location = new System.Drawing.Point(319, 228);
            this.ExportToFileButton.Margin = new System.Windows.Forms.Padding(2);
            this.ExportToFileButton.Name = "ExportToFileButton";
            this.ExportToFileButton.Size = new System.Drawing.Size(134, 28);
            this.ExportToFileButton.TabIndex = 21;
            this.ExportToFileButton.Text = "Export To File";
            this.ExportToFileButton.UseVisualStyleBackColor = true;
            // 
            // Demand
            // 
            this.Demand.HeaderText = "Demand";
            this.Demand.Name = "Demand";
            this.Demand.Width = 61;
            // 
            // goodP
            // 
            this.goodP.HeaderText = "Good Probability  ";
            this.goodP.Name = "goodP";
            this.goodP.Width = 61;
            // 
            // fairP
            // 
            this.fairP.HeaderText = "Fair Probability";
            this.fairP.Name = "fairP";
            this.fairP.Width = 61;
            // 
            // poorP
            // 
            this.poorP.HeaderText = "Poor Probability";
            this.poorP.Name = "poorP";
            this.poorP.Width = 61;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NewspaperSellerSimulation.Properties.Resources.preview_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(838, 410);
            this.Controls.Add(this.ExportToFileButton);
            this.Controls.Add(this.LoadFromFileButton);
            this.Controls.Add(this.AutomaticTestingButton);
            this.Controls.Add(this.StartSimulationButton);
            this.Controls.Add(this.DemandDistributionGrid);
            this.Controls.Add(this.PoorProbabilty);
            this.Controls.Add(this.FairProbability);
            this.Controls.Add(this.GoodProbability);
            this.Controls.Add(this.PoorProbabilityLabel);
            this.Controls.Add(this.FairProbabiltyLabel);
            this.Controls.Add(this.GoodProbabilityLabel);
            this.Controls.Add(this.SellingPrice);
            this.Controls.Add(this.ScrapPrice);
            this.Controls.Add(this.PurchasePrice);
            this.Controls.Add(this.NumofRecords);
            this.Controls.Add(this.NumOfNewsPapers);
            this.Controls.Add(this.DayTypeLabel);
            this.Controls.Add(this.SellingPriceLabel);
            this.Controls.Add(this.ScrapPriceLabel);
            this.Controls.Add(this.PurchasePriceLabel);
            this.Controls.Add(this.NumberOfRecordsLabel);
            this.Controls.Add(this.NumberOfNewspapersLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Newspaper Simualtor";
            ((System.ComponentModel.ISupportInitialize)(this.NumOfNewsPapers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumofRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PurchasePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScrapPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellingPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoodProbability)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FairProbability)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PoorProbabilty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DemandDistributionGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NumberOfNewspapersLabel;
        private System.Windows.Forms.Label NumberOfRecordsLabel;
        private System.Windows.Forms.Label PurchasePriceLabel;
        private System.Windows.Forms.Label ScrapPriceLabel;
        private System.Windows.Forms.Label SellingPriceLabel;
        private System.Windows.Forms.Label DayTypeLabel;
        private System.Windows.Forms.NumericUpDown NumOfNewsPapers;
        private System.Windows.Forms.NumericUpDown NumofRecords;
        private System.Windows.Forms.NumericUpDown PurchasePrice;
        private System.Windows.Forms.NumericUpDown ScrapPrice;
        private System.Windows.Forms.NumericUpDown SellingPrice;
        private System.Windows.Forms.Label GoodProbabilityLabel;
        private System.Windows.Forms.Label FairProbabiltyLabel;
        private System.Windows.Forms.Label PoorProbabilityLabel;
        private System.Windows.Forms.NumericUpDown GoodProbability;
        private System.Windows.Forms.NumericUpDown FairProbability;
        private System.Windows.Forms.NumericUpDown PoorProbabilty;
        private System.Windows.Forms.DataGridView DemandDistributionGrid;
        private System.Windows.Forms.Button StartSimulationButton;
        private System.Windows.Forms.Button AutomaticTestingButton;
        private System.Windows.Forms.Button LoadFromFileButton;
        private System.Windows.Forms.Button ExportToFileButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Demand;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodP;
        private System.Windows.Forms.DataGridViewTextBoxColumn fairP;
        private System.Windows.Forms.DataGridViewTextBoxColumn poorP;
    }
}