using Layout;
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
using static System.Net.WebRequestMethods;

namespace TestLibrary
{
    public partial class Dashboard : Form
    {

        SqlConnection connection = new SqlConnection("Data Source=LAPTOP-NSL9DGV4\\SQLEXPRESS03;Initial Catalog=master;Integrated Security=True");
        string imageUrl = null; // image

        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection3 = new SqlConnection("Data Source=LAPTOP-NSL9DGV4\\SQLEXPRESS03;Initial Catalog=master;Integrated Security=True"))
            {
                connection3.Open();

                // Convert Image
                Image img = pbBookImage.Image;
                byte[] arr;
                ImageConverter converter = new ImageConverter();
                arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
                MessageBox.Show("wer");

                SqlCommand cmd = new SqlCommand("INSERT INTO Book(ISBM, BookName, AuthorLastName, AuthorFirstName, Category, DatePublished, Quantity, Image) VALUES (@ISBM, @BookName, @AuthorLastName, @AuthorFirstName, @Category, @DatePublished, @Quantity, @Image)", connection3);
                cmd.Parameters.AddWithValue("@ISBM", tbISBM.Text);
                cmd.Parameters.AddWithValue("@BookName", tbBookName.Text);
                cmd.Parameters.AddWithValue("@AuthorLastName", tbAuthorFirstName.Text);
                cmd.Parameters.AddWithValue("@AuthorFirstName", tbAuthorLastName.Text);
                cmd.Parameters.AddWithValue("@Category", tbCategory.Text);
                cmd.Parameters.Add("@DatePublished", SqlDbType.Date).Value = dtDatePublished.Value.Date;
                cmd.Parameters.AddWithValue("@Quantity", tbQuantity.Text);
                cmd.Parameters.AddWithValue("@Image", arr);
                cmd.ExecuteNonQuery();

                tbISBM.Text = "";
                tbBookName.Text = "";
                tbAuthorFirstName.Text = "";
                tbAuthorLastName.Text = "";
                tbCategory.Text = "";
                dtDatePublished.Text = "";
                tbQuantity.Text = "";
                pbBookImage.Image = null;

                MessageBox.Show("Successfully Inserted");

                connection3.Close();
                loadDataGrid();
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            loadDataGrid();
            loadBorrowTableGrid();

        }

        private void loadDataGrid() {
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Book", connection))
            {
                connection.Open();
                DataTable booksTable = new DataTable();
                adapter.Fill(booksTable);
                dbBooks.DataSource = booksTable;
                connection.Close();
            }
        }

        private void loadBorrowTableGrid()
        {
            List<Tuple<int, int, string>> data = new List<Tuple<int, int, string>>(); ;
            

            using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-NSL9DGV4\\SQLEXPRESS03;Initial Catalog=master;Integrated Security=True"))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT Id, Email, DATEDIFF(day, BorrowedDate, GETDATE()) as days_difference FROM BorrowTable", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string email = reader.GetString(1);
                            int days_difference = reader.GetInt32(2);

                            // Store the data in a list
                            
                            data.Add(new Tuple<int, int, string>(id, days_difference, email));
                        }
                    }
                }

                // Update the table
                foreach (var item in data)
                {
                    using (SqlCommand cmd = new SqlCommand("UPDATE BorrowTable SET DaysLeft = @DaysLeft, Late = @Late WHERE Id = @Id", connection))
                    {
                        cmd.Parameters.AddWithValue("@Id", item.Item1);
                        cmd.Parameters.AddWithValue("@DaysLeft", item.Item2);
                        bool hasNumbers = System.Text.RegularExpressions.Regex.IsMatch(item.Item3, @"[0-9]");

                        if (hasNumbers)
                        {
                            if (item.Item2 > 7)
                            {
                                cmd.Parameters.AddWithValue("@Late", "true");
                            }
                            else {
                                cmd.Parameters.AddWithValue("@Late", "false");
                            }
                        }
                        else
                        {
                            if (item.Item2 > 14)
                            {
                                cmd.Parameters.AddWithValue("@Late", "true");
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue("@Late", "false");
                            }
                        }

                        cmd.ExecuteNonQuery();
                    }
                }
                // Populate 
                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM BorrowTable", connection))
                {
                    DataTable booksTable = new DataTable();
                    adapter.Fill(booksTable);
                    dbBorrowTable.DataSource = booksTable;

                }
                connection.Close();
            }
        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imageUrl = ofd.FileName;
                    pbBookImage.Image = Image.FromFile(ofd.FileName);
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
                using (SqlConnection connection1 = new SqlConnection("Data Source=LAPTOP-NSL9DGV4\\SQLEXPRESS03;Initial Catalog=master;Integrated Security=True"))
                {
                    connection1.Open();

                    SqlCommand cmd = new SqlCommand("DELETE FROM Book WHERE ISBM = @isbm", connection1);
                    cmd.Parameters.AddWithValue("@isbm", tbISBM.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Deleted");
                    connection1.Close();
                tbISBM.Text = "";
                tbBookName.Text = "";
                tbAuthorFirstName.Text = "";
                tbAuthorLastName.Text = "";
                tbCategory.Text = "";
                dtDatePublished.Text = "";
                tbQuantity.Text = "";
                pbBookImage.Image = null;

                loadDataGrid();
                }
            }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection1 = new SqlConnection("Data Source=LAPTOP-NSL9DGV4\\SQLEXPRESS03;Initial Catalog=master;Integrated Security=True"))
            {
                connection1.Open();
                byte[] arr = null;
                if (pbBookImage.Image != null)
                {
                    Image img = pbBookImage.Image;
                    ImageConverter converter = new ImageConverter();
                    arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
                    MessageBox.Show("shpw");

                }

                //if (pbBookImage.Image != null)
                //{
                //    cmd = new SqlCommand("UPDATE Book SET BookName = @BookName, AuthorLastName = @AuthorLastName, AuthorFirstName = @AuthorFirstName, Category = @Category, DatePublished = @DatePublished, Quantity = @Quantity, Image = @Image WHERE ISBM = @isbm", connection1);
                //    cmd.Parameters.AddWithValue("@ISBM", tbISBM.Text);
                //    cmd.Parameters.AddWithValue("@BookName", tbBookName.Text);
                //    cmd.Parameters.AddWithValue("@AuthorLastName", tbAuthorFirstName.Text);
                //    cmd.Parameters.AddWithValue("@AuthorFirstName", tbAuthorLastName.Text);
                //    cmd.Parameters.AddWithValue("@Category", tbCategory.Text);
                //    cmd.Parameters.Add("@DatePublished", SqlDbType.Date).Value = dtDatePublished.Value.Date;
                //    cmd.Parameters.AddWithValue("@Quantity", tbQuantity.Text);
                //    cmd.Parameters.AddWithValue("@Image", arr);
                //    cmd.ExecuteNonQuery();

                //}
                //else
                //{
                SqlCommand cmd = new SqlCommand("UPDATE Book SET BookName = @BookName, AuthorLastName = @AuthorLastName, AuthorFirstName = @AuthorFirstName, Category = @Category, DatePublished = @DatePublished, Quantity = @Quantity WHERE ISBM = @isbm", connection1);
                    cmd.Parameters.AddWithValue("@ISBM", tbISBM.Text);
                    cmd.Parameters.AddWithValue("@BookName", tbBookName.Text);
                    cmd.Parameters.AddWithValue("@AuthorLastName", tbAuthorFirstName.Text);
                    cmd.Parameters.AddWithValue("@AuthorFirstName", tbAuthorLastName.Text);
                    cmd.Parameters.AddWithValue("@Category", tbCategory.Text);
                    cmd.Parameters.Add("@DatePublished", SqlDbType.Date).Value = dtDatePublished.Value.Date;
                    cmd.Parameters.AddWithValue("@Quantity", tbQuantity.Text);
                    cmd.ExecuteNonQuery();
                //}


                tbISBM.Text = "";
                tbBookName.Text = "";
                tbAuthorFirstName.Text = "";
                tbAuthorLastName.Text = "";
                tbCategory.Text = "";
                dtDatePublished.Text = "";
                tbQuantity.Text = "";
                pbBookImage.Image = null;

                MessageBox.Show("Successfully Updated");
                connection1.Close();

                loadDataGrid();
            }
        }

        private void dbBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                int selectRow = dbBooks.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = dbBooks.Rows[selectRow];  

                string ISBM = selectedRow.Cells[0].Value + string.Empty;
                string BookName = selectedRow.Cells[1].Value + string.Empty;
                string AuthorFirstName = selectedRow.Cells[2].Value + string.Empty;
                string AuthorLastName = selectedRow.Cells[3].Value + string.Empty;
                string Category = selectedRow.Cells[4].Value + string.Empty;
                string DatePublished = selectedRow.Cells[5].Value + string.Empty;
                string Quantity = selectedRow.Cells[6].Value + string.Empty;
                DataGridViewImageCell imageCell = (DataGridViewImageCell)selectedRow.Cells[8];

            if (imageCell.Value != null && (selectRow != (dbBooks.RowCount - 1)))
            {
                byte[] data = (byte[])imageCell.Value;

                using (MemoryStream ms = new MemoryStream(data))
                {
                    Image image = Image.FromStream(ms);
                    //save image to variable or display it
                    pbBookImage.Image = image;
                }
            }

           




            tbISBM.Text = ISBM;
                tbBookName.Text = BookName;
                tbAuthorFirstName.Text = AuthorFirstName;
                tbAuthorLastName.Text = AuthorLastName;
                tbCategory.Text = Category;
                dtDatePublished.Text = DatePublished;
                tbQuantity.Text = Quantity;
        }

        private void dbBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void plBookTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            plBookTable.Visible = true;
            plBorrowBook.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            plBookTable.Visible = false;
            plBorrowBook.Visible = true;
        }

        private void btnSignout_Click(object sender, EventArgs e)
        {
            this.Hide();
            var cu = new chooseUser();
            cu.Closed += (s, args) => this.Close();
            cu.Show();

        }
    }
    }