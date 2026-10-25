namespace TestConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Enter number 1");
            int.TryParse(Console.ReadLine(), out int a);
            Console.WriteLine("Enter number 2");
            int.TryParse(Console.ReadLine(), out int b);
            Console.WriteLine(Program.Add(a, b));
        }
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
