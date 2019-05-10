using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Register
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<User> users = new List<User>();
        public void CreateUser(object sender, EventArgs e)
        {
            Regex letters = new Regex(@"^[a-zA-Z]+$");
            Match nameMatch = letters.Match(nameBox.Text);
            Match surnameMatch = letters.Match(surnameBox.Text);
            Regex emailPattern = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match emailMatch = emailPattern.Match(emailBox.Text);
            Regex passwordPattern = new Regex(@"^[a-zA-Z0-9]+$");
            Match passwordMatch = passwordPattern.Match(passwordBox.Text);

            if (!nameMatch.Success)
            {
                MessageBox.Show("Fill name correctly");
            }
            else if (!surnameMatch.Success)
            {
                MessageBox.Show("Fill surname correctly");
            }
            else if (!emailMatch.Success)
            {
                MessageBox.Show("Fill email correctly");
            }
            else if (!passwordMatch.Success)
            {
                MessageBox.Show("Password consists of only numbers and letters");
            }else
            {
                users.Add(new User
                {
                    Name = nameBox.Text,
                    Surname = surnameBox.Text,
                    Username = usernameBox.Text,
                    Email = emailBox.Text,
                    Password = passwordBox.Text
                });

                Process.Start("C:\\Users\\User\\Desktop\\p210-20190508-weekend-task-sql-Rauf2002\\WinForms\\RegisterSln\\Product\\ProductForm.cs");
            }
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("C:\\Users\\User\\Desktop\\p210-20190508-weekend-task-sql-Rauf2002\\WinForms\\RegisterSln\\Login\\LoginForm.cs");
        }
    }
}
