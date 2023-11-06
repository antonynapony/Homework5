int number;
int shift;
string encrypted;
string decrypted;
int j;
char[] alphabet;
char[] rusAlphabet = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };
char[] engAlphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
Console.WriteLine("Выберите необходимую операцию. Введите <1> для шифрования или <2> для дешифрования: ");
bool IsCorrectOperation = int.TryParse(Console.ReadLine(), out int operation);
if (IsCorrectOperation)
{
    if (operation == 1)
    {
        Console.WriteLine("Выберите язык для шифрования. Введите <1> для шифрования на ангийском или <2> для шифрования на русском: ");
        bool IsCorrectLanguage = int.TryParse(Console.ReadLine(), out int language);
        if (IsCorrectLanguage)
        {
            if (language == 1)
            {
                alphabet = engAlphabet;
                Console.WriteLine("Choose a step for encryption from 1 to 25: ");
                bool IsCorrectStep = int.TryParse(Console.ReadLine(), out int step);
                if (IsCorrectStep)
                {
                    if (step > 0 && step < 26)
                    {
                        Console.WriteLine("Write a phrase for encryption: ");
                        string InputPhrase = Console.ReadLine();
                        InputPhrase = InputPhrase.ToLower();
                        char[] message = InputPhrase.ToCharArray();
                        for (int i = 0; i < message.Length; i++)
                        {
                            for (j = 0; j < alphabet.Length; j++)
                            {
                                if (message[i] == alphabet[j])
                                {
                                    break;
                                }
                            }

                            if (j != 26)
                            {
                                number = j;
                                shift = number + step;
                                if (shift > 25)
                                {
                                    shift = shift - 26;
                                }
                                message[i] = alphabet[shift];
                            }
                        }
                        encrypted = new string(message);
                        Console.WriteLine($"Encrypted phrase: {encrypted}");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect value for step!");
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect value for step!");
                }
            }
            else if (language == 2)
            {
                alphabet = rusAlphabet;
                Console.WriteLine("Введите шаг шифрования от 1 до 32: ");
                bool IsCorrectStep = int.TryParse(Console.ReadLine(), out int step);
                if (IsCorrectStep)
                {
                    if (step > 0 && step < 33)
                    {
                        Console.WriteLine("Напишите фразу для шифрования: ");
                        string InputPhrase = Console.ReadLine();
                        InputPhrase = InputPhrase.ToLower();
                        char[] message = InputPhrase.ToCharArray();
                        for (int i = 0; i < message.Length; i++)
                        {
                            for (j = 0; j < alphabet.Length; j++)
                            {
                                if (message[i] == alphabet[j])
                                {
                                    break;
                                }
                            }

                            if (j != 33)
                            {
                                number = j;
                                shift = number + step;
                                if (shift > 32)
                                {
                                    shift = shift - 33;
                                }
                                message[i] = alphabet[shift];
                            }
                        }

                        encrypted = new string(message);
                        Console.WriteLine($"Зашифрованная фраза: {encrypted}");
                    }
                    else
                    {
                        Console.WriteLine("Шаг шифрования введен некорректно!");
                    }
                }
                else
                {
                    Console.WriteLine("Шаг шифрования введен некорректно!");
                }
            }
            else
            {
                Console.WriteLine("Номер языка введен некорректно!");
            }
        }
        else
        {
            Console.WriteLine("Номер языка введен некорректно!");
        }
    }
    else if (operation == 2)
    {
        Console.WriteLine("Выберите язык для шифрования. Введите <1> для шифрования на ангийском или <2> для шифрования на русском: ");
        bool IsCorrectLanguage = int.TryParse(Console.ReadLine(), out int language);
        if (IsCorrectLanguage)
        {
            if (language == 1)
            {
                alphabet = engAlphabet;
                Console.WriteLine("Choose a step for decryption from 1 to 25: ");
                bool IsCorrectStep = int.TryParse(Console.ReadLine(), out int step);
                if (IsCorrectStep)
                {
                    if (step > 0 && step < 26)
                    {
                        Console.WriteLine("Write a phrase for decryption: ");
                        string InputPhrase = Console.ReadLine();
                        InputPhrase = InputPhrase.ToLower();
                        char[] message = InputPhrase.ToCharArray();
                        for (int i = 0; i < message.Length; i++)
                        {
                            for (j = 0; j < alphabet.Length; j++)
                            {
                                if (message[i] == alphabet[j])
                                {
                                    break;
                                }
                            }

                            if (j != 26)
                            {
                                number = j;
                                shift = number - step;
                                if (shift < 0)
                                {
                                    shift = shift + 26;
                                }
                                message[i] = alphabet[shift];
                            }
                        }

                        decrypted = new string(message);
                        Console.WriteLine($"Decrypted phrase: {decrypted}");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect value for step!");
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect value for step!");
                }
            }
            else if (language == 2)
            {
                alphabet = rusAlphabet;
                Console.WriteLine("Введите шаг дешифрования от 1 до 32: ");
                bool IsCorrectStep = int.TryParse(Console.ReadLine(), out int step);
                if (IsCorrectStep)
                {
                    if (step > 0 && step < 33)
                    {
                        Console.WriteLine("Напишите фразу для расшифровки: ");
                        string InputPhrase = Console.ReadLine();
                        InputPhrase = InputPhrase.ToLower();
                        char[] message = InputPhrase.ToCharArray();
                        for (int i = 0; i < message.Length; i++)
                        {
                            for (j = 0; j < alphabet.Length; j++)
                            {
                                if (message[i] == alphabet[j])
                                {
                                    break;
                                }
                            }

                            if (j != 33)
                            {
                                number = j;
                                shift = number - step;
                                if (shift < 0)
                                {
                                    shift = shift + 33;
                                }
                                message[i] = alphabet[shift];
                            }
                        }

                        decrypted = new string(message);
                        Console.WriteLine($"Расшифрованная фраза: {decrypted}");
                    }
                    else
                    {
                        Console.WriteLine("Шаг дешифрования введен некорректно!");
                    }
                }
                else
                {
                    Console.WriteLine("Шаг дешифрования введен некорректно!");
                }
            }
            else
            {
                Console.WriteLine("Номер языка введен некорректно!");
            }
        }
        else
        {
            Console.WriteLine("Номер языка введен некорректно!");
        }
    }
    else
    {
        Console.WriteLine("Номер операции введен некорректно!");
    }
}
else
{
    Console.WriteLine("Номер операции введен некорректно!");
}
