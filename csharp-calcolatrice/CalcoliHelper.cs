using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_calcolatrice
{
    internal class CalcoliHelper
    {
        public static int SommaNumeri(int num1, int num2)
        {
            int somma =  num1 + num2;
            return somma;
        }
        public static double SommaNumeri(double num1, double num2)
        {
            double somma = num1 + num2;
            return somma;
        }
        public static int DifferenzaNumeri(int num1, int num2)
        {
            int differenza = num1 - num2;
            return differenza;
        }
        public static double DifferenzaNumeri(double num1, double num2)
        {
            double differenza = num1 - num2;
            return differenza;
        }
        public static int MoltiplicazioneNumeri(int num1, int num2)
        {
            int moltiplicazione = num1 * num2;
            return moltiplicazione;
        }
        public static double MoltiplicazioneNumeri(double num1, double num2)
        {
            double moltiplicazione = num1 * num2;
            return Math.Round(moltiplicazione,2);
        }
        public static int ValAssoluto(int num)
        {
            return Math.Abs(num);
        }
        public static double ValAssoluto(double num)
        {
            return Math.Abs(num);
        }
        public static int MinNum(int num1,int num2)
        {
            return Math.Min(num1,num2);
        }
        public static double MinNum(double num1,double num2)
        {
            return Math.Min(num1, num2);
        }
        public static int MaxNum(int num1, int num2)
        {
            return Math.Max(num1, num2);
        }
        public static double MaxNUm(double num1, double num2)
        {
            return Math.Max(num1, num2);
        }
        //overloading
    }
}
