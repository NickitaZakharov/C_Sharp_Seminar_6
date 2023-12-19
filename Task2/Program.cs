//Задайте строку, содержащую латинские буквы в обоих регистрах. 
//Сформируйте строку, в которой все заглавные буквы заменены на строчные.


Console.WriteLine("Введите строку:");
string input = Console.ReadLine();
string output = input.ToLower();
Console.WriteLine("Результат:");
Console.WriteLine(output);
