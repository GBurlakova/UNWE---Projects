namespace Canteen.Forms
{
    using Canteen.Common;
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class MainScreen : Form
    {
        private const string FormTitle = "Контролен панел";
        private const int FromWidth = 980;
        private const int FormHeight = 700;

        public MainScreen()
        {
            InitializeComponent();
            // Form settings
            this.Width = FromWidth;
            this.Height = FormHeight;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Text = FormTitle;
            this.BackColor = ColorFactory.GetColor(CommonColors.BackgroundGrey);
            // Main menu
            mainMenu.BackColor = ColorFactory.GetColor(CommonColors.DarkGrey);
            mainMenu.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 12);
            mainMenu.ForeColor = ColorFactory.GetColor(CommonColors.BackgroundGrey);
        }

        private void cascadeLayoutMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalLayoutMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalLayoutMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void closeAllWindowsMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form subForm in this.MdiChildren)
            {
                if (subForm.IsMdiContainer != true)
                {
                    subForm.Close();
                }
            }
        }

        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            var aboutScreen = new AboutScreen();
            aboutScreen.MdiParent = this;
            aboutScreen.StartPosition = FormStartPosition.CenterParent;
            aboutScreen.Show();
        }

        private void newProductMenuItem_Click(object sender, EventArgs e)
        {
            var newProductForm = new NewProduct();
            newProductForm.MdiParent = this;
            newProductForm.Show();
        }

        private void productsListMenuItem_Click(object sender, EventArgs e)
        {
            var allProducts = new AllProducts();
            allProducts.StartPosition = FormStartPosition.CenterScreen;
            allProducts.ShowDialog();
        }
    }
}
