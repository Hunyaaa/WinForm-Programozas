﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Úszóverseny
{
    public partial class Nevjegy : Form
    {
        public Nevjegy()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Uszoverseny form = new Uszoverseny();
            form.Show();
            Visible = false;
        }

        private void nevjegy_Load(object sender, EventArgs e)
        {

        }
    }
}
