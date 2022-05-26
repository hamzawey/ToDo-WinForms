namespace ToDoApp_Project.View
{
    partial class RegisterView
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
            this.btnRegisterRegisterView = new System.Windows.Forms.Button();
            this.txtBoxRegisterName = new System.Windows.Forms.TextBox();
            this.txtBoxRegisterPassword = new System.Windows.Forms.TextBox();
            this.lblRegisterPassword = new System.Windows.Forms.Label();
            this.lblRegisterName = new System.Windows.Forms.Label();
            this.lblRegisterText = new System.Windows.Forms.Label();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnRegisterRegisterView
            // 
            this.btnRegisterRegisterView.BackColor = System.Drawing.Color.White;
            this.btnRegisterRegisterView.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterRegisterView.ForeColor = System.Drawing.Color.Navy;
            this.btnRegisterRegisterView.Location = new System.Drawing.Point(224, 240);
            this.btnRegisterRegisterView.Name = "btnRegisterRegisterView";
            this.btnRegisterRegisterView.Size = new System.Drawing.Size(139, 47);
            this.btnRegisterRegisterView.TabIndex = 11;
            this.btnRegisterRegisterView.Text = "REGISTER";
            this.btnRegisterRegisterView.UseVisualStyleBackColor = false;
            this.btnRegisterRegisterView.Click += new System.EventHandler(this.btnRegisterRegisterView_Click);
            // 
            // txtBoxRegisterName
            // 
            this.txtBoxRegisterName.Location = new System.Drawing.Point(54, 157);
            this.txtBoxRegisterName.Name = "txtBoxRegisterName";
            this.txtBoxRegisterName.Size = new System.Drawing.Size(150, 20);
            this.txtBoxRegisterName.TabIndex = 10;
            // 
            // txtBoxRegisterPassword
            // 
            this.txtBoxRegisterPassword.Location = new System.Drawing.Point(373, 157);
            this.txtBoxRegisterPassword.Name = "txtBoxRegisterPassword";
            this.txtBoxRegisterPassword.Size = new System.Drawing.Size(150, 20);
            this.txtBoxRegisterPassword.TabIndex = 9;
            this.txtBoxRegisterPassword.UseSystemPasswordChar = true;
            // 
            // lblRegisterPassword
            // 
            this.lblRegisterPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblRegisterPassword.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterPassword.ForeColor = System.Drawing.Color.Navy;
            this.lblRegisterPassword.Location = new System.Drawing.Point(373, 111);
            this.lblRegisterPassword.Name = "lblRegisterPassword";
            this.lblRegisterPassword.Size = new System.Drawing.Size(150, 23);
            this.lblRegisterPassword.TabIndex = 8;
            this.lblRegisterPassword.Text = "PASSWORD";
            // 
            // lblRegisterName
            // 
            this.lblRegisterName.BackColor = System.Drawing.Color.Transparent;
            this.lblRegisterName.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterName.ForeColor = System.Drawing.Color.Navy;
            this.lblRegisterName.Location = new System.Drawing.Point(85, 110);
            this.lblRegisterName.Name = "lblRegisterName";
            this.lblRegisterName.Size = new System.Drawing.Size(84, 23);
            this.lblRegisterName.TabIndex = 7;
            this.lblRegisterName.Text = "NAME";
            // 
            // lblRegisterText
            // 
            this.lblRegisterText.BackColor = System.Drawing.Color.Transparent;
            this.lblRegisterText.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterText.ForeColor = System.Drawing.Color.Navy;
            this.lblRegisterText.Location = new System.Drawing.Point(12, 24);
            this.lblRegisterText.Name = "lblRegisterText";
            this.lblRegisterText.Size = new System.Drawing.Size(560, 49);
            this.lblRegisterText.TabIndex = 6;
            this.lblRegisterText.Text = "onload";
            this.lblRegisterText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.White;
            this.btnGoBack.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoBack.ForeColor = System.Drawing.Color.Navy;
            this.btnGoBack.Location = new System.Drawing.Point(456, 312);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(116, 37);
            this.btnGoBack.TabIndex = 12;
            this.btnGoBack.Text = "GO BACK";
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(373, 183);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(150, 24);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "SHOW PASSWORD";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // RegisterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::ToDoApp_Project.Properties.Resources._360_F_300808649_zCM3DACzRfbgSaZ2RsyDLZqIsf6Nh3hW;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.btnRegisterRegisterView);
            this.Controls.Add(this.txtBoxRegisterName);
            this.Controls.Add(this.txtBoxRegisterPassword);
            this.Controls.Add(this.lblRegisterPassword);
            this.Controls.Add(this.lblRegisterName);
            this.Controls.Add(this.lblRegisterText);
            this.Name = "RegisterView";
            this.Text = "REGISTER";
            this.Load += new System.EventHandler(this.RegisterView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegisterRegisterView;
        private System.Windows.Forms.TextBox txtBoxRegisterName;
        private System.Windows.Forms.TextBox txtBoxRegisterPassword;
        private System.Windows.Forms.Label lblRegisterPassword;
        private System.Windows.Forms.Label lblRegisterName;
        private System.Windows.Forms.Label lblRegisterText;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}