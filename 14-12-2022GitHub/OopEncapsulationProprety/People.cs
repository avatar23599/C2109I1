
namespace OopEncapsulationProprety;
internal class People
{
    //các field phải là private 
    string fullname;
    //thuộc tính address->dùng trên máy tính, laptop 
    public string Address {private get; set; }// phải thêm private mới thức hiện được
    //public string Address {  set; }-> chỉ được get chứ không được set,
    public int Age { get; set; }
    

    //property theo C# cũ->phương thức dùng trên điện thoại
    public string Fullname 
    { 

        set => fullname = value; 
        get => fullname;
    
    }

    public void ShowProperty()
    {
        Console.WriteLine($"{nameof(Address)} = {Address}");
        Console.WriteLine($"{nameof(fullname)} = {fullname}");
    }
}
