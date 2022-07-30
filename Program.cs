using System;

namespace Array_sınıfı_metodları 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Atama ve işlemli atama
            int x = 3;
            int y = 3;
            y = y+2;

            Console.WriteLine(y);
            y = y+2;
            Console.WriteLine(y);
            y/=1;
            Console.WriteLine(y);
            x*=2;
            Console.WriteLine(x);

            // Mantıksal operatörler

            bool isSucces = true;
            bool isCompleted = false;

            if(isSucces && isCompleted)
            Console.WriteLine("Perfect");

            if(isSucces || isCompleted)
            Console.WriteLine("Great");

            if(isSucces && !isCompleted)
            Console.WriteLine("Fine");

            // İlişkisel Operatörler

            int a = 3;
            int b = 3;

            bool sonuc = a<b;

            Console.WriteLine(sonuc);
            sonuc = a>b;
            Console.WriteLine(sonuc);
            sonuc = a>=b;
            Console.WriteLine(sonuc);
            sonuc = a<=b;
            Console.WriteLine(sonuc);
            sonuc = a>b;
            Console.WriteLine(sonuc);
            sonuc = a==b;
            Console.WriteLine(sonuc);
            sonuc = a!=b;

            // +, *, /, -

            int sayi1 = 10;
            int sayi2 = 4;

            int sonuc1 = sayi1/sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1*sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1/sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 += 1;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1-sayi2;
            Console.WriteLine(sonuc1);
        
            int sonuc2 = 20%4;
            Console.WriteLine(sonuc2);
        }
    }
}