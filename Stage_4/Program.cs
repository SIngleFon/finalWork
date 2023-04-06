//Ввод данных
int UserKeyVolume = StringMessage("Введите кол-во элементов для ввода с клавиатуры: ", "Ошибка ввода. Повторите попытку!");

//Логика
string[] UserKeyArray = FillArrayInUserKey(UserKeyVolume); 
int count = FindCount(UserKeyArray);
string[] nArray = FillArray(UserKeyArray, count);
Console.Write($"[{String.Join(", ", UserKeyArray)}] -> [{String.Join(", ", nArray)}]");

// Методы
string[] FillArrayInUserKey(int UserKey) //Метод, чтобы пользователь сам ввел с клавиатуры элементы.
{
    string[] array = new string[UserKey];
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i+1} элемент массива строк: ");
        array[i] =Console.ReadLine()?? "";
    }
    return array;
}

int StringMessage(string msg, string error) //Метод для вывода текста и ввода данных с клавиатуры.
{
    while (true)
    {
        Console.Write(msg);
        bool IsCorrect = int.TryParse(Console.ReadLine(), out int kek);
        if (IsCorrect)
        {
            return kek;
        }
        Console.WriteLine(error);
    }
}

int FindCount(string[] array) //Метод для поиска кол-ва элементов в массиве строк с кол-вом символом не превышающих 3.
{
    int count = 0;
    for(int i = 0; i<array.Length; i++)
    {
        if(array[i].Count() <= 3)
        {
            count++;
        }
    }
    return count;
}

string[] FillArray(string[] array, int count) //Метод, который заполняет новый массив, с элементами <= 3. 
{
    string[] arr = new string[count];
    int j = 0;
    for(int i = 0; i<array.Length; i++)
    {
        if(array[i].Count() <= 3)
        {
            arr[j] = array[i];
            j++;
        }
    }
    return arr;
}