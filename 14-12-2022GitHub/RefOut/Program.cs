using RefOut;
using System.Text;

int a = 10;
int b = 5;

//UseRefOut.ChangeNumber(ref a, ref b);
//Console.WriteLine($"Program: {nameof(a)}= {a},{nameof(b)}={b}");

UseRefOut.ChangeNumber(out a, out b);
Console.WriteLine($"Program: {nameof(a)}= {a},{nameof(b)}={b}");