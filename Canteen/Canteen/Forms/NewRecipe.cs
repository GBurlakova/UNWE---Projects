namespace Canteen.Forms
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Windows.Forms;
    using Canteen.Common;

    public partial class NewRecipe : Form
    {
        private const string FormTitle = "Вход";
        private const int FormWidth = 455;
        private const int FormHeight = 431;

        public NewRecipe()
        {
            InitializeComponent();

            // Form settings
            this.Width = FormWidth;
            this.Height = FormHeight;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Text = FormTitle;
            this.BackColor = ColorFactory.GetColor(CommonColors.BackgroundGrey);
            // Content wrapper
            contentWrapper.BackColor = Color.White;
            contentWrapper.Width = (int)(FormWidth * Constants.WrapperSizeCoefficient);
            contentWrapper.Height = (int)(FormHeight * Constants.WrapperSizeCoefficient);
            // Center the wrapper within the parent form
            contentWrapper.Left = (this.ClientSize.Width - contentWrapper.Width) / 2;
            contentWrapper.Top = (this.ClientSize.Height - contentWrapper.Height) / 2;
            // Recipe label
            recipeLabel.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 16);
            recipeLabel.ForeColor = ColorFactory.GetColor(CommonColors.GreyFontColor);
            // Product label
            productLabel.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 16);
            productLabel.ForeColor = ColorFactory.GetColor(CommonColors.GreyFontColor);
            // Quantity label
            quantityLabel.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 16);
            quantityLabel.ForeColor = ColorFactory.GetColor(CommonColors.GreyFontColor);
            // New recipe button
            newRecipeButton.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 20);
            newRecipeButton.ForeColor = ColorFactory.GetColor(CommonColors.BackgroundGrey);
            newRecipeButton.BackColor = ColorFactory.GetColor(CommonColors.DarkGrey);
            // Fill combo boxes
            FillRecipeCombobox();
            recipe.SelectedIndex = 0;
            FillProductComboBox();
            // Set tooltips
            toolTip.SetToolTip(recipe, Constants.RecipeToolTip);
            toolTip.SetToolTip(product, Constants.ProductToolTip);
            toolTip.SetToolTip(quantity, Constants.RecipeProductQuantityToolTip);
        }

        private bool ValidateRecipeData()
        {
            bool isValidProductQuantity =
                CommonUserInteractionMethods.ValidateRequiredInputField(
                    error,
                    Constants.RequiredRecipeProductQuantityMessage,
                    quantity);

            return isValidProductQuantity;
        }

        private void FillProductComboBox()
        {
            SqlConnection connection = CommonDatabaseActions.CreateDatabaseConnection("Canteen");
            SqlCommand getAvailableProductsCommand = new SqlCommand("GetAvailableRecipeProducts", connection);
            getAvailableProductsCommand.CommandType = CommandType.StoredProcedure;
            getAvailableProductsCommand.CommandText = "GetAvailableRecipeProducts";

            SqlParameter RecipeCode = new SqlParameter("@recipeCode", DbType.Int32);
            RecipeCode.Value = recipe.SelectedValue;
            getAvailableProductsCommand.Parameters.Add(RecipeCode);

            using (connection)
            {
                try
                {
                    connection.Open();
                    SqlDataReader reader = getAvailableProductsCommand.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    product.DisplayMember = "Наименование";
                    product.ValueMember = "Код";
                    product.DataSource = dataTable;
                }
                catch (SqlException se)
                {
                    MessageBox.Show(se.ToString());
                }
            }
        }

        private void FillRecipeCombobox()
        {
            SqlConnection connection = CommonDatabaseActions.CreateDatabaseConnection("Canteen");
            SqlCommand getRecipesCommand = new SqlCommand("GetMealsWithoutRecipe", connection);
            getRecipesCommand.CommandType = CommandType.StoredProcedure;
            getRecipesCommand.CommandText = "GetMealsWithoutRecipe";

            using (connection)
            {
                try
                {
                    connection.Open();
                    SqlDataReader reader = getRecipesCommand.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    recipe.DisplayMember = "Наименование";
                    recipe.ValueMember = "Код";
                    recipe.DataSource = dataTable;
                }
                catch (SqlException se)
                {
                    MessageBox.Show(se.ToString());
                }
            }
        }

        private SqlCommand CreateInsertNewRecipeCommand(SqlConnection connection)
        {
            try
            {
                SqlCommand insertNewRecipeCommand = new SqlCommand("InsertRecipe", connection);
                insertNewRecipeCommand.CommandType = CommandType.StoredProcedure;
                insertNewRecipeCommand.CommandText = "InsertRecipe";

                SqlParameter RecipeCode = new SqlParameter("@recipeCode", DbType.Int32);
                RecipeCode.Value = recipe.SelectedValue;
                insertNewRecipeCommand.Parameters.Add(RecipeCode);

                SqlParameter ProductCode = new SqlParameter("@productCode", DbType.Int32);
                ProductCode.Value = product.SelectedValue;
                insertNewRecipeCommand.Parameters.Add(ProductCode);

                SqlParameter Quantity = new SqlParameter("@quantity", DbType.Int32);
                Quantity.Value = Int32.Parse(quantity.Text);
                insertNewRecipeCommand.Parameters.Add(Quantity);

                return insertNewRecipeCommand;
            }
            catch (FormatException formatException)
            {
                throw new FormatException();
            }
        }

        private void recipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillProductComboBox();
        }

        private void newRecipeButton_Click(object sender, EventArgs e)
        {
            DialogResult result = CommonUserInteractionMethods.ConfirmAction(Constants.ConfirmInsertNewRecipeMessage);

            if (result.Equals(DialogResult.OK))
            {
                bool isValidRecipeProductData = ValidateRecipeData();
                if (isValidRecipeProductData)
                {
                    SqlConnection connection = CommonDatabaseActions.CreateDatabaseConnection("Canteen");

                    try
                    {
                        SqlCommand insertNewRecipeCommand = CreateInsertNewRecipeCommand(connection);
                        using (connection)
                        {
                            connection.Open();
                            insertNewRecipeCommand.ExecuteNonQuery();
                            MessageBox.Show(Constants.RecipeInsertedSuccessfullyMessage);
                            this.Close();
                        }
                    }
                    catch (FormatException formatException)
                    {
                        MessageBox.Show(Constants.InvalidRecipeProductQuantityMessage);
                    }
                    catch (SqlException sqlException)
                    {
                        MessageBox.Show(sqlException.ToString());
                    }  
                } 
             }
        }
    }
}
