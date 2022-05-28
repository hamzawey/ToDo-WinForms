namespace ToDoApp_Project.View
{
    partial class ManageToDos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageToDos));
            this.dgvManageToDos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toDoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnGoBack = new System.Windows.Forms.Button();
            this.btnDeleteByIdToDo = new System.Windows.Forms.Button();
            this.lblDeleteByIdToDo = new System.Windows.Forms.Label();
            this.lblCreateToDo = new System.Windows.Forms.Label();
            this.btnCreateToDo = new System.Windows.Forms.Button();
            this.lblEditToDo = new System.Windows.Forms.Label();
            this.btnUpdateToDo = new System.Windows.Forms.Button();
            this.txtCreateToDoId = new System.Windows.Forms.TextBox();
            this.lblCreateToDoId = new System.Windows.Forms.Label();
            this.lblCreateToDoTitle = new System.Windows.Forms.Label();
            this.txtCreateToDoTitle = new System.Windows.Forms.TextBox();
            this.txtDeleteToDoById = new System.Windows.Forms.TextBox();
            this.lblEditToDoTitle = new System.Windows.Forms.Label();
            this.txtEditToDoTitle = new System.Windows.Forms.TextBox();
            this.lblEditToDoId = new System.Windows.Forms.Label();
            this.txtEditToDoId = new System.Windows.Forms.TextBox();
            this.btnFindToDoTasks = new System.Windows.Forms.Button();
            this.lblFindToDoTasks = new System.Windows.Forms.Label();
            this.lblShareSelectUser = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnShareToDo = new System.Windows.Forms.Button();
            this.comboShareUser = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageToDos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvManageToDos
            // 
            this.dgvManageToDos.AllowUserToAddRows = false;
            this.dgvManageToDos.AllowUserToDeleteRows = false;
            this.dgvManageToDos.AllowUserToResizeColumns = false;
            this.dgvManageToDos.AllowUserToResizeRows = false;
            this.dgvManageToDos.AutoGenerateColumns = false;
            this.dgvManageToDos.BackgroundColor = System.Drawing.Color.Maroon;
            this.dgvManageToDos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManageToDos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvManageToDos.DataSource = this.toDoBindingSource;
            this.dgvManageToDos.GridColor = System.Drawing.Color.Maroon;
            this.dgvManageToDos.Location = new System.Drawing.Point(12, 12);
            this.dgvManageToDos.Name = "dgvManageToDos";
            this.dgvManageToDos.ReadOnly = true;
            this.dgvManageToDos.RowHeadersVisible = false;
            this.dgvManageToDos.Size = new System.Drawing.Size(544, 937);
            this.dgvManageToDos.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn2.HeaderText = "TITLE";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 110;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CreatedAt";
            this.dataGridViewTextBoxColumn3.HeaderText = "CREATED AT";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 110;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CreatorId";
            this.dataGridViewTextBoxColumn4.HeaderText = "CREATOR ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "LastChanged";
            this.dataGridViewTextBoxColumn5.HeaderText = "LAST CHANGED";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 110;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "LastChangedUserId";
            this.dataGridViewTextBoxColumn6.HeaderText = "LAST CHANGER ID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 80;
            // 
            // toDoBindingSource
            // 
            this.toDoBindingSource.DataSource = typeof(ToDoApp_Project.Model.ToDo);
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.White;
            this.btnGoBack.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoBack.ForeColor = System.Drawing.Color.Firebrick;
            this.btnGoBack.Location = new System.Drawing.Point(1227, 894);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(130, 55);
            this.btnGoBack.TabIndex = 12;
            this.btnGoBack.Text = "GO BACK";
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // btnDeleteByIdToDo
            // 
            this.btnDeleteByIdToDo.BackColor = System.Drawing.Color.White;
            this.btnDeleteByIdToDo.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteByIdToDo.ForeColor = System.Drawing.Color.Firebrick;
            this.btnDeleteByIdToDo.Location = new System.Drawing.Point(890, 268);
            this.btnDeleteByIdToDo.Name = "btnDeleteByIdToDo";
            this.btnDeleteByIdToDo.Size = new System.Drawing.Size(130, 55);
            this.btnDeleteByIdToDo.TabIndex = 13;
            this.btnDeleteByIdToDo.Text = "DELETE BY ID";
            this.btnDeleteByIdToDo.UseVisualStyleBackColor = false;
            this.btnDeleteByIdToDo.Click += new System.EventHandler(this.btnDeleteByIdToDo_Click);
            // 
            // lblDeleteByIdToDo
            // 
            this.lblDeleteByIdToDo.BackColor = System.Drawing.Color.Transparent;
            this.lblDeleteByIdToDo.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteByIdToDo.ForeColor = System.Drawing.Color.White;
            this.lblDeleteByIdToDo.Location = new System.Drawing.Point(570, 204);
            this.lblDeleteByIdToDo.Name = "lblDeleteByIdToDo";
            this.lblDeleteByIdToDo.Size = new System.Drawing.Size(785, 27);
            this.lblDeleteByIdToDo.TabIndex = 14;
            this.lblDeleteByIdToDo.Text = "To delete a ToDo, please provide Id and click DELETE BY ID";
            this.lblDeleteByIdToDo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCreateToDo
            // 
            this.lblCreateToDo.BackColor = System.Drawing.Color.Transparent;
            this.lblCreateToDo.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateToDo.ForeColor = System.Drawing.Color.White;
            this.lblCreateToDo.Location = new System.Drawing.Point(580, 12);
            this.lblCreateToDo.Name = "lblCreateToDo";
            this.lblCreateToDo.Size = new System.Drawing.Size(775, 27);
            this.lblCreateToDo.TabIndex = 16;
            this.lblCreateToDo.Text = "To create a ToDo, please provide Id and Title";
            this.lblCreateToDo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCreateToDo
            // 
            this.btnCreateToDo.BackColor = System.Drawing.Color.White;
            this.btnCreateToDo.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateToDo.ForeColor = System.Drawing.Color.Firebrick;
            this.btnCreateToDo.Location = new System.Drawing.Point(890, 124);
            this.btnCreateToDo.Name = "btnCreateToDo";
            this.btnCreateToDo.Size = new System.Drawing.Size(130, 55);
            this.btnCreateToDo.TabIndex = 15;
            this.btnCreateToDo.Text = "CREATE";
            this.btnCreateToDo.UseVisualStyleBackColor = false;
            this.btnCreateToDo.Click += new System.EventHandler(this.btnCreateToDo_Click);
            // 
            // lblEditToDo
            // 
            this.lblEditToDo.BackColor = System.Drawing.Color.Transparent;
            this.lblEditToDo.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditToDo.ForeColor = System.Drawing.Color.White;
            this.lblEditToDo.Location = new System.Drawing.Point(575, 348);
            this.lblEditToDo.Name = "lblEditToDo";
            this.lblEditToDo.Size = new System.Drawing.Size(780, 27);
            this.lblEditToDo.TabIndex = 20;
            this.lblEditToDo.Text = "To edit a ToDo, please provide Id and Title and click UPDATE";
            this.lblEditToDo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUpdateToDo
            // 
            this.btnUpdateToDo.BackColor = System.Drawing.Color.White;
            this.btnUpdateToDo.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateToDo.ForeColor = System.Drawing.Color.Firebrick;
            this.btnUpdateToDo.Location = new System.Drawing.Point(890, 470);
            this.btnUpdateToDo.Name = "btnUpdateToDo";
            this.btnUpdateToDo.Size = new System.Drawing.Size(130, 55);
            this.btnUpdateToDo.TabIndex = 19;
            this.btnUpdateToDo.Text = "UPDATE";
            this.btnUpdateToDo.UseVisualStyleBackColor = false;
            this.btnUpdateToDo.Click += new System.EventHandler(this.btnUpdateToDo_Click);
            // 
            // txtCreateToDoId
            // 
            this.txtCreateToDoId.Location = new System.Drawing.Point(822, 88);
            this.txtCreateToDoId.Name = "txtCreateToDoId";
            this.txtCreateToDoId.Size = new System.Drawing.Size(117, 20);
            this.txtCreateToDoId.TabIndex = 21;
            this.txtCreateToDoId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCreateToDoId
            // 
            this.lblCreateToDoId.AutoSize = true;
            this.lblCreateToDoId.BackColor = System.Drawing.Color.Transparent;
            this.lblCreateToDoId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateToDoId.ForeColor = System.Drawing.Color.White;
            this.lblCreateToDoId.Location = new System.Drawing.Point(864, 53);
            this.lblCreateToDoId.Name = "lblCreateToDoId";
            this.lblCreateToDoId.Size = new System.Drawing.Size(29, 24);
            this.lblCreateToDoId.TabIndex = 23;
            this.lblCreateToDoId.Text = "ID";
            // 
            // lblCreateToDoTitle
            // 
            this.lblCreateToDoTitle.AutoSize = true;
            this.lblCreateToDoTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblCreateToDoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateToDoTitle.ForeColor = System.Drawing.Color.White;
            this.lblCreateToDoTitle.Location = new System.Drawing.Point(991, 53);
            this.lblCreateToDoTitle.Name = "lblCreateToDoTitle";
            this.lblCreateToDoTitle.Size = new System.Drawing.Size(66, 24);
            this.lblCreateToDoTitle.TabIndex = 25;
            this.lblCreateToDoTitle.Text = "TITLE";
            // 
            // txtCreateToDoTitle
            // 
            this.txtCreateToDoTitle.Location = new System.Drawing.Point(967, 88);
            this.txtCreateToDoTitle.Name = "txtCreateToDoTitle";
            this.txtCreateToDoTitle.Size = new System.Drawing.Size(117, 20);
            this.txtCreateToDoTitle.TabIndex = 24;
            this.txtCreateToDoTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDeleteToDoById
            // 
            this.txtDeleteToDoById.Location = new System.Drawing.Point(916, 242);
            this.txtDeleteToDoById.Name = "txtDeleteToDoById";
            this.txtDeleteToDoById.Size = new System.Drawing.Size(77, 20);
            this.txtDeleteToDoById.TabIndex = 26;
            this.txtDeleteToDoById.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEditToDoTitle
            // 
            this.lblEditToDoTitle.AutoSize = true;
            this.lblEditToDoTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblEditToDoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditToDoTitle.ForeColor = System.Drawing.Color.White;
            this.lblEditToDoTitle.Location = new System.Drawing.Point(991, 394);
            this.lblEditToDoTitle.Name = "lblEditToDoTitle";
            this.lblEditToDoTitle.Size = new System.Drawing.Size(66, 24);
            this.lblEditToDoTitle.TabIndex = 30;
            this.lblEditToDoTitle.Text = "TITLE";
            // 
            // txtEditToDoTitle
            // 
            this.txtEditToDoTitle.Location = new System.Drawing.Point(967, 429);
            this.txtEditToDoTitle.Name = "txtEditToDoTitle";
            this.txtEditToDoTitle.Size = new System.Drawing.Size(117, 20);
            this.txtEditToDoTitle.TabIndex = 29;
            this.txtEditToDoTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEditToDoId
            // 
            this.lblEditToDoId.AutoSize = true;
            this.lblEditToDoId.BackColor = System.Drawing.Color.Transparent;
            this.lblEditToDoId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditToDoId.ForeColor = System.Drawing.Color.White;
            this.lblEditToDoId.Location = new System.Drawing.Point(864, 394);
            this.lblEditToDoId.Name = "lblEditToDoId";
            this.lblEditToDoId.Size = new System.Drawing.Size(29, 24);
            this.lblEditToDoId.TabIndex = 28;
            this.lblEditToDoId.Text = "ID";
            // 
            // txtEditToDoId
            // 
            this.txtEditToDoId.Location = new System.Drawing.Point(822, 429);
            this.txtEditToDoId.Name = "txtEditToDoId";
            this.txtEditToDoId.Size = new System.Drawing.Size(117, 20);
            this.txtEditToDoId.TabIndex = 27;
            this.txtEditToDoId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnFindToDoTasks
            // 
            this.btnFindToDoTasks.BackColor = System.Drawing.Color.White;
            this.btnFindToDoTasks.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindToDoTasks.ForeColor = System.Drawing.Color.Firebrick;
            this.btnFindToDoTasks.Location = new System.Drawing.Point(892, 606);
            this.btnFindToDoTasks.Name = "btnFindToDoTasks";
            this.btnFindToDoTasks.Size = new System.Drawing.Size(130, 55);
            this.btnFindToDoTasks.TabIndex = 31;
            this.btnFindToDoTasks.Text = "TASKS";
            this.btnFindToDoTasks.UseVisualStyleBackColor = false;
            this.btnFindToDoTasks.Click += new System.EventHandler(this.btnFindToDoTasks_Click);
            // 
            // lblFindToDoTasks
            // 
            this.lblFindToDoTasks.BackColor = System.Drawing.Color.Transparent;
            this.lblFindToDoTasks.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFindToDoTasks.ForeColor = System.Drawing.Color.White;
            this.lblFindToDoTasks.Location = new System.Drawing.Point(577, 551);
            this.lblFindToDoTasks.Name = "lblFindToDoTasks";
            this.lblFindToDoTasks.Size = new System.Drawing.Size(780, 39);
            this.lblFindToDoTasks.TabIndex = 32;
            this.lblFindToDoTasks.Text = "Select a ToDo from the table and click TASKS to find if it has tasks";
            this.lblFindToDoTasks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblShareSelectUser
            // 
            this.lblShareSelectUser.AutoSize = true;
            this.lblShareSelectUser.BackColor = System.Drawing.Color.Transparent;
            this.lblShareSelectUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShareSelectUser.ForeColor = System.Drawing.Color.White;
            this.lblShareSelectUser.Location = new System.Drawing.Point(886, 743);
            this.lblShareSelectUser.Name = "lblShareSelectUser";
            this.lblShareSelectUser.Size = new System.Drawing.Size(150, 24);
            this.lblShareSelectUser.TabIndex = 38;
            this.lblShareSelectUser.Text = "SELECT USER";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(575, 696);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(780, 27);
            this.label3.TabIndex = 34;
            this.label3.Text = "To Share a ToDo select it from the table and click Share";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShareToDo
            // 
            this.btnShareToDo.BackColor = System.Drawing.Color.White;
            this.btnShareToDo.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShareToDo.ForeColor = System.Drawing.Color.Firebrick;
            this.btnShareToDo.Location = new System.Drawing.Point(890, 829);
            this.btnShareToDo.Name = "btnShareToDo";
            this.btnShareToDo.Size = new System.Drawing.Size(130, 55);
            this.btnShareToDo.TabIndex = 33;
            this.btnShareToDo.Text = "SHARE";
            this.btnShareToDo.UseVisualStyleBackColor = false;
            this.btnShareToDo.Click += new System.EventHandler(this.btnShareToDo_Click);
            // 
            // comboShareUser
            // 
            this.comboShareUser.FormattingEnabled = true;
            this.comboShareUser.Location = new System.Drawing.Point(890, 783);
            this.comboShareUser.Name = "comboShareUser";
            this.comboShareUser.Size = new System.Drawing.Size(130, 21);
            this.comboShareUser.TabIndex = 39;
            // 
            // ManageToDos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::ToDoApp_Project.Properties.Resources.img6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1368, 961);
            this.Controls.Add(this.comboShareUser);
            this.Controls.Add(this.lblShareSelectUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnShareToDo);
            this.Controls.Add(this.lblFindToDoTasks);
            this.Controls.Add(this.btnFindToDoTasks);
            this.Controls.Add(this.lblEditToDoTitle);
            this.Controls.Add(this.txtEditToDoTitle);
            this.Controls.Add(this.lblEditToDoId);
            this.Controls.Add(this.txtEditToDoId);
            this.Controls.Add(this.txtDeleteToDoById);
            this.Controls.Add(this.lblCreateToDoTitle);
            this.Controls.Add(this.txtCreateToDoTitle);
            this.Controls.Add(this.lblCreateToDoId);
            this.Controls.Add(this.txtCreateToDoId);
            this.Controls.Add(this.lblEditToDo);
            this.Controls.Add(this.btnUpdateToDo);
            this.Controls.Add(this.lblCreateToDo);
            this.Controls.Add(this.btnCreateToDo);
            this.Controls.Add(this.lblDeleteByIdToDo);
            this.Controls.Add(this.btnDeleteByIdToDo);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.dgvManageToDos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageToDos";
            this.Text = "ToDo App - Manage ToDos";
            this.Load += new System.EventHandler(this.ManageToDos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageToDos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvManageToDos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creatorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastChangedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastChangedUserIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Button btnDeleteByIdToDo;
        private System.Windows.Forms.Label lblDeleteByIdToDo;
        private System.Windows.Forms.Label lblCreateToDo;
        private System.Windows.Forms.Button btnCreateToDo;
        private System.Windows.Forms.Label lblEditToDo;
        private System.Windows.Forms.Button btnUpdateToDo;
        private System.Windows.Forms.TextBox txtCreateToDoId;
        private System.Windows.Forms.Label lblCreateToDoId;
        private System.Windows.Forms.Label lblCreateToDoTitle;
        private System.Windows.Forms.TextBox txtCreateToDoTitle;
        private System.Windows.Forms.TextBox txtDeleteToDoById;
        private System.Windows.Forms.BindingSource toDoBindingSource;
        private System.Windows.Forms.Label lblEditToDoTitle;
        private System.Windows.Forms.TextBox txtEditToDoTitle;
        private System.Windows.Forms.Label lblEditToDoId;
        private System.Windows.Forms.TextBox txtEditToDoId;
        private System.Windows.Forms.Button btnFindToDoTasks;
        private System.Windows.Forms.Label lblFindToDoTasks;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label lblShareSelectUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnShareToDo;
        private System.Windows.Forms.ComboBox comboShareUser;
    }
}