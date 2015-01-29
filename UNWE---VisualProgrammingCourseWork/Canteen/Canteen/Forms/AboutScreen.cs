namespace Canteen.Forms
{
    using System;
    using Canteen.Common;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class AboutScreen : Form
    {
        private const string FormTitle = "За приложението";
        private const int FormWidth = 650;
        private const int FormHeight = 380;
        private const string DeveloperName = "Габриела Бурлакова";
        private const string FacultyNumber = "118003";
        private const string Speciality = "Бизнес информатика";
        private const string Stream = "177";
        private const string GroupNumber = "1708";

        public AboutScreen()
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
            aboutLabel.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia);
            aboutLabel.ForeColor = ColorFactory.GetColor(CommonColors.GreyFontColor);
            // About box
            aboutBox.Text = String.Format(Constants.AboutInformation, DeveloperName, FacultyNumber, Speciality, Stream, GroupNumber, Environment.NewLine);
            aboutBox.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 16);
            aboutBox.ForeColor = ColorFactory.GetColor(CommonColors.GreyFontColor);
        }


    }
}
