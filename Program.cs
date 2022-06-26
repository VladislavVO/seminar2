/*
## Задача 10: 
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

/*
int FindSecondNumber()

{
Console.Write("Input number ");
int number1 = Convert.ToInt32(Console.ReadLine());
int result = (number1 % 100) / 10;
return result;
}

int result = FindSecondNumber();

Console.WriteLine("The second digit is " + result);
*/



/*
## Задача 13: 
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

/*
int FindThirdDigit()
{
Console.Write("Input number ");
int number1 = Convert.ToInt32(Console.ReadLine());
int digitCount = (int)Math.Log10(number1) + 1;
int StepenDeleniya, result;


if (digitCount < 3)

{
     result = 14;
     
}

    else

    {
    StepenDeleniya = Convert.ToInt32(Math.Pow(10, digitCount - 2));

    result = number1 % StepenDeleniya / (StepenDeleniya / 10);
           
    }
return result;
}

int result = FindThirdDigit();


if (result < 10)
{
Console.WriteLine("The third digit is " + result);
}
else
{
Console.WriteLine("третьей цифры нет");
}
*/

/*
## Задача 15: 
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/


/*
string WeekEnd()
{
Console.Write("Input day ");
int number1 = Convert.ToInt32(Console.ReadLine());
string result;

if (number1 < 6) 
{
result = "нет";
}
else
    if (number1 < 8) 
    {
    result = "да"; 
    }
    else
    result = "ой"; 
    
return result;
}

string result = WeekEnd();

Console.WriteLine(result); 

*/