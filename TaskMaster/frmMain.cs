using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace TaskMaster
{
    public partial class frmMain : Form
    {
        SqlConnection Connection;
        string ConnectionString;

        public frmMain()
        {
            InitializeComponent();

            ConnectionString = ConfigurationManager.ConnectionStrings["TaskMaster.Properties.Settings.TaskMasterConnectionString"].ConnectionString;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            PopulateAllTasks();
            PopulateCurrentTasks();
        }

        private void PopulateAllTasks()
        {
            using (Connection = new SqlConnection(ConnectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM AllTasks", Connection))
            {
                DataTable AllTaskTable = new DataTable();
                adapter.Fill(AllTaskTable);

                lstAllTasks.DisplayMember = "Description";
                lstAllTasks.ValueMember = "Id";
                lstAllTasks.DataSource = AllTaskTable;
            }
        }
        private void PopulateCurrentTasks()
        {
            string query = "SELECT Description, BaseDate FROM AllTasks " +
                "WHERE BaseDate IN (DATEADD(DD, -1, CAST(CURRENT_TIMESTAMP AS DATE)), DATEADD(DD, -4, CAST(CURRENT_TIMESTAMP AS DATE)), DATEADD(DD, -10, CAST(CURRENT_TIMESTAMP AS DATE)), DATEADD(DD, -30, CAST(CURRENT_TIMESTAMP AS DATE)) , DATEADD(DD, -90, CAST(CURRENT_TIMESTAMP AS DATE)))";

            using (Connection = new SqlConnection(ConnectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, Connection))
            {
                DataTable CurrentTaskTable = new DataTable();
                adapter.Fill(CurrentTaskTable);

                lstCurrentTasks.DisplayMember = "Description";
                lstCurrentTasks.ValueMember = "Id";
                lstCurrentTasks.DataSource = CurrentTaskTable;
            }
        }
        private void lstAllTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(lstAllTasks.SelectedValue.ToString());
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO AllTasks VALUES (@TaskDescription, CAST(CURRENT_TIMESTAMP AS DATE))";
            using (Connection = new SqlConnection(ConnectionString))
            using (SqlCommand command = new SqlCommand(query, Connection))
            {
                Connection.Open();
                command.Parameters.AddWithValue("@TaskDescription", txtTaskDescription.Text);

                command.ExecuteNonQuery();
            }
            txtTaskDescription.Text = string.Empty;
            PopulateAllTasks();
        }

        private void btnUpdateTaskDescription_Click(object sender, EventArgs e)
        {
            string query = "UPDATE AllTasks SET Description = @TaskDescription WHERE Id = @TaskId";
            using (Connection = new SqlConnection(ConnectionString))
            using (SqlCommand command = new SqlCommand(query, Connection))
            {
                Connection.Open();
                command.Parameters.AddWithValue("@TaskDescription", txtTaskDescription.Text);
                command.Parameters.AddWithValue("@TaskId", lstAllTasks.SelectedValue);

                command.ExecuteNonQuery();
            }
            txtTaskDescription.Text = string.Empty;
            PopulateAllTasks();
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM AllTasks";
            using (Connection = new SqlConnection(ConnectionString))
            using (SqlCommand command = new SqlCommand(query, Connection))
            {
                Connection.Open();
                command.ExecuteNonQuery();
            }
            txtTaskDescription.Text = string.Empty;
            PopulateAllTasks();
        }
    }
}
