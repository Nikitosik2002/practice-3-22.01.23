

int[] array = new int[]{0, 2, 3, 1, 0, 8, -10, 0, 0};

void print(int[] array)
{
    foreach (var item in array)
    {
        System.Console.Write(item + " ");
    }
}
print(array);
System.Console.WriteLine();

for (int i = 0; i < array.Length ; i++)
{

        for (int j = 1; j < array.Length; j++)
        {
            
            if (array[j] == 0)
            {
                int temp = array[j];
                array[j] = array[j-1];
                array[j-1] = temp;
            }
            
        }  
      
}
print(array);








