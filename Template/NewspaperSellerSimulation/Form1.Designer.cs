namespace NewspaperSellerSimulation
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NumOfNewsPapers = new System.Windows.Forms.NumericUpDown();
            this.NumofRecords = new System.Windows.Forms.NumericUpDown();
            this.PurchasePrice = new System.Windows.Forms.NumericUpDown();
            this.ScrapPrice = new System.Windows.Forms.NumericUpDown();
            this.SellingPrice = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.GoodProbability = new System.Windows.Forms.NumericUpDown();
            this.FairProbability = new System.Windows.Forms.NumericUpDown();
            this.PoorProbabilty = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Newspapers : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of Records : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Purchase Price : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Scrap Price : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(73, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Selling Price : ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(73, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(273, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "Day Type Distributions : ";
            // 
            // NumOfNewsPapers
            // 
            this.NumOfNewsPapers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumOfNewsPapers.Location = new System.Drawing.Point(361, 64);
            this.NumOfNewsPapers.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.NumOfNewsPapers.Name = "NumOfNewsPapers";
            this.NumOfNewsPapers.Size = new System.Drawing.Size(183, 30);
            this.NumOfNewsPapers.TabIndex = 6;
            this.NumOfNewsPapers.ValueChanged += new System.EventHandler(this.NumOfNewsPapers_ValueChanged);
            // 
            // NumofRecords
            // 
            this.NumofRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumofRecords.Location = new System.Drawing.Point(318, 128);
            this.NumofRecords.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.NumofRecords.Name = "NumofRecords";
            this.NumofRecords.Size = new System.Drawing.Size(183, 30);
            this.NumofRecords.TabIndex = 7;
            this.NumofRecords.ValueChanged += new System.EventHandler(this.NumofRecords_ValueChanged);
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
            this.PurchasePrice.Location = new System.Drawing.Point(274, 181);
            this.PurchasePrice.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.PurchasePrice.Name = "PurchasePrice";
            this.PurchasePrice.Size = new System.Drawing.Size(81, 30);
            this.PurchasePrice.TabIndex = 8;
            this.PurchasePrice.ValueChanged += new System.EventHandler(this.PurchasePrice_ValueChanged);
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
            this.ScrapPrice.Location = new System.Drawing.Point(236, 237);
            this.ScrapPrice.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.ScrapPrice.Name = "ScrapPrice";
            this.ScrapPrice.Size = new System.Drawing.Size(76, 30);
            this.ScrapPrice.TabIndex = 9;
            this.ScrapPrice.ValueChanged += new System.EventHandler(this.ScrapPrice_ValueChanged);
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
            this.SellingPrice.Location = new System.Drawing.Point(247, 293);
            this.SellingPrice.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.SellingPrice.Name = "SellingPrice";
            this.SellingPrice.Size = new System.Drawing.Size(75, 30);
            this.SellingPrice.TabIndex = 10;
            this.SellingPrice.ValueChanged += new System.EventHandler(this.SellingPrice_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(85, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(211, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Good Day Probability : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(85, 453);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(196, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Fair Day Probability : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(85, 494);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(204, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "Poor Day Probability : ";
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
            this.GoodProbability.Location = new System.Drawing.Point(302, 408);
            this.GoodProbability.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.GoodProbability.Name = "GoodProbability";
            this.GoodProbability.Size = new System.Drawing.Size(75, 30);
            this.GoodProbability.TabIndex = 14;
            this.GoodProbability.ValueChanged += new System.EventHandler(this.GoodProbability_ValueChanged);
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
            this.FairProbability.Location = new System.Drawing.Point(287, 451);
            this.FairProbability.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.FairProbability.Name = "FairProbability";
            this.FairProbability.Size = new System.Drawing.Size(75, 30);
            this.FairProbability.TabIndex = 15;
            this.FairProbability.ValueChanged += new System.EventHandler(this.FairProbability_ValueChanged);
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
            this.PoorProbabilty.Location = new System.Drawing.Point(295, 494);
            this.PoorProbabilty.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.PoorProbabilty.Name = "PoorProbabilty";
            this.PoorProbabilty.Size = new System.Drawing.Size(75, 30);
            this.PoorProbabilty.TabIndex = 16;
            this.PoorProbabilty.ValueChanged += new System.EventHandler(this.PoorProbabilty_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Demand,
            this.goodP,
            this.fairP,
            this.poorP});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(570, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(667, 167);
            this.dataGridView1.TabIndex = 17;
            // 
            // Demand
            // 
            this.Demand.HeaderText = "Demand";
            this.Demand.Name = "Demand";
            // 
            // goodP
            // 
            this.goodP.HeaderText = "Good Probability  ";
            this.goodP.Name = "goodP";
            // 
            // fairP
            // 
            this.fairP.HeaderText = "Fair Probability";
            this.fairP.Name = "fairP";
            // 
            // poorP
            // 
            this.poorP.HeaderText = "Poor Probability";
            this.poorP.Name = "poorP";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 631);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PoorProbabilty);
            this.Controls.Add(this.FairProbability);
            this.Controls.Add(this.GoodProbability);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SellingPrice);
            this.Controls.Add(this.ScrapPrice);
            this.Controls.Add(this.PurchasePrice);
            this.Controls.Add(this.NumofRecords);
            this.Controls.Add(this.NumOfNewsPapers);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumOfNewsPapers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumofRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PurchasePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScrapPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellingPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoodProbability)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FairProbability)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PoorProbabilty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown NumOfNewsPapers;
        private System.Windows.Forms.NumericUpDown NumofRecords;
        private System.Windows.Forms.NumericUpDown PurchasePrice;
        private System.Windows.Forms.NumericUpDown ScrapPrice;
        private System.Windows.Forms.NumericUpDown SellingPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown GoodProbability;
        private System.Windows.Forms.NumericUpDown FairProbability;
        private System.Windows.Forms.NumericUpDown PoorProbabilty;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Demand;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodP;
        private System.Windows.Forms.DataGridViewTextBoxColumn fairP;
        private System.Windows.Forms.DataGridViewTextBoxColumn poorP;
    }
}