void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                {
                    Console.Write($"{inArray[i, j, k]} ({i},{j},{k})");
                }
                Console.WriteLine();
            }
    }
}

void FillArray(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                matr[i, j, k] = new Random().Next(10, 100);
                CheckChange(matr, i, j, k);
            }
        }
    }
}
void CheckChange(int[,,] matr, int l, int m, int n)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                if (l != i)
                {
                    if (m != j)
                    {
                        if (n != k)
                        {
                            if (matr[l, m, n] == matr[i, j, k])
                            {
                                matr[l, m, n] = new Random().Next(10, 100);
                                CheckChange(matr, l, m, n);
                            }
                        }
                    }
                }
            }
        }
    }
}
int rows = 3;
int columns = 3;
int lines = 3;
int[,,] array = new int[rows, columns, lines];
FillArray(array);
PrintArray(array);