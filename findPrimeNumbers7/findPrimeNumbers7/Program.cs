﻿internal class PrimeNumberChecker
{
    static void Main(string[] args)
    {
        List<int> res = new List<int>();
        int number = 1;
        do
        {
            int checker = 1;
            do
            {
                if (number != 1)
                {
                    if (number % checker == 0)
                    {
                        res.Add(checker);
                        checker++;
                    }
                    else
                    {
                        checker++;
                    }
                }
                else
                {
                    goto end_of_outter_loop;
                }
            }
            while (checker <= number);
            if (res.Count > 2)
            {
                Console.Write("{0} is not prime", res.Last());
                Console.WriteLine();
                res.Clear();
            }
            else
            {
                Console.Write("{0} is prime", res.Last());
                Console.WriteLine();
                res.Clear();
            }
        end_of_outter_loop: { }
            number++;
        }
        while (number <= 500);
        Console.ReadKey();
    }
}

