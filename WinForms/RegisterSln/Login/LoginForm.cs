using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Register;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Login(object sender, EventArgs e)
        {
            Process.Start("C:\\Users\\User\\Desktop\\p210-20190508-weekend-task-sql-Rauf2002\\WinForms\\RegisterSln\\Product\\ProductForm.cs");
            
            foreach (var c in loginPanel.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }
            }
        }

        private void RegisterLink(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("C:\\Users\\User\\Desktop\\p210-20190508-weekend-task-sql-Rauf2002\\WinForms\\RegisterSln\\Register\\RegisterForm.cs");
        }
    }
}
