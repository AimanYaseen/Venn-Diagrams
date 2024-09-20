using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Venn_Diagram
{
    class Complement
    {
        public void ExpressionSymbol(TextBox txtExp, string Exp)
        {
            txtExp.Text += Exp;
        }
        public List<string> PerformOperation(HashSet<string> A, HashSet<string> U)
        {


            var Except = U.Except(A);

            List<string> Result = Except.ToList();
            return Result;
        }

        
    }
}
