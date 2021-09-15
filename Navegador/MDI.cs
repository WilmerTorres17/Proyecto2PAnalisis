﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navegador
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            Form1 Prod = new Form1();
            Prod.MdiParent = this;
            Prod.Show();
        }
    }
}