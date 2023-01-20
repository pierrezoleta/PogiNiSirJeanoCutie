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
using TestLibrary;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Layout
{
    public partial class loginPage : Form
    {
        string connectionString = "Data Source=LAPTOP-NSL9DGV4\\SQLEXPRESS03;Initial Catalog=master;Integrated Security=True";
        String borrowerType;
        Boolean student;
        public loginPage(String borrowerType, Boolean student)
        {
            InitializeComponent();
            this.borrowerType = borrowerType;
            this.student = student;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string checkCredentialsQuery = "";
                if (borrowerType.Equals("Student")) {
                    checkCredentialsQuery = "SELECT * FROM [dbo].[Students] WHERE email = @email AND password = @password";
                } else if (borrowerType.Equals("Faculty"))
                {
                    checkCredentialsQuery = "SELECT * FROM [dbo].[Faculty] WHERE email = @email AND password = @password";
                }
                // Check if email and password match
               
                using (SqlCommand command = new SqlCommand(checkCredentialsQuery, connection))
                {
                    command.Parameters.AddWithValue("@email", txtEmail.Text);
                    command.Parameters.AddWithValue("@password", txtPassword.Text);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            // Email and password match
                            btnLogin.BackColor = Color.Green;
                            //return true;
                            Form1 frm1 = new Form1(txtEmail.Text, student);
                            frm1.ShowDialog();
                        }
                        else
                        {
                            // Email and password do not match
                            btnLogin.BackColor = Color.Red;
                            //return false;
                        }
                    }
                }



            }
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            if (borrowerType.Equals("Student"))
            {
                studentRegister sr = new studentRegister();

                // Show the other form as a modal dialog
                sr.ShowDialog();
            } else if (borrowerType.Equals("Faculty"))
            {
                facRegister sr = new facRegister();

                // Show the other form as a modal dialog
                sr.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
