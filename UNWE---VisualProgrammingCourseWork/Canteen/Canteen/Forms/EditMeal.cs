namespace Canteen.Forms
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Windows.Forms;
    using Canteen.Common;

    public partial class EditMeal : Form
    {
        private const string FormTitle = "Редактиране на ястие";
        private const int FormWidth = 880;
        private const int FormHeight = 370;

        public EditMeal(string mealCode, string mealName, string quantity, string type, string portions, string calories, string date)
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
            // Edit button
            editButton.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 16);
            editButton.ForeColor = ColorFactory.GetColor(CommonColors.BackgroundGrey);
            editButton.BackColor = ColorFactory.GetColor(CommonColors.DarkGrey);
            // Meal table
            meal.Rows[0].Cells[0].Value = mealCode;
            meal.Rows[0].Cells[1].Value = mealName;
            meal.Rows[0].Cells[2].Value = quantity;
            meal.Rows[0].Cells[3].Value = calories;
            meal.Rows[0].Cells[4].Value = type;
            meal.Rows[0].Cells[5].Value = portions;
            meal.Rows[0].Cells[6].Value = date;
        }

        private SqlCommand CreateMealEditCommand(SqlConnection connection)
        {
            try
            {
                SqlCommand mealEditCommand = new SqlCommand("EditMeal", connection);
                mealEditCommand.CommandType = CommandType.StoredProcedure;
                mealEditCommand.CommandText = "EditMeal";

                SqlParameter MealCode = new SqlParameter("@mealCode", SqlDbType.Int);
                MealCode.Value = Int32.Parse(meal.Rows[0].Cells[0].Value.ToString());
                mealEditCommand.Parameters.Add(MealCode);

                SqlParameter MealName = new SqlParameter("@mealName", SqlDbType.NVarChar);
                MealName.Value = meal.Rows[0].Cells[1].Value;
                mealEditCommand.Parameters.Add(MealName);

                SqlParameter Quantity = new SqlParameter("@quantity", SqlDbType.Int);
                Quantity.Value = Int32.Parse(meal.Rows[0].Cells[2].Value.ToString());
                mealEditCommand.Parameters.Add(Quantity);

                SqlParameter Calories = new SqlParameter("@calories", SqlDbType.Int);
                Calories.Value = Int32.Parse(meal.Rows[0].Cells[3].Value.ToString());
                mealEditCommand.Parameters.Add(Calories);

                SqlParameter Type = new SqlParameter("@type", SqlDbType.NVarChar);
                Type.Value = meal.Rows[0].Cells[4].Value;
                mealEditCommand.Parameters.Add(Type);

                SqlParameter Portions = new SqlParameter("@portions", SqlDbType.Int);
                Portions.Value = Int32.Parse(meal.Rows[0].Cells[5].Value.ToString());
                mealEditCommand.Parameters.Add(Portions);

                return mealEditCommand;
            }
            catch (FormatException)
            {
                
                throw new FormatException();
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            DialogResult result = CommonUserInteractionMethods.ConfirmAction(Constants.ConfirmMealEditMеssage);

            if (result.Equals(DialogResult.OK))
            {
                SqlConnection connection = CommonDatabaseActions.CreateDatabaseConnection("Canteen");
                using (connection)
                {
                    
                    try
                    {
                        SqlCommand productEditCommand = CreateMealEditCommand(connection);
                        connection.Open();
                        SqlDataReader reader = productEditCommand.ExecuteReader();
                        MessageBox.Show(Constants.MealEditеdSuccessfullyMеssage);
                    }
                    catch (FormatException formatException)
                    {
                        MessageBox.Show(Constants.InvalidMealDataFormat);
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
    }
}
