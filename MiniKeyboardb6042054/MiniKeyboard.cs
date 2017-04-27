using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniKeyboardb6042054
{
    
    
    public partial class MiniKeyboard : Form
    {

        int click;

        public MiniKeyboard()
        {
            InitializeComponent();
        }

        private void ModeButton_Click(object sender, EventArgs e)
        {
            if (ModeStatus.Text == "Multi-Press")
            {
            ModeStatus.Text = "Prediction";
            }
            else if (ModeStatus.Text == "Prediction") 
            {
            ModeStatus.Text = "Multi-Press";
            }
            

        }

        private void ModeStatus_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void Char8_Click(object sender, EventArgs e)
        {
            //Char8T.Start();

            click++;

            if (click == 1)
            {
                // insert 1st (var 0) from list and insert into rich word builder textbox
                richTextBox1.Text = "a";

            }
            else if (click == 2)
            {
                richTextBox1.Text = "b";

            }
            else if (click == 3)
            {
                richTextBox1.Text = "c";

            }
            else if (click == 4)
            {
                richTextBox1.Text = "8";

            }
            else if (click == 5)
            {
                richTextBox1.Text = "A";

            }
            else if (click == 6)
            {
                richTextBox1.Text = "B";

            }
            else if (click == 7)
            {
                richTextBox1.Text = "C";

            }
            else if (click == 8)
            {
                click = 1;
                richTextBox1.Text = "a";

            }
            // change if statement into case statement - easier to edit and looks neater

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
