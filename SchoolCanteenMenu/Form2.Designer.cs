namespace SchoolCanteenMenu
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbSelectMenu = new System.Windows.Forms.GroupBox();
            this.btnLunch = new System.Windows.Forms.Button();
            this.grbLunchSelection = new System.Windows.Forms.GroupBox();
            this.btnWeek2 = new System.Windows.Forms.Button();
            this.btnWeek1 = new System.Windows.Forms.Button();
            this.btnMTea = new System.Windows.Forms.Button();
            this.grbTeaMenu = new System.Windows.Forms.GroupBox();
            this.chkCPuff = new System.Windows.Forms.CheckBox();
            this.chkBrownie = new System.Windows.Forms.CheckBox();
            this.chkSlice = new System.Windows.Forms.CheckBox();
            this.chkCSwirl = new System.Windows.Forms.CheckBox();
            this.chkSPinwheel = new System.Windows.Forms.CheckBox();
            this.chkCRolls = new System.Windows.Forms.CheckBox();
            this.chkBagel = new System.Windows.Forms.CheckBox();
            this.grbBagel = new System.Windows.Forms.GroupBox();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.grbSandwich = new System.Windows.Forms.GroupBox();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.grbMuffin = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.chkMuffin = new System.Windows.Forms.CheckBox();
            this.grbLunchMenu = new System.Windows.Forms.GroupBox();
            this.lblMTeaCost = new System.Windows.Forms.Label();
            this.lbCOItems = new System.Windows.Forms.ListBox();
            this.grbList = new System.Windows.Forms.GroupBox();
            this.chkSandwich = new System.Windows.Forms.CheckBox();
            this.grbSelectMenu.SuspendLayout();
            this.grbLunchSelection.SuspendLayout();
            this.grbTeaMenu.SuspendLayout();
            this.grbBagel.SuspendLayout();
            this.grbSandwich.SuspendLayout();
            this.grbMuffin.SuspendLayout();
            this.grbList.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbSelectMenu
            // 
            this.grbSelectMenu.Controls.Add(this.btnLunch);
            this.grbSelectMenu.Controls.Add(this.grbLunchSelection);
            this.grbSelectMenu.Controls.Add(this.btnMTea);
            this.grbSelectMenu.Location = new System.Drawing.Point(12, 12);
            this.grbSelectMenu.Name = "grbSelectMenu";
            this.grbSelectMenu.Size = new System.Drawing.Size(226, 191);
            this.grbSelectMenu.TabIndex = 0;
            this.grbSelectMenu.TabStop = false;
            this.grbSelectMenu.Text = "Select Menu ";
            // 
            // btnLunch
            // 
            this.btnLunch.Location = new System.Drawing.Point(17, 48);
            this.btnLunch.Name = "btnLunch";
            this.btnLunch.Size = new System.Drawing.Size(83, 23);
            this.btnLunch.TabIndex = 1;
            this.btnLunch.Text = "Lunch ";
            this.btnLunch.UseVisualStyleBackColor = true;
            this.btnLunch.Click += new System.EventHandler(this.btnLunch_Click);
            // 
            // grbLunchSelection
            // 
            this.grbLunchSelection.Controls.Add(this.btnWeek2);
            this.grbLunchSelection.Controls.Add(this.btnWeek1);
            this.grbLunchSelection.Location = new System.Drawing.Point(17, 88);
            this.grbLunchSelection.Name = "grbLunchSelection";
            this.grbLunchSelection.Size = new System.Drawing.Size(127, 86);
            this.grbLunchSelection.TabIndex = 0;
            this.grbLunchSelection.TabStop = false;
            this.grbLunchSelection.Text = "Week";
            this.grbLunchSelection.Visible = false;
            // 
            // btnWeek2
            // 
            this.btnWeek2.Location = new System.Drawing.Point(26, 48);
            this.btnWeek2.Name = "btnWeek2";
            this.btnWeek2.Size = new System.Drawing.Size(75, 23);
            this.btnWeek2.TabIndex = 3;
            this.btnWeek2.Text = "Week 2";
            this.btnWeek2.UseVisualStyleBackColor = true;
            // 
            // btnWeek1
            // 
            this.btnWeek1.Location = new System.Drawing.Point(26, 19);
            this.btnWeek1.Name = "btnWeek1";
            this.btnWeek1.Size = new System.Drawing.Size(75, 23);
            this.btnWeek1.TabIndex = 2;
            this.btnWeek1.Text = "Week 1";
            this.btnWeek1.UseVisualStyleBackColor = true;
            // 
            // btnMTea
            // 
            this.btnMTea.Location = new System.Drawing.Point(17, 19);
            this.btnMTea.Name = "btnMTea";
            this.btnMTea.Size = new System.Drawing.Size(83, 23);
            this.btnMTea.TabIndex = 0;
            this.btnMTea.Text = "Morning Tea ";
            this.btnMTea.UseVisualStyleBackColor = true;
            this.btnMTea.Click += new System.EventHandler(this.btnMTea_Click);
            // 
            // grbTeaMenu
            // 
            this.grbTeaMenu.Controls.Add(this.chkSandwich);
            this.grbTeaMenu.Controls.Add(this.chkCPuff);
            this.grbTeaMenu.Controls.Add(this.chkBrownie);
            this.grbTeaMenu.Controls.Add(this.chkSlice);
            this.grbTeaMenu.Controls.Add(this.chkCSwirl);
            this.grbTeaMenu.Controls.Add(this.chkSPinwheel);
            this.grbTeaMenu.Controls.Add(this.chkCRolls);
            this.grbTeaMenu.Controls.Add(this.chkBagel);
            this.grbTeaMenu.Controls.Add(this.grbBagel);
            this.grbTeaMenu.Controls.Add(this.grbSandwich);
            this.grbTeaMenu.Controls.Add(this.grbMuffin);
            this.grbTeaMenu.Controls.Add(this.chkMuffin);
            this.grbTeaMenu.Enabled = false;
            this.grbTeaMenu.Location = new System.Drawing.Point(244, 12);
            this.grbTeaMenu.Name = "grbTeaMenu";
            this.grbTeaMenu.Size = new System.Drawing.Size(388, 600);
            this.grbTeaMenu.TabIndex = 1;
            this.grbTeaMenu.TabStop = false;
            this.grbTeaMenu.Text = "Morning Tea";
            // 
            // chkCPuff
            // 
            this.chkCPuff.AutoSize = true;
            this.chkCPuff.Location = new System.Drawing.Point(23, 144);
            this.chkCPuff.Name = "chkCPuff";
            this.chkCPuff.Size = new System.Drawing.Size(108, 17);
            this.chkCPuff.TabIndex = 12;
            this.chkCPuff.Text = "Cheese Puff - $3 ";
            this.chkCPuff.UseVisualStyleBackColor = true;
            this.chkCPuff.CheckedChanged += new System.EventHandler(this.MTeaCheckBox_Checked);
            // 
            // chkBrownie
            // 
            this.chkBrownie.AutoSize = true;
            this.chkBrownie.Location = new System.Drawing.Point(23, 121);
            this.chkBrownie.Name = "chkBrownie";
            this.chkBrownie.Size = new System.Drawing.Size(85, 17);
            this.chkBrownie.TabIndex = 11;
            this.chkBrownie.Text = "Brownie - $3";
            this.chkBrownie.UseVisualStyleBackColor = true;
            this.chkBrownie.CheckedChanged += new System.EventHandler(this.MTeaCheckBox_Checked);
            // 
            // chkSlice
            // 
            this.chkSlice.AutoSize = true;
            this.chkSlice.Location = new System.Drawing.Point(23, 98);
            this.chkSlice.Name = "chkSlice";
            this.chkSlice.Size = new System.Drawing.Size(70, 17);
            this.chkSlice.TabIndex = 10;
            this.chkSlice.Text = "Slice - $3";
            this.chkSlice.UseVisualStyleBackColor = true;
            this.chkSlice.CheckedChanged += new System.EventHandler(this.MTeaCheckBox_Checked);
            // 
            // chkCSwirl
            // 
            this.chkCSwirl.AutoSize = true;
            this.chkCSwirl.Location = new System.Drawing.Point(23, 75);
            this.chkCSwirl.Name = "chkCSwirl";
            this.chkCSwirl.Size = new System.Drawing.Size(119, 17);
            this.chkCSwirl.TabIndex = 9;
            this.chkCSwirl.Text = "Cinnamon Swirl - $3";
            this.chkCSwirl.UseVisualStyleBackColor = true;
            this.chkCSwirl.CheckedChanged += new System.EventHandler(this.MTeaCheckBox_Checked);
            // 
            // chkSPinwheel
            // 
            this.chkSPinwheel.AutoSize = true;
            this.chkSPinwheel.Location = new System.Drawing.Point(23, 52);
            this.chkSPinwheel.Name = "chkSPinwheel";
            this.chkSPinwheel.Size = new System.Drawing.Size(138, 17);
            this.chkSPinwheel.TabIndex = 8;
            this.chkSPinwheel.Text = "Savoury Pinwheel  - $3 ";
            this.chkSPinwheel.UseVisualStyleBackColor = true;
            this.chkSPinwheel.CheckedChanged += new System.EventHandler(this.MTeaCheckBox_Checked);
            // 
            // chkCRolls
            // 
            this.chkCRolls.AutoSize = true;
            this.chkCRolls.Location = new System.Drawing.Point(23, 29);
            this.chkCRolls.Name = "chkCRolls";
            this.chkCRolls.Size = new System.Drawing.Size(104, 17);
            this.chkCRolls.TabIndex = 7;
            this.chkCRolls.Text = "Cheese Roll - $4";
            this.chkCRolls.UseVisualStyleBackColor = true;
            this.chkCRolls.CheckedChanged += new System.EventHandler(this.MTeaCheckBox_Checked);
            // 
            // chkBagel
            // 
            this.chkBagel.AutoSize = true;
            this.chkBagel.Location = new System.Drawing.Point(23, 349);
            this.chkBagel.Name = "chkBagel";
            this.chkBagel.Size = new System.Drawing.Size(74, 17);
            this.chkBagel.TabIndex = 6;
            this.chkBagel.Text = "Bagel - $4";
            this.chkBagel.UseVisualStyleBackColor = true;
            this.chkBagel.CheckedChanged += new System.EventHandler(this.MTeaCheckBox_Checked);
            // 
            // grbBagel
            // 
            this.grbBagel.Controls.Add(this.radioButton8);
            this.grbBagel.Controls.Add(this.radioButton9);
            this.grbBagel.Location = new System.Drawing.Point(40, 372);
            this.grbBagel.Name = "grbBagel";
            this.grbBagel.Size = new System.Drawing.Size(333, 63);
            this.grbBagel.TabIndex = 5;
            this.grbBagel.TabStop = false;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(6, 35);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(302, 17);
            this.radioButton8.TabIndex = 2;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Tomato, onion, creamy cheese, avocado and tomato relish";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(6, 12);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(321, 17);
            this.radioButton9.TabIndex = 1;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "Smoked salmon, creamy cheese, alfa sprouts and tomato relish";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // grbSandwich
            // 
            this.grbSandwich.Controls.Add(this.radioButton7);
            this.grbSandwich.Controls.Add(this.radioButton6);
            this.grbSandwich.Controls.Add(this.radioButton5);
            this.grbSandwich.Controls.Add(this.radioButton3);
            this.grbSandwich.Controls.Add(this.radioButton4);
            this.grbSandwich.Enabled = false;
            this.grbSandwich.Location = new System.Drawing.Point(40, 211);
            this.grbSandwich.Name = "grbSandwich";
            this.grbSandwich.Size = new System.Drawing.Size(333, 132);
            this.grbSandwich.TabIndex = 4;
            this.grbSandwich.TabStop = false;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(6, 104);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(229, 17);
            this.radioButton7.TabIndex = 5;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Chicken, creamy cheese, salad and apricot";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(6, 81);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(316, 17);
            this.radioButton6.TabIndex = 4;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Vegetarian (Egg, tomato, aifa sprouts. cucumber and mustard)";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(6, 58);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(150, 17);
            this.radioButton5.TabIndex = 3;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Bacon, lettuce and tomato";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 12);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(176, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Beef, cheese, lettuce and onion";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 35);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(199, 17);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Ham, tomato, egg, lettuce and mayo ";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // grbMuffin
            // 
            this.grbMuffin.Controls.Add(this.radioButton2);
            this.grbMuffin.Controls.Add(this.radioButton1);
            this.grbMuffin.Location = new System.Drawing.Point(40, 474);
            this.grbMuffin.Name = "grbMuffin";
            this.grbMuffin.Size = new System.Drawing.Size(333, 71);
            this.grbMuffin.TabIndex = 2;
            this.grbMuffin.TabStop = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(55, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Sweet";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(64, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Savoury";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // chkMuffin
            // 
            this.chkMuffin.AutoSize = true;
            this.chkMuffin.Location = new System.Drawing.Point(23, 451);
            this.chkMuffin.Name = "chkMuffin";
            this.chkMuffin.Size = new System.Drawing.Size(76, 17);
            this.chkMuffin.TabIndex = 1;
            this.chkMuffin.Text = "Muffin - $3";
            this.chkMuffin.UseVisualStyleBackColor = true;
            this.chkMuffin.CheckedChanged += new System.EventHandler(this.MTeaCheckBox_Checked);
            // 
            // grbLunchMenu
            // 
            this.grbLunchMenu.Enabled = false;
            this.grbLunchMenu.Location = new System.Drawing.Point(638, 12);
            this.grbLunchMenu.Name = "grbLunchMenu";
            this.grbLunchMenu.Size = new System.Drawing.Size(358, 600);
            this.grbLunchMenu.TabIndex = 2;
            this.grbLunchMenu.TabStop = false;
            this.grbLunchMenu.Text = "Lunch";
            // 
            // lblMTeaCost
            // 
            this.lblMTeaCost.AutoSize = true;
            this.lblMTeaCost.Location = new System.Drawing.Point(87, 210);
            this.lblMTeaCost.Name = "lblMTeaCost";
            this.lblMTeaCost.Size = new System.Drawing.Size(31, 13);
            this.lblMTeaCost.TabIndex = 7;
            this.lblMTeaCost.Text = "Total";
            // 
            // lbCOItems
            // 
            this.lbCOItems.FormattingEnabled = true;
            this.lbCOItems.Location = new System.Drawing.Point(6, 19);
            this.lbCOItems.Name = "lbCOItems";
            this.lbCOItems.Size = new System.Drawing.Size(214, 173);
            this.lbCOItems.TabIndex = 8;
            // 
            // grbList
            // 
            this.grbList.Controls.Add(this.lbCOItems);
            this.grbList.Controls.Add(this.lblMTeaCost);
            this.grbList.Location = new System.Drawing.Point(12, 209);
            this.grbList.Name = "grbList";
            this.grbList.Size = new System.Drawing.Size(226, 403);
            this.grbList.TabIndex = 3;
            this.grbList.TabStop = false;
            this.grbList.Text = "Check Out List ";
            // 
            // chkSandwich
            // 
            this.chkSandwich.AutoSize = true;
            this.chkSandwich.Location = new System.Drawing.Point(23, 197);
            this.chkSandwich.Name = "chkSandwich";
            this.chkSandwich.Size = new System.Drawing.Size(94, 17);
            this.chkSandwich.TabIndex = 13;
            this.chkSandwich.Text = "Sandwich - $4";
            this.chkSandwich.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 626);
            this.Controls.Add(this.grbList);
            this.Controls.Add(this.grbLunchMenu);
            this.Controls.Add(this.grbTeaMenu);
            this.Controls.Add(this.grbSelectMenu);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.grbSelectMenu.ResumeLayout(false);
            this.grbLunchSelection.ResumeLayout(false);
            this.grbTeaMenu.ResumeLayout(false);
            this.grbTeaMenu.PerformLayout();
            this.grbBagel.ResumeLayout(false);
            this.grbBagel.PerformLayout();
            this.grbSandwich.ResumeLayout(false);
            this.grbSandwich.PerformLayout();
            this.grbMuffin.ResumeLayout(false);
            this.grbMuffin.PerformLayout();
            this.grbList.ResumeLayout(false);
            this.grbList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbSelectMenu;
        private System.Windows.Forms.Button btnLunch;
        private System.Windows.Forms.GroupBox grbLunchSelection;
        private System.Windows.Forms.Button btnWeek2;
        private System.Windows.Forms.Button btnWeek1;
        private System.Windows.Forms.Button btnMTea;
        private System.Windows.Forms.GroupBox grbTeaMenu;
        private System.Windows.Forms.GroupBox grbLunchMenu;
        private System.Windows.Forms.GroupBox grbMuffin;
        private System.Windows.Forms.CheckBox chkMuffin;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox grbSandwich;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.CheckBox chkBagel;
        private System.Windows.Forms.GroupBox grbBagel;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.CheckBox chkCRolls;
        private System.Windows.Forms.CheckBox chkCPuff;
        private System.Windows.Forms.CheckBox chkBrownie;
        private System.Windows.Forms.CheckBox chkSlice;
        private System.Windows.Forms.CheckBox chkCSwirl;
        private System.Windows.Forms.CheckBox chkSPinwheel;
        private System.Windows.Forms.Label lblMTeaCost;
        private System.Windows.Forms.ListBox lbCOItems;
        private System.Windows.Forms.GroupBox grbList;
        private System.Windows.Forms.CheckBox chkSandwich;
    }
}