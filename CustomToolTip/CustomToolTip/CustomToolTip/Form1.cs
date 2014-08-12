using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CustomToolTip
{
    public partial class Form1 : Form
    {
        CustomToolTip toolTip = new CustomToolTip();
        public Form1()
        {
            InitializeComponent();
            toolTip.ShowAlways = true;
            //toolTip.IsBalloon = true;
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 0;
            toolTip.ReshowDelay = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string inputStr = @" If this attribute is presented and set to list, handler will not, use number handler, for match. For example:  will not give a match. User can only select with criteria match.";
            SplitLine(inputStr, 4);
            toolTip.IsBalloon = true;
            toolTip.SetToolTip(this.button1, "This is my button");
            toolTip.SetToolTip(this.label1, SplitLine(inputStr, 10));
        }

        static string SplitLine(string inputString, int numWordPerLine)
        {
            string returnString = string.Empty;
            if (!string.IsNullOrEmpty(inputString))
            {
                string[] delimiter = new string[] { @" " };
                inputString = Regex.Replace(inputString, @"\s+", @" ").Trim();
                List<string> words = inputString.Split(delimiter, StringSplitOptions.None).ToList();
                List<string> lineList = new List<string>();

                string line = string.Empty;
                for (int i = 0; i < words.Count; i++)
                {
                    if (i % numWordPerLine == 0)
                    {
                        if (!string.IsNullOrEmpty(line.Trim()))
                        {
                            lineList.Add(line);
                        }
                        line = string.Empty;
                        line += words[i].Trim() + @" ";
                    }
                    else
                    {
                        line += words[i].Trim() + @" ";
                    }
                }
                for (int i = 0; i < lineList.Count; i++)
                {
                    returnString += lineList[i] + Environment.NewLine;
                }
            }
            return returnString;
        }
    }

    public class CustomToolTip : ToolTip
    {
        public CustomToolTip()
        {
            this.OwnerDraw = true;
            this.Popup += new PopupEventHandler(this.OnPopup);
            this.Draw += new DrawToolTipEventHandler(this.OnDraw);
        }

        // use this event to set the size of the tool tip
        private void OnPopup(object sender, PopupEventArgs e) 
        {
            //e.ToolTipSize = new Size(200, 200);
        }

        // use this event to customise the tool tip
        private void OnDraw(object sender, DrawToolTipEventArgs e) 
        {
            Graphics g = e.Graphics;

            LinearGradientBrush b = new LinearGradientBrush(e.Bounds,
                Color.GreenYellow, Color.MintCream, 45f);

            g.FillRectangle(b, e.Bounds);

            g.DrawRectangle(new Pen(Brushes.Red, 1), new Rectangle(e.Bounds.X, e.Bounds.Y,
                e.Bounds.Width - 1, e.Bounds.Height - 1));

            g.DrawString(e.ToolTipText, new Font(e.Font, FontStyle.Bold), Brushes.Silver,
                new PointF(e.Bounds.X + 6, e.Bounds.Y + 6)); // shadow layer
            g.DrawString(e.ToolTipText, new Font(e.Font, FontStyle.Bold), Brushes.Black,
                new PointF(e.Bounds.X + 5, e.Bounds.Y + 5)); // top layer

            b.Dispose();
        }
    }
}
