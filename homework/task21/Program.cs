// tak21
Console.WriteLine("Введите координату точки А по x");
int Ax= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки А по y");
int Ay= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки А по z");
int Az= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки B по x");
int Bx= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки B по y");
int By= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки B по z");
int Bz= Convert.ToInt32(Console.ReadLine());
double rez= Math.Sqrt(Math.Pow(Bx-Ax, 2)+ Math.Pow(By-Ay, 2) +Math.Pow(Bz-Az, 2));
Console.WriteLine($"{rez:f2}");
