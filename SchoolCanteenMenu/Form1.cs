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
        string[] tutorClass = { "ABH", "AJF", "AHB", "AWA", "BSA", "BLA", "BRI", "BGW", "HKA", "HML", "HMD", "HKI", "RWT", "RTH", "RHR", "RBN", "SMN", "SRO", "SDG", "SDA" };
    
        public Form1()
        {
            InitializeComponent();
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < tutorClass.Length; i++)
            {
                cmbTClass.Items.Add(tutorClass[i]);
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            //Declaring the variables
            string name;
            name = txtName.Text;
          

            string textToSend = "Student Info:" + "\r\n" + name +  "\r\n" + cmbTClass.Text;

            //When the name textbox is not filled and the tutor class is not selected from the combobox, it'll show an error message box//
            if (txtName.Text == ""||cmbTClass.Text=="")
            {
                MessageBox.Show("Please Enter Student Name and Tutor Class");
            }
            //After it's filled, it'll switch to another form//
            else
            {
                this.Hide();
                Form2 f2 = new Form2(textToSend);
                f2.ShowDialog();
                this.Close();

            }
      
        }

       
    }
}
