namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                // მენიუს ჩვენება
                Console.WriteLine("Calculator Menu:");
                Console.WriteLine("1) Addition");
                Console.WriteLine("2) Subtraction");
                Console.WriteLine("3) Multiplication");
                Console.WriteLine("4) Division");
                Console.WriteLine("5) Exit");
                Console.Write("Choose an option: ");

                // მომხმარებლის არჩევანის მიღება
                int option = int.Parse(Console.ReadLine());

                if (option == 5)
                {
                    exit = true;
                    Console.WriteLine("Exiting calculator");
                    break;
                }

                // რიცხვების შეყვანა
                Console.Write("Enter first number: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Enter second number: ");
                double num2 = double.Parse(Console.ReadLine());

                // ოპერაციის შესრულება
                double result = 0;
                switch (option)
                {
                    case 1:
                        result = num1 + num2;
                        Console.WriteLine($"Result: {num1} + {num2} = {result}");
                        break;
                    case 2:
                        result = num1 - num2;
                        Console.WriteLine($"Result: {num1} - {num2} = {result}");
                        break;
                    case 3:
                        result = num1 * num2;
                        Console.WriteLine($"Result: {num1} * {num2} = {result}");
                        break;
                    case 4:
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                            Console.WriteLine($"Result: {num1} / {num2} = {result}");
                        }
                        else
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please choose between 1-5.");
                        break;
                }

                Console.WriteLine(); // ახალი ხაზის დამატება მენიუსთვის
            }
        }
    }
}
