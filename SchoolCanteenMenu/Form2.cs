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
        CheckBox[] currentChk = new CheckBox[15];
        //RadioButton sandwichChoice = new RadioButton();
        int[] cost = { 4, 3, 3, 3, 3, 3, 4, 4, 4, 4, 4, 4, 4, 3, 3};
        int sum = 0;

        //Declaring a new list
        List<CheckBox> SelectedMenu = new List<CheckBox>();


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
            currentChk[6] = chkSandwichBCLO;
            currentChk[7] = chkSandwichHTELM;
            currentChk[8] = chkSandwichBLT;
            currentChk[9] = chkSandwichVege;
            currentChk[10] = chkSandwichCCSA;
            currentChk[11] = chkBagelSCAT;
            currentChk[12] = chkBagelTOCAT;
            currentChk[13] = chkMuffinSav;
            currentChk[14] = chkMuffinSwe;




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


        public void MTeaCheckBox_Checked(object sender, EventArgs e)
        {
            //The checkboxes that are checked are called "current"
            CheckBox current = sender as CheckBox;
            //The cost array follows the current (parallel array)
            int indexcurrent = Array.IndexOf(currentChk, current);
            //Declaring the variable for cost
            int price = cost[indexcurrent];
           
           
            //When it's checked, the selected items will be added in a list 
            if (current.Checked)
            {
                //When it's checked, the current (selected) checkbox will be added in a list 
                SelectedMenu.Add(current);
                //Displays the items in a list box 
                lbCOItems.Items.Add(current.Text);
                //It'll add the item's cost
                sum = price + sum;
                //Display the total cost of the selected items
                lblMTeaCost.Text = "\r\n" + "$" + sum.ToString();
            }
            //If it's not, then it'll be remove from the list. 
            else
            {
                //When it's unchecked, the current (unselected) checkbox will be remove from the list 
                SelectedMenu.Remove(current);
                //Removes the unselected item from the list box 
                lbCOItems.Items.Remove(current.Text);
                //It'll subtract the item's cost so it only display the selected item's total cost
                sum = sum - price;
                lblMTeaCost.Text = "\r\n" + "$" + sum.ToString();
            }

           //When the list has more than 3, the message box will show an error.
            if (SelectedMenu.Count > 3)
            {
                //Displays the message box for error
                MessageBox.Show("Only select 3 items.");
                //After message box is closed, it'll automatically unselect the checkboxes
                current.Checked = false;
            }
            //If not, nothing happens.
            else
            {  
            }
           
        }

       /* private void chkSandwich_Checked(object sender, EventArgs e)
        {
            
            if (chkSandwich.Checked)
            {
                grbSandwich.Enabled= true;
            }
            else
            {
                grbSandwich.Enabled = false;
            }
        }

        public void SandwichRbtn_Checked(object sender, EventArgs e)
        {
            RadioButton sanchoice = sender as RadioButton;
            if (sanchoice.Checked)
            {
                lbCOItems.Items.Add("Sandwich - $4 =" + sanchoice.Text);
            }
            else
            {
                lbCOItems.Items.Remove("Sandwich - $4 =" + sanchoice.Text);
            }
        } */

        










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
