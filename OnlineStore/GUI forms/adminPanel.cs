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
    public partial class adminPanel : Form
    {
        public adminPanel()
        {
            InitializeComponent();
        }

        private void rRegisterBtn_Click(object sender, EventArgs e)
        {
            addProduct productForm = new addProduct();
            productForm.ShowDialog();
        }
    }
}