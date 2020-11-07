using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleBank
{
    public partial class Form1 : Form
    {
        public string username, password = "";
        public static int userkey;
        List<string> userTxt = new List<string>();  
        List<string> passTxt = new List<string>();
        Dictionary<int, string> userList = new Dictionary<int, string>();   //I honestly can't remember why I did this instead of user,password... but it works
        Dictionary<int, string> passList = new Dictionary<int, string>();
        
        //some things to consider:
        //textbox clears? Should I clear the textboxes after a failed login?


        public void AddUserDict(int position, string username)  //method for addng a new user to the dictionary
        {
            userList.Add(position, username);                   //the position when adding a new user will always be the same for the new password below
        }
        public void AddPassDict(int position, string password) //method for adding  new password to the dictionary
        {
            passList.Add(position, password);
        }
        public int GetCountPlusOne()
        {
            return userList.Count + 1;  //this is to get the next position free in the dictionary so the count is always +1
        }

        public string[] GetUsernames() //used to get the array of usernames for the create account form to check for already existing usernames
        {
            string[] userAry = userTxt.ToArray();
            return userAry;
        }

        public int getUserNum()
        {
            return userTxt.IndexOf(username);
        }

        //public static bool Exists(string path);

        public Form1()
        {
            InitializeComponent();
            string directory1 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SimpleBankApp\";  //directory that saves in MyDocuments in a SimpleBankApp directory
            string path1 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SimpleBankApp\userTuple.txt";  //file in my docs that has the username info
            string path2 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SimpleBankApp\passTuple.txt";  //file in my docs that has the password info
            string path3 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SimpleBankApp\userData.txt";   //bank info file
            
            if (!Directory.Exists(directory1))
            { // Create the directory
                Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "SimpleBankApp"));
            }
            if (!File.Exists(path1))
            {
                using (StreamWriter sw = File.CreateText(path1)) { }
            }
            if (!File.Exists(path2))
            { // Create a file to write to   
                using (StreamWriter sw = File.CreateText(path2)) { }
            }
            if (!File.Exists(path3))
            { // Create a file to write to   
                using (StreamWriter sw = File.CreateText(path3)) { }
            }
            try
            {
                using (StreamReader sr = new StreamReader(path1))
                {
                    while (sr.Peek() >= 0)  //basically a null check
                    {
                        userTxt.Add(sr.ReadLine()); //adds each line into the username list
                    }
                }
            }
            catch (Exception epp)
            {
                Console.WriteLine("Exception: " + epp.Message);
            }

            try
            {
                using (StreamReader sr = new StreamReader(path2))
                {
                    while (sr.Peek() >= 0)  //basically a null check
                    {
                        passTxt.Add(sr.ReadLine()); //adds each line into the password list
                    }
                }
            }
            catch (Exception epp)
            {
                Console.WriteLine("Exception: " + epp.Message);
            }

            string[] userAry = userTxt.ToArray();   //turns the list into an array for iterating through easily
            string[] passAry = passTxt.ToArray();

            for (int i=0;i<userAry.Length;i++)      //this takes all the data we retrieved from the files that we put into a list, and then into an array, into the data dictionary
            {
                userList.Add(i,userAry[i]);
                passList.Add(i, passAry[i]);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)  //this is the submit button
        {
            if (usernameTxt.Text != "")     //checks to make sure the username field is not null or empty
            {
                username = usernameTxt.Text;    //this pulls the text entered into the username field and assigns it to the username variable declared at the start of the program
            }
            else                                 //this pops up an error if the field is null
            {
                MessageBox.Show("Please enter a username", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (passwordTxt.Text != "")         //checks to make sure the password field is not null or empty
            {
                password = passwordTxt.Text;    //this pulls the text entered into the password field and assigns it to the password variable declared at the start of the program
            }
            else                                 //this pops up an error if the field is null
            {
                MessageBox.Show("Please enter a password", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (userList.ContainsValue(username))       //this checks the username dictionary to see if the username entered is actually a value in the dictionary
            {
                var myUserKey = userList.FirstOrDefault(x => x.Value == username).Key;      //if the username is a valid value, this retrieves the key pair
                userkey = myUserKey;
                if (passList.ContainsValue(password))   //this checks the password dictionary to see if the password entered is actually a value in the dictionary
                {
                    var myPassKey = passList.FirstOrDefault(x => x.Value == password).Key;  //if the password is a valid value, this retrieves the key pair
                    if (myUserKey == myPassKey)                     //this is the magic where if the key value of both the username and password are the same, then the program continues onward
                    {
                        //here will be the new form to show the banking main screen
                        //probably like
                         Form3 bankScreen = new Form3();
                         bankScreen.Show();
                         //this.Close(); //OR
                         this.Hide(); //but I think i want it to close not hide.
                         
                    }
                    else        //shows if the password does not match the username's associated password
                    {
                        MessageBox.Show("Incorrect password", "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        passwordTxt.Clear();
                    }
                }
                else        //shows if the password does not even exist in the dicitonary as a redundancy
                {
                    MessageBox.Show("Incorrect password", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    passwordTxt.Clear();
                }
            }
            else  //this pops up an error message when the username has no matches in the dictionary
            {     //also fuck me isn't this great? I hate when I don't know if the account is associated with the right email or username and I just forgot the password or what.
                MessageBox.Show("This Username does not exist", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)  //this is the create account button
        {
            Form2 f2 = new Form2();     //this opens up the new form to create an account
            f2.Show();
            this.Hide();
        }

        private void usernameTxt_TextChanged(object sender, EventArgs e)
        {
   
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTxt_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }
    }
}
