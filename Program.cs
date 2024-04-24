namespace RP33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char op;
            int first, second, result;

            Console.Write("Введите первое число: ");
            first = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            second = int.Parse(Console.ReadLine());
            Console.Write("Введите оператор (+, -, *, /): ");
            op = (char)Console.Read();

            switch (op)
            {
                case '+':

                    Console.WriteLine(new Class1().dada(first, second));
                    break;

                case '-':
                    Console.WriteLine(new Class2().dada(first, second));
                    break;

                case '*':
                    Console.WriteLine(new Class3().dada(first, second));
                    break;

                case '/':
                    Console.WriteLine(new Class4().dada(first, second));
                    break;

                default:
                    Console.WriteLine("Недопустимый оператор");
                    break;
            }
        }
    }
}
