using System;
using System.Collections.Generic;
using System.Text;

namespace dequeueArray
{
    class deqA
    {
        private int[] dequeueArray;
        private int front;
        private int rear;

        public deqA()
        {
            dequeueArray = new int[10];
            front = -1;
            rear = -1;
        }

        public deqA(int maxSize)
        {
            dequeueArray = new int[maxSize];
            front = -1;
            rear = -1;
        }

        public bool isEmpty()
        {
            return (front == -1);
        }

        public bool isFull()
        {
            return ((front == 0 && rear == dequeueArray.Length - 1) || (front == rear + 1));
        }

        public void InsertFront(int x)
        {
            if (isFull())
            {
                Console.WriteLine("Queue Overflow");
                return;
            }
            if (front == -1)
            {
                front = 0;
                rear = 0;
            }
            else if (front == 0)
                front = dequeueArray.Length - 1;
            else
                front = front - 1;
            dequeueArray[front] = x;
        }

        public void InsertRear(int x)
        {
            if (isFull())
            {
                Console.WriteLine("Queue Overflow");
                return;
            }
            if (front == -1)
                front = 0;
            if (rear == dequeueArray.Length - 1)
                rear = 0;
            else
                rear = rear + 1;
            dequeueArray[rear] = x;
        }

        public int DeleteFront()
        {
            if (isEmpty())
                throw new System.InvalidOperationException("Queue Underflow");
            int x = dequeueArray[front];

            if (front == rear)                    /*Only one element*/
            {
                front = -1;
                rear = -1;
            }
            else if (front == dequeueArray.Length - 1)
                front = 0;
            else
                front = front + 1;
            return x;
        }

        public int DeleteRear()
        {
            if (isEmpty())
                throw new System.InvalidOperationException("Queue Underflow");
            int x = dequeueArray[rear];

            if (front == rear)                    /*Only one element*/
            {
                front = -1;
                rear = -1;
            }
            else if (rear == 0)
                rear = dequeueArray.Length - 1;
            else
                rear = rear-1;
            return x;
        }

        public void Display()
        {
            int i = front;
            if (isEmpty())
            {
                Console.WriteLine("Queue is empty");
            }
            if(front<=rear)
            {
                while (i <= rear)
                {
                    Console.WriteLine(dequeueArray[i++] + " ");
                }
            }
            else
            {
                while (i <= dequeueArray.Length - 1)
                {
                    Console.WriteLine(dequeueArray[i++] + " ");
                }
                i = 0;
                while (i <= rear)
                {
                    Console.WriteLine(dequeueArray[i++] + " ");
                }
            }
        }

        public int Size()
        {
            int s=0;
            int i = front;
            if (isEmpty())
            {
                Console.WriteLine("Queue is empty");
            }
            if (isFull())
                return dequeueArray.Length - 1;
            if (front <= rear)
            {
                while (i <= rear)
                {
                    s++;
                    i++;
                }
            }
            else
            {
                while (i <= dequeueArray.Length - 1)
                {
                    s++;
                    i++;
                }
                i = 0;
                while (i <= rear)
                {
                    s++;
                    i++;
                }
            }
            return s;
        }

        public int Peek()
        {
            if (isEmpty())
                throw new System.InvalidOperationException("Queue Underflow");
            return dequeueArray[front];
        }
    }
}
