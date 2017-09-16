using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace 建造者模式
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Graphics gp = panel1.CreateGraphics();
            Pen pen = new Pen(Color.Red);
            BuilderController builde = new BuilderController(new BuilderFat(gp,pen));
            builde.AllMethod();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics gp = panel1.CreateGraphics();
            Pen pen = new Pen(Color.Red);
            BuilderController builde = new BuilderController(new BuilderThin(gp, pen));
            builde.AllMethod();
        }
    }
}
