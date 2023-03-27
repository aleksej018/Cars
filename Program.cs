using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Podaci
    {
        private string boja;
        private string karoserija;
        private int godProiz;
        
        public Podaci(string boja, string karoserija, int godProiz)
        {
            this.boja = boja;
            this.karoserija = karoserija;
            this.godProiz = godProiz;
        }
        public int godiste
        {
            get { return godProiz; }
            set 
            {
                if (value >= 1990 && value <= 2020)
                    godProiz = value;
                else
                    Console.WriteLine("Greska!");
            }
        }
        public void ispis()
        {
            Console.WriteLine("Boja vozila: " + boja);
            Console.WriteLine("Karoserija: " + karoserija);
            Console.WriteLine("Godina proizvodnje: " + godProiz);
            if (godProiz > 2005)
                Console.WriteLine("Za vase vozilo trenutno nema popusta.");
            else
                Console.WriteLine("Moguci popust na radove za vase vozilo je 10%.");
        }
    }

    class Servis
    {
        public bool dubinskoEnterijer
        { get; set; }
        public bool farovi
        { get; set; }
        public bool boja
        { get; set; }
        public bool maliSer
        { get; set; }
        public Servis(bool dubinskoEnterijer, bool farovi, bool boja, bool maliSer)
        {
            this.dubinskoEnterijer = dubinskoEnterijer;
            this.farovi=farovi;
            this.boja=boja;
            this.maliSer = maliSer;
        }
        public void ispis()
        {
            Console.WriteLine("Dubinsko pranje enterijera: "+dubinskoEnterijer);
            Console.WriteLine("Poliranje farova: " + farovi);
            Console.WriteLine("Poliranje boje automobila: " + boja);
            Console.WriteLine("Mali servis: " + maliSer);
        }
    }
    class Automobil : Podaci
    {
        private Servis ser;
        private string proiz;
        private string model;

        public Automobil(string proiz, string model, string boja, string karoserija, int godProiz) : base(boja, karoserija, godProiz)
        {
            this.proiz = proiz;
            this.model = model;
        }
        public void dodajOpremu(Servis x)
        {
            ser = x;
        }
        public new void ispis()
        {
            Console.WriteLine("Proizvodjac: " + proiz);
            Console.WriteLine("Model vozila: " + model);
            base.ispis();
            Console.WriteLine();
            Console.WriteLine("Potrebno uraditi na vozilu: ");
            ser.ispis();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Servis o1 = new Servis(true, false, true, true);
            Automobil a1 = new Automobil("Peugeot","306", "Plava", "Kupe", 2001);
            a1.dodajOpremu(o1);
            Console.WriteLine("Vas automobil:");
            a1.ispis();
            
        }
    }
}
