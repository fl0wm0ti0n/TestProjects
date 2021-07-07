using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityFramework_Test.Models;

namespace EntityFramework_Test
{
    public partial class Form1 : Form
    {
        private tmDBContext tmContext;

        public Form1()
        {
            InitializeComponent();

            tmContext = new tmDBContext();

            var statuses = tmContext.Statuses.ToList();

            foreach (Status s in statuses)
            {
                comboboxStatus.Items.Add(s);
            }

            refreshData();
        }

        private void refreshData()
        {
            BindingSource bi = new BindingSource();

            var query = from t in tmContext.Tasks
                        orderby t.DueDate
                        select new { t.Id, Aufgabe = t.Name, Status = t.Status.Name, Erstellt = t.DueDate };

            bi.DataSource = query.ToList();

            dataGridView.DataSource = bi;
            dataGridView.Refresh();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (comboboxStatus.SelectedItem != null && txtboxTask.Text != String.Empty)
            {
                var newTask = new Models.Task
                {
                    Name = txtboxTask.Text,
                    StatusId = (comboboxStatus.SelectedItem as Models.Status).Id,
                    DueDate = dateTime.Value
                };

                tmContext.Tasks.Add(newTask);
                tmContext.SaveChanges();

                refreshData();
            }
            else
            {
                MessageBox.Show("Please make sure all data has been entered!");
            };

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var t = tmContext.Tasks.Find(dataGridView.SelectedCells[0].Value);

            tmContext.Tasks.Remove(t);
            tmContext.SaveChanges();

            refreshData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnUpdate.Text == "Update")
            {
                txtboxTask.Text = dataGridView.SelectedCells[1].Value.ToString();
                dateTime.Value = (DateTime)dataGridView.SelectedCells[3].Value;
                foreach (Status s in comboboxStatus.Items)
                {
                    if (s.Name == dataGridView.SelectedCells[2].Value.ToString())
                    {
                        comboboxStatus.SelectedItem = s;
                    }
                }
                //dataGridView.ClearSelection();
                btnUpdate.Text = "Save";
            }
            else if (btnUpdate.Text == "Save")
            {
                if (comboboxStatus.SelectedItem != null && txtboxTask.Text != String.Empty)
                {
                    var t = tmContext.Tasks.Find((int)dataGridView.SelectedCells[0].Value);

                    t.Name = txtboxTask.Text;
                    t.StatusId = (comboboxStatus.SelectedItem as Models.Status).Id;
                    t.DueDate = dateTime.Value;

                    tmContext.SaveChanges();

                    btnUpdate.Text = "Update";
                    txtboxTask.Text = String.Empty;
                    dateTime.Value = DateTime.Now;
                    comboboxStatus.Text = "Please select";
                    refreshData();
                }
                else
                {
                    MessageBox.Show("Please make sure all data has been entered!");
                };
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnUpdate.Text = "Update";
            txtboxTask.Text = String.Empty;
            dateTime.Value = DateTime.Now;
            comboboxStatus.Text = "Please select";
        }
    }
}
