Console.WriteLine("Введите символы в строку: ");
string line = Console.ReadLine();
if (!string.IsNullOrWhiteSpace(line))
{
    line = line.Trim();
    if (!line.Contains("h"))
    {
        Console.WriteLine("В строке нет символа h!");
    }
    else
    {
        char[] newArray = line.ToCharArray();
        int firstIndex = Array.IndexOf(newArray, 'h');
        int lastIndex = Array.LastIndexOf(newArray, 'h');
        for (int i = firstIndex + 1; i < lastIndex; i++)
        {
            if (newArray[i] == 'h')
            {
                newArray[i] = 'H';
            }
        }

        string changedLine = new string(newArray);
        Console.WriteLine(changedLine);
    }
}
else
{
    Console.WriteLine("Пустая строка!");
}