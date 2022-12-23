using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass;
internal class ClassTwo<M,N>
{
    public M Field1 { get; set; }

    public N Field2 { get; set; }
    public void Show() => Console.WriteLine($"{Field1}, {Field2}");

}
