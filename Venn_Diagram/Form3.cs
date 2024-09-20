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
    public partial class Form3 : Form
    {
         Intersection obj  = new Intersection();

        HashSet<string> A;
        HashSet<string> B;
        HashSet<string> C;
        string Exp = string.Empty;

        public Form3()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<string> r = obj.PerformOperation(A, B, C);

            
            foreach (var item in r)
            {
                textIntersecResult.Text += item + ",";
            }



        }

        public void ExpressionSymbol()
        {
            obj.ExpressionSymbol(txtExp, Exp);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Exp = "A";
            ExpressionSymbol();
            B = new HashSet<string>() { "5", "4", "3", "6" };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Exp =  "B";
            ExpressionSymbol();
            A = new HashSet<string>() { "1", "2", "3", "4" };
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Exp = "C";
            ExpressionSymbol();
            C = new HashSet<string>() { "2", "3", "6", "7" };
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Exp = "";
            txtExp.Text = "";
            textIntersecResult.Text = "";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void txtExp_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Exp = " | " ;
            ExpressionSymbol();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textIntersecResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Exp = " ( ";
            ExpressionSymbol();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Exp = " ) ";
            ExpressionSymbol();
        }
    }
}
