/*
 * Click Me
 * 2/20/2023
 * C#.NET I
 * 
 * Instructions:
 * Run the program to see what it does. Be prepared to discuss
 * the following questions...
 * 1. Are controls in GUI program objects?
 * 2. Why might it be useful to have the program add controls
 *    dynamically?
 * 3. What is sender?
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickMe
{
    public partial class ClickMeForm : Form
    {
        public ClickMeForm()
        {
            InitializeComponent();
        }

        private void ClickMeForm_Load(object sender, EventArgs e)
        {
            Button b1 = new Button();
            b1.Name = "clickMeButton";
            b1.Text = "Click me!";
            b1.Font = new Font(FontFamily.GenericSansSerif, 46);
            b1.AutoSize = true;
            b1.Location = new Point(50, 75);
            b1.Click += new System.EventHandler(this.clickMeButton_Clicked);
            this.Controls.Add(b1);
        }

        private void clickMeButton_Clicked(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "Hi!";
        }
    }
}
