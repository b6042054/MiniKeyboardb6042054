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

        }
    }
}
