using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int first, second;
        public Form1()
        {
            
            
           
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtBox1_TextChanged(object sender, EventArgs e)
        {
            first = int.Parse(txtBox1.Text);
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int result = first + second;
            lblResult.Text = Convert.ToString(result);
        }

        private void txtBox2_TextChanged(object sender, EventArgs e)
        {
            second = int.Parse(txtBox2.Text);
        }
        
        private void btnSub_Click_1(object sender, EventArgs e)
        {
            int result = first - second;
            lblResult.Text = Convert.ToString(result);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = first/second;
            lblResult.Text = Convert.ToString(result);
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void btnmul_Click(object sender, EventArgs e)
        {
            int result = first*second;
            lblResult.Text = Convert.ToString(result);
        }

        private void btndiv2_Click(object sender, EventArgs e)
        {
            int result = first % second;
            lblResult.Text = Convert.ToString(result);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            int result = 0;
            lblResult.Text = Convert.ToString(result);
            txtBox1.Text = Convert.ToString(result);
            txtBox2.Text = Convert.ToString(result);
        }

    }
}
