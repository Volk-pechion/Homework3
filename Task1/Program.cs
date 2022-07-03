//  Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом

void printArray(int[] array)
{
   for (int i=0; i<array.Length; i++)
   {
      System.Console.WriteLine(array[i]);
   }
}

Console.Write("введите пятизначное число: ");
string number =  Console.ReadLine();
int numberInt = int.Parse(number);

int [] array = new int [5];

array[0] = numberInt/10000;
array[1] = numberInt/1000%10;
array[2] = numberInt/100%10;
array[3] = numberInt/10%10;
array[4] = numberInt%10; 

if ((array[0]==array[4]) && (array[1]== array [3]))
{
    System.Console.WriteLine("число является палидромом");
}
else
{
    System.Console.WriteLine("число не является палидромом");
}
