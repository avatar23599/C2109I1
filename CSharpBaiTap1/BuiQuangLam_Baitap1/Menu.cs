
namespace BuiQuangLam_Baitap1;
internal class Menu
{
    public static void ListMe()
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.InputEncoding = Encoding.Unicode;
        List<Entity_SinhVien> sv = new();
        Gui_SinhVien GuiSV = new();
        bool result = true;
        while (result)
        {
            Console.WriteLine("===========================MENU============================");
            Console.WriteLine("Chọn 1-> Thêm sinh viên");
            Console.WriteLine("Chọn 2-> Xóa sinh sinh viên");
            Console.WriteLine("Chọn 3-> Tìm kiếm thông tin sinh viên");
            Console.WriteLine("Chọn 4-> cập nhật lại thông tin sinh viên thông qua mã sinh viên");
            Console.WriteLine("Chọn 5-> Hiển thị thông tin của tất cả sinh viên sinh viên");
            Console.WriteLine("Chọn 6-> Sắp xếp lại danh sách sinh viên theo thứ tự giảm dần");
            Console.WriteLine("Chọn kí tự, số khác thể thoát chương trình");
            Console.WriteLine("===========================================================");
            Console.WriteLine("Mời nhập lựa chọn của bạn: ");
           
            switch (Console.ReadLine())
            {
                case "1": GuiSV.Them_SuaSV(sv,1); break;
                case "2": GuiSV.HienThi_XoaSinhVien(sv,1); break;
                case "3": GuiSV.HienThi_XoaSinhVien(sv, 2); break;
                case "4": GuiSV.Them_SuaSV(sv, 2); break;
                case "5": GuiSV.HienThiToanBoSinhVien(sv); break;
                case "6": GuiSV.SapXepToanBoSinhVien(sv); break;
                default:
                    Console.WriteLine("Cảm ơn!");
                    result= false;
                    break;
            }
        }
    }
}
