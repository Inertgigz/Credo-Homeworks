namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input-ის შეყვანა
            Console.Write("Enter a String: ");
            string input = Console.ReadLine();

            // ხმოვნების ცვლადი
            int numberOfVowels = 0;

            //ხმოვნების გაფილტვრა და რაოდენობის numberOfVowels-ში ასახვა
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u')
                {
                    numberOfVowels++;
                }
            }

            // შედეგის ბეჭდვა
            Console.WriteLine($"Number of vowels: {numberOfVowels}");
        }
    }
}
