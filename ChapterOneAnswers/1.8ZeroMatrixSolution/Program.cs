void ZeroMatrix(int[,] matrix)
{
    int[] cols = new int[matrix.GetLength(1)];
    int[] rows = new int[matrix.GetLength(0)];

    for (int i = 0; i < rows.Length; i++)
    {
        for (int j = 0; j < cols.Length; j++)
        {
            if (matrix[i, j] == 0)
            {
                rows[i] = 1;
                cols[j] = 1;
            }
        }
    }

    for (int i = 0; i < rows.Length; i++)
    {
        if (rows[i] == 1)
        {
            TurnRowInto0s(matrix, i);
        }
    }

    for (int i = 0; i < cols.Length; i++)
    {
        if (cols[i] == 1)
        {
            TurnColInto0s(matrix, i);
        }
    }

    void TurnRowInto0s(int[,] matrix, int row)
    {
        for (int i = 0; i < rows.Length; i++)
        {
            matrix[row, i] = 0;
        }
    }

    void TurnColInto0s(int [,] matrix, int col)
    {
        for (int i = 0; i < rows.Length; i++)
        {
            matrix[i, col] = 0;
        }
    }
}

// Space Complexity O(n)
// Time Complexity O(n^2)


// Check
int[,] x = { { 1, 2, 0 }, { 5, 6, 0 }, { 2, 7, 3 } };
ZeroMatrix(x);

foreach(int i in x)
{
    Console.WriteLine(i);
}