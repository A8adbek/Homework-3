namespace Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int32 num = 0;
            Console.WriteLine("Multiplication table");
            for(int i = 1; i <= 10; i++)
            {
                for(int j = 1; j <= 10; j++)
                {
                    num = i * j;
                    Console.WriteLine(i + " * " + j + " = " + num);
                }
            }
        }
    }
}