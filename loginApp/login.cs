using System;
using System.Collections;
using System.Collections.Generic;
using System.IO; // Add this using directive for File class
using System.Windows.Forms;

namespace loginApp
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        string filepath = @"C:\\Users\\jez\\Desktop\users.txt";
        //arraylist of usernames
        ArrayList allusernames = new ArrayList();
        // dictionary of usernames and passwords
        Dictionary<string, string> usernameANDpassword = new Dictionary<string, string>();

        //create afunction to get all the username and passwords
        public void getUsers()
        {
            string[] lines = File.ReadAllLines(filepath);
            string[] values;
            string un = "";
            string ps = "";

            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split(':');

                if (values[0].Trim().Equals("Username"))
                {
                    un = values[1];
                    //add username to array
                    allusernames.Add(un);
                }

                else if (values[0].Trim().Equals("Password"))
                {
                    ps = values[1];
                }

                if (un != "" && ps != "")
                {

                    //add username and passwords to dictionary
                    usernameANDpassword.Add(un, ps);

                    //clear username and password
                    un = "";
                    ps = "";

                }

            }

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        //login
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            bool userExist = false;

            if (username.Trim().Equals("") || password.Trim().Equals(""))
            {
                MessageBox.Show("you need to enter the username and password");
            }
            else
            {
                foreach (var uname in usernameANDpassword)
                {
                    //check if the username exist
                    if (uname.Key.ToString().Trim().Equals(username))
                    {
                        //check if the password exist
                        if (uname.Value.ToString().Trim().Equals(password))
                        {
                            userExist = true;
                            break;
                        }
                    }
                }
                if (userExist)
                {
                    MessageBox.Show("YES");
                }
                else
                {
                    MessageBox.Show("NO");
                }
            }
        }

        //regester
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string username = textBox_RG_Username.Text;
            string fullname = textBox_RG_Fullname.Text;
            string email = textBox_RG_Email.Text;
            string password = textBox_RG_Password.Text;
            string confirmpass = textBox_RG_Confirm.Text;

            //check if the textbox are not empty
            if (!username.Trim().Equals("") || !fullname.Trim().Equals("") || !email.Trim().Equals("") || !password.Trim().Equals(""))
            {
                //check if the password confiramtion are correct
                if (password.Equals(confirmpass))
                {
                    TextWriter writer = new StreamWriter(filepath, true);

                    writer.Write("Username:" + username);
                    writer.WriteLine("");//new line
                    writer.Write("Fullname:" + fullname);
                    writer.WriteLine("");//new line
                    writer.Write("Email:" + email);
                    writer.WriteLine("");//new line
                    writer.Write("Password:" + password);
                    writer.WriteLine("");//new line
                    writer.Write("---------");
                    writer.WriteLine("");//new line

                    writer.Close();
                    MessageBox.Show("Account Created");
                    usernameANDpassword.Add(username, password);
                }
                else
                {
                    MessageBox.Show("Confiramtion passwrod error");
                }
            }
            else
            {
                MessageBox.Show("one or more fields are empty");
            }
        }
    }
}