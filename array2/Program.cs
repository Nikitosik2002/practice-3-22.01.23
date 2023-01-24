
int[] array = new int[] {23, 11, 8, 11, 23, 32, 8, 11, 32, 9, 11, 32, 32, 32};
void print (int[] array)
{
    foreach (var item in array)
    {
        System.Console.Write(item + " ");
    }
}


int maxNumbers (int[] array)
{
    int count = 0;
    int result = 0;

    for (int i = 0; i < array.Length; i++)
    {
        int max = array[i];
        for (int j = 0; j < array.Length; j++)
        {
            if (max == array[j])
            {
                count++;
            }
            
        }

        if (count > result)
        {
            result = count;
        } 
        count = 0;
    }
    return result;
}

print(array);
System.Console.WriteLine();
System.Console.WriteLine(maxNumbers(array));