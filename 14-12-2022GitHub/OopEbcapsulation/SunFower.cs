
namespace OopEbcapsulation;
internal class SunFower:Plant
{
    static void Main(string[] args)
    {
        Plant sf = new();
        sf.Internal();
        sf.ProtectedInternal();
        sf.Public();
       
        SunFower sf2 = new();
        sf2.Internal();
        sf2.ProtectedInternal();
        sf2.Public();   
        sf2.PrivateProtected();
        sf2.Protected();

    }
}
