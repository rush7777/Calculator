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
if(firsta == seconda){
System.Console.WriteLine($"1st number is equal to 2nd number");
}
else if(firsta > seconda){System.Console.WriteLine($"1st number is greater than 2nd number");
}
else if(firsta < seconda){System.Console.WriteLine($"1st number is smaller than 2nd number");
}
else {
  System.Console.WriteLine($"1st number is not equal to 2nd number");
}