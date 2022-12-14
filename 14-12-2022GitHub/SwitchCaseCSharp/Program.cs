﻿
Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding= Encoding.Unicode;

int? number1 = Random.Shared.Next(0, 9);
int? number2 = Random.Shared.Next(0, 9);
Console.WriteLine($"{nameof(number1)} = {number1}");
Console.WriteLine($"{nameof(number2)} = {number2}");

Console.WriteLine("Vui lòng nhập dấu: ");
var pheptoan = Console.ReadLine();

//switch (pheptoan)
//{
//    case "+": Console.WriteLine(number1 + number2);break;
//    case "-" when number1>number2: Console.WriteLine(number1 - number2);break;
//    case "*":
//        Console.WriteLine(number1 * number2); break;
//    case "/" when (number1 > number2&&number2!=0): Console.WriteLine((decimal)number1 / (decimal)number2); break;
//    default: Console.WriteLine("i can't do it"); break;
//}

//switch expression => biểu thức switch
Console.WriteLine(
    
    pheptoan switch
    {
        "-" when number1 > number2                   => (number1 - number2,"hello"),
        "+"                                          => number1 + number2,
        "*"                                          => number1 * number2,
        "/" when (number1 > number2 && number2 != 0) => number1 / number2,
        _ => "i can't do it"
    }
    
    );