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
using System.Data.SqlClient;

namespace Hospital_management
{
    public partial class Login : Form

        
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-H92Q174F;Initial Catalog=Hospital;Integrated Security=True");
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "select * from login where Username='" + usertxt.Text + "' and password='" + passtxt.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    mainForm frm=new mainForm();
                    this.Hide();
                    frm.ShowDialog();
                   
                
                }
                else
                {
                    MessageBox.Show("invalid login");
                    usertxt.Clear();
                    passtxt.Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An exception occured" + ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
