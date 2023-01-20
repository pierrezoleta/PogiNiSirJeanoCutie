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

namespace TestLibrary
{
    public partial class Form2 : Form
    {
        private string _isbn;
        private string _bookName;
        private string _authorFirstName;
        private string _authorLastName;
        private string _category;
        private int _quantity;
        private DateTime _datePublished;


        public Form2()
        {

            InitializeComponent();
        }
        public string Isbn
        {
            get { return _isbn; }
            set { _isbn = value; lbIsbm.Text = value; }
        }
        public string BooktTitle
        {
            get { return _bookName; }
            set { _bookName = value; lbBookName.Text = value; }
        }

        public string AuthorFirstName
        {
            get { return _authorFirstName; }
            set { _authorFirstName = value; lbAuthorFirstName.Text = value; }
        }

        public string AuthorLasttName
        {
            get { return _authorLastName; }
            set { _authorLastName = value; lbAuthorLastName.Text = value; }
        }

        public string Category
        {
            get { return _category; }
            set { _category = value; lbCategory.Text = value; }
        }


        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; lbQuantity.Text = value.ToString(); }
        }


        public DateTime DatePublished
        {
            get { return _datePublished; }
            set { _datePublished = value; }
        }



        private Image _icon1;

        public Image Icon1
        {
            get { return _icon1; }
            set { _icon1 = pictureBox1.Image = value; }
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string contactNum = "";
            int count = 0;
            using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-NSL9DGV4\\SQLEXPRESS03;Initial Catalog=master;Integrated Security=True"))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM BorrowTable WHERE Email = @email", connection))
                {
                    command.Parameters.AddWithValue("@email", Form1.StudentEmail);
                    count = (int)command.ExecuteScalar();
                    // do something with the count
                }

                if (count < 3 )
                {
                    if (Form1.IsStudent )
                    {
                        using (SqlCommand command = new SqlCommand("SELECT phoneNumber FROM Students WHERE email = @email", connection))
                        {
                            command.Parameters.AddWithValue("@email", Form1.StudentEmail);
                            MessageBox.Show(Form1.StudentEmail.ToString());
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    contactNum = reader.GetString(0);
                                    // do something with the contactNumber
                                }
                            }
                        }
                    }
                    else
                    {
                        using (SqlCommand command = new SqlCommand("SELECT phoneNumber FROM Faculty WHERE email = @email", connection))
                        {
                            command.Parameters.AddWithValue("@email", Form1.StudentEmail);
                            MessageBox.Show(Form1.StudentEmail.ToString());
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    contactNum = reader.GetString(0);
                                    // do something with the contactNumber
                                }
                            }
                        }
                    }

                    

                    using (SqlCommand command = new SqlCommand("INSERT INTO BorrowTable (Email, ISBM, BorrowedDate, FirstName, LastName, ContactNumber) VALUES (@Email, @ISBM, @BorrowedDate, @FirstName, @LastName, @ContactNumber)", connection))
                    {
                        command.Parameters.AddWithValue("@Email", Form1.StudentEmail);
                        command.Parameters.AddWithValue("@ISBM", lbIsbm.Text);
                        command.Parameters.AddWithValue("@BorrowedDate", DateTime.Now);
                        command.Parameters.AddWithValue("@FirstName", lbAuthorFirstName.Text);
                        command.Parameters.AddWithValue("@LastName", lbAuthorLastName.Text);
                        command.Parameters.AddWithValue("@ContactNumber", contactNum);
                        int rowsAffected = command.ExecuteNonQuery();
                    }
                }
                else
                {
                    MessageBox.Show("No more books pls");
                }
               connection.Close();
            }
        }

        private void lbAuthorLastName_Click(object sender, EventArgs e)
        {

        }

        private void lbQuantity_Click(object sender, EventArgs e)
        {

        }
    }
}  