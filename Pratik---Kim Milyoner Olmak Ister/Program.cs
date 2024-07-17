int trueanswers = 0;          // Burada doğru cevapları sayacak bir değişken tanımlandı.
Console.WriteLine("Kim Milyoner Olmak İster Bilgi Yarışmasına Hoşgeldiniz!");
Console.WriteLine("1.Soru : Kızınca tüküren hayvan hangisidir ?");
Console.WriteLine("a) Lama          b) Deve");
string answer = Console.ReadLine().ToLower();   // Burada büyük küçük harf duyarlılığı olmaması için .ToLower() kullanıldı.
if ((answer != "a") && (answer != "b"))   // Burada iki şık dışında bir şık söylenmesi durumunda kodun hata vermeyip yanlış saymasını sağladık.
{
    Console.WriteLine("Olmayan bir şık söylediniz. Cevabınız yanlış sayılacak.");
}
if (answer == "a")
{
    trueanswers++;   // Burada olduğu gibi her doğru cevapta değişkenimiz 1 sayı artacak
    Console.WriteLine("DOĞRU CEVAP VERDİNİZ!");
    Console.WriteLine();  // Arayüzün güzel gözükmesi için her bildirimin altına boş bir satır eklendi.
}
else
{
    {
        Console.WriteLine("Yanlış cevap verdiniz.");
        Console.WriteLine();
    }
}
Console.WriteLine("2.Soru : Dünya'nın uydusu hangisidir ?");
Console.WriteLine("a) Güneş          b) Ay");
string answer2 = Console.ReadLine().ToLower();

if ((answer2 != "a") && (answer2 != "b"))   // Burada iki şık dışında bir şık söylenmesi durumunda kodun hata vermeyip yanlış saymasını sağladık.
{
    Console.WriteLine("Olmayan bir şık söylediniz. Cevabınız yanlış sayılacak.");
}

if (answer2 == "b")
{
    trueanswers++;
    Console.WriteLine("DOĞRU CEVAP VERDİNİZ!");
    Console.WriteLine();
}
else
{
    {
        Console.WriteLine("Yanlış cevap verdiniz.");
        Console.WriteLine();
    }
}
if(trueanswers == 0) // Burada ilk iki soruyu bilemediği durumda üçüncü soruyu görememesi için sayacımızın kontrolü yapıldı.
{
    Console.WriteLine("İki soru bilemediniz ve yarışmadan elendiniz.");
}
else
{
    Console.WriteLine("3.Soru : (5 * 2) + (8 / 2) - 2 işleminin sonucu kaçtır ?");
    Console.WriteLine("a) 7          b) 12");
    string answer3 = Console.ReadLine().ToLower();

    if ((answer3 != "a") && (answer3 != "b"))   // Burada iki şık dışında bir şık söylenmesi durumunda kodun hata vermeyip yanlış saymasını sağladık.
    {
        Console.WriteLine("Olmayan bir şık söylediniz. Cevabınız yanlış sayılacak.");
    }

    if (answer3 == "b")
    {
        trueanswers++;
        Console.WriteLine("DOĞRU CEVAP VERDİNİZ!");
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine("Yanlış cevap verdiniz.");
        Console.WriteLine();
    }
    
    if(trueanswers >= 2)
    {
        Console.WriteLine($"Doğru verdiğiniz cevap sayısı : {trueanswers} BÜYÜK ÖDÜLÜ KAZANDINIZ!");
    }
    else
    {
        Console.WriteLine($"Doğru verdiğiniz cevap sayısı : {trueanswers} Yarışmadan elendiniz.");
    }
}
