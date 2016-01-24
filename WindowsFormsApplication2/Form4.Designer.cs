namespace WindowsFormsApplication2
{
    partial class manager
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
            this.label1 = new System.Windows.Forms.Label();
            this.login_entry = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.account_list = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.check = new System.Windows.Forms.Button();
            this.add_new = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entry for login:";
            // 
            // login_entry
            // 
            this.login_entry.Location = new System.Drawing.Point(13, 30);
            this.login_entry.Name = "login_entry";
            this.login_entry.Size = new System.Drawing.Size(267, 20);
            this.login_entry.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Account:";
            // 
            // account_list
            // 
            this.account_list.FormattingEnabled = true;
            this.account_list.Location = new System.Drawing.Point(13, 74);
            this.account_list.Name = "account_list";
            this.account_list.Size = new System.Drawing.Size(267, 21);
            this.account_list.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password:";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(10, 121);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(37, 13);
            this.password.TabIndex = 5;
            this.password.Text = "passw";
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(12, 152);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(268, 23);
            this.check.TabIndex = 6;
            this.check.Text = "Check entry";
            this.check.UseVisualStyleBackColor = true;
            // 
            // add_new
            // 
            this.add_new.Location = new System.Drawing.Point(12, 182);
            this.add_new.Name = "add_new";
            this.add_new.Size = new System.Drawing.Size(268, 23);
            this.add_new.TabIndex = 7;
            this.add_new.Text = "Add new entry";
            this.add_new.UseVisualStyleBackColor = true;
            // 
            // manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 209);
            this.Controls.Add(this.add_new);
            this.Controls.Add(this.check);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.account_list);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.login_entry);
            this.Controls.Add(this.label1);
            this.Name = "manager";
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox login_entry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox account_list;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Button add_new;
    }
}