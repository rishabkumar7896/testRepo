namespace TestConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(Program.Add(3, 4));
        }
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
