﻿using System;

namespace List
{
    class List
    {
        public bool IsEmpty => Size == 0;
        public Element head;
        public int Size { get;  set; }

        public class Element
        {
            public string Data { get; set; }
            public Element Next { get; set; }
            public Element Previous { get; set; }
            public Element(string data)
            {
                Data = data;
            }
        }
        public void Append(int index, string data)
        {
            if (index < 0 || index > Size)
            {
                Console.WriteLine("Wrong Index");
                return;
            }
            var thisElement = new Element(data);
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

        public void Printing()
        {
            Element current = head;
            if (IsEmpty)
            {
                Console.WriteLine("List is empty");
                return;
            }
            while (current != null)
            {
                Console.WriteLine(current.Data + " ");
                current = current.Next;
            }
        }

        public string this[int index]
        {
            get
            {
                if (GetElement(index) == null)
                {
                    return "Wrong Index!";
                }
                return GetElement(index).Data;
            }
            set
            {
                if (GetElement(index) == null)
                {
                    return;
                }
                GetElement(index).Data = value;
            }
        }

        public Element GetElement(int index)
        {
            if (index < 0 || index > Size)
            {
                return default;
            }
            Element current = head;
            for (int i = 0; i < index; ++i)
            {
                current = current.Next;
            }
            return current;
        }
    }
}