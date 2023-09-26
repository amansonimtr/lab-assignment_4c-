using System;

class SimpleStack<T>
{
    private T[] items;
    private int top; 

    public SimpleStack(int capacity)
    {
        items = new T[capacity];
        top = -1;
    }

    public int Count
    {
        get { return top + 1; }
    }

    public bool IsEmpty
    {
        get { return Count == 0; }
    }

    public void Push(T item)
    {
        if (top == items.Length - 1)
        {
            
            throw new InvalidOperationException("Stack is full");
        }
        top++;
        items[top] = item;
    }

    public T Pop()
    {
        if (IsEmpty)
        {
            
            throw new InvalidOperationException("Stack is empty");
        }
        T item = items[top];
        top--;
        return item;
    }

    public T Peek()
    {
        if (IsEmpty)
        {
            
            throw new InvalidOperationException("Stack is empty");
        }
        return items[top];
    }

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
    }
}

class Program
{
    static void Main()
    {
        SimpleStack<int> stack = new SimpleStack<int>(3);

        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        Console.WriteLine("Top element: " + stack.Peek());

        while (!stack.IsEmpty)
        {
            int item = stack.Pop();
            Console.WriteLine("Popped: " + item);
        }

        Console.ReadLine();
    }
}
