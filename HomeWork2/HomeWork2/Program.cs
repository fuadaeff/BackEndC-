namespace HomeWork2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ilk ededi daxil edin:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ikinci ededi daxil edin:");
            int b = Convert.ToInt32(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            /* or we can do it with adding third condition;
             * int c;
             * c = a;a=b;b=c
             * and print
            */
            Console.WriteLine(b);
            Console.WriteLine(a);
            
        }
    }
}
