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
    class Spieltisch
    {
        // Member
        private KI[] kiSpieler = null;
        private Spieler reSpieler = null;

        // Felder
        private int aktWurf;
        private string aktFarbe;

        // Eigenschaften
        internal KI[] KiSpieler 
        {
            get => kiSpieler;

            set
            {
                if (value != null && value.Length == 11) kiSpieler = value;
                else
                {
                    for(int i = 0; i < 10; i++)
                    kiSpieler[i] = new KI();
                }
            }
        }
        internal Spieler ReSpieler
        {
            get => reSpieler;

            set
            {
                if (value != null) reSpieler = value;
                else reSpieler = new Spieler();
            }
        }
        public int AktWurf
        {
            get => aktWurf;

            set
            {
                if (value < 36 && value > 0) aktWurf = value;
                else aktWurf = -1;
            }
        }
        public string AktFarbe
        {
            get => aktFarbe;

            set
            {
                if (value == "sw" || value == "rt" || value == "grn") aktFarbe = value;
                else aktFarbe = "fehler";
            }
        }

        //Methoden
        public int lassRollen()
        {
            Random kugel = new Random();     //Initialiseren des Zufallsgeneratorobjektes
            int ans = -1;
            ans = kugel.Next(37, 0);        //Zahlen von 0 bis einschließlich 36
            return ans;
        
        }
    }
}
