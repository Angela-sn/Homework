// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3,5 -> 243 
double a;
double b;
double c;

Console.Write("Введите число A: ");  
a = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите число B, которое возводит число А в натуральную степень В: ");  
b = Convert.ToDouble(Console.ReadLine());

c = Math.Pow(a, b);

Console.WriteLine($"{a},{b} -> {c}");  

Console.ReadLine();



