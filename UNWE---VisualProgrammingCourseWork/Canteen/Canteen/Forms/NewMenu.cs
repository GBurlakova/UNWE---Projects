

namespace Canteen.Forms
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Windows.Forms;
    using Canteen.Common;

    public partial class NewMenu : Form
    {
        private const string FormTitle = "Ново меню";
        private const int FormWidth = 585;
        private const int FormHeight = 450;
        private const int MenuItems = 3;
        private const string DateFormat = "yyyy-MM-dd";

        public NewMenu()
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
            // New menu button
            newMenuButton.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 20);
            newMenuButton.ForeColor = ColorFactory.GetColor(CommonColors.BackgroundGrey);
            newMenuButton.BackColor = ColorFactory.GetColor(CommonColors.DarkGrey);
            // Date label
            dateLabel.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 16);
            dateLabel.ForeColor = ColorFactory.GetColor(CommonColors.GreyFontColor);
            // First meal label
            firstMealLabel.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 16);
            firstMealLabel.ForeColor = ColorFactory.GetColor(CommonColors.GreyFontColor);
            // Second meal label
            secondMealLabel.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 16);
            secondMealLabel.ForeColor = ColorFactory.GetColor(CommonColors.GreyFontColor);
            // Third meal label
            thirdMealLabel.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 16);
            thirdMealLabel.ForeColor = ColorFactory.GetColor(CommonColors.GreyFontColor);
            // First meal count label
            firstMealCountLabel.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 16);
            firstMealCountLabel.ForeColor = ColorFactory.GetColor(CommonColors.GreyFontColor);
            // Second meal count label
            secondMealCountLabel.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 16);
            secondMealCountLabel.ForeColor = ColorFactory.GetColor(CommonColors.GreyFontColor);
            // Third meal count label
            thirdMealCountLabel.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 16);
            thirdMealCountLabel.ForeColor = ColorFactory.GetColor(CommonColors.GreyFontColor);
            // Tool tips
            toolTip.SetToolTip(firstMeal, Constants.FirstMealToolTip);
            toolTip.SetToolTip(firstMealCount, Constants.FirstMealCountToolTip);
            toolTip.SetToolTip(secondMeal, Constants.SecondMealToolTip);
            toolTip.SetToolTip(secondMealCount, Constants.SecondMealCountToolTip);
            toolTip.SetToolTip(thirdMeal, Constants.ThirdMealToolTip);
            toolTip.SetToolTip(thirdMeal, Constants.ThirdMealCountToolTip);
            // Set Custom format to datepicjer
            date.Format = DateTimePickerFormat.Custom;
            date.CustomFormat = "yyyy-MM-dd";
            // Fill combo boxes
            FillFirstMealComboBox();
            FillSecondMealComboBox();
            FillThirdMealComboBox();
        }

        private void FillFirstMealComboBox()
        {
            SqlConnection connection = CommonDatabaseActions.CreateDatabaseConnection("Canteen");
            SqlCommand getFirstMealsCommand = new SqlCommand("GetFirstMealsAvailableForMenus", connection);
            getFirstMealsCommand.CommandType = CommandType.StoredProcedure;
            getFirstMealsCommand.CommandText = "GetFirstMealsAvailableForMenus";
            using (connection)
            {
                try
                {
                    connection.Open();
                    SqlDataReader reader = getFirstMealsCommand.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    firstMeal.DisplayMember = "Наименование";
                    firstMeal.ValueMember = "Код";
                    firstMeal.DataSource = dataTable;
                }
                catch (SqlException se)
                {
                    MessageBox.Show(se.ToString());
                }
            }
        }

        private void FillSecondMealComboBox()
        {
            SqlConnection connection = CommonDatabaseActions.CreateDatabaseConnection("Canteen");
            SqlCommand getSecondMealsCommand = new SqlCommand("GetSecondMealsAvailableForMenus", connection);
            getSecondMealsCommand.CommandType = CommandType.StoredProcedure;
            getSecondMealsCommand.CommandText = "GetSecondMealsAvailableForMenus";

            using (connection)
            {
                try
                {
                    connection.Open();
                    SqlDataReader reader = getSecondMealsCommand.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    secondMeal.DisplayMember = "Наименование";
                    secondMeal.ValueMember = "Код";
                    secondMeal.DataSource = dataTable;
                }
                catch (SqlException se)
                {
                    MessageBox.Show(se.ToString());
                }
            }
        }

        private void FillThirdMealComboBox()
        {
            SqlConnection connection = CommonDatabaseActions.CreateDatabaseConnection("Canteen");
            SqlCommand getSecondMealsCommand = new SqlCommand("GetThirdMealsAvailableForMenus", connection);
            getSecondMealsCommand.CommandType = CommandType.StoredProcedure;
            getSecondMealsCommand.CommandText = "GetThirdMealsAvailableForMenus";

            using (connection)
            {
                try
                {
                    connection.Open();
                    SqlDataReader reader = getSecondMealsCommand.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    thirdMeal.DisplayMember = "Наименование";
                    thirdMeal.ValueMember = "Код";
                    thirdMeal.DataSource = dataTable;
                }
                catch (SqlException se)
                {
                    MessageBox.Show(se.ToString());
                }
            }
        }

        private bool ValidateMenuData()
        {
            bool isValidFirstMealCount =
                CommonUserInteractionMethods.ValidateRequiredInputField(
                    error,
                    Constants.RequiredFirstMealCountMessage,
                    firstMealCount);
            bool isValidSecondMealCount =
                CommonUserInteractionMethods.ValidateRequiredInputField(
                    error,
                    Constants.RequiredSecondMealCountMessage,
                    secondMealCount);
            bool isValidThirdMealCount =
                CommonUserInteractionMethods.ValidateRequiredInputField(
                    error,
                    Constants.RequiredThirdMealCountMessage,
                    thirdMealCount);

            bool isValidMenuData = isValidFirstMealCount && isValidSecondMealCount && isValidThirdMealCount;
            return isValidMenuData;
        }

        private void newMenuButton_Click(object sender, System.EventArgs e)
        {
            DialogResult result =
                CommonUserInteractionMethods.ConfirmAction(Constants.ConfirmCreateNewMenuMessage);
            if (result.Equals(DialogResult.OK))
            {
                bool isValidMenuData = ValidateMenuData();
                if (isValidMenuData)
                {
                    try
                    {
                        SqlConnection connection = CommonDatabaseActions.CreateDatabaseConnection("Canteen");
                        using (connection)
                        {
                            connection.Open();
                            SqlCommand insertFirstMealToMenu =
                                CreateInsertMealToMenuCommand(connection, firstMeal, firstMealCount);
                            insertFirstMealToMenu.ExecuteNonQuery();
                            SqlCommand insertSecondMealToMenu =
                                CreateInsertMealToMenuCommand(connection, secondMeal, secondMealCount);
                            insertSecondMealToMenu.ExecuteNonQuery();
                            SqlCommand insertThirdMealToMenu =
                                CreateInsertMealToMenuCommand(connection, thirdMeal, thirdMealCount);
                            insertThirdMealToMenu.ExecuteNonQuery();
                            MessageBox.Show(Constants.MenuCreatedSuccessfullyMessage);
                            this.Close();

                        }
                    }
                    catch (FormatException formatException)
                    {
                        MessageBox.Show(Constants.InvalidMenuDateMessage);
                    }
                    catch (SqlException sqlException)
                    {
                        MessageBox.Show(sqlException.ToString());
                    }
                }
            }
        }

        private SqlCommand CreateInsertMealToMenuCommand(
            SqlConnection connection,
            ComboBox mealInput,
            TextBox mealsCountInput)
        {
            SqlCommand insertMealToMenuCommand = new SqlCommand("InsertMenu", connection);
            insertMealToMenuCommand.CommandType = CommandType.StoredProcedure;
            insertMealToMenuCommand.CommandText = "InsertMenu";

            SqlParameter mealCode = new SqlParameter("@mealCode", SqlDbType.Int);
            mealCode.Value = mealInput.SelectedValue;
            insertMealToMenuCommand.Parameters.Add(mealCode);

            SqlParameter mealsCount = new SqlParameter("@mealsCount", SqlDbType.Int);
            mealsCount.Value = Int32.Parse(mealsCountInput.Text);
            insertMealToMenuCommand.Parameters.Add(mealsCount);

            SqlParameter menuDate = new SqlParameter("@date", SqlDbType.NVarChar);
            DateTime menuDateInput = date.Value;
            string menuDateFormatted = menuDateInput.ToString(DateFormat);
            menuDate.Value = menuDateFormatted;
            insertMealToMenuCommand.Parameters.Add(menuDate);

            return insertMealToMenuCommand;

        }
    }
}
