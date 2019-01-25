using System;
using MultiBracketValidation.classes;

namespace MultiBracketValidation
{
    public class Program
    {
        static void Main(string[] args)
        {
            string wordTrue = "bob(is)co[oo[l]Hell]o";
            MultiBracketValidation2(wordTrue);

            string wordFalse = "bob(is)co[oo[l.Hell]o";
            MultiBracketValidation2(wordFalse);
        }

        public static bool MultiBracketValidation2(string input)
        {
            Stack stack = new Stack();
            char[] inputArray = input.ToCharArray();
            foreach (char item in inputArray)
            {
                switch (item)
                {
                    case '[':
                        stack.Push(item);
                        break;
                    case '(':
                        stack.Push(item);
                        break;
                    case '{':
                        stack.Push(item);
                        break;
                    case ']':
                        if (stack.Top.Value == '[')
                        {
                            stack.Pop();
                        }
                        break;
                    case ')':
                        if (stack.Top.Value == '(')
                        {
                            stack.Pop();
                        }
                        break;
                    case '}':
                        if (stack.Top.Value == '{')
                        {
                            stack.Pop();
                        }
                        break;
                }
            }

            if (stack.Top == null)
            {
                Console.WriteLine("Stack is empty - {0} returns TRUE", input);
                return true;

            }
            else
            {
                Console.WriteLine("Stack is not empty - {0} returns FALSE", input);
                return false;
            }
        }
    }
}