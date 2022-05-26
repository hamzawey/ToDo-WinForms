namespace ToDoApp_Project.View
{
    partial class ToDosView
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
            this.lblEditTitle = new System.Windows.Forms.Label();
            this.txtEditTitle = new System.Windows.Forms.TextBox();
            this.lblEditId = new System.Windows.Forms.Label();
            this.txtEditId = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.toDosDataGridView.DataSource = this.toDoBindingSource;
            this.toDosDataGridView.Location = new System.Drawing.Point(12, 12);
            this.toDosDataGridView.Name = "toDosDataGridView";
            this.toDosDataGridView.Size = new System.Drawing.Size(614, 637);
            this.toDosDataGridView.TabIndex = 0;
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
            this.btnDeleteByIdTodo.Location = new System.Drawing.Point(952, 330);
            this.btnDeleteByIdTodo.Name = "btnDeleteByIdTodo";
            this.btnDeleteByIdTodo.Size = new System.Drawing.Size(130, 55);
            this.btnDeleteByIdTodo.TabIndex = 13;
            this.btnDeleteByIdTodo.Text = "DELETE BY ID";
            this.btnDeleteByIdTodo.UseVisualStyleBackColor = false;
            this.btnDeleteByIdTodo.Click += new System.EventHandler(this.btnDeleteByIdTodo_Click);
            // 
            // lblDeleteByIdToDo
            // 
            this.lblDeleteByIdToDo.BackColor = System.Drawing.Color.Transparent;
            this.lblDeleteByIdToDo.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteByIdToDo.ForeColor = System.Drawing.Color.White;
            this.lblDeleteByIdToDo.Location = new System.Drawing.Point(637, 262);
            this.lblDeleteByIdToDo.Name = "lblDeleteByIdToDo";
            this.lblDeleteByIdToDo.Size = new System.Drawing.Size(835, 27);
            this.lblDeleteByIdToDo.TabIndex = 14;
            this.lblDeleteByIdToDo.Text = "To delete a ToDo, please provide Id and click DELETE BY ID";
            this.lblDeleteByIdToDo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCreateToDo
            // 
            this.lblCreateToDo.BackColor = System.Drawing.Color.Transparent;
            this.lblCreateToDo.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateToDo.ForeColor = System.Drawing.Color.White;
            this.lblCreateToDo.Location = new System.Drawing.Point(632, 49);
            this.lblCreateToDo.Name = "lblCreateToDo";
            this.lblCreateToDo.Size = new System.Drawing.Size(840, 27);
            this.lblCreateToDo.TabIndex = 16;
            this.lblCreateToDo.Text = "To create a ToDo, please provide Id and Title";
            this.lblCreateToDo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCreateNewTodo
            // 
            this.btnCreateNewTodo.BackColor = System.Drawing.Color.White;
            this.btnCreateNewTodo.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateNewTodo.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnCreateNewTodo.Location = new System.Drawing.Point(952, 161);
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
            this.lblEditToDo.Location = new System.Drawing.Point(637, 435);
            this.lblEditToDo.Name = "lblEditToDo";
            this.lblEditToDo.Size = new System.Drawing.Size(835, 27);
            this.lblEditToDo.TabIndex = 20;
            this.lblEditToDo.Text = "To edit a ToDo, please provide Id and Title and click UPDATE";
            this.lblEditToDo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUpdateToDo
            // 
            this.btnUpdateToDo.BackColor = System.Drawing.Color.White;
            this.btnUpdateToDo.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateToDo.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdateToDo.Location = new System.Drawing.Point(952, 564);
            this.btnUpdateToDo.Name = "btnUpdateToDo";
            this.btnUpdateToDo.Size = new System.Drawing.Size(130, 55);
            this.btnUpdateToDo.TabIndex = 19;
            this.btnUpdateToDo.Text = "UPDATE";
            this.btnUpdateToDo.UseVisualStyleBackColor = false;
            this.btnUpdateToDo.Click += new System.EventHandler(this.btnUpdateToDo_Click);
            // 
            // txtCreateId
            // 
            this.txtCreateId.Location = new System.Drawing.Point(884, 125);
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
            this.lblCreateId.Location = new System.Drawing.Point(926, 90);
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
            this.lblCreateTitle.Location = new System.Drawing.Point(1053, 90);
            this.lblCreateTitle.Name = "lblCreateTitle";
            this.lblCreateTitle.Size = new System.Drawing.Size(66, 24);
            this.lblCreateTitle.TabIndex = 25;
            this.lblCreateTitle.Text = "TITLE";
            // 
            // txtCreateTitle
            // 
            this.txtCreateTitle.Location = new System.Drawing.Point(1029, 125);
            this.txtCreateTitle.Name = "txtCreateTitle";
            this.txtCreateTitle.Size = new System.Drawing.Size(117, 20);
            this.txtCreateTitle.TabIndex = 24;
            this.txtCreateTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDeleteById
            // 
            this.txtDeleteById.Location = new System.Drawing.Point(978, 304);
            this.txtDeleteById.Name = "txtDeleteById";
            this.txtDeleteById.Size = new System.Drawing.Size(77, 20);
            this.txtDeleteById.TabIndex = 26;
            this.txtDeleteById.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEditTitle
            // 
            this.lblEditTitle.AutoSize = true;
            this.lblEditTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblEditTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditTitle.ForeColor = System.Drawing.Color.White;
            this.lblEditTitle.Location = new System.Drawing.Point(1053, 487);
            this.lblEditTitle.Name = "lblEditTitle";
            this.lblEditTitle.Size = new System.Drawing.Size(66, 24);
            this.lblEditTitle.TabIndex = 30;
            this.lblEditTitle.Text = "TITLE";
            // 
            // txtEditTitle
            // 
            this.txtEditTitle.Location = new System.Drawing.Point(1029, 522);
            this.txtEditTitle.Name = "txtEditTitle";
            this.txtEditTitle.Size = new System.Drawing.Size(117, 20);
            this.txtEditTitle.TabIndex = 29;
            this.txtEditTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEditId
            // 
            this.lblEditId.AutoSize = true;
            this.lblEditId.BackColor = System.Drawing.Color.Transparent;
            this.lblEditId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditId.ForeColor = System.Drawing.Color.White;
            this.lblEditId.Location = new System.Drawing.Point(926, 487);
            this.lblEditId.Name = "lblEditId";
            this.lblEditId.Size = new System.Drawing.Size(29, 24);
            this.lblEditId.TabIndex = 28;
            this.lblEditId.Text = "ID";
            // 
            // txtEditId
            // 
            this.txtEditId.Location = new System.Drawing.Point(884, 522);
            this.txtEditId.Name = "txtEditId";
            this.txtEditId.Size = new System.Drawing.Size(117, 20);
            this.txtEditId.TabIndex = 27;
            this.txtEditId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn2.HeaderText = "TITLE";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 160;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CreatedAt";
            this.dataGridViewTextBoxColumn3.HeaderText = "CREATED AT";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 110;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CreatorId";
            this.dataGridViewTextBoxColumn4.HeaderText = "CREATOR ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 70;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "LastChanged";
            this.dataGridViewTextBoxColumn5.HeaderText = "LAST CHANGED";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 110;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "LastChangedUserId";
            this.dataGridViewTextBoxColumn6.HeaderText = "CHANGER ID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 70;
            // 
            // ToDosView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.BackgroundImage = global::ToDoApp_Project.Properties.Resources.aec3fd35fa6dc8166e9836d0cccd44aa;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1484, 661);
            this.Controls.Add(this.lblEditTitle);
            this.Controls.Add(this.txtEditTitle);
            this.Controls.Add(this.lblEditId);
            this.Controls.Add(this.txtEditId);
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
            this.Name = "ToDosView";
            this.Text = "ToDos";
            this.Load += new System.EventHandler(this.ToDosView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toDosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView toDosDataGridView;
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
        private System.Windows.Forms.BindingSource toDoBindingSource;
        private System.Windows.Forms.Label lblEditTitle;
        private System.Windows.Forms.TextBox txtEditTitle;
        private System.Windows.Forms.Label lblEditId;
        private System.Windows.Forms.TextBox txtEditId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}