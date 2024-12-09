internal class PrimeNumberChecker
{
    static void Main(string[] args)
    {
        List<int> res = new List<int>();
        for (int number = 1; number <= 500; number++)
        {
            for (int checker = 1; checker <= number; checker++)
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