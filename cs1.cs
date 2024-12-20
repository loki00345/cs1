//using System.Globalization;

//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            1 EX
//            Console.Write("Введіть число від 1 до 100: ");
//            int number = int.Parse(Console.ReadLine());

//            if (number < 1 || number > 100)
//            {
//                Console.WriteLine("Помилка: число повинно бути в діапазоні від 1 до 100.");
//            }
//            else if (number % 3 == 0 && number % 5 == 0)
//            {
//                Console.WriteLine("Fizz Buzz");
//            }
//            else if (number % 3 == 0)
//            {
//                Console.WriteLine("Fizz");
//            }
//            else if (number % 5 == 0)
//            {
//                Console.WriteLine("Buzz");
//            }
//            else
//            {
//                Console.WriteLine(number);
//            }

//            ex 2
//            Console.Write("Введіть число: ");
//            double number = double.Parse(Console.ReadLine());

//            Console.Write("Введіть відсоток: ");
//            double percent = double.Parse(Console.ReadLine());

//            double result = (number * percent) / 100;
//            Console.WriteLine($"{percent}% від {number} = {result}");

//            ex 3
//            Console.WriteLine("Введіть чотири цифри:");
//            string number = "";

//            for (int i = 0; i < 4; i++)
//            {
//                number += Console.ReadLine();
//            }
//            Console.WriteLine($"Число: {number}");

//            ex 4
//            Console.Write("Введіть шестизначне число: ");
//            string number = Console.ReadLine();

//            if (number.Length != 6)
//            {
//                Console.WriteLine("Помилка: число повинно бути шестизначним.");
//            }
//            else
//            {
//                Console.Write("Введіть перший номер розряду: ");
//                int pos1 = int.Parse(Console.ReadLine()) - 1;

//                Console.Write("Введіть другий номер розряду: ");
//                int pos2 = int.Parse(Console.ReadLine()) - 1;

//                char[] digits = number.ToCharArray();
//                char temp = digits[pos1];
//                digits[pos1] = digits[pos2];
//                digits[pos2] = temp;

//                Console.WriteLine($"Результат: {new string(digits)}");
//            }

//            ex 5
//                Console.Write("Введіть дату (дд.мм.рррр): ");
//            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

//            string season = GetSeason(date);
//            string dayOfWeek = date.ToString("dddd", new CultureInfo("en-US"));

//            Console.WriteLine($"{season} {dayOfWeek}");
//        }

//        static string GetSeason(DateTime date)
//        {
//            if (date.Month >= 3 && date.Month <= 5) return "Spring";
//            if (date.Month >= 6 && date.Month <= 8) return "Summer";
//            if (date.Month >= 9 && date.Month <= 11) return "Autumn";
//            return "Winter";

//            ex 6
//            Console.Write("Введіть температуру: ");
//            double temp = double.Parse(Console.ReadLine());

//            Console.Write("Оберіть конвертацію (1: Фаренгейт -> Цельсій, 2: Цельсій -> Фаренгейт): ");
//            int choice = int.Parse(Console.ReadLine());

//            if (choice == 1)
//            {
//                double celsius = (temp - 32) * 5 / 9;
//                Console.WriteLine($"{temp} F = {celsius} C");
//            }
//            else if (choice == 2)
//            {
//                double fahrenheit = (temp * 9 / 5) + 32;
//                Console.WriteLine($"{temp} C = {fahrenheit} F");
//            }
//            else
//            {
//                Console.WriteLine("Невірний вибір.");
//            }


//            ex 7
//            Console.Write("Введіть перше число: ");
//            int num1 = int.Parse(Console.ReadLine());

//            Console.Write("Введіть друге число: ");
//            int num2 = int.Parse(Console.ReadLine());

//            int start = Math.Min(num1, num2);
//            int end = Math.Max(num1, num2);

//            Console.WriteLine($"Парні числа в діапазоні від {start} до {end}:");
//            for (int i = start; i <= end; i++)
//            {
//                if (i % 2 == 0)
//                {
//                    Console.WriteLine(i);
//                }
//            }
//        }
//    }
//}