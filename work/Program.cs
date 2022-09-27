/*Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"*/


string Task63 (int n){
    if (n == 1) return "1";
    else {
        return Task63 (n-1) +" "+ Convert.ToString(n);
    }
}

Console.WriteLine(Task63(5));

/*
Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"
*/

string Task65 (int n1, int n2){
    if (n2 == n1) return Convert.ToString(n1);
    else {
        return Task65 (n1, n2-1) +" "+ Convert.ToString(n2);
    }
}

Console.WriteLine(Task65(5, 10));


/*Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9*/

int Task67(int n){
    if(n/10 == 0){return n;}
    else return Task67(n/10) + n%10;
}

Console.WriteLine(Task67(453));


/*Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8*/

int Task69(int a, int b){
    if(b == 1){return a;}
    else return Task69(a, b-1) * a;
}

Console.WriteLine(Task69(3, 2));


