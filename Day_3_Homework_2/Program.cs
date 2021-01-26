using System;

namespace Day_3_Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Homework : ref ve out anahtar kelimelerini bilmeyen birine nasıl anlatırdınız?
            // Ref keyword'ü aslında bir çeşit değer döndürme işlemidir. Yani return kullanmadan. Örneğin:

            int x = 10; // x'in başlangıç değeri 10
            var result = Add(x); // result değişkenine geri dönen değeri atadık
            Console.WriteLine("Result is {0}", result);
            Console.WriteLine("x variable is {0}\n", x); // burada görüldüğü gibi x değişkeni değişmedi çünkü değer tipler üzerinden işlem yaptık. Şimdi ref keyword'ünü kullanalım

            // - Ref Keyword -
            
            var result2 = AddRef(ref x);
            Console.WriteLine("Result is {0}", result);
            Console.WriteLine("x variable is {0}\n", x);
            // burada görüldüğü gibi x değişkeni başka bir fonksiyonda değişmesine rağmen Main() içerisindede değişti.
            // Bunun nedeni ise şudur: Biz 'ref' keyword'ünü kullanmadığımız zaman program parametre olarak x'in adresini değil değerini gönderir. Yani fonksiyon içerisinde değeri kullanılır.
            // Adresi üzerinden değişikliğe uğramadığı için Main() içerisinde değeri aynı kalır.
            // Yani Add() fonksiyonunda 'x' adında yeni bir değişken oluşturulur ve ona Main() içerisindeki x'in değeri atanır.
            // Ancak AddRef() fonksiyonunda 'int x' in parametre tanımnın önüne 'ref' keyword'ünü geitrdik ve artık AddRef() fonksiyonu x'in değerini değil x'in referansını kullanır.
            // Yani fonksiyon içerisinde yeni bir x değişkeni kullanmaz da Main()'deki 'x' değişkeninin adını AddRef'de görüldüğü gibi x yapar. 
            // Burada önemli bir nokta daha var. 'AddRef(ref x);' şeklinde fonksiyonu çağırırken de 'x' in önüne 'ref' keyword'ünü geitrmeliyiz
            // Şimdi birde 'out' keyword'üne bakalım.

            // - Out Keyword -

            int y;
            var result3 = AddOut(out y);
            Console.WriteLine("Result is {0}", result);
            Console.WriteLine("y variable is {0}", y);
            // Out keyword'ü 'ref' ile aynıdır ancak tek farkı vardır. O da ref keyword'ü ile kullanılacak değişkene kullanılmadan önce mutlaka değer atanmalıdır.
            // Ancak out'da böyle bir şey söz konusu değildir. Out keyword'ünde çöp değerli değişken kullanılabilir ancak fonksiyon içerisinde kullanılmadan önce mutlaka değer atanmalıdır 
            // aksi takdirde hata verecektir. Bunu görmek için AddOut() fonksiyonu içindeki 'y = 5;' satırını comment'leyin ve çıkacak hatayı inceleyin.



            Console.ReadLine();
        }

        static int Add(int x)
        {
            var result = x += 5;
            return result;
        }

        static int AddRef(ref int x)
        {
            var result = x += 5;
            return result;
        }

        static int AddOut(out int y)
        {
            y = 10; // Lütfen bir de bu satırı yorum satırına çavirin ve çıkan hatayı inceleyin
            var result = y += 5;
            return result;
        }
    }
}
