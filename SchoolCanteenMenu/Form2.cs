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
    public partial class Form2 : Form
    {
        string textToShow;
       
        public Form2(string textData)
        {
            textToShow = textData;
            InitializeComponent();
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
            CheckBox[] currentChk = new CheckBox[6];
            currentChk[0] = chkCRolls;
            currentChk[1] = chkSPinwheel;
            currentChk[2] = chkCSwirl; ;
            currentChk[3] = chkSlice;
            currentChk[4] = chkBrownie;
            currentChk[5] = chkCPuff;

            int[] cost = { 4, 3, 3, 3, 3, 3 };

            for (int i=0; i< 6; i++)
            {
                if (currentChk[i].Checked == true && currentChk[i].Enabled)
                {
                    string food = currentChk[i].Text;
                    int indexOfFood = Array.IndexOf(currentChk, food);
                    int foodCost = cost [i];
                    lblMTea.Text = food;
                    lblMTea.Text += "\r\n" + food;
                    lblMTeaCost.Text = foodCost.ToString();
                }
            }
        }
    }
}
