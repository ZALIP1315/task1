// Task15
Console.WriteLine("Введите цифру,обозначающую день недели");
Console.WriteLine("понедельник - 1");
Console.WriteLine("вторник - 2");
Console.WriteLine("среда - 3");
Console.WriteLine("четверг - 4");
Console.WriteLine("пятница - 5");
Console.WriteLine("суббота - 6");
Console.WriteLine("воскресенье - 7");

String User= Console.ReadLine() ;
int N1 = Convert.ToInt32 (User);
if (N1 >0 && N1 <8)
{
   if (N1 == 6 || N1 == 7)
   {
      Console.WriteLine("Это выходной");
   }
   else
   {
       Console.WriteLine("Это будний день");
   }
}
else 
{
    Console.WriteLine("Вы ввели некорректное число");
};