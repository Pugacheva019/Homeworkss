using System;
using System.Collections.Generic;
using System.Linq;

namespace Test1
{
    /// <summary>
    /// Priority queue's class
    /// </summary>
    public class Queue<T, TItem>
    {
        readonly SortedDictionary<T, Queue<TItem>> Queues;

        public Queue(IComparer<T> priorityComparer)
        {
            Queues = new SortedDictionary<T, Queue<TItem>>(priorityComparer);
        }

        public Queue() : this(Comparer<T>.Default) { }

        public void Enqueue(T priority, TItem item)
        {
            if (!Queues.ContainsKey(priority))
            {
                Add(priority);
            }

            Queues[priority].Enqueue(item);
        }

        private void Add(T priority)
        {
            Queues.Add(priority, new Queue<TItem>());
        }

        public TItem Dequeue()
        {
            if (Queues.Any())
                return Dequeue2();
            else
                throw new EmptyQueue("The queue is empty");
        }

        private TItem Dequeue2()
        {
            KeyValuePair<T, Queue<TItem>> one = Queues.First();
            TItem Item = one.Value.Dequeue();
            if (!one.Value.Any())
            {
                Queues.Remove(one.Key);
            }
            return Item;
        }
    }
}
