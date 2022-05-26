namespace ToDoApp_Project.View
{
    partial class txtBoxCreateToDoTitle
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
            this.toDosDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creatorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastChangedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastChangedUserIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toDoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnGoBack = new System.Windows.Forms.Button();
            this.btnDeleteByIdTodo = new System.Windows.Forms.Button();
            this.lblDeleteByIdToDo = new System.Windows.Forms.Label();
            this.lblCreateToDo = new System.Windows.Forms.Label();
            this.btnCreateNewTodo = new System.Windows.Forms.Button();
            this.lblEditToDo = new System.Windows.Forms.Label();
            this.btnUpdateToDo = new System.Windows.Forms.Button();
            this.txtCreateId = new System.Windows.Forms.TextBox();
            this.lblCreateId = new System.Windows.Forms.Label();
            this.lblCreateTitle = new System.Windows.Forms.Label();
            this.txtCreateTitle = new System.Windows.Forms.TextBox();
            this.txtDeleteById = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.toDosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toDosDataGridView
            // 
            this.toDosDataGridView.AutoGenerateColumns = false;
            this.toDosDataGridView.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.toDosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.toDosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.createdAtDataGridViewTextBoxColumn,
            this.creatorIdDataGridViewTextBoxColumn,
            this.lastChangedDataGridViewTextBoxColumn,
            this.lastChangedUserIdDataGridViewTextBoxColumn});
            this.toDosDataGridView.DataSource = this.toDoBindingSource;
            this.toDosDataGridView.Location = new System.Drawing.Point(12, 12);
            this.toDosDataGridView.Name = "toDosDataGridView";
            this.toDosDataGridView.Size = new System.Drawing.Size(565, 637);
            this.toDosDataGridView.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 40;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "TITLE";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 130;
            // 
            // createdAtDataGridViewTextBoxColumn
            // 
            this.createdAtDataGridViewTextBoxColumn.DataPropertyName = "CreatedAt";
            this.createdAtDataGridViewTextBoxColumn.HeaderText = "CREATE DATE";
            this.createdAtDataGridViewTextBoxColumn.Name = "createdAtDataGridViewTextBoxColumn";
            this.createdAtDataGridViewTextBoxColumn.Width = 90;
            // 
            // creatorIdDataGridViewTextBoxColumn
            // 
            this.creatorIdDataGridViewTextBoxColumn.DataPropertyName = "CreatorId";
            this.creatorIdDataGridViewTextBoxColumn.HeaderText = "CREATOR ID";
            this.creatorIdDataGridViewTextBoxColumn.Name = "creatorIdDataGridViewTextBoxColumn";
            this.creatorIdDataGridViewTextBoxColumn.Width = 70;
            // 
            // lastChangedDataGridViewTextBoxColumn
            // 
            this.lastChangedDataGridViewTextBoxColumn.DataPropertyName = "LastChanged";
            this.lastChangedDataGridViewTextBoxColumn.HeaderText = "LAST CHANGED";
            this.lastChangedDataGridViewTextBoxColumn.Name = "lastChangedDataGridViewTextBoxColumn";
            this.lastChangedDataGridViewTextBoxColumn.Width = 90;
            // 
            // lastChangedUserIdDataGridViewTextBoxColumn
            // 
            this.lastChangedUserIdDataGridViewTextBoxColumn.DataPropertyName = "LastChangedUserId";
            this.lastChangedUserIdDataGridViewTextBoxColumn.HeaderText = "LAST CHANGED BY";
            this.lastChangedUserIdDataGridViewTextBoxColumn.Name = "lastChangedUserIdDataGridViewTextBoxColumn";
            // 
            // toDoBindingSource
            // 
            this.toDoBindingSource.DataSource = typeof(ToDoApp_Project.Model.ToDo);
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.White;
            this.btnGoBack.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoBack.ForeColor = System.Drawing.Color.Blue;
            this.btnGoBack.Location = new System.Drawing.Point(1342, 594);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(130, 55);
            this.btnGoBack.TabIndex = 12;
            this.btnGoBack.Text = "GO BACK";
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // btnDeleteByIdTodo
            // 
            this.btnDeleteByIdTodo.BackColor = System.Drawing.Color.White;
            this.btnDeleteByIdTodo.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteByIdTodo.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnDeleteByIdTodo.Location = new System.Drawing.Point(965, 334);
            this.btnDeleteByIdTodo.Name = "btnDeleteByIdTodo";
            this.btnDeleteByIdTodo.Size = new System.Drawing.Size(130, 55);
            this.btnDeleteByIdTodo.TabIndex = 13;
            this.btnDeleteByIdTodo.Text = "DELETE BY ID";
            this.btnDeleteByIdTodo.UseVisualStyleBackColor = false;
            // 
            // lblDeleteByIdToDo
            // 
            this.lblDeleteByIdToDo.BackColor = System.Drawing.Color.Transparent;
            this.lblDeleteByIdToDo.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteByIdToDo.ForeColor = System.Drawing.Color.White;
            this.lblDeleteByIdToDo.Location = new System.Drawing.Point(583, 262);
            this.lblDeleteByIdToDo.Name = "lblDeleteByIdToDo";
            this.lblDeleteByIdToDo.Size = new System.Drawing.Size(889, 27);
            this.lblDeleteByIdToDo.TabIndex = 14;
            this.lblDeleteByIdToDo.Text = "To delete a ToDo, please provide Id and click DELETE BY ID";
            this.lblDeleteByIdToDo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCreateToDo
            // 
            this.lblCreateToDo.BackColor = System.Drawing.Color.Transparent;
            this.lblCreateToDo.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateToDo.ForeColor = System.Drawing.Color.White;
            this.lblCreateToDo.Location = new System.Drawing.Point(583, 49);
            this.lblCreateToDo.Name = "lblCreateToDo";
            this.lblCreateToDo.Size = new System.Drawing.Size(889, 27);
            this.lblCreateToDo.TabIndex = 16;
            this.lblCreateToDo.Text = "To create a ToDo, please provide Id and Title";
            this.lblCreateToDo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCreateNewTodo
            // 
            this.btnCreateNewTodo.BackColor = System.Drawing.Color.White;
            this.btnCreateNewTodo.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateNewTodo.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnCreateNewTodo.Location = new System.Drawing.Point(965, 166);
            this.btnCreateNewTodo.Name = "btnCreateNewTodo";
            this.btnCreateNewTodo.Size = new System.Drawing.Size(130, 55);
            this.btnCreateNewTodo.TabIndex = 15;
            this.btnCreateNewTodo.Text = "CREATE";
            this.btnCreateNewTodo.UseVisualStyleBackColor = false;
            this.btnCreateNewTodo.Click += new System.EventHandler(this.btnCreateNewTodo_Click);
            // 
            // lblEditToDo
            // 
            this.lblEditToDo.BackColor = System.Drawing.Color.Transparent;
            this.lblEditToDo.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditToDo.ForeColor = System.Drawing.Color.White;
            this.lblEditToDo.Location = new System.Drawing.Point(583, 435);
            this.lblEditToDo.Name = "lblEditToDo";
            this.lblEditToDo.Size = new System.Drawing.Size(889, 27);
            this.lblEditToDo.TabIndex = 20;
            this.lblEditToDo.Text = "To edit a ToDo, please provide Id and Title and click UPDATE";
            this.lblEditToDo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUpdateToDo
            // 
            this.btnUpdateToDo.BackColor = System.Drawing.Color.White;
            this.btnUpdateToDo.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateToDo.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdateToDo.Location = new System.Drawing.Point(965, 482);
            this.btnUpdateToDo.Name = "btnUpdateToDo";
            this.btnUpdateToDo.Size = new System.Drawing.Size(130, 55);
            this.btnUpdateToDo.TabIndex = 19;
            this.btnUpdateToDo.Text = "UPDATE";
            this.btnUpdateToDo.UseVisualStyleBackColor = false;
            this.btnUpdateToDo.Click += new System.EventHandler(this.btnUpdateToDo_Click);
            // 
            // txtCreateId
            // 
            this.txtCreateId.Location = new System.Drawing.Point(897, 130);
            this.txtCreateId.Name = "txtCreateId";
            this.txtCreateId.Size = new System.Drawing.Size(117, 20);
            this.txtCreateId.TabIndex = 21;
            this.txtCreateId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCreateId
            // 
            this.lblCreateId.AutoSize = true;
            this.lblCreateId.BackColor = System.Drawing.Color.Transparent;
            this.lblCreateId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateId.ForeColor = System.Drawing.Color.White;
            this.lblCreateId.Location = new System.Drawing.Point(939, 95);
            this.lblCreateId.Name = "lblCreateId";
            this.lblCreateId.Size = new System.Drawing.Size(29, 24);
            this.lblCreateId.TabIndex = 23;
            this.lblCreateId.Text = "ID";
            // 
            // lblCreateTitle
            // 
            this.lblCreateTitle.AutoSize = true;
            this.lblCreateTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblCreateTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateTitle.ForeColor = System.Drawing.Color.White;
            this.lblCreateTitle.Location = new System.Drawing.Point(1066, 95);
            this.lblCreateTitle.Name = "lblCreateTitle";
            this.lblCreateTitle.Size = new System.Drawing.Size(66, 24);
            this.lblCreateTitle.TabIndex = 25;
            this.lblCreateTitle.Text = "TITLE";
            // 
            // txtCreateTitle
            // 
            this.txtCreateTitle.Location = new System.Drawing.Point(1042, 130);
            this.txtCreateTitle.Name = "txtCreateTitle";
            this.txtCreateTitle.Size = new System.Drawing.Size(117, 20);
            this.txtCreateTitle.TabIndex = 24;
            this.txtCreateTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDeleteById
            // 
            this.txtDeleteById.Location = new System.Drawing.Point(991, 308);
            this.txtDeleteById.Name = "txtDeleteById";
            this.txtDeleteById.Size = new System.Drawing.Size(77, 20);
            this.txtDeleteById.TabIndex = 26;
            this.txtDeleteById.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxCreateToDoTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.BackgroundImage = global::ToDoApp_Project.Properties.Resources.aec3fd35fa6dc8166e9836d0cccd44aa;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1484, 661);
            this.Controls.Add(this.txtDeleteById);
            this.Controls.Add(this.lblCreateTitle);
            this.Controls.Add(this.txtCreateTitle);
            this.Controls.Add(this.lblCreateId);
            this.Controls.Add(this.txtCreateId);
            this.Controls.Add(this.lblEditToDo);
            this.Controls.Add(this.btnUpdateToDo);
            this.Controls.Add(this.lblCreateToDo);
            this.Controls.Add(this.btnCreateNewTodo);
            this.Controls.Add(this.lblDeleteByIdToDo);
            this.Controls.Add(this.btnDeleteByIdTodo);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.toDosDataGridView);
            this.Name = "txtBoxCreateToDoTitle";
            this.Text = "ToDos";
            ((System.ComponentModel.ISupportInitialize)(this.toDosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView toDosDataGridView;
        private System.Windows.Forms.BindingSource toDoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creatorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastChangedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastChangedUserIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Button btnDeleteByIdTodo;
        private System.Windows.Forms.Label lblDeleteByIdToDo;
        private System.Windows.Forms.Label lblCreateToDo;
        private System.Windows.Forms.Button btnCreateNewTodo;
        private System.Windows.Forms.Label lblEditToDo;
        private System.Windows.Forms.Button btnUpdateToDo;
        private System.Windows.Forms.TextBox txtCreateId;
        private System.Windows.Forms.Label lblCreateId;
        private System.Windows.Forms.Label lblCreateTitle;
        private System.Windows.Forms.TextBox txtCreateTitle;
        private System.Windows.Forms.TextBox txtDeleteById;
    }
}