﻿//Задайте строку, состоящую из слов, разделенных пробелами. Сформировать строку, 
//в которой слова расположены в обратном порядке. 
//В полученной строке слова должны быть также разделены пробелами.

public class Program

{

    public static string ReverseWords(string sentence)

    {



        string[] words = sentence.Split(' ');
        Array.Reverse(words);
        string reverseSentence = string.Join(" ", words);
        return reverseSentence;

    }



    public static void Main(string[] args)

    {

        string sentence = "Один Два Три Четыре Пять Шесть Семь";
        string reverseSentence = ReverseWords(sentence);
        Console.WriteLine(reverseSentence);

    }

}
