// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdırma

int sayac = int.Parse(Console.ReadLine());

for (int i = 1; i <= sayac; i++)
{
    if (i%2 == 1)
    {
        Console.WriteLine(i);
        
    }
    
}

//Console.ReadLine();


int toplamTek=0, toplamCift = 0;

for (int a = 1; a <= 1000; a++)
{
    if (a % 2 == 0)
    {
        toplamCift += a;
    }else {
        toplamTek += a;
    }
}

Console.WriteLine("Teklerin Toplamı = " + toplamTek);

Console.WriteLine("Çiftlerin Toplamı = " + toplamCift);

Console.ReadLine();


for (int i = 1; i < 10; i++)
{
    if (i == 4)
    {
        break;
    }
    Console.WriteLine(i);
}
Console.ReadLine();



for (int i = 1; i < 10; i++)
{
    if (i == 4)
    {
        continue;
    }
    Console.WriteLine(i);
}
Console.ReadLine();