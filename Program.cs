using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ErwCSharp_3_StructsUndEnums
{
    //enums sind sammlung von Konstanten
    enum Day { Mo,Tu,We,Th,Fr,Sa,Su }
    // "Herausforderung" erstelle ein Enum von Monaten.... DAS SOLL EIN WITZ SEIN!!
    enum Month { Jan =1,Feb,Mar,Apr,May,Jun,Jul,Aug,Sep,Oct,Nov,Dec}
    // so werden alle mmonate automatisch +1 sein und damit die richtige Monat-Zahl bekommen
    // weitere änderungen werden so übernommen. wenn Mai anstatt 5 auf 25 setzen, dan wid Juni 26, Juli 27...
    struct Game
    {
        public string name;
        public string developer;
        public double rating;
        public DateTime releaseDate;    //selber erweiterung

        //kann auch Methoden haben
         public void DisplayInfo()
        {
            Console.WriteLine($"Game1 heißt {this.name}, wurde entwickelt von {this.developer}, \nreleased in {this.releaseDate:d} und bewertet mit {this.rating} Sterne");
            // DateTime :d für short date format
            //ausgeben, wird in methode umgepackt, mit this anstatt Instanzname (oder einfach leer lassen.
        }

        //die Structs dürfen kein default Konstruktoren haben!!
        //public Game()
        //{

        //}

        //Sie dürfen Konstruktoren haben nur wenn sie ALLE Eigenschaften gesetzt werden
        public Game( string name,string developer, double rating, DateTime releaseDate)
        {
            this.name = string.Empty;
            this.developer = string.Empty;
            this.rating = 0;
            this.releaseDate = DateTime.Now;

        }

        // EINE KLASSE IST EIN POINTER TYPE, EIN STRUCT IST EIN VALUE TYPE.
        // das heißt, dass ein Objekt  von eine Klasse immer auf ein Wert REFERENZIERT
        // und ein Struct ist den Wert selber.
        // https://www.lernmoment.de/csharp-programmieren/kombinierte-formatierung-fuer-konsole-datei/
        // wieder nicht richtig erklärt...
    }
    class Program
    {
        static void Main(string[] args)
        {
            //ENUMS
            Day fr = Day.Fr;
            Day su = Day.Su;
            Day a = Day.Fr;
            //Fr hat interner Wert 4,  Su, hat 6...  das  benötigen aber eigentlich nicht
            Console.WriteLine(fr == a);//true, a und fr sind beide Fr (friday)
            Console.WriteLine(Day.Mo);
            Console.WriteLine((int)Day.Mo); //0 Monday Enum as integer gecasted,zeigt 0...toll
            Console.WriteLine();
            Console.WriteLine();

            // "Herausforderung" erstelle ein Enum von Monaten.... DAS SOLL EIN WITZ SEIN!!
            Month monat = Month.Jan;
            //Console.WriteLine(monat);
            for (int i = 1; i < 13 ; i++)
            {
                monat = (Month)i;
                Console.WriteLine(monat);  
            }
            Console.WriteLine();
            Console.WriteLine();

            //STRUCTS
            Game game1;
            //einfache Deklaration
            
            //werte setzen
            game1.name = "PokemonGO";
            game1.developer = "Niantic";
            game1.rating = 3.5;
            game1.releaseDate = Convert.ToDateTime("01.07.2016");

            Game x;
            x.name = string.Empty;
            x.developer = string.Empty;
            x.rating = 0;
            x.releaseDate = DateTime.Now;

            //ausgeben, wird in methode umgepackt
            //Console.WriteLine($"Game1 heißt {game1.name}, wurde entwickelt von {game1.developer}, released in {game1.releaseDate:d} und bewertet mit {game1.rating} Sterne");
            //                                                                                                    // DateTime :d für short date format
            game1.DisplayInfo();
            Console.ReadKey();
        }
    }
}
