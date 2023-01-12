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

namespace Hospital_management
{
    public partial class PatientForm : Form
    {
        SqlConnection conn=new SqlConnection("Data Source=LAPTOP-H92Q174F;Initial Catalog=Hospital;Integrated Security=True");
        public PatientForm()
        {
            InitializeComponent();
        }

        void displayTable()
        {
            conn.Open();
            //aproach #1
            //SqlCommand cmd = new SqlCommand();
            //aproach #2

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Patients";
            cmd.ExecuteNonQuery();//runs the query
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            dataGridView.DataSource = dt;
            conn.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " INSERT INTO Patients VALUES ('" + pfntxt.Text + "','" + plntxt.Text + "','" +Convert.ToInt32 (pdctxt.Text) + "','" + pidtxt.Text + "','" + psntxt.Text + "','" + Convert.ToDouble(pbtxt.Text) + "','" + pdstxt.Text + "')";
            cmd.ExecuteNonQuery();
            conn.Close();
            displayTable();
            MessageBox.Show("patient has been added to the table");

            pfntxt.Clear();
            plntxt.Clear();
            pdctxt.Clear();
            pidtxt.Clear();
            psntxt.Clear();
            pbtxt.Clear();
            pdstxt.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mainForm from=new mainForm();
            from.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE Patients SET firstname='" + pfntxt.Text + "', lastname='" + plntxt.Text + "', deptcode='" + Convert.ToInt32(pdctxt.Text) + "',sectionNumber='"+ psntxt.Text+"',balance='"+ Convert.ToDouble(pbtxt.Text)+"',dischargestatus='"+pdstxt.Text+"' WHERE patientId = '" + pidtxt.Text + "'";
            cmd.ExecuteNonQuery();
            conn.Close();
            displayTable();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM Patients where patientId='" + pidtxt.Text + "'";
            cmd.ExecuteNonQuery();
            conn.Close();
            displayTable();
            MessageBox.Show("patient has been deleted");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            displayTable();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Patients where patientId='" + pidtxt.Text + "'";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            dataGridView.DataSource = dt;
            MessageBox.Show("patient found");
            conn.Close();

        }

        private void pfntxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
