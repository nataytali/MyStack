using System;

namespace MyStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
         
            try
            {
                Console.WriteLine(myStack.Peek());
                myStack.Pop();
                myStack.Pop();
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
