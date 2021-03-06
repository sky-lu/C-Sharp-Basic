﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCsStringDateTime
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void mnuQuit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure to quit the program ?","Closing program",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void mnuBook_Click(object sender, EventArgs e)
        {
            frmBookString fb = new frmBookString();
            fb.MdiParent = this;
            fb.Show();
        }

        private void mnuTimeSheet_Click(object sender, EventArgs e)
        {
            frmTimesheet ft = new frmTimesheet();
            ft.MdiParent = this;
            ft.Show();
        }

        private void functionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmCalculator fc = new frmCalculator();
            //fc.MdiParent = this;
            //fc.Show();

            frmFunctionTest ft = new frmFunctionTest();
            ft.MdiParent = this;
            ft.Show();
        }

        private void stuctureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStructure fs = new frmStructure();
            fs.MdiParent = this;
            fs.Show();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFile ff = new frmFile();
            ff.MdiParent = this;
            ff.Show();
        }
    }
}
