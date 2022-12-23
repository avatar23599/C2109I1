


namespace BuiQuangLam_Baitap1;
internal class Helper_Validation
{
        public static bool checkRegex(String regex, String message)
        {
            Regex re = new Regex(regex);
            while (true)
            {
                if (re.IsMatch(message))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
}
