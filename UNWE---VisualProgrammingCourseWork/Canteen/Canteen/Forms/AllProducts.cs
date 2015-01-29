namespace Canteen.Forms
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Windows.Forms;

    using Canteen.Common;

    public partial class AllProducts : Form
    {
        private const string FormTitle = "Продукти";
        private const int FormWidth = 875;
        private const int FormHeight = 480;

        public AllProducts()
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
            // Product code label
            productCodeLabel.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 16);
            productCodeLabel.ForeColor = ColorFactory.GetColor(CommonColors.GreyFontColor);
            // Product name label
            productNameLabel.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 16);
            productNameLabel.ForeColor = ColorFactory.GetColor(CommonColors.GreyFontColor);
            // Measurement unit label
            measurementUnitLabel.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 16);
            measurementUnitLabel.ForeColor = ColorFactory.GetColor(CommonColors.GreyFontColor);
            // Modification date label
            modificationDateLabel.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 16);
            modificationDateLabel.ForeColor = ColorFactory.GetColor(CommonColors.GreyFontColor);
            // Edit button
            editButton.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 16);
            editButton.ForeColor = ColorFactory.GetColor(CommonColors.BackgroundGrey);
            editButton.BackColor = ColorFactory.GetColor(CommonColors.DarkGrey);
            // Delete button
            deleteButton.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 16);
            deleteButton.ForeColor = ColorFactory.GetColor(CommonColors.BackgroundGrey);
            deleteButton.BackColor = ColorFactory.GetColor(CommonColors.DarkGrey);
        }

        private void продуктиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.canteenDataSet);

        }

        private void AllProducts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'canteenDataSet.Продукти' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.canteenDataSet.Продукти);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = CommonUserInteractionMethods.ConfirmAction(Constants.ConfirmDeleteProductMessage);

            if (result.Equals(DialogResult.OK))
            {
                SqlConnection connection = CommonDatabaseActions.CreateDatabaseConnection("Canteen");
                using (connection)
                {
                    SqlCommand productInsertionCommand = CreateProductDeleteCommand(connection);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = productInsertionCommand.ExecuteReader();
                        MessageBox.Show(Constants.ProductDeletedSuccessfullyMessage);
                        this.productsTableAdapter.Fill(this.canteenDataSet.Продукти);
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

        private SqlCommand CreateProductDeleteCommand(SqlConnection connection)
        {
            SqlCommand productDeleteCommand = new SqlCommand("DeleteProduct", connection);
            productDeleteCommand.CommandType = CommandType.StoredProcedure;
            productDeleteCommand.CommandText = "DeleteProduct";

            SqlParameter ProductCode = new SqlParameter("@productCode", SqlDbType.Int);
            ProductCode.Value = Int32.Parse(productCode.Text);
            productDeleteCommand.Parameters.Add(ProductCode);

            return productDeleteCommand;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            DialogResult result = CommonUserInteractionMethods.ConfirmAction(Constants.ConfirmEditProductMessage);

            if (result.Equals(DialogResult.OK))
            {
                SqlConnection connection = CommonDatabaseActions.CreateDatabaseConnection("Canteen");
                using (connection)
                {
                    SqlCommand productEditCommand = CreateProductEditCommand(connection);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = productEditCommand.ExecuteReader();
                        MessageBox.Show(Constants.ProductEditedSuccessfullyMessage);
                        this.productsTableAdapter.Fill(this.canteenDataSet.Продукти);
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

        private SqlCommand CreateProductEditCommand(SqlConnection connection)
        {
            SqlCommand productEditCommand = new SqlCommand("EditProduct", connection);
            productEditCommand.CommandType = CommandType.StoredProcedure;
            productEditCommand.CommandText = "EditProduct";

            SqlParameter ProductCode = new SqlParameter("@productCode", SqlDbType.Int);
            ProductCode.Value = Int32.Parse(productCode.Text);
            productEditCommand.Parameters.Add(ProductCode);

            SqlParameter ProductName = new SqlParameter("@productName", SqlDbType.NVarChar);
            ProductName.Value = productName.Text;
            productEditCommand.Parameters.Add(ProductName);

            SqlParameter MeasurementUnit = new SqlParameter("@measurementUnit", SqlDbType.NVarChar);
            MeasurementUnit.Value = measurementUnit.Text;
            productEditCommand.Parameters.Add(MeasurementUnit);

            return productEditCommand;
        }
    }
}
