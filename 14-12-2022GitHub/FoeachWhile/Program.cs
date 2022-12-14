using System.Collections;
using System.Text;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

string[] arr = { "Null", "NullLy", "Lâm" };
//foreach (var item in arr)
//{
//    Console.WriteLine($"{item} có chiều dài {item.Length}");
//}

IEnumerable e = arr.GetEnumerator();
while (e.MoveNext())
{
    string s = (string)e.Current;
    Console.WriteLine($"{s} có chiều dài {s.Length}");
}