namespace OopEbcapsulation;
public class Plant
{
    //encapsulation thể hiện ở 2 chỗ
    //1)access modify 2)property
    //a)access modify
    private void Private()
    => 
    Console.WriteLine("Private");

    protected void Protected()//con cháu nó được sài
    =>
    Console.WriteLine("Protected");

    internal void Internal()//trong cùng project là được sài
    =>
    Console.WriteLine("Internal");
    private protected void PrivateProtected()//có chức năng của private hoặc chức năng của protected
    => 
    Console.WriteLine("PrivateProtected");

    protected internal void ProtectedInternal()
    =>
    Console.WriteLine("ProtectedInternal");

    public void Public ()
    =>
    Console.WriteLine("Public");
    
}
