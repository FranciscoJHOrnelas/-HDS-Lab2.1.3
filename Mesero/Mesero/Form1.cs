﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mesero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txbEspecificacion_TextChanged(object sender, EventArgs e)
        {
            if (txbEspecificacion.Text != "") { btnConfirmarOrden.Visible = true; }
            else btnConfirmarOrden.Visible = false;
        }

        private void txbEspecificacion_MouseClick(object sender, MouseEventArgs e)
        {
            txbEspecificacion.Text = "";
            txbEspecificacion.ForeColor = Color.Black;
        }
    }
}
