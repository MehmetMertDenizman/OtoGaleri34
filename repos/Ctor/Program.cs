using Ctor;
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//CusManager cusManager = new CusManager(15);
//cusManager.Add();
//cusManager.List();
//Console.WriteLine("HP: " + cusManager.Hp());
//Product product = new Product { ID = 1, Name = "ANAN" };
//Product product2 = new Product(2, "Laptop");
EmpManager empManager = new EmpManager(new FileLogger());
empManager.Add();
EmpManager  empManagerr;
EmpManager empManager2 = new EmpManager(new DBLogger);


int num1 = 10;
int num2 = 20;
num2 = num1;
num1 = 30;
Console.WriteLine(num1);


