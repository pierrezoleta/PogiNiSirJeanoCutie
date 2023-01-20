using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestLibrary;

namespace Layout
{
    public partial class chooseUser : Form
    {
        public chooseUser()
        {
            InitializeComponent();
        }

        private void btnBorrower_Click(object sender, EventArgs e)
        {
            loginPage form2 = new loginPage("Student", true);

            // Show the other form as a modal dialog
            form2.ShowDialog();
        }

        private void btnLibrarian_Click(object sender, EventArgs e)
        {
            loginPage form2 = new loginPage("Faculty", false);

            // Show the other form as a modal dialog
            form2.ShowDialog();
        }

        private void chooseUser_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard lp = new Dashboard();
            this.Visible = false;
            lp.ShowDialog();
        }
    }
}
