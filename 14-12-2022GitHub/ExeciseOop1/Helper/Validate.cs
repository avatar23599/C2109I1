using ExeciseOop1.ExtensionMethod;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ExeciseOop1.Helper;
internal class Validate <T>
{
    public static T CheckReadLine()
    {
        var TypeCode = Type.GetTypeCode(typeof(T));
        object obj = new();
        bool flag;
        do
        {
            flag = true;
            try
            {
                var str = Console.ReadLine();
                if (string.IsNullOrEmpty(str))//str is {}-> là null
                {
                    throw new Exception("error, null or empty");
                }

                switch (TypeCode)
                {
                    case TypeCode.String: obj = str; break;
                    case TypeCode.Int32 :
                        obj = Convert.ToInt32(str);
                        if ((int)obj < 0) throw new Exception("Values must be greater than zero");
                        break;
                    case TypeCode.Double: 
                        obj = Convert.ToDouble(str);
                        if ((double)obj < 0) throw new Exception("Values must be greater than zero");
                        break;
                    case TypeCode.DateTime:
                        var date = DateTime.TryParseExact(str, new[] { "d/M/yyyy", "d-M-yyyy" }, new CultureInfo("vi-VN"), DateTimeStyles.None, out var t )? t: throw new Exception("datetime wrong") ;
                        obj = date.Add(DateTime.Now.TimeOfDay);
                        break;
                    case TypeCode.Char:
                        obj = Convert.ToChar(str.ToLower());
                        if (!obj.In('y', 'n')) throw new Exception("error, must be y or n");
                       break;
                    default: obj = null ; break;
                }
            }
            catch (Exception e)
            {

                Console.WriteLine($"{e.GetType}:{ e.Message}, please enter again");
                flag = false;
            }
        } while (!flag);
        return (T)obj;

    }
}
