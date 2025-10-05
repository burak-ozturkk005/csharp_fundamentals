namespace syn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            performOperation("Task 1",2000);
            performOperation("Task 2", 3000);


            Console.WriteLine("End");
        }
        static void performOperation(string taskName, int delayDuration)
        {
            Console.WriteLine($"{taskName} started");
            Thread.Sleep(delayDuration);
            Console.WriteLine($"{taskName} completed");

        }
    }
}
