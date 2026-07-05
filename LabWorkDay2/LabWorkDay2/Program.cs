// Console.Write("Mehsulun qiymetini daxil edin: ");
// string input = Console.ReadLine();
// Console.Write("Endirim faizini daxil edin: ");
// string input2 = Console.ReadLine();
// if (double.TryParse(input, out double price)&&double.TryParse(input2, out double amount))
// {
//     double discountAmount = price * amount / 100;
//     double finalAmount = price - discountAmount;
//     Console.Write("Final amount is: " + finalAmount);
// }
// else
// {
//     Console.WriteLine("Invalid input");
// }

// Console.Write("Ayliq maasi daxil edin: ");
// string input = Console.ReadLine();
// Console.Write("Overtime saatlarinin sayini daxil edin: ");
// string input2 = Console.ReadLine();
// if (double.TryParse(input, out double salary) && double.TryParse(input2, out double amount))
// {
//     double hourlyRAte = salary / 160;
//     double overtimePay = amount * hourlyRAte * 1.5;
//     double totalSalary = salary + overtimePay;
//     Console.WriteLine($"Saatlıq əmək haqqı: {hourlyRAte}");
//     Console.WriteLine($"Əlavə ödəniş: {overtimePay}");
//     Console.WriteLine($"Yekun əmək haqqı: {totalSalary}");
// }


// Console.Write("Havanin temperaturunu daxil edin(Selsi ile): ");
// string input = Console.ReadLine();
// if (double.TryParse(input, out double selsi))
// {
//     double F = selsi * 9 / 5 + 32;
//     Console.WriteLine("Fahrenheit: " + F);
//     if (F % 2 == 0)
//     {
//         Console.Write("Tam hisse: cutdur");
//     }
//     else
//     {
//         Console.Write("Tam hisse cut deyil");
//     }
// }

// Console.Write("Il daxil edin: ");
// string input = Console.ReadLine();
// if (double.TryParse(input, out double year))
// {
//     if (year % 400 == 0)
//     {
//         Console.WriteLine("Bu il uzun ildir.");
//     }
//     else if (year % 100 == 0)
//     {
//         Console.WriteLine("Bu il uzun il deyil.");
//     }
//     else if (year % 4 == 0)
//     {
//         Console.WriteLine("Bu il uzun ildir.");
//     }
//     else
//     {
//         Console.WriteLine("Bu il uzun il deyil.");
//     }
// }

// Console.Write("Enter number: ");
// string input = Console.ReadLine();
// Console.Write("Enter number: ");
// string input2 = Console.ReadLine();
// Console.Write("Enter number: ");
// string input3 = Console.ReadLine();
// if (int.TryParse(input, out int number1) && int.TryParse(input2, out int number2) &&
//     int.TryParse(input3, out int number3))
// {
//     if (number1 > number2 && number1 > number3) 
//     {
//         Console.Write($"En boyuk eded: {number1}");
//     } 
//     else if (number2 > number3 && number2 > number1)
//     {
//         Console.Write($"En boyuk eded: {number2}");
//     } 
//     else if (number3 > number1 && number3 > number2)
//     {
//         Console.Write($"En boyuk eded: {number3}");
//     }
//     else if (number1 == number2 && number1 > number3) 
//     {
//        Console.Write("First and second numbers are equal and greater than third number");
//     }
//     else if (number1 == number3 && number1 > number2)
//     {
//         Console.Write("First and third numbers are equal and greater than second number");
//     }
//     else if (number2 == number3 && number2 > number1)
//     {
//         Console.Write("Second and third numbers are equal and greater than first number");
//     }
//     else
//     {
//         Console.Write("all numbers are equal");
//     }
// }
// else
// {
//     Console.WriteLine("Invalid input");
// }

// Console.Write("Enter triangle numbers: ");
// string input = Console.ReadLine();
// string input2 = Console.ReadLine();
// string input3 = Console.ReadLine();
// if (int.TryParse(input, out int number1) 
//     && int.TryParse(input2, out int number2) 
//     && int.TryParse(input3, out int number3))
// {
//     if (number1 < number2 + number3 && number2 < number1 + number3 && number3 < number1 + number2)
//     {
//         if (number1 == number2 && number2==number3)
//         {
//             Console.Write("Beraberterefli ucbucaqdir");
//         }
//         else if (number1 == number2 || number2 == number3 || number3 == number1)
//         {
//             Console.Write("Beraberyanli ucbucaqdir");
//         }
//     }
//     else
//     {
//         Console.Write("Muxtelif terefli ucbucaqdir");
//     }
// }
// else
// {
//     Console.WriteLine("Invalid input");
// }


// using System.Security.Cryptography; double[] SumArray(double[] array)
// {
//     int counter = 0;
//     double avarage = 0;
//     double sum = 0;
//     double max = array[0];
//     double min = array[0];
//     foreach (int numbers in array)
//     {
//         if (numbers > max)
//         {
//             max = numbers;
//         } 
//         if (numbers < min)
//         {
//             min = numbers;
//         }
//         sum += numbers; 
//         avarage = (double)sum / array.Length;
//     }
//     double[]result=[max,min ,sum, (double)avarage];
//     return result;
// }
//
//
//
// var finalArray=SumArray(new double[] {1,2,3,4});
// Console.WriteLine($"Max is: {finalArray[0]}, Min is: {finalArray[1]}, Average is: {finalArray[3]}, Sum is: {finalArray[2]}");



// Console.Write("Enter your initial balance: ");
// double balance = double.Parse(Console.ReadLine());
// do
// {
//     Console.Write("Cixartmaq istediyiniz meblegi qeyd edin: ");
//     string input = Console.ReadLine();
//     if (int.TryParse(input, out int amount))
//     {
//         if (amount == 0)
//         {
//             break;
//         }
//
//         if (amount <= balance)
//         {
//             balance -= amount;
//             Console.WriteLine($"Yeni balans: {balance}");
//         }
//         else
//         {
//             Console.WriteLine("Balans kifayet etmir");
//         }
//     }
//     else
//     {
//         Console.WriteLine("Duzgun eded qeyd edin.");
//     }
// } while (true);


// Console.WriteLine("Enter a number: ");
// string numberInput = Console.ReadLine();
// while (true)
// {
//     if (!int.TryParse(numberInput, out int number))
//     {
//         Console.WriteLine($"{numberInput} is not a number.");
//         continue;
//     }
//     if (number % 2 != 0 && number % 3 != 0 && number % 5 != 0 && number % 7 != 0)
//     {
//         Console.WriteLine($"{number} sadə ədəddir.");
//     }
//     else
//     {
//         Console.WriteLine($"{number} sadə ədəd deyil.");
//     }
//     break;
// }

// int n = int.Parse(Console.ReadLine());
// int w = 5;
// for (int i = 2; i < n; i++)
// {
//     if (n % i == 0)
//     {
//         Console.WriteLine("Murekkebdir.");
//         w = 6;
//         break;
//     }
// }
//
// if (w == 5)
// {
//     Console.WriteLine("Sadedir.");
// }
