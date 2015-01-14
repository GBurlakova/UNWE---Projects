namespace Canteen.Forms
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Windows.Forms;
    using Canteen.Common;

    public partial class SearchMeals : Form
    {
        private const string FormTitle = "Продукти";
        private const int FormWidth = 850;
        private const int FormHeight = 500;

        public SearchMeals()
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
            // Menu strip
            toolStrip.BackColor = ColorFactory.GetColor(CommonColors.DarkGrey);
            toolStrip.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 12);
            toolStrip.ForeColor = ColorFactory.GetColor(CommonColors.BackgroundGrey);
            // Meal name label
            mealNameLabel.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 16);
            mealNameLabel.ForeColor = ColorFactory.GetColor(CommonColors.GreyFontColor);
            // Meal type label
            typeLabel.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 16);
            typeLabel.ForeColor = ColorFactory.GetColor(CommonColors.GreyFontColor);
            // Calories label
            caloriesLabel.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 16);
            caloriesLabel.ForeColor = ColorFactory.GetColor(CommonColors.GreyFontColor);// Calories label
            caloriesHelpFromLabel.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 16);
            caloriesHelpFromLabel.ForeColor = ColorFactory.GetColor(CommonColors.GreyFontColor);// Calories label
            caloriesHelpToLabel.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 16);
            caloriesHelpToLabel.ForeColor = ColorFactory.GetColor(CommonColors.GreyFontColor);
            // Quantity label
            quantityLabel.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 16);
            quantityLabel.ForeColor = ColorFactory.GetColor(CommonColors.GreyFontColor);
            quantityHelpFromLabel.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 16);
            quantityHelpFromLabel.ForeColor = ColorFactory.GetColor(CommonColors.GreyFontColor);
            quantityHelpToLabel.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 16);
            quantityHelpToLabel.ForeColor = ColorFactory.GetColor(CommonColors.GreyFontColor);
            // Search button
            searchButton.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 16);
            searchButton.ForeColor = ColorFactory.GetColor(CommonColors.BackgroundGrey);
            searchButton.BackColor = ColorFactory.GetColor(CommonColors.DarkGrey);
            // Clear button
            clearFiltersButton.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 12);
            clearFiltersButton.ForeColor = ColorFactory.GetColor(CommonColors.BackgroundGrey);
            clearFiltersButton.BackColor = ColorFactory.GetColor(CommonColors.DarkGrey);
        }

        private void clearFiltersButton_Click(object sender, System.EventArgs e)
        {
            mealName.Clear();
            type.Clear();
            caloriesStartRange.Clear();
            caloriesEndRange.Clear();
            quantityStartRange.Clear();
            quantityEndRange.Clear();
            mealsTable.DataSource = null;
        }


        private void searchButton_Click(object sender, System.EventArgs e)
        {
             SqlConnection connection = CommonDatabaseActions.CreateDatabaseConnection("Canteen");
            using (connection)
            {
                SqlCommand searchMealsCommand = CreateSearchMealsCommand(connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = searchMealsCommand.ExecuteReader();
                    mealsTable.DataSource = null;
                    if (reader.HasRows)
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        mealsTable.DataSource = dataTable;
                    }
                }
                catch (SqlException se)
                {
                    MessageBox.Show(se.ToString());
                }
                catch (FormatException formatException)
                {
                    MessageBox.Show("Format exeption");
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private SqlCommand CreateSearchMealsCommand(SqlConnection connection)
        {
            SqlCommand searchMealsCommand = new SqlCommand("SearchMeals", connection);
            searchMealsCommand.CommandType = CommandType.StoredProcedure;
            searchMealsCommand.CommandText = "SearchMeals";

            SqlParameter MealName = new SqlParameter("@mealName", SqlDbType.NVarChar);
            if (string.IsNullOrEmpty(mealName.Text))
            {
                MealName.Value = DBNull.Value;
            }
            else
            {
                MealName.Value = mealName.Text;
            }

            searchMealsCommand.Parameters.Add(MealName);


            SqlParameter Type = new SqlParameter("@mealType", SqlDbType.NVarChar);
            if (string.IsNullOrEmpty(type.Text))
            {
                Type.Value = DBNull.Value;
            }
            else
            {
                Type.Value = type.Text;
            }

            searchMealsCommand.Parameters.Add(Type);

            SqlParameter CaloriesStartRange = new SqlParameter("@caloriesStartRange", SqlDbType.Int);
            if (string.IsNullOrEmpty(caloriesStartRange.Text))
            {
                CaloriesStartRange.Value = DBNull.Value;
            }
            else
            {
                CaloriesStartRange.Value = Int32.Parse(caloriesStartRange.Text);
            }

            searchMealsCommand.Parameters.Add(CaloriesStartRange);

            SqlParameter CaloriesEndRange = new SqlParameter("@caloriesEndRange", SqlDbType.Int);
            if (string.IsNullOrEmpty(caloriesEndRange.Text))
            {
                CaloriesEndRange.Value = DBNull.Value;
            }
            else
            {
                CaloriesEndRange.Value = Int32.Parse(caloriesEndRange.Text);
            }

            searchMealsCommand.Parameters.Add(CaloriesEndRange);

            SqlParameter QuantityStartRange = new SqlParameter("@quantityStartRange", SqlDbType.Int);
            if (string.IsNullOrEmpty(quantityStartRange.Text))
            {
                QuantityStartRange.Value = DBNull.Value;
            }
            else
            {
                QuantityStartRange.Value = Int32.Parse(quantityStartRange.Text);
            }

            searchMealsCommand.Parameters.Add(QuantityStartRange);

            SqlParameter QuantityEndRange = new SqlParameter("@quantityEndRange", SqlDbType.Int);
            if (string.IsNullOrEmpty(quantityEndRange.Text))
            {
                QuantityEndRange.Value = DBNull.Value;
            }
            else
            {
                QuantityEndRange.Value = Int32.Parse(quantityEndRange.Text);
            }

            searchMealsCommand.Parameters.Add(QuantityEndRange);


            return searchMealsCommand;
        }

        private void newMealButton_Click(object sender, EventArgs e)
        {
            var newMealForm = new NewMeal();
            newMealForm.Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = CommonUserInteractionMethods.ConfirmAction(Constants.ConfimrDeleteMealMessage);

            if (result.Equals(DialogResult.OK))
            {
                SqlConnection connection = CommonDatabaseActions.CreateDatabaseConnection("Canteen");
                using (connection)
                {
                    SqlCommand mealDeleteCommand = CreateDeleteMealCommand(connection);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = mealDeleteCommand.ExecuteReader();
                        MessageBox.Show(Constants.MealDeletedSuccessfullyMessage);
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

        private SqlCommand CreateDeleteMealCommand(SqlConnection connection)
        {
            SqlCommand mealDeleteCommand = new SqlCommand("DeleteMeal", connection);
            mealDeleteCommand.CommandType = CommandType.StoredProcedure;
            mealDeleteCommand.CommandText = "DeleteMeal";

            SqlParameter MealCode = new SqlParameter("@mealCode", SqlDbType.Int);
            MealCode.Value = Int32.Parse(mealsTable.CurrentRow.Cells[0].Value.ToString());
            mealDeleteCommand.Parameters.Add(MealCode);

            return mealDeleteCommand;
        }

        private void mealsTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string mealCode = mealsTable.CurrentRow.Cells[0].Value.ToString();
            string mealName = mealsTable.CurrentRow.Cells[1].Value.ToString();
            string quantity = mealsTable.CurrentRow.Cells[2].Value.ToString();
            string calories = mealsTable.CurrentRow.Cells[3].Value.ToString();
            string type = mealsTable.CurrentRow.Cells[4].Value.ToString();
            string portions = mealsTable.CurrentRow.Cells[5].Value.ToString();
            string date = DateTime.Parse(mealsTable.CurrentRow.Cells[6].Value.ToString()).ToShortDateString();
            var editMealForm = new EditMeal(mealCode, mealName, quantity, type, portions, calories, date);
            editMealForm.ShowDialog();
        }
    }
}
