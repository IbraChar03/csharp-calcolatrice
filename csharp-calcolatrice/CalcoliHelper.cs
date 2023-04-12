using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_calcolatrice
{
    internal class CalcoliHelper
    {
        public static int SommaNumeriInt(int num1, int num2)
        {
            int somma =  num1 + num2;
            return somma;
        }
        public static double SommaNumeriDouble(double num1, double num2)
        {
            double somma = num1 + num2;
            return somma;
        }
        public static int DifferenzaNumeriInt(int num1, int num2)
        {
            int differenza = num1 - num2;
            return differenza;
        }
        public static double DifferenzaNumeriDouble(double num1, double num2)
        {
            double differenza = num1 - num2;
            return differenza;
        }
        public static int MoltiplicazioneNumeriInt(int num1, int num2)
        {
            int moltiplicazione = num1 * num2;
            return moltiplicazione;
        }
        public static double MoltiplicazioneNumeriDouble(double num1, double num2)
        {
            double moltiplicazione = num1 * num2;
            return moltiplicazione;
        }
    }
}
