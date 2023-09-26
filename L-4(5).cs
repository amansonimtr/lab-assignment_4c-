using System;

class CustomList<T>
{
    private T[] items;

    public CustomList(int capacity)
    {
        items = new T[capacity];
    }

    public int Count { get; private set; }

    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= Count)
            {
                throw new IndexOutOfRangeException();
            }
            return items[index];
        }
        set
        {
            if (index < 0 || index >= Count)
            {
                throw new IndexOutOfRangeException();
            }
            items[index] = value;
        }
    }

    public void Add(T item)
    {
        if (Count == items.Length)
        {
            
            Array.Resize(ref items, items.Length * 2);
        }
        items[Count] = item;
        Count++;
    }

    public void RemoveAt(int index)
    {
        if (index < 0 || index >= Count)
        {
            throw new IndexOutOfRangeException();
        }

        for (int i = index; i < Count - 1; i++)
        {
            items[i] = items[i + 1];
        }

        Count--;
    }
}

class Program
{
    static void Main()
    {
        CustomList<int> myList = new CustomList<int>(3);

        myList.Add(1);
        myList.Add(2);
        myList.Add(3);

        Console.WriteLine("Element at index 0: " + myList[0]);
        Console.WriteLine("Element at index 1: " + myList[1]);
        Console.WriteLine("Element at index 2: " + myList[2]);

        myList[1] = 42; 
        Console.WriteLine("Element at index 1 after update: " + myList[1]);

        myList.RemoveAt(0); 
        Console.WriteLine("Element at index 0 after removal: " + myList[0]);

        Console.ReadLine();
    }
}
