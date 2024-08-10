
//dizi oluşturuldu
int[] dizi = new int[10];

//i her arttığında dizi 1 büyüyor
for (int i = 0; i < dizi.Length; i++)
{
    dizi[i] = i + 1;
}
//dizi de bulunan elemanlar yazdırıldı
foreach (int sayi in dizi)
{
    Console.WriteLine(sayi);
}
//kullanıcıdan 11.sayi alındı, dizinin boyutu güncellendi
Console.WriteLine("Yeni sayi giriniz: ");
int yeniSayi = Convert.ToInt32(Console.ReadLine());
Array.Resize(ref dizi, dizi.Length +1);
dizi[dizi.Length - 1] = yeniSayi;

//dizi büyükten kücüge siralandi
Array.Sort(dizi);
Array.Reverse(dizi);
Console.WriteLine("Büyükten küçüğe sıralanan dizi: ");
foreach (int i in dizi)
{

Console.WriteLine(i); }