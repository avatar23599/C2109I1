
namespace BuiQuangLam_Baitap1;
internal class Helper_RegexConst
{
    public static string NUM = "^[0-9]+$";

    public static string CHARS = @"^[a-zA-Z]+$";

    public static string STATUS = "^true$|^false$";

    public static string DATE = @"\b(?<month>\d{1,2})/(?<day>\d{1,2})/(?<year>\d{2,4})\b";

}
