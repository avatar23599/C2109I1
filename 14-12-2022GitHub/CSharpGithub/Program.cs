//format code Ctrl K +D
double a = 0.1;
double b = 0.2;
Console.WriteLine(a+ b ==0.3?"true":"false");
//=>false

decimal c = 0.1M;
decimal d = 0.2M;
Console.WriteLine(c + d == 0.3M ? "true" : "false");
//=>true

//? Nullable value type
string? fullname = null;
//int i = null;
//CSharp cũ
//Nullable<int> i = null;
//CSharp mới
bool? check = null;

//int lenght = fullname != null ? fullname.Length : 0; 

//int? lenght = fullname is not null  ? fullname.Length : null;

//var r = 10;
//if(r is 10)
//{

//}

//null-conditional operator ?
//? thứ 2 tương tự !=, fullname mà khác null thì nó sẽ trả về vế sau.
//int? lenght = fullname?.Length;

//??-> null-coalescing operator
//tương tự dấu ==, fullname = null trả về vế sau
int? lenght = fullname?.Length??0;
