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
    public partial class Form2 : Form
    {
        Union obj = new Union();

        HashSet<string> A;
        HashSet<string> B;
        HashSet<string> C;



        string Exp = string.Empty;
        public Form2()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            Exp = "A";
            ExpressionSymbol();
            B = new HashSet<string>() { "2", "3", "5", "6" };
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Exp = "B";
            ExpressionSymbol();
            A = new HashSet<string>() { "1", "2", "4", "5" };
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Exp  = "C";
            ExpressionSymbol();
            C = new HashSet<string>() { "4", "5", "6", "7" };
        }

        private void button7_Click(object sender, EventArgs e)
        {
            List<string> r = obj.PerformOperation(A, B, C);

           /// var UnionResult = A.Union(B).Union(C);
           /// List<string> Result = UnionResult.ToList();
            foreach (var item in r)
            {
                txtUResult.Text += item + ",";
            }

        }

        public void ExpressionSymbol()
        {
            /// txtExp.Text += Exp;
            obj.ExpressionSymbol(txtExp, Exp);

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Exp = "";
            txtExp.Text = "";
            txtUResult.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtExp_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Exp = " U ";
            ExpressionSymbol();
        }

        private void button5_Click(object sender, EventArgs e)
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
