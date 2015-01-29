namespace Canteen.Forms
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Windows.Forms;
    using Canteen.Common;

    public partial class AllMeals : Form
    {
        private const string FormTitle = "Ястия";
        private const int FormWidth = 900;
        private const int FormHeight = 500;

        public AllMeals()
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
            // Meal code label
            mealCodeLabel.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 16);
            mealCodeLabel.ForeColor = ColorFactory.GetColor(CommonColors.GreyFontColor);
            // Meal name label
            mealNameLabel.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 16);
            mealNameLabel.ForeColor = ColorFactory.GetColor(CommonColors.GreyFontColor);
            // Quantity label
            quantityLabel.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 16);
            quantityLabel.ForeColor = ColorFactory.GetColor(CommonColors.GreyFontColor);
            // Calories label
            caloriesLabel.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 16);
            caloriesLabel.ForeColor = ColorFactory.GetColor(CommonColors.GreyFontColor);
            // Type label
            typeLabel.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 16);
            typeLabel.ForeColor = ColorFactory.GetColor(CommonColors.GreyFontColor);
            // Portions label
            portionsLabel.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 16);
            portionsLabel.ForeColor = ColorFactory.GetColor(CommonColors.GreyFontColor);
            // Modifiecation date label
            modificationDateLabel.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 16);
            modificationDateLabel.ForeColor = ColorFactory.GetColor(CommonColors.GreyFontColor);
            // Edit button
            editButton.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 16);
            editButton.ForeColor = ColorFactory.GetColor(CommonColors.BackgroundGrey);
            editButton.BackColor = ColorFactory.GetColor(CommonColors.DarkGrey);
            // Delete button
            deleteButton.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 16);
            deleteButton.ForeColor = ColorFactory.GetColor(CommonColors.BackgroundGrey);
            deleteButton.BackColor = ColorFactory.GetColor(CommonColors.DarkGrey);
        }

        private void AllMeals_Load(object sender, System.EventArgs e)
        {
            // TODO: This line of code loads data into the 'canteenDataSet.Ястия' table. You can move, or remove it, as needed.
            this.mealsTableAdapter.Fill(this.canteenDataSet.Ястия);
        }

        private void editButton_Click(object sender, System.EventArgs e)
        {
            DialogResult result = CommonUserInteractionMethods.ConfirmAction(Constants.ConfirmMealEditMеssage);

            if (result.Equals(DialogResult.OK))
            {
                SqlConnection connection = CommonDatabaseActions.CreateDatabaseConnection("Canteen");
                using (connection)
                {
                    SqlCommand productEditCommand = CreateMealEditCommand(connection);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = productEditCommand.ExecuteReader();
                        MessageBox.Show(Constants.MealEditеdSuccessfullyMеssage);
                        this.mealsTableAdapter.Fill(this.canteenDataSet.Ястия);
                    }
                    catch (SqlException se)
                    {
                        MessageBox.Show(se.ToString());
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        private SqlCommand CreateMealEditCommand(SqlConnection connection)
        {
            SqlCommand mealEditCommand = new SqlCommand("EditMeal", connection);
            mealEditCommand.CommandType = CommandType.StoredProcedure;
            mealEditCommand.CommandText = "EditMeal";

            SqlParameter MealCode = new SqlParameter("@mealCode", SqlDbType.Int);
            MealCode.Value = Int32.Parse(mealCode.Text);
            mealEditCommand.Parameters.Add(MealCode);

            SqlParameter MealName = new SqlParameter("@mealName", SqlDbType.NVarChar);
            MealName.Value = mealName.Text;
            mealEditCommand.Parameters.Add(MealName);

            SqlParameter Quantity = new SqlParameter("@quantity", SqlDbType.Int);
            Quantity.Value = Int32.Parse(quantity.Text);
            mealEditCommand.Parameters.Add(Quantity);

            SqlParameter Calories = new SqlParameter("@calories", SqlDbType.Int);
            Calories.Value = Int32.Parse(calories.Text);
            mealEditCommand.Parameters.Add(Calories);

            SqlParameter Type = new SqlParameter("@type", SqlDbType.NVarChar);
            Type.Value = type.Text;
            mealEditCommand.Parameters.Add(Type);

            SqlParameter Portions = new SqlParameter("@portions", SqlDbType.Int);
            Portions.Value = Int32.Parse(portions.Text);
            mealEditCommand.Parameters.Add(Portions);

            return mealEditCommand;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = CommonUserInteractionMethods.ConfirmAction(Constants.ConfimrDeleteMealMessage);

            if (result.Equals(DialogResult.OK))
            {
                SqlConnection connection = CommonDatabaseActions.CreateDatabaseConnection("Canteen");
                using (connection)
                {
                    SqlCommand mealDeleteCommand = CreateMealDeleteCommand(connection);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = mealDeleteCommand.ExecuteReader();
                        MessageBox.Show(Constants.MealDeletedSuccessfullyMessage);
                        this.mealsTableAdapter.Fill(this.canteenDataSet.Ястия);
                    }
                    catch (SqlException se)
                    {
                        MessageBox.Show(se.ToString());
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        private SqlCommand CreateMealDeleteCommand(SqlConnection connection)
        {
            SqlCommand mealDeleteCommand = new SqlCommand("DeleteMeal", connection);
            mealDeleteCommand.CommandType = CommandType.StoredProcedure;
            mealDeleteCommand.CommandText = "DeleteMeal";

            SqlParameter MealCode = new SqlParameter("@mealCode", SqlDbType.Int);
            MealCode.Value = Int32.Parse(mealCode.Text);
            mealDeleteCommand.Parameters.Add(MealCode);

            return mealDeleteCommand;
        }
    }
}
