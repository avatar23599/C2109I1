


Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;
List<Student> students = new()
{
    new Student() { RollNumber = 1, Fullname = "NullLy",Section ="dãy số 1",HostelNumber = 1},
    new Student() { RollNumber = 2, Fullname = "Null",Section ="dãy số 2",HostelNumber = 1},
    new Student() { RollNumber = 3, Fullname = "Ly",Section ="dãy số 3",HostelNumber = 1},
    new Student() { RollNumber = 4, Fullname = "NullLLy",Section ="dãy số 4",HostelNumber = 1},
    new Student() { RollNumber = 5, Fullname = "Lâm",Section ="dãy số 1",HostelNumber = 2},
    new Student() { RollNumber = 6, Fullname = "La",Section ="dãy số 2",HostelNumber = 2},
    new Student() { RollNumber = 7, Fullname = "Lam",Section ="dãy số 3",HostelNumber = 3},
    new Student() { RollNumber = 8, Fullname = "Âm",Section ="dãy số 4",HostelNumber = 4},
    new Student() { RollNumber = 9, Fullname = "Am",Section ="dãy số 1",HostelNumber = 4},
    new Student() { RollNumber = 10, Fullname = "M",Section ="dãy số 2",HostelNumber = 4}
};

Stopwatch sm = new();
sm.Restart();
//foreach (var stu in students)
//{
//    Console.WriteLine(stu);
//}
//Console.WriteLine($"Foreach Time: {sm.ElapsedMilliseconds}");
//sm.Restart();

//tất cả các dạng của collection đều có mẫu để duyệt qua dữ liệu mà không dung đến for hay foreach =>ienumarator
//IEnumerator enu = students.GetEnumerator();
//while (enu.MoveNext())
//{
//    Console.WriteLine(enu.Current);
//}
//Console.WriteLine($"Foreach Time: {sm.ElapsedMilliseconds}");

//LINQ => language Intergrated query

//linq to sql

//sql bình thường select form where group by having order by

//form where group by having order => select

//linq to object

//linq to xml, json

//parallel linq => qlinq


//linq to object có 2 dạng
//style 1) theo trường phái sql => sql syntax, dễ học, dễ hiểu
//style 2) theo trường phái lamda => method syntax khó học, rất khó để hiểu

//liệt kê tất cả sinh viên với mã sinh viên phải lớn hơn 2

//foreach (var stu in students)
//{
//    if (stu.RollNumber > 2)
//    {    
//        Console.WriteLine(stu);
//    }
//}
//foreach (var i in from t in students
//                  where t.RollNumber > 2
//                  select t)
//{
//    Console.WriteLine(i);
//}
//IEnumerable là con của IEnumbertor
//tìm tổng số sinh viên trong cái List
//dung để tính 1 lần

//var listStu = (from t in students
//               where t.RollNumber > 2
//               select t).Count();
//Console.WriteLine(listStu);

//dung nhiều làn listStu
//var listStu = (from t in students
//               where t.RollNumber > 2
//               select t);
//Console.WriteLine(listStu.Count());

//linq to object style 2 methoh syntax
//var listStu = students.Where(stu => stu.RollNumber > 2);//đúng
//var listSt = students.Where(stu => stu.RollNumber > 2).Select(stu => stu);//sai where tự động trả về không cần phải select
//var listSt = students.Select(stu => stu).Where(stu => stu.RollNumber > 2);//sai

//foreach (var i in students.Where(stu => stu.RollNumber > 2))
//{
//    Console.WriteLine(i);
//}

//các phương thức có sẵn trong list
students.ForEach(Console.WriteLine);
students.ForEach(stu=> Console.WriteLine(stu));
students.ForEach(
    stu =>
{
    if (stu.RollNumber > 2)
    {
        Console.WriteLine(stu);
    }
});

//kết hợp lambda với phương thức có sẵn của list
students.Where(stu => stu.RollNumber > 2)
        .ToList()
        .ForEach(Console.WriteLine);

//Nếu sài được phương thức của nó trước trước thì dùng trước, sau đó hãy tới extension method
//var r = from stu in students
//        where stu.RollNumber > 2
//        select new //anonymous type
//        {
//            stu.RollNumber,
//            stu.Fullname
//        };
//r.ToList().ForEach(Console.WriteLine);


//var r = from stu in students
//        where stu.RollNumber > 2
//        select new //anonymous type
//        {
//            StudentDetail = $"{stu.RollNumber}:{stu.Fullname}",
//            StudentRoom = $"{stu.Section}={stu.HostelNumber}"
//        };
//r.ToList().ForEach(Console.WriteLine);

//students.Select(stu => new
//{
//    StudentDetail = $"{stu.RollNumber}:{stu.Fullname}",
//    StudentRoom = $"{stu.Section}={stu.HostelNumber}"
//}).ToList() .ForEach(Console.WriteLine);

foreach (var stu in students)
{
    Console.WriteLine(stu);
}

IEnumerator enu = students.GetEnumerator();//-> vong lập for
while (enu.MoveNext())
{

}

var t = from stu in students
         select  stu;


//lần đầu tiên nó sẽ thực thi trên sever-> trả về bộ nhớ
//select * from list where RollNumber > 2
IEnumerable<Student> i = from stu in students//->duyệt list bằng linq->linq to Object->làm về đối tượng
                         where stu.RollNumber > 2
                         select stu;
//là vào bộ nhớ loại bỏ chỉ lấy 2 dòng đầu tiên
i = i.Take(2);
//lần đầu tiên nó sẽ thực thi trên sever-> trả về bộ nhớ
//select * from list where RollNumber > 2
IQueryable<Student> s = from stu in students.AsQueryable()//->linq to Sql->con của ienumertor-> làm về sql
                        where stu.RollNumber > 2
                        select stu;
//select top(2) * from list where RollNumber > 2
//sẽ chạy lên sever lần nữa
s = s.Take(2);


var k = from stu in students//var là IEnumerable<> chứ không phải list nên không dung forEach đc
                         where stu.RollNumber > 2
                         select stu;
k.ToList().ForEach(Console.WriteLine);//collection

//sắp xếp
students.Order();
var obj = from stu in students
          where stu.RollNumber >2
          orderby stu.Section descending, stu.HostelNumber ascending
          select stu;
var obj3 = students.Where(stu=>stu.RollNumber>2).OrderByDescending(stu => stu.Section)//sắp xếp theo order-> xong sắp xếp theo then 
        .ThenBy(stu => stu.HostelNumber);