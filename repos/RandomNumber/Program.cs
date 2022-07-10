a:
Random rnd = new Random();
int rndNumber = rnd.Next(1, 101);
sbyte input = 0;
sbyte retry = 0;


Console.WriteLine("\n\nProgramın seçtiği sayı: " + rndNumber);
Console.WriteLine("----------------------------------------");
Console.WriteLine("Yeni OYUN başlıyor\n\n");
Console.WriteLine("1 ile 100 arasında bir sayı giriniz:\n\n");


while (input != rndNumber)
{


    sbyte.TryParse(Console.ReadLine(), out input);

    if (input < 1 || input > 100)
    {
        Console.WriteLine("Sadece 1 ile 100 arasında sayı girebilirsiniz.\n\n");
        break;
    }
    if (input == rndNumber)
    {
        retry++;
        Console.WriteLine("Tebrikler " + retry + ". denemede bildiniz!");
        break;
    }
    else if (input < rndNumber)
    {
        retry++;
        Console.WriteLine("Yukarı");
    }
    else if (input > rndNumber)
    {
        retry++;
        Console.WriteLine("Aşağı");
    }

}


b:
Console.WriteLine("Tekrar oynamak için 'e' tuşu, çıkmak için 'q' tuşuna; sonrasında enter'a basın.\n\n");
string reGame = Console.ReadLine();


if (reGame == "e")
{
    goto a;
}
else if (reGame == "q")
{
    Console.WriteLine("Çıkış başarılı");
}
else
{
    Console.WriteLine("Yanlış komut girildi, menüye dönüyoruz.\n\n");
    goto b;
}