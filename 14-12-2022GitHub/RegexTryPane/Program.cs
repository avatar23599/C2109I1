
using System.Text;
using System.Text.RegularExpressions;
Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;
string? str= null;
Console.WriteLine("Vui long nhap so: ");
str= Console.ReadLine();
bool? dem = true;
var formula = new Regex("^[0-9]+$");
#region regex
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
    //mệnh đề grual clause
    if (string.IsNullOrEmpty(Console.ReadLine()))
    {
        return;
    }
    //làm cái gì đó

    //==============================
    if(Console.ReadLine() != null)
    {
        //làm cái gì đó
    }

    
}
#endregion

#region try_catch
Console.WriteLine("Vui long nhap so luong: ");
string? amount = Console.ReadLine();
try
{
    int? total = int.Parse(amount);
    if (total <= 0) throw new Exception("phải lớn hơn 0");
    Console.WriteLine($"{nameof(total)} = {total}");
}
catch (Exception)when (amount.Contains("$"))
{
    Console.WriteLine("Chuỗi không được chứa $");
}
catch (Exception e)
{

    Console.WriteLine($"{e.GetType()}, {e.Message}");
}
#endregion

