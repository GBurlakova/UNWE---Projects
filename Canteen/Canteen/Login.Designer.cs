namespace Canteen
{
    partial class Login
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
            this.enterLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.contentWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentWrapper
            // 
            this.contentWrapper.Controls.Add(this.password);
            this.contentWrapper.Controls.Add(this.enterButton);
            this.contentWrapper.Controls.Add(this.username);
            this.contentWrapper.Controls.Add(this.passwordLabel);
            this.contentWrapper.Controls.Add(this.usernameLabel);
            this.contentWrapper.Controls.Add(this.enterLabel);
            this.contentWrapper.Location = new System.Drawing.Point(12, 12);
            this.contentWrapper.Name = "contentWrapper";
            this.contentWrapper.Size = new System.Drawing.Size(610, 458);
            this.contentWrapper.TabIndex = 2;
            // 
            // enterLabel
            // 
            this.enterLabel.AutoSize = true;
            this.enterLabel.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterLabel.Location = new System.Drawing.Point(254, 25);
            this.enterLabel.Name = "enterLabel";
            this.enterLabel.Size = new System.Drawing.Size(89, 38);
            this.enterLabel.TabIndex = 0;
            this.enterLabel.Text = "Вход";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameLabel.Location = new System.Drawing.Point(52, 138);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(210, 25);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Потребителско име";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.Location = new System.Drawing.Point(52, 187);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(87, 25);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Парола";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(318, 143);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(181, 20);
            this.username.TabIndex = 1;
            // 
            // enterButton
            // 
            this.enterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterButton.Location = new System.Drawing.Point(191, 279);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(215, 48);
            this.enterButton.TabIndex = 3;
            this.enterButton.Text = "Вход";
            this.enterButton.UseVisualStyleBackColor = true;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(318, 193);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(181, 20);
            this.password.TabIndex = 2;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 482);
            this.Controls.Add(this.contentWrapper);
            this.Name = "Login";
            this.Text = "Login";
            this.contentWrapper.ResumeLayout(false);
            this.contentWrapper.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contentWrapper;
        private System.Windows.Forms.Label enterLabel;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.TextBox password;


    }
}