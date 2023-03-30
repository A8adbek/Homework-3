namespace Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int32 num = 0;
            String numbers = String.Empty;
            String numbers1 = String.Empty;
            Int32 counter = 1;
            while (counter <= 100)
            {
                Console.Write("Number " + counter + " : ");
                numbers = Console.ReadLine();
                if (numbers == "q" || numbers == "Q")
                {
                    goto a;
                }
                num = Convert.ToInt32(numbers);
                if (num <= 100)
                {
                    numbers1 += num;
                    numbers1 += ", ";
                } 
                counter++;
            }
            a:
            Console.WriteLine("Reply : " + numbers1);
        }
    }
}