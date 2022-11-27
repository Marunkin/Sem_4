//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. (Задачи, решенные через Math.Pow, будут отправлены на переделку, так как задача стоит в том, чтобы написать цикл)

//3, 5 -> 243 (3⁵)
//2, 4 -> 16

/*
Console.WriteLine("Введите числа: ");
int A = int.Parse(Console.ReadLine()!);
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Число {A} в степени {B} будет равно {GetDegree(A, B)}");
//-----------------------------------------МЕТОДЫ-------------------------------------------------
int GetDegree(int limit1, int limit2){
    int number = limit1;
    for (int i = 1; i < limit2; i++){
        number *= limit1; // sum = += i;
    }
    return number;
}
*/
//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11
//82 -> 10
//9012 -> 12
/*
Console.WriteLine("Введите число: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр в числе {A} равна {GetSum(A)}");
//-----------------------------------------МЕТОДЫ-------------------------------------------------
int GetSum(int limit){
    int sum = 0;
    while(true){
        if(limit/10 !=0 || limit%10 !=0){
            sum = sum+(limit%10);
            limit = limit/10;
        }
        else {
            break;
        }
    }
    return(sum);
}
*/

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (числа берете любые)
int[] array = new int[8];
Mass(array);
Console.WriteLine($"Mассив: [{String.Join(" ",array)}]");
//-----------------------------------------МЕТОДЫ-------------------------------------------------
int[] Mass(int[] array){
    for (int i = 0; i < array.Length; i++){
        array[i] = new Random().Next();
    }
    return array;
}