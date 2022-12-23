namespace BuiQuangLam_Baitap1;
internal class Gui_SinhVien
{
    public void ResetMenu(List<Entity_SinhVien> sv) {
        Console.Clear();
        sv.ForEach(Console.WriteLine);
    }



    #region 1,4
    public void Them_SuaSV(List<Entity_SinhVien> sv, int chucnang)
    {
        string maSV;
        string tenSV;
        string gioiTinh;
        string ngaySinh;
        Entity_SinhVien EnSv = new();

        while (true)
        {
        maSinhVien:
            Console.WriteLine("Mời bạn nhập Mã Sinh Viên: ");
            maSV = Console.ReadLine();
            if (Helper_Validation.checkRegex(Helper_RegexConst.NUM, maSV) == false) goto maSinhVien;
            int count = sv.Where(sv => sv.MaSV == int.Parse(maSV)).Count();
            if (chucnang == 2)
            {
                if (count == 0)
                {
                    Console.WriteLine("Mã Sinh Viên không tồn tại");
                    goto maSinhVien;
                }

            }
            else
            {
                if (count != 0)
                {
                    Console.WriteLine("Mã Sinh Viên đã tồn tại");
                    goto maSinhVien;
                }

            }

        //----------------------------------------------------

        tenSinhVien:
            Console.WriteLine("Mời bạn nhập Tên Sinh Viên: ");
            tenSV = Console.ReadLine();
            if (Helper_Validation.checkRegex(Helper_RegexConst.CHARS, tenSV) == false) goto tenSinhVien;



            gioiTinhSinhVien:
            Console.WriteLine("Mời bạn nhập giới tính Sinh Viên(true là Nam, false là Nữ): ");
            gioiTinh = Console.ReadLine().ToLower();
            if (Helper_Validation.checkRegex(Helper_RegexConst.STATUS, gioiTinh) == false) goto gioiTinhSinhVien;



            ngaySinh:
            Console.WriteLine("Mời bạn nhập ngày sinh (mm/dd/yyyy): ");
            ngaySinh = Console.ReadLine();
            if (Helper_Validation.checkRegex(Helper_RegexConst.DATE, ngaySinh) == false) goto ngaySinh;
            break;

        }
        if (chucnang == 1)//thêm sinh viên
        {
            sv.Add(new Entity_SinhVien()
            {
                MaSV = int.Parse(maSV),
                TenSV = tenSV,
                GioiTinh = bool.Parse(gioiTinh),
                NgaySinh = DateTime.Parse(ngaySinh)
            });
            Console.WriteLine("Thêm thành công!");
        }
        else//sửa sinh viên
        {
           var up = (from p in sv
                  where p.MaSV == int.Parse(maSV)
                  select p).ToList();
            foreach (var i in up)
            {
                i.TenSV = tenSV;
                i.GioiTinh = bool.Parse(gioiTinh);
                i.NgaySinh = DateTime.Parse(ngaySinh);
            }
            ResetMenu(sv);
            Console.WriteLine("Cập nhật thành công");
        }
    }
    #endregion

    #region 2,3
   public void HienThi_XoaSinhVien(List<Entity_SinhVien> sv, int chucnang)
    {
        Console.Clear();
        sv.ForEach(Console.WriteLine);
        string maSV;
        while (true)
        {
        maSinhVien:
            Console.WriteLine((chucnang==1)?"Mời bạn nhập Mã Sinh Viên bạn muốn xóa: ": "Mời bạn nhập Mã Sinh Viên bạn muốn xem thông tin: ");
            maSV = Console.ReadLine();
            if (Helper_Validation.checkRegex(Helper_RegexConst.NUM, maSV) == false) goto maSinhVien;
            int count = sv.Where(sv => sv.MaSV == int.Parse(maSV)).Count();
            if (count == 0) { 
                Console.WriteLine("Mã Sinh Viên không tồn tại") ;
                goto maSinhVien;
            } 
            
            break;
        }
        if (chucnang == 1)//xóa sinh viên
        {
            sv.RemoveAll(sv => sv.MaSV == int.Parse(maSV));
            ResetMenu(sv);
            Console.WriteLine("Xóa thành công! ");
        }
        else//hiển thị thông tin sinh viên thông qua maSV
        {
            sv.Where(sv => sv.MaSV == int.Parse(maSV))
                    .ToList()
                    .ForEach(Console.WriteLine);
        }
    }
    #endregion

    #region 5
    public void HienThiToanBoSinhVien(List<Entity_SinhVien> sv)
    {
        Console.Clear();
        sv.ForEach(Console.WriteLine);
        Console.ReadKey();
    }
    #endregion

    #region 6
    public void SapXepToanBoSinhVien(List<Entity_SinhVien> sv)
        {
            Console.Clear();
            sv.Reverse();
            sv.ForEach(Console.WriteLine);
            Console.WriteLine("Sắp xếp thành công");
            Console.ReadKey();
        }
    #endregion
    

}
