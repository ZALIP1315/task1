// task23
Console.WriteLine("Введите число");
int number= Convert.ToInt32(Console.ReadLine());
if (number >0)
{
    for(int i=1;i<=number;i++)
    Console.Write(i * i * i + " " );
}
else
Console.WriteLine("Неправильно введено число");