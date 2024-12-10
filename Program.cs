
namespace Assignment6_3_1
{
    internal class Program
    {
        //You are developing a program to manage a call queue of customers using the Queue  in C#.
        //The program creates a queue of callers and demonstrates the functionality of enqueueing elements into the queue and iterating over the elements and dequeuing.
        //Use linked lists.
        static void Main(string[] args)
        {
            CustomQueue callsQueue = new CustomQueue();

            Console.WriteLine($"Peek at front of queue: | Name: {callsQueue.Peek().Name} | DateTime: {callsQueue.Peek().Date} | Phone Number: {callsQueue.Peek().PhoneNum}");
            Console.WriteLine($"Amount of calls in the queue: {callsQueue.Size}");
            Console.WriteLine();
            Console.WriteLine("Add a call to the end of the queue");
            callsQueue.Enqueue(new Call {Name = "Tom", Date = DateTime.Now, PhoneNum = "555-555-5555"});
            Console.WriteLine($"Amount of calls in the queue: {callsQueue.Size}");
            Console.WriteLine($"Peek at front of queue: | Name: {callsQueue.Peek().Name} | DateTime: {callsQueue.Peek().Date} | Phone Number: {callsQueue.Peek().PhoneNum}");
            Console.WriteLine();
            Console.WriteLine("Add two calls to the end of the queue");
            callsQueue.Enqueue(new Call { Name = "Bill", Date = DateTime.Now, PhoneNum = "111-555-5555" });
            callsQueue.Enqueue(new Call { Name = "Kate", Date = DateTime.Now, PhoneNum = "222-555-5555" });
            Console.WriteLine($"Amount of calls in the queue: {callsQueue.Size}");
            Console.WriteLine($"Peek at front of queue: | Name: {callsQueue.Peek().Name} | DateTime: {callsQueue.Peek().Date} | Phone Number: {callsQueue.Peek().PhoneNum}");
            Console.WriteLine();
            Console.WriteLine($"Remove the front of the queue: {callsQueue.Dequeue().Name}");
            Console.WriteLine($"Amount of calls in the queue: {callsQueue.Size}");
            Console.WriteLine($"Peek at front of queue: | Name: {callsQueue.Peek().Name} | DateTime: {callsQueue.Peek().Date} | Phone Number: {callsQueue.Peek().PhoneNum}");
            Console.WriteLine();
            Console.WriteLine($"Remove the front of the queue: {callsQueue.Dequeue().Name}");
            Console.WriteLine($"Amount of calls in the queue: {callsQueue.Size}");
            Console.WriteLine($"Peek at front of queue: | Name: {callsQueue.Peek().Name} | DateTime: {callsQueue.Peek().Date} | Phone Number: {callsQueue.Peek().PhoneNum}");
            Console.WriteLine();
            Console.WriteLine($"Remove the front of the queue: {callsQueue.Dequeue().Name}");
            Console.WriteLine($"Amount of calls in the queue: {callsQueue.Size}");
            Console.WriteLine($"Peek at front of queue: | Name: {callsQueue.Peek().Name} | DateTime: {callsQueue.Peek().Date} | Phone Number: {callsQueue.Peek().PhoneNum}");
            Console.WriteLine();
            Console.WriteLine($"Amount of calls in the queue: {callsQueue.Size}");
        }
    }

    public class CustomQueue
    {
        public int Size = 0;
        private LinkedList<Call> callQueue = new LinkedList<Call>();
        
        //Look at front of queue
        public Call Peek()
        {
            Call retVar = new Call();
            if (callQueue.Count > 0)
            {
                return callQueue.First();
            }
            else
            {
                Console.WriteLine("Error! Queue is empty");
                return retVar;
            }
        }

        //Remove the front of the queue
        public Call Dequeue()
        {
            Call retVar = new Call();
            if (callQueue.Count > 0)
            {
                retVar = callQueue.First();
                callQueue.RemoveFirst();
                Size--;
            }
            else
            {
                Console.WriteLine("Error! Queue is empty");
            }  
            return retVar;
        }

        //Add to end of queue
        public void Enqueue(Call c)
        {
            callQueue.AddLast(c);
            Size++;
        }
    }
}
