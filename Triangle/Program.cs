using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç adet çokgen gireceksiniz?");
            int RepeatValue;

            RepeatValue = Convert.ToInt32(Console.ReadLine());
            for (int loop = 0; loop < RepeatValue; loop++)
            {
                Console.WriteLine("Üçgeninizin kenar sayısını giriniz : ");
                int EdgeValue;
                EdgeValue = Convert.ToInt32(Console.ReadLine());
                int AverageAngle = 180 - (360 / EdgeValue);
                int TotalAngle = EdgeValue * AverageAngle;
                Console.WriteLine("Üçgeninizin bi köşesinin ortalam açısı : " + AverageAngle);
                Console.WriteLine("Üçgeninizin iç açıları toplamı : " + TotalAngle);
                Console.WriteLine("------------------- üçgen Tamamlandı -------------------") ;

            }




        }
    }
}
