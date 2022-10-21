
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
if (num1 > num2)
 Console.WriteLine ($"{num1} - большее число, а {num2} - меньшее число");
else if (num2 > num1)
 Console.WriteLine ($"{num2} - большее число, а {num1} - меньшее число");
else if (num1 == num2)
 Console.WriteLine ("Числа равны");
else
 Console.WriteLine ("Числа не равны");   


