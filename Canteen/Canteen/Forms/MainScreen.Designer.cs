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
            this.mealsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allMealsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMealMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.каскадноПодрежданеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вертикалноПодрежданеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.хоризонталноПодрежданеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.затварянеНаВсичкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mealsMenuItem,
            this.windowsMenuItem,
            this.helpMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1033, 24);
            this.mainMenu.TabIndex = 2;
            this.mainMenu.Text = "menuStrip1";
            // 
            // mealsMenuItem
            // 
            this.mealsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allMealsMenuItem,
            this.newMealMenuItem});
            this.mealsMenuItem.Name = "mealsMenuItem";
            this.mealsMenuItem.Size = new System.Drawing.Size(50, 20);
            this.mealsMenuItem.Text = "Ястия";
            // 
            // allMealsMenuItem
            // 
            this.allMealsMenuItem.Name = "allMealsMenuItem";
            this.allMealsMenuItem.Size = new System.Drawing.Size(152, 22);
            this.allMealsMenuItem.Text = "Преглед";
            // 
            // newMealMenuItem
            // 
            this.newMealMenuItem.Name = "newMealMenuItem";
            this.newMealMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newMealMenuItem.Text = "Ново ястие";
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
        private System.Windows.Forms.ToolStripMenuItem allMealsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newMealMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem каскадноПодрежданеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вертикалноПодрежданеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem хоризонталноПодрежданеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem затварянеНаВсичкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;

    }
}