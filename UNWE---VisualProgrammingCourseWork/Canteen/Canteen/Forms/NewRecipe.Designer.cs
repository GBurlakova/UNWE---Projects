namespace Canteen.Forms
{
    partial class NewRecipe
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
            this.newRecipeButton = new System.Windows.Forms.Button();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.productLabel = new System.Windows.Forms.Label();
            this.recipeLabel = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.TextBox();
            this.product = new System.Windows.Forms.ComboBox();
            this.recipe = new System.Windows.Forms.ComboBox();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.contentWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // contentWrapper
            // 
            this.contentWrapper.Controls.Add(this.newRecipeButton);
            this.contentWrapper.Controls.Add(this.quantityLabel);
            this.contentWrapper.Controls.Add(this.productLabel);
            this.contentWrapper.Controls.Add(this.recipeLabel);
            this.contentWrapper.Controls.Add(this.quantity);
            this.contentWrapper.Controls.Add(this.product);
            this.contentWrapper.Controls.Add(this.recipe);
            this.contentWrapper.Location = new System.Drawing.Point(12, 12);
            this.contentWrapper.Name = "contentWrapper";
            this.contentWrapper.Size = new System.Drawing.Size(410, 367);
            this.contentWrapper.TabIndex = 0;
            // 
            // newRecipeButton
            // 
            this.newRecipeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newRecipeButton.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newRecipeButton.Location = new System.Drawing.Point(110, 257);
            this.newRecipeButton.Name = "newRecipeButton";
            this.newRecipeButton.Size = new System.Drawing.Size(185, 57);
            this.newRecipeButton.TabIndex = 6;
            this.newRecipeButton.Text = "Добави";
            this.newRecipeButton.UseVisualStyleBackColor = true;
            this.newRecipeButton.Click += new System.EventHandler(this.newRecipeButton_Click);
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantityLabel.Location = new System.Drawing.Point(48, 176);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(129, 25);
            this.quantityLabel.TabIndex = 5;
            this.quantityLabel.Text = "Количество";
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productLabel.Location = new System.Drawing.Point(82, 110);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(95, 25);
            this.productLabel.TabIndex = 4;
            this.productLabel.Text = "Продукт";
            // 
            // recipeLabel
            // 
            this.recipeLabel.AutoSize = true;
            this.recipeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recipeLabel.Location = new System.Drawing.Point(105, 43);
            this.recipeLabel.Name = "recipeLabel";
            this.recipeLabel.Size = new System.Drawing.Size(72, 25);
            this.recipeLabel.TabIndex = 3;
            this.recipeLabel.Text = "Ястие";
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(195, 181);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(152, 20);
            this.quantity.TabIndex = 2;
            // 
            // product
            // 
            this.product.FormattingEnabled = true;
            this.product.Location = new System.Drawing.Point(195, 114);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(152, 21);
            this.product.TabIndex = 1;
            // 
            // recipe
            // 
            this.recipe.FormattingEnabled = true;
            this.recipe.Location = new System.Drawing.Point(195, 47);
            this.recipe.Name = "recipe";
            this.recipe.Size = new System.Drawing.Size(152, 21);
            this.recipe.TabIndex = 0;
            this.recipe.SelectedIndexChanged += new System.EventHandler(this.recipe_SelectedIndexChanged);
            // 
            // error
            // 
            this.error.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.error.ContainerControl = this;
            // 
            // NewRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 393);
            this.Controls.Add(this.contentWrapper);
            this.Name = "NewRecipe";
            this.Text = "NewRecipe";
            this.contentWrapper.ResumeLayout(false);
            this.contentWrapper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contentWrapper;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.Label recipeLabel;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.ComboBox product;
        private System.Windows.Forms.ComboBox recipe;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button newRecipeButton;
    }
}