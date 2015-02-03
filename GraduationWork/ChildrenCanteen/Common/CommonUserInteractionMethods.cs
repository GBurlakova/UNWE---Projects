namespace ChildrenCanteen.Common
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

        public static DialogResult ConfirmAction(string confirmMessage)
        {
            DialogResult confirmResult = 
                MessageBox.Show(
                    confirmMessage, Constants.ConfimrButtonText, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            return confirmResult;
        }
    }
}
