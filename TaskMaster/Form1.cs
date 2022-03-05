using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskMaster.Model;
using System.Globalization;
using LicenseContext = OfficeOpenXml.LicenseContext;
using OfficeOpenXml.Style;
using System.Diagnostics;

namespace TaskMaster
{
    public partial class Form1 : Form
    {
        private TaskMasterDbContext taskMasterDbContext;
        public Form1()
        {
            InitializeComponent();

            taskMasterDbContext = new TaskMasterDbContext();

            var statuses = taskMasterDbContext.Statuses.ToList();

            foreach(Status s in statuses)
            {
                cboStatus.Items.Add(s);
            }
            refreshData();
        }

        private void refreshData()
        {
            BindingSource bi = new BindingSource();

            var query = from t in taskMasterDbContext.Tasks
                        orderby t.DueDate
                        select new { t.Id, TaskName = t.Name, StatusName = t.Status.Name, t.DueDate };

            bi.DataSource = query.ToList();
            dataGridView1.DataSource = bi;
            dataGridView1.Refresh();
        }

        private void cmdCreateTask_Click(object sender, EventArgs e)
        {
            if(cboStatus.SelectedItem is not null && txtTask.Text != String.Empty)
            {
                var newTask = new Model.Task
                {
                    Name = txtTask.Text,
                    StatusId = (cboStatus.SelectedItem as Model.Status).Id,
                    DueDate = dateTimePicker1.Value.ToString("dd/MM/yyyy")
                };
                taskMasterDbContext.Tasks.Add(newTask);
                taskMasterDbContext.SaveChanges();
            }
            else
            {
                MessageBox.Show("Enter All the Data");
            }
            refreshData();
        }

        private void cmdDeleteTask_Click(object sender, EventArgs e)
        {
            var task = taskMasterDbContext.Tasks.Find((int)dataGridView1.SelectedCells[0].Value);

            taskMasterDbContext.Tasks.Remove(task);
            taskMasterDbContext.SaveChanges();
            refreshData();
        }

        private void cmdUpdateTask_Click(object sender, EventArgs e)
        {
            if(cmdUpdateTask.Text == "Update")
            {
                txtTask.Text = dataGridView1.SelectedCells[1].Value.ToString();
                dateTimePicker1.Value = DateTime.Parse(dataGridView1.SelectedCells[3].Value.ToString());
                foreach(Status s in cboStatus.Items)
                {
                    if(s.Name == dataGridView1.SelectedCells[2].Value.ToString())
                    {
                        cboStatus.SelectedItem = s;
                    }
                }

                cmdUpdateTask.Text = "Save";
            }
            else if(cmdUpdateTask.Text == "Save")
            {
                var t = taskMasterDbContext.Tasks.Find((int)dataGridView1.SelectedCells[0].Value);

                t.Name = txtTask.Text;
                t.StatusId = (cboStatus.SelectedItem as Status).Id;
                t.DueDate = dateTimePicker1.Value.ToString("dd/MM/yyyy");

                taskMasterDbContext.SaveChanges();
                refreshData();
                cmdUpdateTask.Text = "Update";

                txtTask.Text = string.Empty;
                dateTimePicker1.Value = DateTime.Now;
                cboStatus.Text = "Please select...";

            }


        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            cmdUpdateTask.Text = "Update";

            txtTask.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now;
            cboStatus.Text = "Please select...";
        }

        private void cmdExportToExcel_Click(object sender, EventArgs e)
        {
            var query = from t in taskMasterDbContext.Tasks
                        orderby t.DueDate
                        select new { t.Id, TaskName = t.Name, StatusName = t.Status.Name, DueDate = t.DueDate.ToString() };
            var tasks = query.ToList();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            var file = new FileInfo(@"D:\TaskManager\TasksMaster.xlsx");
            DeleteIfExists(file);

            using var package = new ExcelPackage(file);

            var ws = package.Workbook.Worksheets.Add("TasksReport");

            var range = ws.Cells["A2"].LoadFromCollection(tasks, true);
            range.AutoFitColumns();

            // Formats the header
            ws.Cells["A1"].Value = "Tasks Sheet";
            ws.Cells["A1:D1"].Merge = true;
            ws.Column(1).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            ws.Row(1).Style.Font.Size = 24;
            ws.Row(1).Style.Font.Color.SetColor(Color.Gold);

            ws.Row(2).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            ws.Row(2).Style.Font.Bold = true;
            ws.Column(2).Width = 55;

            package.Save();
            Process.Start(@"C:\Program Files\Microsoft Office\root\Office16\EXCEL.EXE", @"D:\TaskManager\TasksMaster.xlsx");
            
            
        }

        private static void DeleteIfExists(FileInfo file)
        {
            if (file.Exists)
            {
                file.Delete();
            }
        }
    }
}
