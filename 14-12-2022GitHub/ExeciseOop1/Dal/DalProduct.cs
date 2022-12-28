

using System.Security.Cryptography.X509Certificates;

namespace ExeciseOop1.Dal;
internal class DalProduct : IProduct
{
    public List<Product> ListPro { get; set; } = new();

    public void ResetMenu()
    {
        Console.Clear();
        ListPro.ForEach(Console.WriteLine);
    }
    #region Thêm và Sửa
    public void Them_SuaSP(int chucnang)
    {
        Console.WriteLine("Enter the number of product");
        var n = Validate<int>.CheckReadLine();
        for (int i = 0; i < n; i++)
        {
            Product pro = new();
        maSanPham://Mã sản phẩm
            Console.WriteLine($"product[{i + 1}]=> enter id product: ");
            string maSp = pro.ProId = Validate<string>.CheckReadLine();

            //int count = ListPro.Where(pro => pro.ProId == proId).Count();
            //if (chucnang == 2)
            //{
            //    if (count == 0)
            //    {
            //        Console.WriteLine("Mã Sản Phẩm không tồn tại");
            //        goto maSanPham;//-> trở lại nhập mã sản phẩm
            //    }

            //}
            //else
            //{
            //    if (count != 0)
            //    {
            //        Console.WriteLine("Mã Sản Phẩm đã tồn tại");
            //        goto maSanPham;//-> trở lại nhập mã sản phẩm
            //    }

            //}

            Console.WriteLine($"product[{i + 1}]=> Nhập tên sản phẩm: ");
            string name = pro.ProName = Validate<string>.CheckReadLine();

            Console.WriteLine($"product[{i + 1}]=> Nhập giá sản phẩm: ");
            double gia = pro.ProPrice = Validate<double>.CheckReadLine();

            Console.WriteLine($"product[{i + 1}]=> Nhập số lượng sản phẩm: ");
            int quantity = pro.ProQuantity = Validate<int>.CheckReadLine();

            Console.WriteLine($"product[{i + 1}]=> Nhập ngày nhập sản phẩm: ");
            DateTime date = pro.ProDate = Validate<DateTime>.CheckReadLine();

            if (chucnang == 1)//thêm sinh viên
            {
                ListPro.Add(pro);
                Console.WriteLine("Thêm thành công!");
            }
            else//sửa sinh viên
            {
                var up = (from p in ListPro
                          where p.ProId == maSp
                          select p).ToList();
                foreach (var item in up)
                {
                    item.ProName = name;
                    item.ProPrice = gia;
                    item.ProQuantity = quantity;
                    item.ProDate = date;
                }
                ResetMenu();
                Console.WriteLine("Cập nhật thành công");
            }

            
        }


    }
    #endregion

    #region Xem và Xóa thông tin sản phẩm
    public void Xem_XoaThongTinSP(int chucnang)
    {
        Console.WriteLine((chucnang == 1) ? "Mời bạn nhập Mã Sản Phẩm bạn muốn xóa: " : "Mời bạn nhập Mã Sản Phẩm bạn muốn xem thông tin: ");
        string ProId = Validate<string>.CheckReadLine();
        if (chucnang == 1)//xóa sinh viên
        {
            ListPro.RemoveAll(sv => sv.ProId == ProId);
            ResetMenu();
            Console.WriteLine("Xóa thành công! ");
        }
        else//hiển thị thông tin sinh viên thông qua maSV
        {
            ListPro.Where(sv => sv.ProId == ProId)
                    .ToList()
                    .ForEach(Console.WriteLine);
        }
    }
    #endregion

    #region 5
    public void HienThiToanBoSP()
    {
        Console.Clear();
        ListPro.ForEach(Console.WriteLine);
        Console.ReadKey();
    }
    #endregion

    #region 6
    public void SapXepToanBoSP()
    {
        Console.Clear();
        ListPro.Reverse();
        ListPro.ForEach(Console.WriteLine);
        Console.WriteLine("Sắp xếp thành công");
        Console.ReadKey();
    }
    #endregion
}
