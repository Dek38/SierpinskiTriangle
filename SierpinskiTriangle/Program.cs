Console.WriteLine("Type an integer positive pow of 2:");
if (!int.TryParse(Console.ReadLine(), out int result))
{
    Console.WriteLine("This is not a pow");
    return -1;
}

if (result <= 0)
{
    Console.WriteLine("This pow is not positive");
    return -1;
}

int depth = (int)Math.Pow(2, result);
int[] firstArray = { 1 };
int[] secondArray = new int[depth];
for (int i = 0; i < depth; i++)
{
    Console.Write(new string(' ', depth - 1 - i));
    for (int j = 0; j < i + 1; j++)
    {
        if (i == 0)
        {
            secondArray[j] = firstArray[i];
            firstArray = new int[depth];
        }
        else 
        {
            if (j == 0)
            {
                secondArray[j] = firstArray[j];
            }
            else if (j == i)
            {
                secondArray[j] = firstArray[j - 1];
            }
            else
            {
                secondArray[j] = firstArray[j - 1] + firstArray[j];
                if (secondArray[j] % 2 == 0)
                {
                    secondArray[j] = 0;
                }
            }
        }
    }

    secondArray.CopyTo(firstArray, 0);

    for (int j = 0; j < i + 1; j++)
    {
        if (secondArray[j] == 0)
        {
            Console.Write("  ");
        }

        else
        {
            Console.Write($"{secondArray[j]} ");
        }

    }
    Console.WriteLine();
}

return 0;





