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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchProducts));
            this.contentWrapper = new System.Windows.Forms.Panel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.deleteButton = new System.Windows.Forms.ToolStripButton();
            this.newProductButton = new System.Windows.Forms.ToolStripButton();
            this.clearFiltersButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.measurementUnit = new System.Windows.Forms.TextBox();
            this.measurementUnitLabel = new System.Windows.Forms.Label();
            this.productsTable = new System.Windows.Forms.DataGridView();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.productName = new System.Windows.Forms.TextBox();
            this.contentWrapper.SuspendLayout();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // contentWrapper
            // 
            this.contentWrapper.Controls.Add(this.toolStrip);
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
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteButton,
            this.newProductButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(710, 25);
            this.toolStrip.TabIndex = 9;
            this.toolStrip.Text = "toolStrip1";
            // 
            // deleteButton
            // 
            this.deleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(51, 22);
            this.deleteButton.Text = "Изтрий";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // newProductButton
            // 
            this.newProductButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.newProductButton.Image = ((System.Drawing.Image)(resources.GetObject("newProductButton.Image")));
            this.newProductButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newProductButton.Name = "newProductButton";
            this.newProductButton.Size = new System.Drawing.Size(80, 22);
            this.newProductButton.Text = "Нов продукт";
            this.newProductButton.Click += new System.EventHandler(this.newProductButton_Click);
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
            this.clearFiltersButton.Click += new System.EventHandler(this.clearFiltersButton_Click);
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
            // measurementUnit
            // 
            this.measurementUnit.Location = new System.Drawing.Point(235, 107);
            this.measurementUnit.Name = "measurementUnit";
            this.measurementUnit.Size = new System.Drawing.Size(203, 20);
            this.measurementUnit.TabIndex = 5;
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
            this.productsTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsTable_CellDoubleClick);
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
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(235, 47);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(203, 20);
            this.productName.TabIndex = 0;
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
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
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
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton deleteButton;
        private System.Windows.Forms.ToolStripButton newProductButton;
    }
}