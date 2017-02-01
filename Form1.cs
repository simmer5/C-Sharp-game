using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SavarankiskasAntras
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        int sk, x;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            trackBar1.Value = trackBar1.Minimum;
            trackBar2.Value = trackBar2.Maximum;
            label2.Text = Convert.ToString(trackBar1.Value);
            label3.Text = Convert.ToString(trackBar2.Value);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(trackBar1.Value);
            if (trackBar1.Value > trackBar2.Value)
            {
                trackBar2.Value = trackBar1.Value;
                label3.Text = Convert.ToString(trackBar2.Value);
            }
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label3.Text = Convert.ToString(trackBar2.Value);
            if (trackBar2.Value < trackBar1.Value)
            {
                trackBar1.Value = trackBar2.Value;
                label2.Text = Convert.ToString(trackBar1.Value);
            }
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            sk = r.Next(trackBar1.Value, trackBar2.Value+1);
            label12.Text = Convert.ToString(sk);
           
        }
        private void button1_Click(object sender, EventArgs e)
        {

            label13.Text = Convert.ToString(textBox1.Text);

            listBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
            ActiveControl = textBox1;
            x = listBox1.Items.Count;
            label9.Text = Convert.ToString(x);
           
                                  
            if (label12.Text == label13.Text)
                {
                    label14.Text = "You are right!!! Corect number is "+ label13.Text;
                    MessageBox.Show("Congratulate!");
                    ResetGame();
                }
                else
                {
                    label14.Text = "This is not "+ label13.Text + ". Try one more time!";
                    if (Convert.ToInt32 (label13.Text)<sk)
                    {
                        if (Convert.ToInt32(label13.Text) < trackBar1.Value)
                        {
                            MessageBox.Show("Wrong Interval!");
                        }
                        else
                        {
                            trackBar1.Value = Convert.ToInt32(label13.Text);
                            label2.Text = Convert.ToString(trackBar1.Value);
                        }
                    }
                    if (Convert.ToInt32(label13.Text) > sk)
                    {
                        if (Convert.ToInt32(label13.Text) > trackBar2.Value)
                        {
                            MessageBox.Show("Wrong Interval!");
                        }
                        else
                        {
                            trackBar2.Value = Convert.ToInt32(label13.Text);
                            label3.Text = Convert.ToString(trackBar2.Value);
                        }
                    }
                   
                }
           

            if (numericUpDown1.Value == listBox1.Items.Count && label12.Text == label13.Text) 
            {
                ResetGame();


            } else if (numericUpDown1.Value == listBox1.Items.Count)
            {
                MessageBox.Show("You lose. Try again.");
                ResetGame();
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {       
           
        }        

        //leidzia tik skaicius rasyti i textbox'a
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {
            
    }        private void ResetGame()
        {
      
            trackBar1.Value = trackBar1.Minimum;
            trackBar2.Value = trackBar2.Maximum;
            label2.Text = Convert.ToString(trackBar1.Value);
            label3.Text = Convert.ToString(trackBar2.Value);
            listBox1.Items.Clear();
            numericUpDown1.Value = numericUpDown1.Minimum;
            label9.Text = "";
            label14.Text = "";
        }
    }
}


