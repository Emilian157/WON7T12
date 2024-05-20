using System;

public class Queue<T>
{
    private T[] elements;
    private int head = 0;
    private int tail = 0;
    private int count = 0;
    private int capacity;

    public Queue(int capacity)
    {
        if (capacity <= 0)
        {
            throw new ArgumentOutOfRangeException("capacity", "Capacitatea trebuie sa fie mai mare decat 0.");
        }
        this.capacity = capacity;
        elements = new T[capacity];
    }

    public void Enqueue(T item)
    {
        if (count == capacity)
        {
            throw new InvalidOperationException("Coada a atins capacitatea maxima.");
        }
        elements[tail] = item;
        tail = (tail + 1) % capacity;
        count++;
    }

    public T Dequeue()
    {
        if (count == 0)
        {
            throw new InvalidOperationException("Coada este goala.");
        }
        T item = elements[head];
        head = (head + 1) % capacity;
        count--;
        return item;
    }

    public int Count
    {
        get { return count; }
    }
}