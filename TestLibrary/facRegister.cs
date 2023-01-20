using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Layout
{
    public partial class facRegister : Form
    {
        string firstName, lastName, email,   phoneNumber, password;
        Boolean validFirstName, validLastName, validEmail,  validPassword, validPhoneNumber, validConfirmPassword;

        string emailPattern = "^[A-Za-z]+\\.[A-Za-z]+@(?i)laspinas\\.sti\\.edu\\.ph$";
        
        string phoneNumberPattern = "^(\\+63|0)[9,8,7,3][0-9]{9}$";
        string namePattern = "^[a-zA-Z]{1,20}$";


        string connectionString = "Data Source=LAPTOP-NSL9DGV4\\SQLEXPRESS03;Initial Catalog=master;Integrated Security=True";

       

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals(txtConfirmPassword.Text))
            {
                lblConfirmPassword.ForeColor = Color.Green;
                validConfirmPassword = true;
            }
            else if (txtPassword.Text.Equals(""))
            {
                lblConfirmPassword.ForeColor = Color.Black;
                validConfirmPassword= false;
            }
            else
            {
                lblConfirmPassword.ForeColor = Color.Red;
                validConfirmPassword = false;
            }

        }

        string passwordPattern = "^(?=.*[!@#\\$%\\^&\\*])[A-Za-z0-9!@#\\$%\\^&\\*]{5,}$";

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtPassword.Text, passwordPattern))
            {
                lblPassword.ForeColor = Color.Green;
                validPassword = true;
            }
            else if (txtPassword.Text.Equals(""))
            {
                lblPassword.ForeColor = Color.Black;
                validPassword = false;
            }
            else
            {
                lblPassword.ForeColor = Color.Red;
                validPassword = false;
            }
        }

       

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtPhoneNumber.Text, phoneNumberPattern))
            {
                lblPhoneNumber.ForeColor = Color.Green;
                validPhoneNumber = true;
            }
            else if (txtPhoneNumber.Text.Equals(""))
            {
                lblPhoneNumber.ForeColor = Color.Black;
                validPhoneNumber = false;
            }
            else
            {
                lblPhoneNumber.ForeColor = Color.Red;
                validPhoneNumber = false;
            }
        }

        

      

       

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtEmail.Text, emailPattern))
            {
                lblEmail.ForeColor = Color.Green;
                validEmail= true;
                
                
            }
            else if (txtEmail.Text.Equals(""))
            {
                lblEmail.ForeColor = Color.Black;
                validEmail= false;
            }
            else
            {
                lblEmail.ForeColor = Color.Red;
                validEmail= false;
            }
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtLastName.Text, namePattern))
            {
                lblLastName.ForeColor = Color.Green;
                validLastName= true;
            }
            else if (txtLastName.Text.Equals(""))
            {
                lblLastName.ForeColor = Color.Black;
                validLastName= false;
            }
            else
            {
                lblLastName.ForeColor = Color.Red;
                validLastName= false;
            }
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtFirstName.Text, namePattern))
            {
                lblFirstName.ForeColor = Color.Green;
                validFirstName= true;
            }
            else if (txtFirstName.Text.Equals(""))
            {
                lblFirstName.ForeColor = Color.Black;
                validFirstName= false;
            }
            else
            {
                lblFirstName.ForeColor = Color.Red;
                validFirstName= false;
            }
        }

       

        public facRegister()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (validFirstName & validLastName & validEmail  & validPassword & validPhoneNumber &
                validConfirmPassword)
            {


                


               

                // Create a connection object
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open the connection
                    Boolean isTaken = false;
                    connection.Open();

                    string checkEmailExistsQuery = "SELECT * FROM [dbo].[Faculty] WHERE email = @email";
                    using (SqlCommand command = new SqlCommand(checkEmailExistsQuery, connection))
                    {
                        command.Parameters.AddWithValue("@email", txtEmail.Text);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                // Email already exists, do not insert new row
                                Console.WriteLine("is already taken bro try agian");
                                btnRegister.BackColor = Color.Red;
                                return;
                            }
                        }
                    }

                    btnRegister.BackColor = Color.Green;
                    /*
                    // Create a command object
                    using (SqlCommand command = new SqlCommand("SELECT Id, name, code FROM [dbo].[Table]", connection))
                    {
                        // Execute the command and retrieve the results
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Print out the results
                            while (reader.Read())
                            {
                                Console.WriteLine("Id: {0}, name: {1}, , code: {1}", reader["id"], reader["name"], reader["code"]);
                            }
                        }
                    }
                    */

                    string stmt = "SELECT COUNT(*) FROM [dbo].[Faculty]";
                    int count = 0;
                    using (SqlCommand cmdCount = new SqlCommand(stmt, connection))
                    {
                        
                        count = (int)cmdCount.ExecuteScalar();

                        String st = "INSERT INTO [dbo].[Faculty](Id,firstName,lastName, email,  phoneNumber, password) values " +
                            "(@Id, @firstName, @lastName, @email, @phoneNumber, @password)";





                        SqlCommand cmd = new SqlCommand(st, connection);
                        cmd.Parameters.AddWithValue("@Id", count+1);
                        cmd.Parameters.AddWithValue("@firstName", txtFirstName.Text);
                        cmd.Parameters.AddWithValue("@lastName", txtLastName.Text);
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                        
                        
                        cmd.Parameters.AddWithValue("@phoneNumber", txtPhoneNumber.Text);
                        cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                        
                        cmd.ExecuteNonQuery();
                    }


                    //SqlCommand cmd = new SqlCommand("DELETE FROM [dbo].[Table]" + " WHERE Id" + " = 2", connection);
                    //cmd.ExecuteNonQuery();

                   

                }


            }
            else
            {
                btnRegister.BackColor= Color.Red;
            }

        }
    }
}
