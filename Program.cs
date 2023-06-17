Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

void Twonum(int num)
{
    if (num >= 100 && num <= 999)
    {
        System.Console.WriteLine($" {(num / 10) % 10}");
    }
    else
    {
        System.Console.WriteLine("Вы введи не трехзначное число!");
    }
}

System.Console.Write("введите число N -> ");
int num1 = Convert.ToInt32(Console.ReadLine());
Twonum(num1);


Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

System.Console.WriteLine("Введите цисло");
int num1 = Convert.ToInt32(Console.ReadLine());
string num1Text = Convert.ToString(num1);
if (num1Text.Length > 2){
  Console.WriteLine("третья цифра -> " + num1Text[2]);
}
else {
  Console.WriteLine("-> третьей цифры нет");
}


void CheckingTheDayOfTheWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("(этот день выходной) -> да");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("это вообще не день недели");
  }
  else Console.WriteLine("(этот день не выходной) -> нет");
}

CheckingTheDayOfTheWeek(dayNumber);