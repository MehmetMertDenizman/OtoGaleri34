int s = 7;
int result = fak(s);

static int fak(int sayi)
{
    if (sayi == 0 & sayi == 1)
    {
        return 1;
    }
    else {
        return sayi * (sayi - 1);
            }

}

Console.WriteLine($"{0}sayısının faktöriyeli: {1}", result, fak(s));


















//double page = 1400;
//double result = 12;

//for(double i = 1; i <7 ; i++)
//{

//    result = result + result + 9;

//}
//Console.WriteLine(page / result);
//Console.WriteLine(result);