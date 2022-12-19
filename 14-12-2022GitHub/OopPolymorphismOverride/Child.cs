using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPolymorphismOverride;
internal class Child:Parent
{
    public override void Display()
    {
        //Override dung đề ghỉ đè lên phương thức giống như việc cập nhật lại đồng dola, sữa chữa
        base.Display();//->gọi lại phương thức của thằng cha
        Console.WriteLine("Child Display");
    }
    public new void Show()
    =>
    Console.WriteLine("Child Show");
    
}
