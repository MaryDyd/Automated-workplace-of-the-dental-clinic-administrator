﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinic
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void PRMainMenuExitbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 MainMenu = new Form2();
            MainMenu.Show();
        }

        private void PRADDbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
