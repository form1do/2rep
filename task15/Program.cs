// See https://aka.ms/new-console-template for more information
Console.WriteLine("Добро пожаловать в программу определения выходных");
Console.WriteLine("Введите  число, обозначающее номер дня недели");
Int32 day = Convert.ToInt32(Console.ReadLine());
if (day <=5){
    System.Console.WriteLine("Это будний день");
}
else
System.Console.WriteLine("Это выходной");

