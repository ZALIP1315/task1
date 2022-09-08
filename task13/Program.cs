//task 13
Console.WriteLine("Введите число"); 
int N1 = Convert.ToInt32(Console.ReadLine());
string N2 = Convert.ToString(N1);
if (N2.Length > 2)
{
    Console.WriteLine(N2[2]);
}
else
{
    Console.WriteLine("третьей цифры нет");
}