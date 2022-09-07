// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Добро пожаловать в программу нахождения третьего знака числа (Допустим, вы - Араб)");
Console.WriteLine("Введите  число");
Int64 number = Convert.ToInt64(Console.ReadLine());
Int64 thirddegit = (number%1000-number%100)/100;
if (Convert.ToUInt64(number)<100){
    System.Console.WriteLine("Третьего знака нет");
}
else
System.Console.WriteLine($"Третий знак числа {number} -> {thirddegit}");
