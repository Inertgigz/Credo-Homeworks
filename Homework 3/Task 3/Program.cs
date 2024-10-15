namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3 ცალი 2 განზუმილებიანი მასივის შექმნა, რომელთა შორის მესამე წინა ორის ჯამი იქნება
            int[,] matrixOne = new int[3, 3];
            int[,] matrixTwo = new int[3, 3];
            int[,] finalMatrix = new int[3, 3];

            // პირველ მატრიცაში მონაცემების შეყვანის მეთოდის გამოძახება
            Console.WriteLine("Enter Values for 1st Matrix: ");
            fillMatrix(matrixOne);

            Console.WriteLine();

            // მეორე მატრიცაში მონაცემების შეყვანის მეთოდის გამოძახება
            Console.WriteLine("Enter Values for 2nd Matrix: ");
            fillMatrix(matrixTwo);

            // მე-3 მატრიცაში პირველი 2 მატრიცის მონაცემთა ჯამის ასახვის მეთოდის გამოძახება
            addMatrix(matrixOne, matrixTwo, finalMatrix);

            Console.WriteLine(); 
            
            // 2 მატრიცის ჯამით მიღებული ახალი 3X3 მატრიცის ბეჭდვის მეთოდის გამოძახება
            printMatrix(finalMatrix);

        }

        // მატრიცებში მონაცემთა შეყვანის მეთოდი
        static void fillMatrix(int[,] matrix)
        {
            for (int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write($"Enter value for matrix [{i+1},{j+1}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        // // მე-3 მატრიცაში პირველი 2 მატრიცის მონაცემთა ჯამის ასახვის მეთოდი
        static void addMatrix(int[,] matrix1, int[,] matrix2, int[,] resultMatrix)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    resultMatrix[i,j] = matrix1[i,j] + matrix2[i,j];
                }
            }
        }

        // 2 მატრიცის ჯამით მიღებული ახალი 3X3 მატრიცის ბეჭდვის მეთოდი
        static void printMatrix(int[,] matrix)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
