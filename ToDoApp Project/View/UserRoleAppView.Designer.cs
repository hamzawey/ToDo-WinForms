namespace ToDoApp_Project.View
{
    partial class UserRoleAppView
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
            this.userMainLabel = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.ToDoListsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userMainLabel
            // 
            this.userMainLabel.BackColor = System.Drawing.Color.Transparent;
            this.userMainLabel.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userMainLabel.ForeColor = System.Drawing.Color.MediumBlue;
            this.userMainLabel.Location = new System.Drawing.Point(12, 65);
            this.userMainLabel.Name = "userMainLabel";
            this.userMainLabel.Size = new System.Drawing.Size(610, 59);
            this.userMainLabel.TabIndex = 7;
            this.userMainLabel.Text = "onload";
            this.userMainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnExit.Location = new System.Drawing.Point(252, 328);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(130, 55);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ToDoListsButton
            // 
            this.ToDoListsButton.BackColor = System.Drawing.Color.White;
            this.ToDoListsButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDoListsButton.ForeColor = System.Drawing.Color.MediumBlue;
            this.ToDoListsButton.Location = new System.Drawing.Point(252, 206);
            this.ToDoListsButton.Name = "ToDoListsButton";
            this.ToDoListsButton.Size = new System.Drawing.Size(130, 55);
            this.ToDoListsButton.TabIndex = 5;
            this.ToDoListsButton.Text = "ToDo Lists";
            this.ToDoListsButton.UseVisualStyleBackColor = false;
            this.ToDoListsButton.Click += new System.EventHandler(this.ToDoListsButton_Click);
            // 
            // UserRoleAppView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.BackgroundImage = global::ToDoApp_Project.Properties.Resources.Ocean_Wallpaper_scaled;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.userMainLabel);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.ToDoListsButton);
            this.Name = "UserRoleAppView";
            this.Text = "MAIN MENU";
            this.Load += new System.EventHandler(this.UserRoleAppView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label userMainLabel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button ToDoListsButton;
    }
}