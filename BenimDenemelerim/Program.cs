using System;

namespace BenimDenemelerim
{
   public class Program
    {
       public static void Main(string[] args)
        {
            Sorunun 2 kere tekrarlanmasını sağlayan for döngüsü.
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Lütfen yaşınızı giriniz:");  //input metni
                int yas = Convert.ToInt32(Console.ReadLine());  //inputu çeker
                if (yas >= 18) //bara giriş koşulunu kontrol eder.
                {
                    Console.WriteLine("Bara girebilirsiniz"); // eğer 18 yaşında büyükse bara girebilir
                }

                else //aksi durum
                {
                    int HaveYear;
                    HaveYear = 18 - yas; //Bara girebilmek için kaç yılının bulunduğunu hesaplayan matematik işlemi.
                    Console.WriteLine("Bara girmekiçin" + " " + HaveYear + " " + "yılınız var"); //output
                }
            }

        }
    }
}




