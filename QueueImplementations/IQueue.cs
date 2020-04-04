using System;
using System.Collections.Generic;
using System.Text;

namespace QueueImplementations
{
    public interface IQueue
    {
        void Enqueue(int item);
        int Dequeue();
        int Peek();
    }
}
