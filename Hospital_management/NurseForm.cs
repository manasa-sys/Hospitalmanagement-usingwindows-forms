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
    public partial class NurseForm : Form
    {
        SqlConnection conn=new SqlConnection("Data Source=LAPTOP-H92Q174F;Initial Catalog=Hospital;Integrated Security=True");
        public NurseForm()
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
            cmd.CommandText = "select * from Nurses";
            cmd.ExecuteNonQuery();//runs the query
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            dataGridView.DataSource = dt;
            conn.Close();

        }
        private void button4_Click(object sender, EventArgs e)
        {
            mainForm from=new mainForm();
            from.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " INSERT INTO Nurses VALUES ('" + nfntxt.Text + "','" + nlntxt.Text + "','" + Convert.ToInt32(ndctxt.Text) + "','" + nidtxt.Text + "','" + Convert.ToInt32(nyoptxt.Text) + "','" + Convert.ToDouble(nshtxt.Text) + "','"+Convert.ToInt32(nnptxt.Text)+"')";
            cmd.ExecuteNonQuery();
            conn.Close();
            displayTable();
            MessageBox.Show("nurse has been added to the table");

            nfntxt.Clear();
            nlntxt.Clear();
            ndctxt.Clear();
            nidtxt.Clear();
            nyoptxt.Clear();
            nshtxt.Clear();
            nnptxt.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            displayTable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE Nurses SET firstname='" + nfntxt.Text + "', lastname='" + nlntxt.Text + "', deptcode='" + Convert.ToInt32(ndctxt.Text) + "',nurseId='" + nidtxt.Text + "',yearsofPractice='" + Convert.ToInt32(nyoptxt.Text) + "',shiftHours='" + Convert.ToDouble(nshtxt.Text) + "',numberofpatients='"+Convert.ToInt32(nnptxt.Text)+"' WHERE nurseId = '" + nidtxt.Text + "'";
            cmd.ExecuteNonQuery();
            conn.Close();
            displayTable();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM Nurses where nurseId='" + nidtxt.Text + "'";
            cmd.ExecuteNonQuery();
            conn.Close();
            displayTable();
            MessageBox.Show("nurse has been deleted");
        }

        private void button6_Click(object sender, EventArgs e)
        {

            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Nurses where nurseId='" + nidtxt.Text + "'";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            dataGridView.DataSource = dt;
            MessageBox.Show("nurse found");
            conn.Close();
        }
    }
}
