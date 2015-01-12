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
            this.продуктиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProductMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mealsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMealMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mealsListMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.каскадноПодрежданеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вертикалноПодрежданеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.хоризонталноПодрежданеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.затварянеНаВсичкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsListMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.търсенеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.продуктиToolStripMenuItem,
            this.mealsMenuItem,
            this.windowsMenuItem,
            this.helpMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1033, 24);
            this.mainMenu.TabIndex = 2;
            this.mainMenu.Text = "menuStrip1";
            // 
            // продуктиToolStripMenuItem
            // 
            this.продуктиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProductMenuItem,
            this.productsListMenuItem,
            this.търсенеToolStripMenuItem});
            this.продуктиToolStripMenuItem.Name = "продуктиToolStripMenuItem";
            this.продуктиToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.продуктиToolStripMenuItem.Text = "Продукти";
            // 
            // newProductMenuItem
            // 
            this.newProductMenuItem.Name = "newProductMenuItem";
            this.newProductMenuItem.Size = new System.Drawing.Size(190, 22);
            this.newProductMenuItem.Text = "Добавяне на продукт";
            this.newProductMenuItem.Click += new System.EventHandler(this.newProductMenuItem_Click);
            // 
            // mealsMenuItem
            // 
            this.mealsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMealMenuItem,
            this.mealsListMenuItem});
            this.mealsMenuItem.Name = "mealsMenuItem";
            this.mealsMenuItem.Size = new System.Drawing.Size(50, 20);
            this.mealsMenuItem.Text = "Ястия";
            // 
            // newMealMenuItem
            // 
            this.newMealMenuItem.Name = "newMealMenuItem";
            this.newMealMenuItem.Size = new System.Drawing.Size(176, 22);
            this.newMealMenuItem.Text = "Добавяне на ястие";
            // 
            // mealsListMenuItem
            // 
            this.mealsListMenuItem.Name = "mealsListMenuItem";
            this.mealsListMenuItem.Size = new System.Drawing.Size(176, 22);
            this.mealsListMenuItem.Text = "Списък";
            // 
            // windowsMenuItem
            // 
            this.windowsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.каскадноПодрежданеToolStripMenuItem,
            this.вертикалноПодрежданеToolStripMenuItem,
            this.хоризонталноПодрежданеToolStripMenuItem,
            this.затварянеНаВсичкиToolStripMenuItem});
            this.windowsMenuItem.Name = "windowsMenuItem";
            this.windowsMenuItem.Size = new System.Drawing.Size(75, 20);
            this.windowsMenuItem.Text = "Прозорци";
            // 
            // каскадноПодрежданеToolStripMenuItem
            // 
            this.каскадноПодрежданеToolStripMenuItem.Name = "каскадноПодрежданеToolStripMenuItem";
            this.каскадноПодрежданеToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.каскадноПодрежданеToolStripMenuItem.Text = "Каскадно подреждане";
            this.каскадноПодрежданеToolStripMenuItem.Click += new System.EventHandler(this.cascadeLayoutMenuItem_Click);
            // 
            // вертикалноПодрежданеToolStripMenuItem
            // 
            this.вертикалноПодрежданеToolStripMenuItem.Name = "вертикалноПодрежданеToolStripMenuItem";
            this.вертикалноПодрежданеToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.вертикалноПодрежданеToolStripMenuItem.Text = "Вертикално подреждане";
            this.вертикалноПодрежданеToolStripMenuItem.Click += new System.EventHandler(this.verticalLayoutMenuItem_Click);
            // 
            // хоризонталноПодрежданеToolStripMenuItem
            // 
            this.хоризонталноПодрежданеToolStripMenuItem.Name = "хоризонталноПодрежданеToolStripMenuItem";
            this.хоризонталноПодрежданеToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.хоризонталноПодрежданеToolStripMenuItem.Text = "Хоризонтално подреждане";
            this.хоризонталноПодрежданеToolStripMenuItem.Click += new System.EventHandler(this.horizontalLayoutMenuItem_Click);
            // 
            // затварянеНаВсичкиToolStripMenuItem
            // 
            this.затварянеНаВсичкиToolStripMenuItem.Name = "затварянеНаВсичкиToolStripMenuItem";
            this.затварянеНаВсичкиToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.затварянеНаВсичкиToolStripMenuItem.Text = "Затваряне на всички";
            this.затварянеНаВсичкиToolStripMenuItem.Click += new System.EventHandler(this.closeAllWindowsMenuItem_Click);
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
            this.aboutMenuItem.Size = new System.Drawing.Size(140, 22);
            this.aboutMenuItem.Text = "За продукта";
            this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
            // 
            // productsListMenuItem
            // 
            this.productsListMenuItem.Name = "productsListMenuItem";
            this.productsListMenuItem.Size = new System.Drawing.Size(190, 22);
            this.productsListMenuItem.Text = "Списък";
            this.productsListMenuItem.Click += new System.EventHandler(this.productsListMenuItem_Click);
            // 
            // търсенеToolStripMenuItem
            // 
            this.търсенеToolStripMenuItem.Name = "търсенеToolStripMenuItem";
            this.търсенеToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.търсенеToolStripMenuItem.Text = "Търсене";
            this.търсенеToolStripMenuItem.Click += new System.EventHandler(this.търсенеToolStripMenuItem_Click);
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
        private System.Windows.Forms.ToolStripMenuItem каскадноПодрежданеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вертикалноПодрежданеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem хоризонталноПодрежданеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem затварянеНаВсичкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem продуктиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProductMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsListMenuItem;
        private System.Windows.Forms.ToolStripMenuItem търсенеToolStripMenuItem;

    }
}