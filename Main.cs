public class Program
{
    public static void Main()
    {
        Queue<int> intQueue = new Queue<int>(5);
        intQueue.Enqueue(1);
        intQueue.Enqueue(2);
        intQueue.Enqueue(3);

        Console.WriteLine("Primul element extras din coada este: " + intQueue.Dequeue());
        Console.WriteLine("Numarul de elemente din coada este: " + intQueue.Count);

        Queue<string> stringQueue = new Queue<string>(3);
        stringQueue.Enqueue("hello");
        stringQueue.Enqueue("world");

        Console.WriteLine("Primul element extras din coada este: " + stringQueue.Dequeue());
        Console.WriteLine("Numarul de elemente din coada este: " + stringQueue.Count);
    }
}