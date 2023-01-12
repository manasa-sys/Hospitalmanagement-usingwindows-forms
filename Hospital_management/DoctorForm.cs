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
    public partial class DoctorForm : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-H92Q174F;Initial Catalog=Hospital;Integrated Security=True");
        public DoctorForm()
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
            cmd.CommandText = "select * from Doctors";
            cmd.ExecuteNonQuery();//runs the query
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            dataGridView.DataSource = dt;
            conn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " INSERT INTO Doctors VALUES ('" + dfntxt.Text + "','" + dlntxt.Text + "','" + Convert.ToInt32(ddctxt.Text) + "','" + didtxt.Text + "','" + Convert.ToInt32(dyoptxt.Text )+ "','" + Convert.ToDouble(dshtxt.Text) + "')";
            cmd.ExecuteNonQuery();
            conn.Close();
            displayTable();
            MessageBox.Show("doctor has been added to the table");

            dfntxt.Clear();
            dlntxt.Clear();
            ddctxt.Clear();
            didtxt.Clear();
            dyoptxt.Clear();
            dshtxt.Clear();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mainForm from=new mainForm();
            this.Hide();
            from.ShowDialog();
        }

       /* private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE Doctors SET firstname='" + dfntxt.Text + "', lastname='" + dlntxt.Text + "', deptcode='" + Convert.ToInt32(ddctxt.Text) + "',yrsofPractice='" + Convert.ToInt32(dyoptxt.Text) + "',shifthours='" +Convert.ToDouble( dshtxt.Text) + "' WHERE doctorId = '" + didtxt.Text + "'";
            cmd.ExecuteNonQuery();
            conn.Close();
            displayTable();

        }*/

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM Doctors where doctorId='" + didtxt.Text + "'";
            cmd.ExecuteNonQuery();
            conn.Close();
            displayTable();
            MessageBox.Show("doctor has been deleted");
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
            cmd.CommandText = "SELECT * FROM Doctors where doctorId='" + didtxt.Text + "'";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            dataGridView.DataSource = dt;
            MessageBox.Show("doctor found");
            conn.Close();
        }
    }
}
