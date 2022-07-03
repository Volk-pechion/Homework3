// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

int promt(string message)
{
    System.Console.WriteLine(message);
    string param = Console.ReadLine();
    return int.Parse(param);
}

int x1 = promt("введите х1");
int y1 = promt("введите y1");
int z1 = promt("введите z1");

int x2 = promt("введите х2");
int y2 = promt("введите y2");
int z2 = promt("введите z2");

int x = x2-x1;
int y = y2-y1;
int z = z2-z1;
double l =  Math.Sqrt(x*x+y*y+z*z);

System.Console.WriteLine(l);