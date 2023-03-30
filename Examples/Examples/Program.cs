namespace Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int32 num = 0;
            Int32 max = 0;
            Int32 min = 0;
            Int32 counter = 1;
            Console.WriteLine("| Enter a number");
            while (counter <= 4)
            {
                Console.Write("| Number " + counter + " : ");
                num = int.Parse(Console.ReadLine()); 
                counter++;
                if(max < num)
                {
                    max = num;
                    if(counter == 2)
                    {
                        min = num;
                    }
                } else if(min > num)
                {
                    min = num;
                }
            }
            Console.WriteLine("| max : " + max);
            Console.WriteLine("| min : " + min);
        }
    }
}