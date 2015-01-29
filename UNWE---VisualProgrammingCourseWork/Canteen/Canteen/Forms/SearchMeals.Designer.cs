namespace Canteen.Forms
{
    partial class SearchMeals
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchMeals));
            this.contentWrapper = new System.Windows.Forms.Panel();
            this.quantityHelpToLabel = new System.Windows.Forms.Label();
            this.quantityHelpFromLabel = new System.Windows.Forms.Label();
            this.caloriesHelpToLabel = new System.Windows.Forms.Label();
            this.caloriesHelpFromLabel = new System.Windows.Forms.Label();
            this.clearFiltersButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.mealsTable = new System.Windows.Forms.DataGridView();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.caloriesLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.mealNameLabel = new System.Windows.Forms.Label();
            this.quantityEndRange = new System.Windows.Forms.TextBox();
            this.quantityStartRange = new System.Windows.Forms.TextBox();
            this.caloriesEndRange = new System.Windows.Forms.TextBox();
            this.caloriesStartRange = new System.Windows.Forms.TextBox();
            this.type = new System.Windows.Forms.TextBox();
            this.mealName = new System.Windows.Forms.TextBox();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.deleteButton = new System.Windows.Forms.ToolStripButton();
            this.newMealButton = new System.Windows.Forms.ToolStripButton();
            this.contentWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mealsTable)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentWrapper
            // 
            this.contentWrapper.Controls.Add(this.quantityHelpToLabel);
            this.contentWrapper.Controls.Add(this.quantityHelpFromLabel);
            this.contentWrapper.Controls.Add(this.caloriesHelpToLabel);
            this.contentWrapper.Controls.Add(this.caloriesHelpFromLabel);
            this.contentWrapper.Controls.Add(this.clearFiltersButton);
            this.contentWrapper.Controls.Add(this.searchButton);
            this.contentWrapper.Controls.Add(this.mealsTable);
            this.contentWrapper.Controls.Add(this.quantityLabel);
            this.contentWrapper.Controls.Add(this.caloriesLabel);
            this.contentWrapper.Controls.Add(this.typeLabel);
            this.contentWrapper.Controls.Add(this.mealNameLabel);
            this.contentWrapper.Controls.Add(this.quantityEndRange);
            this.contentWrapper.Controls.Add(this.quantityStartRange);
            this.contentWrapper.Controls.Add(this.caloriesEndRange);
            this.contentWrapper.Controls.Add(this.caloriesStartRange);
            this.contentWrapper.Controls.Add(this.type);
            this.contentWrapper.Controls.Add(this.mealName);
            this.contentWrapper.Controls.Add(this.toolStrip);
            this.contentWrapper.Location = new System.Drawing.Point(21, 12);
            this.contentWrapper.Name = "contentWrapper";
            this.contentWrapper.Size = new System.Drawing.Size(790, 438);
            this.contentWrapper.TabIndex = 0;
            // 
            // quantityHelpToLabel
            // 
            this.quantityHelpToLabel.AutoSize = true;
            this.quantityHelpToLabel.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantityHelpToLabel.Location = new System.Drawing.Point(384, 217);
            this.quantityHelpToLabel.Name = "quantityHelpToLabel";
            this.quantityHelpToLabel.Size = new System.Drawing.Size(35, 25);
            this.quantityHelpToLabel.TabIndex = 17;
            this.quantityHelpToLabel.Text = "до";
            // 
            // quantityHelpFromLabel
            // 
            this.quantityHelpFromLabel.AutoSize = true;
            this.quantityHelpFromLabel.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantityHelpFromLabel.Location = new System.Drawing.Point(200, 216);
            this.quantityHelpFromLabel.Name = "quantityHelpFromLabel";
            this.quantityHelpFromLabel.Size = new System.Drawing.Size(33, 25);
            this.quantityHelpFromLabel.TabIndex = 16;
            this.quantityHelpFromLabel.Text = "от";
            // 
            // caloriesHelpToLabel
            // 
            this.caloriesHelpToLabel.AutoSize = true;
            this.caloriesHelpToLabel.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.caloriesHelpToLabel.Location = new System.Drawing.Point(384, 161);
            this.caloriesHelpToLabel.Name = "caloriesHelpToLabel";
            this.caloriesHelpToLabel.Size = new System.Drawing.Size(35, 25);
            this.caloriesHelpToLabel.TabIndex = 15;
            this.caloriesHelpToLabel.Text = "до";
            // 
            // caloriesHelpFromLabel
            // 
            this.caloriesHelpFromLabel.AutoSize = true;
            this.caloriesHelpFromLabel.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.caloriesHelpFromLabel.Location = new System.Drawing.Point(200, 161);
            this.caloriesHelpFromLabel.Name = "caloriesHelpFromLabel";
            this.caloriesHelpFromLabel.Size = new System.Drawing.Size(33, 25);
            this.caloriesHelpFromLabel.TabIndex = 14;
            this.caloriesHelpFromLabel.Text = "от";
            // 
            // clearFiltersButton
            // 
            this.clearFiltersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearFiltersButton.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearFiltersButton.Location = new System.Drawing.Point(599, 51);
            this.clearFiltersButton.Name = "clearFiltersButton";
            this.clearFiltersButton.Size = new System.Drawing.Size(126, 61);
            this.clearFiltersButton.TabIndex = 13;
            this.clearFiltersButton.Text = "Изчисти филтрите";
            this.clearFiltersButton.UseVisualStyleBackColor = true;
            this.clearFiltersButton.Click += new System.EventHandler(this.clearFiltersButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchButton.Location = new System.Drawing.Point(598, 182);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(127, 40);
            this.searchButton.TabIndex = 12;
            this.searchButton.Text = "Търсене";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // mealsTable
            // 
            this.mealsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mealsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mealsTable.Location = new System.Drawing.Point(24, 276);
            this.mealsTable.Name = "mealsTable";
            this.mealsTable.ReadOnly = true;
            this.mealsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mealsTable.Size = new System.Drawing.Size(719, 150);
            this.mealsTable.TabIndex = 11;
            this.mealsTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mealsTable_CellDoubleClick);
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantityLabel.Location = new System.Drawing.Point(61, 217);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(90, 25);
            this.quantityLabel.TabIndex = 10;
            this.quantityLabel.Text = "Грамаж";
            // 
            // caloriesLabel
            // 
            this.caloriesLabel.AutoSize = true;
            this.caloriesLabel.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.caloriesLabel.Location = new System.Drawing.Point(61, 161);
            this.caloriesLabel.Name = "caloriesLabel";
            this.caloriesLabel.Size = new System.Drawing.Size(99, 25);
            this.caloriesLabel.TabIndex = 9;
            this.caloriesLabel.Text = "Калории";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeLabel.Location = new System.Drawing.Point(61, 109);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(51, 25);
            this.typeLabel.TabIndex = 8;
            this.typeLabel.Text = "Тип";
            // 
            // mealNameLabel
            // 
            this.mealNameLabel.AutoSize = true;
            this.mealNameLabel.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mealNameLabel.Location = new System.Drawing.Point(61, 51);
            this.mealNameLabel.Name = "mealNameLabel";
            this.mealNameLabel.Size = new System.Drawing.Size(160, 25);
            this.mealNameLabel.TabIndex = 7;
            this.mealNameLabel.Text = "Наименование";
            // 
            // quantityEndRange
            // 
            this.quantityEndRange.Location = new System.Drawing.Point(425, 222);
            this.quantityEndRange.Name = "quantityEndRange";
            this.quantityEndRange.Size = new System.Drawing.Size(127, 20);
            this.quantityEndRange.TabIndex = 6;
            // 
            // quantityStartRange
            // 
            this.quantityStartRange.Location = new System.Drawing.Point(239, 222);
            this.quantityStartRange.Name = "quantityStartRange";
            this.quantityStartRange.Size = new System.Drawing.Size(127, 20);
            this.quantityStartRange.TabIndex = 5;
            // 
            // caloriesEndRange
            // 
            this.caloriesEndRange.Location = new System.Drawing.Point(425, 166);
            this.caloriesEndRange.Name = "caloriesEndRange";
            this.caloriesEndRange.Size = new System.Drawing.Size(127, 20);
            this.caloriesEndRange.TabIndex = 4;
            // 
            // caloriesStartRange
            // 
            this.caloriesStartRange.Location = new System.Drawing.Point(239, 166);
            this.caloriesStartRange.Name = "caloriesStartRange";
            this.caloriesStartRange.Size = new System.Drawing.Size(127, 20);
            this.caloriesStartRange.TabIndex = 3;
            // 
            // type
            // 
            this.type.Location = new System.Drawing.Point(239, 109);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(175, 20);
            this.type.TabIndex = 2;
            // 
            // mealName
            // 
            this.mealName.Location = new System.Drawing.Point(239, 55);
            this.mealName.Name = "mealName";
            this.mealName.Size = new System.Drawing.Size(175, 20);
            this.mealName.TabIndex = 1;
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteButton,
            this.newMealButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(790, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // deleteButton
            // 
            this.deleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.deleteButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
            this.deleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(90, 22);
            this.deleteButton.Text = "Изтриване";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // newMealButton
            // 
            this.newMealButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.newMealButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newMealButton.Image = ((System.Drawing.Image)(resources.GetObject("newMealButton.Image")));
            this.newMealButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newMealButton.Name = "newMealButton";
            this.newMealButton.Size = new System.Drawing.Size(93, 22);
            this.newMealButton.Text = "Ново ястие";
            this.newMealButton.Click += new System.EventHandler(this.newMealButton_Click);
            // 
            // SearchMeals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 462);
            this.Controls.Add(this.contentWrapper);
            this.Name = "SearchMeals";
            this.Text = "SearchMeals";
            this.contentWrapper.ResumeLayout(false);
            this.contentWrapper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mealsTable)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contentWrapper;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton deleteButton;
        private System.Windows.Forms.ToolStripButton newMealButton;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label caloriesLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label mealNameLabel;
        private System.Windows.Forms.TextBox quantityEndRange;
        private System.Windows.Forms.TextBox quantityStartRange;
        private System.Windows.Forms.TextBox caloriesEndRange;
        private System.Windows.Forms.TextBox caloriesStartRange;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.TextBox mealName;
        private System.Windows.Forms.Button clearFiltersButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView mealsTable;
        private System.Windows.Forms.Label quantityHelpToLabel;
        private System.Windows.Forms.Label quantityHelpFromLabel;
        private System.Windows.Forms.Label caloriesHelpToLabel;
        private System.Windows.Forms.Label caloriesHelpFromLabel;
    }
}