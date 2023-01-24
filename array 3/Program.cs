

string[] array = new string[5] {"Andrey", "Рома", "Алексей", "Настя", "Даня"};

void print (string[] array)
{
    foreach (var item in array)
{
    System.Console.WriteLine(item);
}
}
print(array);
System.Console.WriteLine();

int length = array.Length / 2;
System.Console.WriteLine(length);

string box =string.Empty;
for (int i = 0; i < array.Length / 2; i++)
{
    box = array[i];
    array[i] = array[array.Length - (1+i)];
    array[array.Length - (1+i)] = box;
}

print(array);