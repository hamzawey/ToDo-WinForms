namespace ToDoApp_Project.View
{
    partial class UserMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMain));
            this.lblUserHeader = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnToDos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUserHeader
            // 
            this.lblUserHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblUserHeader.Font = new System.Drawing.Font("Franklin Gothic Medium", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserHeader.ForeColor = System.Drawing.Color.White;
            this.lblUserHeader.Location = new System.Drawing.Point(1, 54);
            this.lblUserHeader.Name = "lblUserHeader";
            this.lblUserHeader.Size = new System.Drawing.Size(632, 78);
            this.lblUserHeader.TabIndex = 7;
            this.lblUserHeader.Text = "WELCOME!";
            this.lblUserHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnExit.Location = new System.Drawing.Point(252, 328);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(130, 55);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnToDos
            // 
            this.btnToDos.BackColor = System.Drawing.Color.White;
            this.btnToDos.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToDos.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnToDos.Location = new System.Drawing.Point(252, 206);
            this.btnToDos.Name = "btnToDos";
            this.btnToDos.Size = new System.Drawing.Size(130, 55);
            this.btnToDos.TabIndex = 5;
            this.btnToDos.Text = "TODOS";
            this.btnToDos.UseVisualStyleBackColor = false;
            this.btnToDos.Click += new System.EventHandler(this.btnToDos_Click);
            // 
            // UserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::ToDoApp_Project.Properties.Resources.img4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.lblUserHeader);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnToDos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserView";
            this.Text = "ToDo App - Home";
            this.Load += new System.EventHandler(this.UserView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUserHeader;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnToDos;
    }
}