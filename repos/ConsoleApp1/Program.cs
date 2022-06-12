// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int a = 5;
int b = 6; int c = 7; int d = 8; int e = 9; int f = 10; int g = 11;
if (a + b + c + d + e + f + g != 12) Console.WriteLine("vay eşit değil");
var listo = new List<string> { "<anan>", "baban", "ben"};
listo.Add("11");
listo.Sort();
foreach (var item in listo) Console.Write("Hello " + item + ", "); 


var index = listo.IndexOf("ane");

Console.WriteLine(index);

var fibo = new List<int> { };
int it = 0;

while (fibo.Count <= 20)

{
    it++;
    fibo.Add(it);
     
    
}
int num1 = 0;
int num2 = 1;
int sum = 0;
Console.WriteLine(num1);
while (sum < 40000)
{
    sum = num1 + num2;
    num1 = num2;
    num2 = sum;
    Console.WriteLine(sum);
    
}

    Console.ReadKey();