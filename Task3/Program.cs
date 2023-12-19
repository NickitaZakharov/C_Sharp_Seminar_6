//Задайте произвольную строку. 
//Выясните, является ли она палиндромом.

public class PalindromeChecker

{

    public static bool IsPalindrome(string str)

    {

        if (string.IsNullOrEmpty(str))

        {

            return true;

        }



        int start = 0;

        int end = str.Length - 1;



        while (start <= end)

        {

            if (str[start] != str[end])

            {

                return false;

            }



            start++;

            end--;

        }



        return true;

    }

}



public class Program

{

    public static void Main(string[] args)

    {

        string input = "Просто произвольная строка";



        bool isPalindrome = PalindromeChecker.IsPalindrome(input);



        Console.WriteLine("Is the string a palindrome? " + isPalindrome);

    }

}
