namespace Canteen.Forms
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Windows.Forms;
    using Canteen.Common;

    public partial class NewProduct : Form
    {
        private const string FormTitle = "Добавяне на продукт";
        private const int FormWidth = 550;
        private const int FormHeight = 370;

        public NewProduct()
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
            // Product name label
            productNameLabel.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 16);
            productNameLabel.ForeColor = ColorFactory.GetColor(CommonColors.GreyFontColor);
            // Measurement unit label
            measurementUnitLabel.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 16);
            measurementUnitLabel.ForeColor = ColorFactory.GetColor(CommonColors.GreyFontColor);
            // New product button
            newProductButton.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 20);
            newProductButton.ForeColor = ColorFactory.GetColor(CommonColors.BackgroundGrey);
            newProductButton.BackColor = ColorFactory.GetColor(CommonColors.DarkGrey);
            // Set tool tips
            this.toolTip.SetToolTip(productName, Constants.ProductNameToolTip);
            this.toolTip.SetToolTip(measurementUnit, Constants.MeasurementToolTip);
        }

        private void newProductButton_Click(object newProductButtonSender, EventArgs e)
        {
            bool isValidProductData = ValidateProductData();

            if (isValidProductData)
            {
                DialogResult confirmResult = CommonUserInteractionMethods.ConfirmAction(Constants.ConfirmCreateNewProductMessage);

                if (confirmResult.Equals(DialogResult.OK))
                {
                    SqlConnection connection = CommonDatabaseActions.CreateDatabaseConnection("Canteen");
                    using (connection)
                    {
                        SqlCommand productInsertionCommand = CreateProductInsertionCommand(connection);
                        try
                        {
                            using (productInsertionCommand)
                            {
                                connection.Open();
                                productInsertionCommand.ExecuteNonQuery();
                                MessageBox.Show(Constants.NewProductCreatedSuccessfullyMessage);
                                productName.Clear();
                                measurementUnit.Clear();
                                connection.Close();
                            } 
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

        private bool ValidateProductData()
        {
            bool isValidProductName =
                CommonUserInteractionMethods.ValidateRequiredInputField(
                    error,
                    Constants.RequiredProductNameMessage,
                    productName);
            bool isValidMeasurementUnit =
                CommonUserInteractionMethods.ValidateRequiredInputField(
                    error,
                    Constants.RequiredMeasurementUnitMessage,
                    measurementUnit);
            

            bool isValidProductData = isValidProductName && isValidMeasurementUnit;
            return isValidProductData;
        }

        private SqlCommand CreateProductInsertionCommand(SqlConnection connection)
        {
            SqlCommand productInsertionCommand = new SqlCommand("InsertProduct", connection);
            productInsertionCommand.CommandType = CommandType.StoredProcedure;
            productInsertionCommand.CommandText = "InsertProduct";

            SqlParameter ProductName = new SqlParameter("@productName", SqlDbType.NVarChar);
            ProductName.Value = productName.Text;
            productInsertionCommand.Parameters.Add(ProductName);

            SqlParameter MeasurementUnit = new SqlParameter("@measurementUnit", SqlDbType.NVarChar);
            MeasurementUnit.Value = measurementUnit.Text;
            productInsertionCommand.Parameters.Add(MeasurementUnit);

            return productInsertionCommand;
        }
    }
}
