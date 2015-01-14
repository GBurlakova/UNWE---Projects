namespace Canteen.Forms
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Windows.Forms;
    using Canteen.Common;

    public partial class EditRecipeProduct : Form
    {
        private const string FormTitle = "Количество на продукт";
        private const int FormWidth = 485;
        private const int FormHeight = 215;

        private int recipeCode;
        private int productCode;

        public EditRecipeProduct(int recipeCode, int productCode)
        {
            InitializeComponent();

            this.recipeCode = recipeCode;
            this.productCode = productCode;

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
            // Quantity label
            quantityLabel.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 16);
            quantityLabel.ForeColor = ColorFactory.GetColor(CommonColors.GreyFontColor);
            // Delete button
            editRecipeProductButton.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 12);
            editRecipeProductButton.ForeColor = ColorFactory.GetColor(CommonColors.BackgroundGrey);
            editRecipeProductButton.BackColor = ColorFactory.GetColor(CommonColors.DarkGrey);
        }

        private void editRecipeProductButton_Click(object sender, System.EventArgs e)
        {
            SqlConnection connection = CommonDatabaseActions.CreateDatabaseConnection("Canteen");

            using (connection)
            {
                try
                {
                    SqlCommand editrRecipeCommand = CreateEditRecipeProductCommand(connection);
                    connection.Open();
                    editrRecipeCommand.ExecuteNonQuery();
                    MessageBox.Show(Constants.RecipeProductEditedSuccessfullyMessage);
                    this.Close();
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

        private SqlCommand CreateEditRecipeProductCommand(SqlConnection connection)
        {
            try
            {
                SqlCommand editRecipeProductCommand = new SqlCommand("EditRecipeProduct", connection);
                editRecipeProductCommand.CommandType = CommandType.StoredProcedure;
                editRecipeProductCommand.CommandText = "EditRecipeProduct";

                SqlParameter RecipeCode = new SqlParameter("@recipeCode", DbType.Int32);
                RecipeCode.Value = this.recipeCode;
                editRecipeProductCommand.Parameters.Add(RecipeCode);

                SqlParameter ProductCode = new SqlParameter("@productCode", DbType.Int32);
                ProductCode.Value = this.productCode;
                editRecipeProductCommand.Parameters.Add(ProductCode);

                SqlParameter Quantity = new SqlParameter("@quantity", DbType.Int32);
                Quantity.Value = Int32.Parse(quantity.Text);
                editRecipeProductCommand.Parameters.Add(Quantity);

                return editRecipeProductCommand;
            }
            catch (FormatException formatException)
            {
                throw new FormatException();
            }
        }
    }
}
