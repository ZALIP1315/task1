// task19

Console.WriteLine("Введите число"); 
String number = Console.ReadLine();
if (number.Length ==5)
{
    if(number[0]==number[4] && number[1]==number[3])
    Console.WriteLine($"{number}-паллиндром");
    else
    Console.WriteLine($"{number}-не паллиндром");
}
else 
{
    Console.WriteLine ("Вы ввели неправильное число");
};