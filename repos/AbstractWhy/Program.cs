// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
AbstractWhy.January january = new AbstractWhy.January();
Console.WriteLine(  january.WhatHour() );
Console.WriteLine(january.WhichMonth());
Console.WriteLine(january.HowManyDays());
AbstractWhy.February february = new AbstractWhy.February();
Console.WriteLine(february.WhatHour());
Console.WriteLine(february.WhichMonth());
Console.WriteLine(february.HowManyDays());
AbstractWhy.EnumDays dayfri = AbstractWhy.EnumDays.friday;
if (dayfri == AbstractWhy.EnumDays.friday)
{
    Console.WriteLine("Friday");
}
else if (dayfri == AbstractWhy.EnumDays.thursday)
{
    Console.WriteLine("Thursday");
}

AbstractWhy.Customer customer = new AbstractWhy.Customer(3, "Mert", "ANANANNANA");
customer.ID = 1;
customer.Email = "anan@gmail.com";
customer.SurName = "Denizman";
Console.WriteLine(customer.ID);
Console.WriteLine(customer.SurName);
Console.WriteLine(customer.CustomerName);
AbstractWhy.CustomerState regState = customer.customerAdd(customer);

if (regState == AbstractWhy.CustomerState.regOK)
{
    Console.WriteLine("Başarılı eklendi");
    }

