namespace ToDoApp_Project.View
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
            this.lblHeaderLogin = new System.Windows.Forms.Label();
            this.lblLoginName = new System.Windows.Forms.Label();
            this.lblLoginPassword = new System.Windows.Forms.Label();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.txtLoginName = new System.Windows.Forms.TextBox();
            this.btnLoginUser = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.checkShowPassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblHeaderLogin
            // 
            this.lblHeaderLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblHeaderLogin.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderLogin.ForeColor = System.Drawing.Color.White;
            this.lblHeaderLogin.Location = new System.Drawing.Point(12, 28);
            this.lblHeaderLogin.Name = "lblHeaderLogin";
            this.lblHeaderLogin.Size = new System.Drawing.Size(560, 50);
            this.lblHeaderLogin.TabIndex = 0;
            this.lblHeaderLogin.Text = "LOGIN";
            this.lblHeaderLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLoginName
            // 
            this.lblLoginName.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginName.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginName.ForeColor = System.Drawing.Color.White;
            this.lblLoginName.Location = new System.Drawing.Point(89, 111);
            this.lblLoginName.Name = "lblLoginName";
            this.lblLoginName.Size = new System.Drawing.Size(80, 23);
            this.lblLoginName.TabIndex = 1;
            this.lblLoginName.Text = "NAME";
            // 
            // lblLoginPassword
            // 
            this.lblLoginPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginPassword.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginPassword.ForeColor = System.Drawing.Color.White;
            this.lblLoginPassword.Location = new System.Drawing.Point(374, 111);
            this.lblLoginPassword.Name = "lblLoginPassword";
            this.lblLoginPassword.Size = new System.Drawing.Size(150, 23);
            this.lblLoginPassword.TabIndex = 2;
            this.lblLoginPassword.Text = "PASSWORD";
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.Location = new System.Drawing.Point(374, 157);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.Size = new System.Drawing.Size(150, 20);
            this.txtLoginPassword.TabIndex = 3;
            this.txtLoginPassword.UseSystemPasswordChar = true;
            // 
            // txtLoginName
            // 
            this.txtLoginName.Location = new System.Drawing.Point(55, 157);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.Size = new System.Drawing.Size(150, 20);
            this.txtLoginName.TabIndex = 4;
            // 
            // btnLoginUser
            // 
            this.btnLoginUser.BackColor = System.Drawing.Color.White;
            this.btnLoginUser.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginUser.ForeColor = System.Drawing.Color.Black;
            this.btnLoginUser.Location = new System.Drawing.Point(226, 235);
            this.btnLoginUser.Name = "btnLoginUser";
            this.btnLoginUser.Size = new System.Drawing.Size(130, 47);
            this.btnLoginUser.TabIndex = 5;
            this.btnLoginUser.Text = "LOGIN";
            this.btnLoginUser.UseVisualStyleBackColor = false;
            this.btnLoginUser.Click += new System.EventHandler(this.btnLoginUser_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.White;
            this.btnGoBack.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoBack.ForeColor = System.Drawing.Color.Black;
            this.btnGoBack.Location = new System.Drawing.Point(458, 316);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(114, 33);
            this.btnGoBack.TabIndex = 6;
            this.btnGoBack.Text = "GO BACK";
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // checkShowPassword
            // 
            this.checkShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.checkShowPassword.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkShowPassword.ForeColor = System.Drawing.Color.White;
            this.checkShowPassword.Location = new System.Drawing.Point(374, 183);
            this.checkShowPassword.Name = "checkShowPassword";
            this.checkShowPassword.Size = new System.Drawing.Size(150, 24);
            this.checkShowPassword.TabIndex = 7;
            this.checkShowPassword.Text = "SHOW PASSWORD";
            this.checkShowPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkShowPassword.UseVisualStyleBackColor = false;
            this.checkShowPassword.CheckedChanged += new System.EventHandler(this.checkShowPassword_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.checkShowPassword);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.btnLoginUser);
            this.Controls.Add(this.txtLoginName);
            this.Controls.Add(this.txtLoginPassword);
            this.Controls.Add(this.lblLoginPassword);
            this.Controls.Add(this.lblLoginName);
            this.Controls.Add(this.lblHeaderLogin);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeaderLogin;
        private System.Windows.Forms.Label lblLoginName;
        private System.Windows.Forms.Label lblLoginPassword;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.TextBox txtLoginName;
        private System.Windows.Forms.Button btnLoginUser;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.CheckBox checkShowPassword;
    }
}