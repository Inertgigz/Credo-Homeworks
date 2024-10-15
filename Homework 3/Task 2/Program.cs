namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Input-ის შეყვანა
            Console.Write("Enter a number: ");
            int input = int.Parse(Console.ReadLine());

            // მასივის შექმნა სიგრძით - 10
            int[] arr = new int[10];

            // მასივში რიცხვების ასახვა
            for ( int i = 0; i < arr.Length; i++ )
            {
                arr[i] = input * (i + 1);
            }

            // შედეგის სათაური
            Console.WriteLine($"Multiplication Table of {input}:");

            // შედეგის დაბეჭდვა
            for ( int i = 0; i < arr.Length; i++ )
            {
                Console.WriteLine($"{input} X {i+1} = {arr[i]}");
            }
        }
    }
}
