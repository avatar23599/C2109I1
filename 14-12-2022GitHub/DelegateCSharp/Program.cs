using DelegateCSharp;
//delegate thường dùng để làm gì? ,dùng ở đâu?
//viết bên ngoài class
//Mathems ma = new();

//ma.Add(10, 5);

//Mathems.Div(10, 5);//Toàn bộ đều sài được

//new Mathems().Multi(10, 5);//dung 1 lần
Abc dele = new Mathems().Multi;
dele += new Mathems().Sub;//+= là phép gán 
dele(10, 5);//có tên khác là safe thread: luồng an toàn-> sử dụng cpu nhiều luồng
