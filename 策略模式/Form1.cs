using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 策略模式
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }
        double total = 0.0d;
        private void button1_Click(object sender, EventArgs e)
        {
            CashContext cash = new CashContext(comboBox1.SelectedItem.ToString());
            double totalCash = 0d;
            totalCash = cash.GetResult(Convert.ToDouble(Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text)));
            total = total + totalCash;
            label4.Text = total.ToString();
            listBox1.Items.Add ( "价格: " + textBox1.Text + " 数量: " + textBox2.Text +comboBox1.SelectedItem+ " 小计: " + totalCash);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            listBox1.Items.Clear();
            label4.Text = "";
            total = 0.0d;
        }
    }
}
