
using OopEbcapsulation;

namespace OopEbcapsulationCont;
internal class Weed : Plant

{
    static void Main(string[] args)
    {
        Weed w = new();
        w.Public();
        w.Protected();
        w.ProtectedInternal();//hoặc là pro hoặc intenal
        //w.PrivateProtected();//con nuôi không được kế thừa

    }
}
