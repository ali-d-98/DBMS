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

namespace Ali
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conString = "data source=DESKTOP-S86R5UP;initial catalog=Ali-2;integrated security=True;MultipleActiveResultSets=True;";
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(
                    "insert into Person (first_name, last_name, national_id, age, city) values('" + Fname.Text + "', '" + Lname.Text + "', '" 
                    + NI.Text + "', '" + Ag.Text + "', '" + Ci.Text + "');",
                    connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        MessageBox.Show("Data inserted");
                       Fname.Text = "";
                       Lname.Text = "";
                       NI.Clear();
                       Ag.Clear();
                       Ci.Clear();
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string conString = "data source=DESKTOP-S86R5UP;initial catalog=Ali-2;integrated security=True;MultipleActiveResultSets=True;";
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(
                    "select * from Person;",
                    connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                result.Text += reader.GetValue(i) + " , ";
                            }
                            result.Text += "\r\n";  
                        }
                    }
                }
            }
        }
    }
}
