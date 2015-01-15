namespace Canteen.Forms
{
    partial class NewMenu
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
            this.date = new System.Windows.Forms.DateTimePicker();
            this.firstMeal = new System.Windows.Forms.ComboBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.thirdMeal = new System.Windows.Forms.ComboBox();
            this.secondMeal = new System.Windows.Forms.ComboBox();
            this.firstMealLabel = new System.Windows.Forms.Label();
            this.secondMealLabel = new System.Windows.Forms.Label();
            this.thirdMealLabel = new System.Windows.Forms.Label();
            this.newMenuButton = new System.Windows.Forms.Button();
            this.firstMealCount = new System.Windows.Forms.TextBox();
            this.firstMealCountLabel = new System.Windows.Forms.Label();
            this.secondMealCountLabel = new System.Windows.Forms.Label();
            this.secondMealCount = new System.Windows.Forms.TextBox();
            this.thirdMealCountLabel = new System.Windows.Forms.Label();
            this.thirdMealCount = new System.Windows.Forms.TextBox();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.contentWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // contentWrapper
            // 
            this.contentWrapper.Controls.Add(this.thirdMealCountLabel);
            this.contentWrapper.Controls.Add(this.thirdMealCount);
            this.contentWrapper.Controls.Add(this.secondMealCountLabel);
            this.contentWrapper.Controls.Add(this.secondMealCount);
            this.contentWrapper.Controls.Add(this.firstMealCountLabel);
            this.contentWrapper.Controls.Add(this.firstMealCount);
            this.contentWrapper.Controls.Add(this.newMenuButton);
            this.contentWrapper.Controls.Add(this.thirdMealLabel);
            this.contentWrapper.Controls.Add(this.secondMealLabel);
            this.contentWrapper.Controls.Add(this.firstMealLabel);
            this.contentWrapper.Controls.Add(this.secondMeal);
            this.contentWrapper.Controls.Add(this.thirdMeal);
            this.contentWrapper.Controls.Add(this.dateLabel);
            this.contentWrapper.Controls.Add(this.firstMeal);
            this.contentWrapper.Controls.Add(this.date);
            this.contentWrapper.Location = new System.Drawing.Point(21, 12);
            this.contentWrapper.Name = "contentWrapper";
            this.contentWrapper.Size = new System.Drawing.Size(523, 388);
            this.contentWrapper.TabIndex = 0;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(228, 29);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(129, 20);
            this.date.TabIndex = 0;
            // 
            // firstMeal
            // 
            this.firstMeal.FormattingEnabled = true;
            this.firstMeal.Location = new System.Drawing.Point(155, 94);
            this.firstMeal.Name = "firstMeal";
            this.firstMeal.Size = new System.Drawing.Size(129, 21);
            this.firstMeal.TabIndex = 1;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateLabel.Location = new System.Drawing.Point(155, 24);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(59, 25);
            this.dateLabel.TabIndex = 2;
            this.dateLabel.Text = "Дата";
            // 
            // thirdMeal
            // 
            this.thirdMeal.FormattingEnabled = true;
            this.thirdMeal.Location = new System.Drawing.Point(155, 210);
            this.thirdMeal.Name = "thirdMeal";
            this.thirdMeal.Size = new System.Drawing.Size(129, 21);
            this.thirdMeal.TabIndex = 3;
            // 
            // secondMeal
            // 
            this.secondMeal.FormattingEnabled = true;
            this.secondMeal.Location = new System.Drawing.Point(155, 150);
            this.secondMeal.Name = "secondMeal";
            this.secondMeal.Size = new System.Drawing.Size(129, 21);
            this.secondMeal.TabIndex = 4;
            // 
            // firstMealLabel
            // 
            this.firstMealLabel.AutoSize = true;
            this.firstMealLabel.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstMealLabel.Location = new System.Drawing.Point(23, 86);
            this.firstMealLabel.Name = "firstMealLabel";
            this.firstMealLabel.Size = new System.Drawing.Size(118, 25);
            this.firstMealLabel.TabIndex = 6;
            this.firstMealLabel.Text = "Предястие";
            // 
            // secondMealLabel
            // 
            this.secondMealLabel.AutoSize = true;
            this.secondMealLabel.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondMealLabel.Location = new System.Drawing.Point(44, 148);
            this.secondMealLabel.Name = "secondMealLabel";
            this.secondMealLabel.Size = new System.Drawing.Size(97, 25);
            this.secondMealLabel.TabIndex = 8;
            this.secondMealLabel.Text = "Основно";
            // 
            // thirdMealLabel
            // 
            this.thirdMealLabel.AutoSize = true;
            this.thirdMealLabel.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.thirdMealLabel.Location = new System.Drawing.Point(62, 208);
            this.thirdMealLabel.Name = "thirdMealLabel";
            this.thirdMealLabel.Size = new System.Drawing.Size(79, 25);
            this.thirdMealLabel.TabIndex = 9;
            this.thirdMealLabel.Text = "Десерт";
            // 
            // newMenuButton
            // 
            this.newMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newMenuButton.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newMenuButton.Location = new System.Drawing.Point(172, 294);
            this.newMenuButton.Name = "newMenuButton";
            this.newMenuButton.Size = new System.Drawing.Size(168, 52);
            this.newMenuButton.TabIndex = 10;
            this.newMenuButton.Text = "Добави";
            this.newMenuButton.UseVisualStyleBackColor = true;
            this.newMenuButton.Click += new System.EventHandler(this.newMenuButton_Click);
            // 
            // firstMealCount
            // 
            this.firstMealCount.Location = new System.Drawing.Point(383, 99);
            this.firstMealCount.Name = "firstMealCount";
            this.firstMealCount.Size = new System.Drawing.Size(100, 20);
            this.firstMealCount.TabIndex = 11;
            // 
            // firstMealCountLabel
            // 
            this.firstMealCountLabel.AutoSize = true;
            this.firstMealCountLabel.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstMealCountLabel.Location = new System.Drawing.Point(307, 94);
            this.firstMealCountLabel.Name = "firstMealCountLabel";
            this.firstMealCountLabel.Size = new System.Drawing.Size(62, 25);
            this.firstMealCountLabel.TabIndex = 12;
            this.firstMealCountLabel.Text = "Брой";
            // 
            // secondMealCountLabel
            // 
            this.secondMealCountLabel.AutoSize = true;
            this.secondMealCountLabel.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondMealCountLabel.Location = new System.Drawing.Point(307, 150);
            this.secondMealCountLabel.Name = "secondMealCountLabel";
            this.secondMealCountLabel.Size = new System.Drawing.Size(62, 25);
            this.secondMealCountLabel.TabIndex = 14;
            this.secondMealCountLabel.Text = "Брой";
            // 
            // secondMealCount
            // 
            this.secondMealCount.Location = new System.Drawing.Point(383, 155);
            this.secondMealCount.Name = "secondMealCount";
            this.secondMealCount.Size = new System.Drawing.Size(100, 20);
            this.secondMealCount.TabIndex = 13;
            // 
            // thirdMealCountLabel
            // 
            this.thirdMealCountLabel.AutoSize = true;
            this.thirdMealCountLabel.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.thirdMealCountLabel.Location = new System.Drawing.Point(307, 206);
            this.thirdMealCountLabel.Name = "thirdMealCountLabel";
            this.thirdMealCountLabel.Size = new System.Drawing.Size(62, 25);
            this.thirdMealCountLabel.TabIndex = 16;
            this.thirdMealCountLabel.Text = "Брой";
            // 
            // thirdMealCount
            // 
            this.thirdMealCount.Location = new System.Drawing.Point(383, 211);
            this.thirdMealCount.Name = "thirdMealCount";
            this.thirdMealCount.Size = new System.Drawing.Size(100, 20);
            this.thirdMealCount.TabIndex = 15;
            // 
            // error
            // 
            this.error.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.error.ContainerControl = this;
            // 
            // NewMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 412);
            this.Controls.Add(this.contentWrapper);
            this.Name = "NewMenu";
            this.Text = "NewMenu";
            this.contentWrapper.ResumeLayout(false);
            this.contentWrapper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contentWrapper;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label firstMealLabel;
        private System.Windows.Forms.ComboBox secondMeal;
        private System.Windows.Forms.ComboBox thirdMeal;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.ComboBox firstMeal;
        private System.Windows.Forms.Label thirdMealLabel;
        private System.Windows.Forms.Label secondMealLabel;
        private System.Windows.Forms.Button newMenuButton;
        private System.Windows.Forms.Label thirdMealCountLabel;
        private System.Windows.Forms.TextBox thirdMealCount;
        private System.Windows.Forms.Label secondMealCountLabel;
        private System.Windows.Forms.TextBox secondMealCount;
        private System.Windows.Forms.Label firstMealCountLabel;
        private System.Windows.Forms.TextBox firstMealCount;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.ToolTip toolTip;
    }
}