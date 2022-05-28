namespace ToDoApp_Project.View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.btnRegisterUser = new System.Windows.Forms.Button();
            this.txtRegisterName = new System.Windows.Forms.TextBox();
            this.txtRegisterPassword = new System.Windows.Forms.TextBox();
            this.lblRegisterPassword = new System.Windows.Forms.Label();
            this.lblRegisterName = new System.Windows.Forms.Label();
            this.lblRegisterHeader = new System.Windows.Forms.Label();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.checkTogglePassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnRegisterUser
            // 
            this.btnRegisterUser.BackColor = System.Drawing.Color.White;
            this.btnRegisterUser.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRegisterUser.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterUser.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnRegisterUser.Location = new System.Drawing.Point(224, 240);
            this.btnRegisterUser.Name = "btnRegisterUser";
            this.btnRegisterUser.Size = new System.Drawing.Size(139, 47);
            this.btnRegisterUser.TabIndex = 11;
            this.btnRegisterUser.Text = "REGISTER";
            this.btnRegisterUser.UseVisualStyleBackColor = false;
            this.btnRegisterUser.Click += new System.EventHandler(this.btnRegisterUser_Click);
            // 
            // txtRegisterName
            // 
            this.txtRegisterName.Location = new System.Drawing.Point(54, 157);
            this.txtRegisterName.Name = "txtRegisterName";
            this.txtRegisterName.Size = new System.Drawing.Size(150, 20);
            this.txtRegisterName.TabIndex = 10;
            // 
            // txtRegisterPassword
            // 
            this.txtRegisterPassword.Location = new System.Drawing.Point(373, 157);
            this.txtRegisterPassword.Name = "txtRegisterPassword";
            this.txtRegisterPassword.Size = new System.Drawing.Size(150, 20);
            this.txtRegisterPassword.TabIndex = 9;
            this.txtRegisterPassword.UseSystemPasswordChar = true;
            // 
            // lblRegisterPassword
            // 
            this.lblRegisterPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblRegisterPassword.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterPassword.ForeColor = System.Drawing.Color.White;
            this.lblRegisterPassword.Location = new System.Drawing.Point(373, 111);
            this.lblRegisterPassword.Name = "lblRegisterPassword";
            this.lblRegisterPassword.Size = new System.Drawing.Size(150, 23);
            this.lblRegisterPassword.TabIndex = 8;
            this.lblRegisterPassword.Text = "PASSWORD";
            this.lblRegisterPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRegisterName
            // 
            this.lblRegisterName.BackColor = System.Drawing.Color.Transparent;
            this.lblRegisterName.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterName.ForeColor = System.Drawing.Color.White;
            this.lblRegisterName.Location = new System.Drawing.Point(89, 111);
            this.lblRegisterName.Name = "lblRegisterName";
            this.lblRegisterName.Size = new System.Drawing.Size(84, 23);
            this.lblRegisterName.TabIndex = 7;
            this.lblRegisterName.Text = "NAME";
            this.lblRegisterName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRegisterHeader
            // 
            this.lblRegisterHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblRegisterHeader.Font = new System.Drawing.Font("Franklin Gothic Medium", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterHeader.ForeColor = System.Drawing.Color.White;
            this.lblRegisterHeader.Location = new System.Drawing.Point(-1, 9);
            this.lblRegisterHeader.Name = "lblRegisterHeader";
            this.lblRegisterHeader.Size = new System.Drawing.Size(584, 64);
            this.lblRegisterHeader.TabIndex = 6;
            this.lblRegisterHeader.Text = "REGISTER";
            this.lblRegisterHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.White;
            this.btnGoBack.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGoBack.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoBack.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnGoBack.Location = new System.Drawing.Point(456, 312);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(116, 37);
            this.btnGoBack.TabIndex = 12;
            this.btnGoBack.Text = "GO BACK";
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // checkTogglePassword
            // 
            this.checkTogglePassword.BackColor = System.Drawing.Color.Transparent;
            this.checkTogglePassword.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkTogglePassword.ForeColor = System.Drawing.Color.White;
            this.checkTogglePassword.Location = new System.Drawing.Point(373, 183);
            this.checkTogglePassword.Name = "checkTogglePassword";
            this.checkTogglePassword.Size = new System.Drawing.Size(150, 24);
            this.checkTogglePassword.TabIndex = 13;
            this.checkTogglePassword.Text = "SHOW PASSWORD";
            this.checkTogglePassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkTogglePassword.UseVisualStyleBackColor = false;
            this.checkTogglePassword.CheckedChanged += new System.EventHandler(this.checkTogglePassword_CheckedChanged);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::ToDoApp_Project.Properties.Resources.img1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.checkTogglePassword);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.btnRegisterUser);
            this.Controls.Add(this.txtRegisterName);
            this.Controls.Add(this.txtRegisterPassword);
            this.Controls.Add(this.lblRegisterPassword);
            this.Controls.Add(this.lblRegisterName);
            this.Controls.Add(this.lblRegisterHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegisterUser;
        private System.Windows.Forms.TextBox txtRegisterName;
        private System.Windows.Forms.TextBox txtRegisterPassword;
        private System.Windows.Forms.Label lblRegisterPassword;
        private System.Windows.Forms.Label lblRegisterName;
        private System.Windows.Forms.Label lblRegisterHeader;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.CheckBox checkTogglePassword;
    }
}