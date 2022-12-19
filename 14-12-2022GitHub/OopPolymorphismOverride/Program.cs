using OopPolymorphismOverride;

Child ch1 = new();
ch1.Display();
ch1.Show();

Parent par = new();
par.Display();


Parent pa = new Child();
pa.Display();
pa.Show();
