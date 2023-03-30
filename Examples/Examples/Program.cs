namespace Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int32 num1 = 0;
            Int32 num2 = 0, max = 0; ;
            Int32 count1 = 0, count2 = 0, count3 = 0, count4 = 0, count5 = 0, count6 = 0, count7 = 0, count8 = 0, count9 = 0, count0 = 0;
            String num = String.Empty;
            Console.Write("Enter a numbers : ");
            num = Console.ReadLine();
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] == '1')
                {
                    count1++;
                    if(count1 > count0 || count1 > count2 || count1 > count3 || count1 > count4 || count1 > count5 || count1 > count6 || count1 > count7 || count1 > count8 || count1 > count9)
                    {
                        max = count1;
                    }
                }
                if (num[i] == '2')
                {
                    count2++;
                    if (count2 > count0 || count2 > count1 || count2 > count3 || count2 > count4 || count2 > count5 || count2 > count6 || count2 > count7 || count2 > count8 || count2 > count9)
                    {
                        max = count2;
                    }
                }
                if (num[i] == '3')
                {
                    count3++;
                    if (count3 > count0 || count3 > count2 || count3 > count1 || count3 > count4 || count3 > count5 || count3 > count6 || count3 > count7 || count3 > count8 || count3 > count9)
                    {
                        max = count3;
                    }
                }
                if (num[i] == '4')
                {
                    count4++;
                    if (count4 > count0 || count4 > count2 || count4 > count3 || count4 > count1 || count4 > count5 || count4 > count6 || count4 > count7 || count4 > count8 || count4 > count9)
                    {
                        max = count4;
                    }
                }
                if (num[i] == '5')
                {
                    count5++;
                    if (count5 > count0 || count5 > count2 || count5 > count3 || count5 > count4 || count5 > count1 || count5 > count6 || count5 > count7 || count5 > count8 || count5 > count9)
                    {
                        max = count5;
                    }
                }
                if (num[i] == '6')
                {
                    count6++;
                    if (count6 > count0 || count6 > count2 || count6 > count3 || count6 > count4 || count6 > count5 || count6 > count1 || count6 > count7 || count6 > count8 || count6 > count9)
                    {
                        max = count6;
                    }
                }
                if (num[i] == '7')
                {
                    count7++;
                    if (count7 > count0 || count7 > count2 || count7 > count3 || count7 > count4 || count7 > count5 || count7 > count6 || count7 > count1 || count7 > count8 || count7 > count9)
                    {
                        max = count7;
                    }
                }
                if (num[i] == '8')
                {
                    count8++;
                    if (count8 > count0 || count8 > count2 || count8 > count3 || count8 > count4 || count8 > count5 || count8 > count6 || count8 > count7 || count8 > count1 || count8 > count9)
                    {
                        max = count8;
                    }
                }
                if (num[i] == '9')
                {
                    count9++;
                    if (count9 > count0 || count9 > count2 || count9 > count3 || count9 > count4 || count9 > count5 || count9 > count6 || count9 > count7 || count9 > count8 || count9 > count1)
                    {
                        max = count9;
                    }
                }
                if (num[i] == '0')
                {
                    count0++;
                    if (count0 > count1 || count0 > count2 || count0 > count3 || count0 > count4 || count0 > count5 || count0 > count6 || count0 > count7 || count0 > count8 || count0 > count9)
                    {
                        max = count0;

                    }
                }
            }
            if(max == count0)
            {
                Console.Write("Number 0 : ");
            }
            if (max == count1)
            {
                Console.Write("Number 1 : ");
            }
            if (max == count2)
            {
                Console.Write("Number 2 : ");
            }
            if (max == count3)
            {
                Console.Write("Number 3 : ");
            }
            if (max == count4)
            {
                Console.Write("Number 4 : ");
            }
            if (max == count5)
            {
                Console.Write("Number 5 : ");
            }
            if (max == count6)
            {
                Console.Write("Number 6 : ");
            }
            if (max == count7)
            {
                Console.Write("Number 7 : ");
            }
            if (max == count0)
            {
                Console.Write("Number 8 : ");
            }
            if (max == count9)
            {
                Console.Write("Number 9 : ");
            }
            Console.Write(max + " there is");
            
        }
    }
}