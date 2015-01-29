namespace Canteen.Forms
{
    partial class NewMeal
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
            this.newMealButton = new System.Windows.Forms.Button();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.mealNameLabel = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.TextBox();
            this.mealName = new System.Windows.Forms.TextBox();
            this.caloriesLabel = new System.Windows.Forms.Label();
            this.calories = new System.Windows.Forms.TextBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.TextBox();
            this.portionsLabel = new System.Windows.Forms.Label();
            this.portions = new System.Windows.Forms.TextBox();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.contentWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // contentWrapper
            // 
            this.contentWrapper.Controls.Add(this.portionsLabel);
            this.contentWrapper.Controls.Add(this.portions);
            this.contentWrapper.Controls.Add(this.typeLabel);
            this.contentWrapper.Controls.Add(this.type);
            this.contentWrapper.Controls.Add(this.caloriesLabel);
            this.contentWrapper.Controls.Add(this.calories);
            this.contentWrapper.Controls.Add(this.newMealButton);
            this.contentWrapper.Controls.Add(this.quantityLabel);
            this.contentWrapper.Controls.Add(this.mealNameLabel);
            this.contentWrapper.Controls.Add(this.quantity);
            this.contentWrapper.Controls.Add(this.mealName);
            this.contentWrapper.Location = new System.Drawing.Point(23, 12);
            this.contentWrapper.Name = "contentWrapper";
            this.contentWrapper.Size = new System.Drawing.Size(731, 438);
            this.contentWrapper.TabIndex = 0;
            // 
            // newMealButton
            // 
            this.newMealButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newMealButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newMealButton.Location = new System.Drawing.Point(290, 354);
            this.newMealButton.Name = "newMealButton";
            this.newMealButton.Size = new System.Drawing.Size(154, 47);
            this.newMealButton.TabIndex = 9;
            this.newMealButton.Text = "Запис";
            this.newMealButton.UseVisualStyleBackColor = true;
            this.newMealButton.Click += new System.EventHandler(this.newMealButton_Click);
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantityLabel.Location = new System.Drawing.Point(168, 85);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(90, 25);
            this.quantityLabel.TabIndex = 8;
            this.quantityLabel.Text = "Грамаж";
            // 
            // mealNameLabel
            // 
            this.mealNameLabel.AutoSize = true;
            this.mealNameLabel.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mealNameLabel.Location = new System.Drawing.Point(168, 31);
            this.mealNameLabel.Name = "mealNameLabel";
            this.mealNameLabel.Size = new System.Drawing.Size(160, 25);
            this.mealNameLabel.TabIndex = 7;
            this.mealNameLabel.Text = "Наименование";
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(381, 85);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(167, 20);
            this.quantity.TabIndex = 6;
            // 
            // mealName
            // 
            this.mealName.Location = new System.Drawing.Point(381, 31);
            this.mealName.Name = "mealName";
            this.mealName.Size = new System.Drawing.Size(167, 20);
            this.mealName.TabIndex = 5;
            // 
            // caloriesLabel
            // 
            this.caloriesLabel.AutoSize = true;
            this.caloriesLabel.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.caloriesLabel.Location = new System.Drawing.Point(168, 140);
            this.caloriesLabel.Name = "caloriesLabel";
            this.caloriesLabel.Size = new System.Drawing.Size(99, 25);
            this.caloriesLabel.TabIndex = 11;
            this.caloriesLabel.Text = "Калории";
            // 
            // calories
            // 
            this.calories.Location = new System.Drawing.Point(381, 140);
            this.calories.Name = "calories";
            this.calories.Size = new System.Drawing.Size(167, 20);
            this.calories.TabIndex = 10;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeLabel.Location = new System.Drawing.Point(168, 198);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(51, 25);
            this.typeLabel.TabIndex = 13;
            this.typeLabel.Text = "Тип";
            // 
            // type
            // 
            this.type.Location = new System.Drawing.Point(381, 198);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(167, 20);
            this.type.TabIndex = 12;
            // 
            // portionsLabel
            // 
            this.portionsLabel.AutoSize = true;
            this.portionsLabel.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.portionsLabel.Location = new System.Drawing.Point(168, 250);
            this.portionsLabel.Name = "portionsLabel";
            this.portionsLabel.Size = new System.Drawing.Size(91, 25);
            this.portionsLabel.TabIndex = 15;
            this.portionsLabel.Text = "Порции";
            // 
            // portions
            // 
            this.portions.Location = new System.Drawing.Point(381, 255);
            this.portions.Name = "portions";
            this.portions.Size = new System.Drawing.Size(167, 20);
            this.portions.TabIndex = 14;
            // 
            // error
            // 
            this.error.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.error.ContainerControl = this;
            // 
            // NewMeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.contentWrapper);
            this.Name = "NewMeal";
            this.Text = "NewMeal";
            this.contentWrapper.ResumeLayout(false);
            this.contentWrapper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contentWrapper;
        private System.Windows.Forms.Label portionsLabel;
        private System.Windows.Forms.TextBox portions;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.Label caloriesLabel;
        private System.Windows.Forms.TextBox calories;
        private System.Windows.Forms.Button newMealButton;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label mealNameLabel;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.TextBox mealName;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.ToolTip toolTip;
    }
}