using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carsell
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//auto
        {
            Cars cars = new Cars();
            cars.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)//body
        {
            Body body = new Body();
            body.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)//dealer
        {
            Dealer dealer = new Dealer();   
            dealer.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)//engine
        {
            Engine engine = new Engine();
            engine.ShowDialog();
        }
    }
}
