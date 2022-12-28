using System.Text;
using Tuple;
Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;


Person per = new()
{
    Id = 1,
    FirstName = "Tối",
    LastName = "nay uống hồng trà"
};

Console.WriteLine(per.Id);
Console.WriteLine(per.FirstName+per.LastName);

//dùng tuple không cần đến class(struct)
ValueTuple<int, string, string> p1 = (1, "tối", "nay Huân bao 1 ly hồng trà 35 ngàn");
Console.WriteLine(p1.Item2+p1.Item3);

(int, string, string) p2 = (1, "Tối nay", "Huân bao một ly hồng trà 35 ngàn");
Console.WriteLine(p2.Item2+p2.Item3);

var p3 = (1, "Tối nay", "Huân bao một ly hồng trà 35 ngàn");//value tuple

var p4 = (1); // variable int p4 = 1

//net core dùng cái name thay thế cho các Item1, item2,..
(int Id, string FristName, string LastName) p5 = (1, "Tối nay", "Huân bao một ly hồng trà 35 ngàn");
Console.WriteLine(p5.FristName + p5.LastName);

var p6 = (id: 1, FristName: "Tối nay",  "Huân bao ly hồng trà 35 ngàn");
Console.WriteLine(p6.FristName + p6.Item3);

var p7 = new { id = 1, fristname = "Null", lastname = "Ly" };
Console.WriteLine(p7.fristname+p7.lastname);