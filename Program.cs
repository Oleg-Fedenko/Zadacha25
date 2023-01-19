/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/


int getUserData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()!);
}

int numA = getUserData("Введите число A: ");
int numB = getUserData("Введите число B: ");
ToDegree(numA, numB);



void ToDegree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(result);
}

