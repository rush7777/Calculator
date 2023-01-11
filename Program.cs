// Calculator
System.Console.WriteLine($"Enter 1st number: " );
int firsta = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter Operations(+,-,*,/,%)");
string operators = Console.ReadLine();
System.Console.WriteLine($"Enter 2nd number: " );
int seconda = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Addtraction: {firsta + seconda}");
Console.WriteLine($"Subtraction: {firsta - seconda}");
Console.WriteLine($"Multiplication: {firsta * seconda}");
Console.WriteLine($"Division: {firsta / seconda}");
//Ternar operators
string massage =
  firsta <= 0
    ? "1st  number is negative"
    : "1st number is positive";
System.Console.WriteLine(massage);

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

string results = operators switch
{
  "+" => $"{firsta} + {seconda} = {firsta + seconda}",
  "-" => $"{firsta} - {seconda} = {firsta - seconda}",
  "*" => $"{firsta} * {seconda} = {firsta * seconda}",
  "/" => $"{firsta} / {seconda} = {firsta / seconda}",
   _ => "Operation Not Found!"
};
System.Console.WriteLine(results);
/*
switch (operators)
{
    case "+" :
      System.Console.WriteLine($"{firsta} + {seconda}  = {firsta + seconda}");
    break;
    case "-" :
      System.Console.WriteLine($"{firsta} - {seconda}  = {firsta - seconda}");
    break;
    case "*" :
      System.Console.WriteLine($"{firsta} * {seconda}  = {firsta * seconda}");
    break;
    case "/" :
      System.Console.WriteLine($"{firsta} / {seconda}  = {firsta / seconda}");
    break;
    default:
       System.Console.WriteLine("Operation NOT Found!");
    break;
} */

int counter = 0;
while(firsta > counter){
  counter++;
  int need = counter % 2;
  if(need == 0)
  System.Console.WriteLine(counter);

}
