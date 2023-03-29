string InputInt(string message)
{
    Console.Write(message);

    return Console.ReadLine();
}

string[] NewArray()
{
    int length = int.Parse(InputInt("Введите длину массива: "));
    string[] arrayOne = new string[length];

    for (int i = 0; i < arrayOne.Length; i++)

    arrayOne[i] = InputInt($"Введите значение #{i + 1}/{arrayOne.Length}: ");
    
    return arrayOne;
}

void OutputArray(string[] arrayOne)
{
    for (int i = 0; i < arrayOne.Length; i++)

    Console.Write($"{arrayOne[i]}\t");
    Console.WriteLine();
}

string[] TransformArray(string[] arrayOne)
{
    int length = 0;
    int count = 0;

    for (int i = 0; i < arrayOne.Length; i++)
    if (arrayOne[i].Length <= 3) length++;
    
    string[] arrayTwo = new string[length];
    for (int i = 0; i < arrayOne.Length; i++)
    
    {
        if (arrayOne[i].Length <= 3)
        {
            arrayTwo[count] = arrayOne[i];
            count++;
        }
    }
    return arrayTwo;
}


string[] arrayOne = NewArray();
OutputArray(arrayOne);
string[] arrayTwo = TransformArray(arrayOne);
OutputArray(arrayTwo);