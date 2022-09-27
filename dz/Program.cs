/*Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/
Console.WriteLine("------------ЗАДАЧА 64--------------- ");
void Task64 (int n){
    if (n != 0){
        Console.Write($"{n} ");
        Task64(n-1);
    }
}
Console.WriteLine("Введите N:");
int number64 = Convert.ToInt32(Console.ReadLine());
Task64 (number64);
Console.WriteLine("----------------------------------- ");

/*Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

Console.WriteLine("------------ЗАДАЧА 66--------------- ");
int Task66(int m, int n){
    if (m == n) return m;
    else return Task66(m+1, n) + m;
}
Console.WriteLine("Задайте значения M и N (M < N)");
int number66m = Convert.ToInt32(Console.ReadLine());
int number66n = Convert.ToInt32(Console.ReadLine());
if (number66m < number66n){
    Console.WriteLine(Task66(number66m,number66n));
}
else Console.WriteLine("НЕКОРЕКТНЫЕ ДАННЫЕ ");
Console.WriteLine("----------------------------------- ");


/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

Console.WriteLine("------------ЗАДАЧА 68--------------- ");
int Task68(int m, int n){
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return Task68(m - 1, 1);
    else  return Task68(m - 1, Task68(m, n - 1));
}

Console.WriteLine(Task68(2,3));
Console.WriteLine("------------------------------------- ");



