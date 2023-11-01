using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main(String[] args)
    {
        Hashtable books = new Hashtable();

        books.Add("Tim O'Brien", "The Things They Carried");
        books.Add("James Clear", "Atomic Habits");
        books.Add("Yuval Noah Harari", "Sapiens: A Brief History of Humankind");
        books.Add("Ray Dalio", "Principles");
        books.Add("Toni Morrison", "Beloved");
        books.Add("Dale Carnegie", "How to Win Friends and Influence People");

        Console.WriteLine("Enter an author to find a book: ");
        var author = Console.ReadLine();

        if (books.ContainsKey(author))
        {
            string value = (string)books[author];
            Console.WriteLine($"The book for key {author} is: {value}");
        }
        else
        {
            Console.WriteLine($"Key {author} not found.");
        }

        char[] separators = new char[] { ' ', '.', ',', '!', '?' };
        string[] words = author.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < words.Length; i++)
        {
            words[i] = words[i].ToLower();
        }

        Hashtable wordfreq = new Hashtable();

        foreach (string i in words)
        {
            if (wordfreq.ContainsKey(i))
            {
                int freq = (int)wordfreq[i];
                wordfreq[i] = freq + 1;
            }
            else
            {
                wordfreq[i] = 1;
            }
        }

        Console.WriteLine("Word frequencies in the author text:");
        foreach (DictionaryEntry entry in wordfreq)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value} times");
        }

    }

}
