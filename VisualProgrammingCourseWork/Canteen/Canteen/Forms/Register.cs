namespace Canteen.Forms
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Windows.Forms;
    using Canteen.Common;

    public partial class Register : Form
    {
        private const string FormTitle = "Регистрация";
        private const int FormWidth = 625;
        private const int FormHeight = 510;

        public Register()
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
            // Enter label
            registerLabel.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia);
            registerLabel.ForeColor = ColorFactory.GetColor(CommonColors.GreyFontColor);
            // Username label
            usernameLabel.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 16);
            usernameLabel.ForeColor = ColorFactory.GetColor(CommonColors.GreyFontColor);
            // Password label
            passwordLabel.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 16);
            passwordLabel.ForeColor = ColorFactory.GetColor(CommonColors.GreyFontColor);
            // First name label
            firstNameLabel.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 16);
            firstNameLabel.ForeColor = ColorFactory.GetColor(CommonColors.GreyFontColor);
            // Last name label
            lastNameLabel.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 16);
            lastNameLabel.ForeColor = ColorFactory.GetColor(CommonColors.GreyFontColor);
            // Register button
            registerButton.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 20);
            registerButton.ForeColor = ColorFactory.GetColor(CommonColors.BackgroundGrey);
            registerButton.BackColor = ColorFactory.GetColor(CommonColors.DarkGrey);
            // Passwod textbox
            password.PasswordChar = '*';
            password.MaxLength = 20;
            // Cancel button
            cancelButton.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 16);
            cancelButton.ForeColor = ColorFactory.GetColor(CommonColors.BackgroundGrey);
            cancelButton.BackColor = ColorFactory.GetColor(CommonColors.DarkGrey);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            bool isValidUSerData = ValidateUserData();
            if (isValidUSerData)
            {
                SqlConnection connection = CommonDatabaseActions.CreateDatabaseConnection("Canteen");
                using (connection)
                {
                    SqlCommand registerCommand = CreateRegisterCommand(connection);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = registerCommand.ExecuteReader();
                        int authenticationResult = (Int32)registerCommand.Parameters["@ProcedureResult"].Value;
                        if (authenticationResult != -1)
                        {
                            MessageBox.Show(Constants.SuccessfulRegisterMessage);
                            Login.Username = username.Text;
                            Login.Password = password.Text;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show(Constants.UsernameTakenMessage);
                        }
                    }
                    catch (SqlException sqlException)
                    {
                        MessageBox.Show(sqlException.ToString());
                    }
                }
            } 
        }

        private bool ValidateUserData()
        {
            bool isValidFirstName =
                CommonUserInteractionMethods.ValidateRequiredInputField(
                    error,
                    Constants.RequiredFirstNameMessage,
                    firstName);
            bool isValidLastName =
                CommonUserInteractionMethods.ValidateRequiredInputField(
                    error,
                    Constants.RequiredLastNameMessage,
                    lastName);
            bool isValidUserName =
                CommonUserInteractionMethods.ValidateRequiredInputField(
                    error,
                    Constants.RequiredUsernameMessage,
                    username);
            bool isValidPassword =
                CommonUserInteractionMethods.ValidateRequiredInputField(
                    error,
                    Constants.RequiredPasswordMessage,
                    password);

            bool isValidUserData = isValidFirstName && isValidLastName && isValidUserName && isValidPassword;
            return isValidUserData;
        }

        private SqlCommand CreateRegisterCommand(SqlConnection connection)
        {
            SqlCommand registerCommand = new SqlCommand("RegisterUser", connection);
            registerCommand.CommandType = CommandType.StoredProcedure;
            registerCommand.CommandText = "RegisterUser";

            SqlParameter FirstName = new SqlParameter("@FirstName", SqlDbType.NVarChar);
            FirstName.Value = firstName.Text;
            registerCommand.Parameters.Add(FirstName);

            SqlParameter LastName = new SqlParameter("@LastName", SqlDbType.NVarChar);
            LastName.Value = firstName.Text;
            registerCommand.Parameters.Add(LastName);

            SqlParameter UserName = new SqlParameter("@UserName", SqlDbType.NVarChar);
            UserName.Value = username.Text;
            registerCommand.Parameters.Add(UserName);

            SqlParameter Password = new SqlParameter("@Password", SqlDbType.NVarChar);
            Password.Value = password.Text;
            registerCommand.Parameters.Add(Password);

            SqlParameter result = new SqlParameter("@ProcedureResult", SqlDbType.Int);
            result.Direction = ParameterDirection.Output;
            registerCommand.Parameters.Add(result);

            return registerCommand;
        }
    }
}
