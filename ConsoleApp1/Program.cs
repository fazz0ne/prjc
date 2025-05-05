namespace ConsoleApp1
{
    internal class Program
    {
        void sum(int n, int m)
        {
            Console.WriteLine(n+m);
        }
        static void Main(string[] args)
        {
            Program a = new Program();
            a.sum(1, 2);
        }
    }
}
