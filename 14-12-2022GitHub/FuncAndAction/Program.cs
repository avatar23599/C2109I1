internal class Program
{
    //local function->hàm cục bộ nằm trong một phương thức nào đó
    public static void Add(int a, int b) => Console.WriteLine(a + b);
    public static void Show() => Console.WriteLine("C2109I1");

    public static int ReturnNumber() => 5;
    private static void Main(string[] args)
    {
        void Sub(int a, int b) => Console.WriteLine(a+b);

        //func và action => đều là delegate
        //action dùng cho các phương thức không có kiểu trả về-> phương thức có chưa void
        //func dung cho các phương thức khác void

        Action act = Show;
        act();
        Func<int> fun = ReturnNumber;
        Console.WriteLine(fun());

        Action<int, int> ac = Add;
        ac(4, 6);
    }
}