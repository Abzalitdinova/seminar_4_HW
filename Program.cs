// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
// в натуральную степень B.

// Console.WriteLine("введите число");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите степень числа");
// int B = Convert.ToInt32(Console.ReadLine());
// int GetMultiply (int number)
// {
//     int Result = 1;
//     for (int i = 1; i <= B; i++)
//     {
//       Result *= A;  
//     }
// return Result;
// }
// Console.WriteLine($"число {A} в степени {B} равно {GetMultiply(B)}");

// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

// Console.WriteLine("введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// int GetSumNumbers(int number)
// {
//     int sum = 0; 
//     while (number > 0)
//     {
//          sum = sum + number % 10;
//          number /= 10; 
                 
//     }
//     return sum;
// }
// Console.WriteLine($"Сумма чисел: {GetSumNumbers(num)}");

// Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран.

// int[] GetBinaryArray(int size) 
// {
//     int[] result = new int[size]; 
//     for (int i = 0; i < size; i++) 
//     {
//         result[i] = new Random().Next(); 
//     }
//     return result;
// }
// int[] testArray = GetBinaryArray(8); 
// Console.WriteLine($"Массив: [ {String.Join("     ",testArray)} ]");