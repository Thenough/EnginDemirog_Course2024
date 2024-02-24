using Business.Concrete;
using Entities.Concrete;

Vatandas vatandas1 = new Vatandas();
SelamVer("Murat");
SelamVer(isim : "Meltem");
SelamVer();
int sonuc = Topla(3,99);
Topla();


static void SelamVer(string isim = "isimsiz")
{
    Console.WriteLine("Merhaba " + isim);
}

string[] ogrenciler = new string[3];
ogrenciler[0] = "Murat";
ogrenciler[1] = "Kerem";
ogrenciler[2] = "Melltem";

ogrenciler = new string[4];
ogrenciler[3] = "Serhat";

for (int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);
}

string[] sehirler1 = { "ankara", "istanbul", "izmir" };
string[] sehirler2 = { "bursa", "antalya", "tokat" };

sehirler2 = sehirler1;
sehirler1[0] = "adana";
Console.WriteLine(sehirler2[0]);

Person person1 = new Person();
person1.FirstName = "Murat";
person1.LastName = "Can";
person1.NationalIdendity = 24736788882;
person1.DateOfBirthYear = 1994;

Person person2 = new Person();
person2.FirstName = "Meltem";

PttManager pttManager = new PttManager(new PersonManager());

pttManager.GiveMask(person1);

foreach (var sehir in sehirler1)
{
    Console.WriteLine(sehir);
}

List<string> yeniSehirler1 = new List<string> {"Ankara 1","İstanbul 1","İzmir 1" };
yeniSehirler1.Add("Adana 1");
foreach (var sehir1 in yeniSehirler1)
{
    Console.WriteLine(sehir1);
}
static int Topla(int sayi1 = 2, int sayi2 = 2)
{
    int sonuc = sayi1+sayi2;
    Console.WriteLine("Toplam "+sonuc);
    return sonuc;
}
static void Degiskenler()
{
    string mesaj = "Merhaba";
    double tutar = 100000;
    int sayi = 100;
    bool girisYapmismi = false;

    string ad = "Murat";
    string soyad = "Can";
    int dogumYili = 1994;
    long tcNo = 24587227491;
}
public class Vatandas
{
   public string Ad { get; set; }
    public string Soyad { get; set; }
    public int DogumYili { get; set; }
    public long TcNo { get; set; }
}
