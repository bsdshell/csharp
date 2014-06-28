using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ValidatingEvent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Event will be trigger when focus leaves the control(e.g TextBox)
            this.textBox1.Validating += ValidationRule;
        }
        private void ValidationRule(object sender, EventArgs e)
        {
            MessageBox.Show("Validating me!", "Validating", MessageBoxButtons.YesNo);
        }
    }
}
