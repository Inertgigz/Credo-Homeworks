namespace Homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // #1

            int a = 7;
            int b = 3;

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);

            // ---------------------------------------------------
            // #2

            float aa = 1 / 7;
            double bb = 1.0 / 7.0;
            decimal cc = 1.0m / 7.0m;

            Console.WriteLine("float: " + aa * 7);
            Console.WriteLine("double: " + bb * 7);
            Console.WriteLine("decimal: " + cc * 7);

            // ---------------------------------------------------
            // #3

            int i = 13; ;
            double g = 24.5;
            decimal d = 56.4234m;
            float f = 24.4f;

            double implicitDoubleFromInt = i;

            int explicitIntFromDouble = (int)g;

            int explicitIntFromFloat = (int)f;

            double implicitDoubleFromFloat = f; // No cast needed

            int explicitIntFromDecimal = (int)d;

            Console.WriteLine($"int: {i}");
            Console.WriteLine($"double: {g}");
            Console.WriteLine($"float: {f}");
            Console.WriteLine($"decimal: {d}\n");

            Console.WriteLine($"Implicit conversion (int → double): {implicitDoubleFromInt}");
            Console.WriteLine($"Explicit conversion (double → int): {explicitIntFromDouble}");
            Console.WriteLine($"Explicit conversion (float → int): {explicitIntFromFloat}");
            Console.WriteLine($"Implicit conversion (float → double): {implicitDoubleFromFloat}");
            Console.WriteLine($"Explicit conversion (decimal → int): {explicitIntFromDecimal}");

            // ---------------------------------------------------
            // #4

            int x = 5;
            int bbb = 10;


            Console.WriteLine($"Before: x = {x} & b = {bbb}\n");

            // შევუცვალოთ მნიშვნელობები x-სა და b-ს დროებითი ცვლადის გამოყენებით

            int temp = x;
            x = bbb;
            bbb = temp;

            Console.WriteLine($"After: x = {x} & b = {bbb}");

            // ---------------------------------------------------
            // #5

            Console.Write("Enter your height in meters (example: 1.75): ");
            string heightInput = Console.ReadLine();
            double height = Convert.ToDouble(heightInput);


            Console.Write("Enter your weight in kilograms (example: 70): ");
            string weightInput = Console.ReadLine();
            double weight = Convert.ToDouble(weightInput);


            double bmi = weight / (height * height);

            Console.WriteLine($"Your BMI is: {bmi}");

            if (bmi < 18.5)
            {
                Console.WriteLine("You are underweight. It may be a good idea to consult a healthcare provider.");
            }
            else if (bmi >= 18.5 && bmi < 24.9)
            {
                Console.WriteLine("You have a normal weight. Keep up with a balanced diet and regular exercise!");
            }
            else if (bmi >= 25 && bmi < 29.9)
            {
                Console.WriteLine("You are overweight. Consider improving your diet and increasing physical activity.");
            }
            else
            {
                Console.WriteLine("You are in the obese range. It is recommended to consult a healthcare provider for guidance.");
            }
        }
    }
}
