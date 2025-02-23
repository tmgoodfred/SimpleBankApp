﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleBank
{
    public partial class Form4 : Form
    {
        List<string> userData = new List<string>();
        string bankDataStr = "";
        string[] bankDataStringToSplit = new string[2];
        double checkingNum, savingsNum;
        static string amountReq = @"^[0-9]\d{0,9}(\.\d{1,2})?%?$";  //the regex to make sure that the data entered is a double
        Regex amountCheck = new Regex(amountReq);
        int userNum = Form1.userkey;
        string path1 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SimpleBankApp\userData.txt";    //gets the local file path for the user bank data
        public Form4()
        {
            InitializeComponent();
            groupBox1.Controls.Add(this.checkingRadio);     //these two lines set the box to control the radio buttons to make sure that only one of them is selected at a time
            groupBox1.Controls.Add(this.savingRadio);
            try
            {
                using (StreamReader sr = new StreamReader(path1))
                {
                    while (sr.Peek() >= 0)  //basically a null check
                    {
                        userData.Add(sr.ReadLine()); //adds each line into the user data list
                    }
                }
            }
            catch (Exception epp)
            {
                Console.WriteLine("Exception: " + epp.Message);
            }
            string[] userAry = userData.ToArray();
            for (int i = 0; i < userAry.Length; i++)    //this iterates through the list of bank data to get the matching line that corresponds with the user's index
            {
                if (i == userNum)    //if the line of bank data matches the line number of the logged in user:
                {
                    bankDataStr = userAry[i];   //save the string of bank data 
                }
            }
            bankDataStringToSplit = bankDataStr.Split(',');
            checkingNum = Convert.ToDouble(bankDataStringToSplit[0]);
            savingsNum = Convert.ToDouble(bankDataStringToSplit[1]);
        }

        private void checkingRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void savingRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string[] userAry = userData.ToArray();
            if (checkingRadio.Checked)      //the following code is for when the user selects checking
            {
                if(amount.Text != "")   //checks to make sure that the amount isn't blank
                {
                    if(amountCheck.IsMatch(amount.Text))    //checks against the regex to ensure that it is only a digit
                    {
                        checkingNum = checkingNum + Convert.ToDouble(amount.Text); //takes the amount entered and coverts it to a double 
                        string temp = checkingNum.ToString() + "," + savingsNum.ToString(); //this replaces the line value that will be entered into the txt file
                        userAry[userNum] = temp;
                        try
                        {
                            File.WriteAllText(path1, String.Empty); //write all the data back into the file while changing the line of the user currently using it
                            for (int i = 0;i<userAry.Length;i++)
                            {
                                File.AppendAllText(path1, userAry[i]+"\n"); //appends the array to the textfile after emptying it
                            }
                            Form3 f3 = new Form3(); //opens back to the last form
                            f3.Show();
                            this.Close();
                        }
                        catch (Exception epp)
                        {
                            Console.WriteLine("Exception: " + epp.Message);
                        }
                    }
                    else        //this displays if anything other than numbers are entered
                    {
                        MessageBox.Show("Numbers only please", "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else        //this displays when there is no number entered
                {
                    MessageBox.Show("Please enter an amount", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (savingRadio.Checked)       //the following code is for when the user selects savings
            {
                if (amount.Text != "")      //checks to make sure that the amount isn't blank
                {
                    if (amountCheck.IsMatch(amount.Text))       //checks against the regex to ensure that it is only a digit
                    {
                        savingsNum = savingsNum + Convert.ToDouble(amount.Text);    //takes the amount entered and coverts it to a double 
                        string temp = checkingNum.ToString() + "," + savingsNum.ToString(); //this replaces the line value that will be entered into the txt file
                        userAry[userNum] = temp;    
                        try
                        {
                            File.WriteAllText(path1, String.Empty); //write all the data back into the file while changing the line of the user currently using it
                            for (int i = 0; i < userAry.Length; i++)
                            {
                                File.AppendAllText(path1, userAry[i] + "\n");   //appends the array to the textfile after emptying it
                            }
                            Form3 f3 = new Form3(); //opens back to the last form
                            f3.Show();
                            this.Close();
                        }
                        catch (Exception epp)
                        {
                            Console.WriteLine("Exception: " + epp.Message);
                        }
                    }
                    else    //this displays if anything other than numbers are entered
                    {
                        MessageBox.Show("Numbers only please", "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else        //this displays when there is no number entered
                {
                    MessageBox.Show("Please enter an amount", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)   //simply a back button
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Close();
        }
    }
}
