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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUsersManagementView
            // 
            this.btnUsersManagementView.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUsersManagementView.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsersManagementView.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUsersManagementView.Location = new System.Drawing.Point(251, 169);
            this.btnUsersManagementView.Name = "btnUsersManagementView";
            this.btnUsersManagementView.Size = new System.Drawing.Size(125, 49);
            this.btnUsersManagementView.TabIndex = 0;
            this.btnUsersManagementView.Text = "Users Management View";
            this.btnUsersManagementView.UseVisualStyleBackColor = false;
            this.btnUsersManagementView.Click += new System.EventHandler(this.btnUsersManagementView_Click);
            // 
            // ToDoListsButton
            // 
            this.ToDoListsButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.ToDoListsButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDoListsButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ToDoListsButton.Location = new System.Drawing.Point(251, 250);
            this.ToDoListsButton.Name = "ToDoListsButton";
            this.ToDoListsButton.Size = new System.Drawing.Size(125, 44);
            this.ToDoListsButton.TabIndex = 1;
            this.ToDoListsButton.Text = "ToDo Lists";
            this.ToDoListsButton.UseVisualStyleBackColor = false;
            this.ToDoListsButton.Click += new System.EventHandler(this.ToDoListsButton_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnExit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.Location = new System.Drawing.Point(251, 326);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(125, 44);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(144, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 77);
            this.label1.TabIndex = 3;
            this.label1.Text = "ADMIN HOME";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdminRoleAppView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::ToDoApp_Project.Properties.Resources._601078;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.ToDoListsButton);
            this.Controls.Add(this.btnUsersManagementView);
            this.Name = "AdminRoleAppView";
            this.Text = "ToDo App";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUsersManagementView;
        private System.Windows.Forms.Button ToDoListsButton;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
    }
}