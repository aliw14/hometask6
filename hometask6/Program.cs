namespace hometask6;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("ededi daxil et:");
        int number = int.Parse(Console.ReadLine());
        int countDigit = 0;
        int countDigitLog = (int)Math.Log10(number) + 1;
        int r;
        int sum;
        while (number != 0) 
        {
            r = number % 10;
            number /= 10;
            if (r==0) 
            {
                Console.WriteLine(r);

            }countDigit++;

        }

        
    }
}


