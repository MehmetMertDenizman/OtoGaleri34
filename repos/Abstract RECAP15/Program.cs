// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



Interface2.CusControl cusControl = new Interface2.CusControl();
cusControl.customerAdd(new Interface2.Sql());
cusControl.customerAdd(new Interface2.MySql());
cusControl.customerAdd(new Interface2.CusControl());

cusControl.add();

Interface2.AbstractAlt alt = new Interface2.AbstractAlt();
alt.method1();
alt.method2();