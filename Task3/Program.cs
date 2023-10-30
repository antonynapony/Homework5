int number;
int shift;
string encrypted;
string decrypted;
int j;

char[] RusAlphabet = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };
char[] EngAlphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
Console.WriteLine("Выберите язык для шифрования. Введите <1> для шифрования на ангийском или <2> для шифрования на русском: ");
bool IsCorrectNumber = int.TryParse(Console.ReadLine(), out int language);
if (IsCorrectNumber)
{
    if (language == 1)
    {
        Console.Write("Write a phrase for encryption: ");
        string InputPhrase = Console.ReadLine();
        InputPhrase = InputPhrase.ToLower();
        char[] message = InputPhrase.ToCharArray();
        for (int i = 0; i < message.Length; i++)
        {
            for (j = 0; j < EngAlphabet.Length; j++)
            {
                if (message[i] == EngAlphabet[j])
                {
                    break;
                }
            }

            if (j != 26)
            {
                number = j;
                shift = number + 3;
                if (shift > 25)
                {
                    shift = shift - 26;
                }
                message[i] = EngAlphabet[shift];
            }
        }

        encrypted = new string(message);
        Console.WriteLine($"Зашифрованная фраза: {encrypted}");

        char[] OutputMessage = encrypted.ToCharArray();
        for (int i = 0; i < OutputMessage.Length; i++)
        {
            for (j = 0; j < EngAlphabet.Length; j++)
            {
                if (OutputMessage[i] == EngAlphabet[j])
                {
                    break;
                }
            }

            if (j != 26)
            {
                number = j;
                shift = number - 3;
                if (shift < 0)
                {
                    shift = shift + 26;
                }
                OutputMessage[i] = EngAlphabet[shift];
            }
        }

        decrypted = new string(OutputMessage);
        Console.WriteLine($"Decrypted phrase: {decrypted}");
    }
    else if (language == 2)
    {
        Console.Write("Напишите фразу для шифрования: ");
        string InputPhrase = Console.ReadLine();
        InputPhrase = InputPhrase.ToLower();
        char[] message = InputPhrase.ToCharArray();
        for (int i = 0; i < message.Length; i++)
        {
            for (j = 0; j < RusAlphabet.Length; j++)
            {
                if (message[i] == RusAlphabet[j])
                {
                    break;
                }
            }

            if (j != 33)
            {
                number = j;
                shift = number + 3;
                if (shift > 32)
                {
                    shift = shift - 33;
                }
                message[i] = RusAlphabet[shift];
            }
        }

        encrypted = new string(message);
        Console.WriteLine($"Зашифрованная фраза: {encrypted}");

        char[] OutputMessage = encrypted.ToCharArray();
        for (int i = 0; i < OutputMessage.Length; i++)
        {
            for (j = 0; j < RusAlphabet.Length; j++)
            {
                if (OutputMessage[i] == RusAlphabet[j])
                {
                    break;
                }
            }

            if (j != 33)
            {
                number = j;
                shift = number - 3;
                if (shift < 0)
                {
                    shift = shift + 33;
                }
                OutputMessage[i] = RusAlphabet[shift];
            }
        }

        decrypted = new string(OutputMessage);
        Console.WriteLine($"Расшифрованная фраза: {decrypted}");
    }
    else
    {
        Console.WriteLine("Номер введен некорректно");
    }
}
else
{
    Console.WriteLine("Номер введен некорректно");
}

