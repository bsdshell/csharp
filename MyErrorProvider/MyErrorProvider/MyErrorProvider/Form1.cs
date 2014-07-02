using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MyErrorProvider
{
    public partial class Form1 : Form
    {
        private ErrorProvider _errorProvider = new ErrorProvider();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            if (!IsDigit(textbox.Text))
            {
                _errorProvider.SetError(textbox, "Input has to be digit");
            }
            else
            {
                _errorProvider.Clear();
            }
        }

        private Boolean IsDigit(string inputString)
        {
            Boolean isValid = false;
            Regex r = new Regex("^[0-9]*$");
            if (r.IsMatch(inputString))
            {
                isValid = true;
            }
            return isValid;
        }

        private Boolean IsAlphabet(string inputString)
        {
            Boolean isValid = false;
            Regex r = new Regex("^[a-zA-Z]*$");
            if (r.IsMatch(inputString))
            {
                isValid = true;
            }
            return isValid;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            if (! IsAlphabet(textbox.Text))
            {
                _errorProvider.SetError(textbox, "Input has to be alphabet");
            }
            else
            {
                _errorProvider.Clear();
            }
        }
    }
}
