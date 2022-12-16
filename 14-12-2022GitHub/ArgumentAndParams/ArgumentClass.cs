using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgumentAndParams;
internal class ArgumentClass
{
    //Biểu thức chạy nhanh hơn phương thức
    public void Display(int a, int b, int c )
    =>
    Console.WriteLine($"{nameof(a)} = {a}, {nameof(b)} = {b}, {nameof(c)} = {c}");
    
    //optional argument
    //parameter(tham số)
    public void Show(int a = 0, int b = default, int c = 10)
    =>
    Console.WriteLine($"{nameof(a)} = {a}, {nameof(b)} = {b}, {nameof(c)} = {c}");//expression body

    public void SumParam(params int[] values)//params => tự hiểu và tự đẩy các số vào mảng
    {
        int? sum = 0;
        foreach ( var i in values ) 
        {
            sum += i;
        }
        Console.WriteLine($"{nameof(sum)} = {sum}");
    }
}
