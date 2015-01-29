namespace Canteen.Forms
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Drawing;
    using Canteen.Common;
    using System.Windows.Forms;

    public partial class AllRecipes : Form
    {
        private const string FormTitle = "Рецепти";
        private const int FormWidth = 850;
        private const int FormHeight = 540;

        private BindingSource recipesBindingSource;

        public AllRecipes()
        {
            InitializeComponent();

            this.recipesBindingSource = new BindingSource();
            BindRecipesData();
            recipeCode.DataBindings.Add(new Binding("text", recipesBindingSource, "Код"));
            recipeName.DataBindings.Add(new Binding("text", recipesBindingSource, "Наименование")); 

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
            // Product label
            productLabel.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 16);
            productLabel.ForeColor = ColorFactory.GetColor(CommonColors.GreyFontColor);
            // Quantity label
            quantityLabel.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 16);
            quantityLabel.ForeColor = ColorFactory.GetColor(CommonColors.GreyFontColor);
            // Recipe code label
            recipeCodeLabel.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 16);
            recipeCodeLabel.ForeColor = ColorFactory.GetColor(CommonColors.GreyFontColor);
            // Recipe name label
            recipeNameLabel.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 16);
            recipeNameLabel.ForeColor = ColorFactory.GetColor(CommonColors.GreyFontColor);
            // Delete recipe button
            deleteRecipeButton.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 12);
            deleteRecipeButton.ForeColor = ColorFactory.GetColor(CommonColors.BackgroundGrey);
            deleteRecipeButton.BackColor = ColorFactory.GetColor(CommonColors.DarkGrey);
            // Show add product panel button
            showAddProductPanelButton.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 12);
            showAddProductPanelButton.ForeColor = ColorFactory.GetColor(CommonColors.BackgroundGrey);
            showAddProductPanelButton.BackColor = ColorFactory.GetColor(CommonColors.DarkGrey);
            // Delete recipe product button
            deleteRecipeProductButton.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 12);
            deleteRecipeProductButton.ForeColor = ColorFactory.GetColor(CommonColors.BackgroundGrey);
            deleteRecipeProductButton.BackColor = ColorFactory.GetColor(CommonColors.DarkGrey);
            // Edit recipe product button
            editRecipeProductButton.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 12);
            editRecipeProductButton.ForeColor = ColorFactory.GetColor(CommonColors.BackgroundGrey);
            editRecipeProductButton.BackColor = ColorFactory.GetColor(CommonColors.DarkGrey);
            // Add recipe product button
            addRecipeProductButton.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 12);
            addRecipeProductButton.ForeColor = ColorFactory.GetColor(CommonColors.BackgroundGrey);
            addRecipeProductButton.BackColor = ColorFactory.GetColor(CommonColors.DarkGrey);
            // New product panel
            FillProductsComboBox();
            newProductPanel.Hide();
        }

        private void recipeCode_TextChanged(object textboxsender, System.EventArgs e)
        {
            FillRecipeProductsTable();
        }

        private void FillRecipeProductsTable()
        {
            SqlConnection connection = CommonDatabaseActions.CreateDatabaseConnection("Canteen");
            using (connection)
            {
                SqlCommand authenticationCommand = CreateGetRecipesCommand(connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = authenticationCommand.ExecuteReader();
                    if (reader.HasRows)
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        recipeProducts.DataSource = dataTable;
                    }
                }
                catch (SqlException se)
                {
                    MessageBox.Show(se.ToString());
                }
            }
        }

        private SqlCommand CreateGetRecipesCommand(SqlConnection connection)
        {
            SqlCommand getRecipesCommand = new SqlCommand("GetRecipeProductsProcedure", connection);
            getRecipesCommand.CommandType = CommandType.StoredProcedure;
            getRecipesCommand.CommandText = "GetRecipeProductsProcedure";

            SqlParameter RecipeCode = new SqlParameter("@recipeCode", SqlDbType.NVarChar);
            RecipeCode.Value = Int32.Parse(recipeCode.Text);
            getRecipesCommand.Parameters.Add(RecipeCode);

            return getRecipesCommand;
        }

        private void showAddProductPanelButton_Click(object sender, EventArgs e)
        {
            newProductPanel.Show();
        }

        private void BindRecipesData()
        {
            this.recipesBindingSource.DataSource = GetRecipes();
            recipesBindingNavigator.BindingSource = recipesBindingSource;
        }

        private DataTable GetRecipes()
        {
            SqlConnection connection = CommonDatabaseActions.CreateDatabaseConnection("Canteen");
            SqlCommand getRecipes = new SqlCommand("GetRecipes", connection);
            getRecipes.CommandType = CommandType.StoredProcedure;
            getRecipes.CommandText = "GetRecipes";

            try
            {
                using (connection)
                {
                    connection.Open();
                    SqlDataReader reader = getRecipes.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    return dataTable;
                }
            }
            catch (SqlException sqlException)
            {
                MessageBox.Show(sqlException.ToString());
                throw;
            }
        }

        private void FillProductsComboBox()
        {
            SqlConnection connection = CommonDatabaseActions.CreateDatabaseConnection("Canteen");
            SqlCommand getProductsCommand = new SqlCommand("GetProducts", connection);
            getProductsCommand.CommandType = CommandType.StoredProcedure;
            getProductsCommand.CommandText = "GetProducts";
            using (connection)
            {
                try
                {
                    connection.Open();
                    SqlDataReader reader = getProductsCommand.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    products.DisplayMember = "Наименование";
                    products.ValueMember = "Код";
                    products.DataSource = dataTable;
                }
                catch (SqlException se)
                {
                    MessageBox.Show(se.ToString());
                }
            }
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            DialogResult result = CommonUserInteractionMethods.ConfirmAction(Constants.ConfirmAddProductToRecipeMessage);
            if (result.Equals(DialogResult.OK))
            {
                SqlConnection connection = CommonDatabaseActions.CreateDatabaseConnection("Canteen");
                
                using (connection)
                {
                    try
                    {
                        SqlCommand addProductToRecipeCommand = CreateAddProductToRecipeCommand(connection);
                        connection.Open();
                        addProductToRecipeCommand.ExecuteNonQuery();
                        MessageBox.Show(Constants.ProductDeletedFromRecipeSuccessfullyMessage);
                        FillRecipeProductsTable();
                    }
                    catch (FormatException formatException)
                    {
                        MessageBox.Show(Constants.InvalidRecipeProductDataMessage);
                        quantity.Clear();
                    }
                    catch (SqlException se)
                    {
                        MessageBox.Show(se.ToString());
                    }
                }
            }
        }

        private SqlCommand CreateAddProductToRecipeCommand(SqlConnection connection)
        {
            try
            {
                SqlCommand addProductToRecipeCommand = new SqlCommand("AddProductToRecipe", connection);
                addProductToRecipeCommand.CommandType = CommandType.StoredProcedure;
                addProductToRecipeCommand.CommandText = "AddProductToRecipe";

                SqlParameter RecipeCode = new SqlParameter("@recipeCode", DbType.Int32);
                RecipeCode.Value = Int32.Parse(recipeCode.Text);
                addProductToRecipeCommand.Parameters.Add(RecipeCode);

                SqlParameter ProductCode = new SqlParameter("@productCode", DbType.Int32);
                ProductCode.Value = Int32.Parse(products.SelectedValue.ToString());
                addProductToRecipeCommand.Parameters.Add(ProductCode);

                SqlParameter Quantity = new SqlParameter("@quantity", DbType.Int32);
                Quantity.Value = Int32.Parse(quantity.Text);
                addProductToRecipeCommand.Parameters.Add(Quantity);

                return addProductToRecipeCommand;
            }
            catch (FormatException)
            {
                throw new FormatException();
            }  
        }

        private void deleteRecipeButton_Click(object sender, EventArgs e)
        {
            DialogResult result = CommonUserInteractionMethods.ConfirmAction(Constants.ConfirmDeleteRecipeMessage);
            if (result.Equals(DialogResult.OK))
            {
                SqlConnection connection = CommonDatabaseActions.CreateDatabaseConnection("Canteen");
                SqlCommand deleteRecipeCommand = CreateDeleteRecipeCommand(connection);
                try
                {
                    using (connection)
                    {
                        connection.Open();
                        deleteRecipeCommand.ExecuteNonQuery();
                        MessageBox.Show(Constants.RecipeDeletedSuccessfullyMessage);
                        BindRecipesData();
                    }
                }
                catch (SqlException sqlException)
                {
                    MessageBox.Show(sqlException.ToString());
                }  
            }  
        }

        private SqlCommand CreateDeleteRecipeCommand(SqlConnection connection)
        {
            SqlCommand deleteRecipeCommand = new SqlCommand("DeleteRecipe", connection);
            deleteRecipeCommand.CommandType = CommandType.StoredProcedure;
            deleteRecipeCommand.CommandText = "DeleteRecipe";

            SqlParameter RecipeCode = new SqlParameter("@recipeCode", DbType.Int32);
            RecipeCode.Value = Int32.Parse(recipeCode.Text);
            deleteRecipeCommand.Parameters.Add(RecipeCode);

            return deleteRecipeCommand;
        }

        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            newProductPanel.Hide();
            SqlConnection connection = CommonDatabaseActions.CreateDatabaseConnection("Canteen");
            DialogResult result = CommonUserInteractionMethods.ConfirmAction(
                Constants.ConfirmDeleteRecipeProductMesssage);

            if (result.Equals(DialogResult.OK))
            {
                using (connection)
                {
                    try
                    {
                        SqlCommand deleteRecipeProductCommand = CreateDeleteRecipeProductCommand(connection);
                        connection.Open();
                        deleteRecipeProductCommand.ExecuteNonQuery();
                        MessageBox.Show(Constants.RecipeProductDeletedSuccessfullyMessage);
                        FillRecipeProductsTable();
                    }
                    catch (SqlException sqlException)
                    {

                        MessageBox.Show(sqlException.ToString());
                    }  
                }
            }

        }

        private SqlCommand CreateDeleteRecipeProductCommand(SqlConnection connection)
        {
            SqlCommand deleterecipeCommand = new SqlCommand("DeleteProductFromRecipe", connection);
            deleterecipeCommand.CommandType = CommandType.StoredProcedure;
            deleterecipeCommand.CommandText = "DeleteProductFromRecipe";

            SqlParameter RecipeCode = new SqlParameter("@recipeCode", DbType.Int32);
            RecipeCode.Value = Int32.Parse(recipeCode.Text);
            deleterecipeCommand.Parameters.Add(RecipeCode);

            SqlParameter ProductCode = new SqlParameter("@productCode", DbType.Int32);
            ProductCode.Value = Int32.Parse(recipeProducts.CurrentRow.Cells[0].Value.ToString());
            deleterecipeCommand.Parameters.Add(ProductCode);

            return deleterecipeCommand;
        }

        private void editProductButton_Click(object sender, EventArgs e)
        {
            newProductPanel.Hide();

            int recipeCodeValue = Int32.Parse(recipeCode.Text);
            int productCodeValue = Int32.Parse(recipeProducts.CurrentRow.Cells[0].Value.ToString());

            var editProductForm = new EditRecipeProduct(recipeCodeValue, productCodeValue);
            editProductForm.ShowDialog();

            FillRecipeProductsTable();
        }
    }
}
