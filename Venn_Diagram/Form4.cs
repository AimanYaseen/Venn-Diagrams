using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Venn_Diagram
{
    public partial class Form4 : Form
    {

        SetDifference obj = new SetDifference();

        HashSet<string> A;
        HashSet<string> B;
        HashSet<string> C;


        string Exp = string.Empty;

    
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Exp = "A";
            ExpressionSymbol();
            B = new HashSet<string>() { "3", "4", "6", "7" };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Exp = "B";
            ExpressionSymbol();
            A = new HashSet<string>() { "2", "3","5", "6" };
        }
        private void button9_Click(object sender, EventArgs e)
        {
            Exp = "C";
            ExpressionSymbol();
            C = new HashSet<string>() { "2", "3", "6", "7" };
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Exp = " - ";
            ExpressionSymbol();
        }

        private void button5_Click(object sender, EventArgs e)
        {


            

            List<string> r = obj.PerformOperation(A,B,C);
            foreach (var item in r)
            {
                textdifferenceResult.Text += item + ",";
            }
        }
        public void ExpressionSymbol()
        {
            //txtExp.Text += Exp;

            obj.ExpressionSymbol(txtExp, Exp);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Exp = "";
            txtExp.Text = "";
            textdifferenceResult.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Exp = " ( ";
            ExpressionSymbol();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Exp = " ) ";
            ExpressionSymbol();
        }

       
    }
}
