using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Venn_Diagram
{
    class Union
    {
        public void ExpressionSymbol(TextBox txtExp, string Exp)
        {
            txtExp.Text += Exp;
        }

         public List<string> PerformOperation(HashSet<string> A, HashSet<string> B, HashSet<string> C) 
        {


            var UnionResult = A.Union(B).Union(C);
            List<string> Result = UnionResult.ToList();
                
            return Result;
        }

    }
}
