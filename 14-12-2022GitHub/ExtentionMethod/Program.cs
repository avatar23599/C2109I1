﻿using ExtentionMethod;
using System.Text;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

Console.WriteLine("Vui lòng nhập 1 số: ");
int i = int.TryParse(Console.ReadLine(), out var result)?result:0;

//Làm kiểm tra xem viến i có lớn hơn 100 hay không
CheckNumber.Check(i, 100);
int abc = 200;
abc.IsGreaterThan(100);
i.IsGreaterThan(100);
//extention method không thông qua đối tượng của class đang chứa
//mà thông qua cái muốn sử dụng
Program pro = new();
pro.Hi();