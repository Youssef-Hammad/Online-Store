﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineStore
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void registerBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registerForm rForm = new registerForm();
            rForm.ShowDialog();
        }
    }
}
