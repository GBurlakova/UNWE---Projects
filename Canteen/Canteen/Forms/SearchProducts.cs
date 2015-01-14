namespace Canteen.Forms
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Windows.Forms;
    using Canteen.Common;

    public partial class SearchProducts : Form
    {
        private const string FormTitle = "Търсене на продукти";
        private const int FormWidth = 750;
        private const int FormHeight = 500;

        public SearchProducts()
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
            // Search button
            searchButton.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 16);
            searchButton.ForeColor = ColorFactory.GetColor(CommonColors.BackgroundGrey);
            searchButton.BackColor = ColorFactory.GetColor(CommonColors.DarkGrey);
            // Clear button
            clearFiltersButton.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 12);
            clearFiltersButton.ForeColor = ColorFactory.GetColor(CommonColors.BackgroundGrey);
            clearFiltersButton.BackColor = ColorFactory.GetColor(CommonColors.DarkGrey);
            // Menu strip
            toolStrip.BackColor = ColorFactory.GetColor(CommonColors.DarkGrey);
            toolStrip.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 12);
            toolStrip.ForeColor = ColorFactory.GetColor(CommonColors.BackgroundGrey);
        }

        private void searchButton_Click(object sender, System.EventArgs e)
        {
            SqlConnection connection = CommonDatabaseActions.CreateDatabaseConnection("Canteen");
            using (connection)
            {
                SqlCommand productEditCommand = CreateSearchProductsCommand(connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = productEditCommand.ExecuteReader();
                    productsTable.DataSource = null;
                    if(reader.HasRows)
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        productsTable.DataSource = dataTable;
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

        private SqlCommand CreateSearchProductsCommand(SqlConnection connection)
        {
            SqlCommand searchProducts = new SqlCommand("SearchProducts", connection);
            searchProducts.CommandType = CommandType.StoredProcedure;
            searchProducts.CommandText = "SearchProducts";

            SqlParameter ProductName = new SqlParameter("@productName", SqlDbType.NVarChar);
            if (string.IsNullOrEmpty(productName.Text))
            {
                ProductName.Value = null;
            }
            else
            {
                ProductName.Value = productName.Text;
            }

            searchProducts.Parameters.Add(ProductName);

            SqlParameter MeasurementUnit = new SqlParameter("@measurementUnit", SqlDbType.NVarChar);
            if (string.IsNullOrEmpty(measurementUnit.Text))
            {
                MeasurementUnit.Value = null;
            }
            else
            {
                MeasurementUnit.Value = measurementUnit.Text;
            }
            
            searchProducts.Parameters.Add(MeasurementUnit);

            return searchProducts;
        }

        private void clearFiltersButton_Click(object sender, EventArgs e)
        {
            productName.Clear();
            measurementUnit.Clear();
            productsTable.DataSource = null;
        }

        private void newProductButton_Click(object sender, EventArgs e)
        {
            var newProductForm = new NewProduct();
            newProductForm.StartPosition = FormStartPosition.CenterScreen;
            newProductForm.Show();
            this.Close();
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
            ProductCode.Value = Int32.Parse(productsTable.CurrentRow.Cells[0].Value.ToString());
            productDeleteCommand.Parameters.Add(ProductCode);

            return productDeleteCommand;
        }

        private void productsTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string productId = productsTable.CurrentRow.Cells[0].Value.ToString();
            string productName = productsTable.CurrentRow.Cells[1].Value.ToString();
            string measumentUnit = productsTable.CurrentRow.Cells[2].Value.ToString();
            string date = DateTime.Parse(productsTable.CurrentRow.Cells[3].Value.ToString()).ToShortDateString();
            var editProductForm = new EditProduct(productId, productName, measumentUnit, date);
            editProductForm.ShowDialog();
        }

    }
}
