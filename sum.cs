internal class sum
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter Number (from 1 to 1000");
        int number = int.Parse(Console.ReadLine());
        int result = 0, i = 0;
        do
        {
            result = result + i;
            Console.WriteLine("{0},{1}", i, result);
            i++;
        }
        while (i <= number);
    }
}

