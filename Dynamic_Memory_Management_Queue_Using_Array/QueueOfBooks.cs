using System;
using System.Collections.Generic;
using System.Text;

namespace Dynamic_Memory_Management_Queue_Using_Array
{
    internal class QueueOfBooks
    {
        private Book[] queueOfBooks;
        private int size;
        private int position;

        public QueueOfBooks(int size)
        {
            position = -1;
            this.size = size;

        }

        public void Enqueue(Book book)
        {
            position++;
            queueOfBooks[position] = book;
        }
        public void Dequeue()
        {
            Book tempBook = queueOfBooks[0];

            for (int i = 0; i < position; i++)
                queueOfBooks[i] = queueOfBooks[i + 1];

            queueOfBooks[position] = tempBook;

            position--;

        }

        public int CountNotNullElements()
        {
            int count = 0;
            foreach (var item in queueOfBooks)
            {
                if (string.IsNullOrEmpty(item.ToString()))
                {
                    count++;
                }
            }

            return count;
        }

    }
}
