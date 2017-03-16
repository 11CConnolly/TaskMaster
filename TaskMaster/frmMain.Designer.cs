namespace TaskMaster
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblAllTasks = new System.Windows.Forms.Label();
            this.lstAllTasks = new System.Windows.Forms.ListBox();
            this.lstCurrentTasks = new System.Windows.Forms.ListBox();
            this.lblCurrentTasks = new System.Windows.Forms.Label();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.txtTaskDescription = new System.Windows.Forms.TextBox();
            this.btnUpdateTaskDescription = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAllTasks
            // 
            this.lblAllTasks.AutoSize = true;
            this.lblAllTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllTasks.Location = new System.Drawing.Point(48, 180);
            this.lblAllTasks.Name = "lblAllTasks";
            this.lblAllTasks.Size = new System.Drawing.Size(72, 20);
            this.lblAllTasks.TabIndex = 0;
            this.lblAllTasks.Text = "All Tasks";
            // 
            // lstAllTasks
            // 
            this.lstAllTasks.FormattingEnabled = true;
            this.lstAllTasks.Location = new System.Drawing.Point(18, 200);
            this.lstAllTasks.Name = "lstAllTasks";
            this.lstAllTasks.Size = new System.Drawing.Size(133, 160);
            this.lstAllTasks.TabIndex = 1;
            this.lstAllTasks.SelectedIndexChanged += new System.EventHandler(this.lstAllTasks_SelectedIndexChanged);
            // 
            // lstCurrentTasks
            // 
            this.lstCurrentTasks.FormattingEnabled = true;
            this.lstCurrentTasks.Location = new System.Drawing.Point(208, 200);
            this.lstCurrentTasks.Name = "lstCurrentTasks";
            this.lstCurrentTasks.Size = new System.Drawing.Size(133, 160);
            this.lstCurrentTasks.TabIndex = 3;
            // 
            // lblCurrentTasks
            // 
            this.lblCurrentTasks.AutoSize = true;
            this.lblCurrentTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTasks.Location = new System.Drawing.Point(223, 181);
            this.lblCurrentTasks.Name = "lblCurrentTasks";
            this.lblCurrentTasks.Size = new System.Drawing.Size(108, 20);
            this.lblCurrentTasks.TabIndex = 2;
            this.lblCurrentTasks.Text = "Current Tasks";
            // 
            // btnAddTask
            // 
            this.btnAddTask.BackColor = System.Drawing.Color.Transparent;
            this.btnAddTask.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTask.Location = new System.Drawing.Point(19, 112);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(132, 31);
            this.btnAddTask.TabIndex = 4;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.UseVisualStyleBackColor = false;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // txtTaskDescription
            // 
            this.txtTaskDescription.BackColor = System.Drawing.Color.White;
            this.txtTaskDescription.Location = new System.Drawing.Point(19, 72);
            this.txtTaskDescription.Name = "txtTaskDescription";
            this.txtTaskDescription.Size = new System.Drawing.Size(322, 20);
            this.txtTaskDescription.TabIndex = 5;
            // 
            // btnUpdateTaskDescription
            // 
            this.btnUpdateTaskDescription.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTaskDescription.Location = new System.Drawing.Point(209, 112);
            this.btnUpdateTaskDescription.Name = "btnUpdateTaskDescription";
            this.btnUpdateTaskDescription.Size = new System.Drawing.Size(132, 31);
            this.btnUpdateTaskDescription.TabIndex = 6;
            this.btnUpdateTaskDescription.Text = "Update Task";
            this.btnUpdateTaskDescription.UseVisualStyleBackColor = true;
            this.btnUpdateTaskDescription.Click += new System.EventHandler(this.btnUpdateTaskDescription_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("AR DESTINE", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "TaskMaster";
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAll.Location = new System.Drawing.Point(132, 147);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(100, 31);
            this.btnDeleteAll.TabIndex = 8;
            this.btnDeleteAll.Text = "DeleteAll";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(366, 390);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdateTaskDescription);
            this.Controls.Add(this.txtTaskDescription);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.lstCurrentTasks);
            this.Controls.Add(this.lblCurrentTasks);
            this.Controls.Add(this.lstAllTasks);
            this.Controls.Add(this.lblAllTasks);
            this.Name = "frmMain";
            this.Text = "TaskMaster";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAllTasks;
        private System.Windows.Forms.ListBox lstAllTasks;
        private System.Windows.Forms.ListBox lstCurrentTasks;
        private System.Windows.Forms.Label lblCurrentTasks;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.TextBox txtTaskDescription;
        private System.Windows.Forms.Button btnUpdateTaskDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteAll;
    }
}

