﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MiniKeyboardb6042054
{
    
    
    public partial class MiniKeyboard : Form
    {

        int click;
        //string store;
        //string tempstore;
        string str_keystrokes;
        string CFile_Name;


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
            

            if (ModeStatus.Text == "Multi-Press")
            {
                Char8T.Start();

                click++;

                str_keystrokes = "8";
                textBox2.Text = textBox2.Text + str_keystrokes;

                switch (click)
                {
                    case 1: richTextBox1.Text = richTextBox1.Text + "a"; break;
                    case 2: richTextBox1.Text = richTextBox1.Text + "b"; break;
                    case 3: richTextBox1.Text = richTextBox1.Text + "c"; break;
                    case 4: richTextBox1.Text = richTextBox1.Text + "8"; break;
                    case 5: richTextBox1.Text = richTextBox1.Text + "A"; break;
                    case 6: richTextBox1.Text = richTextBox1.Text + "B"; break;
                    case 7: richTextBox1.Text = richTextBox1.Text + "C"; break;
                    case 8: click = 1; richTextBox1.Text = richTextBox1.Text + "a"; break;
                       
                }

                

            }
            else
            {
                
            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Char9_Click(object sender, EventArgs e)
        {

            if (ModeStatus.Text == "Multi-Press")
            {
                
                click++;

                str_keystrokes = "9";
                textBox2.Text = textBox2.Text + str_keystrokes;

                switch (click)
                {
                    case 1: store = "d";  richTextBox1.Text = "d"; break;
                    case 2: store = "e";  richTextBox1.Text = "e"; break;
                    case 3: store = "f";  richTextBox1.Text = "f"; break;
                    case 4: store = "9";  richTextBox1.Text = "9"; break;
                    case 5: store = "D";  richTextBox1.Text = "D"; break;
                    case 6: store = "E";  richTextBox1.Text = "E"; break;
                    case 7: store = "F";  richTextBox1.Text = "F"; break;
                    case 8: click = 1; store = "d";   richTextBox1.Text = "d"; break;
                }
                 

            }
        }

        private void Char4_Click(object sender, EventArgs e)
        {

            if (ModeStatus.Text == "Multi-Press")
            {
                click++;

                str_keystrokes = "4";
                textBox2.Text = textBox2.Text + str_keystrokes;

                switch (click)
                {
                    case 1: richTextBox1.Text = "g"; break;
                    case 2: richTextBox1.Text = "h"; break;
                    case 3: richTextBox1.Text = "i"; break;
                    case 4: richTextBox1.Text = "4"; break;
                    case 5: richTextBox1.Text = "G"; break;
                    case 6: richTextBox1.Text = "H"; break;
                    case 7: richTextBox1.Text = "I"; break;
                    case 8: click = 1; richTextBox1.Text = "g"; break;
                }
            }
        }

        private void Char5_Click(object sender, EventArgs e)
        {
            if (ModeStatus.Text == "Multi-Press")
            {
                click++;

                str_keystrokes = "5";
                textBox2.Text = textBox2.Text + str_keystrokes;

                switch (click)
                {
                    case 1: richTextBox1.Text = "j"; break;
                    case 2: richTextBox1.Text = "k"; break;
                    case 3: richTextBox1.Text = "l"; break;
                    case 4: richTextBox1.Text = "5"; break;
                    case 5: richTextBox1.Text = "J"; break;
                    case 6: richTextBox1.Text = "K"; break;
                    case 7: richTextBox1.Text = "L"; break;
                    case 8: click = 1; richTextBox1.Text = "j"; break;
                }
            }
        }

        private void Char6_Click(object sender, EventArgs e)
        {
            if (ModeStatus.Text == "Multi-Press")
            {
                click++;

                str_keystrokes = "6";
                textBox2.Text = textBox2.Text + str_keystrokes;

                switch (click)
                {
                    case 1: richTextBox1.Text = "m"; break;
                    case 2: richTextBox1.Text = "n"; break;
                    case 3: richTextBox1.Text = "o"; break;
                    case 4: richTextBox1.Text = "6"; break;
                    case 5: richTextBox1.Text = "M"; break;
                    case 6: richTextBox1.Text = "N"; break;
                    case 7: richTextBox1.Text = "O"; break;
                    case 8: click = 1; richTextBox1.Text = "m"; break;
                }
            }
        }

        private void Char1_Click(object sender, EventArgs e)
        {
            if (ModeStatus.Text == "Multi-Press")
            {
                click++;

                str_keystrokes = "1";
                textBox2.Text = textBox2.Text + str_keystrokes;

                switch (click)
                {
                    case 1: richTextBox1.Text = "p"; break;
                    case 2: richTextBox1.Text = "q"; break;
                    case 3: richTextBox1.Text = "r"; break;
                    case 4: richTextBox1.Text = "s"; break;
                    case 5: richTextBox1.Text = "1"; break;
                    case 6: richTextBox1.Text = "P"; break;
                    case 7: richTextBox1.Text = "Q"; break;
                    case 8: richTextBox1.Text = "R"; break;
                    case 9: richTextBox1.Text = "S"; break;
                    case 10: click = 1; richTextBox1.Text = "p"; break;
                }
            }
        }

        private void Char2_Click(object sender, EventArgs e)
        {
            if (ModeStatus.Text == "Multi-Press")
            {
                click++;

                str_keystrokes = "2";
                textBox2.Text = textBox2.Text + str_keystrokes;

                switch (click)
                {
                    case 1: richTextBox1.Text = "t"; break;
                    case 2: richTextBox1.Text = "u"; break;
                    case 3: richTextBox1.Text = "v"; break;
                    case 4: richTextBox1.Text = "2"; break;
                    case 5: richTextBox1.Text = "T"; break;
                    case 6: richTextBox1.Text = "U"; break;
                    case 7: richTextBox1.Text = "V"; break;
                    case 8: click = 1; richTextBox1.Text = "t"; break;
                }
            }
        }

        private void Char3_Click(object sender, EventArgs e)
        {
            if (ModeStatus.Text == "Multi-Press")
            {
                click++;

                str_keystrokes = "3";
                textBox2.Text = textBox2.Text + str_keystrokes;

                switch (click)
                {
                    case 1: richTextBox1.Text = "w"; break;
                    case 2: richTextBox1.Text = "x"; break;
                    case 3: richTextBox1.Text = "y"; break;
                    case 4: richTextBox1.Text = "z"; break;
                    case 5: richTextBox1.Text = "3"; break;
                    case 6: richTextBox1.Text = "W"; break;
                    case 7: richTextBox1.Text = "X"; break;
                    case 8: richTextBox1.Text = "Y"; break;
                    case 9: richTextBox1.Text = "Z"; break;
                    case 10: click = 1; richTextBox1.Text = "w"; break;
                }
            }
        }

        private void Char7_Click(object sender, EventArgs e)
        {
            click++;

            str_keystrokes = "7";
            textBox2.Text = textBox2.Text + str_keystrokes;

            switch (click)
            {
                case 1: richTextBox1.Text = "."; break;
                case 2: richTextBox1.Text = ","; break;
                case 3: richTextBox1.Text = "'"; break;
                case 4: richTextBox1.Text = "7"; break;
                case 5: richTextBox1.Text = "'"; break;
                case 6: richTextBox1.Text = ":"; break;
                case 7: richTextBox1.Text = ";"; break;
                case 8: click = 1; richTextBox1.Text = "."; break;
            }
        }

        private void Char10_Click(object sender, EventArgs e)
        {
            click++;

            str_keystrokes = "*";
            textBox2.Text = textBox2.Text + str_keystrokes;

            switch (click)
            {
                case 1: richTextBox1.Text = "*"; break;
                case 2: richTextBox1.Text = "-"; break;
                case 3: richTextBox1.Text = "_"; break;
                case 4: click = 1; richTextBox1.Text = "*"; break;
            }
        }

        private void Char11_Click(object sender, EventArgs e)
        {
            click++;

            str_keystrokes = "#";
            textBox2.Text = textBox2.Text + str_keystrokes;

            switch (click)
            {
                case 1: richTextBox1.Text = "#"; break;
                case 2: richTextBox1.Text = "-"; break;
                case 3: richTextBox1.Text = "_"; break;
                case 4: click = 1; richTextBox1.Text = "#"; break;
            }
        }

        private void Char0_Click(object sender, EventArgs e)
        {
            click++;

            str_keystrokes = "";
            textBox1.AppendText(richTextBox1.Text + " ");
            


        }


        private void Char8T_Tick(object sender, EventArgs e)
        {
            
           //richTextBox1.AppendText();
            click = 0;
            //store = tempstore;
            //richTextBox1.Text = richTextBox1.Text + tempstore;

            
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {

            richTextBox1.AppendText(Environment.NewLine);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
         //   if (CFile_Name == "")
           // {
             //   saveFileDialog1.InitialDirectory = "C:\\";

             //   if (saveFileDialog1.ShowDialog() == DialogResult.OK)
              //  {
               //     StreamWriter OutputStream = File.CreateText(saveFileDialog1.FileName);
               //     OutputStream.Write(textBox1.Text);
               //     CFile_Name = saveFileDialog1.FileName;
               //     OutputStream.Close();
             //   }
            }
           // else
            {
            //    saveToolStripMenuItem_Click(sender, e);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            // Insert code to read the stream here.
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }

        }
    }
}
