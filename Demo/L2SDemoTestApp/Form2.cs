using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace L2SDemoTestApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var rootdata = new L2SDemo.Root();

            this.bindingSource1.DataSource = rootdata;
            this.bindingSource1.DataMember = "Products";

            this.dataGridView1.DataSource = this.bindingSource1;
        }
    }
}
