using System;

namespace StructKavrami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen_Class dikdortgen = new Dikdortgen_Class();
            Console.WriteLine("Class Alan Hesabı:" + dikdortgen.AlanHesapla());

            Console.WriteLine("****************************");

            Dikdortgen_Struct dikdortgen2;
            dikdortgen2.KisaKenar = 3;
            dikdortgen2.UzunKenar = 5;
            Console.WriteLine("Struct Alan Hesabı:" + dikdortgen2.AlanHesapla());


        }
    }



    class Dikdortgen_Class
    {
        public int KisaKenar;
        public int UzunKenar;

        public Dikdortgen_Class()
        {
            KisaKenar = 3;
            UzunKenar = 5;
        }

        public long AlanHesapla()
        {
            return this.KisaKenar * this.UzunKenar;
        }
    }



    struct Dikdortgen_Struct
    {
        public int KisaKenar;
        public int UzunKenar;

        public Dikdortgen_Struct(int kisaKenar, int uzunKenar)
        {
            KisaKenar = kisaKenar;
            UzunKenar = uzunKenar;
        }

        public long AlanHesapla()
        {
            return this.KisaKenar * this.UzunKenar;
        }
    }
}
