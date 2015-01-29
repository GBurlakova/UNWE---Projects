namespace Canteen.Forms
{
    partial class EditProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.contentWrapper = new System.Windows.Forms.Panel();
            this.product = new System.Windows.Forms.DataGridView();
            this.editButton = new System.Windows.Forms.Button();
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MeasurementUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModificationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contentWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product)).BeginInit();
            this.SuspendLayout();
            // 
            // contentWrapper
            // 
            this.contentWrapper.Controls.Add(this.editButton);
            this.contentWrapper.Controls.Add(this.product);
            this.contentWrapper.Location = new System.Drawing.Point(12, 12);
            this.contentWrapper.Name = "contentWrapper";
            this.contentWrapper.Size = new System.Drawing.Size(760, 268);
            this.contentWrapper.TabIndex = 0;
            // 
            // product
            // 
            this.product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.product.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductCode,
            this.ProductName,
            this.MeasurementUnit,
            this.ModificationDate});
            this.product.Location = new System.Drawing.Point(24, 55);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(659, 83);
            this.product.TabIndex = 0;
            // 
            // editButton
            // 
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editButton.Location = new System.Drawing.Point(283, 176);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(156, 48);
            this.editButton.TabIndex = 5;
            this.editButton.Text = "Редактиране";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // ProductCode
            // 
            this.ProductCode.HeaderText = "Код";
            this.ProductCode.Name = "ProductCode";
            this.ProductCode.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Наименование";
            this.ProductName.Name = "ProductName";
            // 
            // MeasurementUnit
            // 
            this.MeasurementUnit.HeaderText = "МернаЕдиница";
            this.MeasurementUnit.Name = "MeasurementUnit";
            // 
            // ModificationDate
            // 
            this.ModificationDate.HeaderText = "ДатаНаМодификация";
            this.ModificationDate.Name = "ModificationDate";
            this.ModificationDate.ReadOnly = true;
            // 
            // EditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 292);
            this.Controls.Add(this.contentWrapper);
            this.Name = "EditProduct";
            this.Text = "EditProduct";
            this.contentWrapper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.product)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contentWrapper;
        private System.Windows.Forms.DataGridView product;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeasurementUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModificationDate;
    }
}