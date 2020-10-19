﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErwCSharp_3_StructsUndEnums
{

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
    }
    class Program
    {
        static void Main(string[] args)
        {
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