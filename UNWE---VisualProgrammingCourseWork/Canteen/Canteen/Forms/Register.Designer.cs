namespace Canteen.Forms
{
    partial class Register
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
            this.registerLabel = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.contentWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // contentWrapper
            // 
            this.contentWrapper.Controls.Add(this.cancelButton);
            this.contentWrapper.Controls.Add(this.registerButton);
            this.contentWrapper.Controls.Add(this.firstName);
            this.contentWrapper.Controls.Add(this.firstNameLabel);
            this.contentWrapper.Controls.Add(this.lastName);
            this.contentWrapper.Controls.Add(this.lastNameLabel);
            this.contentWrapper.Controls.Add(this.password);
            this.contentWrapper.Controls.Add(this.username);
            this.contentWrapper.Controls.Add(this.passwordLabel);
            this.contentWrapper.Controls.Add(this.usernameLabel);
            this.contentWrapper.Controls.Add(this.registerLabel);
            this.contentWrapper.Location = new System.Drawing.Point(12, 12);
            this.contentWrapper.Name = "contentWrapper";
            this.contentWrapper.Size = new System.Drawing.Size(610, 444);
            this.contentWrapper.TabIndex = 0;
            // 
            // registerLabel
            // 
            this.registerLabel.AutoSize = true;
            this.registerLabel.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerLabel.Location = new System.Drawing.Point(195, 19);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(207, 38);
            this.registerLabel.TabIndex = 0;
            this.registerLabel.Text = "Регистрация";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(340, 264);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(181, 20);
            this.password.TabIndex = 4;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(340, 214);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(181, 20);
            this.username.TabIndex = 3;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.Location = new System.Drawing.Point(74, 258);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(87, 25);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "Парола";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameLabel.Location = new System.Drawing.Point(74, 209);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(210, 25);
            this.usernameLabel.TabIndex = 4;
            this.usernameLabel.Text = "Потребителско име";
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(340, 165);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(181, 20);
            this.lastName.TabIndex = 2;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNameLabel.Location = new System.Drawing.Point(74, 160);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(104, 25);
            this.lastNameLabel.TabIndex = 8;
            this.lastNameLabel.Text = "Фамилия";
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(340, 107);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(181, 20);
            this.firstName.TabIndex = 1;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNameLabel.Location = new System.Drawing.Point(74, 102);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(54, 25);
            this.firstNameLabel.TabIndex = 10;
            this.firstNameLabel.Text = "Име";
            // 
            // registerButton
            // 
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerButton.Location = new System.Drawing.Point(99, 352);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(185, 57);
            this.registerButton.TabIndex = 11;
            this.registerButton.Text = "Регистрация";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(319, 352);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(185, 57);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Отказ";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // error
            // 
            this.error.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.error.ContainerControl = this;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 482);
            this.Controls.Add(this.contentWrapper);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.contentWrapper.ResumeLayout(false);
            this.contentWrapper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contentWrapper;
        private System.Windows.Forms.Label registerLabel;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.ErrorProvider error;
    }
}