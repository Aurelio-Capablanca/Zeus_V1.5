﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zeus.Vista
{
    public partial class FrmRecuperadores : Form
    {
        public FrmRecuperadores()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmRecuperarAdmin principal = new FrmRecuperarAdmin();
            principal.Show();
            this.Hide();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmLogin principal = new FrmLogin();
            principal.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmRecuperacionRes principal = new FrmRecuperacionRes();
            principal.Show();
            this.Hide();

        }

        private void FrmRecuperadores_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmRecuperadorCorreo principal = new FrmRecuperadorCorreo();
            principal.Show();
            this.Hide();

        }
    }
}
