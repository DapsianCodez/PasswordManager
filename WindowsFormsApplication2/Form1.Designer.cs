namespace WindowsFormsApplication2
{
    partial class start_screen
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
            this.welcome = new System.Windows.Forms.Label();
            this.existing_user = new System.Windows.Forms.Button();
            this.new_user = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Location = new System.Drawing.Point(118, 9);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(55, 13);
            this.welcome.TabIndex = 0;
            this.welcome.Text = "Welcome.";
            // 
            // existing_user
            // 
            this.existing_user.Location = new System.Drawing.Point(12, 36);
            this.existing_user.Name = "existing_user";
            this.existing_user.Size = new System.Drawing.Size(268, 23);
            this.existing_user.TabIndex = 1;
            this.existing_user.Text = "Existing user";
            this.existing_user.UseVisualStyleBackColor = true;
            this.existing_user.Click += new System.EventHandler(this.existing_user_Click);
            // 
            // new_user
            // 
            this.new_user.Location = new System.Drawing.Point(12, 65);
            this.new_user.Name = "new_user";
            this.new_user.Size = new System.Drawing.Size(268, 23);
            this.new_user.TabIndex = 2;
            this.new_user.Text = "New user";
            this.new_user.UseVisualStyleBackColor = true;
            this.new_user.Click += new System.EventHandler(this.new_user_Click);
            // 
            // start_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 101);
            this.Controls.Add(this.new_user);
            this.Controls.Add(this.existing_user);
            this.Controls.Add(this.welcome);
            this.Name = "start_screen";
            this.Text = "Start";
            this.Load += new System.EventHandler(this.start_screen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Button existing_user;
        private System.Windows.Forms.Button new_user;
    }
}

