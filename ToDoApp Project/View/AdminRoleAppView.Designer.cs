namespace ToDoApp_Project.View
{
    partial class AdminRoleAppView
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
            this.btnUsersManagementView = new System.Windows.Forms.Button();
            this.ToDoListsButton = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.adminMainLabel = new System.Windows.Forms.Label();
            this.adminRoleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUsersManagementView
            // 
            this.btnUsersManagementView.BackColor = System.Drawing.Color.White;
            this.btnUsersManagementView.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsersManagementView.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnUsersManagementView.Location = new System.Drawing.Point(251, 181);
            this.btnUsersManagementView.Name = "btnUsersManagementView";
            this.btnUsersManagementView.Size = new System.Drawing.Size(130, 55);
            this.btnUsersManagementView.TabIndex = 0;
            this.btnUsersManagementView.Text = "Manage Users";
            this.btnUsersManagementView.UseVisualStyleBackColor = false;
            this.btnUsersManagementView.Click += new System.EventHandler(this.btnUsersManagementView_Click);
            // 
            // ToDoListsButton
            // 
            this.ToDoListsButton.BackColor = System.Drawing.Color.White;
            this.ToDoListsButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDoListsButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ToDoListsButton.Location = new System.Drawing.Point(251, 276);
            this.ToDoListsButton.Name = "ToDoListsButton";
            this.ToDoListsButton.Size = new System.Drawing.Size(130, 55);
            this.ToDoListsButton.TabIndex = 1;
            this.ToDoListsButton.Text = "ToDo Lists";
            this.ToDoListsButton.UseVisualStyleBackColor = false;
            this.ToDoListsButton.Click += new System.EventHandler(this.ToDoListsButton_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnExit.Location = new System.Drawing.Point(251, 370);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(130, 55);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // adminMainLabel
            // 
            this.adminMainLabel.BackColor = System.Drawing.Color.Transparent;
            this.adminMainLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminMainLabel.ForeColor = System.Drawing.Color.White;
            this.adminMainLabel.Location = new System.Drawing.Point(144, 9);
            this.adminMainLabel.Name = "adminMainLabel";
            this.adminMainLabel.Size = new System.Drawing.Size(345, 91);
            this.adminMainLabel.TabIndex = 3;
            this.adminMainLabel.Text = "onload";
            this.adminMainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // adminRoleLabel
            // 
            this.adminRoleLabel.BackColor = System.Drawing.Color.Transparent;
            this.adminRoleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminRoleLabel.ForeColor = System.Drawing.Color.White;
            this.adminRoleLabel.Location = new System.Drawing.Point(12, 113);
            this.adminRoleLabel.Name = "adminRoleLabel";
            this.adminRoleLabel.Size = new System.Drawing.Size(610, 23);
            this.adminRoleLabel.TabIndex = 4;
            this.adminRoleLabel.Text = "onload";
            this.adminRoleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdminRoleAppView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::ToDoApp_Project.Properties.Resources._601078;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.adminRoleLabel);
            this.Controls.Add(this.adminMainLabel);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.ToDoListsButton);
            this.Controls.Add(this.btnUsersManagementView);
            this.Name = "AdminRoleAppView";
            this.Text = "MAIN MENU ADMIN";
            this.Load += new System.EventHandler(this.AdminRoleAppView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUsersManagementView;
        private System.Windows.Forms.Button ToDoListsButton;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label adminMainLabel;
        private System.Windows.Forms.Label adminRoleLabel;
    }
}