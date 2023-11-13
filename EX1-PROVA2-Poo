using System;
using System.Collections.Generic;


namespace prova2ex1
{
    internal class Pilha

    {
        private List<char> stack;

        public Pilha()
        {
            stack = new List<char>();
        }

        public void Push(char c)
        {
            stack.Add(c);
        }

        public char Pop()
        {
            char c = stack[stack.Count - 1];
            stack.RemoveAt(stack.Count - 1);
            return c;
        }

        public bool IsEmpty()
        {
            return stack.Count == 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string expression = "{5*[a+b]-d*(c-a)+log10}";
            Console.WriteLine(CheckExpression(expression));
        }

        static bool CheckExpression(string expression)
        {
            Pilha stack = new Pilha();

            foreach (char c in expression)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == ']' || c == '}')
                {
                    if (stack.IsEmpty())
                    {
                        return false;
                    }

                    char top = stack.Pop();

                    if ((c == ')' && top != '(') || (c == ']' && top != '[') || (c == '}' && top != '{'))
                    {
                        return false;
                    }
                }
            }

            return stack.IsEmpty();
        }
    }

}

