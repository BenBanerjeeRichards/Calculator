using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Calculator
    {
        private List<Variable> variables = new List<Variable>();
        private List<Function> functions = new List<Function>();

        public Calculator()
        {
            variables.Add(new Variable("pi", Math.PI, true));
            variables.Add(new Variable("e", Math.E, true));
            variables.Add(new Variable("phi", (1 + Math.Sqrt(5)) / 2, true));
        }

        public CalculatorMessage evalulate(string expr)
        {
            return evalulateExpression(tokenise(expr));
        }

        public CalculatorMessage evalulateExpression(List<string> expression)
        {
            // Check if the expression is an assignment
            if (expression.Contains("="))
            {
                // assignments require more processing 
                List<List<string>> assignment = splitListByCharacter(expression, "=");

                // Check assignment actually exists
                if (assignment[0].Count == 0 || assignment[1].Count == 0)
                {
                    return new CalculatorMessage(Status.ERROR, "Malformed Expression", "evalulateExpression_2: blank assignment");
                }

                // Now, figure out if the assignment is a function or variable assignment
                if (assignment[0].Count == 1)
                {
                    // Check the variable name is valid
                    if (!isValidAssignmentName(assignment[0][0]))
                    {
                        return new CalculatorMessage(Status.ERROR, "Assignment names can only consist of a-z, A-Z", "evalulateExpression_3");
                    }

                    // Must be a variable, as the left side can only have one token (we don't do algebra :-) )
                    expression = processVariables(assignment[1]);
                    CalculatorMessage calcMessage = evalulate(expression);

                    if (calcMessage.getStatus() == Status.SUCCESS)
                    {
                        // Expression evalulated OK
                        if (addVariable(new Variable(assignment[0][0], calcMessage.getBody(), false)))
                        {
                            return calcMessage;
                        }
                        else
                        {
                            return new CalculatorMessage(Status.ERROR, "Can't change value of constant", "evalulateExpression_4");
                        }
                    }

                } else
                {
                    // If the program gets here, the only valid option is a function
                    int length = assignment[0].Count();

                    if (length < 4)
                    {
                        return new CalculatorMessage(Status.ERROR, "Malformed Expression", "evalulateExpression_5: Function");
                    }

                    if (!isValidAssignmentName(assignment[0][0]))
                    {
                        return new CalculatorMessage(Status.ERROR, "Malformed Expression", "evalulateExpression_6: Function");
                    }

                    if (!assignment[0][1].Equals("(") || !assignment[0][length-1].Equals(")"))
                    {
                        return new CalculatorMessage(Status.ERROR, "Malformed Expression", "evalulateExpression_7: Function");
                    }

                    string name = assignment[0][0];

                    // Protect against recursive functions 
                    if (assignment[1].Contains(name))
                    {
                        return new CalculatorMessage(Status.ERROR, "Recursive Function", "evalulateExpression_58");
                    }

                    List<string> args = new List<string>();
                    
                    // Parse the arguments
                    for (int i = 2; i <= (length -2); i++)
                    {
                        if ((i % 2) == 0)
                        {
                            if (isValidAssignmentName(assignment[0][i]))
                            {
                                if (args.Contains(assignment[0][i]))
                                {
                                    return new CalculatorMessage(Status.ERROR, "Malformed Expression: Duplicate Argument", "evalulateExpression_8");
                                }
                                args.Add(assignment[0][i]);
                            }
                            else
                            {
                                return new CalculatorMessage(Status.ERROR, "Malformed Expression", "evalulateExpression_8: Function");
                            }
                        }
                        else
                        {
                            if (!assignment[0][i].Equals(","))
                            {
                                return new CalculatorMessage(Status.ERROR, "Malformed Expression", "evalulateExpression_9: Function");
                            }
                        }
                    }

                    // Check the function name: prevent it from overwriting a core function, such as sin(x)
                    if (isNativeFunction(name))
                    {
                        return new CalculatorMessage(Status.ERROR, "Can't overwrite native function", "evalulateExpression_14");
                    }

                    // Create the function 
                    Function fn = new Function(name, assignment[1], args);

                    // Now, we check the expression is valid 
                    // We don't care about using the following value, just check it is successfull
                    List<string> testArgs = new List<string>();

                    for (int i = 0; i < args.Count(); i++)
                    {
                        testArgs.Add("1");
                    }

                    CalculatorMessage calcMessage = evalulateFunction(fn, testArgs);

                    if (calcMessage.getStatus() == Status.ERROR)
                    {
                        return calcMessage;
                    }

                    addFunction(fn);


                   return new CalculatorMessage(Status.SUCCESS, "", "evalulateExpression_11: Created Function");
                }
            }
            else
            {
                // Standard Expression
                expression = processVariables(expression);

                return evalulate(expression);
            }

            return new CalculatorMessage(Status.ERROR, "Malformed Expression", "evalulate_1: ");

        }

        private List<string> tokenise(string expr)
        {
            List<string> tokens = new List<string>();
            string regex = @"([a-zA-Z]+)|=|-?[0-9]+\.?[0-9]{0,}|\(|\)|\+|\-|\*|\/|\^";

            foreach (Match m in Regex.Matches(expr, regex))
            {
                tokens.Add(m.Value);
            }

            foreach (var t in tokens)
            {
                Console.Write(t + " ");
            }

            Console.WriteLine();

            return tokens;
        }

        private CalculatorMessage evalulateFunction(Function fn, List<string> args)
        {
            List<Variable> variables = fn.getVariablesForArgs(args);

            
            if (variables.Contains(null))
            {
                return new CalculatorMessage(Status.ERROR, "Malformed Expression", "evalulateFunction_10: Null in Variables");
            }
            

            if (!addVariables(variables))
            {
                Console.WriteLine("Failed to add variables");
            }

            List<string> exprCopy = fn.getExpr().ToList();
            List<string> expr = processVariables(fn.getExpr());

            fn.setExpr(exprCopy);
            return evalulate(expr);
        }

        private List<List<string>> splitListByCharacter(List<string> list, string token)
        {
            List<List<string>> parts = new List<List<string>>();

            int tokenPos = list.IndexOf(token);

            parts.Add(new List<string>());
            parts.Add(new List<string>());

            for (int i = 0; i < tokenPos; i++)
            {
                parts[0].Add(list[i]);
            }

            for (int i = tokenPos + 1; i < list.Count; i++)
            {
                parts[1].Add(list[i]);
            }

            return parts;
        }

        private List<string> processVariables(List<string> tokens)
        {
            foreach (string token in tokens.ToList())
            {
                if (isVariable(token))
                {
                    // Subsitute variable in
                    int place = tokens.IndexOf(token);
                    tokens[place] = variables.Where(v => v.getName() == token).Select(v => v.getValue()).First();
                }
            }

            return tokens;
        }

        private List<string> getFunctionArgs(List<string> function)
        {
            // Get the arguments from a function 
            List<string> args = new List<string>();

            for (int i = 2; i <= (function.Count() - 2); i++)
            {
                if ((i % 2) != 2)
                {
                    args.Add(function[i]);
                }
            }

            return args;

        }

        private bool isVariable(string name)
        {
            var query = variables.Where(v => v.getName().Equals(name));
            return !(query.Count() == 0);
        } 

        private bool isUserFunction(string name)
        {
            var query = functions.Where(f => f.getName().Equals(name));
            return !(query.Count() == 0);
        }

        private CalculatorMessage evalulate(List<string> tokens)
        {
            // Shunting Yard Algorithm
            Stack<string> stack = new Stack<string>();
            Queue<string> queue = new Queue<string>();

            foreach (string token in tokens)
            {
                // Number
                if (isNumber(token))
                {
                    queue.Enqueue(token);
                }

                // Function
                if (isNativeFunction(token) || isUserFunction(token))
                {
                    stack.Push(token);
                }

                // Function argument seperator
                if (token.Equals(","))
                {
                    string nextToken = safeStackPeek(stack);

                    while (!safeStackPeek(stack).Equals("("))
                    {
                        queue.Enqueue(stack.Pop());
                    }
                }

                // Handle Operators
                if (isOperator(token))
                {

                    while (isOperator(safeStackPeek(stack)))
                    {
                        if (getAssociativity(token).Equals("left") && (getPrecedence(token) <= getPrecedence(stack.Peek())))
                        {
                            queue.Enqueue(stack.Pop());
                            continue;
                        }

                        else if (getAssociativity(stack.Peek()).Equals("right") && (getPrecedence(token) < getPrecedence(stack.Peek())))
                        {
                            queue.Enqueue(stack.Pop());
                            continue;
                        }
                        break;
                    }
                    stack.Push(token);
                }

                if (token.Equals("("))
                {
                    stack.Push(token);
                }

                // Deal with brackets
                if (token.Equals(")"))
                {

                    while (!safeStackPeek(stack).Equals("("))
                    {
                        queue.Enqueue(stack.Pop());

                        if (safeStackPeek(stack).Equals(""))
                        {
                            return new CalculatorMessage(Status.ERROR, "Mismatched Braces", "evalulate_1: Stack Empty");
                        }
                    }

                    stack.Pop();
                }

            }

            while (!safeStackPeek(stack).Equals(""))
            {
                queue.Enqueue(stack.Pop());

            }

            List<string> rpn = new List<string>();

            while (queue.Count != 0)
            {
                rpn.Add(queue.Dequeue());
            }

            foreach (string t in rpn)
            {
                Console.Write(" " + t);
            }
            Console.WriteLine();

            return evalulateRPN(rpn);
        }

        private CalculatorMessage evalulateRPN(List<string> rpnTokens)
        {
            Stack<string> stack = new Stack<string>();

          
            foreach (string token in rpnTokens)
            {

                if (isNumber(token))
                {
                    stack.Push(token);
                }

                if (isOperator(token))
                {
                    Console.WriteLine(token);
                    if (stack.Count < 2)
                    {
                        return new CalculatorMessage(Status.ERROR, "Malformed Expression", "evalulateRPN_1: Stack Empty");
                    }

                    // Operators always have two sides - left and right
                    string right = stack.Pop();
                    string left = stack.Pop();

                    CalculatorMessage answerMessage = applyOperation(token, stringToDecimal(left), stringToDecimal(right));

                    if (answerMessage.getStatus() == Status.SUCCESS)
                    {
                        stack.Push(answerMessage.getBody());
                    }
                    else
                    {
                        return answerMessage;
                    }
                } if (isNativeFunction(token))
                {
                    // All native functions require one argument
                    if (stack.Count < 1)
                    {
                        return new CalculatorMessage(Status.ERROR, "Malformed Expression", "evalulateRPN_2: Stack Empty");
                    }

                    CalculatorMessage functionMessage = applyNativeFunction(token, stringToDecimal(stack.Pop()));

                    if (functionMessage.getStatus() == Status.SUCCESS)
                    {
                        stack.Push(functionMessage.getBody());
                    }
                    else
                    {
                        return functionMessage;
                    }

                } if (isUserFunction(token))
                {
                   
                    // User defined function
                    Function function = functions.Where(f => f.getName().Equals(token)).First();
                    List<string> e = function.getExpr();

                    int argsCount = function.getNumberArguments();

                    if (stack.Count < argsCount)
                    {
                        return new CalculatorMessage(Status.ERROR, "Malformed Expression", "evalulateRPN_3: Stack Empty");
                    }

                    List<string> args = new List<string>();

                    for (int i = 0; i < argsCount; i++)
                    {
                        args.Add(stack.Pop());
                    }

                    CalculatorMessage functionMessage = evalulateFunction(function, args);

                    if (functionMessage.getStatus() == Status.SUCCESS)
                    {
                        stack.Push(functionMessage.getBody());
                    }
                    else
                    {
                        return functionMessage;
                    }
                }
            }

            Decimal result;

            if (stack.Count == 0)
            {
                return new CalculatorMessage(Status.ERROR, "Malformed Expression", "evalulateRPN_3: Stack Empty");
            }

            if (Decimal.TryParse(stack.Pop(), out result))
            {
                return new CalculatorMessage(Status.SUCCESS, result.ToString());
            }

            return new CalculatorMessage(Status.ERROR, "Malformed Expression", "evalulateRPN_4");
        }

        private Decimal stringToDecimal(string str)
        {
            bool isNegative = false;
            if (str.First().ToString().Equals("u") && str.Length != 1)
            {
                // negative 
                str = str.Substring(1, str.Length - 1);
                isNegative = true;
            }

            Decimal dec = new Decimal();

            if (Decimal.TryParse(str, out dec))
            {
                return isNegative ? dec * -1 : dec;
            }

            Console.WriteLine("stringToDecimal: failed convertion " + str);
            return new Decimal();

        }

        private CalculatorMessage applyOperation(string op, Decimal left, Decimal right)
        {
            switch (op)
            {
                case "+":
                    return new CalculatorMessage(Status.SUCCESS, (left + right).ToString());
                case "-":
                    return new CalculatorMessage(Status.SUCCESS, (left - right).ToString());
                case "*":
                    return new CalculatorMessage(Status.SUCCESS, (left * right).ToString());
                case "/":
                    if (right == 0)
                    {
                        // Divide by zero
                        return new CalculatorMessage(Status.ERROR, "Divide by Zero", "applyOperation_1");
                    }
                    return new CalculatorMessage(Status.SUCCESS, (left / right).ToString());
                case "^":
                    return new CalculatorMessage(Status.SUCCESS, (Math.Pow((double)left, (double)right)).ToString());
            }

            return new CalculatorMessage(Status.ERROR, "Internal Application Error: Unable to apply operation", "applyOperation_1");
        }

        private CalculatorMessage applyNativeFunction(string token, Decimal value)
        {
            // TODO implement rad-deg-grad settings

            switch (token)
            {
                case "sin":
                    return new CalculatorMessage(Status.SUCCESS, (Math.Sin((double)value).ToString()));
                case "cos":
                    return new CalculatorMessage(Status.SUCCESS, (Math.Cos((double)value).ToString()));
                case "tan":
                    return new CalculatorMessage(Status.SUCCESS, (Math.Tan((double)value).ToString()));
                case "asin":
                    return new CalculatorMessage(Status.SUCCESS, (Math.Asin((double)value).ToString()));
                case "acos":
                    return new CalculatorMessage(Status.SUCCESS, (Math.Acos((double)value).ToString()));
                case "atan":
                    return new CalculatorMessage(Status.SUCCESS, (Math.Atan((double)value).ToString()));
                case "sqrt":
                    return new CalculatorMessage(Status.SUCCESS, (Math.Sqrt((double)value).ToString()));
                case "log":
                    return new CalculatorMessage(Status.SUCCESS, (Math.Log10((double)value).ToString()));
                case "ln":
                    return new CalculatorMessage(Status.SUCCESS, (Math.Log((double)value).ToString()));
                default:
                    return new CalculatorMessage(Status.ERROR, "Internal Error", "applyNativeFunction_1: No Function Found: Internal Error");
            }
        }

        private int getPrecedence(string token)
        {
            switch (token)
            {
                case "^":
                    return 4;
                case "*":
                case "/":
                    return 3;
                case "+":
                case "-":
                    return 2;
                default:
                    return 0;
            }
        }

        private string getAssociativity(string token)
        {
            switch (token)
            {
                case "^":
                    return "right";
                case "*":
                case "/":
                case "+":
                case "-":
                    return "left";
                default:
                    return "none";
            }
        }

        private bool isOperator(string token)
        {
            return Regex.Match(token, "^[+\\-\\*/\\^%]${1}", RegexOptions.None).Success;
        }

        private bool isNumber(string token)
        {
            return Regex.Match(token, "^u?[0-9]+\\.?[0-9]{0,}$", RegexOptions.None).Success;
        }

        private bool isNativeFunction(string token)
        {
            return Regex.Match(token, "^sin|cos|tan|asin|acos|atan|sqrt|log|ln$", RegexOptions.None).Success;
        }

        private void debugStack(Stack<string> s)
        {
            // prints out the contents of the stack 

            Stack<string> stack = new Stack<string>(s);

            Console.WriteLine("============= STACK =============");

            while (stack.Count != 0)
            {
                Console.WriteLine(stack.Pop());
            }


        }

        private void debugStackQueue(Stack<string> s, Queue<string> q, string message)
        {
            // prints out the contents of the stack and queue

            // Copy the stack and queue so we don't delete the items
            Queue<string> queue = new Queue<string>(q);
            Stack<string> stack = new Stack<string>(s);

            Console.WriteLine(message);
            Console.WriteLine("============= STACK =============");

            while (stack.Count != 0)
            {
                Console.WriteLine(stack.Pop());
            }

            Console.WriteLine("============= QUEUE =============");

            while (queue.Count != 0)
            {
                Console.WriteLine(queue.Dequeue());

            }
        }

        private string safeStackPeek(Stack<string> stack)
        {
            return (stack.Count == 0) ? "" : stack.Peek();
        }

        public void addFunction(Function function)
        {
            functions.RemoveAll(f => f.getName().Equals(function.getName()));
            functions.Add(function);
        }

        private bool addVariable(Variable variable)
        {
            foreach (var v in variables)
            {
                if (v.getName().Equals(variable.getName()) && v.isConstant())
                {
                    // Can't replace a constast variable such as PI
                    return false;
                }
            }

            variables.RemoveAll(v => v.getName().Equals(variable.getName()));
            variables.Add(variable);
            return true;

        }

        private bool addVariables(List<Variable> variables)
        {
            foreach (var variable in variables)
            {
                if (!addVariable(variable))
                {
                    return false;
                }
            }

            return true;
        }

        private bool isValidAssignmentName(string name)
        {
            return Regex.Match(name, "[a-zA-Z]+", RegexOptions.None).Success;
        }

    }
}
