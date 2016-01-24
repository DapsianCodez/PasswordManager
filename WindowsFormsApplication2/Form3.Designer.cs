namespace WindowsFormsApplication2
{
    partial class user_register
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.new_username = new System.Windows.Forms.TextBox();
            this.new_password = new System.Windows.Forms.TextBox();
            this.repeat_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.security_question = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.security_answer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.code_gen = new System.Windows.Forms.TextBox();
            this.hint = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.incl_security = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "New username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "New password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Repeat password:";
            // 
            // new_username
            // 
            this.new_username.Location = new System.Drawing.Point(114, 13);
            this.new_username.Name = "new_username";
            this.new_username.Size = new System.Drawing.Size(191, 20);
            this.new_username.TabIndex = 3;
            // 
            // new_password
            // 
            this.new_password.Location = new System.Drawing.Point(114, 43);
            this.new_password.Name = "new_password";
            this.new_password.Size = new System.Drawing.Size(191, 20);
            this.new_password.TabIndex = 4;
            // 
            // repeat_password
            // 
            this.repeat_password.Location = new System.Drawing.Point(114, 73);
            this.repeat_password.Name = "repeat_password";
            this.repeat_password.Size = new System.Drawing.Size(191, 20);
            this.repeat_password.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Your own security question:";
            // 
            // security_question
            // 
            this.security_question.Enabled = false;
            this.security_question.Location = new System.Drawing.Point(11, 153);
            this.security_question.Name = "security_question";
            this.security_question.Size = new System.Drawing.Size(293, 20);
            this.security_question.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Answer to that question:";
            // 
            // security_answer
            // 
            this.security_answer.Enabled = false;
            this.security_answer.Location = new System.Drawing.Point(11, 192);
            this.security_answer.Name = "security_answer";
            this.security_answer.Size = new System.Drawing.Size(293, 20);
            this.security_answer.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(293, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Security code generator array (10-20 non-repeating symbols):";
            // 
            // code_gen
            // 
            this.code_gen.Enabled = false;
            this.code_gen.Location = new System.Drawing.Point(11, 231);
            this.code_gen.Name = "code_gen";
            this.code_gen.Size = new System.Drawing.Size(294, 20);
            this.code_gen.TabIndex = 11;
            // 
            // hint
            // 
            this.hint.AutoSize = true;
            this.hint.Location = new System.Drawing.Point(12, 254);
            this.hint.Name = "hint";
            this.hint.Size = new System.Drawing.Size(487, 13);
            this.hint.TabIndex = 12;
            this.hint.Text = "Hint: use random symbols instead of your private information,like your name, phon" +
    "e number, e-mail etc.";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(12, 293);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(292, 23);
            this.submit.TabIndex = 13;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            // 
            // incl_security
            // 
            this.incl_security.AutoSize = true;
            this.incl_security.Location = new System.Drawing.Point(12, 117);
            this.incl_security.Name = "incl_security";
            this.incl_security.Size = new System.Drawing.Size(151, 17);
            this.incl_security.TabIndex = 14;
            this.incl_security.Text = "Include advanced security";
            this.incl_security.UseVisualStyleBackColor = true;
            this.incl_security.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // user_register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 328);
            this.Controls.Add(this.incl_security);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.hint);
            this.Controls.Add(this.code_gen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.security_answer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.security_question);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.repeat_password);
            this.Controls.Add(this.new_password);
            this.Controls.Add(this.new_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "user_register";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.user_register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox new_username;
        private System.Windows.Forms.TextBox new_password;
        private System.Windows.Forms.TextBox repeat_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox security_question;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox security_answer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox code_gen;
        private System.Windows.Forms.Label hint;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.CheckBox incl_security;
    }
}