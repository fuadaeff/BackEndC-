namespace HomeWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int C;
            Console.WriteLine("Input your Farenheigt degree;");
            int F = Convert.ToInt32(Console.ReadLine());
            C = ((F - 32) * 5) / 9;
            Console.WriteLine("Your Celsius degree is " + C);
        }
    }
}
