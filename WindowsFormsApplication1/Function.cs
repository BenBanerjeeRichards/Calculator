using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{

    class Function
    {
        private List<string> expr;

        private List<string> args;
        private string name;

        public Function(string name, List<string> expr, List<string> args)
        {
            this.expr = expr;
            this.args = args;
            this.name = name;

            int i = 0;

            // Each variable needs to be prefixed with _ to prevent collisions with user defined variables
            // Much simplier than implementing variable namespaces

            foreach (string token in expr.ToList())
            {
                if (isFunctionArgs(token)) 
                {
                    expr[i] = "_" + token;
                }

                i++;
            }

        }

        public List<Variable> getVariablesForArgs(List<string> argsValues)
        {
            List<Variable> variables = new List<Variable>();

            int i = 0;

            foreach (var argsValue in argsValues)
            {
                if (args.Count <= i)
                {
                    // It is up to the calling object to verify values are not null
                    variables.Add(null);
                }
                else
                {
                    variables.Add(new Variable("_" + args[i++], argsValue, false));
                }
            }

            return variables;
        }

        private bool isFunctionArgs(string token)
        {
            foreach (string arg in args)
            {
                if (token.Equals(arg))
                {
                    return true;
                }
            }

            return false;
        }

        public List<string> getExpr()
        {
            return expr;
        }

        public string getName()
        {
            return name;
        }

        public int getNumberArguments()
        {
            return args.Count();
        }

        public void setExpr(List<string> expr)
        {
            this.expr = expr;
        }

    }
}
