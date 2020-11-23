using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gissa_forms2
{
    public partial class Form1 : Form
    {
        Random slump;
        int antal = 0;
        int tal = 0;
        int random = 0;
        public Form1()
        {
            InitializeComponent();
            slump = new Random();
            random = slump.Next(0, 101);
        }

        private void Aaaa_Click(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
            tal = int.Parse(textBox2.Text);
            antal++;
            {
                if (tal < random)
                {
                    label1.Text = ("Det är för lågt");
                    label2.Text = ("Gissa igen");
                    

                }
                else if (tal > random)
                {
                    label1.Text = ("Det för högt");
                    label2.Text = ("Gissa igen");
                    
                }
                else
                    label1.Text = ("Rätt, Dina försök: " + antal);
                    label2.Text = ("");



            }
        }
    }
}
    






