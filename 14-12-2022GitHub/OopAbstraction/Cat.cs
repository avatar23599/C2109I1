namespace OopAbstraction;
internal abstract class Cat:Animal//kế thừa cha vì cha có abstract nên con phải có abstract
    //
{
    private bool gender;

    public void ShowInfoCat()
    {
        Console.WriteLine($"{nameof(gender)} = {gender}");
    }
}
