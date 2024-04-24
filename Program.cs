namespace RP33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char op;
            double first, second, result;

            Console.Write("Введите первое число: ");
            first = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число: ");
            second = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите оператор (+, -, *, /): ");
            op = (char)Console.Read();

            switch (op)
            {
                case '+':
                    result = first + second;
                    Console.WriteLine("{0} + {1} = {2}", first, second, result);
                    break;

                case '-':
                    result = first - second;
                    Console.WriteLine("{0} - {1} = {2}", first, second, result);
                    break;

                case '*':
                    result = first * second;
                    Console.WriteLine("{0} * {1} = {2}", first, second, result);
                    break;

                case '/':
                    result = first / second;
                    Console.WriteLine("{0} / {1} = {2}", first, second, result);
                    break;

                default:
                    Console.WriteLine("Недопустимый оператор");
                    break;
            }
        }
    }
}
