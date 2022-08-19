/* 

#Урок 1. Знакомство с языком программирования С#

//##Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int num1, num2;

// Ввод данных
// Console.Write("Программа, которая на вход принимает два числа (a и b) и выдаёт, какое число большее, а какое меньшее.");
Console.Write("a = ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("b = ");
num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2) {
Console.WriteLine("max = " +num1);
}
else if (num1 < num2){
Console.WriteLine("max = " +num2);
}
else if (num1 == num2){
Console.WriteLine("Числа равны");
}


*/

/* 

//##Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int a,b,c;

// Ввод данных
// Console.Write("Программа, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");
Console.Write("a = ");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("b = ");
b = Convert.ToInt32(Console.ReadLine());

Console.Write("c = ");
c = Convert.ToInt32(Console.ReadLine());

if (a > b && a > c) {
Console.WriteLine("max = "+a);
}
else if (b > a && b >c) {
Console.WriteLine("max = "+b);
}
else if (c > a && c > b){
Console.WriteLine("max = "+c);
}
else if (a == b && a == c){
Console.WriteLine("Все числа равны");
}


*/

/*

//##Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным

int a;

// Ввод данных
// Console.Write("программа, которая на вход принимает число и выдаёт, является ли число чётным");
Console.Write("Введите число: ");
a = Convert.ToInt32(Console.ReadLine());

if (a%2 == 0) {
Console.WriteLine("да");
}
else {
Console.WriteLine("нет");
}


*/

/*
//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int num;

Console.Write("Введите число: ");
num = Convert.ToInt32(Console.ReadLine());

int current = 0;

while(current<=num){
    if (current%2 == 0)
    { Console.Write(current + ", ");
    }
    current++;
}


*/