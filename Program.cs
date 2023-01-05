// Calculator

using System;
System.Console.WriteLine($"Enter 1st number: " );
int firsta = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Enter 2nd number: " );
int seconda = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Addtraction: {firsta + seconda}");
Console.WriteLine($"Subtraction: {firsta - seconda}");
Console.WriteLine($"Multiplication: {firsta * seconda}");
Console.WriteLine($"Division: {firsta / seconda}");
System.Console.WriteLine($"1st number equal to 2nd number: {firsta == seconda}");
System.Console.WriteLine($"1st number greater to 2nd number: {firsta > seconda}");
System.Console.WriteLine($"1st number smaller to 2nd number: {firsta < seconda}");
System.Console.WriteLine($"1st number not equal to 2nd number: {firsta != seconda}");