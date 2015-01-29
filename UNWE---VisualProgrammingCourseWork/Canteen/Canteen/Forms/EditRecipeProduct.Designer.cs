namespace Canteen.Forms
{
    partial class EditRecipeProduct
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
            this.quantity = new System.Windows.Forms.TextBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.editRecipeProductButton = new System.Windows.Forms.Button();
            this.contentWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentWrapper
            // 
            this.contentWrapper.Controls.Add(this.editRecipeProductButton);
            this.contentWrapper.Controls.Add(this.quantityLabel);
            this.contentWrapper.Controls.Add(this.quantity);
            this.contentWrapper.Location = new System.Drawing.Point(12, 7);
            this.contentWrapper.Name = "contentWrapper";
            this.contentWrapper.Size = new System.Drawing.Size(444, 162);
            this.contentWrapper.TabIndex = 0;
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(224, 43);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(121, 20);
            this.quantity.TabIndex = 0;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantityLabel.Location = new System.Drawing.Point(77, 38);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(127, 25);
            this.quantityLabel.TabIndex = 1;
            this.quantityLabel.Text = "Количество";
            // 
            // editRecipeProductButton
            // 
            this.editRecipeProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editRecipeProductButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editRecipeProductButton.Location = new System.Drawing.Point(146, 95);
            this.editRecipeProductButton.Name = "editRecipeProductButton";
            this.editRecipeProductButton.Size = new System.Drawing.Size(149, 46);
            this.editRecipeProductButton.TabIndex = 6;
            this.editRecipeProductButton.Text = "Запази";
            this.editRecipeProductButton.UseVisualStyleBackColor = true;
            this.editRecipeProductButton.Click += new System.EventHandler(this.editRecipeProductButton_Click);
            // 
            // EditRecipeProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 177);
            this.Controls.Add(this.contentWrapper);
            this.Name = "EditRecipeProduct";
            this.Text = "EditRecipeProduct";
            this.contentWrapper.ResumeLayout(false);
            this.contentWrapper.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contentWrapper;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.Button editRecipeProductButton;
    }
}