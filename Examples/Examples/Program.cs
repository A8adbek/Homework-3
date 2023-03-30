namespace Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int32 Null = 0;
            Int32 Length = 0;
            Int32 One = 1;
            Int32 number = 0;
            Int32 residual = 0; 
            Int32 saver = 0; 
            String sign = String.Empty;
            String collector = String.Empty;
            String reverseAdder = "";
            Console.Write("| Enter a number : ");
            sign = Console.ReadLine();
            number = Convert.ToInt32(sign);
            saver = number;
            while (true)
            {
                residual = number / 2;
                if (residual * 2 == number)
                {
                    collector += Convert.ToString(Null);
                    
                } else if (number == 1) 
                {
                    collector += Convert.ToString(One);
                    sign = collector;
                    Length = sign.Length - 1;
                    while (Length >= 0)
                    {
                        reverseAdder = reverseAdder + sign[Length];
                        Length--;
                    }
                    Console.Write("| Number " + saver + " to binary : " + reverseAdder);
                    Console.WriteLine("");
                    return;
                } else
                {
                    collector += Convert.ToString(One);
                    
                }
                number = number / 2;
            }
            
        }
    }
}