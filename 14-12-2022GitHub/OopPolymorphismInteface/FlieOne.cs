using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPolymorphismInteface;
internal class FlieOne : IBinaryFile, ITextFIle
{
    public void ReadFile()
    =>
    Console.WriteLine("ReadFile");
    

    public void WriteBinaryFile()
    =>
    Console.WriteLine("WriteBinaryFile");
    

    public void WriteTextFile()
    =>
    Console.WriteLine("WriteTextFile");
    
}
