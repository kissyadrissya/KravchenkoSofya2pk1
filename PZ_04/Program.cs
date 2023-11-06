namespace PZ_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // задание 1
            Console.WriteLine("задание 1");
            Console.WriteLine("Число от -100 до 50 с шагом 5");
            for (int i = -100; i <= 50; i = i + 5)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // задание 2
            Console.WriteLine("задание 2");
            Console.WriteLine("6 символов в алфавитном порядке, начиная с N");
            for (char i = 'N'; i <= 'S'; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // задание 3
            Console.WriteLine("задание 3");
            Console.WriteLine("5 # значков в 4 строках");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine();
                for (int v = 0; v < 5; v++)
                {
                    Console.Write('#');
                }
            }
            Console.WriteLine();

            // задание 4
            Console.WriteLine("задание 4");
            int count = 0;
            Console.WriteLine("значение от -200 до 200, кратное 5");
            for (int i = -200; i <= 200; i++)
            {

                if (i % 5 == 0)
                {
                    Console.Write(i + " ");
                    count++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("количество чисел кратных '5' равно " + count);
            Console.WriteLine();

            //задание 5
            Console.WriteLine("задание 5");
            int a, b;

            for (a = 4, b = 50; b - a > 22; a++, b--)
            {
                Console.WriteLine(a + " " + b);
            }

            Console.WriteLine(a + " " + b);

        }
    }
}