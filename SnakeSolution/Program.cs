using System;

namespace SnakeSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = 5;
            string sentence = @"First we thought the PC was a calculator. Then we found out how to turn numbers into letters with ASCII and we thought it was a typewriter. Then we discovered graphics, and we thought it was a television. With the World Wide Web, we've realized it's a brochure.";  // Quote from Douglas Adams

            string[] wordList = sentence.Split(" ");
            string[,] matrix = new string[matrixSize, matrixSize];
            bool readInMode = true;

            // This first loop goes once to start the words and the second time to get the words and write them out.
            for (var j = 0; j < 2; j++)
            {
                // The adders determine whether rows and columns are increasing, decreasing, or staying the same.
                int rowAdder = 0;
                int columnAdder = 1;

                // These are the indexes into the matrix to put words in or to take them out.
                int currentRow = 0;
                int currentCol = 0;

                // For a 5x5 matrix, we need to handle 5 columns, then 4 rows, then 4 columns etc. This handles those changes.
                int countdownStart = 4;
                int countdown = 4;
                int countdownSub = 1;

                for (var i = 0; i < 25; i++)
                {
                    string word;

                    if (readInMode)
                    {
                        word = wordList[i];
                        matrix[currentRow, currentCol] = word;
                    }
                    if (!readInMode)
                    {
                        Console.Write($"{matrix[currentRow, currentCol]} ");
                    }

                    // If we've reached the countdown, change directions.
                    if (countdown == 0)
                    {
                        if (rowAdder == 0 && columnAdder == 1)
                        {
                            rowAdder = 1;
                            columnAdder = 0;
                        }
                        else if (rowAdder == 1 && columnAdder == 0)
                        {
                            rowAdder = 0;
                            columnAdder = -1;
                        }
                        else if (rowAdder == 0 && columnAdder == -1)
                        {
                            rowAdder = -1;
                            columnAdder = 0;
                        }
                        else if (rowAdder == -1 && columnAdder == 0)
                        {
                            rowAdder = 0;
                            columnAdder = 1;
                        }

                        countdownStart -= countdownSub;
                        countdown = countdownStart;
                        if (countdownSub == 0) countdownSub = 1;
                        else countdownSub = 0;
                    }
                    else
                    {
                        countdown--;
                    }

                    // Update the indices in the proper direction (right, then down, then left, then up, etc.
                    currentRow += rowAdder;
                    currentCol += columnAdder;

                }

                if (readInMode)
                {
                    // Output the matrix
                    for (var row = 0; row < matrixSize; row++)
                    {
                        for (var col = 0; col < matrixSize; col++)
                        {
                            Console.Write($"{matrix[row, col]} ");
                        }
                        Console.WriteLine();
                    }
                }
                readInMode = false;
            }

        }
    }
}
