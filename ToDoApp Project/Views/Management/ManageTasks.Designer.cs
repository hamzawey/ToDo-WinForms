namespace ToDoApp_Project.View
{
    partial class ManageTasks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageTasks));
            this.dgvTasks = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isCompleteDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dateCreatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creatorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastChangedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastChangeUserIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnGoBack = new System.Windows.Forms.Button();
            this.lblToDoNameForTasks = new System.Windows.Forms.Label();
            this.lblCompleteTask = new System.Windows.Forms.Label();
            this.btnToggleComplete = new System.Windows.Forms.Button();
            this.btnDeleteByIdTask = new System.Windows.Forms.Button();
            this.lblTaskDeleteById = new System.Windows.Forms.Label();
            this.txtTaskDeleteById = new System.Windows.Forms.TextBox();
            this.lblCreateTitle = new System.Windows.Forms.Label();
            this.txtCreateTaskTitle = new System.Windows.Forms.TextBox();
            this.lblCreateId = new System.Windows.Forms.Label();
            this.txtCreateTaskId = new System.Windows.Forms.TextBox();
            this.lblCreateTask = new System.Windows.Forms.Label();
            this.btnCreateTask = new System.Windows.Forms.Button();
            this.lblCreateToDoId = new System.Windows.Forms.Label();
            this.txtCreateTaskToDoId = new System.Windows.Forms.TextBox();
            this.lblCreateDescription = new System.Windows.Forms.Label();
            this.txtCreateTaskDescription = new System.Windows.Forms.TextBox();
            this.lblEditTaskIsComplete = new System.Windows.Forms.Label();
            this.txtEditTaskIsComplete = new System.Windows.Forms.TextBox();
            this.lblEditTaskDescription = new System.Windows.Forms.Label();
            this.txtEditTaskDescription = new System.Windows.Forms.TextBox();
            this.lblEditTaskTitle = new System.Windows.Forms.Label();
            this.txtEditTaskTitle = new System.Windows.Forms.TextBox();
            this.lblEditTaskId = new System.Windows.Forms.Label();
            this.txtEditTaskId = new System.Windows.Forms.TextBox();
            this.lblUpdateTask = new System.Windows.Forms.Label();
            this.btnUpdateTask = new System.Windows.Forms.Button();
            this.lblTrueFalseText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTasks
            // 
            this.dgvTasks.AllowUserToAddRows = false;
            this.dgvTasks.AllowUserToDeleteRows = false;
            this.dgvTasks.AllowUserToResizeColumns = false;
            this.dgvTasks.AllowUserToResizeRows = false;
            this.dgvTasks.AutoGenerateColumns = false;
            this.dgvTasks.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.dgvTasks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.isCompleteDataGridViewCheckBoxColumn,
            this.dateCreatedDataGridViewTextBoxColumn,
            this.creatorIdDataGridViewTextBoxColumn,
            this.lastChangedDataGridViewTextBoxColumn,
            this.lastChangeUserIdDataGridViewTextBoxColumn});
            this.dgvTasks.DataSource = this.taskBindingSource;
            this.dgvTasks.GridColor = System.Drawing.Color.RoyalBlue;
            this.dgvTasks.Location = new System.Drawing.Point(12, 53);
            this.dgvTasks.Name = "dgvTasks";
            this.dgvTasks.ReadOnly = true;
            this.dgvTasks.RowHeadersVisible = false;
            this.dgvTasks.Size = new System.Drawing.Size(682, 575);
            this.dgvTasks.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 30;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "TITLE";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "DESCRIPTION";
            this.descriptionDataGridViewTextBoxColumn.MaxInputLength = 32;
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 4;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 150;
            // 
            // isCompleteDataGridViewCheckBoxColumn
            // 
            this.isCompleteDataGridViewCheckBoxColumn.DataPropertyName = "IsComplete";
            this.isCompleteDataGridViewCheckBoxColumn.HeaderText = "IS COMPLETE";
            this.isCompleteDataGridViewCheckBoxColumn.Name = "isCompleteDataGridViewCheckBoxColumn";
            this.isCompleteDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isCompleteDataGridViewCheckBoxColumn.Width = 70;
            // 
            // dateCreatedDataGridViewTextBoxColumn
            // 
            this.dateCreatedDataGridViewTextBoxColumn.DataPropertyName = "DateCreated";
            this.dateCreatedDataGridViewTextBoxColumn.HeaderText = "CREATED AT";
            this.dateCreatedDataGridViewTextBoxColumn.Name = "dateCreatedDataGridViewTextBoxColumn";
            this.dateCreatedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // creatorIdDataGridViewTextBoxColumn
            // 
            this.creatorIdDataGridViewTextBoxColumn.DataPropertyName = "CreatorId";
            this.creatorIdDataGridViewTextBoxColumn.HeaderText = "CREATOR ID";
            this.creatorIdDataGridViewTextBoxColumn.Name = "creatorIdDataGridViewTextBoxColumn";
            this.creatorIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.creatorIdDataGridViewTextBoxColumn.Width = 70;
            // 
            // lastChangedDataGridViewTextBoxColumn
            // 
            this.lastChangedDataGridViewTextBoxColumn.DataPropertyName = "LastChanged";
            this.lastChangedDataGridViewTextBoxColumn.HeaderText = "LAST CHANGED";
            this.lastChangedDataGridViewTextBoxColumn.Name = "lastChangedDataGridViewTextBoxColumn";
            this.lastChangedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastChangeUserIdDataGridViewTextBoxColumn
            // 
            this.lastChangeUserIdDataGridViewTextBoxColumn.DataPropertyName = "LastChangeUserId";
            this.lastChangeUserIdDataGridViewTextBoxColumn.HeaderText = "LAST CHANGE ID";
            this.lastChangeUserIdDataGridViewTextBoxColumn.Name = "lastChangeUserIdDataGridViewTextBoxColumn";
            this.lastChangeUserIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastChangeUserIdDataGridViewTextBoxColumn.Width = 60;
            // 
            // taskBindingSource
            // 
            this.taskBindingSource.DataSource = typeof(ToDoApp_Project.Model.Task);
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.White;
            this.btnGoBack.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoBack.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnGoBack.Location = new System.Drawing.Point(1251, 583);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(110, 45);
            this.btnGoBack.TabIndex = 13;
            this.btnGoBack.Text = "GO BACK";
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // lblToDoNameForTasks
            // 
            this.lblToDoNameForTasks.BackColor = System.Drawing.Color.Transparent;
            this.lblToDoNameForTasks.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToDoNameForTasks.ForeColor = System.Drawing.Color.White;
            this.lblToDoNameForTasks.Location = new System.Drawing.Point(12, 9);
            this.lblToDoNameForTasks.Name = "lblToDoNameForTasks";
            this.lblToDoNameForTasks.Size = new System.Drawing.Size(682, 41);
            this.lblToDoNameForTasks.TabIndex = 14;
            this.lblToDoNameForTasks.Text = "Tasks:";
            this.lblToDoNameForTasks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCompleteTask
            // 
            this.lblCompleteTask.BackColor = System.Drawing.Color.Transparent;
            this.lblCompleteTask.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompleteTask.ForeColor = System.Drawing.Color.White;
            this.lblCompleteTask.Location = new System.Drawing.Point(700, 24);
            this.lblCompleteTask.Name = "lblCompleteTask";
            this.lblCompleteTask.Size = new System.Drawing.Size(631, 37);
            this.lblCompleteTask.TabIndex = 34;
            this.lblCompleteTask.Text = "To complete or remove from complete a task you have to select it from the table a" +
    "nd click the button";
            this.lblCompleteTask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnToggleComplete
            // 
            this.btnToggleComplete.BackColor = System.Drawing.Color.White;
            this.btnToggleComplete.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToggleComplete.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnToggleComplete.Location = new System.Drawing.Point(961, 64);
            this.btnToggleComplete.Name = "btnToggleComplete";
            this.btnToggleComplete.Size = new System.Drawing.Size(110, 45);
            this.btnToggleComplete.TabIndex = 33;
            this.btnToggleComplete.Text = "COMPLETE UNCOMPLETE";
            this.btnToggleComplete.UseVisualStyleBackColor = false;
            this.btnToggleComplete.Click += new System.EventHandler(this.btnToggleComplete_Click);
            // 
            // btnDeleteByIdTask
            // 
            this.btnDeleteByIdTask.BackColor = System.Drawing.Color.White;
            this.btnDeleteByIdTask.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteByIdTask.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnDeleteByIdTask.Location = new System.Drawing.Point(961, 191);
            this.btnDeleteByIdTask.Name = "btnDeleteByIdTask";
            this.btnDeleteByIdTask.Size = new System.Drawing.Size(110, 45);
            this.btnDeleteByIdTask.TabIndex = 35;
            this.btnDeleteByIdTask.Text = "DELETE BY ID";
            this.btnDeleteByIdTask.UseVisualStyleBackColor = false;
            this.btnDeleteByIdTask.Click += new System.EventHandler(this.btnDeleteByIdTask_Click);
            // 
            // lblTaskDeleteById
            // 
            this.lblTaskDeleteById.BackColor = System.Drawing.Color.Transparent;
            this.lblTaskDeleteById.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskDeleteById.ForeColor = System.Drawing.Color.White;
            this.lblTaskDeleteById.Location = new System.Drawing.Point(706, 122);
            this.lblTaskDeleteById.Name = "lblTaskDeleteById";
            this.lblTaskDeleteById.Size = new System.Drawing.Size(625, 31);
            this.lblTaskDeleteById.TabIndex = 38;
            this.lblTaskDeleteById.Text = "PROVIDE AN ID IN THE BOX BELOW";
            this.lblTaskDeleteById.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTaskDeleteById
            // 
            this.txtTaskDeleteById.Location = new System.Drawing.Point(983, 156);
            this.txtTaskDeleteById.Name = "txtTaskDeleteById";
            this.txtTaskDeleteById.Size = new System.Drawing.Size(57, 20);
            this.txtTaskDeleteById.TabIndex = 36;
            this.txtTaskDeleteById.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCreateTitle
            // 
            this.lblCreateTitle.AutoSize = true;
            this.lblCreateTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblCreateTitle.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateTitle.ForeColor = System.Drawing.Color.White;
            this.lblCreateTitle.Location = new System.Drawing.Point(863, 303);
            this.lblCreateTitle.Name = "lblCreateTitle";
            this.lblCreateTitle.Size = new System.Drawing.Size(41, 17);
            this.lblCreateTitle.TabIndex = 44;
            this.lblCreateTitle.Text = "TITLE";
            // 
            // txtCreateTaskTitle
            // 
            this.txtCreateTaskTitle.Location = new System.Drawing.Point(839, 338);
            this.txtCreateTaskTitle.Name = "txtCreateTaskTitle";
            this.txtCreateTaskTitle.Size = new System.Drawing.Size(117, 20);
            this.txtCreateTaskTitle.TabIndex = 43;
            this.txtCreateTaskTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCreateId
            // 
            this.lblCreateId.AutoSize = true;
            this.lblCreateId.BackColor = System.Drawing.Color.Transparent;
            this.lblCreateId.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateId.ForeColor = System.Drawing.Color.White;
            this.lblCreateId.Location = new System.Drawing.Point(784, 303);
            this.lblCreateId.Name = "lblCreateId";
            this.lblCreateId.Size = new System.Drawing.Size(22, 17);
            this.lblCreateId.TabIndex = 42;
            this.lblCreateId.Text = "ID";
            // 
            // txtCreateTaskId
            // 
            this.txtCreateTaskId.Location = new System.Drawing.Point(778, 338);
            this.txtCreateTaskId.Name = "txtCreateTaskId";
            this.txtCreateTaskId.Size = new System.Drawing.Size(46, 20);
            this.txtCreateTaskId.TabIndex = 41;
            this.txtCreateTaskId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCreateTask
            // 
            this.lblCreateTask.BackColor = System.Drawing.Color.Transparent;
            this.lblCreateTask.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateTask.ForeColor = System.Drawing.Color.White;
            this.lblCreateTask.Location = new System.Drawing.Point(703, 260);
            this.lblCreateTask.Name = "lblCreateTask";
            this.lblCreateTask.Size = new System.Drawing.Size(628, 27);
            this.lblCreateTask.TabIndex = 40;
            this.lblCreateTask.Text = "To create a Task please provide Id, Title, Description and ToDo Id";
            this.lblCreateTask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCreateTask
            // 
            this.btnCreateTask.BackColor = System.Drawing.Color.White;
            this.btnCreateTask.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTask.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnCreateTask.Location = new System.Drawing.Point(961, 375);
            this.btnCreateTask.Name = "btnCreateTask";
            this.btnCreateTask.Size = new System.Drawing.Size(110, 45);
            this.btnCreateTask.TabIndex = 39;
            this.btnCreateTask.Text = "CREATE";
            this.btnCreateTask.UseVisualStyleBackColor = false;
            this.btnCreateTask.Click += new System.EventHandler(this.btnCreateTask_Click);
            // 
            // lblCreateToDoId
            // 
            this.lblCreateToDoId.AutoSize = true;
            this.lblCreateToDoId.BackColor = System.Drawing.Color.Transparent;
            this.lblCreateToDoId.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateToDoId.ForeColor = System.Drawing.Color.White;
            this.lblCreateToDoId.Location = new System.Drawing.Point(1176, 303);
            this.lblCreateToDoId.Name = "lblCreateToDoId";
            this.lblCreateToDoId.Size = new System.Drawing.Size(61, 17);
            this.lblCreateToDoId.TabIndex = 48;
            this.lblCreateToDoId.Text = "TODO ID";
            // 
            // txtCreateTaskToDoId
            // 
            this.txtCreateTaskToDoId.Location = new System.Drawing.Point(1147, 338);
            this.txtCreateTaskToDoId.Name = "txtCreateTaskToDoId";
            this.txtCreateTaskToDoId.Size = new System.Drawing.Size(117, 20);
            this.txtCreateTaskToDoId.TabIndex = 47;
            this.txtCreateTaskToDoId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCreateDescription
            // 
            this.lblCreateDescription.AutoSize = true;
            this.lblCreateDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblCreateDescription.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateDescription.ForeColor = System.Drawing.Color.White;
            this.lblCreateDescription.Location = new System.Drawing.Point(980, 303);
            this.lblCreateDescription.Name = "lblCreateDescription";
            this.lblCreateDescription.Size = new System.Drawing.Size(94, 17);
            this.lblCreateDescription.TabIndex = 46;
            this.lblCreateDescription.Text = "DESCRIPTION";
            // 
            // txtCreateTaskDescription
            // 
            this.txtCreateTaskDescription.Location = new System.Drawing.Point(972, 338);
            this.txtCreateTaskDescription.Name = "txtCreateTaskDescription";
            this.txtCreateTaskDescription.Size = new System.Drawing.Size(154, 20);
            this.txtCreateTaskDescription.TabIndex = 45;
            this.txtCreateTaskDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEditTaskIsComplete
            // 
            this.lblEditTaskIsComplete.BackColor = System.Drawing.Color.Transparent;
            this.lblEditTaskIsComplete.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditTaskIsComplete.ForeColor = System.Drawing.Color.White;
            this.lblEditTaskIsComplete.Location = new System.Drawing.Point(1138, 477);
            this.lblEditTaskIsComplete.Name = "lblEditTaskIsComplete";
            this.lblEditTaskIsComplete.Size = new System.Drawing.Size(155, 24);
            this.lblEditTaskIsComplete.TabIndex = 58;
            this.lblEditTaskIsComplete.Text = "IS COMPLETE";
            this.lblEditTaskIsComplete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEditTaskIsComplete
            // 
            this.txtEditTaskIsComplete.Location = new System.Drawing.Point(1138, 512);
            this.txtEditTaskIsComplete.Name = "txtEditTaskIsComplete";
            this.txtEditTaskIsComplete.Size = new System.Drawing.Size(155, 20);
            this.txtEditTaskIsComplete.TabIndex = 57;
            this.txtEditTaskIsComplete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEditTaskDescription
            // 
            this.lblEditTaskDescription.AutoSize = true;
            this.lblEditTaskDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblEditTaskDescription.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditTaskDescription.ForeColor = System.Drawing.Color.White;
            this.lblEditTaskDescription.Location = new System.Drawing.Point(971, 477);
            this.lblEditTaskDescription.Name = "lblEditTaskDescription";
            this.lblEditTaskDescription.Size = new System.Drawing.Size(94, 17);
            this.lblEditTaskDescription.TabIndex = 56;
            this.lblEditTaskDescription.Text = "DESCRIPTION";
            // 
            // txtEditTaskDescription
            // 
            this.txtEditTaskDescription.Location = new System.Drawing.Point(963, 512);
            this.txtEditTaskDescription.Name = "txtEditTaskDescription";
            this.txtEditTaskDescription.Size = new System.Drawing.Size(154, 20);
            this.txtEditTaskDescription.TabIndex = 55;
            this.txtEditTaskDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEditTaskTitle
            // 
            this.lblEditTaskTitle.AutoSize = true;
            this.lblEditTaskTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblEditTaskTitle.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditTaskTitle.ForeColor = System.Drawing.Color.White;
            this.lblEditTaskTitle.Location = new System.Drawing.Point(854, 477);
            this.lblEditTaskTitle.Name = "lblEditTaskTitle";
            this.lblEditTaskTitle.Size = new System.Drawing.Size(41, 17);
            this.lblEditTaskTitle.TabIndex = 54;
            this.lblEditTaskTitle.Text = "TITLE";
            // 
            // txtEditTaskTitle
            // 
            this.txtEditTaskTitle.Location = new System.Drawing.Point(830, 512);
            this.txtEditTaskTitle.Name = "txtEditTaskTitle";
            this.txtEditTaskTitle.Size = new System.Drawing.Size(117, 20);
            this.txtEditTaskTitle.TabIndex = 53;
            this.txtEditTaskTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEditTaskId
            // 
            this.lblEditTaskId.AutoSize = true;
            this.lblEditTaskId.BackColor = System.Drawing.Color.Transparent;
            this.lblEditTaskId.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditTaskId.ForeColor = System.Drawing.Color.White;
            this.lblEditTaskId.Location = new System.Drawing.Point(775, 477);
            this.lblEditTaskId.Name = "lblEditTaskId";
            this.lblEditTaskId.Size = new System.Drawing.Size(22, 17);
            this.lblEditTaskId.TabIndex = 52;
            this.lblEditTaskId.Text = "ID";
            // 
            // txtEditTaskId
            // 
            this.txtEditTaskId.Location = new System.Drawing.Point(769, 512);
            this.txtEditTaskId.Name = "txtEditTaskId";
            this.txtEditTaskId.Size = new System.Drawing.Size(46, 20);
            this.txtEditTaskId.TabIndex = 51;
            this.txtEditTaskId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblUpdateTask
            // 
            this.lblUpdateTask.BackColor = System.Drawing.Color.Transparent;
            this.lblUpdateTask.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateTask.ForeColor = System.Drawing.Color.White;
            this.lblUpdateTask.Location = new System.Drawing.Point(700, 441);
            this.lblUpdateTask.Name = "lblUpdateTask";
            this.lblUpdateTask.Size = new System.Drawing.Size(631, 27);
            this.lblUpdateTask.TabIndex = 50;
            this.lblUpdateTask.Text = "To edit a Task please provide the information below";
            this.lblUpdateTask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUpdateTask
            // 
            this.btnUpdateTask.BackColor = System.Drawing.Color.White;
            this.btnUpdateTask.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTask.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdateTask.Location = new System.Drawing.Point(961, 553);
            this.btnUpdateTask.Name = "btnUpdateTask";
            this.btnUpdateTask.Size = new System.Drawing.Size(110, 45);
            this.btnUpdateTask.TabIndex = 49;
            this.btnUpdateTask.Text = "UPDATE";
            this.btnUpdateTask.UseVisualStyleBackColor = false;
            this.btnUpdateTask.Click += new System.EventHandler(this.btnUpdateTask_Click);
            // 
            // lblTrueFalseText
            // 
            this.lblTrueFalseText.BackColor = System.Drawing.Color.Transparent;
            this.lblTrueFalseText.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrueFalseText.ForeColor = System.Drawing.Color.White;
            this.lblTrueFalseText.Location = new System.Drawing.Point(1138, 535);
            this.lblTrueFalseText.Name = "lblTrueFalseText";
            this.lblTrueFalseText.Size = new System.Drawing.Size(155, 23);
            this.lblTrueFalseText.TabIndex = 59;
            this.lblTrueFalseText.Text = "(true / false)";
            this.lblTrueFalseText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ManageTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::ToDoApp_Project.Properties.Resources.img7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1373, 640);
            this.Controls.Add(this.lblTrueFalseText);
            this.Controls.Add(this.lblEditTaskIsComplete);
            this.Controls.Add(this.txtEditTaskIsComplete);
            this.Controls.Add(this.lblEditTaskDescription);
            this.Controls.Add(this.txtEditTaskDescription);
            this.Controls.Add(this.lblEditTaskTitle);
            this.Controls.Add(this.txtEditTaskTitle);
            this.Controls.Add(this.lblEditTaskId);
            this.Controls.Add(this.txtEditTaskId);
            this.Controls.Add(this.lblUpdateTask);
            this.Controls.Add(this.btnUpdateTask);
            this.Controls.Add(this.lblCreateToDoId);
            this.Controls.Add(this.txtCreateTaskToDoId);
            this.Controls.Add(this.lblCreateDescription);
            this.Controls.Add(this.txtCreateTaskDescription);
            this.Controls.Add(this.lblCreateTitle);
            this.Controls.Add(this.txtCreateTaskTitle);
            this.Controls.Add(this.lblCreateId);
            this.Controls.Add(this.txtCreateTaskId);
            this.Controls.Add(this.lblCreateTask);
            this.Controls.Add(this.btnCreateTask);
            this.Controls.Add(this.lblTaskDeleteById);
            this.Controls.Add(this.txtTaskDeleteById);
            this.Controls.Add(this.btnDeleteByIdTask);
            this.Controls.Add(this.lblCompleteTask);
            this.Controls.Add(this.btnToggleComplete);
            this.Controls.Add(this.lblToDoNameForTasks);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.dgvTasks);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageTasks";
            this.Text = "ToDoTasks";
            this.Load += new System.EventHandler(this.ToDoTasks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTasks;
        private System.Windows.Forms.BindingSource taskBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isCompleteDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creatorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastChangedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastChangeUserIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Label lblToDoNameForTasks;
        private System.Windows.Forms.Label lblCompleteTask;
        private System.Windows.Forms.Button btnToggleComplete;
        private System.Windows.Forms.Button btnDeleteByIdTask;
        private System.Windows.Forms.Label lblTaskDeleteById;
        private System.Windows.Forms.TextBox txtTaskDeleteById;
        private System.Windows.Forms.Label lblCreateTitle;
        private System.Windows.Forms.TextBox txtCreateTaskTitle;
        private System.Windows.Forms.Label lblCreateId;
        private System.Windows.Forms.TextBox txtCreateTaskId;
        private System.Windows.Forms.Label lblCreateTask;
        private System.Windows.Forms.Button btnCreateTask;
        private System.Windows.Forms.Label lblCreateToDoId;
        private System.Windows.Forms.TextBox txtCreateTaskToDoId;
        private System.Windows.Forms.Label lblCreateDescription;
        private System.Windows.Forms.TextBox txtCreateTaskDescription;
        private System.Windows.Forms.Label lblEditTaskIsComplete;
        private System.Windows.Forms.TextBox txtEditTaskIsComplete;
        private System.Windows.Forms.Label lblEditTaskDescription;
        private System.Windows.Forms.TextBox txtEditTaskDescription;
        private System.Windows.Forms.Label lblEditTaskTitle;
        private System.Windows.Forms.TextBox txtEditTaskTitle;
        private System.Windows.Forms.Label lblEditTaskId;
        private System.Windows.Forms.TextBox txtEditTaskId;
        private System.Windows.Forms.Label lblUpdateTask;
        private System.Windows.Forms.Button btnUpdateTask;
        private System.Windows.Forms.Label lblTrueFalseText;
    }
}