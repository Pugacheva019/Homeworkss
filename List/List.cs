using System;

namespace List
{
    class List
    {
        public bool IsEmpty => Size == 0;

        private ListElement head;

        public int Size;

        private class ListElement
        {
            public string Data { get; set; }

            public ListElement Next { get; set; }

            public ListElement(string data)
            {
                Data = data;
            }
        }

        public void Append(int index, string data)
        {
            if (index < 0 || index > Size)
            {
                Console.WriteLine("Wrong Index!");
                return;
            }
            var newElement = new ListElement(data);
            if (index == 0)
            {
                newElement.Next = this.head;
                this.head = newElement;
                Size++;
                return;
            }
            var currentElement = head;
            for (int i = 0; i < index - 1; i++)
            {
                currentElement = currentElement.Next;
            }
            newElement.Next = currentElement.Next;
            currentElement.Next = newElement;
            Size++;
        }

        public void Remove(int index)
        {
            if (index < 0 || index >= Size)
            {
                Console.WriteLine("Wrong Index!");
                return;
            }
            ListElement current = head;
            if (index == 0)
            {
                head = head.Next;
                Size--;
                return;
            }
            for (int i = 0; i < index - 1; i++)
            {
                current = current.Next;
            }
            current.Next = current.Next.Next;
            Size--;
        }

        public void Print()
        {
            ListElement current = head;
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

        private ListElement GetElement(int index)
        {
            if (index < 0 || index > Size)
            {
                return null;
            }
            ListElement current = head;
            for (int i = 0; i < index; ++i)
            {
                current = current.Next;
            }
            return current;
        }
    }
}