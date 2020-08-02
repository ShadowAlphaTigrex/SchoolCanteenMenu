using System;
using System.Collections;
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
    public partial class Form2 : Form
    {
        string textToShow;
        CheckBox[] currentChk = new CheckBox[6];

        int[] cost = { 4, 3, 3, 3, 3, 3 };
        int sum = 0;
        int subtract;

        public Form2(string textData)
        {
            textToShow = textData;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            currentChk[0] = chkCRolls;
            currentChk[1] = chkSPinwheel;
            currentChk[2] = chkCSwirl; ;
            currentChk[3] = chkSlice;
            currentChk[4] = chkBrownie;
            currentChk[5] = chkCPuff;


            /* int indexCRolls = Array.IndexOf(currentChk, chkCRolls);
             int indexSPinwheel = Array.IndexOf(currentChk, chkSPinwheel);
             int indexCSwirl = Array.IndexOf(currentChk, chkCSwirl);
             int indexSlice = Array.IndexOf(currentChk, chkSlice);
             int indexBrownie = Array.IndexOf(currentChk, chkBrownie);
             int indexCPuff = Array.IndexOf(currentChk, chkCPuff);
             */
        }

        private void btnMTea_Click(object sender, EventArgs e)
        {
            //After the button is clicked, the Morning Tea group box 
            //enabled and the Lunch Week Selection group box is not visible
            grbTeaMenu.Enabled = true;
            grbLunchSelection.Enabled = false;
        }

        private void btnLunch_Click(object sender, EventArgs e)
        {
            //After the button is clicked, the Morning Tea group box 
            //disabled and the Lunch Week Selection group box is visible and enabled
            grbTeaMenu.Enabled = false;
            grbLunchSelection.Visible = true;
            grbLunchSelection.Enabled = true;

        }


        private void MTeaCheckBox_Checked(object sender, EventArgs e)
        {
            //The checkboxes that are checked are called "current"
            CheckBox current = sender as CheckBox;
            //The cost array follows the current (parallel array)
            int indexcurrent = Array.IndexOf(currentChk, current);
            //Declaring the variable for cost
            int price = cost[indexcurrent];
            //Declaring a new list
            List<CheckBox> SelectedMenu = new List<CheckBox>();
           
            //When it's checked, it'll be added in a list 
            if (current.Checked)
            {
                SelectedMenu.Add(current);
            }
            //If it's not, then it'll be remove
            else
            {
                SelectedMenu.Remove(current);
            }

           //When the list has more than 3, the label will be shown a text
            if (SelectedMenu.Count > 3)
            {
                label1.Text = "TOO MUCH";

            }
            //If not, it'll add the cost 
            else
            {
                sum = price + sum;
                lblMTeaCost.Text = "\r\n" + "$" + sum.ToString();
            }
            
        }


           /* if (current.Checked)
 
            {
                lbCOItems.Items.Add(current.Text);
                sum = price + sum;
                lblMTeaCost.Text = "\r\n" + "$" + sum.ToString();
            }

            else 
            {
                lbCOItems.Items.Remove(current.Text);
                subtract = sum - price;
                lblMTeaCost.Text = "$" + subtract.ToString();
               
            }
            */
            
        }
           
           
       
       

     
           








        /*List<int> numbers = new List<int>();
        int[] array = new int[] { 1, 2, 3 };





        for (int i=0; i< 6; i++)
        {
            if (currentChk[i].Checked == true && currentChk[i].Enabled)
            {
                string food = currentChk[i].Text;
                int indexOfFood = Array.IndexOf(currentChk, food);
                int foodCost = cost [i];
                lblMTea.Text = food;
                lblMTeaCost.Text = foodCost.ToString();
            }
        }
        */


    
}
