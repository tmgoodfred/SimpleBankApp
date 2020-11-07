using System;
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
    public partial class Form2 : Form
    {
        string createUsername,createPassword = "";
        static string passwordReq = @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?!.*\s).{6,14}$"; //Password expresion that requires one lower case letter, one upper case letter, one digit, 6-14 length, and no spaces. 
        static string usernameReq = @"^([a-zA-Z])[a-zA-Z_-]*[\w_-]*[\S]{6,12}$|^([a-zA-Z])[0-9_-]*[\S]$|^[a-zA-Z]*[\S]{6,12}$"; //is alphanumeric, starts with a letter and contains no special characters other
        Regex passCheck = new Regex(passwordReq);                                                                               //than underscore or dash, also between 6 and 12 characters.
        Regex userCheck = new Regex(usernameReq);
        bool checker = false;   //will trigger if a matching password is found

        public Form2()
        {
            InitializeComponent();
        }

        private void createAccountButton_Click(object sender, EventArgs e)      //this is the button to create the account once the data has been entered
        {
            Form1 f1T = new Form1();    //new instance of form1 for use in code
            string[] userNames = f1T.GetUsernames();   //array of usernames received from username file in form1
            if (createUserTxt.Text != "")    //makes sure that the username field is not null or empty
            {
                if (userCheck.IsMatch(createUserTxt.Text))  //checks to see if the username matches the regex 
                {
                    for (int i = 0; i < userNames.Length; i++)  //iterates over the username array
                    {
                        if (createUserTxt.Text == userNames[i]) //if the username entered matches, then send error and break out of the loop
                        {
                            checker = true; //flag is flipped when a matching username exists
                        }
                    }
                    if (!checker)   //if the trigger doesn't flip and no matching usernames exist, the username is saved
                    {
                        createUsername = createUserTxt.Text;    //assigns the username variable at the start of the program to the text entered in the username field
                    }
                    else        //will display the error if the username exists
                    {
                        MessageBox.Show("Username already exists", "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else    //outputs when the username doesn't match the regex
                {
                    MessageBox.Show("Username Invalid. Please enter a username that fits the following:\n\tIs alphanumeric (letters and numbers)\n\tStarts with a letter\n\tIs between 6 and 12 characters\n\tContains no special characters aside from an underscore or dash", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else              //pops up when the username field is blank
            {
                MessageBox.Show("Please enter a username", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if(createPassTxt.Text != "" || createPass2Txt.Text != "")          //checks if the password fields are empty
            {
                if(createPassTxt.Text == createPass2Txt.Text)   //this checks if the passwords entered are matching
                {
                    if (passCheck.IsMatch(createPassTxt.Text))  //the regex match to make sure the password actually fits the requirements
                    {
                        createPassword = createPassTxt.Text;    //if both passwords match, it doesn't matter which one you take, I picked the first field.
                        string path1 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SimpleBankApp\userTuple.txt";  //username info file
                        string path2 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SimpleBankApp\passTuple.txt";  //password info file
                        string path3 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SimpleBankApp\userData.txt";   //bank info file
                        if (!File.Exists(path3))
                        { // Create a file to write to   
                            using (StreamWriter sw = File.CreateText(path3)) { }
                        }
                        try
                        {
                            File.AppendAllText(path1, Environment.NewLine + createUsername);    //this appends the new username onto the text file on the next line
                        }
                        catch (Exception epp)
                        {
                            Console.WriteLine("Exception: " + epp.Message);
                        }
                        try
                        {
                            File.AppendAllText(path2, Environment.NewLine + createPassword);    //this appends the new password onto the text file on the next line
                        }
                        catch (Exception epp)
                        {
                            Console.WriteLine("Exception: " + epp.Message);
                        }
                        try
                        {
                            File.AppendAllText(path3, Environment.NewLine + "0.00,0.00");    //this appends the new bank data to the new user
                        }
                        catch (Exception epp)
                        {
                            Console.WriteLine("Exception: " + epp.Message);
                        }
                        MessageBox.Show("Account Created!", "CONGRATS",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Form1 f1 = new Form1(); //this creates the new form which will not re-initialize and will detect the new username and password
                        f1.Show();  //after the files are written to, the original login screen pops back up
                        this.Close();
                    }
                    else        //error message for when a password is entered that does not fit requirements
                    {
                        MessageBox.Show("Password needs to have the following:\n\tOne lower case\n\tOne upper case\n\tOne digit\nBe between 6 and 14 characters\n\tNo spaces", "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else            //if the passwords don't match, this error appears
                {
                    MessageBox.Show("Passwords do not match", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else            //if one or both of the password fields are empty this error appears
            {
                MessageBox.Show("Please enter a password", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backButton_Click(object sender, EventArgs e)       //this is the back button
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void createUserTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void createPassTxt_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void createPass2Txt_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
