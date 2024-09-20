using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Venn_Diagram
{
    public class SetDifference
    {


        public void ExpressionSymbol(TextBox txtExp,string Exp)
        {
            txtExp.Text += Exp;
        }



        public List<string> PerformOperation(HashSet<string> A, HashSet<string> B, HashSet<string> C)
        {
            var temp = B.Except(C);


            var Except = A.Except(temp);

            List<string> Result = Except.ToList();

            return Result;
        }
    }
}
