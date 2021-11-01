using System;

namespace Be_Fruitful
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initial program setups 
            double[,] matrixA, matrixB, matrixC;
            string rawData;
            string[] temp;

            Console.Write("How many rows does the first matrix have ? ");
            int row1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("How many columns does the first matrix have? ");
            int column1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("How many rows does the second matrix have? ");
            int row2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("How many columns does the second matrix have? ");
            int column2 = Convert.ToInt32(Console.ReadLine());

            //Check for illegal inputs
            if (row1 != column2 && row2 != column1)
                Console.WriteLine("These two matrices cannot be multiplied.");

            // start the hard stuff  
            else
            {
                matrixA = new double[row1, column1];
                matrixB = new double[row2, column2];

                //Populating first matrix
                for (int i = 0; i < row1; i++)
                {
                    Console.Write("Enter a row of the first matrix, seperated by space: ");
                    rawData = Console.ReadLine();
                    temp = rawData.Split(" ");

                    for (int j = 0; j < temp.Length; j++)
                    {
                        matrixA[i, j] = Convert.ToDouble(temp[j]);
                    }
                }

                //Populating second matrix
                for (int i = 0; i < row2; i++)
                {
                    Console.Write("Enter a row of the second matrix, seperated by space: ");
                    rawData = Console.ReadLine();
                    temp = rawData.Split(" ");

                    for (int j = 0; j < temp.Length; j++)
                    {
                        matrixB[i, j] = Convert.ToDouble(temp[j]);
                    }
                }

                matrixC = new double[row1, column2];

                //Merge matrixA and matrixB into matrixC (matrixA[i,k]*matrixB[k,j])
                for (int i = 0; i < row1; i++)
                {
                    for (int j = 0; j < column2; j++)
                    {
                        matrixC[i, j] = 0;
                        for (int k = 0; k < column1; k++)
                        {
                            matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                        }
                    }
                }

                //Output the result
                Console.WriteLine("The resulting matrix is:");
                for (int i = 0; i < row1; i++)
                {
                    for (int j = 0; j < column2; j++)
                        Console.Write("{0,8:F2}", matrixC[i, j]);
                    Console.WriteLine();
                }
            }
        }
    }
}
