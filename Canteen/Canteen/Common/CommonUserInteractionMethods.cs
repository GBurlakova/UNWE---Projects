namespace Canteen.Common
{
    using System.Windows.Forms;

    public static class CommonUserInteractionMethods
    {
        public static bool ValidateRequiredInputField(ErrorProvider error, string errorMessage, TextBox inputField)
        {
            bool isValidInput = false;

            if (string.IsNullOrEmpty(inputField.Text.Trim()))
            {
                error.SetError(inputField, errorMessage);
            }
            else
            {
                error.Clear();
                isValidInput = true;
            }

            return isValidInput;
        }
    }
}
