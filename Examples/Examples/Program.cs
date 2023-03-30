namespace Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int32 num = 0;
            Int32 counter = 1;
            Int32 Factorial = 1;
            Console.Write("| Enter a number : ");
            num = int.Parse(Console.ReadLine());
            while (num >= counter)
            {
                Factorial *= counter;
                counter++;
            }
            Console.Write("| " + num + " is a factorial number : " + Factorial);
        }
    }
}