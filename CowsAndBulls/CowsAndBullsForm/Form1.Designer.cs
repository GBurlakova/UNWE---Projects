namespace CowsAndBullsForm
{
    partial class Form1
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
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.enterNumberButton = new System.Windows.Forms.Button();
            this.newGameButton = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // numberTextBox
            // 
            this.numberTextBox.BackColor = System.Drawing.Color.Tan;
            this.numberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberTextBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.numberTextBox.Location = new System.Drawing.Point(32, 35);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(195, 26);
            this.numberTextBox.TabIndex = 0;
            // 
            // enterNumberButton
            // 
            this.enterNumberButton.BackColor = System.Drawing.Color.RosyBrown;
            this.enterNumberButton.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.enterNumberButton.FlatAppearance.BorderSize = 2;
            this.enterNumberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterNumberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterNumberButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.enterNumberButton.Location = new System.Drawing.Point(347, 35);
            this.enterNumberButton.Name = "enterNumberButton";
            this.enterNumberButton.Size = new System.Drawing.Size(109, 35);
            this.enterNumberButton.TabIndex = 1;
            this.enterNumberButton.Text = "Submit";
            this.enterNumberButton.UseVisualStyleBackColor = false;
            this.enterNumberButton.Click += new System.EventHandler(this.enterNumberButton_Click);
            // 
            // newGameButton
            // 
            this.newGameButton.BackColor = System.Drawing.Color.RosyBrown;
            this.newGameButton.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.newGameButton.FlatAppearance.BorderSize = 2;
            this.newGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newGameButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.newGameButton.Location = new System.Drawing.Point(520, 102);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(118, 40);
            this.newGameButton.TabIndex = 2;
            this.newGameButton.Text = "New game";
            this.newGameButton.UseVisualStyleBackColor = false;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.BackColor = System.Drawing.Color.Tan;
            this.resultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultTextBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.resultTextBox.Location = new System.Drawing.Point(32, 102);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(295, 324);
            this.resultTextBox.TabIndex = 3;
            this.resultTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CowsAndBullsForm.Properties.Resources.smile1;
            this.ClientSize = new System.Drawing.Size(650, 438);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.enterNumberButton);
            this.Controls.Add(this.numberTextBox);
            this.Name = "Form1";
            this.Text = "Cows And Bulls";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Button enterNumberButton;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.RichTextBox resultTextBox;
    }
}

