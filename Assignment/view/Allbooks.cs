using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment.Views;

namespace Assignment.view
{
    public partial class Allbooks : Form
    {
        public Allbooks()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            int id = tBId.Text;
            string password = tbName.Text;
            var result = BookCintoller.book(id, Name);
            if (result! = null)
            {
                MessageBox.Show("Book Available");

            }
            else MessageBox.Show("Book Unavailable");


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Allbooks_Load(object sender, EventArgs e)
        {

        }
    }
}
