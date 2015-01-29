namespace Canteen.Forms
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Windows.Forms;
    using Canteen.Common;

    public partial class NewMeal : Form
    {
        private const string FormTitle = "Ново ястие";
        private const int FormWidth = 800;
        private const int FormHeight = 500;

        public NewMeal()
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
            // New meal button button
            newMealButton.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 16);
            newMealButton.ForeColor = ColorFactory.GetColor(CommonColors.BackgroundGrey);
            newMealButton.BackColor = ColorFactory.GetColor(CommonColors.DarkGrey);
            // Set tool tips
            this.toolTip.SetToolTip(mealName, Constants.MealNameToolTip);
            this.toolTip.SetToolTip(quantity, Constants.QuantityToolTip);
            this.toolTip.SetToolTip(calories, Constants.CaloriesToolTip);
            this.toolTip.SetToolTip(type, Constants.TypeToolTip);
            this.toolTip.SetToolTip(portions, Constants.PortionsToolTip);
        }

        private void newMealButton_Click(object sender, System.EventArgs e)
        {
            bool isValidMealData = ValidateMealData();

            if (isValidMealData)
            {
                DialogResult confirmResult = CommonUserInteractionMethods.ConfirmAction(Constants.ConfirmCreateNewMealMessage);

                if (confirmResult.Equals(DialogResult.OK))
                {
                    SqlConnection connection = CommonDatabaseActions.CreateDatabaseConnection("Canteen");
                    using (connection)
                    {
                        try
                        {
                            SqlCommand mealInsertionCommand = CreateMealInsertionCommand(connection);
                            using (mealInsertionCommand)
                            {
                                connection.Open();
                                mealInsertionCommand.ExecuteNonQuery();
                                MessageBox.Show(Constants.NewMealCreatedSuccessfullyMessage);
                                mealName.Clear();
                                quantity.Clear();
                                calories.Clear();
                                type.Clear();
                                portions.Clear();
                                connection.Close();
                            }
                        }
                        catch (FormatException)
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

        private bool ValidateMealData()
        {
            bool isValidMealName =
                CommonUserInteractionMethods.ValidateRequiredInputField(
                    error,
                    Constants.RequiredMealNameMessage,
                    mealName);
            bool isValidQuantity =
                CommonUserInteractionMethods.ValidateRequiredInputField(
                    error,
                    Constants.RequiredMealQuantityMessage,
                    quantity);
            bool isValidType =
                CommonUserInteractionMethods.ValidateRequiredInputField(
                    error,
                    Constants.RequiredMealTypeMessage,
                    type);
            bool areValidCalories =
                CommonUserInteractionMethods.ValidateRequiredInputField(
                    error,
                    Constants.RequiredMealCaloriesMessage,
                    calories);
            bool areValidPortions =
                CommonUserInteractionMethods.ValidateRequiredInputField(
                    error,
                    Constants.RequiredMealPortionsMessage,
                    portions);


            bool isValidMealData = isValidMealName && isValidQuantity && isValidType && areValidCalories && areValidPortions;
            return isValidMealData;
        }

        private SqlCommand CreateMealInsertionCommand(SqlConnection connection)
        {
            try
            {
                SqlCommand createNewMealCommand = new SqlCommand("InsertMeal", connection);
                createNewMealCommand.CommandType = CommandType.StoredProcedure;
                createNewMealCommand.CommandText = "InsertMeal";

                SqlParameter MealName = new SqlParameter("@mealName", SqlDbType.NVarChar);
                MealName.Value = mealName.Text;
                createNewMealCommand.Parameters.Add(MealName);

                SqlParameter Quantity = new SqlParameter("@quantity", SqlDbType.Int);
                Quantity.Value = Int32.Parse(quantity.Text);
                createNewMealCommand.Parameters.Add(Quantity);

                SqlParameter Calories = new SqlParameter("@calories", SqlDbType.Int);
                Calories.Value = Int32.Parse(calories.Text);
                createNewMealCommand.Parameters.Add(Calories);

                SqlParameter Type = new SqlParameter("@type", SqlDbType.NVarChar);
                Type.Value = type.Text;
                createNewMealCommand.Parameters.Add(Type);

                SqlParameter Portions = new SqlParameter("@portions", SqlDbType.Int);
                Portions.Value = Int32.Parse(portions.Text);
                createNewMealCommand.Parameters.Add(Portions);

                return createNewMealCommand;
            }
            catch (FormatException formatException)
            {
                
                throw new FormatException();
            }
        }
    }
}
