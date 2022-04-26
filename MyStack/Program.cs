using System;

namespace MyStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> myStack = new Stack<int>();
            for (int i = 1; i <= 3; i++)
            {
                myStack.Push(i);
            }

            Console.WriteLine(myStack.Peek());

            try
            {
                myStack.Pop();
                Console.WriteLine(myStack.Peek());
                myStack.Pop();
                Console.WriteLine(myStack.Peek());
                myStack.Pop();
                Console.WriteLine(myStack.Peek());
                myStack.Pop();
                Console.WriteLine(myStack.Peek());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
