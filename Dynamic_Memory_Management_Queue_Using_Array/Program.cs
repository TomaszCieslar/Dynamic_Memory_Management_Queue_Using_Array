using System;

namespace Dynamic_Memory_Management_Queue_Using_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implementing a queue using array

            QueueOfBooks q = new QueueOfBooks(2);
            q.Enqueue(new Book("title1"));
            q.Enqueue(new Book("title2"));

            q.CountNotNullElements();

            q.Dequeue();
            q.Dequeue();

            q.CountNotNullElements();
        }
    }
}
