using Layout;
using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TestLibrary
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=LAPTOP-NSL9DGV4\\SQLEXPRESS03;Initial Catalog=master;Integrated Security=True");

        public static string StudentEmail;
        public static Boolean IsStudent;
        ArrayList cartList = new ArrayList();  

        ListItem[] listItems = new ListItem[20];
        string imageUrl = null; // image
        public Form1(string studentEmail, Boolean isStudent)
        {
            StudentEmail = studentEmail;
            IsStudent = isStudent;
            InitializeComponent();
        }




        private void listItem1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            populateItems();
            populateItems2();


        }

        private void populateItems()
        {
            //populate items
            flowLayoutPanel1.Controls.Clear();
            using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-NSL9DGV4\\SQLEXPRESS03;Initial Catalog=master;Integrated Security=True"))
            {
                // Open the connection
                connection.Open();

                // Create a command object
                using (SqlCommand command = new SqlCommand("SELECT ISBM, BookName, AuthorLastName, Image, Quantity FROM [dbo].[Book] ORDER BY DatePublished DESC", connection))
                {
                    // Execute the command and retrieve the results
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Print out the results
                        while (reader.Read())
                        {
                            Console.WriteLine("isbm: {0}, bookName: {1}, authorLastName: {2}, image: {3}", reader["isbm"], reader["bookName"], reader["authorLastName"], reader["image"]);
                            ListItem li = new ListItem();

                            li.Isbn = reader.GetString(0);
                            li.Title = reader.GetString(1);
                            li.Author = reader.GetString(2);
                            byte[] data = (byte[])reader[3];
                            int Quantity = reader.GetInt32(4);

                            using (MemoryStream ms = new MemoryStream(data))
                            {
                                Image image = Image.FromStream(ms);
                                //save image to variable or display it
                                li.Icon = image;
                            }

                            if (Quantity > 0)
                            {
                                //add to flowlayout
                                flowLayoutPanel1.Controls.Add(li);
                            }


                        }
                    }
                }

                connection.Close();
            }
        }
        private void populateItems2()
        {
            //populate items
            flowLayoutPanel2.Controls.Clear();
            using (SqlConnection connection1 = new SqlConnection("Data Source=LAPTOP-NSL9DGV4\\SQLEXPRESS03;Initial Catalog=master;Integrated Security=True"))
            {
                // Open the connection
                connection1.Open();

                // Create a command object
                using (SqlCommand command1 = new SqlCommand("SELECT ISBM, BookName, AuthorLastName, Image, Quantity FROM [dbo].[Book] ORDER BY DatePublished ASC", connection1))
                {
                    // Execute the command and retrieve the results
                    using (SqlDataReader reader = command1.ExecuteReader())
                    {
                        // Print out the results
                        while (reader.Read())
                        {
                            Console.WriteLine("isbm: {0}, bookName: {1}, authorLastName: {2}, image: {3}", reader["isbm"], reader["bookName"], reader["authorLastName"], reader["image"]);
                            ListItem li = new ListItem();
                            li.Isbn = reader.GetString(0);
                            li.Title = reader.GetString(1);
                            li.Author = reader.GetString(2);
                            byte[] data = (byte[])reader[3];
                            int Quantity = reader.GetInt32(4);

                            using (MemoryStream ms = new MemoryStream(data))
                            {
                                Image image = Image.FromStream(ms);
                                //save image to variable or display it
                                li.Icon = image;
                            }

                            if (Quantity > 0)
                            {
                                //add to flowlayout
                                flowLayoutPanel2.Controls.Add(li);
                            }

                        }
                    }
                }

                connection1.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Filter
            if (comboBox1.SelectedItem.ToString().Equals("Date (Newest-Oldest)"))
            {
                //populate items
                flowLayoutPanel1.Controls.Clear();
                using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-NSL9DGV4\\SQLEXPRESS03;Initial Catalog=master;Integrated Security=True"))
                {
                    // Open the connection
                    connection.Open();

                    // Create a command object
                    using (SqlCommand command = new SqlCommand("SELECT ISBM, BookName, AuthorLastName, Image, Quantity FROM [dbo].[Book] ORDER BY DatePublished ASC", connection))
                    {
                        // Execute the command and retrieve the results
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Print out the results
                            while (reader.Read())
                            {
                                Console.WriteLine("isbm: {0}, bookName: {1}, authorLastName: {2}, image: {3}", reader["isbm"], reader["bookName"], reader["authorLastName"], reader["image"]);
                                ListItem li = new ListItem();

                                li.Isbn = reader.GetString(0);
                                li.Title = reader.GetString(1);
                                li.Author = reader.GetString(2);
                                byte[] data = (byte[])reader[3];
                                int Quantity = reader.GetInt32(4);

                                using (MemoryStream ms = new MemoryStream(data))
                                {
                                    Image image = Image.FromStream(ms);
                                    //save image to variable or display it
                                    li.Icon = image;
                                }

                                if (Quantity > 0)
                                {
                                    //add to flowlayout
                                    flowLayoutPanel1.Controls.Add(li);
                                }

                               
                            }
                        }
                    }

                    connection.Close();
                }
            }
            else if (comboBox1.SelectedItem.ToString().Equals("Date (Oldest-Newest)"))
            {
                //populate items
                flowLayoutPanel1.Controls.Clear();
                using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-NSL9DGV4\\SQLEXPRESS03;Initial Catalog=master;Integrated Security=True"))
                {
                    // Open the connection
                    connection.Open();

                    // Create a command object
                    using (SqlCommand command = new SqlCommand("SELECT ISBM, BookName, AuthorLastName, Image, Quantity FROM [dbo].[Book] ORDER BY DatePublished DESC", connection))
                    {
                        // Execute the command and retrieve the results
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Print out the results
                            while (reader.Read())
                            {
                                Console.WriteLine("isbm: {0}, bookName: {1}, authorLastName: {2}, image: {3}", reader["isbm"], reader["bookName"], reader["authorLastName"], reader["image"]);
                                ListItem li = new ListItem();

                                li.Isbn = reader.GetString(0);
                                li.Title = reader.GetString(1);
                                li.Author = reader.GetString(2);
                                byte[] data = (byte[])reader[3];
                                int Quantity = reader.GetInt32(4);

                                using (MemoryStream ms = new MemoryStream(data))
                                {
                                    Image image = Image.FromStream(ms);
                                    //save image to variable or display it
                                    li.Icon = image;
                                }

                                if (Quantity > 0)
                                {
                                    //add to flowlayout
                                    flowLayoutPanel1.Controls.Add(li);
                                }
                            }
                        }
                    }

                    connection.Close();
                }
            }
            else if (comboBox1.SelectedItem.ToString().Equals("Category (A-Z)"))
            {
                //populate items
                flowLayoutPanel1.Controls.Clear();
                using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-NSL9DGV4\\SQLEXPRESS03;Initial Catalog=master;Integrated Security=True"))
                {
                    // Open the connection
                    connection.Open();

                    // Create a command object
                    using (SqlCommand command = new SqlCommand("SELECT ISBM, BookName, AuthorLastName, Image, Quantity FROM [dbo].[Book] ORDER BY Category ASC", connection))
                    {
                        // Execute the command and retrieve the results
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Print out the results
                            while (reader.Read())
                            {
                                Console.WriteLine("isbm: {0}, bookName: {1}, authorLastName: {2}, image: {3}", reader["isbm"], reader["bookName"], reader["authorLastName"], reader["image"]);
                                ListItem li = new ListItem();

                                li.Isbn = reader.GetString(0);
                                li.Title = reader.GetString(1);
                                li.Author = reader.GetString(2);
                                byte[] data = (byte[])reader[3];
                                int Quantity = reader.GetInt32(4);

                                using (MemoryStream ms = new MemoryStream(data))
                                {
                                    Image image = Image.FromStream(ms);
                                    //save image to variable or display it
                                    li.Icon = image;
                                }

                                if (Quantity > 0)
                                {
                                    //add to flowlayout
                                    flowLayoutPanel1.Controls.Add(li);
                                }
                            }
                        }
                    }

                    connection.Close();
                }
            }
            else if (comboBox1.SelectedItem.ToString().Equals("Author (A-Z)"))
            {
                //populate items
                flowLayoutPanel1.Controls.Clear();
                using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-NSL9DGV4\\SQLEXPRESS03;Initial Catalog=master;Integrated Security=True"))
                {
                    // Open the connection
                    connection.Open();

                    // Create a command object
                    using (SqlCommand command = new SqlCommand("SELECT ISBM, BookName, AuthorLastName, Image, Quantity FROM [dbo].[Book] ORDER BY AuthorLastName ASC", connection))
                    {
                        // Execute the command and retrieve the results
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Print out the results
                            while (reader.Read())
                            {
                                Console.WriteLine("isbm: {0}, bookName: {1}, authorLastName: {2}, image: {3}", reader["isbm"], reader["bookName"], reader["authorLastName"], reader["image"]);
                                ListItem li = new ListItem();

                                li.Isbn = reader.GetString(0);
                                li.Title = reader.GetString(1);
                                li.Author = reader.GetString(2);
                                byte[] data = (byte[])reader[3];
                                int Quantity = reader.GetInt32(4);

                                using (MemoryStream ms = new MemoryStream(data))
                                {
                                    Image image = Image.FromStream(ms);
                                    //save image to variable or display it
                                    li.Icon = image;
                                }

                                if (Quantity > 0)
                                {
                                    //add to flowlayout
                                    flowLayoutPanel1.Controls.Add(li);
                                }
                            }
                        }
                    }
                    connection.Close();
                }
            }

        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            this.Hide();
            //var cu = new chooseUser();
            //cu.Closed += (s, args) => this.Close();
            //cu.Show();


        }
    }
}