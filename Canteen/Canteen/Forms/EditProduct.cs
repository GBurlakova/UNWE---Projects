namespace Canteen.Forms
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Windows.Forms;
    using Canteen.Common;

    public partial class EditProduct : Form
    {
        private const string FormTitle = "Продукти";
        private const int FormWidth = 800;
        private const int FormHeight = 330;

        public EditProduct(string productId, string productName, string measurementUnit, object date)
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
            // Edit button
            editButton.Font = FontFactory.GetFont(CommonFonts.DefauldGeorgia, 16);
            editButton.ForeColor = ColorFactory.GetColor(CommonColors.BackgroundGrey);
            editButton.BackColor = ColorFactory.GetColor(CommonColors.DarkGrey);
            // Product table
            product.Rows[0].Cells[0].Value = productId;
            product.Rows[0].Cells[1].Value = productName;
            product.Rows[0].Cells[2].Value = measurementUnit;
            product.Rows[0].Cells[3].Value = date;
        }

        private void editButton_Click(object sender, System.EventArgs e)
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
            ProductCode.Value = Int32.Parse(product.Rows[0].Cells[0].Value.ToString());
            productEditCommand.Parameters.Add(ProductCode);

            SqlParameter ProductName = new SqlParameter("@productName", SqlDbType.NVarChar);
            ProductName.Value = product.Rows[0].Cells[1].Value.ToString();
            productEditCommand.Parameters.Add(ProductName);

            SqlParameter MeasurementUnit = new SqlParameter("@measurementUnit", SqlDbType.NVarChar);
            MeasurementUnit.Value = product.Rows[0].Cells[2].Value.ToString();
            productEditCommand.Parameters.Add(MeasurementUnit);

            return productEditCommand;
        }
    }
}
