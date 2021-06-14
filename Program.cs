/*
Wzorzec projektowy ABSTRACT FACTORY
*/
using System;

namespace KonfiguratorSamochodu
{
    // Fabryka elementów które będą kongigurowane przez klienta
    interface ElementyKonfiguracyjne
    {
        INadwozie wybierzNadwozie();
        ISilnik wybierzSilnik();
        ISkrzyniaBiegów wybierzSkrzynieBiegów();
        IFotele wybierzFotele();
        IKolor wyberzKolor();
        IKolorWnętrza wybierzKolorWnętrza();
        INagłośnienie wybierzNagłośnienie();
        IZegary wybierzZegary();
    }
    //////////////////////////////////////////////////////////////////////////////////////
    // Tworzenie interfejsów głównych oraz klas, które implementują metody utwotzone w interfejsie 
    // Umożliwa to stworzenie np. różego typu nadwozi do interfejsu nadwozie
    // Będzie to pomocne przy konfigurowaniu samochodu
    // Interfejs Nadwozie i klasy które dziedziczą po interfejsie nadwozie
    interface INadwozie
    {
        //metoda typu interfejsu INadwozie dzięki której możliwe będzie wybranie konkretnego typu 
        //nadwozia
        INadwozie dodajNadwozie();

        //metoda dzięki której możlwe będzie stworzenie nazwy
        string podajNazwę();
    }

    //Klasa konkertnego nadwozia dziedzicząca po interfejsie INadwozie 
    //Klasa posiada:
    //-dwie zmienne name(przechowuje nazwe danego nadwozia) i cena(przechowuje koszt danego nadzwoia)
    //-metode typu INadwozie dodajNadwozie(), która pisze na konsoli rodzaj wybranego nadwozia oraz jego cene
    //-metode podajNazwę(), która zwraca nazwę nadwozia
    class Sedan : INadwozie
    {
        String name = "Sedan";
        double cena = 60000;

        public INadwozie dodajNadwozie()
        {
            Console.WriteLine("Nadwozie - " + name + " (cena: " + cena + " zł)\n");
            KonfiguratorSamochodów konfigurator = new KonfiguratorSamochodów();
            konfigurator.PodajKoszt += cena;
            return new Sedan();
        }

        public string podajNazwę()
        {

            return name;

        }


    }

    class Coupe : INadwozie
    {
        String name = "Coupe";
        double cena = 120000;
        public INadwozie dodajNadwozie()
        {
            Console.WriteLine("Nadwozie - " + name + " (cena: " + cena + " zł)\n");
            KonfiguratorSamochodów konfigurator = new KonfiguratorSamochodów();
            konfigurator.PodajKoszt += cena;
            return new Coupe();
        }

        public string podajNazwę()
        {

            return name;

        }
    }

    class Kombi : INadwozie
    {
        String name = "Kombi";
        double cena = 75000;
        public INadwozie dodajNadwozie()
        {
            Console.WriteLine("Nadwozie - " + name + " (cena: " + cena + " zł)\n");
            KonfiguratorSamochodów konfigurator = new KonfiguratorSamochodów();
            konfigurator.PodajKoszt += cena;
            return new Kombi();
        }

        public string podajNazwę()
        {

            return name;

        }
    }

    // Interfejs Silnik i klasy które dziedziczą po interfejsie Silnik
    interface ISilnik
    {
        ISilnik dodajSilnik();

        string podajNazwę();
    }

    class Diesel : ISilnik
    {
        String name = "Diesel";
        double cena = 50000;
        public ISilnik dodajSilnik()
        {
            Console.WriteLine("Silnik - " + name + " (cena: " + cena + " zł)\n");
            KonfiguratorSamochodów konfigurator = new KonfiguratorSamochodów();
            konfigurator.PodajKoszt += cena;
            return new Diesel();
        }

        public string podajNazwę()
        {

            return name;

        }
    }

    class Spalinowy : ISilnik
    {
        String name = "Benzynowy";
        double cena = 46000;
        public ISilnik dodajSilnik()
        {
            Console.WriteLine("Silnik - " + name + " (cena: " + cena + " zł)\n");
            KonfiguratorSamochodów konfigurator = new KonfiguratorSamochodów();
            konfigurator.PodajKoszt += cena;
            return new Spalinowy();
        }

        public string podajNazwę()
        {

            return name;

        }
    }

    class SpalinowyTurbo : ISilnik
    {
        String name = "Benzynowy z turbo";
        double cena = 80000;
        public ISilnik dodajSilnik()
        {
            Console.WriteLine("Silnik - " + name + " (cena: " + cena + " zł)\n");
            KonfiguratorSamochodów konfigurator = new KonfiguratorSamochodów();
            konfigurator.PodajKoszt += cena;
            return new SpalinowyTurbo();
        }

        public string podajNazwę()
        {

            return name;

        }
    }

    // Interfejs Skrzynia Biegów i klasy które dziedziczą po interfejsie Skrzynia Biegów
    interface ISkrzyniaBiegów
    {
        ISkrzyniaBiegów dodajSkrzyniaBiegów();

        string podajNazwę();
    }

    class Manual : ISkrzyniaBiegów
    {
        String name = "Manualna";
        double cena = 7000;
        public ISkrzyniaBiegów dodajSkrzyniaBiegów()
        {
            Console.WriteLine("Skrzynia biegów - " + name + " (cena: " + cena + " zł)\n");
            return new Manual();
        }

        public string podajNazwę()
        {

            return name;

        }
    }

    class Automat6Biegów : ISkrzyniaBiegów
    {
        String name = "Automatyczna 6-cio biegowa";
        double cena = 12000;
        public ISkrzyniaBiegów dodajSkrzyniaBiegów()
        {
            Console.WriteLine("Skrzynia biegów - " + name + " (cena: " + cena + " zł)\n");
            return new Automat6Biegów();
        }

        public string podajNazwę()
        {

            return name;

        }
    }

    class Automat8Biegów : ISkrzyniaBiegów
    {
        String name = "Automatyczna 8-mio biegowa";
        double cena = 21000;
        public ISkrzyniaBiegów dodajSkrzyniaBiegów()
        {
            Console.WriteLine("Skrzynia biegów - " + name + " (cena: " + cena + " zł)\n");
            KonfiguratorSamochodów konfigurator = new KonfiguratorSamochodów();
            konfigurator.PodajKoszt += cena;
            return new Automat8Biegów();
        }

        public string podajNazwę()
        {

            return name;

        }
    }

    // Interfejs Fotele i klasy które dziedziczą po interfejsie Fotele
    interface IFotele
    {
        IFotele dodajFotele();

        string podajNazwę();
    }

    class Sportowe : IFotele
    {
        String name = "Sportowe";
        double cena = 8000;
        public IFotele dodajFotele()

        {
            Console.WriteLine("Fotele - " + name + " (cena: " + cena + " zł)\n");
            KonfiguratorSamochodów konfigurator = new KonfiguratorSamochodów();
            konfigurator.PodajKoszt += cena;
            return new Sportowe();
        }

        public string podajNazwę()
        {

            return name;

        }
    }

    class Standardowe : IFotele
    {
        String name = "Standardowe";
        double cena = 2000;
        public IFotele dodajFotele()

        {
            Console.WriteLine("Fotele - " + name + " (cena: " + cena + " zł)\n");
            KonfiguratorSamochodów konfigurator = new KonfiguratorSamochodów();
            konfigurator.PodajKoszt += cena;
            return new Standardowe();
        }

        public string podajNazwę()
        {

            return name;

        }
    }

    class Luksusowe : IFotele
    {
        String name = "Luksusowe";
        double cena = 6500;
        public IFotele dodajFotele()

        {
            Console.WriteLine("Fotele - " + name + " (cena: " + cena + " zł)\n");
            KonfiguratorSamochodów konfigurator = new KonfiguratorSamochodów();
            konfigurator.PodajKoszt += cena;
            return new Luksusowe();
        }

        public string podajNazwę()
        {

            return name;

        }
    }

    // Interfejs Kolor i klasy które dziedziczą po interfejsie Kolor
    interface IKolor
    {
        IKolor dodajKolor();

        string podajNazwę();
    }

    class Czarny : IKolor
    {
        String name = "Czarny";
        double cena = 2000;
        public IKolor dodajKolor()

        {
            Console.WriteLine("Kolor samochodu - " + name + " (cena: " + cena + " zł)\n");
            KonfiguratorSamochodów konfigurator = new KonfiguratorSamochodów();
            konfigurator.PodajKoszt += cena;
            return new Czarny();
        }

        public string podajNazwę()
        {

            return name;

        }
    }

    class Czerwony : IKolor
    {
        String name = "Czerwony";
        double cena = 3500;
        public IKolor dodajKolor()

        {
            Console.WriteLine("Kolor samochodu - " + name + " (cena: " + cena + " zł)\n");
            KonfiguratorSamochodów konfigurator = new KonfiguratorSamochodów();
            konfigurator.PodajKoszt += cena;
            return new Czerwony();
        }

        public string podajNazwę()
        {

            return name;

        }
    }

    class Biały : IKolor
    {
        String name = "Biały";
        double cena = 2000;
        public IKolor dodajKolor()

        {
            Console.WriteLine("Kolor samochodu - " + name + " (cena: " + cena + " zł)\n");
            KonfiguratorSamochodów konfigurator = new KonfiguratorSamochodów();
            konfigurator.PodajKoszt += cena;
            return new Biały();
        }

        public string podajNazwę()
        {

            return name;

        }
    }

    // Interfejs Kolor Wnętrza i klasy które dziedziczą po interfejsie Kolor Wnętrza
    interface IKolorWnętrza
    {
        IKolorWnętrza dodajKolorWnętrza();

        string podajNazwę();
    }

    class PianoBlack : IKolorWnętrza
    {
        String name = "Piano Black";
        double cena = 3500;
        public IKolorWnętrza dodajKolorWnętrza()

        {
            Console.WriteLine("Wykończenie wnętrza samochodu - " + name + " (cena: " + cena + " zł)\n");
            return new PianoBlack();
        }

        public string podajNazwę()
        {

            return name;

        }
    }

    class Drewno : IKolorWnętrza
    {
        String name = "Drewno";
        double cena = 5000;
        public IKolorWnętrza dodajKolorWnętrza()

        {
            Console.WriteLine("Wykończenie wnętrza samochodu - " + name + " (cena: " + cena + " zł)\n");
            KonfiguratorSamochodów konfigurator = new KonfiguratorSamochodów();
            konfigurator.PodajKoszt += cena;
            return new Drewno();
        }

        public string podajNazwę()
        {

            return name;

        }
    }

    class Standard : IKolorWnętrza
    {
        String name = "Standardowe";
        double cena = 2000;
        public IKolorWnętrza dodajKolorWnętrza()

        {
            Console.WriteLine("Wykończenie wnętrza samochodu - " + name + " (cena: " + cena + " zł)\n");
            KonfiguratorSamochodów konfigurator = new KonfiguratorSamochodów();
            konfigurator.PodajKoszt += cena;
            return new Standard();
        }


        public string podajNazwę()
        {

            return name;

        }
    }

    // Interfejs Nagłośnienie i klasy które dziedziczą po interfejsie Nagłośnienie
    interface INagłośnienie
    {
        INagłośnienie dodajNagłośnienie();

        string podajNazwę();
    }

    class Bose : INagłośnienie
    {
        String name = "Bose";
        double cena = 6000;
        public INagłośnienie dodajNagłośnienie()

        {
            Console.WriteLine("Nagłośnienie typu - " + name + " (cena: " + cena + " zł)\n");
            KonfiguratorSamochodów konfigurator = new KonfiguratorSamochodów();
            konfigurator.PodajKoszt += cena;
            return new Bose();
        }

        public string podajNazwę()
        {

            return name;

        }
    }

    class BangandOlufsen : INagłośnienie
    {
        String name = "Bang and Olufsen";
        double cena = 9000;
        public INagłośnienie dodajNagłośnienie()

        {
            Console.WriteLine("Nagłośnienie typu - " + name + " (cena: " + cena + " zł)\n");
            KonfiguratorSamochodów konfigurator = new KonfiguratorSamochodów();
            konfigurator.PodajKoszt += cena;
            return new BangandOlufsen();
        }

        public string podajNazwę()
        {

            return name;

        }
    }

    class Podstawowe : INagłośnienie
    {
        String name = "Podstawowe";
        double cena = 1500;
        public INagłośnienie dodajNagłośnienie()

        {
            Console.WriteLine("Nagłośnienie typu - " + name + " (cena: " + cena + " zł)\n");
            KonfiguratorSamochodów konfigurator = new KonfiguratorSamochodów();
            konfigurator.PodajKoszt += cena;
            return new Podstawowe();
        }

        public string podajNazwę()
        {

            return name;

        }
    }

    // Interfejs Zegary i klasy które dziedziczą po interfejsie Zegary
    interface IZegary
    {
        IZegary dodajZegary();

        string podajNazwę();
    }

    class Analogowe : IZegary
    {
        String name = "Analogowe";
        double cena = 500;

        public IZegary dodajZegary()

        {
            Console.WriteLine("Zegary - " + name + " (cena: " + cena + " zł)\n");
            KonfiguratorSamochodów konfigurator = new KonfiguratorSamochodów();
            konfigurator.PodajKoszt += cena;
            return new Analogowe();
        }

        public string podajNazwę()
        {

            return name;

        }
    }

    class Cyfrowe : IZegary
    {
        String name = "Cyfrowe";
        double cena = 1500;
        public IZegary dodajZegary()

        {
            Console.WriteLine("Zegary - " + name + " (cena: " + cena + " zł)\n");
            KonfiguratorSamochodów konfigurator = new KonfiguratorSamochodów();
            konfigurator.PodajKoszt += cena;
            return new Cyfrowe();
        }

        public string podajNazwę()
        {

            return name;

        }
    }

    ////////////////////////////////////////////////////////////////////////////////////////////////
    //Klasy dziedziczące po interfejsie ElementyKonfiguracyjne
    //Te klasy definują możliwości wyborów poszczególnych rodzajów elementów konfiguracujnych
    //w zależności od wybranego typu samochodu
    //Części do samochdou AUDI 3
    //FabrykaPodzespołowAUDI3 posiada:
    //Zawiera metody np. wybierzNadwozie() typu INadwozie która umożliwia wybór rodzaju nadwozia w zależności od wybranego typu samochodu
    class FabrykaPodzespołowAUDI3 : ElementyKonfiguracyjne
    {
        public INadwozie wybierzNadwozie()
        {
            Console.WriteLine("Wybierz nadwozie:\n" + "\n" + "1. Sedan (60000zł)   2. Kombi (75000zł)");
            int zmienna = Convert.ToInt32(Console.ReadLine());
            switch (zmienna)
            {
                case 1:
                    return new Sedan();
                    break;
                case 2:
                    return new Kombi();
                    break;
                default:
                    break;
            }
            return null;
        }

        public ISilnik wybierzSilnik()
        {
            Console.WriteLine("Wybierz silnik:\n" + "\n" + "1. Benzynowy (46000zł)   2. Diesel (50000zł)");
            int zmienna = Convert.ToInt32(Console.ReadLine());
            switch (zmienna)
            {
                case 1:
                    return new Spalinowy();
                    break;
                case 2:
                    return new Diesel();
                    break;
                default:
                    break;
            }
            return null;
        }

        public ISkrzyniaBiegów wybierzSkrzynieBiegów()
        {
            Console.WriteLine("Wybierz skrzynię biegów:\n" + "\n" + "1. Manualna (7000zł)   2. Automatyczna 6-cio biegowa (12000zł)");
            int zmienna = Convert.ToInt32(Console.ReadLine());
            switch (zmienna)
            {
                case 1:
                    return new Manual();
                    break;
                case 2:
                    return new Automat6Biegów();
                    break;
                default:
                    break;
            }
            return null;
        }

        public IFotele wybierzFotele()
        {
            Console.WriteLine("Wybierz fotele:\n" + "\n" + "1. Standardowe (2000zł)   2. Luksusowe (6500zł)");
            int zmienna = Convert.ToInt32(Console.ReadLine());
            switch (zmienna)
            {
                case 1:
                    return new Standardowe();
                    break;
                case 2:
                    return new Luksusowe();
                    break;
                default:
                    break;
            }
            return null;
        }

        public IKolor wyberzKolor()
        {
            Console.WriteLine("Wybierz kolor lakieru:\n" + "\n" + "1. Czarny (2000zł)   2. Biały (2000zł)");
            int zmienna = Convert.ToInt32(Console.ReadLine());
            switch (zmienna)
            {
                case 1:
                    return new Czarny();
                    break;
                case 2:
                    return new Biały();
                    break;
                default:
                    break;
            }
            return null;
        }

        public IKolorWnętrza wybierzKolorWnętrza()
        {
            Console.WriteLine("Wybierz wykończenie wnętrza:\n" + "\n" + "1. Standardowe (2000zł)   2. Piano Black (3500zł)");
            int zmienna = Convert.ToInt32(Console.ReadLine());
            switch (zmienna)
            {
                case 1:
                    return new Standard();
                    break;
                case 2:
                    return new PianoBlack();
                    break;
                default:
                    break;
            }
            return null;
        }
        public INagłośnienie wybierzNagłośnienie()
        {
            Console.WriteLine("Wybierz nagłośnienie:\n" + "\n" + "1. Podstawowe (1500zł)   2. Bose (6000zł)");
            int zmienna = Convert.ToInt32(Console.ReadLine());
            switch (zmienna)
            {
                case 1:
                    return new Podstawowe();
                    break;
                case 2:
                    return new Bose();
                    break;
                default:
                    break;
            }
            return null;
        }
        public IZegary wybierzZegary()
        {
            Console.WriteLine("Wybierz zegary:\n" + "\n" + "1. Analogowe (500zł)   2. Cyfrowe (1500zł) ");
            int zmienna = Convert.ToInt32(Console.ReadLine());
            switch (zmienna)
            {
                case 1:
                    return new Analogowe();
                    break;
                case 2:
                    return new Cyfrowe();
                    break;
                default:
                    break;
            }
            return null;
        }
    }

    //Części do samochdou AUDI 4
    class FabrykaPodzespołowAUDI4 : ElementyKonfiguracyjne
    {
        public INadwozie wybierzNadwozie()
        {
            Console.WriteLine("Wybierz nadwozie:\n" + "\n" + "1. Sedan (60000zł)   2. Kombi (75000zł)");
            int zmienna = Convert.ToInt32(Console.ReadLine());
            switch (zmienna)
            {
                case 1:
                    return new Sedan();
                    break;
                case 2:
                    return new Kombi();
                    break;
                default:
                    break;
            }
            return null;

        }

        public ISilnik wybierzSilnik()
        {
            Console.WriteLine("Wybierz silnik:\n" + "\n" + "1. Benzynowy (46000zł)   2. Benzynowy z turbo (80000zł)   3. Diesel (50000zł)");
            int zmienna = Convert.ToInt32(Console.ReadLine());
            switch (zmienna)
            {
                case 1:
                    return new Spalinowy();
                    break;
                case 2:
                    return new SpalinowyTurbo();
                case 3:
                    return new Diesel();
                    break;
                default:
                    break;
            }
            return null;
        }

        public ISkrzyniaBiegów wybierzSkrzynieBiegów()
        {
            Console.WriteLine("Wybierz skrzynię biegów:\n" + "\n" + "1. Manualna (7000zł)   2. Automatyczna 8-mio biegowa (21000zł)");
            int zmienna = Convert.ToInt32(Console.ReadLine());
            switch (zmienna)
            {
                case 1:
                    return new Manual();
                    break;
                case 2:
                    return new Automat8Biegów();
                    break;
                default:
                    break;
            }
            return null;
        }

        public IFotele wybierzFotele()
        {
            Console.WriteLine("Wybierz fotele:\n" + "\n" + "1. Standardowe (2000zł)   2. Luksusowe (6500zł)   3. Sportowe (8000zł)");
            int zmienna = Convert.ToInt32(Console.ReadLine());
            switch (zmienna)
            {
                case 1:
                    return new Standardowe();
                    break;
                case 2:
                    return new Luksusowe();
                    break;
                case 3:
                    return new Sportowe();
                    break;
                default:
                    break;
            }
            return null;
        }

        public IKolor wyberzKolor()
        {
            Console.WriteLine("Wybierz kolor lakieru:\n" + "\n" + "1. Czarny (2000zł)   2. Biały (2000zł)");
            int zmienna = Convert.ToInt32(Console.ReadLine());
            switch (zmienna)
            {
                case 1:
                    return new Czarny();
                    break;
                case 2:
                    return new Biały();
                    break;
                default:
                    break;
            }
            return null;
        }

        public IKolorWnętrza wybierzKolorWnętrza()
        {
            Console.WriteLine("Wybierz wykończenie wnętrza:\n" + "\n" + "1. Standardowe (2000zł)   2. Piano Black (3500zł)   3. Drewno (5000zł)");
            int zmienna = Convert.ToInt32(Console.ReadLine());
            switch (zmienna)
            {
                case 1:
                    return new Standard();
                    break;
                case 2:
                    return new PianoBlack();
                    break;
                case 3:
                    return new Drewno();
                    break;
                default:
                    break;
            }
            return null;
        }
        public INagłośnienie wybierzNagłośnienie()
        {
            Console.WriteLine("Wybierz nagłośnienie:\n" + "\n" + "1. Podstawowe (1500zł)   2. Bose (6000zł)   3. Bang and Olufsen (9000zł)");
            int zmienna = Convert.ToInt32(Console.ReadLine());
            switch (zmienna)
            {
                case 1:
                    return new Podstawowe();
                    break;
                case 2:
                    return new Bose();
                    break;
                case 3:
                    return new BangandOlufsen();
                    break;
                default:
                    break;
            }
            return null;
        }
        public IZegary wybierzZegary()
        {
            Console.WriteLine("Wybierz zegary:\n" + "\n" + "1. Analogowe (500zł)   2. Cyfrowe (1500zł) ");
            int zmienna = Convert.ToInt32(Console.ReadLine());
            switch (zmienna)
            {
                case 1:
                    return new Analogowe();
                    break;
                case 2:
                    return new Cyfrowe();
                    break;
                default:
                    break;
            }
            return null;
        }
    }

    //Części do samochdou AUDI 5
    class FabrykaPodzespołowAUDI5 : ElementyKonfiguracyjne
    {
        public INadwozie wybierzNadwozie()
        {
            Console.WriteLine("Wybierz nadwozie:\n" + "\n" + "1. Sedan (60000zł)   2. Coupe (120000zł)");
            int zmienna = Convert.ToInt32(Console.ReadLine());
            switch (zmienna)
            {
                case 1:
                    return new Sedan();
                    break;
                case 2:
                    return new Coupe();
                    break;
                default:
                    break;
            }
            return null;
        }

        public ISilnik wybierzSilnik()
        {
            Console.WriteLine("Wybierz silnik:\n" + "\n" + "1. Benzynowy (46000zł)   2. Benzynowy z turbo (80000zł)");
            int zmienna = Convert.ToInt32(Console.ReadLine());
            switch (zmienna)
            {
                case 1:
                    return new Spalinowy();
                    break;
                case 2:
                    return new SpalinowyTurbo();
                    break;
                default:
                    break;
            }
            return null;
        }

        public ISkrzyniaBiegów wybierzSkrzynieBiegów()
        {
            Console.WriteLine("Wybierz skrzynię biegów:\n" + "\n" + "1. Automatyczna 6-cio biegowa (12000zł)   2. Automatyczna 8-mio biegowa (21000zł)");
            int zmienna = Convert.ToInt32(Console.ReadLine());
            switch (zmienna)
            {
                case 1:
                    return new Automat6Biegów();
                    break;
                case 2:
                    return new Automat8Biegów();
                    break;
                default:
                    break;
            }
            return null;
        }

        public IFotele wybierzFotele()
        {
            Console.WriteLine("Wybierz fotele:\n" + "\n" + "1. Luksusowe (6500zł)   2. Sportowe (8000zł)");
            int zmienna = Convert.ToInt32(Console.ReadLine());
            switch (zmienna)
            {
                case 1:
                    return new Luksusowe();
                    break;
                case 2:
                    return new Sportowe();
                default:
                    break;
            }
            return null;
        }

        public IKolor wyberzKolor()
        {
            Console.WriteLine("Wybierz kolor lakieru:\n" + "\n" + "1. Czarny (2000zł)   2. Biały (2000zł)   3. Czerwony (3500zł)");
            int zmienna = Convert.ToInt32(Console.ReadLine());
            switch (zmienna)
            {
                case 1:
                    return new Czarny();
                    break;
                case 2:
                    return new Biały();
                    break;
                case 3:
                    return new Czerwony();
                    break;
                default:
                    break;
            }
            return null;
        }

        public IKolorWnętrza wybierzKolorWnętrza()
        {
            Console.WriteLine("Wybierz wykończenie wnętrza:\n" + "\n" + "1. Piano Black (3500zł)   2. Drewno (5000zł)");
            int zmienna = Convert.ToInt32(Console.ReadLine());
            switch (zmienna)
            {
                case 1:
                    return new PianoBlack();
                    break;
                case 2:
                    return new Drewno();
                    break;
                default:
                    break;
            }
            return null;
        }
        public INagłośnienie wybierzNagłośnienie()
        {
            Console.WriteLine("Wybierz nagłośnienie:\n" + "\n" + "1. Bose (6000zł)   2. Bang and Olufsen (9000zł)");
            int zmienna = Convert.ToInt32(Console.ReadLine());
            switch (zmienna)
            {
                case 1:
                    return new Bose();
                    break;
                case 2:
                    return new BangandOlufsen();
                    break;
                default:
                    break;
            }
            return null;
        }
        public IZegary wybierzZegary()
        {
            Console.WriteLine("Wybierz zegary:\n" + "\n" + "1. Analogowe (500zł)   2. Cyfrowe (1500zł) ");
            int zmienna = Convert.ToInt32(Console.ReadLine());
            switch (zmienna)
            {
                case 1:
                    return new Analogowe();
                    break;
                case 2:
                    return new Cyfrowe();
                    break;
                default:
                    return null;
                    break;
            }

        }
    }

    //////////////////////////////////////////////////////////////////////////////////////////////
    //Tworzenie abstrakcyjnego samochodu
    //Posiada zmienne chronione (dostępne tylko w tej klasie) typu np INadwozie,
    //do których, będą przypisywane wubierane elemety konfiguracyjne
    //Posiada metodę abstarct  void skladanie(), która umożliwi składanie samochodu
    //Posiada metodę samochódzłożony(), która wyświetla elementy już złożonego samochodu
    abstract class Samochód
    {
        protected INadwozie nadwozie;
        protected ISilnik silnik;
        protected ISkrzyniaBiegów skrzyniaBiegów;
        protected IFotele fotele;
        protected IKolor kolor;
        protected IKolorWnętrza kolorWnętrza;
        protected INagłośnienie nagłośnienie;
        protected IZegary zegary;

        public abstract void skladanie();



        public void samochódzłożony()
        {
            Console.WriteLine("Nadwozie - " + nadwozie.podajNazwę());
            Console.WriteLine("Silnik - " + silnik.podajNazwę());
            Console.WriteLine("Skrzynia biegów - " + skrzyniaBiegów.podajNazwę());
            Console.WriteLine("Fotele - " + fotele.podajNazwę());
            Console.WriteLine("Kolor samochodu - " + kolor.podajNazwę());
            Console.WriteLine("Kolor wnętrza - " + kolorWnętrza.podajNazwę());
            Console.WriteLine("Rodzaj nagłośnienia - " + nagłośnienie.podajNazwę());
            Console.WriteLine("Zegary - " + zegary.podajNazwę());

        }

    }

    //////////////////////////////////////////////////////////////////////////////////////////////////
    //Konfigurowanie samochodu 
    //Klasa KonfiguratorSamochodów zwraca złożony samochód posiada:
    //Zmienną kosztCaly, która przechowuje koszt składanego samochodu
    //Metodę PodajKoszt, która ustawia i zwraca koszt samochodu
    //Metodę typu Samochód wydajSamochód, która zwraca złożony samochód
    //Samochód zlozSamochód umożliwia złożenie samochodu w zależności od wyboru modelu
    class KonfiguratorSamochodów
    {
        static double kosztCaly = 0.0;

        public double PodajKoszt
        {
            get { return kosztCaly; }
            set { kosztCaly = value; }
        }

        public Samochód wydajSamochód(String model)
        {
            Samochód samochód = zlozSamochód(model);
            samochód.samochódzłożony();
            return samochód;
        }

        protected Samochód zlozSamochód(String model)
        {
            Samochód samochód = null;
            if (model.Equals("1"))
            {
                samochód = new Audi3(new FabrykaPodzespołowAUDI3());
                Console.WriteLine("\n" + "\n" + "\n");
                Console.WriteLine("Zamówiony samochód to:");
                Console.WriteLine("Model - Audi A3");
            }
            else if (model.Equals("2"))
            {
                samochód = new Audi4(new FabrykaPodzespołowAUDI4());
                Console.WriteLine("\n" + "\n" + "\n");
                Console.WriteLine("Zamówiony samochód to:");
                Console.WriteLine("Model - Audi A4");
            }
            else if (model.Equals("3"))
            {
                samochód = new Audi5(new FabrykaPodzespołowAUDI5());
                Console.WriteLine("\n" + "\n" + "\n");
                Console.WriteLine("Zamówiony samochód to:");
                Console.WriteLine("Model - Audi A5");
            }
            return samochód;
        }
    }

    /////////////////////////////////////////////////////////////////////////////////////////////////
    //Klasy konkretnych modeli samochodów dziedziczące po klasie samochód
    //Tutaj konkretnie odbywa się składanie pojazdu
    //Klasa Audi 3
    class Audi3 : Samochód
    {
        ElementyKonfiguracyjne elementyKonfiguracyjne;

        public Audi3(ElementyKonfiguracyjne Audi3)
        {
            elementyKonfiguracyjne = Audi3;
            skladanie();
        }

        public override void skladanie()
        {
            nadwozie = elementyKonfiguracyjne.wybierzNadwozie().dodajNadwozie();
            silnik = elementyKonfiguracyjne.wybierzSilnik().dodajSilnik();
            skrzyniaBiegów = elementyKonfiguracyjne.wybierzSkrzynieBiegów().dodajSkrzyniaBiegów();
            fotele = elementyKonfiguracyjne.wybierzFotele().dodajFotele();
            kolor = elementyKonfiguracyjne.wyberzKolor().dodajKolor();
            kolorWnętrza = elementyKonfiguracyjne.wybierzKolorWnętrza().dodajKolorWnętrza();
            nagłośnienie = elementyKonfiguracyjne.wybierzNagłośnienie().dodajNagłośnienie();
            zegary = elementyKonfiguracyjne.wybierzZegary().dodajZegary();
        }
    }

    //Klasa Audi 4
    class Audi4 : Samochód
    {
        ElementyKonfiguracyjne elementyKonfiguracyjne;

        public Audi4(ElementyKonfiguracyjne Audi4)
        {
            elementyKonfiguracyjne = Audi4;
            skladanie();
        }

        public override void skladanie()
        {
            nadwozie = elementyKonfiguracyjne.wybierzNadwozie().dodajNadwozie();
            silnik = elementyKonfiguracyjne.wybierzSilnik().dodajSilnik();
            skrzyniaBiegów = elementyKonfiguracyjne.wybierzSkrzynieBiegów().dodajSkrzyniaBiegów();
            fotele = elementyKonfiguracyjne.wybierzFotele().dodajFotele();
            kolor = elementyKonfiguracyjne.wyberzKolor().dodajKolor();
            kolorWnętrza = elementyKonfiguracyjne.wybierzKolorWnętrza().dodajKolorWnętrza();
            nagłośnienie = elementyKonfiguracyjne.wybierzNagłośnienie().dodajNagłośnienie();
            zegary = elementyKonfiguracyjne.wybierzZegary().dodajZegary();

        }
    }

    //Klasa Audi 5
    class Audi5 : Samochód
    {
        ElementyKonfiguracyjne elementyKonfiguracyjne;

        public Audi5(ElementyKonfiguracyjne Audi5)
        {
            elementyKonfiguracyjne = Audi5;
            skladanie();
        }

        public override void skladanie()
        {
            nadwozie = elementyKonfiguracyjne.wybierzNadwozie().dodajNadwozie();
            silnik = elementyKonfiguracyjne.wybierzSilnik().dodajSilnik();
            skrzyniaBiegów = elementyKonfiguracyjne.wybierzSkrzynieBiegów().dodajSkrzyniaBiegów();
            fotele = elementyKonfiguracyjne.wybierzFotele().dodajFotele();
            kolor = elementyKonfiguracyjne.wyberzKolor().dodajKolor();
            kolorWnętrza = elementyKonfiguracyjne.wybierzKolorWnętrza().dodajKolorWnętrza();
            nagłośnienie = elementyKonfiguracyjne.wybierzNagłośnienie().dodajNagłośnienie();
            zegary = elementyKonfiguracyjne.wybierzZegary().dodajZegary();

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            KonfiguratorSamochodów auto1 = new KonfiguratorSamochodów();
            Console.WriteLine("\nWitamy w konfiguratorze samochodów marki AUDI\n" + "\n" + "Instrukcja obsługi: " + "\n" + "Konfiguracji dokonuj wpisując przypisaną do wybieranego elementu liczbę, a następnie zatwierdzając enterem" + "\nWybierz model:\n\n1. Audi A3   2. Audi A4   3. Audi A5");
            auto1.wydajSamochód(Console.ReadLine());
            Console.WriteLine("\nCałkowity koszt skonfigurowanego pojazdu wynosi " + auto1.PodajKoszt + "zł");
            Console.ReadKey();
        }
    }
}
