﻿using JASDataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JASInventory
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void UserLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void loginBTN_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (usernameTB.Text == "")
            {
                errorProvider1.SetError(usernameTB, "User name is required");
                usernameTB.Focus();
                return;
            }
            if (passwordTB.Text == "")
            {
                errorProvider1.SetError(passwordTB, "Password is required");
                passwordTB.Focus();
                return;
            }

            UserFactory fac = new UserFactory();
            MessageBox.Show(fac.selectUser(usernameTB.Text, passwordTB.Text));
            
        }
    }
}
