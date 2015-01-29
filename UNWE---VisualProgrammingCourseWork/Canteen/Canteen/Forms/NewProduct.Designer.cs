namespace Canteen.Forms
{
    partial class NewProduct
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
            this.components = new System.ComponentModel.Container();
            this.contentWrapper = new System.Windows.Forms.Panel();
            this.productName = new System.Windows.Forms.TextBox();
            this.measurementUnit = new System.Windows.Forms.TextBox();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.measurementUnitLabel = new System.Windows.Forms.Label();
            this.newProductButton = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.contentWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // contentWrapper
            // 
            this.contentWrapper.Controls.Add(this.newProductButton);
            this.contentWrapper.Controls.Add(this.measurementUnitLabel);
            this.contentWrapper.Controls.Add(this.productNameLabel);
            this.contentWrapper.Controls.Add(this.measurementUnit);
            this.contentWrapper.Controls.Add(this.productName);
            this.contentWrapper.Location = new System.Drawing.Point(12, 2);
            this.contentWrapper.Name = "contentWrapper";
            this.contentWrapper.Size = new System.Drawing.Size(510, 329);
            this.contentWrapper.TabIndex = 0;
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(263, 53);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(167, 20);
            this.productName.TabIndex = 0;
            // 
            // measurementUnit
            // 
            this.measurementUnit.Location = new System.Drawing.Point(263, 128);
            this.measurementUnit.Name = "measurementUnit";
            this.measurementUnit.Size = new System.Drawing.Size(167, 20);
            this.measurementUnit.TabIndex = 1;
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productNameLabel.Location = new System.Drawing.Point(50, 53);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(160, 25);
            this.productNameLabel.TabIndex = 2;
            this.productNameLabel.Text = "Наименование";
            // 
            // measurementUnitLabel
            // 
            this.measurementUnitLabel.AutoSize = true;
            this.measurementUnitLabel.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.measurementUnitLabel.Location = new System.Drawing.Point(50, 128);
            this.measurementUnitLabel.Name = "measurementUnitLabel";
            this.measurementUnitLabel.Size = new System.Drawing.Size(167, 25);
            this.measurementUnitLabel.TabIndex = 3;
            this.measurementUnitLabel.Text = "Мерна единица";
            // 
            // newProductButton
            // 
            this.newProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newProductButton.Location = new System.Drawing.Point(167, 238);
            this.newProductButton.Name = "newProductButton";
            this.newProductButton.Size = new System.Drawing.Size(154, 47);
            this.newProductButton.TabIndex = 4;
            this.newProductButton.Text = "Запис";
            this.newProductButton.UseVisualStyleBackColor = true;
            this.newProductButton.Click += new System.EventHandler(this.newProductButton_Click);
            // 
            // error
            // 
            this.error.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.error.ContainerControl = this;
            // 
            // NewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 332);
            this.Controls.Add(this.contentWrapper);
            this.Name = "NewProduct";
            this.Text = "NewProduct";
            this.contentWrapper.ResumeLayout(false);
            this.contentWrapper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contentWrapper;
        private System.Windows.Forms.Label measurementUnitLabel;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.TextBox measurementUnit;
        private System.Windows.Forms.TextBox productName;
        private System.Windows.Forms.Button newProductButton;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.ToolTip toolTip;
    }
}