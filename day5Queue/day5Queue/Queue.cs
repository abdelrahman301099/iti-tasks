using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5Queue
{
    class Queue
    {
        int[] arr;
        int front;
        int rar;
        int size;
        int pointer;

        public Queue()
        {

            int front = 0;
            int rar = -1;
            pointer = 0;
            int size = 10;
            arr = new int[size];

        }
        public Queue(int _size)
        {
            front = 0;
            rar = -1;
            pointer = 0;
            size = _size;
            arr = new int[_size];
        }
        public void Add(int value)

        {
            if (pointer == size)
            {
                Console.WriteLine("is full");

            }
            else
            {
                rar = (rar + 1) % size;
                arr[rar] = value;
                pointer++;
            }

        }
     

        public int Delete()
        {
            if (pointer == 0)
            {
                Console.WriteLine("is empty");
            }

            int dequeuedItem = arr[front];
            front = (front + 1) % size;
            pointer--;

            
            for (int i = 0; i < pointer; i++)
            {
                int newI = (front + i) % size;
                arr[newI] = arr[(front + i + 1) % size];
            }

            rar = (size + rar - 1) % size; 
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
                Console.WriteLine(arr[index]);
                index = (index + 1) % size;
                count++;
            }
        }


    }
}
