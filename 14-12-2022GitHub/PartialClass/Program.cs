namespace PartialClass;

internal partial class Program
{
    static void Main(string[] args)
    {
        //partial dùng để hợp các class
        //có thể hợp lại nhiều class khác nhau
        //chỉ cần có partial
        Console.WriteLine($"{nameof(number)} = {number}");
    }
}
