using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            
        }
        string connectionString = "Data Source=DESKTOP-NI6OT7O;Initial Catalog=STUDENT;Integrated Security=True";
        
        private void Form1_Load(object sender, EventArgs e)
        {
            GetStudentsRecord();
        }

        private void GetStudentsRecord()
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("Select * from Students", con);
            DataTable dt=new DataTable();
            con.Open();
            SqlDataReader sdr=cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            DGVIEW.DataSource = dt;
        }

        private void insert_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    using (SqlTransaction transaction = con.BeginTransaction())
                    {
                        try
                        {
                            SqlCommand cmd = new SqlCommand("Insert into Students values (@StudentId,@StudentName,@CGPA,@Semester)", con, transaction);
                            cmd.CommandType = CommandType.Text;
                            cmd.Parameters.AddWithValue("@StudentId", stdID.Text);
                            cmd.Parameters.AddWithValue("@StudentName", stdName.Text);
                            cmd.Parameters.AddWithValue("@CGPA", CGPA.Text);
                            cmd.Parameters.AddWithValue("@Semester", SEMESTER.Text);

                            cmd.ExecuteNonQuery();

                            transaction.Commit();

                            MessageBox.Show("Student added in db", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            GetStudentsRecord();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Failed to save student record: " + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
        private bool IsValid()
        {
            if (stdName.Text == String.Empty)
            {
                MessageBox.Show("student name required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (stdID.Text == String.Empty)
            {
                MessageBox.Show("student id required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (CGPA.Text == String.Empty)
            {
                MessageBox.Show("student cgpa required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (SEMESTER.Text == String.Empty)
            {
                MessageBox.Show("student semester required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void EDIT_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlTransaction transaction = con.BeginTransaction())
                    {
                        try
                        {
                            using (SqlCommand cmd = new SqlCommand("Update Students set StudentName=@StudentName,CGPA=@CGPA,Semester=@Semester where StudentId=@StudentId", con, transaction))
                            {
                                cmd.CommandType = CommandType.Text;
                                cmd.Parameters.AddWithValue("@StudentId", stdID.Text);
                                cmd.Parameters.AddWithValue("@StudentName", stdName.Text);
                                cmd.Parameters.AddWithValue("@CGPA", CGPA.Text);
                                cmd.Parameters.AddWithValue("@Semester", SEMESTER.Text);

                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();

                            MessageBox.Show("Student record updated in db", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            GetStudentsRecord();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Failed to update student record: " + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();
                try
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Students WHERE StudentId=@StudentId", con, transaction);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@StudentId", stdID.Text);

                    cmd.ExecuteNonQuery();
                    transaction.Commit();
                    MessageBox.Show("Record Deleted from db", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetStudentsRecord();
                    stdID.Clear();
                    stdName.Clear();
                    CGPA.Clear();
                    SEMESTER.Clear();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("An error occurred while deleting the record: " + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void CLEAR_Click(object sender, EventArgs e)
        {
            GetStudentsRecord();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void DGVIEW_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGVIEW_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                stdID.Text = DGVIEW.SelectedRows[0].Cells[0].Value.ToString();
                stdName.Text = DGVIEW.SelectedRows[0].Cells[1].Value.ToString();
                CGPA.Text = DGVIEW.SelectedRows[0].Cells[2].Value.ToString();
                SEMESTER.Text = DGVIEW.SelectedRows[0].Cells[3].Value.ToString();
            }
            catch
            {
                MessageBox.Show("chose correct Box");

            }
        }
    }
}
