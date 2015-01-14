namespace Canteen.Forms
{
    partial class EditMeal
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
            this.editButton = new System.Windows.Forms.Button();
            this.meal = new System.Windows.Forms.DataGridView();
            this.MealCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MealName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calories = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Portions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModificationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contentWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meal)).BeginInit();
            this.SuspendLayout();
            // 
            // contentWrapper
            // 
            this.contentWrapper.Controls.Add(this.editButton);
            this.contentWrapper.Controls.Add(this.meal);
            this.contentWrapper.Location = new System.Drawing.Point(27, 12);
            this.contentWrapper.Name = "contentWrapper";
            this.contentWrapper.Size = new System.Drawing.Size(805, 300);
            this.contentWrapper.TabIndex = 0;
            // 
            // editButton
            // 
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editButton.Location = new System.Drawing.Point(293, 210);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(208, 49);
            this.editButton.TabIndex = 8;
            this.editButton.Text = "Редактиране";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // meal
            // 
            this.meal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.meal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.meal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MealCode,
            this.MealName,
            this.Quantity,
            this.Calories,
            this.Type,
            this.Portions,
            this.ModificationDate});
            this.meal.Location = new System.Drawing.Point(36, 50);
            this.meal.Name = "meal";
            this.meal.Size = new System.Drawing.Size(738, 104);
            this.meal.TabIndex = 0;
            // 
            // MealCode
            // 
            this.MealCode.HeaderText = "Код";
            this.MealCode.Name = "MealCode";
            this.MealCode.ReadOnly = true;
            // 
            // MealName
            // 
            this.MealName.HeaderText = "Наименование";
            this.MealName.Name = "MealName";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Грамаж";
            this.Quantity.Name = "Quantity";
            // 
            // Calories
            // 
            this.Calories.HeaderText = "Калории";
            this.Calories.Name = "Calories";
            // 
            // Type
            // 
            this.Type.HeaderText = "Тип";
            this.Type.Name = "Type";
            // 
            // Portions
            // 
            this.Portions.HeaderText = "Порции";
            this.Portions.Name = "Portions";
            // 
            // ModificationDate
            // 
            this.ModificationDate.HeaderText = "Дата на модификация";
            this.ModificationDate.Name = "ModificationDate";
            this.ModificationDate.ReadOnly = true;
            // 
            // EditMeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 332);
            this.Controls.Add(this.contentWrapper);
            this.Name = "EditMeal";
            this.Text = "ЕditMeal";
            this.contentWrapper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.meal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contentWrapper;
        private System.Windows.Forms.DataGridView meal;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn MealCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn MealName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calories;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Portions;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModificationDate;
    }
}