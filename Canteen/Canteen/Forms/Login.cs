namespace Canteen.Forms
{
    using System;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Windows.Forms;
    using Canteen.Common;
    using System.Data;

    public partial class Login : Form
    {
        private const string FormTitle = "Вход";
        private const int FormWidth = 650;
        private const int FormHeight = 520;

        public Login()
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
            enterLabel.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia);
            enterLabel.ForeColor = ColorFactory.GetColor(CommonColors.GreyFontColor);
            // Username label
            usernameLabel.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 16);
            usernameLabel.ForeColor = ColorFactory.GetColor(CommonColors.GreyFontColor);
            // Password label
            passwordLabel.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 16);
            passwordLabel.ForeColor = ColorFactory.GetColor(CommonColors.GreyFontColor);
            // Enter button
            enterButton.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 20);
            enterButton.ForeColor = ColorFactory.GetColor(CommonColors.BackgroundGrey);
            enterButton.BackColor = ColorFactory.GetColor(CommonColors.DarkGrey);
            // Passwod textbox
            password.PasswordChar = '*';
            password.MaxLength = 20;
            // Register button
            registerButton.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 16);
            registerButton.ForeColor = ColorFactory.GetColor(CommonColors.BackgroundGrey);
            registerButton.BackColor = ColorFactory.GetColor(CommonColors.DarkGrey);
        }

        public static string Username { get; set; }

        public static string Password { get; set; }

        private void enterButton_Click(object enterButtonSender, EventArgs e)
        {
            bool isValidUserData = ValidateUserData();
            if (isValidUserData)
            {
                SqlConnection connection = CommonDatabaseActions.CreateDatabaseConnection("Canteen");
                using (connection)
                {
                    SqlCommand authenticationCommand = CreateAuthenticationCommand(connection);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = authenticationCommand.ExecuteReader();
                        int authenticationResult = (Int32)authenticationCommand.Parameters["@result"].Value;
                        if (authenticationResult != -1)
                        {
                            this.Hide();
                            var mainScreen = new MainScreen();
                            // Ensure that the current open form will close when main screen is closed
                            mainScreen.Closed += (sender, args) => this.Close();
                            mainScreen.Show();
                        }
                        else
                        {
                            MessageBox.Show(Constants.InvalidLoginDataMessage);
                        }
                    }
                    catch (SqlException se)
                    {
                        MessageBox.Show(se.ToString());
                    }
                }
            }
        }

        private bool ValidateUserData()
        {
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

            bool isValidUserData = isValidUserName && isValidPassword;
            return isValidUserData;
        }

        private SqlCommand CreateAuthenticationCommand(SqlConnection connection)
        {
            SqlCommand authenticationCommand = new SqlCommand("AuthenticateUser", connection);
            authenticationCommand.CommandType = CommandType.StoredProcedure;
            authenticationCommand.CommandText = "AuthenticateUser";

            SqlParameter UserName = new SqlParameter("@UserName", SqlDbType.NVarChar);
            UserName.Value = username.Text;
            authenticationCommand.Parameters.Add(UserName);

            SqlParameter Password = new SqlParameter("@Password", SqlDbType.NVarChar);
            Password.Value = password.Text;
            authenticationCommand.Parameters.Add(Password);

            SqlParameter result = new SqlParameter("@result", SqlDbType.Int);
            result.Direction = ParameterDirection.Output;
            authenticationCommand.Parameters.Add(result);

            return authenticationCommand;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            registerForm.ShowDialog();
            FillUserData();
        }

        private void FillUserData()
        {
            username.Text = Username;
            password.Text = Password;
        }
    }
}
