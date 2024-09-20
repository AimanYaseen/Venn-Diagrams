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
    public partial class Form5 : Form
    {
        Complement obj = new Complement();

        HashSet<string> A;
        HashSet<string> U;
        


        string Exp = string.Empty;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Exp = " U ";
            ExpressionSymbol();
            A  = new HashSet<string>() {"1","2","3","4","5" };
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Exp = "A";
            ExpressionSymbol();
            U = new HashSet<string>() { "1","2","3","4","5","6","7","8","9","10" };
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            List<string> r = obj.PerformOperation(A,U);

            foreach (var item in r)
            {
                txtCompResult.Text += item + ",";
            }
        }
        public void ExpressionSymbol()
        {
            obj.ExpressionSymbol(txtExp, Exp);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Exp = " ' ";
            ExpressionSymbol();
           
            A = new HashSet<string>() { "1", "2", "3", "4", "5" };
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Exp = "";
            txtExp.Text = "";
            txtCompResult.Text = "";
        }
    }
}

