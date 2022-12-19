//using OopPolymorphismInteface;

//FlieOne fi = new();
//fi.WriteTextFile();
//fi.WriteBinaryFile();
//fi.ReadFile();

//((IBinaryFile)fi).ShowInfo();
//(fi as IBinaryFile).ShowInfo();
using OopPolymorphismInteface;
//Nếu 1 class kế thừa nhiều inteface thì nên tạo đối tượng từ class
FileTwo f = new();
f.WriteTextFile();
f.WriteBinaryFile();
(f as ITextFIle).ReadFile();
(f as IBinaryFile).ReadFile();
//Nếu 1 inteface kế thừa nhiều class thì nên tạo đối tượng từ inteface
ITextFIle it = new FlieOne();
it.ReadFile();
it = new FileTwo();
it.ReadFile();