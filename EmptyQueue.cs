using System;
namespace Test1
{
    /// <summary>
    /// Exception for dequeuing an element from empty queue
    /// </summary>
    public class EmptyQueue : Exception
    {
        public EmptyQueue() { }
        public EmptyQueue(string message) : base(message) { }
        public EmptyQueue(string message, Exception inner) : base(message, inner) { }
        protected EmptyQueue(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
