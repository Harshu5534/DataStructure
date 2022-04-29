using System;

namespace LinkedListProblem
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Program");
            LinkedList list= new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();

        }
    }
}
