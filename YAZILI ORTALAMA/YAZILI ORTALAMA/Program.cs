double s1, s2, ort;

Console.Write("1. Sınav notunu giriniz: ");
s1 = Convert.ToInt32(Console.ReadLine());

Console.Write("2. Sınav notunu giriniz: ");
s2 = Convert.ToInt32(Console.ReadLine());

ort = (s1 + s2) / 2;

Console.WriteLine("-------------------------------------------");

if ( ort >= 50 )
{
    Console.WriteLine("Ortalama puanınız " + ort + ". Öğrenci geçti.");
}

else
{
    Console.WriteLine("Ortalama puanınız " + ort + ". Öğrenci kaldı.");
}