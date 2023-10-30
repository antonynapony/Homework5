Console.WriteLine("Введите символы в строку: ");
string line = Console.ReadLine();
if (!string.IsNullOrWhiteSpace(line))
{
    line = line.Trim();
    if (line.Contains("h"))
    {
        int first = line.IndexOf("h");
        int last = line.LastIndexOf("h");
        string line1 = line.Substring(0, first + 1);
        string line2 = line.Substring(first + 1, last - 1);
        string line3 = line.Substring(last);
        line2 = line2.Replace("h", "H");
        string lineChanged = line1 + line2 + line3;
        Console.WriteLine(lineChanged);
    }
    else
    {
        Console.WriteLine("В строке нет символа h!");
    }
}
else
{
    Console.WriteLine("Пустая строка!");
}