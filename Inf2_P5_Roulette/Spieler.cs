/* Informatik 2 Praktikum 5: C# Casino-Roulette (vereinfacht)
    Autor:               Mathis Rathjen
    Mat-#:               1085895
    geschrieben am:       13.06.2021
    zuletzt geändert:      
 */


using System;
using System.Collections.Generic;
using System.Text;

namespace Inf2_P5_Roulette
{
    class Spieler : Spielobjekt
    {
        // Felder
        private string playerName;
        

        // Eigenschaften
        public string PlayerName { get => playerName; set => playerName = value; }
        

        // Konstruktoren
        /// <summary>
        /// Defaultkonstruktor
        /// </summary>
        public Spieler()
        {
            PlayerName = "unnamed";
            Credits = 12000;
        }

        /// <summary>
        /// Main-Konstruktor
        /// </summary>
        /// <param name="name">Name des Realen Splielers</param>
        public Spieler(string name)
        {
            PlayerName = name;
            Credits = 12000;
        }

       
    }
}
