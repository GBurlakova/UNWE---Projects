namespace Canteen.Forms
{
    partial class AboutScreen
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
            this.aboutBox = new System.Windows.Forms.RichTextBox();
            this.aboutLabel = new System.Windows.Forms.Label();
            this.contentWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentWrapper
            // 
            this.contentWrapper.Controls.Add(this.aboutBox);
            this.contentWrapper.Controls.Add(this.aboutLabel);
            this.contentWrapper.Location = new System.Drawing.Point(12, 12);
            this.contentWrapper.Name = "contentWrapper";
            this.contentWrapper.Size = new System.Drawing.Size(610, 305);
            this.contentWrapper.TabIndex = 0;
            // 
            // aboutBox
            // 
            this.aboutBox.Location = new System.Drawing.Point(42, 77);
            this.aboutBox.Name = "aboutBox";
            this.aboutBox.Size = new System.Drawing.Size(510, 184);
            this.aboutBox.TabIndex = 1;
            this.aboutBox.Text = "";
            // 
            // aboutLabel
            // 
            this.aboutLabel.AutoSize = true;
            this.aboutLabel.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aboutLabel.Location = new System.Drawing.Point(197, 14);
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(198, 38);
            this.aboutLabel.TabIndex = 0;
            this.aboutLabel.Text = "За продукта";
            // 
            // AboutScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 342);
            this.Controls.Add(this.contentWrapper);
            this.Name = "AboutScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AboutScreencs";
            this.contentWrapper.ResumeLayout(false);
            this.contentWrapper.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contentWrapper;
        private System.Windows.Forms.RichTextBox aboutBox;
        private System.Windows.Forms.Label aboutLabel;
    }
}