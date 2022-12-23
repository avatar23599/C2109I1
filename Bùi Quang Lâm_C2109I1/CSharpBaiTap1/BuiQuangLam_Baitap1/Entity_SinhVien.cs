
namespace BuiQuangLam_Baitap1;
internal class Entity_SinhVien
{
    public int MaSV { get; set; }
    public string TenSV { get; set; }
    public bool GioiTinh { get; set; }
    public DateTime NgaySinh { get; set; }

    public override string ToString()
    {
        return $"SinhVien = {{{nameof(MaSV)}={MaSV.ToString()}, {nameof(TenSV)}={TenSV}, {nameof(GioiTinh)}={(GioiTinh.ToString()=="True"?"Nam":"Nữ")}, {nameof(NgaySinh)}={NgaySinh.ToString("dd/MM/yyyy")}}}";
    }
}
