namespace Canteen.Forms
{
    using System.Data;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Windows.Forms;
    using Canteen.Common;

    public partial class SearchProducts : Form
    {
        private const string FormTitle = "Продукти";
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
    }
}
