using ExeciseOop1.Entity;
using ExeciseOop1.Helper;
using ExeciseOop1.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeciseOop1.Dal;
internal class DalProduct : IProduct
{
    public List<Product> ListPro { get; set; } = new ();

    public void AddProduct()
    {
        Console.WriteLine("Enter the number of product");
        var n = Validate<int>.CheckReadLine();
        for (int i = 0; i < n; i++)
        {
            Product pro = new();
            Console.WriteLine($"product[{i+1}]=> enter id product: ");
            pro.ProId = Validate<string>.CheckReadLine();

            ListPro.Add(pro);
        }
    }
    

}
