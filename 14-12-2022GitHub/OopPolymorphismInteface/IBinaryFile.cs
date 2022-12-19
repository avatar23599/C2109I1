using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPolymorphismInteface;
internal interface IBinaryFile
{
    //Inteface bắt đầu bằng I hoa
    //Có kiểu trả về và tên của phương thức
    //Muốn áp đặt inteface
    void WriteBinaryFile();
    void ReadFile();

    //Phương thức mặc định của Inteface
    void ShowInfo()
    =>
    Console.WriteLine("This is binary file");
    
}
