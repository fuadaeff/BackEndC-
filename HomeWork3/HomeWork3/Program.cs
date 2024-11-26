namespace HomeWork3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ilk ededi daxil edin:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ikinci ededi daxil edin:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ucuncu ededi daxil edin:");
            int c = Convert.ToInt32(Console.ReadLine());
            int S;
            S = (a + b + c) / 3;
            Console.WriteLine(S);
        }
    }
}
