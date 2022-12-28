
namespace ExeciseOop1.Menu;
internal class MainMenu
{
    public static void ListMe()
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.InputEncoding = Encoding.Unicode;
        
        DalProduct DalPro = new();
        bool result = true;
        while (result)
        {
            Console.WriteLine("===========================MENU============================");
            Console.WriteLine("Chọn 1-> Thêm Sản Phẩm");
            Console.WriteLine("Chọn 2-> Xóa Sản Phẩm");
            Console.WriteLine("Chọn 3-> Tìm kiếm thông tin Sản Phẩm");
            Console.WriteLine("Chọn 4-> cập nhật lại thông tin Sản Phẩm thông qua mã Sản Phẩm");
            Console.WriteLine("Chọn 5-> Hiển thị thông tin của tất cả Sản Phẩm");
            Console.WriteLine("Chọn 6-> Sắp xếp lại danh sách Sản Phẩm theo thứ tự giảm dần");
            Console.WriteLine("Chọn kí tự, số khác thể thoát chương trình");
            Console.WriteLine("===========================================================");
            Console.WriteLine("Mời nhập lựa chọn của bạn: ");

            switch (Console.ReadLine())
            {
                case "1": DalPro.Them_SuaSP(1); break;
                case "2": DalPro.Xem_XoaThongTinSP(1); break;
                case "3": DalPro.Xem_XoaThongTinSP(2); break;
                case "4": DalPro.Them_SuaSP(2); break;
                case "5": DalPro.HienThiToanBoSP(); break;
                case "6": DalPro.SapXepToanBoSP(); break;
                default:
                    Console.WriteLine("Cảm ơn!");
                    result = false;
                    break;
            }
        }
    }
}
