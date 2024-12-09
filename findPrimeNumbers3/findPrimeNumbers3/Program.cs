internal class PrimeNumberChecker
{
    static void Main(string[] args)
    {
        List<int> res = new List<int>();
        IEnumerable<int> myRange = Enumerable.Range(1, 500);
        foreach (int number in myRange)
        {
            foreach (int checker in myRange)
            {
                if (checker <= number)
                {
                    if (number != 1)
                    {
                        if (number % checker == 0)
                        {
                            res.Add(checker);
                        }
                    }
                    else
                    {
                        goto end_of_outter_loop;
                    }
                }
            }

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
        }
        Console.ReadKey();
    }
}

