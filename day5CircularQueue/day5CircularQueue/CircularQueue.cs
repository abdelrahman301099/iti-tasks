using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5CircularQueue
{
   class CircularQueue
    {
        private int[] items;
        private int front;
        private int rear;
        private int pointer;
        private int capacity;

        public CircularQueue(int _capacity)
        {
            capacity = _capacity;
            items = new int[capacity];
            front = rear = -1;
            pointer = 0;
        }

        public void Add(int item)
        {
            if ((rear + 1) % capacity == front)
            {
                Console.WriteLine("Fullll");
                return;
            }

            if (front == -1)
            {
                front = 0;
            }

            rear = (rear + 1) % capacity;
            items[rear] = item;
            pointer++;
        }

        public int Delete()
        {
            if (front == -1)
            {
                Console.WriteLine("Emptyyy");
                return -1;
            }

            int dequeuedItem = items[front];

            if (front == rear)
            {
                front = rear = -1;
            }
            else
            {
                front = (front + 1) % capacity;
            }

            pointer--;
            return dequeuedItem;
        }

        public void PrintQueue()
        {
            if (front == -1)
            {
                Console.WriteLine("Queue is empty.");
                return;
            }

            Console.WriteLine("Queue elements:");
            int count = 0;
            int index = front;
            while (count < pointer)
            {
                Console.WriteLine(items[index]);
                index = (index + 1) % capacity;
                count++;
            }
        }

        //public bool IsEmpty()
        //{
        //    return front == -1;
        //}

        //public bool IsFull()
        //{
        //    return (rear + 1) % capacity == front;
        //}

        //public int Size()
        //{
        //    return pointer;
        //}
    }

}

