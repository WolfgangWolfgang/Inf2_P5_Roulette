using System;
using System.Collections.Generic;
using System.Text;

namespace Inf2_P5_Roulette
{
    /*
     * Wettart              I   Gewinnquote     I      Höchsteinsatz   I    Höchstgewinn
    -----------------------------------------------------------------------------------
       Einfache Chancen     I    1:1            I        12.000€        I       12.000€
       Dutzende, Kolonnen   I    2:1            I         6.000€        I       12.000€
       Transversale simple  I    5:1            I         2.400€        I       12.000€
       Carré                I    8:1            I         1.500€        I       12.000€
       Transversale pleine  I    11:1           I         1.100€        I       12.100€
       Cheval               I    17:1           I           700€        I       11.900€
       Plein                I    35:1           I           350€        I       12.250€
     */

    class Spielobjekt
    {
        // Felder
        private uint credits;

        // Eigenschaften
        public uint Credits { get => credits; set => credits = value; }

        // Konstruktoren
        public Spielobjekt()
        {
            Credits = 12000;
        }

        /// <summary>
        /// Ermittelt die farbe der Aktuellen Zahl, indem die Hälfte der Zahl mit Nachkommastelle, 
        /// mit der Hälfter der Zahl ohne Nachkommastelle verglichen wird. Kommt 0.5 raus ist die Zahl ungerade!!!
        /// </summary>
        /// <param name="zahl">Ergebnis des aktuellen Wurfes</param>
        /// <returns>Ermittelte Farbe</returns>
        public string getFarbe(double zahl)
        {
            string farbe;
            if (zahl == 0) farbe = "grn";
            else
            {
                double ans = zahl * 0.5;
                double truncated = Math.Truncate(ans);
                double nachkomma = ans - truncated;
                if (nachkomma == 0.5) farbe = "sw";
                else farbe = "rt";
            }
            return farbe;
        }

        //Methoden für Zahlbestimmung
        public virtual int [] zahlEinfachChance(string farbe)
        {
            int[] gewinnZahlen = null;
            switch (farbe)
            {
                case "sw":
                    gewinnZahlen = new int[18] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35 };
                    break;

                case "rt":
                    gewinnZahlen = new int[18] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36 };
                    break;
            }
            return gewinnZahlen;
        }
        public virtual int [] zahlDutzende(uint welchesDutzend)
        {
            int[] gewinnZahlen = null;
            switch (welchesDutzend)
            {
                case 1:
                    gewinnZahlen = new int[12] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
                    break;

                case 2:
                    gewinnZahlen = new int[12] { 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };
                    break;

                case 3:
                    gewinnZahlen = new int[12] { 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36 };
                    break;
            }
            return gewinnZahlen;
        }
        public virtual int [] zahlKolonnen(uint welcheKolonne)
        {
           int[] gewinnZahlen = null;
           switch (welcheKolonne)
           {
                case 1:
                    gewinnZahlen = new int[12] { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };
                    break;

                case 2:
                    gewinnZahlen = new int[12] { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 };
                    break;

                case 3:
                    gewinnZahlen = new int[12] { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 };
                    break;
           }
            return gewinnZahlen;
        }
        public virtual int [] zahlTransversaleSimple(uint welcheTransSimp)
        {
            int[] gewinnZahlen = null;
            switch (welcheTransSimp)
            {
                case 1:
                    gewinnZahlen = new int[6] { 1, 2, 3, 4, 5, 6 };
                    break;

                case 2:
                    gewinnZahlen = new int[6] { 7, 8, 9, 10, 11, 12 };
                    break;

                case 3:
                    gewinnZahlen = new int[6] { 13, 14, 15, 16, 17, 18 };
                    break;

                case 4:
                    gewinnZahlen = new int[6] { 19, 20, 21, 22, 23, 24 };
                    break;

                case 5:
                    gewinnZahlen = new int[6] { 25, 26, 27, 28, 29, 30 };
                    break;

                case 6:
                    gewinnZahlen = new int[6] { 31, 32, 33, 34, 35, 36 };
                    break;

                case 7:
                    gewinnZahlen = new int[6] { 4, 5, 6, 7, 8, 9 };
                    break;

                case 8:
                    gewinnZahlen = new int[6] { 10, 11, 12, 13, 14, 15 };
                    break;

                case 9:
                    gewinnZahlen = new int[6] { 16, 17, 18, 19, 20, 21 };
                    break;

                case 10:
                    gewinnZahlen = new int[6] { 22, 23, 24, 25, 26, 27 };
                    break;

                case 11:
                    gewinnZahlen = new int[6] { 28, 29, 30, 31, 32, 33 };
                    break;

                default:
                    gewinnZahlen = new int[6] { -1,-1,-1,-1,-1,-1 };
                    break;
            }
            return gewinnZahlen;
        }
        public virtual int [] zahlCarre(uint welcheCarre)
        {
            int[] gewinnZahlen = null;
            switch (welcheCarre)
            {
                case 1:
                    gewinnZahlen = new int[4] { 0, 1, 2, 3 };
                    break;

                case 2:
                    gewinnZahlen = new int[4] { 1, 2, 4, 5 };
                    break;

                case 3:
                    gewinnZahlen = new int[4] { 2, 3, 5, 6 };
                    break;

                case 4:
                    gewinnZahlen = new int[4] { 7, 8, 10, 11 };
                    break;

                case 5:
                    gewinnZahlen = new int[4] { 8, 9, 11, 12 };
                    break;

                case 6:
                    gewinnZahlen = new int[4] { 10, 11, 13, 14 };
                    break;

                case 7:
                    gewinnZahlen = new int[4] { 11, 12, 14, 15 };
                    break;

                case 8:
                    gewinnZahlen = new int[4] { 13, 14, 16, 17 };
                    break;

                case 9:
                    gewinnZahlen = new int[4] { 14, 15, 17, 18 };
                    break;

                case 10:
                    gewinnZahlen = new int[4] { 16, 17, 19, 20 };
                    break;

                case 11:
                    gewinnZahlen = new int[4] { 17, 18, 20, 21 };
                    break;

                case 12:
                    gewinnZahlen = new int[4] { 19, 20, 22, 23 };
                    break;

                case 13:
                    gewinnZahlen = new int[4] { 20, 21, 23, 24 };
                    break;

                case 14:
                    gewinnZahlen = new int[4] { 22, 23, 25, 26 };
                    break;

                case 15:
                    gewinnZahlen = new int[4] { 23, 24, 26, 27 };
                    break;

                case 16:
                    gewinnZahlen = new int[4] { 25, 26, 28, 29 };
                    break;

                case 17:
                    gewinnZahlen = new int[4] { 26, 27, 29, 30 };
                    break;

                case 18:
                    gewinnZahlen = new int[4] { 28, 29, 31, 32 };
                    break;

                case 19:
                    gewinnZahlen = new int[4] { 29, 30, 32, 33 };
                    break;

                case 20:
                    gewinnZahlen = new int[4] { 31, 32, 34, 35};
                    break;

                case 21:
                    gewinnZahlen = new int[4] { 32, 33, 35, 36 };
                    break;

                default:
                    gewinnZahlen = new int[4] { -1, -1, -1, -1 };
                    break;
            }
            return gewinnZahlen;
        }
        public virtual int [] zahlTransversalePlein(uint welcheTransPlein)
        {
            int[] gewinnZahlen = null;
            switch (welcheTransPlein)
            {
                case 1:
                    gewinnZahlen = new int[3] { 0, 1, 2};
                    break;

                case 2:
                    gewinnZahlen = new int[3] { 0, 2, 3 };
                    break;

                case 3:
                    gewinnZahlen = new int[3] { 1, 2, 3 };
                    break;

                case 4:
                    gewinnZahlen = new int[3] { 4, 5, 6 };
                    break;

                case 5:
                    gewinnZahlen = new int[3] { 7, 8, 9 };
                    break;

                case 6:
                    gewinnZahlen = new int[3] { 10, 11, 12 };
                    break;

                case 7:
                    gewinnZahlen = new int[3] { 13, 14, 15 };
                    break;

                case 8:
                    gewinnZahlen = new int[3] { 16, 17, 18 };
                    break;

                case 9:
                    gewinnZahlen = new int[3] { 19, 20, 21 };
                    break;

                case 10:
                    gewinnZahlen = new int[3] { 22, 23, 24 };
                    break;

                case 11:
                    gewinnZahlen = new int[3] { 25, 26, 27 };
                    break;

                case 12:
                    gewinnZahlen = new int[3] { 28, 29, 30 };
                    break;

                case 13:
                    gewinnZahlen = new int[3] { 31, 32, 33 };
                    break;

                case 14:
                    gewinnZahlen = new int[3] { 34, 35, 36 };
                    break;
            }
            return gewinnZahlen;
        }
        // Cheval direkt bestimmen!!!
                                         /* public virtual int [] zahlCheval(uint welcheCheval)
        {
            int[] gewinnZahlen = null;
            switch (welcheCheval)
            {
                case 1:

                    break;

                case 2:

                    break;

                case 3:

                    break;

                case 4:

                    break;

                case 5:

                    break;

                case 6:

                    break;

                case 7:

                    break;

                case 8:

                    break;

                case 9:

                    break;

                case 10:

                    break;

                case 11:

                    break;

                case 12:

                    break;

                case 13:

                    break;

                case 14:

                    break;

                case 15:

                    break;

                case 16:

                    break;
            }
            return gewinnZahlen;
        }*/
        // Plein direkt bestimmen!!!

        // Methoden für Gewinnbestimmung
        public virtual int gewinnEinfacheChance(int einsatz)
        {
            int gewinn = einsatz + einsatz;
            return gewinn;
        }
        public virtual int gewinnDutzende(int einsatz)
        {
            int gewinn = einsatz * 2 + einsatz;
            return gewinn;
        }
        public virtual int gewinnKolonnen(int einsatz)
        {
            int gewinn = einsatz * 2 + einsatz;
            return gewinn;
        }
        public virtual int gewinnTransversaleSimple(int einsatz)
        {
            int gewinn = einsatz * 5 + einsatz;
            return gewinn;
        }
        public virtual int gewinnCarre(int einsatz)
        {
            int gewinn = einsatz * 8 + einsatz;
            return gewinn;
        }
        public virtual int gewinnTransversalePlein(int einsatz)
        {
            int gewinn = einsatz * 11 + einsatz;
            return gewinn;
        }
        public virtual int gewinnCheval(int einsatz)
        {
            int gewinn = einsatz * 17 + einsatz;
            return gewinn;
        }
        public virtual int gewinnPlein(int einsatz)
        {
            int gewinn = einsatz * 35 + einsatz;
            return gewinn;
        }
    }
}
