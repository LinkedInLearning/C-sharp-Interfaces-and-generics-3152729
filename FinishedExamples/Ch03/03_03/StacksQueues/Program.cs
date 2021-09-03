using System;
using System.Collections.Generic;

namespace StacksQueues
{
    class Program
    {
        static void Main(string[] args) {
            // create a new stack to hold the names of sports
            Stack<string> sportsStack = new Stack<string>();
            // Push some items on to the stack
            sportsStack.Push("Baseball");
            sportsStack.Push("Football");
            sportsStack.Push("Cricket");
            sportsStack.Push("Basketball");
            sportsStack.Push("Hockey");
            sportsStack.Push("Rugby");

            // Let's see how many items are on the stack
            Console.WriteLine("There are {0} sports in the stack.", sportsStack.Count);

            // Peek at the top item
            Console.WriteLine("The top item is {0}", sportsStack.Peek());

            // Pop 2 items, then try the Contains method
            sportsStack.Pop();
            sportsStack.Pop();
            Console.WriteLine("Stack contains Hockey: {0}", sportsStack.Contains("Hockey"));

            // QUEUE
            Queue<string> sportsQueue = new Queue<string>();
            // Enqueue some initial items on to the stack
            sportsQueue.Enqueue("Baseball");
            sportsQueue.Enqueue("Football");
            sportsQueue.Enqueue("Cricket");
            sportsQueue.Enqueue("Basketball");
            sportsQueue.Enqueue("Hockey");
            sportsQueue.Enqueue("Rugby");

            // Let's see how many items are on the queue
            Console.WriteLine("\nThere are {0} sports in the queue.", sportsQueue.Count);

            // Peek at the front item
            Console.WriteLine("The front item is {0}", sportsQueue.Peek());

            // Dequeue 2 items, then try the Contains method
            sportsQueue.Dequeue();
            sportsQueue.Dequeue();
            Console.WriteLine("Queue contains Hockey: {0}", sportsQueue.Contains("Hockey"));

            Console.WriteLine("\nPress Enter key to continue...");
            Console.ReadLine();
        }
    }
}
