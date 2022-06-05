namespace ToDoApp_Project.View
{
    partial class AdminMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMain));
            this.btnToDos = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblAdminHeader = new System.Windows.Forms.Label();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnToDos
            // 
            this.btnToDos.BackColor = System.Drawing.Color.White;
            this.btnToDos.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToDos.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnToDos.Location = new System.Drawing.Point(251, 276);
            this.btnToDos.Name = "btnToDos";
            this.btnToDos.Size = new System.Drawing.Size(130, 55);
            this.btnToDos.TabIndex = 1;
            this.btnToDos.Text = "TODOS";
            this.btnToDos.UseVisualStyleBackColor = false;
            this.btnToDos.Click += new System.EventHandler(this.btnToDos_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnExit.Location = new System.Drawing.Point(251, 370);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(130, 55);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblAdminHeader
            // 
            this.lblAdminHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblAdminHeader.Font = new System.Drawing.Font("Franklin Gothic Medium", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminHeader.ForeColor = System.Drawing.Color.White;
            this.lblAdminHeader.Location = new System.Drawing.Point(-1, 71);
            this.lblAdminHeader.Name = "lblAdminHeader";
            this.lblAdminHeader.Size = new System.Drawing.Size(635, 85);
            this.lblAdminHeader.TabIndex = 3;
            this.lblAdminHeader.Text = "WELCOME!";
            this.lblAdminHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.BackColor = System.Drawing.Color.White;
            this.btnManageUsers.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageUsers.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnManageUsers.Location = new System.Drawing.Point(251, 181);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(130, 55);
            this.btnManageUsers.TabIndex = 0;
            this.btnManageUsers.Text = "MANAGE USERS";
            this.btnManageUsers.UseVisualStyleBackColor = false;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            // 
            // AdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::ToDoApp_Project.Properties.Resources.img5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.lblAdminHeader);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnToDos);
            this.Controls.Add(this.btnManageUsers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminView";
            this.Text = "ToDo App - Home";
            this.Load += new System.EventHandler(this.AdminView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Button btnToDos;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblAdminHeader;
    }
}