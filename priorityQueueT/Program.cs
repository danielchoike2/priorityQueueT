namespace SimpleFoodPriorityQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create the queue
            // The data items are strings. The second type parameter (an int) indicates the priority
            PriorityQueue<string, int> messages = new PriorityQueue<string, int>();

            // Add messages with different priorities to the queue
            messages.Enqueue("Candy", 1);
            messages.Enqueue("Soda", 2);
            messages.Enqueue("Steak", 3);
            messages.Enqueue("Pizza", 4);
            messages.Enqueue("Spagehtti", 5);
            messages.Enqueue("Applies", 6);

            //Count items in the queue
           

            // Retrieve the messages in priority and queue order
            while (messages.TryDequeue(out string item, out int priority))
            {
                Console.WriteLine($"There are {messages.Count} items in the queue");
                Console.WriteLine($"Dequeued Item : {item} Priority Was : {priority}");
            }
        }
    }
}