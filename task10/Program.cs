Console.WriteLine("Введите трехзначное число");
String User= Console.ReadLine() ;
int N1 = Convert.ToInt32 (User);
int A1 = N1 % 100;
int A2 = A1 / 10;
if (N1 > 99 && N1< 1000 || N1 > -1000 && N1 < -99)
{
  if (A2 < 0)
  {
    Console.WriteLine(-A2);
  }
  else Console.WriteLine(A2);
}
else
{
    Console.WriteLine($"Число {N1} не является трехзначным");
};