
namespace TaskMaster
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Task = new System.Windows.Forms.GroupBox();
            this.cmdExportToExcel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdDeleteTask = new System.Windows.Forms.Button();
            this.cmdUpdateTask = new System.Windows.Forms.Button();
            this.cmdCreateTask = new System.Windows.Forms.Button();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtTask = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Task.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 201);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(645, 269);
            this.dataGridView1.TabIndex = 0;
            // 
            // Task
            // 
            this.Task.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Task.Controls.Add(this.label3);
            this.Task.Controls.Add(this.label2);
            this.Task.Controls.Add(this.label1);
            this.Task.Controls.Add(this.cmdCancel);
            this.Task.Controls.Add(this.cmdDeleteTask);
            this.Task.Controls.Add(this.cmdUpdateTask);
            this.Task.Controls.Add(this.cmdCreateTask);
            this.Task.Controls.Add(this.cboStatus);
            this.Task.Controls.Add(this.dateTimePicker1);
            this.Task.Controls.Add(this.txtTask);
            this.Task.Location = new System.Drawing.Point(12, 12);
            this.Task.Name = "Task";
            this.Task.Size = new System.Drawing.Size(1012, 183);
            this.Task.TabIndex = 1;
            this.Task.TabStop = false;
            this.Task.Text = "Task";
            // 
            // cmdExportToExcel
            // 
            this.cmdExportToExcel.Location = new System.Drawing.Point(663, 201);
            this.cmdExportToExcel.Name = "cmdExportToExcel";
            this.cmdExportToExcel.Size = new System.Drawing.Size(361, 269);
            this.cmdExportToExcel.TabIndex = 10;
            this.cmdExportToExcel.Text = "Export To Excel";
            this.cmdExportToExcel.UseVisualStyleBackColor = true;
            this.cmdExportToExcel.Click += new System.EventHandler(this.cmdExportToExcel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(576, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Due Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Status:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Task:";
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(533, 144);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(112, 34);
            this.cmdCancel.TabIndex = 6;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdDeleteTask
            // 
            this.cmdDeleteTask.Location = new System.Drawing.Point(670, 87);
            this.cmdDeleteTask.Name = "cmdDeleteTask";
            this.cmdDeleteTask.Size = new System.Drawing.Size(112, 34);
            this.cmdDeleteTask.TabIndex = 5;
            this.cmdDeleteTask.Text = "Delete";
            this.cmdDeleteTask.UseVisualStyleBackColor = true;
            this.cmdDeleteTask.Click += new System.EventHandler(this.cmdDeleteTask_Click);
            // 
            // cmdUpdateTask
            // 
            this.cmdUpdateTask.Location = new System.Drawing.Point(533, 87);
            this.cmdUpdateTask.Name = "cmdUpdateTask";
            this.cmdUpdateTask.Size = new System.Drawing.Size(112, 34);
            this.cmdUpdateTask.TabIndex = 4;
            this.cmdUpdateTask.Text = "Update";
            this.cmdUpdateTask.UseVisualStyleBackColor = true;
            this.cmdUpdateTask.Click += new System.EventHandler(this.cmdUpdateTask_Click);
            // 
            // cmdCreateTask
            // 
            this.cmdCreateTask.Location = new System.Drawing.Point(393, 87);
            this.cmdCreateTask.Name = "cmdCreateTask";
            this.cmdCreateTask.Size = new System.Drawing.Size(112, 34);
            this.cmdCreateTask.TabIndex = 3;
            this.cmdCreateTask.Text = "Create";
            this.cmdCreateTask.UseVisualStyleBackColor = true;
            this.cmdCreateTask.Click += new System.EventHandler(this.cmdCreateTask_Click);
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(96, 87);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(275, 33);
            this.cboStatus.TabIndex = 2;
            this.cboStatus.Text = "Please select...";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(670, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(300, 31);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // txtTask
            // 
            this.txtTask.Location = new System.Drawing.Point(96, 30);
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(409, 31);
            this.txtTask.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 482);
            this.Controls.Add(this.cmdExportToExcel);
            this.Controls.Add(this.Task);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(1058, 538);
            this.MinimumSize = new System.Drawing.Size(1058, 538);
            this.Name = "Form1";
            this.Text = "Task Master";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Task.ResumeLayout(false);
            this.Task.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox Task;
        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdDeleteTask;
        private System.Windows.Forms.Button cmdUpdateTask;
        private System.Windows.Forms.Button cmdCreateTask;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdExportToExcel;
    }
}

