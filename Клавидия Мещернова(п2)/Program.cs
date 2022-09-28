namespace Pract2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("привет, это никому не нужная программа, но все же введите чего вам надо(я забомбила.)");
            Console.WriteLine("1 - Игра Угадай число, 2 - Таблица умножения, 3 - Вывод делителей числа,4 - выход из программы ");
            int programma = Convert.ToInt32(Console.ReadLine());
            while (programma != 4)
            {
                if (programma == 1)
                {
                    RandomNumber();
                }
                else if (programma == 2)
                {
                    MultTable();
                }
                else if (programma == 3)
                {
                    Console.WriteLine("Введите число");
                    int chislo = Convert.ToInt32(Console.ReadLine());
                    List<int> divisors = Divisors(chislo);
                    Console.WriteLine("Делители:");
                    foreach(int div in divisors)
                    {
                        Console.WriteLine(div);
                    }
                }

                Console.WriteLine(" вы в главном меню этой очень мега грустной программы. выберите что будете делать дальше:");
                programma = Convert.ToInt32(Console.ReadLine());
            }
        }

        static void RandomNumber()
        {
            Random chislo_rand = new Random();
            int chisl = chislo_rand.Next(1, 100);
            int vibor_pols;
            Console.WriteLine("Вы выбрали игру угадай число");
            Console.WriteLine("введите от одного до 100 и угадайте");
            do
            {

                vibor_pols = Convert.ToInt32(Console.ReadLine());

                if (chisl < vibor_pols)
                {
                    Console.WriteLine("загаданное число меньше вашего");
                }
                if (chisl > vibor_pols)
                {
                    Console.WriteLine("загаданное число больше вашего");
                }
            } while (chisl != vibor_pols);
            Console.WriteLine("угадали. ура");
        }

        static void MultTable()
        {
            int[,] matrix = new int[9, 9];
            for (int i = 0; i <= 8; i++)
            {
                for (int j = 0; j <= 8; j++)
                {
                    matrix[i, j] = (i + 1) * (j + 1);
                }
            }

            for (int i = 0; i <= 8; i++)
            {
                for (int j = 0; j <= 8; j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }
        }

        static List<int> Divisors(int chislo)
        {
            List<int> divisors = new List<int>();
            for (int i = 1; i <= chislo / 2; i++)
            {
                if (chislo % i == 0)
                {
                    divisors.Add(i);
                }
            }
            divisors.Add(chislo);

            return divisors;
        }
    }
}