using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Admin : Form
    {
        List<Person> people = new List<Person>();
        public Admin()
        {
            InitializeComponent();

            UpdateBinding();
        }

        private void użytkownicyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void UpdateBinding()
        {
            UsersFounds.DataSource = people;
            UsersFounds.DisplayMember = "FullInfo";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            people = db.GetPeople(LastNameText.Text);

            UpdateBinding();
        }

        private void LastNameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void historiaKredytowaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            db.InsertPerson(FirstNameInsTxt.Text, LastNameInsTxt.Text, EmailAddressInsTxt.Text, LoginInsTxt.Text, PasswordInsTxt.Text);

            FirstNameInsTxt.Text = "";
            LastNameInsTxt.Text = "";
            EmailAddressInsTxt.Text = "";
            LoginInsTxt.Text = "";
            PasswordInsTxt.Text = "";


        }
    }
}
