namespace PZ_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число m: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число n: ");
            double n = Convert.ToDouble(Console.ReadLine());
            double x = 0.0;
            double y = 0.0;
            double z;
            if (m > 5) 
            {
                x = Math.Sin(m + n);
            }
            else if (m <= 5)
            {
                x = n + 5 * Math.Sqrt(m * Math.Pow(n, 2)) - 2.1 * n;
            }
            if (x <= 0)
            {
                y = Math.Log(m * n + x);
            }
            else if (x > 0)
            {
                y = Math.Cos(m * x) * Math.Sin(n * x);
            }
            z = (2 * x + 3 * y) / (Math.Pow(m, 2) + 5);
            Console.WriteLine("х = " + Math.Round(x, 2));
            Console.WriteLine("у = " + Math.Round(y, 2));
            Console.WriteLine("z = " + Math.Round(z, 2));

            Console.ReadLine();
        }
    }
}