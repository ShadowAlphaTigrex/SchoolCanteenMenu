using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolCanteenMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            //Declaring the variables
            string name;
            string tutorclass;
            name = txtName.Text;
            tutorclass = txtTutorClass.Text;

            string textToSend = name;

            //When the textbox is not filled, it'll show an error message box//
            if (txtName.Text == "" || txtTutorClass.Text == "" )
            {
                MessageBox.Show("Please Enter Student Name and Tutor Class");
            }
            //After it's filled, it'll switch to another form//
            else
            {
                this.Hide();
                Form2 f2 = new Form2(name);
                f2.ShowDialog();
                this.Close();

            }
       
        }
    }
}
