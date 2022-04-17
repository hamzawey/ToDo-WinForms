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
            this.SuspendLayout();
            // 
            // btnRegisterRegisterView
            // 
            this.btnRegisterRegisterView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterRegisterView.Location = new System.Drawing.Point(229, 241);
            this.btnRegisterRegisterView.Name = "btnRegisterRegisterView";
            this.btnRegisterRegisterView.Size = new System.Drawing.Size(130, 47);
            this.btnRegisterRegisterView.TabIndex = 11;
            this.btnRegisterRegisterView.Text = "REGISTER";
            this.btnRegisterRegisterView.UseVisualStyleBackColor = true;
            this.btnRegisterRegisterView.Click += new System.EventHandler(this.btnRegisterRegisterView_Click);
            // 
            // txtBoxRegisterName
            // 
            this.txtBoxRegisterName.Location = new System.Drawing.Point(59, 170);
            this.txtBoxRegisterName.Name = "txtBoxRegisterName";
            this.txtBoxRegisterName.Size = new System.Drawing.Size(150, 20);
            this.txtBoxRegisterName.TabIndex = 10;
            // 
            // txtBoxRegisterPassword
            // 
            this.txtBoxRegisterPassword.Location = new System.Drawing.Point(378, 170);
            this.txtBoxRegisterPassword.Name = "txtBoxRegisterPassword";
            this.txtBoxRegisterPassword.Size = new System.Drawing.Size(150, 20);
            this.txtBoxRegisterPassword.TabIndex = 9;
            // 
            // lblRegisterPassword
            // 
            this.lblRegisterPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterPassword.ForeColor = System.Drawing.Color.White;
            this.lblRegisterPassword.Location = new System.Drawing.Point(386, 124);
            this.lblRegisterPassword.Name = "lblRegisterPassword";
            this.lblRegisterPassword.Size = new System.Drawing.Size(129, 23);
            this.lblRegisterPassword.TabIndex = 8;
            this.lblRegisterPassword.Text = "PASSWORD";
            // 
            // lblRegisterName
            // 
            this.lblRegisterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterName.ForeColor = System.Drawing.Color.White;
            this.lblRegisterName.Location = new System.Drawing.Point(96, 124);
            this.lblRegisterName.Name = "lblRegisterName";
            this.lblRegisterName.Size = new System.Drawing.Size(75, 23);
            this.lblRegisterName.TabIndex = 7;
            this.lblRegisterName.Text = "NAME";
            // 
            // lblRegisterText
            // 
            this.lblRegisterText.Font = new System.Drawing.Font("Segoe MDL2 Assets", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterText.ForeColor = System.Drawing.Color.White;
            this.lblRegisterText.Location = new System.Drawing.Point(187, 23);
            this.lblRegisterText.Name = "lblRegisterText";
            this.lblRegisterText.Size = new System.Drawing.Size(222, 69);
            this.lblRegisterText.TabIndex = 6;
            this.lblRegisterText.Text = "REGISTER";
            // 
            // RegisterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btnRegisterRegisterView);
            this.Controls.Add(this.txtBoxRegisterName);
            this.Controls.Add(this.txtBoxRegisterPassword);
            this.Controls.Add(this.lblRegisterPassword);
            this.Controls.Add(this.lblRegisterName);
            this.Controls.Add(this.lblRegisterText);
            this.Name = "RegisterView";
            this.Text = "ToDo App";
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
    }
}