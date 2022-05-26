namespace ToDoApp_Project.View
{
    partial class ToDoTasks
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
            this.btnTaskDeleteById = new System.Windows.Forms.Button();
            this.lblTaskDelById = new System.Windows.Forms.Label();
            this.txtBoxDeleteById = new System.Windows.Forms.TextBox();
            this.lblCreateTitle = new System.Windows.Forms.Label();
            this.txtCreateTaskTitle = new System.Windows.Forms.TextBox();
            this.lblCreateId = new System.Windows.Forms.Label();
            this.txtCreateTaskId = new System.Windows.Forms.TextBox();
            this.lblCreateToDo = new System.Windows.Forms.Label();
            this.btnCreateNewTodo = new System.Windows.Forms.Button();
            this.lblTaskToDoId = new System.Windows.Forms.Label();
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
            this.label5 = new System.Windows.Forms.Label();
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
            this.dgvTasks.BackgroundColor = System.Drawing.Color.MediumTurquoise;
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
            this.dgvTasks.GridColor = System.Drawing.Color.OrangeRed;
            this.dgvTasks.Location = new System.Drawing.Point(12, 53);
            this.dgvTasks.Name = "dgvTasks";
            this.dgvTasks.ReadOnly = true;
            this.dgvTasks.RowHeadersVisible = false;
            this.dgvTasks.Size = new System.Drawing.Size(682, 696);
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
            this.btnGoBack.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoBack.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btnGoBack.Location = new System.Drawing.Point(1442, 694);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(130, 55);
            this.btnGoBack.TabIndex = 13;
            this.btnGoBack.Text = "GO BACK";
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // lblToDoNameForTasks
            // 
            this.lblToDoNameForTasks.BackColor = System.Drawing.Color.Transparent;
            this.lblToDoNameForTasks.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToDoNameForTasks.ForeColor = System.Drawing.Color.White;
            this.lblToDoNameForTasks.Location = new System.Drawing.Point(12, 9);
            this.lblToDoNameForTasks.Name = "lblToDoNameForTasks";
            this.lblToDoNameForTasks.Size = new System.Drawing.Size(682, 41);
            this.lblToDoNameForTasks.TabIndex = 14;
            this.lblToDoNameForTasks.Text = "onload";
            this.lblToDoNameForTasks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCompleteTask
            // 
            this.lblCompleteTask.BackColor = System.Drawing.Color.Transparent;
            this.lblCompleteTask.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompleteTask.ForeColor = System.Drawing.Color.White;
            this.lblCompleteTask.Location = new System.Drawing.Point(700, 24);
            this.lblCompleteTask.Name = "lblCompleteTask";
            this.lblCompleteTask.Size = new System.Drawing.Size(872, 68);
            this.lblCompleteTask.TabIndex = 34;
            this.lblCompleteTask.Text = "onload";
            this.lblCompleteTask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnToggleComplete
            // 
            this.btnToggleComplete.BackColor = System.Drawing.Color.White;
            this.btnToggleComplete.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToggleComplete.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnToggleComplete.Location = new System.Drawing.Point(1073, 107);
            this.btnToggleComplete.Name = "btnToggleComplete";
            this.btnToggleComplete.Size = new System.Drawing.Size(130, 59);
            this.btnToggleComplete.TabIndex = 33;
            this.btnToggleComplete.Text = "COMPLETE UNCOMPLETE";
            this.btnToggleComplete.UseVisualStyleBackColor = false;
            this.btnToggleComplete.Click += new System.EventHandler(this.btnToggleComplete_Click);
            // 
            // btnTaskDeleteById
            // 
            this.btnTaskDeleteById.BackColor = System.Drawing.Color.White;
            this.btnTaskDeleteById.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaskDeleteById.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnTaskDeleteById.Location = new System.Drawing.Point(1073, 261);
            this.btnTaskDeleteById.Name = "btnTaskDeleteById";
            this.btnTaskDeleteById.Size = new System.Drawing.Size(130, 59);
            this.btnTaskDeleteById.TabIndex = 35;
            this.btnTaskDeleteById.Text = "DELETE BY ID";
            this.btnTaskDeleteById.UseVisualStyleBackColor = false;
            this.btnTaskDeleteById.Click += new System.EventHandler(this.btnTaskDeleteById_Click);
            // 
            // lblTaskDelById
            // 
            this.lblTaskDelById.BackColor = System.Drawing.Color.Transparent;
            this.lblTaskDelById.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskDelById.ForeColor = System.Drawing.Color.Black;
            this.lblTaskDelById.Location = new System.Drawing.Point(706, 190);
            this.lblTaskDelById.Name = "lblTaskDelById";
            this.lblTaskDelById.Size = new System.Drawing.Size(866, 31);
            this.lblTaskDelById.TabIndex = 38;
            this.lblTaskDelById.Text = "PROVIDE AN ID IN THE BOX BELOW";
            this.lblTaskDelById.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxDeleteById
            // 
            this.txtBoxDeleteById.Location = new System.Drawing.Point(1110, 235);
            this.txtBoxDeleteById.Name = "txtBoxDeleteById";
            this.txtBoxDeleteById.Size = new System.Drawing.Size(57, 20);
            this.txtBoxDeleteById.TabIndex = 36;
            this.txtBoxDeleteById.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCreateTitle
            // 
            this.lblCreateTitle.AutoSize = true;
            this.lblCreateTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblCreateTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateTitle.ForeColor = System.Drawing.Color.White;
            this.lblCreateTitle.Location = new System.Drawing.Point(985, 386);
            this.lblCreateTitle.Name = "lblCreateTitle";
            this.lblCreateTitle.Size = new System.Drawing.Size(66, 24);
            this.lblCreateTitle.TabIndex = 44;
            this.lblCreateTitle.Text = "TITLE";
            // 
            // txtCreateTaskTitle
            // 
            this.txtCreateTaskTitle.Location = new System.Drawing.Point(961, 421);
            this.txtCreateTaskTitle.Name = "txtCreateTaskTitle";
            this.txtCreateTaskTitle.Size = new System.Drawing.Size(117, 20);
            this.txtCreateTaskTitle.TabIndex = 43;
            this.txtCreateTaskTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCreateId
            // 
            this.lblCreateId.AutoSize = true;
            this.lblCreateId.BackColor = System.Drawing.Color.Transparent;
            this.lblCreateId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateId.ForeColor = System.Drawing.Color.White;
            this.lblCreateId.Location = new System.Drawing.Point(906, 386);
            this.lblCreateId.Name = "lblCreateId";
            this.lblCreateId.Size = new System.Drawing.Size(29, 24);
            this.lblCreateId.TabIndex = 42;
            this.lblCreateId.Text = "ID";
            // 
            // txtCreateTaskId
            // 
            this.txtCreateTaskId.Location = new System.Drawing.Point(900, 421);
            this.txtCreateTaskId.Name = "txtCreateTaskId";
            this.txtCreateTaskId.Size = new System.Drawing.Size(46, 20);
            this.txtCreateTaskId.TabIndex = 41;
            this.txtCreateTaskId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCreateToDo
            // 
            this.lblCreateToDo.BackColor = System.Drawing.Color.Transparent;
            this.lblCreateToDo.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateToDo.ForeColor = System.Drawing.Color.White;
            this.lblCreateToDo.Location = new System.Drawing.Point(711, 336);
            this.lblCreateToDo.Name = "lblCreateToDo";
            this.lblCreateToDo.Size = new System.Drawing.Size(861, 27);
            this.lblCreateToDo.TabIndex = 40;
            this.lblCreateToDo.Text = "To create a ToDo, please provide Id and Title";
            this.lblCreateToDo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCreateNewTodo
            // 
            this.btnCreateNewTodo.BackColor = System.Drawing.Color.White;
            this.btnCreateNewTodo.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateNewTodo.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnCreateNewTodo.Location = new System.Drawing.Point(1073, 461);
            this.btnCreateNewTodo.Name = "btnCreateNewTodo";
            this.btnCreateNewTodo.Size = new System.Drawing.Size(130, 55);
            this.btnCreateNewTodo.TabIndex = 39;
            this.btnCreateNewTodo.Text = "CREATE";
            this.btnCreateNewTodo.UseVisualStyleBackColor = false;
            this.btnCreateNewTodo.Click += new System.EventHandler(this.btnCreateNewTodo_Click);
            // 
            // lblTaskToDoId
            // 
            this.lblTaskToDoId.AutoSize = true;
            this.lblTaskToDoId.BackColor = System.Drawing.Color.Transparent;
            this.lblTaskToDoId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskToDoId.ForeColor = System.Drawing.Color.White;
            this.lblTaskToDoId.Location = new System.Drawing.Point(1278, 386);
            this.lblTaskToDoId.Name = "lblTaskToDoId";
            this.lblTaskToDoId.Size = new System.Drawing.Size(94, 24);
            this.lblTaskToDoId.TabIndex = 48;
            this.lblTaskToDoId.Text = "TODO ID";
            // 
            // txtCreateTaskToDoId
            // 
            this.txtCreateTaskToDoId.Location = new System.Drawing.Point(1269, 421);
            this.txtCreateTaskToDoId.Name = "txtCreateTaskToDoId";
            this.txtCreateTaskToDoId.Size = new System.Drawing.Size(117, 20);
            this.txtCreateTaskToDoId.TabIndex = 47;
            this.txtCreateTaskToDoId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCreateDescription
            // 
            this.lblCreateDescription.AutoSize = true;
            this.lblCreateDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblCreateDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateDescription.ForeColor = System.Drawing.Color.White;
            this.lblCreateDescription.Location = new System.Drawing.Point(1102, 386);
            this.lblCreateDescription.Name = "lblCreateDescription";
            this.lblCreateDescription.Size = new System.Drawing.Size(146, 24);
            this.lblCreateDescription.TabIndex = 46;
            this.lblCreateDescription.Text = "DESCRIPTION";
            // 
            // txtCreateTaskDescription
            // 
            this.txtCreateTaskDescription.Location = new System.Drawing.Point(1094, 421);
            this.txtCreateTaskDescription.Name = "txtCreateTaskDescription";
            this.txtCreateTaskDescription.Size = new System.Drawing.Size(154, 20);
            this.txtCreateTaskDescription.TabIndex = 45;
            this.txtCreateTaskDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEditTaskIsComplete
            // 
            this.lblEditTaskIsComplete.BackColor = System.Drawing.Color.Transparent;
            this.lblEditTaskIsComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditTaskIsComplete.ForeColor = System.Drawing.Color.White;
            this.lblEditTaskIsComplete.Location = new System.Drawing.Point(1264, 594);
            this.lblEditTaskIsComplete.Name = "lblEditTaskIsComplete";
            this.lblEditTaskIsComplete.Size = new System.Drawing.Size(155, 24);
            this.lblEditTaskIsComplete.TabIndex = 58;
            this.lblEditTaskIsComplete.Text = "IS COMPLETE";
            this.lblEditTaskIsComplete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEditTaskIsComplete
            // 
            this.txtEditTaskIsComplete.Location = new System.Drawing.Point(1264, 629);
            this.txtEditTaskIsComplete.Name = "txtEditTaskIsComplete";
            this.txtEditTaskIsComplete.Size = new System.Drawing.Size(155, 20);
            this.txtEditTaskIsComplete.TabIndex = 57;
            this.txtEditTaskIsComplete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEditTaskDescription
            // 
            this.lblEditTaskDescription.AutoSize = true;
            this.lblEditTaskDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblEditTaskDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditTaskDescription.ForeColor = System.Drawing.Color.White;
            this.lblEditTaskDescription.Location = new System.Drawing.Point(1097, 594);
            this.lblEditTaskDescription.Name = "lblEditTaskDescription";
            this.lblEditTaskDescription.Size = new System.Drawing.Size(146, 24);
            this.lblEditTaskDescription.TabIndex = 56;
            this.lblEditTaskDescription.Text = "DESCRIPTION";
            // 
            // txtEditTaskDescription
            // 
            this.txtEditTaskDescription.Location = new System.Drawing.Point(1089, 629);
            this.txtEditTaskDescription.Name = "txtEditTaskDescription";
            this.txtEditTaskDescription.Size = new System.Drawing.Size(154, 20);
            this.txtEditTaskDescription.TabIndex = 55;
            this.txtEditTaskDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEditTaskTitle
            // 
            this.lblEditTaskTitle.AutoSize = true;
            this.lblEditTaskTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblEditTaskTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditTaskTitle.ForeColor = System.Drawing.Color.White;
            this.lblEditTaskTitle.Location = new System.Drawing.Point(980, 594);
            this.lblEditTaskTitle.Name = "lblEditTaskTitle";
            this.lblEditTaskTitle.Size = new System.Drawing.Size(66, 24);
            this.lblEditTaskTitle.TabIndex = 54;
            this.lblEditTaskTitle.Text = "TITLE";
            // 
            // txtEditTaskTitle
            // 
            this.txtEditTaskTitle.Location = new System.Drawing.Point(956, 629);
            this.txtEditTaskTitle.Name = "txtEditTaskTitle";
            this.txtEditTaskTitle.Size = new System.Drawing.Size(117, 20);
            this.txtEditTaskTitle.TabIndex = 53;
            this.txtEditTaskTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEditTaskId
            // 
            this.lblEditTaskId.AutoSize = true;
            this.lblEditTaskId.BackColor = System.Drawing.Color.Transparent;
            this.lblEditTaskId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditTaskId.ForeColor = System.Drawing.Color.White;
            this.lblEditTaskId.Location = new System.Drawing.Point(901, 594);
            this.lblEditTaskId.Name = "lblEditTaskId";
            this.lblEditTaskId.Size = new System.Drawing.Size(29, 24);
            this.lblEditTaskId.TabIndex = 52;
            this.lblEditTaskId.Text = "ID";
            // 
            // txtEditTaskId
            // 
            this.txtEditTaskId.Location = new System.Drawing.Point(895, 629);
            this.txtEditTaskId.Name = "txtEditTaskId";
            this.txtEditTaskId.Size = new System.Drawing.Size(46, 20);
            this.txtEditTaskId.TabIndex = 51;
            this.txtEditTaskId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(706, 544);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(861, 27);
            this.label5.TabIndex = 50;
            this.label5.Text = "To edit a Task please provide the information below";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUpdateTask
            // 
            this.btnUpdateTask.BackColor = System.Drawing.Color.White;
            this.btnUpdateTask.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTask.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnUpdateTask.Location = new System.Drawing.Point(1068, 669);
            this.btnUpdateTask.Name = "btnUpdateTask";
            this.btnUpdateTask.Size = new System.Drawing.Size(130, 55);
            this.btnUpdateTask.TabIndex = 49;
            this.btnUpdateTask.Text = "UPDATE";
            this.btnUpdateTask.UseVisualStyleBackColor = false;
            this.btnUpdateTask.Click += new System.EventHandler(this.btnUpdateTask_Click);
            // 
            // lblTrueFalseText
            // 
            this.lblTrueFalseText.BackColor = System.Drawing.Color.Transparent;
            this.lblTrueFalseText.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrueFalseText.ForeColor = System.Drawing.Color.White;
            this.lblTrueFalseText.Location = new System.Drawing.Point(1264, 652);
            this.lblTrueFalseText.Name = "lblTrueFalseText";
            this.lblTrueFalseText.Size = new System.Drawing.Size(155, 23);
            this.lblTrueFalseText.TabIndex = 59;
            this.lblTrueFalseText.Text = "(true / false)";
            this.lblTrueFalseText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ToDoTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ToDoApp_Project.Properties.Resources.Ocean_Wallpaper_scaled;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1584, 761);
            this.Controls.Add(this.lblTrueFalseText);
            this.Controls.Add(this.lblEditTaskIsComplete);
            this.Controls.Add(this.txtEditTaskIsComplete);
            this.Controls.Add(this.lblEditTaskDescription);
            this.Controls.Add(this.txtEditTaskDescription);
            this.Controls.Add(this.lblEditTaskTitle);
            this.Controls.Add(this.txtEditTaskTitle);
            this.Controls.Add(this.lblEditTaskId);
            this.Controls.Add(this.txtEditTaskId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnUpdateTask);
            this.Controls.Add(this.lblTaskToDoId);
            this.Controls.Add(this.txtCreateTaskToDoId);
            this.Controls.Add(this.lblCreateDescription);
            this.Controls.Add(this.txtCreateTaskDescription);
            this.Controls.Add(this.lblCreateTitle);
            this.Controls.Add(this.txtCreateTaskTitle);
            this.Controls.Add(this.lblCreateId);
            this.Controls.Add(this.txtCreateTaskId);
            this.Controls.Add(this.lblCreateToDo);
            this.Controls.Add(this.btnCreateNewTodo);
            this.Controls.Add(this.lblTaskDelById);
            this.Controls.Add(this.txtBoxDeleteById);
            this.Controls.Add(this.btnTaskDeleteById);
            this.Controls.Add(this.lblCompleteTask);
            this.Controls.Add(this.btnToggleComplete);
            this.Controls.Add(this.lblToDoNameForTasks);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.dgvTasks);
            this.Name = "ToDoTasks";
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
        private System.Windows.Forms.Button btnTaskDeleteById;
        private System.Windows.Forms.Label lblTaskDelById;
        private System.Windows.Forms.TextBox txtBoxDeleteById;
        private System.Windows.Forms.Label lblCreateTitle;
        private System.Windows.Forms.TextBox txtCreateTaskTitle;
        private System.Windows.Forms.Label lblCreateId;
        private System.Windows.Forms.TextBox txtCreateTaskId;
        private System.Windows.Forms.Label lblCreateToDo;
        private System.Windows.Forms.Button btnCreateNewTodo;
        private System.Windows.Forms.Label lblTaskToDoId;
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpdateTask;
        private System.Windows.Forms.Label lblTrueFalseText;
    }
}