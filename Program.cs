// 1) Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
//  a=50 => нет
//  a=7 => нет
// a=322 => да


int i = 322;

   if (i % 7 == 0 && i % 23 == 0)
{
    Console.WriteLine("+");
}


// 2) Напишите программу, которая принимает
// на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠
// 0 и выдаёт номер координатной четверти плоскости,
// в которой находится эта точка.
// 2, 3 => 1
// -5, 3 => 2
// -3, -2 => 3
// 4, -2 => 4

 int x = 4;
 int y = -2;

 if (x > 0 && y > 0 )
 {
    Console.WriteLine("1 четверть");
 }
 else if (x < 0 && y > 0 )
 {
    Console.WriteLine("2 четверть");
 }
else if (x < 0 && y < 0 )
 {
    Console.WriteLine("3 четверть");
 }
else if (x > 0 && y < 0 )
 {
    Console.WriteLine("4 четверть");
 }



// Задача 3: Напишите программу, которая принимает
// на вход целое число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 40 => 4
// 96 => 9
// 72 => 7

// 1 способ
int firstDigit = 7; 
int secondDigit = 2;
int max = firstDigit;
if(max < secondDigit)
{
   Console.WriteLine("max вторая цифра");
}

else
 {
  Console.WriteLine("max первая цифра");
}




// 2 способ
Console.WriteLine("Введите число");
int digit = Convert.ToInt32(Console.ReadLine());
if (digit >=10 && digit <=99)
{
   int tense = (int) digit / 10 ;
   int unit = digit % 10;
   if (tense > unit)
   {
      Console.Write("Десяток больше, чем единиц");
   }
   else if (unit > tense)
   {
      Console.Write("Единиц больше, чем десяток");
   }
   else 
    {
      Console.Write("Равны");
   }
   
}
else
{
    Console.WriteLine("Число не находится в заданном диапазоне");
}


// Задача 4: Напишите программу, которая на вход
// принимает натуральное число N, а на выходе
// показывает его цифры через запятую.

// 568 => 5,6,8
// 8 => 8
// 9542 => 9,5,4,2

Console.WriteLine("Введите число");
int digit = Convert.ToInt32(Console.ReadLine());
int hundred = (int) digit / 100;
int tense = (int) digit / 10 ;
int unit = digit % 10;

{
   Console.Write(",");
}


 

