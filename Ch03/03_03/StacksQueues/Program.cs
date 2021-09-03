using System;
using System.Collections.Generic;

namespace StacksQueues
{
    class Program
    {
        static void Main(string[] args) {
            // Create a new stack to hold the names of sports
            Stack<string> sportsStack = new Stack<string>();
            // Push some initial items on to the stack
            sportsStack.Push("Baseball");
            sportsStack.Push("Football");
            sportsStack.Push("Cricket");
            sportsStack.Push("Basketball");
            sportsStack.Push("Hockey");
            sportsStack.Push("Rugby");

            // TODO: Let's see how many items are on the stack

            // TODO: Peek at the top item

            // TODO: Pop 2 items, then try the Contains method

            // Create a queue to hold the names of sports
            Queue<string> sportsQueue = new Queue<string>();
            // Enqueue some initial items on to the stack
            sportsQueue.Enqueue("Baseball");
            sportsQueue.Enqueue("Football");
            sportsQueue.Enqueue("Cricket");
            sportsQueue.Enqueue("Basketball");
            sportsQueue.Enqueue("Hockey");
            sportsQueue.Enqueue("Rugby");

            // TODO: Let's see how many items are on the queue

            // TODO: Peek at the front item

            // TODO: Dequeue 2 items, then try the Contains method

            // Keep the window open
            Console.WriteLine("\nPress Enter key to continue...");
            Console.ReadLine();
        }
    }
}
