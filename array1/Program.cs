
var rnd = new Random();

void completion (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(2);
    }
}

void print (int[] array)
{
    foreach (var item in array)
    {
        System.Console.Write(item + " ");
    }
}
//1 1 1 1 1 0 0 1 1 1 1 1 0 1 0
int findMax (int[] array)
{
    int count = 1;
    int result = 1;
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] == 1 && array[i] == array[i+1])
        {
            count++;
            if (count > result)
            {
                result = count;
            }
        }
        else
        {
            count = 1;
        }
    }
    return result;
}

System.Console.Write("Введите размерность массива: ");
int k = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("--------");
int[] array = new int[k];

completion(array);
print(array);
System.Console.WriteLine();
System.Console.WriteLine(findMax(array));