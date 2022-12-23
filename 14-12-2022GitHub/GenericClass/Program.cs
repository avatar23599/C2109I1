using GenericClass;

ClassOne<int> one = new();
one.Field= 1;
one.Show();

ClassTwo<string,int> two = new();
two.Field1 = "NullLy";
two.Field2= 2;
one.Show();

ClassTwo<int, double> two2 = new();
two2.Field1 = 10;
two2.Field2 = 10.5;
one.Show();