//fw là dùng để tách các lớp-> tách folder ->layzer
//interface, extension methoh
//một project dùng cho nhiều project khác-> tách project ->tier
using System.Text;
using ExeciseOop1.Dal;
using ExeciseOop1.Entity;
using ExeciseOop1.ExtensionMethod;
using ExeciseOop1.Helper;
Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding= Encoding.Unicode;

DalProduct proD = new();

proD.ChangeColor(ConsoleColor.Red,ConsoleColor.Green);
Product pro = new();
Console.WriteLine("Vui lòng nhập ngày sản xuât");
pro.ProDate = Validate<DateTime>.CheckReadLine();



//Console.WriteLine(pro);