using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPolymorphismInteface;
internal class FileTwo:IBinaryFile,ITextFIle
{
    void IBinaryFile.ReadFile()
    =>
    Console.WriteLine("ReadBinaryFile");//không có bổ từ public

    void ITextFIle.ReadFile()
    =>
    Console.WriteLine("ReadTextFile");
    public void WriteBinaryFile()
    =>
    Console.WriteLine("WriteBinaryFile");


    public void WriteTextFile()
    =>
    Console.WriteLine("WriteTextFile");
}
