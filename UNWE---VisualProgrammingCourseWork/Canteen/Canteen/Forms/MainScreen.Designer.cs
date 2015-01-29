namespace Canteen.Forms
{
    partial class MainScreen
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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.productsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProductMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsListMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchProductsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mealsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMealMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mealsListMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recipesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newRecipeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recipesListMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menusMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMenuMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeLayout = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalLayout = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalLayout = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllWindows = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsMenuItem,
            this.mealsMenuItem,
            this.recipesMenuItem,
            this.menusMenuItem,
            this.windowsMenuItem,
            this.helpMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1033, 24);
            this.mainMenu.TabIndex = 2;
            this.mainMenu.Text = "menuStrip1";
            // 
            // productsMenuItem
            // 
            this.productsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProductMenuItem,
            this.productsListMenuItem,
            this.searchProductsMenuItem});
            this.productsMenuItem.Name = "productsMenuItem";
            this.productsMenuItem.Size = new System.Drawing.Size(72, 20);
            this.productsMenuItem.Text = "Продукти";
            // 
            // newProductMenuItem
            // 
            this.newProductMenuItem.Name = "newProductMenuItem";
            this.newProductMenuItem.Size = new System.Drawing.Size(190, 22);
            this.newProductMenuItem.Text = "Добавяне на продукт";
            this.newProductMenuItem.Click += new System.EventHandler(this.newProductMenuItem_Click);
            // 
            // productsListMenuItem
            // 
            this.productsListMenuItem.Name = "productsListMenuItem";
            this.productsListMenuItem.Size = new System.Drawing.Size(190, 22);
            this.productsListMenuItem.Text = "Списък";
            this.productsListMenuItem.Click += new System.EventHandler(this.productsListMenuItem_Click);
            // 
            // searchProductsMenuItem
            // 
            this.searchProductsMenuItem.Name = "searchProductsMenuItem";
            this.searchProductsMenuItem.Size = new System.Drawing.Size(190, 22);
            this.searchProductsMenuItem.Text = "Търсене";
            this.searchProductsMenuItem.Click += new System.EventHandler(this.searchProductsMenuItem_Click);
            // 
            // mealsMenuItem
            // 
            this.mealsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMealMenuItem,
            this.mealsListMenuItem,
            this.searchMenuItem});
            this.mealsMenuItem.Name = "mealsMenuItem";
            this.mealsMenuItem.Size = new System.Drawing.Size(50, 20);
            this.mealsMenuItem.Text = "Ястия";
            // 
            // newMealMenuItem
            // 
            this.newMealMenuItem.Name = "newMealMenuItem";
            this.newMealMenuItem.Size = new System.Drawing.Size(176, 22);
            this.newMealMenuItem.Text = "Добавяне на ястие";
            this.newMealMenuItem.Click += new System.EventHandler(this.newMealMenuItem_Click);
            // 
            // mealsListMenuItem
            // 
            this.mealsListMenuItem.Name = "mealsListMenuItem";
            this.mealsListMenuItem.Size = new System.Drawing.Size(176, 22);
            this.mealsListMenuItem.Text = "Списък";
            this.mealsListMenuItem.Click += new System.EventHandler(this.mealsListMenuItem_Click);
            // 
            // searchMenuItem
            // 
            this.searchMenuItem.Name = "searchMenuItem";
            this.searchMenuItem.Size = new System.Drawing.Size(176, 22);
            this.searchMenuItem.Text = "Търсене";
            this.searchMenuItem.Click += new System.EventHandler(this.searchMealsMenuItem_Click);
            // 
            // recipesMenuItem
            // 
            this.recipesMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newRecipeMenuItem,
            this.recipesListMenuItem});
            this.recipesMenuItem.Name = "recipesMenuItem";
            this.recipesMenuItem.Size = new System.Drawing.Size(64, 20);
            this.recipesMenuItem.Text = "Рецепти";
            // 
            // newRecipeMenuItem
            // 
            this.newRecipeMenuItem.Name = "newRecipeMenuItem";
            this.newRecipeMenuItem.Size = new System.Drawing.Size(190, 22);
            this.newRecipeMenuItem.Text = "Добавяне на рецепта";
            this.newRecipeMenuItem.Click += new System.EventHandler(this.newRecipeMenuItem_Click);
            // 
            // recipesListMenuItem
            // 
            this.recipesListMenuItem.Name = "recipesListMenuItem";
            this.recipesListMenuItem.Size = new System.Drawing.Size(190, 22);
            this.recipesListMenuItem.Text = "Списък";
            this.recipesListMenuItem.Click += new System.EventHandler(this.recipesListMenuItem_Click);
            // 
            // menusMenuItem
            // 
            this.menusMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMenuMenuItem});
            this.menusMenuItem.Name = "menusMenuItem";
            this.menusMenuItem.Size = new System.Drawing.Size(64, 20);
            this.menusMenuItem.Text = "Менюта";
            // 
            // newMenuMenuItem
            // 
            this.newMenuMenuItem.Name = "newMenuMenuItem";
            this.newMenuMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newMenuMenuItem.Text = "Добави меню";
            this.newMenuMenuItem.Click += new System.EventHandler(this.newMenuMenuItem_Click);
            // 
            // windowsMenuItem
            // 
            this.windowsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeLayout,
            this.verticalLayout,
            this.horizontalLayout,
            this.closeAllWindows});
            this.windowsMenuItem.Name = "windowsMenuItem";
            this.windowsMenuItem.Size = new System.Drawing.Size(75, 20);
            this.windowsMenuItem.Text = "Прозорци";
            // 
            // cascadeLayout
            // 
            this.cascadeLayout.Name = "cascadeLayout";
            this.cascadeLayout.Size = new System.Drawing.Size(223, 22);
            this.cascadeLayout.Text = "Каскадно подреждане";
            this.cascadeLayout.Click += new System.EventHandler(this.cascadeLayoutMenuItem_Click);
            // 
            // verticalLayout
            // 
            this.verticalLayout.Name = "verticalLayout";
            this.verticalLayout.Size = new System.Drawing.Size(223, 22);
            this.verticalLayout.Text = "Вертикално подреждане";
            this.verticalLayout.Click += new System.EventHandler(this.verticalLayoutMenuItem_Click);
            // 
            // horizontalLayout
            // 
            this.horizontalLayout.Name = "horizontalLayout";
            this.horizontalLayout.Size = new System.Drawing.Size(223, 22);
            this.horizontalLayout.Text = "Хоризонтално подреждане";
            this.horizontalLayout.Click += new System.EventHandler(this.horizontalLayoutMenuItem_Click);
            // 
            // closeAllWindows
            // 
            this.closeAllWindows.Name = "closeAllWindows";
            this.closeAllWindows.Size = new System.Drawing.Size(223, 22);
            this.closeAllWindows.Text = "Затваряне на всички";
            this.closeAllWindows.Click += new System.EventHandler(this.closeAllWindowsMenuItem_Click);
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenuItem});
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Size = new System.Drawing.Size(62, 20);
            this.helpMenuItem.Text = "Помощ";
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutMenuItem.Text = "За продукта";
            this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 750);
            this.Controls.Add(this.mainMenu);
            this.IsMdiContainer = true;
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainScreen";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem mealsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mealsListMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newMealMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeLayout;
        private System.Windows.Forms.ToolStripMenuItem verticalLayout;
        private System.Windows.Forms.ToolStripMenuItem horizontalLayout;
        private System.Windows.Forms.ToolStripMenuItem closeAllWindows;
        private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProductMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsListMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchProductsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recipesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recipesListMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newRecipeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menusMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newMenuMenuItem;

    }
}