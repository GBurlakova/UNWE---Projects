namespace Canteen
{
    using System.Drawing;
    using System.Windows.Forms;
    using Canteen.Common;

    public partial class Login : Form
    {
        private const string formTitle = "Вход";
        private const int width = 650;
        private const int height = 520;
        public Login()
        {
            InitializeComponent();
            // Form settings
            this.Width = width;
            this.Height = height;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Text = formTitle;
            this.BackColor = ColorFactory.GetColor(CommonColors.BackgroundGrey);
            // Content wrapper
            contentWrapper.BackColor = Color.White;
            contentWrapper.Width = (int)(width * Constants.WrapperSizeCoefficient);
            contentWrapper.Height = (int)(height * Constants.WrapperSizeCoefficient);
            // Center the wrapper within the parent form
            contentWrapper.Left = (this.ClientSize.Width - contentWrapper.Width) / 2;
            contentWrapper.Top = (this.ClientSize.Height - contentWrapper.Height) / 2;
            // Enter label
            enterLabel.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia);
            enterLabel.ForeColor = ColorFactory.GetColor(CommonColors.FontColor);
            // Username label
            usernameLabel.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 16);
            usernameLabel.ForeColor = ColorFactory.GetColor(CommonColors.FontColor);
            // Password label
            passwordLabel.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 16);
            passwordLabel.ForeColor = ColorFactory.GetColor(CommonColors.FontColor);
            // Enter button
            enterButton.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 20);
            enterButton.ForeColor = ColorFactory.GetColor(CommonColors.BackgroundGrey);
            enterButton.BackColor = ColorFactory.GetColor(CommonColors.DarkGrey);
            // Passwod textbox
            password.PasswordChar = '*';
            password.MaxLength = 20;
        }
    }
}
