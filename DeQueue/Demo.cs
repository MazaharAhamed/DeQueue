using dequeueArray;
using System;

namespace DeQueue
{
    class Demo
    {
        static void Main(string[] args)
        {
            int choice, x;

            deqA dq = new deqA(8);

            while (true)
            {
                Console.WriteLine("1.Insert at front end");
                Console.WriteLine("2.Insert at rear end");
                Console.WriteLine("3.Delete from front end");
                Console.WriteLine("4.Delete from rear end");
                Console.WriteLine("5.Queue Size");
                Console.WriteLine("6.Front element in Queue");
                Console.WriteLine("7.Display all elements");
                Console.WriteLine("8.Quit");
                Console.WriteLine("Enter your choice:");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 8)
                    break;

                switch(choice)
                {
                    case 1:
                        Console.WriteLine("Enter element to insert at front end");
                        x = Convert.ToInt32(Console.ReadLine());
                        dq.InsertFront(x);
                        break;
                    case 2:
                        Console.WriteLine("Enter element to insert at rear end");
                        x = Convert.ToInt32(Console.ReadLine());
                        dq.InsertRear(x);
                        break;
                    case 3:
                        Console.WriteLine("Deleted element from front end is: " + dq.DeleteFront());
                        break;
                    case 4:
                        Console.WriteLine("Deleted element from rear end is: " + dq.DeleteRear());
                        break;
                    case 5:
                        Console.WriteLine("Queue Size is: " + dq.Size());
                        break;
                    case 6:
                        Console.WriteLine("Front Element in Queue is: " + dq.Peek());
                        break;
                    case 7:
                        dq.Display();
                        break;
                    default:
                        Console.WriteLine("Wrong Choice");
                        break;
                }
                Console.WriteLine("");
            }
        }
    }
}
