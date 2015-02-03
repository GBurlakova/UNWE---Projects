namespace Canteen.Forms
{
    partial class AllRecipes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllRecipes));
            this.contentWrapper = new System.Windows.Forms.Panel();
            this.recipesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteRecipeButton = new System.Windows.Forms.Button();
            this.newProductPanel = new System.Windows.Forms.Panel();
            this.addRecipeProductButton = new System.Windows.Forms.Button();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.productLabel = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.TextBox();
            this.products = new System.Windows.Forms.ComboBox();
            this.editRecipeProductButton = new System.Windows.Forms.Button();
            this.deleteRecipeProductButton = new System.Windows.Forms.Button();
            this.showAddProductPanelButton = new System.Windows.Forms.Button();
            this.recipeProducts = new System.Windows.Forms.DataGridView();
            this.recipeCode = new System.Windows.Forms.TextBox();
            this.recipeName = new System.Windows.Forms.TextBox();
            this.canteenDataSet = new Canteen.CanteenDataSet();
            this.recipeCodeLabel = new System.Windows.Forms.Label();
            this.recipeNameLabel = new System.Windows.Forms.Label();
            this.contentWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recipesBindingNavigator)).BeginInit();
            this.recipesBindingNavigator.SuspendLayout();
            this.newProductPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recipeProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canteenDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // contentWrapper
            // 
            this.contentWrapper.Controls.Add(this.recipeNameLabel);
            this.contentWrapper.Controls.Add(this.recipeCodeLabel);
            this.contentWrapper.Controls.Add(this.recipesBindingNavigator);
            this.contentWrapper.Controls.Add(this.deleteRecipeButton);
            this.contentWrapper.Controls.Add(this.newProductPanel);
            this.contentWrapper.Controls.Add(this.editRecipeProductButton);
            this.contentWrapper.Controls.Add(this.deleteRecipeProductButton);
            this.contentWrapper.Controls.Add(this.showAddProductPanelButton);
            this.contentWrapper.Controls.Add(this.recipeProducts);
            this.contentWrapper.Controls.Add(this.recipeCode);
            this.contentWrapper.Controls.Add(this.recipeName);
            this.contentWrapper.Location = new System.Drawing.Point(30, 12);
            this.contentWrapper.Name = "contentWrapper";
            this.contentWrapper.Size = new System.Drawing.Size(770, 478);
            this.contentWrapper.TabIndex = 0;
            // 
            // recipesBindingNavigator
            // 
            this.recipesBindingNavigator.AddNewItem = null;
            this.recipesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.recipesBindingNavigator.DeleteItem = null;
            this.recipesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.recipesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.recipesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.recipesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.recipesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.recipesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.recipesBindingNavigator.Name = "recipesBindingNavigator";
            this.recipesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.recipesBindingNavigator.Size = new System.Drawing.Size(770, 25);
            this.recipesBindingNavigator.TabIndex = 11;
            this.recipesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // deleteRecipeButton
            // 
            this.deleteRecipeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteRecipeButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteRecipeButton.Location = new System.Drawing.Point(506, 33);
            this.deleteRecipeButton.Name = "deleteRecipeButton";
            this.deleteRecipeButton.Size = new System.Drawing.Size(149, 46);
            this.deleteRecipeButton.TabIndex = 10;
            this.deleteRecipeButton.Text = "Изтрий рецепта";
            this.deleteRecipeButton.UseVisualStyleBackColor = true;
            this.deleteRecipeButton.Click += new System.EventHandler(this.deleteRecipeButton_Click);
            // 
            // newProductPanel
            // 
            this.newProductPanel.Controls.Add(this.addRecipeProductButton);
            this.newProductPanel.Controls.Add(this.quantityLabel);
            this.newProductPanel.Controls.Add(this.productLabel);
            this.newProductPanel.Controls.Add(this.quantity);
            this.newProductPanel.Controls.Add(this.products);
            this.newProductPanel.Location = new System.Drawing.Point(168, 346);
            this.newProductPanel.Name = "newProductPanel";
            this.newProductPanel.Size = new System.Drawing.Size(487, 112);
            this.newProductPanel.TabIndex = 9;
            // 
            // addRecipeProductButton
            // 
            this.addRecipeProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addRecipeProductButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addRecipeProductButton.Location = new System.Drawing.Point(328, 32);
            this.addRecipeProductButton.Name = "addRecipeProductButton";
            this.addRecipeProductButton.Size = new System.Drawing.Size(149, 46);
            this.addRecipeProductButton.TabIndex = 10;
            this.addRecipeProductButton.Text = "Запази";
            this.addRecipeProductButton.UseVisualStyleBackColor = true;
            this.addRecipeProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantityLabel.Location = new System.Drawing.Point(3, 64);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(114, 23);
            this.quantityLabel.TabIndex = 11;
            this.quantityLabel.Text = "Количество";
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productLabel.Location = new System.Drawing.Point(32, 17);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(85, 23);
            this.productLabel.TabIndex = 10;
            this.productLabel.Text = "Продукт";
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(137, 67);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(171, 20);
            this.quantity.TabIndex = 9;
            // 
            // products
            // 
            this.products.FormattingEnabled = true;
            this.products.Location = new System.Drawing.Point(137, 22);
            this.products.Name = "products";
            this.products.Size = new System.Drawing.Size(171, 21);
            this.products.TabIndex = 8;
            // 
            // editRecipeProductButton
            // 
            this.editRecipeProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editRecipeProductButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editRecipeProductButton.Location = new System.Drawing.Point(496, 266);
            this.editRecipeProductButton.Name = "editRecipeProductButton";
            this.editRecipeProductButton.Size = new System.Drawing.Size(172, 46);
            this.editRecipeProductButton.TabIndex = 7;
            this.editRecipeProductButton.Text = "Редактирай продукт";
            this.editRecipeProductButton.UseVisualStyleBackColor = true;
            this.editRecipeProductButton.Click += new System.EventHandler(this.editProductButton_Click);
            // 
            // deleteRecipeProductButton
            // 
            this.deleteRecipeProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteRecipeProductButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteRecipeProductButton.Location = new System.Drawing.Point(312, 266);
            this.deleteRecipeProductButton.Name = "deleteRecipeProductButton";
            this.deleteRecipeProductButton.Size = new System.Drawing.Size(160, 46);
            this.deleteRecipeProductButton.TabIndex = 6;
            this.deleteRecipeProductButton.Text = "Премахни продукт";
            this.deleteRecipeProductButton.UseVisualStyleBackColor = true;
            this.deleteRecipeProductButton.Click += new System.EventHandler(this.deleteProductButton_Click);
            // 
            // showAddProductPanelButton
            // 
            this.showAddProductPanelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showAddProductPanelButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showAddProductPanelButton.Location = new System.Drawing.Point(133, 266);
            this.showAddProductPanelButton.Name = "showAddProductPanelButton";
            this.showAddProductPanelButton.Size = new System.Drawing.Size(149, 46);
            this.showAddProductPanelButton.TabIndex = 5;
            this.showAddProductPanelButton.Text = "Добави продукт";
            this.showAddProductPanelButton.UseVisualStyleBackColor = true;
            this.showAddProductPanelButton.Click += new System.EventHandler(this.showAddProductPanelButton_Click);
            // 
            // recipeProducts
            // 
            this.recipeProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.recipeProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recipeProducts.Location = new System.Drawing.Point(91, 101);
            this.recipeProducts.Name = "recipeProducts";
            this.recipeProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.recipeProducts.Size = new System.Drawing.Size(613, 150);
            this.recipeProducts.TabIndex = 4;
            // 
            // recipeCode
            // 
            this.recipeCode.Location = new System.Drawing.Point(299, 33);
            this.recipeCode.Name = "recipeCode";
            this.recipeCode.ReadOnly = true;
            this.recipeCode.Size = new System.Drawing.Size(147, 20);
            this.recipeCode.TabIndex = 1;
            this.recipeCode.TextChanged += new System.EventHandler(this.recipeCode_TextChanged);
            // 
            // recipeName
            // 
            this.recipeName.Location = new System.Drawing.Point(299, 59);
            this.recipeName.Name = "recipeName";
            this.recipeName.ReadOnly = true;
            this.recipeName.Size = new System.Drawing.Size(147, 20);
            this.recipeName.TabIndex = 3;
            // 
            // canteenDataSet
            // 
            this.canteenDataSet.DataSetName = "CanteenDataSet";
            this.canteenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recipeCodeLabel
            // 
            this.recipeCodeLabel.AutoSize = true;
            this.recipeCodeLabel.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recipeCodeLabel.Location = new System.Drawing.Point(232, 28);
            this.recipeCodeLabel.Name = "recipeCodeLabel";
            this.recipeCodeLabel.Size = new System.Drawing.Size(50, 25);
            this.recipeCodeLabel.TabIndex = 12;
            this.recipeCodeLabel.Text = "Код";
            // 
            // recipeNameLabel
            // 
            this.recipeNameLabel.AutoSize = true;
            this.recipeNameLabel.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recipeNameLabel.Location = new System.Drawing.Point(128, 59);
            this.recipeNameLabel.Name = "recipeNameLabel";
            this.recipeNameLabel.Size = new System.Drawing.Size(160, 25);
            this.recipeNameLabel.TabIndex = 13;
            this.recipeNameLabel.Text = "Наименование";
            // 
            // AllRecipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 502);
            this.Controls.Add(this.contentWrapper);
            this.Name = "AllRecipes";
            this.Text = "AllRecipes";
            this.contentWrapper.ResumeLayout(false);
            this.contentWrapper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recipesBindingNavigator)).EndInit();
            this.recipesBindingNavigator.ResumeLayout(false);
            this.recipesBindingNavigator.PerformLayout();
            this.newProductPanel.ResumeLayout(false);
            this.newProductPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recipeProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canteenDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contentWrapper;
        private CanteenDataSet canteenDataSet;
        private System.Windows.Forms.TextBox recipeCode;
        private System.Windows.Forms.TextBox recipeName;
        private System.Windows.Forms.DataGridView recipeProducts;
        private System.Windows.Forms.Panel newProductPanel;
        private System.Windows.Forms.Button addRecipeProductButton;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.ComboBox products;
        private System.Windows.Forms.Button editRecipeProductButton;
        private System.Windows.Forms.Button deleteRecipeProductButton;
        private System.Windows.Forms.Button showAddProductPanelButton;
        private System.Windows.Forms.Button deleteRecipeButton;
        private System.Windows.Forms.BindingNavigator recipesBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Label recipeNameLabel;
        private System.Windows.Forms.Label recipeCodeLabel;
    }
}