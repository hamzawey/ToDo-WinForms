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
            this.SuspendLayout();
            // 
            // btnUsersManagementView
            // 
            this.btnUsersManagementView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsersManagementView.Location = new System.Drawing.Point(1177, 12);
            this.btnUsersManagementView.Name = "btnUsersManagementView";
            this.btnUsersManagementView.Size = new System.Drawing.Size(195, 42);
            this.btnUsersManagementView.TabIndex = 0;
            this.btnUsersManagementView.Text = "Users Management View";
            this.btnUsersManagementView.UseVisualStyleBackColor = true;
            this.btnUsersManagementView.Click += new System.EventHandler(this.btnUsersManagementView_Click);
            // 
            // AdminRoleAppView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1384, 761);
            this.Controls.Add(this.btnUsersManagementView);
            this.Name = "AdminRoleAppView";
            this.Text = "ToDo App";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUsersManagementView;
    }
}