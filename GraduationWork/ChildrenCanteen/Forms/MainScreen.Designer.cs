namespace ChildrenCanteen
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
            this.recipesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menusMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recipesListMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newRecipeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchRecipeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manusListMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newMenuMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requestsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newRequestMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requestsReportsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recipesMenuItem,
            this.menusMenuItem,
            this.requestsMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(874, 26);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // recipesMenuItem
            // 
            this.recipesMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recipesListMenuItem,
            this.newRecipeMenuItem,
            this.searchRecipeMenuItem});
            this.recipesMenuItem.Name = "recipesMenuItem";
            this.recipesMenuItem.Size = new System.Drawing.Size(64, 20);
            this.recipesMenuItem.Text = "Рецепти";
            // 
            // menusMenuItem
            // 
            this.menusMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manusListMenuItem1,
            this.newMenuMenuItem});
            this.menusMenuItem.Name = "menusMenuItem";
            this.menusMenuItem.Size = new System.Drawing.Size(64, 20);
            this.menusMenuItem.Text = "Менюта";
            // 
            // recipesListMenuItem
            // 
            this.recipesListMenuItem.Name = "recipesListMenuItem";
            this.recipesListMenuItem.Size = new System.Drawing.Size(190, 22);
            this.recipesListMenuItem.Text = "Списък";
            // 
            // newRecipeMenuItem
            // 
            this.newRecipeMenuItem.Name = "newRecipeMenuItem";
            this.newRecipeMenuItem.Size = new System.Drawing.Size(190, 22);
            this.newRecipeMenuItem.Text = "Добавяне на рецепта";
            // 
            // searchRecipeMenuItem
            // 
            this.searchRecipeMenuItem.Name = "searchRecipeMenuItem";
            this.searchRecipeMenuItem.Size = new System.Drawing.Size(190, 22);
            this.searchRecipeMenuItem.Text = "Търсене";
            // 
            // manusListMenuItem1
            // 
            this.manusListMenuItem1.Name = "manusListMenuItem1";
            this.manusListMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.manusListMenuItem1.Text = "Списък";
            // 
            // newMenuMenuItem
            // 
            this.newMenuMenuItem.Name = "newMenuMenuItem";
            this.newMenuMenuItem.Size = new System.Drawing.Size(178, 22);
            this.newMenuMenuItem.Text = "Добавяне на меню";
            // 
            // requestsMenuItem
            // 
            this.requestsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newRequestMenuItem,
            this.requestsReportsMenuItem});
            this.requestsMenuItem.Name = "requestsMenuItem";
            this.requestsMenuItem.Size = new System.Drawing.Size(115, 20);
            this.requestsMenuItem.Text = "Контролен панел";
            // 
            // newRequestMenuItem
            // 
            this.newRequestMenuItem.Name = "newRequestMenuItem";
            this.newRequestMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newRequestMenuItem.Text = "Ново искане";
            // 
            // requestsReportsMenuItem
            // 
            this.requestsReportsMenuItem.Name = "requestsReportsMenuItem";
            this.requestsReportsMenuItem.Size = new System.Drawing.Size(152, 22);
            this.requestsReportsMenuItem.Text = "Отчети";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 452);
            this.Controls.Add(this.mainMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenu;
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
        private System.Windows.Forms.ToolStripMenuItem recipesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recipesListMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newRecipeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchRecipeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menusMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manusListMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newMenuMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requestsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newRequestMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requestsReportsMenuItem;
    }
}