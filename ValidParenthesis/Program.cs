using System;
using System.Collections.Generic;

namespace ValidParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string test1 = "";
            Console.WriteLine(IsValid(test1));

            string test4 = " ";
            Console.WriteLine(IsValid(test4));

            string test5 = null;
            Console.WriteLine(IsValid(test5));

            string test2 = "({[]})";
            Console.WriteLine(IsValid(test2));

            string test3 = "(]{][)";
            Console.WriteLine(IsValid(test3));
        }

        public static bool IsValid(string s)
        {
            if (String.IsNullOrEmpty(s) || String.IsNullOrWhiteSpace(s))
            {
                return false;
            }
            Stack<char> parenthesis = new Stack<char>();
            foreach(char brace in s)
            {
                if (brace == '(' || brace == '{' || brace == '[')
                {
                    parenthesis.Push(brace);
                    continue;
                }
                else if (brace == ')')
                {
                    if (parenthesis.Peek() == '(')
                    {
                        parenthesis.Pop();
                        continue;
                    }
                }
                else if (brace == '}')
                {
                    if (parenthesis.Peek() == '{')
                    {
                        parenthesis.Pop();
                        continue;
                    }
                }
                else if (brace == ']')
                {
                    if (parenthesis.Peek() == '[')
                    {
                        parenthesis.Pop();
                        continue;
                    }
                }
            }
            if (parenthesis.Count == 0)
            {
                return true;
            }
            else return false;
        }
    }
}
