using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestLibrary
{
    public partial class ListItem : UserControl
    {
        
        public ListItem()
        {
            InitializeComponent();
        }

        private void ListItem_Load(object sender, EventArgs e)
        {
           
        }

        #region Properties

        private string _title;
        private string _author;
        private Image _icon;
        private string _isbn;

        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; lbTitle.Text = value; }
        }

        [Category("Custom Props")]
        public string Author
        {
            get { return _author; }
            set { _author = value; lbAuthor.Text = value; }
        }


        [Category("Custom Props")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; pictureBox1.Image = value; }
        }

        [Category("Custom Props")]
        public string Isbn
        {
            get { return _isbn; }
            set { _isbn = value;  }
        }
        #endregion

        private void lbAuthor_Click(object sender, EventArgs e)
        {

        }

        private void ListItem_Click(object sender, EventArgs e)
        {
           
        }

        private void ListItem_MouseClick(object sender, MouseEventArgs e)
        {
            Form2 frm2 = new Form2();
            using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-NSL9DGV4\\SQLEXPRESS03;Initial Catalog=master;Integrated Security=True"))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT ISBM , BookName, AuthorLastName, AuthorFirstName, Category, DatePublished, Quantity FROM Book WHERE ISBM = @isbm", connection))
                {
                    command.Parameters.AddWithValue("@isbm", Isbn);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            frm2.Isbn = reader.GetString(0);
                            frm2.BooktTitle = reader.GetString(1);
                            frm2.AuthorLasttName = reader.GetString(2);
                            frm2.AuthorFirstName = reader.GetString(3); 
                            frm2.Category = reader.GetString(4);
                            DateTime dt = reader.GetDateTime(5);
                            frm2.DatePublished = dt;
                            frm2.Quantity = reader.GetInt32(6);

                        }
                    }
                }
            }


            frm2.Icon1 = pictureBox1.Image;



            //using (StreamReader reader = new StreamReader("Book.csv"))
            //{
            //    string line;
            //    //Console.WriteLine(reader.ReadToEnd());
            //    while ((line = reader.ReadLine()) != null)
            //    {
            //        string[] fields = line.Split(',');

            //        if (fields[0].Equals(Isbn)) 
            //        { 

            //            frm2.BooktTitle = Author;
            //            frm2.Isbn = fields[0];
            //        }

            //        Console.WriteLine(fields[0]);
            //        Console.WriteLine(fields[1]);

            //        // Create Read Update Delete
            //    }
            //}
            frm2.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Form2 frm2 = new Form2();
            using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-NSL9DGV4\\SQLEXPRESS03;Initial Catalog=master;Integrated Security=True"))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT ISBM , BookName, AuthorLastName, AuthorFirstName, Category, DatePublished, Quantity FROM Book WHERE ISBM = @isbm", connection))
                {
                    command.Parameters.AddWithValue("@isbm", Isbn);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            frm2.Isbn = reader.GetString(0);
                            frm2.BooktTitle = reader.GetString(1);
                            frm2.AuthorLasttName = reader.GetString(2);
                            frm2.AuthorFirstName = reader.GetString(3);
                            frm2.Category = reader.GetString(4);
                            DateTime dt = reader.GetDateTime(5);
                            frm2.DatePublished = dt;
                            frm2.Quantity = reader.GetInt32(6);

                        }
                    }
                }
            }


            frm2.Icon1 = pictureBox1.Image;



            
            frm2.ShowDialog();
        }

        private void lbTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
