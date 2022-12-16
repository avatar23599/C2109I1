
using System.Text;
using System.Text.RegularExpressions;
Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;
string? str= null;
Console.WriteLine("Vui long nhap so: ");
str= Console.ReadLine();
bool? dem = true;
var formula = new Regex("^[0-9]+$");
while (dem == true)
{
    if (formula.IsMatch(str))
    {
        int result = Convert.ToInt32(str);
        Console.WriteLine("success");
        dem = false;
    }

    if (int.TryParse(str, out int i))
    {
        Console.WriteLine($"i la so: {i}");
        dem = false;
    }

    
    Console.WriteLine("Vui long nhap so luong: ");
    string? amount = Console.ReadLine();
    //mệnh đề grual clause
    if (string.IsNullOrEmpty(amount)) return;
}

