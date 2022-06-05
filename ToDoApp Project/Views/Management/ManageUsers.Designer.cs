namespace ToDoApp_Project.View
{
    partial class ManageUsers
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUsers));
            this.dgvManageUsers = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnManageEdit = new System.Windows.Forms.Button();
            this.btnManageCreate = new System.Windows.Forms.Button();
            this.btnManageDelete = new System.Windows.Forms.Button();
            this.txtManageCreateId = new System.Windows.Forms.TextBox();
            this.txtManageCreatePassword = new System.Windows.Forms.TextBox();
            this.txtManageCreateUsername = new System.Windows.Forms.TextBox();
            this.txtManageCreateRole = new System.Windows.Forms.TextBox();
            this.lblManageUsersDelete = new System.Windows.Forms.Label();
            this.lblManageUsersCreate = new System.Windows.Forms.Label();
            this.lblManageUsersEdit = new System.Windows.Forms.Label();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.lblManageUsersHeader = new System.Windows.Forms.Label();
            this.lblManageCreateId = new System.Windows.Forms.Label();
            this.lblManageCreateUsername = new System.Windows.Forms.Label();
            this.lblManageCreatePassword = new System.Windows.Forms.Label();
            this.lblManageCreateRole = new System.Windows.Forms.Label();
            this.lblManageEditRole = new System.Windows.Forms.Label();
            this.lblManageEditPassword = new System.Windows.Forms.Label();
            this.lblManageEditUsername = new System.Windows.Forms.Label();
            this.txtManageEditRole = new System.Windows.Forms.TextBox();
            this.txtManageEditUsername = new System.Windows.Forms.TextBox();
            this.txtManageEditPassword = new System.Windows.Forms.TextBox();
            this.txtManageDeleteById = new System.Windows.Forms.TextBox();
            this.lblManageUsersDeleteById = new System.Windows.Forms.Label();
            this.btnManageDeleteById = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvManageUsers
            // 
            this.dgvManageUsers.AllowUserToAddRows = false;
            this.dgvManageUsers.AllowUserToDeleteRows = false;
            this.dgvManageUsers.AllowUserToResizeColumns = false;
            this.dgvManageUsers.AllowUserToResizeRows = false;
            this.dgvManageUsers.AutoGenerateColumns = false;
            this.dgvManageUsers.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.dgvManageUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManageUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dgvManageUsers.DataSource = this.userBindingSource;
            this.dgvManageUsers.Location = new System.Drawing.Point(12, 48);
            this.dgvManageUsers.Name = "dgvManageUsers";
            this.dgvManageUsers.ReadOnly = true;
            this.dgvManageUsers.RowHeadersVisible = false;
            this.dgvManageUsers.Size = new System.Drawing.Size(323, 611);
            this.dgvManageUsers.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 40;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Username";
            this.dataGridViewTextBoxColumn6.HeaderText = "USERNAME";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 90;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn7.HeaderText = "PASSWORD";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 110;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Role";
            this.dataGridViewTextBoxColumn8.HeaderText = "ROLE";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 80;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(ToDoApp_Project.Model.User);
            // 
            // btnManageEdit
            // 
            this.btnManageEdit.BackColor = System.Drawing.Color.White;
            this.btnManageEdit.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageEdit.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnManageEdit.Location = new System.Drawing.Point(582, 573);
            this.btnManageEdit.Name = "btnManageEdit";
            this.btnManageEdit.Size = new System.Drawing.Size(110, 48);
            this.btnManageEdit.TabIndex = 1;
            this.btnManageEdit.Text = "EDIT";
            this.btnManageEdit.UseVisualStyleBackColor = false;
            this.btnManageEdit.Click += new System.EventHandler(this.btnManageEdit_Click);
            // 
            // btnManageCreate
            // 
            this.btnManageCreate.BackColor = System.Drawing.Color.White;
            this.btnManageCreate.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageCreate.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnManageCreate.Location = new System.Drawing.Point(582, 126);
            this.btnManageCreate.Name = "btnManageCreate";
            this.btnManageCreate.Size = new System.Drawing.Size(110, 48);
            this.btnManageCreate.TabIndex = 2;
            this.btnManageCreate.Text = "CREATE";
            this.btnManageCreate.UseVisualStyleBackColor = false;
            this.btnManageCreate.Click += new System.EventHandler(this.btnManageCreate_Click);
            // 
            // btnManageDelete
            // 
            this.btnManageDelete.BackColor = System.Drawing.Color.White;
            this.btnManageDelete.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageDelete.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnManageDelete.Location = new System.Drawing.Point(582, 247);
            this.btnManageDelete.Name = "btnManageDelete";
            this.btnManageDelete.Size = new System.Drawing.Size(110, 48);
            this.btnManageDelete.TabIndex = 3;
            this.btnManageDelete.Text = "DELETE";
            this.btnManageDelete.UseVisualStyleBackColor = false;
            this.btnManageDelete.Click += new System.EventHandler(this.btnManageDelete_Click);
            // 
            // txtManageCreateId
            // 
            this.txtManageCreateId.Location = new System.Drawing.Point(405, 67);
            this.txtManageCreateId.Name = "txtManageCreateId";
            this.txtManageCreateId.Size = new System.Drawing.Size(70, 20);
            this.txtManageCreateId.TabIndex = 4;
            // 
            // txtManageCreatePassword
            // 
            this.txtManageCreatePassword.Location = new System.Drawing.Point(627, 67);
            this.txtManageCreatePassword.Name = "txtManageCreatePassword";
            this.txtManageCreatePassword.Size = new System.Drawing.Size(140, 20);
            this.txtManageCreatePassword.TabIndex = 5;
            // 
            // txtManageCreateUsername
            // 
            this.txtManageCreateUsername.Location = new System.Drawing.Point(481, 67);
            this.txtManageCreateUsername.Name = "txtManageCreateUsername";
            this.txtManageCreateUsername.Size = new System.Drawing.Size(140, 20);
            this.txtManageCreateUsername.TabIndex = 6;
            // 
            // txtManageCreateRole
            // 
            this.txtManageCreateRole.Location = new System.Drawing.Point(773, 67);
            this.txtManageCreateRole.Name = "txtManageCreateRole";
            this.txtManageCreateRole.Size = new System.Drawing.Size(81, 20);
            this.txtManageCreateRole.TabIndex = 7;
            // 
            // lblManageUsersDelete
            // 
            this.lblManageUsersDelete.BackColor = System.Drawing.Color.Transparent;
            this.lblManageUsersDelete.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageUsersDelete.ForeColor = System.Drawing.Color.White;
            this.lblManageUsersDelete.Location = new System.Drawing.Point(354, 199);
            this.lblManageUsersDelete.Name = "lblManageUsersDelete";
            this.lblManageUsersDelete.Size = new System.Drawing.Size(565, 45);
            this.lblManageUsersDelete.TabIndex = 8;
            this.lblManageUsersDelete.Text = "SELECT USER FROM THE GRID AND CLICK DELETE TO DELETE THE IT FROM THE DATABASE";
            this.lblManageUsersDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblManageUsersCreate
            // 
            this.lblManageUsersCreate.BackColor = System.Drawing.Color.Transparent;
            this.lblManageUsersCreate.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageUsersCreate.ForeColor = System.Drawing.Color.White;
            this.lblManageUsersCreate.Location = new System.Drawing.Point(351, 12);
            this.lblManageUsersCreate.Name = "lblManageUsersCreate";
            this.lblManageUsersCreate.Size = new System.Drawing.Size(568, 42);
            this.lblManageUsersCreate.TabIndex = 9;
            this.lblManageUsersCreate.Text = "TO CREATE A ACCOUNT FILL THE BOXES BELOW TO PROVIDE ENOUGH INFO";
            this.lblManageUsersCreate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblManageUsersEdit
            // 
            this.lblManageUsersEdit.BackColor = System.Drawing.Color.Transparent;
            this.lblManageUsersEdit.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageUsersEdit.ForeColor = System.Drawing.Color.White;
            this.lblManageUsersEdit.Location = new System.Drawing.Point(343, 441);
            this.lblManageUsersEdit.Name = "lblManageUsersEdit";
            this.lblManageUsersEdit.Size = new System.Drawing.Size(576, 47);
            this.lblManageUsersEdit.TabIndex = 10;
            this.lblManageUsersEdit.Text = "TO EDIT ACCOUNT SELECT IT FROM THE GRID AND PROVIDE INFORMATION IN THE BOXES BELO" +
    "W";
            this.lblManageUsersEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.White;
            this.btnGoBack.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoBack.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnGoBack.Location = new System.Drawing.Point(804, 614);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(110, 48);
            this.btnGoBack.TabIndex = 11;
            this.btnGoBack.Text = "GO BACK";
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // lblManageUsersHeader
            // 
            this.lblManageUsersHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblManageUsersHeader.Font = new System.Drawing.Font("Franklin Gothic Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageUsersHeader.ForeColor = System.Drawing.Color.White;
            this.lblManageUsersHeader.Location = new System.Drawing.Point(12, 9);
            this.lblManageUsersHeader.Name = "lblManageUsersHeader";
            this.lblManageUsersHeader.Size = new System.Drawing.Size(323, 33);
            this.lblManageUsersHeader.TabIndex = 12;
            this.lblManageUsersHeader.Text = "ALL USERS";
            this.lblManageUsersHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblManageCreateId
            // 
            this.lblManageCreateId.BackColor = System.Drawing.Color.Transparent;
            this.lblManageCreateId.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageCreateId.ForeColor = System.Drawing.Color.White;
            this.lblManageCreateId.Location = new System.Drawing.Point(402, 100);
            this.lblManageCreateId.Name = "lblManageCreateId";
            this.lblManageCreateId.Size = new System.Drawing.Size(73, 23);
            this.lblManageCreateId.TabIndex = 13;
            this.lblManageCreateId.Text = "ID";
            this.lblManageCreateId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblManageCreateUsername
            // 
            this.lblManageCreateUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblManageCreateUsername.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageCreateUsername.ForeColor = System.Drawing.Color.White;
            this.lblManageCreateUsername.Location = new System.Drawing.Point(481, 100);
            this.lblManageCreateUsername.Name = "lblManageCreateUsername";
            this.lblManageCreateUsername.Size = new System.Drawing.Size(137, 23);
            this.lblManageCreateUsername.TabIndex = 14;
            this.lblManageCreateUsername.Text = "USERNAME";
            this.lblManageCreateUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblManageCreatePassword
            // 
            this.lblManageCreatePassword.BackColor = System.Drawing.Color.Transparent;
            this.lblManageCreatePassword.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageCreatePassword.ForeColor = System.Drawing.Color.White;
            this.lblManageCreatePassword.Location = new System.Drawing.Point(624, 100);
            this.lblManageCreatePassword.Name = "lblManageCreatePassword";
            this.lblManageCreatePassword.Size = new System.Drawing.Size(143, 23);
            this.lblManageCreatePassword.TabIndex = 15;
            this.lblManageCreatePassword.Text = "PASSWORD";
            this.lblManageCreatePassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblManageCreateRole
            // 
            this.lblManageCreateRole.BackColor = System.Drawing.Color.Transparent;
            this.lblManageCreateRole.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageCreateRole.ForeColor = System.Drawing.Color.White;
            this.lblManageCreateRole.Location = new System.Drawing.Point(773, 100);
            this.lblManageCreateRole.Name = "lblManageCreateRole";
            this.lblManageCreateRole.Size = new System.Drawing.Size(80, 23);
            this.lblManageCreateRole.TabIndex = 16;
            this.lblManageCreateRole.Text = "ROLE";
            this.lblManageCreateRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblManageEditRole
            // 
            this.lblManageEditRole.BackColor = System.Drawing.Color.Transparent;
            this.lblManageEditRole.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageEditRole.ForeColor = System.Drawing.Color.White;
            this.lblManageEditRole.Location = new System.Drawing.Point(751, 534);
            this.lblManageEditRole.Name = "lblManageEditRole";
            this.lblManageEditRole.Size = new System.Drawing.Size(80, 23);
            this.lblManageEditRole.TabIndex = 24;
            this.lblManageEditRole.Text = "ROLE";
            this.lblManageEditRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblManageEditPassword
            // 
            this.lblManageEditPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblManageEditPassword.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageEditPassword.ForeColor = System.Drawing.Color.White;
            this.lblManageEditPassword.Location = new System.Drawing.Point(602, 534);
            this.lblManageEditPassword.Name = "lblManageEditPassword";
            this.lblManageEditPassword.Size = new System.Drawing.Size(143, 23);
            this.lblManageEditPassword.TabIndex = 23;
            this.lblManageEditPassword.Text = "PASSWORD";
            this.lblManageEditPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblManageEditUsername
            // 
            this.lblManageEditUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblManageEditUsername.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageEditUsername.ForeColor = System.Drawing.Color.White;
            this.lblManageEditUsername.Location = new System.Drawing.Point(459, 534);
            this.lblManageEditUsername.Name = "lblManageEditUsername";
            this.lblManageEditUsername.Size = new System.Drawing.Size(137, 23);
            this.lblManageEditUsername.TabIndex = 22;
            this.lblManageEditUsername.Text = "USERNAME";
            this.lblManageEditUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtManageEditRole
            // 
            this.txtManageEditRole.Location = new System.Drawing.Point(751, 501);
            this.txtManageEditRole.Name = "txtManageEditRole";
            this.txtManageEditRole.Size = new System.Drawing.Size(80, 20);
            this.txtManageEditRole.TabIndex = 20;
            // 
            // txtManageEditUsername
            // 
            this.txtManageEditUsername.Location = new System.Drawing.Point(459, 501);
            this.txtManageEditUsername.Name = "txtManageEditUsername";
            this.txtManageEditUsername.Size = new System.Drawing.Size(140, 20);
            this.txtManageEditUsername.TabIndex = 19;
            // 
            // txtManageEditPassword
            // 
            this.txtManageEditPassword.Location = new System.Drawing.Point(605, 501);
            this.txtManageEditPassword.Name = "txtManageEditPassword";
            this.txtManageEditPassword.Size = new System.Drawing.Size(140, 20);
            this.txtManageEditPassword.TabIndex = 18;
            // 
            // txtManageDeleteById
            // 
            this.txtManageDeleteById.Location = new System.Drawing.Point(605, 339);
            this.txtManageDeleteById.Name = "txtManageDeleteById";
            this.txtManageDeleteById.Size = new System.Drawing.Size(60, 20);
            this.txtManageDeleteById.TabIndex = 25;
            this.txtManageDeleteById.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblManageUsersDeleteById
            // 
            this.lblManageUsersDeleteById.BackColor = System.Drawing.Color.Transparent;
            this.lblManageUsersDeleteById.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageUsersDeleteById.ForeColor = System.Drawing.Color.White;
            this.lblManageUsersDeleteById.Location = new System.Drawing.Point(343, 308);
            this.lblManageUsersDeleteById.Name = "lblManageUsersDeleteById";
            this.lblManageUsersDeleteById.Size = new System.Drawing.Size(576, 28);
            this.lblManageUsersDeleteById.TabIndex = 28;
            this.lblManageUsersDeleteById.Text = "PROVIDE AN ID IN THE BOX BELOW";
            this.lblManageUsersDeleteById.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnManageDeleteById
            // 
            this.btnManageDeleteById.BackColor = System.Drawing.Color.White;
            this.btnManageDeleteById.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageDeleteById.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnManageDeleteById.Location = new System.Drawing.Point(582, 375);
            this.btnManageDeleteById.Name = "btnManageDeleteById";
            this.btnManageDeleteById.Size = new System.Drawing.Size(110, 48);
            this.btnManageDeleteById.TabIndex = 27;
            this.btnManageDeleteById.Text = "DELETE BY ID";
            this.btnManageDeleteById.UseVisualStyleBackColor = false;
            this.btnManageDeleteById.Click += new System.EventHandler(this.btnManageDeleteById_Click);
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(926, 671);
            this.Controls.Add(this.lblManageUsersDeleteById);
            this.Controls.Add(this.btnManageDeleteById);
            this.Controls.Add(this.txtManageDeleteById);
            this.Controls.Add(this.lblManageEditRole);
            this.Controls.Add(this.lblManageEditPassword);
            this.Controls.Add(this.lblManageEditUsername);
            this.Controls.Add(this.txtManageEditRole);
            this.Controls.Add(this.txtManageEditUsername);
            this.Controls.Add(this.txtManageEditPassword);
            this.Controls.Add(this.lblManageCreateRole);
            this.Controls.Add(this.lblManageCreatePassword);
            this.Controls.Add(this.lblManageCreateUsername);
            this.Controls.Add(this.lblManageCreateId);
            this.Controls.Add(this.lblManageUsersHeader);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.lblManageUsersEdit);
            this.Controls.Add(this.lblManageUsersCreate);
            this.Controls.Add(this.lblManageUsersDelete);
            this.Controls.Add(this.txtManageCreateRole);
            this.Controls.Add(this.txtManageCreateUsername);
            this.Controls.Add(this.txtManageCreatePassword);
            this.Controls.Add(this.txtManageCreateId);
            this.Controls.Add(this.btnManageDelete);
            this.Controls.Add(this.btnManageCreate);
            this.Controls.Add(this.btnManageEdit);
            this.Controls.Add(this.dgvManageUsers);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageUsers";
            this.Text = "ToDo App - Manage Users";
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvManageUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnManageEdit;
        private System.Windows.Forms.Button btnManageCreate;
        private System.Windows.Forms.Button btnManageDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox txtManageCreateId;
        private System.Windows.Forms.TextBox txtManageCreatePassword;
        private System.Windows.Forms.TextBox txtManageCreateUsername;
        private System.Windows.Forms.TextBox txtManageCreateRole;
        private System.Windows.Forms.Label lblManageUsersDelete;
        private System.Windows.Forms.Label lblManageUsersCreate;
        private System.Windows.Forms.Label lblManageUsersEdit;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Label lblManageUsersHeader;
        private System.Windows.Forms.Label lblManageCreateId;
        private System.Windows.Forms.Label lblManageCreateUsername;
        private System.Windows.Forms.Label lblManageCreatePassword;
        private System.Windows.Forms.Label lblManageCreateRole;
        private System.Windows.Forms.Label lblManageEditRole;
        private System.Windows.Forms.Label lblManageEditPassword;
        private System.Windows.Forms.Label lblManageEditUsername;
        private System.Windows.Forms.TextBox txtManageEditRole;
        private System.Windows.Forms.TextBox txtManageEditUsername;
        private System.Windows.Forms.TextBox txtManageEditPassword;
        private System.Windows.Forms.TextBox txtManageDeleteById;
        private System.Windows.Forms.Label lblManageUsersDeleteById;
        private System.Windows.Forms.Button btnManageDeleteById;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}