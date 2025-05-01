using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void IntroducePerson(string firsname,string lastname,string city)
        {
           
            label1.Text = " سلام من " + firsname + " " + lastname + " هستم و اهل " + city + " هستم";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            IntroducePerson(lastname: textBox2.Text, city: textBox3.Text, firsname: textBox1.Text);
        }
    }
}
