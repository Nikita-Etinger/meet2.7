using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace meet7
{
    class Program
    {
        static void Main()
        {
            string text = "Вот дом,\r\nКоторый построил Джек.\r\nА это пшеница,\r\nКоторая в тёмном чулане хранится\r\nВ доме,\r\nКоторый построил Джек.\r\nА это весёлая птица-синица,\r\nКоторая часто ворует пшеницу,\r\nКоторая в тёмном чулане хранится\r\nВ доме,\r\nКоторый построил Джек.";

            string[] words = Regex.Split(text, @"\W+");

            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (!string.IsNullOrEmpty(word))
                {
                    string lowercaseWord = word.ToLower();
                    if (wordCount.ContainsKey(lowercaseWord))
                    {
                        wordCount[lowercaseWord]++;
                    }
                    else
                    {
                        wordCount[lowercaseWord] = 1;
                    }
                }
            }

            int uniqueWordCount = wordCount.Count; // Количество уникальных слов
            int totalWordCount = words.Length; // Общее количество слов

            Console.WriteLine("Слово\t\tЧастота");
            foreach (var kvp in wordCount)
            {
                Console.WriteLine($"{kvp.Key}\t\t{kvp.Value}");
            }

            Console.WriteLine($"Уникальных слов: {uniqueWordCount}");
            Console.WriteLine($"Всего слов: {totalWordCount}");
        }
    }
}