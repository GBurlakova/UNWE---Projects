namespace Canteen.Forms
{
    partial class SearchProducts
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
            this.contentWrapper = new System.Windows.Forms.Panel();
            this.productName = new System.Windows.Forms.TextBox();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.productsTable = new System.Windows.Forms.DataGridView();
            this.measurementUnitLabel = new System.Windows.Forms.Label();
            this.measurementUnit = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.clearFiltersButton = new System.Windows.Forms.Button();
            this.contentWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // contentWrapper
            // 
            this.contentWrapper.Controls.Add(this.clearFiltersButton);
            this.contentWrapper.Controls.Add(this.searchButton);
            this.contentWrapper.Controls.Add(this.measurementUnit);
            this.contentWrapper.Controls.Add(this.measurementUnitLabel);
            this.contentWrapper.Controls.Add(this.productsTable);
            this.contentWrapper.Controls.Add(this.productNameLabel);
            this.contentWrapper.Controls.Add(this.productName);
            this.contentWrapper.Location = new System.Drawing.Point(12, 12);
            this.contentWrapper.Name = "contentWrapper";
            this.contentWrapper.Size = new System.Drawing.Size(710, 438);
            this.contentWrapper.TabIndex = 0;
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(235, 47);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(203, 20);
            this.productName.TabIndex = 0;
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productNameLabel.Location = new System.Drawing.Point(27, 47);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(160, 25);
            this.productNameLabel.TabIndex = 1;
            this.productNameLabel.Text = "Наименование";
            // 
            // productsTable
            // 
            this.productsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsTable.Location = new System.Drawing.Point(23, 253);
            this.productsTable.Name = "productsTable";
            this.productsTable.ReadOnly = true;
            this.productsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsTable.Size = new System.Drawing.Size(635, 150);
            this.productsTable.TabIndex = 3;
            // 
            // measurementUnitLabel
            // 
            this.measurementUnitLabel.AutoSize = true;
            this.measurementUnitLabel.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.measurementUnitLabel.Location = new System.Drawing.Point(27, 102);
            this.measurementUnitLabel.Name = "measurementUnitLabel";
            this.measurementUnitLabel.Size = new System.Drawing.Size(167, 25);
            this.measurementUnitLabel.TabIndex = 4;
            this.measurementUnitLabel.Text = "Мерна единица";
            // 
            // measurementUnit
            // 
            this.measurementUnit.Location = new System.Drawing.Point(235, 107);
            this.measurementUnit.Name = "measurementUnit";
            this.measurementUnit.Size = new System.Drawing.Size(203, 20);
            this.measurementUnit.TabIndex = 5;
            // 
            // searchButton
            // 
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchButton.Location = new System.Drawing.Point(271, 184);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(127, 40);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Търсене";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // clearFiltersButton
            // 
            this.clearFiltersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearFiltersButton.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearFiltersButton.Location = new System.Drawing.Point(519, 56);
            this.clearFiltersButton.Name = "clearFiltersButton";
            this.clearFiltersButton.Size = new System.Drawing.Size(126, 61);
            this.clearFiltersButton.TabIndex = 8;
            this.clearFiltersButton.Text = "Изчисти филтрите";
            this.clearFiltersButton.UseVisualStyleBackColor = true;
            // 
            // SearchProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 462);
            this.Controls.Add(this.contentWrapper);
            this.Name = "SearchProducts";
            this.Text = "SearchProducts";
            this.contentWrapper.ResumeLayout(false);
            this.contentWrapper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contentWrapper;
        private System.Windows.Forms.DataGridView productsTable;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.TextBox productName;
        private System.Windows.Forms.TextBox measurementUnit;
        private System.Windows.Forms.Label measurementUnitLabel;
        private System.Windows.Forms.Button clearFiltersButton;
        private System.Windows.Forms.Button searchButton;
    }
}