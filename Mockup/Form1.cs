using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mockup
{
    public partial class Form1 : Form
        
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SignupInterface a = new SignupInterface();
            a.Show();
            this.Hide();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LoginInterface a = new LoginInterface();
            a.Show();
            this.Hide();
        }
    }

        
 }
    
