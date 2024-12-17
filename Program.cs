using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите предложение, завершающееся точкой:");
        string input = Console.ReadLine();

        // Убираем точку в конце для удобства обработки
        if (input.EndsWith("."))
        {
            input = input.TrimEnd('.');
        }

        char[] delimiters = { ' ', ',', '-', ' ' };
        string result = "";
        int wordCount = 0;

        // Проходим по каждому символу, формируя слова
        for (int i = 0; i < input.Length; i++)
        {
            char currentChar = input[i];

            // Если текущий символ - разделитель
            if (Array.Exists(delimiters, element => element == currentChar))
            {
                // Добавляем разделитель в результат
                result += currentChar;
            }
            else
            {
                // Начинаем новое слово
                string word = "";

                // Собираем слово
                while (i < input.Length && !Array.Exists(delimiters, element => element == input[i]))
                {
                    word += input[i];
                    i++;
                }

                // Увеличиваем счетчик слов
                wordCount++;
                // Добавляем слово с номером в результат
                result += word + "(" + wordCount + ")";
                // Уменьшаем счетчик, чтобы не пропустить следующий символ
                i--;
            }
        }

        Console.WriteLine("Результат: " + result);
    }
}