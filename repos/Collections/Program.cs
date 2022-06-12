using System.Collections;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Dictionary<string, int> dict = new Dictionary<string, int>();
dict.Add("anan", 1);
dict.Add("baban", 2);










ArrayList city = new ArrayList();
List<string> list = new List<string>();
List<Cus> list2 = new List<Cus>
{
    new Cus { ID = 1, Name = "mert" },
    new Cus { ID = 2, Name = "sert" },
    new Cus { ID = 3, Name = "dert" }
};
list2.Add(new Cus { ID = 5, Name = "lalal" }) ;
var cust = new Cus { ID = 4, Name = "Yok" };
foreach (Cus c in list2)
{
    Console.WriteLine(c.ID.ToString() +  c.Name);
     
}
Console.WriteLine(list2.Count());
list2.AddRange(new Cus[2]
{
    new Cus { ID = 3, Name = "dert" },
    new Cus { ID = 3, Name = "dert" }
});

class Cus
{
    public int ID { get; set; }
    public string? Name { get; set; }
}
