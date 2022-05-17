namespace ToDoApp_Project.View
{
    partial class LoginView
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
            this.lblSignInText = new System.Windows.Forms.Label();
            this.lblSignInName = new System.Windows.Forms.Label();
            this.lblSignInPassword = new System.Windows.Forms.Label();
            this.txtBoxSignInPassword = new System.Windows.Forms.TextBox();
            this.txtBoxSignInName = new System.Windows.Forms.TextBox();
            this.btnSignInLoginView = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSignInText
            // 
            this.lblSignInText.BackColor = System.Drawing.Color.Transparent;
            this.lblSignInText.Font = new System.Drawing.Font("Segoe MDL2 Assets", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignInText.ForeColor = System.Drawing.Color.Black;
            this.lblSignInText.Location = new System.Drawing.Point(219, 19);
            this.lblSignInText.Name = "lblSignInText";
            this.lblSignInText.Size = new System.Drawing.Size(168, 69);
            this.lblSignInText.TabIndex = 0;
            this.lblSignInText.Text = "SIGN IN";
            // 
            // lblSignInName
            // 
            this.lblSignInName.BackColor = System.Drawing.Color.Transparent;
            this.lblSignInName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignInName.ForeColor = System.Drawing.Color.Black;
            this.lblSignInName.Location = new System.Drawing.Point(104, 110);
            this.lblSignInName.Name = "lblSignInName";
            this.lblSignInName.Size = new System.Drawing.Size(75, 23);
            this.lblSignInName.TabIndex = 1;
            this.lblSignInName.Text = "NAME";
            // 
            // lblSignInPassword
            // 
            this.lblSignInPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblSignInPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignInPassword.ForeColor = System.Drawing.Color.Black;
            this.lblSignInPassword.Location = new System.Drawing.Point(394, 110);
            this.lblSignInPassword.Name = "lblSignInPassword";
            this.lblSignInPassword.Size = new System.Drawing.Size(129, 23);
            this.lblSignInPassword.TabIndex = 2;
            this.lblSignInPassword.Text = "PASSWORD";
            // 
            // txtBoxSignInPassword
            // 
            this.txtBoxSignInPassword.Location = new System.Drawing.Point(386, 156);
            this.txtBoxSignInPassword.Name = "txtBoxSignInPassword";
            this.txtBoxSignInPassword.Size = new System.Drawing.Size(150, 20);
            this.txtBoxSignInPassword.TabIndex = 3;
            this.txtBoxSignInPassword.UseSystemPasswordChar = true;
            // 
            // txtBoxSignInName
            // 
            this.txtBoxSignInName.Location = new System.Drawing.Point(67, 156);
            this.txtBoxSignInName.Name = "txtBoxSignInName";
            this.txtBoxSignInName.Size = new System.Drawing.Size(150, 20);
            this.txtBoxSignInName.TabIndex = 4;
            // 
            // btnSignInLoginView
            // 
            this.btnSignInLoginView.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSignInLoginView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignInLoginView.ForeColor = System.Drawing.Color.White;
            this.btnSignInLoginView.Location = new System.Drawing.Point(238, 234);
            this.btnSignInLoginView.Name = "btnSignInLoginView";
            this.btnSignInLoginView.Size = new System.Drawing.Size(130, 47);
            this.btnSignInLoginView.TabIndex = 5;
            this.btnSignInLoginView.Text = "SIGN IN";
            this.btnSignInLoginView.UseVisualStyleBackColor = false;
            this.btnSignInLoginView.Click += new System.EventHandler(this.btnSignInLoginView_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnGoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoBack.ForeColor = System.Drawing.Color.White;
            this.btnGoBack.Location = new System.Drawing.Point(458, 316);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(114, 33);
            this.btnGoBack.TabIndex = 6;
            this.btnGoBack.Text = "GO BACK";
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::ToDoApp_Project.Properties.Resources._360_F_300808649_zCM3DACzRfbgSaZ2RsyDLZqIsf6Nh3hW;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.btnSignInLoginView);
            this.Controls.Add(this.txtBoxSignInName);
            this.Controls.Add(this.txtBoxSignInPassword);
            this.Controls.Add(this.lblSignInPassword);
            this.Controls.Add(this.lblSignInName);
            this.Controls.Add(this.lblSignInText);
            this.Name = "LoginView";
            this.Text = "ToDo App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSignInText;
        private System.Windows.Forms.Label lblSignInName;
        private System.Windows.Forms.Label lblSignInPassword;
        private System.Windows.Forms.TextBox txtBoxSignInPassword;
        private System.Windows.Forms.TextBox txtBoxSignInName;
        private System.Windows.Forms.Button btnSignInLoginView;
        private System.Windows.Forms.Button btnGoBack;
    }
}