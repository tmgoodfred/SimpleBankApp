using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleBank
{
    public partial class Form3 : Form
    {
        List<string> userData = new List<string>();
        double checkingNum,savingsNum = 0.0;    //the double version of the extracted bank data which comes in string form
        string[] bankDataStringToSplit = new string[2];
        string bankDataStr = "";
        public static double checkings;
        public static double savings;

        public Form3()
        {
            int userNum = 0;
            InitializeComponent();
            string path1 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Data\userData.txt");    //gets the local file path for the user bank data
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

            userNum = Form1.userkey;    //takes the user index from the login to correlate with the proper index of bank data so the user gets the correct data for their account
            string[] userAry = userData.ToArray();
            for (int i = 0;i<userAry.Length;i++)    //this iterates through the list of bank data to get the matching line that corresponds with the user's index
            {
                if(i == userNum)    //if the line of bank data matches the line number of the logged in user:
                {
                    bankDataStr = userAry[i];   //save the string of bank data 
                }              
            }
            bankDataStringToSplit = bankDataStr.Split(','); //splitting the savings and checkings into two strings
            checkingNum = Convert.ToDouble(bankDataStringToSplit[0]);
            checkings = checkingNum;
            savingsNum = Convert.ToDouble(bankDataStringToSplit[1]);
            savings = savingsNum;
            checkingTxt.Text = "$" + bankDataStringToSplit[0];
            savingsTxt.Text = "$" + bankDataStringToSplit[1];
        }

        private void checkingTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddFunds_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void TransferFunds_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            this.Hide();
        }

        private void savingsTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
