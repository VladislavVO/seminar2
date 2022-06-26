/*

## Задача 10: 

Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

/*
    Console.Write("Input number ");
    int number1 = Convert.ToInt32(Console.ReadLine());

int FindSecondNumber(int num1)
{

    int res = num1 % 2;
    return res;
}

int result = FindSecondNumber();

Console.WriteLine("The second digit of " + number1 + " is " + result);

*/

/**********************************************************************************
Console.Write("Input number ");
int number1 = Convert.ToInt32(Console.ReadLine());

int result = (number1 % 100) / 10;

Console.WriteLine("The second digit of " + number1 + " is " + result);

***********************************************************************************/



/*
## Задача 13: 

Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6

*/



Console.Write("Input number ");
int number1 = Convert.ToInt32(Console.ReadLine());

int digitCount = (int)Math.Log10(number1) + 1;
int StepenDeleniya, result;


if (digitCount < 3)

        {
            Console.WriteLine("третьей цифры нет");
        }

        else

        {
            StepenDeleniya = Convert.ToInt32(Math.Pow(10, digitCount - 2));

            result = number1 % StepenDeleniya / (StepenDeleniya / 10);

            Console.WriteLine(result);
        }





/*
int result = number1 % 10;



## Задача 15: 

Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет


*/

/**********************************************************************************
Console.Write("Input number of day ");
int number1 = Convert.ToInt32(Console.ReadLine());

if (number1 < 6) 
{
Console.WriteLine("нет");
}
else
    if (number1 < 8) 
    {
    Console.WriteLine("да"); 
    }
    else
    Console.WriteLine("ой"); 


***********************************************************************************/