using System;

namespace ListProgram
{
    /// <summary>
    /// Class for List.
    /// </summary>
    class List
    {
        /// <summary>
        /// list is empty or not.
        /// </summary>
        public bool IsEmpty => Size == 0;

        /// <summary>
        /// Top of the list.
        /// </summary>
        private Element head;

        /// <summary>
        /// The size of the list.
        /// </summary>
        public int Size { get; set; }

        /// <summary>
        /// Class of the element of the list.
        /// </summary>
        /// <param name="data">String value.</param>
        /// <param name="key">Key of the element.</param>
        public class Element
        {
            public int Key { get; set; }
            public string Data { get; set; }
            public Element Next { get; set; }
            public Element Previous { get; set; }
            public Element(string data, int key)
            {
                Data = data;
                Key = key;
            }
        }

        /// <summary>
        /// Method of adding elements to the list.
        /// </summary>
        /// <param name="index">Position of the element.</param>
        /// <param name="data">String value.</param>
        /// <param name="key">Key of the element.</param>
        public void Append(int key, int index, string data)
        {
            if (index < 0 || index > Size)
            {
                return;
            }
            var thisElement = new Element(data, key);
            Element current = head;
            int currentIndex = 0;
            if (index == 0)
            {
                Element temp = head;
                head = thisElement;
                head.Next = temp;
                ++Size;
            }
            else if (index == Size)
            {
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = thisElement;
                ++Size;
            }
            else
            {
                while (current != null)
                {
                    if (currentIndex == index)
                    {
                        thisElement.Next = current;
                        thisElement.Previous = current.Previous;
                        if (thisElement.Previous != null)
                        {
                            thisElement.Previous.Next = thisElement;
                        }
                        ++Size;
                    }
                    current = current.Next;
                }
            }
        }

        /// <summary>
        /// Method for removing elements.
        /// </summary>
        public void Remove(int index)
        {
            if (index < 0 || index > Size)
            {
                Console.WriteLine("Wrong Index!");
                return;
            }
            Element current = head;
            Element currentPrevious = null;
            int currentIndex = 0;
            while (current != null)
            {
                if (currentIndex == index)
                {
                    if (currentPrevious == null)
                    {
                        head = head.Next;
                    }
                    else
                    {
                        currentPrevious.Next = current.Next;
                    }
                    --Size;
                }
                ++currentIndex;
                currentPrevious = current;
                current = current.Next;
            }
        }

        /// <summary>
        /// Method for removing elements by key.
        /// </summary>
        public void RemoveByKey(int key)
        {
            var current = head;
            for (int i = 0; i < Size; i++)
            {
                if (current.Key == key)
                {
                    string currentData = current.Data;
                    RemoveData(currentData);
                }
                current = current.Next;
            }
        }

        /// <summary>
        /// Method for removing elements by data.
        /// </summary>
        private void RemoveData(string data)
        {
            Element current = head;
            Element previous = null;
            while (current != null)
            {
                if (current.Data == data)
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;
                    }
                    else
                    {
                        head = head.Next;
                    }
                    --Size;
                }
                previous = current;
                current = current.Next;
            }
        }

        /// <summary>
        /// Method for finding elements by key.
        /// </summary>
        public bool Finding(int key)
        {
            var current = head;
            for (int i = 0; i < Size; i++)
            {
                if (current.Key == key)
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        /// <summary>
        /// Method for printing elements.
        /// </summary>
        public void Printing()
        {
            Element current = head;
            while (current != null)
            {
                Console.WriteLine(current.Data + " ");
                current = current.Next;
            }
        }
    }
}