
using ArgumentAndParams;
//pure oop
//ArgumentClass argu = new ArgumentClass();

//dung var
//var argu = new ArgumentClass();


//taget-type
ArgumentClass argu = new();

//named argument(đối số), 
argu.Display(4, 5, 6);
argu.Display(a: 4, b: 5, c: 6);
argu.Display(a: 4, 5, 6);
argu.Display(b: 4, a: 5, c: 6);

//optional argument
argu.Show(10);//a = 10
argu.Show();//a = 0, b = 0, c = 0;

argu.Show(10, c: 10);//a = 10, c = 10, b = 0;


argu.SumParam(1,2,3,4);